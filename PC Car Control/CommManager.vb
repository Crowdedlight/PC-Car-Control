Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Drawing
Imports System.IO.Ports
Imports System.Windows.Forms

Public Class CommManager

#Region "Manager Enums"
    ''' enumeration to hold our transmission types
    Public Enum TransmissionType
        Text
        Hex
    End Enum

    ''' enumeration to hold our message types
    Public Enum MessageType
        Incoming
        Outgoing
        Normal
        Warning
        [Error]
    End Enum
#End Region

#Region "Manager Variables"
    'property variables
    Private _baudRate As String = String.Empty
    Private _stopBits As String = String.Empty
    Private _dataBits As String = String.Empty
    Private _portName As String = String.Empty
    Private _transType As TransmissionType
    Private _displayWindow As RichTextBox
    Private _Speedbar As ProgressBar
    Private _ErrorLight As PictureBox
    Private _LapCounter As TextBox
    Private _msg As String
    Private _type As MessageType
    'global manager variables
    Private MessageColor As Color() = {Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red}
    Private comPort As New SerialPort()
    Private write As Boolean = True

    'Error variables
    Private ErrormsgStr As String = String.Empty
    'LapCount variables
    Private LapStr As String = String.Empty
    'motor speed
    Private speedint As String = String.Empty
#End Region

#Region "Class Properties"
    ''' property to hold the StopBits
    ''' of our manager class
    Public Property StopBits() As String
        Get
            Return _stopBits
        End Get
        Set(ByVal value As String)
            _stopBits = value
        End Set
    End Property

    ''' property to hold the DataBits
    ''' of our manager class
    Public Property DataBits() As String
        Get
            Return _dataBits
        End Get
        Set(ByVal value As String)
            _dataBits = value
        End Set
    End Property

    ''' property to hold the PortName
    ''' of our manager class
    Public Property PortName() As String
        Get
            Return _portName
        End Get
        Set(ByVal value As String)
            _portName = value
        End Set
    End Property

    ''' property to hold our TransmissionType
    ''' of our manager class
    Public Property CurrentTransmissionType() As TransmissionType
        Get
            Return _transType
        End Get
        Set(ByVal value As TransmissionType)
            _transType = value
        End Set
    End Property

    ''' property to hold our display window
    ''' value
    Public Property DisplayWindow() As RichTextBox
        Get
            Return _displayWindow
        End Get
        Set(ByVal value As RichTextBox)
            _displayWindow = value
        End Set
    End Property

    ''' Property to hold Motorspeed progressbar value
    Public Property SpeedBar() As ProgressBar
        Get
            Return _Speedbar
        End Get
        Set(ByVal value As ProgressBar)
            _Speedbar = value
        End Set
    End Property

    ''' Property to hold ErrorLight value
    Public Property ErrorLight() As PictureBox
        Get
            Return _ErrorLight
        End Get
        Set(ByVal value As PictureBox)
            _ErrorLight = value
        End Set
    End Property

    ''' Property to hold Lapcounter label value
    Public Property LapCounter() As TextBox
        Get
            Return _LapCounter
        End Get
        Set(ByVal text As TextBox)
            _LapCounter = text
        End Set
    End Property

    ''' Property to hold the message being sent
    ''' through the serial port
    Public Property Message() As String
        Get
            Return _msg
        End Get
        Set(ByVal value As String)
            _msg = value
        End Set
    End Property

    ''' Message to hold the transmission type
    Public Property Type() As MessageType
        Get
            Return _type
        End Get
        Set(ByVal value As MessageType)
            _type = value
        End Set
    End Property
#End Region

#Region "Manager Properties"
    ''' <summary>
    ''' Property to hold the BaudRate
    ''' of our manager class
    ''' </summary>
    Public Property BaudRate() As String
        Get
            Return _baudRate
        End Get
        Set(ByVal value As String)
            _baudRate = value
        End Set
    End Property

#End Region

