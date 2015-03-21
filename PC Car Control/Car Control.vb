
Public Class CarControl
    Private comm As New CommManager()
    Private transType As String = String.Empty

    Private Sub cboPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPort.SelectedIndexChanged
        comm.PortName = cboPort.Text()
    End Sub


    ''' Method to initialize serial port
    ''' values to standard defaults
    Private Sub SetDefaults()
        cboPort.SelectedIndex = -1
        cboBaud.SelectedText = "9600"
        cboStop.SelectedIndex = 2
        cboData.SelectedIndex = 1
        ErrorLights("Green")

    End Sub

    Public Shared Sub ErrorLights(ByVal errorMsg As String)

        If errorMsg = "Error" Then
            CarControl.PicLED.Image = My.Resources.led_red
            MsgBox("RED", 0, "RED")

        ElseIf errorMsg = "Green" Then
            CarControl.PicLED.Image = My.Resources.led_green
        End If

    End Sub

    ''' methos to load our serial
    ''' port option values
    Private Sub LoadValues()
        comm.SetPortNameValues(cboPort)
        comm.SetStopBitValues(cboStop)
    End Sub

    ''' method to set the state of controls
    ''' when the form first loads
    Private Sub SetControlState()
        rdoHex.Checked = True
        cmdOpen.Enabled = True
        cmdSend.Enabled = False
        cmdClose.Enabled = False
    End Sub

    Private Sub CarControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadValues()
        SetControlState()
        SetDefaults()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        comm.ClosePort()
        SetControlState()
        SetDefaults()
    End Sub

    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        comm.StopBits = cboStop.Text
        comm.DataBits = cboData.Text
        comm.BaudRate = cboBaud.Text
        comm.DisplayWindow = rtbDisplay
        comm.OpenPort()

        cmdOpen.Enabled = False
        cmdClose.Enabled = True
        cmdSend.Enabled = True
    End Sub

    Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click
        comm.Message = txtSend.Text
        comm.Type = CommManager.MessageType.Normal
        comm.WriteData(txtSend.Text)
        txtSend.Text = String.Empty
        txtSend.Focus()

    End Sub

    Private Sub rdoHex_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoHex.CheckedChanged
        If rdoHex.Checked() Then
            comm.CurrentTransmissionType = CommManager.TransmissionType.Hex
        Else
            comm.CurrentTransmissionType = CommManager.TransmissionType.Text
        End If
    End Sub

    Private Sub cboBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBaud.SelectedIndexChanged
        comm.BaudRate = cboBaud.Text()
    End Sub

    Private Sub cboStop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStop.SelectedIndexChanged
        comm.StopBits = cboStop.Text()
    End Sub

    Private Sub cboData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboData.SelectedIndexChanged
        comm.StopBits = cboStop.Text()
    End Sub

    Private Sub speed50_Click(sender As Object, e As EventArgs) Handles speed50.Click
        Dim speed50 As String = "55 10 80"
        comm.Message = speed50
        comm.Type = CommManager.MessageType.Normal
        comm.WriteData(speed50)

        'update speedslider
        SpeedBar.Value = 50
    End Sub

    Private Sub speed75_Click(sender As Object, e As EventArgs) Handles speed75.Click
        Dim speed75 As String = "55 10 BF"
        comm.Message = speed75
        comm.Type = CommManager.MessageType.Normal
        comm.WriteData(speed75)

        'update speedslider
        SpeedBar.Value = 75

    End Sub

    Private Sub speed80_Click(sender As Object, e As EventArgs) Handles speed80.Click
        Dim speed80 As String = "55 10 CC"
        comm.Message = speed80
        comm.Type = CommManager.MessageType.Normal
        comm.WriteData(speed80)

        'update speedslider
        SpeedBar.Value = 80
    End Sub

    Private Sub stopall_Click(sender As Object, e As EventArgs) Handles stopall.Click
        Dim stopsend As String = "55 10 00"
        comm.Message = stopsend
        comm.Type = CommManager.MessageType.Normal
        comm.WriteData(stopsend)

        'update speedslider
        SpeedBar.Value = 0
    End Sub

    Private Sub SendSpeed_Click(sender As Object, e As EventArgs) Handles SendSpeed.Click
        Dim procent As Integer = 2.55 * SpeedSlider.Value
        Dim HexSpeed As String = Hex(procent)
        Dim speedMsg As String = "55 10 " & HexSpeed
        comm.Message = speedMsg
        comm.Type = CommManager.MessageType.Normal
        comm.WriteData(speedMsg)

        'update speedslider
        SpeedBar.Value = SpeedSlider.Value

    End Sub

    Private Sub txtSend_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSend.KeyUp
        If Keys.Enter = True Then
            comm.Message = txtSend.Text
            comm.Type = CommManager.MessageType.Normal
            comm.WriteData(txtSend.Text)
            txtSend.Text = String.Empty
            txtSend.Focus()
        End If
    End Sub

    Private Sub btnLapCount_Click(sender As Object, e As EventArgs) Handles btnLapCount.Click
        Dim LapTime As String = "AA 12 24"
        comm.Message = LapTime
        comm.Type = CommManager.MessageType.Normal
        comm.WriteData(LapTime)
    End Sub
End Class