#Region "Manager Constructors"
    ''' Constructor to set the properties of our Manager Class
    ''' <param name="baud">Desired BaudRate</param>
    ''' <param name="par">Desired Parity</param>
    ''' <param name="sBits">Desired StopBits</param>
    ''' <param name="dBits">Desired DataBits</param>
    ''' <param name="name">Desired PortName</param>
    Public Sub New(ByVal baud As String, ByVal par As String, ByVal sBits As String, ByVal dBits As String, ByVal name As String, ByVal rtb As RichTextBox, ByVal spdbar As ProgressBar, ByVal lapctn As TextBox, ByVal ErrBox As PictureBox)
        _baudRate = baud
        _stopBits = sBits
        _dataBits = dBits
        _portName = name
        _displayWindow = rtb
        _Speedbar = spdbar
        _ErrorLight = ErrBox
        _LapCounter = lapctn
        'now add an event handler
        AddHandler comPort.DataReceived, AddressOf comPort_DataReceived
    End Sub

    ''' Comstructor to set the properties of our
    ''' serial port communicator to nothing
    Public Sub New()
        _baudRate = String.Empty
        _stopBits = String.Empty
        _dataBits = String.Empty
        _portName = "COM1"
        _displayWindow = Nothing
        _Speedbar = Nothing
        _ErrorLight = Nothing
        _LapCounter = Nothing
        'add event handler
        AddHandler comPort.DataReceived, AddressOf comPort_DataReceived
    End Sub
#End Region

#Region "WriteData"
    Public Sub WriteData(ByVal msg As String)
        Select Case CurrentTransmissionType
            Case TransmissionType.Text
                'first make sure the port is open
                'if its not open then open it
                If Not (comPort.IsOpen = True) Then
                    comPort.Open()
                End If
                'send the message to the port
                comPort.Write(msg)
                'display the message
                _type = MessageType.Outgoing
                _msg = msg + "" + Environment.NewLine + ""
                DisplayData(_type, _msg)
                Exit Select
            Case TransmissionType.Hex
                Try
                    'convert the message to byte array
                    Dim newMsg As Byte() = HexToByte(msg)
                    'Determine if we are goint
                    'to write the byte data to the screen
                    If Not write Then
                        DisplayData(_type, _msg)
                        Exit Sub
                    End If
                    'send the message to the port
                    comPort.Write(newMsg, 0, newMsg.Length)
                    'convert back to hex and display
                    _type = MessageType.Outgoing
                    _msg = ByteToHex(newMsg) + "" + Environment.NewLine + ""
                    DisplayData(_type, _msg)
                Catch ex As FormatException
                    'display error message
                    _type = MessageType.Error
                    _msg = ex.Message + "" + Environment.NewLine + ""
                    DisplayData(_type, _msg)
                Finally
                    _displayWindow.SelectAll()
                End Try
                Exit Select
            Case Else
                'first make sure the port is open
                'if its not open then open it
                If Not (comPort.IsOpen = True) Then
                    comPort.Open()
                End If
                'send the message to the port
                comPort.Write(msg)
                'display the message
                _type = MessageType.Outgoing
                _msg = msg + "" + Environment.NewLine + ""
                DisplayData(MessageType.Outgoing, msg + "" + Environment.NewLine + "")
                Exit Select
        End Select
    End Sub
#End Region

#Region "HexToByte"
    ''' method to convert hex string into a byte array
    ''' <param name="msg">string to convert</param>
    ''' <returns>a byte array</returns>
    Private Function HexToByte(ByVal msg As String) As Byte()
        'Here we added an extra check to ensure the data
        'was the proper length for converting to byte
        If msg.Length Mod 2 = 0 Then
            'remove any spaces from the string
            _msg = msg
            _msg = msg.Replace(" ", "")
            'create a byte array the length of the
            'divided by 2 (Hex is 2 characters in length)
            Dim comBuffer As Byte() = New Byte(_msg.Length / 2 - 1) {}
            For i As Integer = 0 To _msg.Length - 1 Step 2
                comBuffer(i / 2) = CByte(Convert.ToByte(_msg.Substring(i, 2), 16))
            Next
            write = True
            'loop through the length of the provided string
            'convert each set of 2 characters to a byte
            'and add to the array
            'return the array
            Return comBuffer
        Else
            'Message wasnt the proper length
            'So we set the display message
            _msg = "Invalid format" + Environment.NewLine
            _type = MessageType.Error
            ' DisplayData(_Type, _msg)
            'Set our boolean value to false
            write = False
            Return Nothing
        End If
    End Function
#End Region

#Region "ByteToHex"
    ''' method to convert a byte array into a hex string
    ''' <param name="comByte">byte array to convert</param>
    ''' <returns>a hex string</returns>
    Private Function ByteToHex(ByVal comByte As Byte()) As String
        'create a new StringBuilder object
        Dim builder As New StringBuilder(comByte.Length * 3)
        'loop through each byte in the array
        For Each data As Byte In comByte
            builder.Append(Convert.ToString(data, 16).PadLeft(2, "0"c).PadRight(3, " "c))
            'convert the byte to a string and add to the stringbuilder
        Next
        'return the converted value
        Return builder.ToString().ToUpper()
    End Function
#End Region

#Region "DisplayData"
    ''' Method to display the data to and
    ''' from the port on the screen
    <STAThread()> _
    Private Sub DisplayData(ByVal type As MessageType, ByVal msg As String)
        _displayWindow.Invoke(New EventHandler(AddressOf DoDisplay))
    End Sub
#End Region

#Region "DoDisplay"
    Private Sub DoDisplay(ByVal sender As Object, ByVal e As EventArgs)
        _displayWindow.SelectionStart = Len(_displayWindow.Text)
        _displayWindow.SelectionLength = 0
        _displayWindow.SelectionFont = New Font(_displayWindow.SelectionFont, FontStyle.Bold)
        _displayWindow.SelectionColor = MessageColor(CType(_type, Integer))
        _displayWindow.AppendText(_msg)
        _displayWindow.ScrollToCaret()
    End Sub
#End Region

#Region "OpenPort"
    Public Function OpenPort() As Boolean
        Try
            'first check if the port is already open
            'if its open then close it
            If comPort.IsOpen = True Then
                comPort.Close()
            End If

            'set the properties of our SerialPort Object
            comPort.BaudRate = Integer.Parse(_baudRate)
            'BaudRate
            comPort.DataBits = Integer.Parse(_dataBits)
            'DataBits
            comPort.StopBits = DirectCast([Enum].Parse(GetType(StopBits), _stopBits), StopBits)
            'StopBits
            comPort.PortName = _portName
            'PortName
            'now open the port
            comPort.Open()
            'display message
            _type = MessageType.Normal
            _msg = "Port opened at " + DateTime.Now + "" + Environment.NewLine + ""
            DisplayData(_type, _msg)
            'return true
            Return True
        Catch ex As Exception
            DisplayData(MessageType.[Error], ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region " ClosePort "
    Public Sub ClosePort()
        If comPort.IsOpen Then
            _msg = "Port closed at " + DateTime.Now + "" + Environment.NewLine + ""
            _type = MessageType.Normal
            DisplayData(_type, _msg)
            comPort.Close()
        End If
    End Sub
#End Region

#Region "comPort_DataReceived"
    ''' method that will be called when theres data waiting in the buffer
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub comPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        'determine the mode the user selected (binary/string)

        'Delay to pick up all bytes
        Dim byteCount As Integer = comPort.BytesToRead
        If byteCount = 3 Then

            Select Case CurrentTransmissionType
                Case TransmissionType.Text
                    'user chose string
                    'read data waiting in the buffer
                    Dim msg As String = comPort.ReadExisting()
                    'display the data to the user
                    _type = MessageType.Incoming
                    _msg = msg
                    DisplayData(MessageType.Incoming, msg + "" + Environment.NewLine + "")
                    Exit Select
                Case TransmissionType.Hex
                    'user chose binary
                    'retrieve number of bytes in the buffer
                    Dim bytes As Integer = comPort.BytesToRead
                    'create a byte array to hold the awaiting data
                    Dim comBuffer As Byte() = New Byte(bytes - 1) {}
                    'read the data and store it
                    comPort.Read(comBuffer, 0, bytes)
                    'display the data to the user
                    _type = MessageType.Incoming
                    _msg = ByteToHex(comBuffer) + "" + Environment.NewLine + ""
                    DisplayData(MessageType.Incoming, ByteToHex(comBuffer) + "" + Environment.NewLine + "")

                    'Change LED at error msg
                    Dim errorMsg As String = "BB BB BB "
                    Dim incMsg As String = ByteToHex(comBuffer)

                    If errorMsg = incMsg Then
                        'Send to funtion in Car Control that updates error lights
                        ErrorLightControl("Error")
                    End If

                    'Intercept motor speed change and update speed bar
                    ' If incMsg Then
                    ' Make string split. if first two hex = BB 10 convert last hex and update speed bar
                    ' BB 10 80 ==> .length -4, -3, -2
                    Dim RecievedMsgs() As String = Split(incMsg)
                    If RecievedMsgs(RecievedMsgs.Length - 3) = "10" Then
                        Dim speedMsg As String = RecievedMsgs(RecievedMsgs.Length - 2)
                        MotorBarControl(speedMsg)
                    End If

                    'Check for lap counter update. Send to correct function 
                    If RecievedMsgs(RecievedMsgs.Length - 3) = "12" Then
                        Dim LapMsg As String = RecievedMsgs(RecievedMsgs.Length - 2)
                        LapCounterControl(LapMsg)
                    End If

                    Exit Select
                Case Else
                    'read data waiting in the buffer
                    Dim str As String = comPort.ReadExisting()
                    'display the data to the user
                    _type = MessageType.Incoming
                    _msg = str + "" + Environment.NewLine + ""
                    DisplayData(MessageType.Incoming, str + "" + Environment.NewLine + "")
                    Exit Select
            End Select
        End If
    End Sub
#End Region

#Region "MotorBar Control"
    <STAThread()> _
    Public Sub MotorBarControl(ByVal speed As String)
        speedint = Convert.ToInt32(speed, 16) / 2.55
        _Speedbar.BeginInvoke(New EventHandler(AddressOf MotorSpeedSet))
    End Sub

    Public Sub MotorSpeedSet(ByVal speed As Object, ByVal e As EventArgs)
        _Speedbar.Value = speedint
    End Sub
#End Region

#Region "Error Lights control"
    <STAThread()> _
    Public Sub ErrorLightControl(ByVal errorMsg As String)
        ErrormsgStr = errorMsg
        _ErrorLight.BeginInvoke(New EventHandler(AddressOf ErrorLightSet))
    End Sub

    Public Sub ErrorLightSet(ByVal errormsg As Object, ByVal e As EventArgs)
        If ErrormsgStr = "Error" And CarControl.ErrorBlink.Enabled = True Then
            _ErrorLight.Image = My.Resources.led_red

        ElseIf ErrormsgStr = "OK" Then
            _ErrorLight.Image = My.Resources.led_green
        End If

        If ErrormsgStr = "Error" And CarControl.ErrorBlink.Enabled = False Then
            CarControl.ErrorBlink.Enabled = True
            CarControl.ErrorBlink.Start()
        End If

    End Sub

#End Region

#Region "Lap Counter Control"
    <STAThread()> _
    Public Sub LapCounterControl(ByVal lapCount As String)
        LapStr = Convert.ToInt32(lapCount, 16)
        _LapCounter.BeginInvoke(New EventHandler(AddressOf LapCounterSet))
    End Sub

    Public Sub LapCounterSet(ByVal lapcount As Object, ByVal e As EventArgs)
        _LapCounter.Text = LapStr
    End Sub
#End Region

#Region "Save Log"
    Public Sub SaveLog()
        If _displayWindow Is Nothing Then
            MsgBox("No text to save", 1, "ERROR")
        Else
            CarControl.SaveLogDialog.Filter = "TXT Files (*.txt*)|*.txt"
            If CarControl.SaveLogDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText _
                (CarControl.SaveLogDialog.FileName, _displayWindow.Text, False)
            End If
        End If

    End Sub
#End Region

#Region "SetStopBitValues"
    Public Sub SetStopBitValues(ByVal obj As Object)
        For Each str As String In [Enum].GetNames(GetType(StopBits))
            DirectCast(obj, ComboBox).Items.Add(str)
        Next
    End Sub
#End Region

#Region "SetPortNameValues"
    Public Sub SetPortNameValues(ByVal obj As Object)

        For Each str As String In SerialPort.GetPortNames()
            DirectCast(obj, ComboBox).Items.Add(str)
        Next
    End Sub
#End Region



End Class
