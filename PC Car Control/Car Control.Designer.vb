<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarControl))
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoText = New System.Windows.Forms.RadioButton()
        Me.rdoHex = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cboData = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cboStop = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBaud = New System.Windows.Forms.ComboBox()
        Me.cboPort = New System.Windows.Forms.ComboBox()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SpeedSlider = New System.Windows.Forms.NumericUpDown()
        Me.SpeedDisplay = New System.Windows.Forms.ProgressBar()
        Me.SendSpeed = New System.Windows.Forms.Button()
        Me.speed50 = New System.Windows.Forms.Button()
        Me.speed75 = New System.Windows.Forms.Button()
        Me.stopall = New System.Windows.Forms.Button()
        Me.speed80 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnLapCount = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LapDisplay = New System.Windows.Forms.TextBox()
        Me.btnSavelog = New System.Windows.Forms.Button()
        Me.btnTestMotor = New System.Windows.Forms.Button()
        Me.SaveLogDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ErrorBlink = New System.Windows.Forms.Timer(Me.components)
        Me.ErrLight = New System.Windows.Forms.PictureBox()
        Me.groupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SpeedSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ErrLight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(125, 306)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 23)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "Close Port"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.rdoText)
        Me.groupBox3.Controls.Add(Me.rdoHex)
        Me.groupBox3.Location = New System.Drawing.Point(335, 205)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(100, 60)
        Me.groupBox3.TabIndex = 12
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Mode"
        '
        'rdoText
        '
        Me.rdoText.AutoSize = True
        Me.rdoText.Location = New System.Drawing.Point(6, 38)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(46, 17)
        Me.rdoText.TabIndex = 1
        Me.rdoText.TabStop = True
        Me.rdoText.Text = "Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoHex
        '
        Me.rdoHex.AutoSize = True
        Me.rdoHex.Location = New System.Drawing.Point(6, 16)
        Me.rdoHex.Name = "rdoHex"
        Me.rdoHex.Size = New System.Drawing.Size(44, 17)
        Me.rdoHex.TabIndex = 0
        Me.rdoHex.TabStop = True
        Me.rdoHex.Text = "Hex"
        Me.rdoHex.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSend)
        Me.GroupBox1.Controls.Add(Me.rtbDisplay)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 288)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serial Port Communication"
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(7, 259)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(300, 20)
        Me.txtSend.TabIndex = 4
        '
        'rtbDisplay
        '
        Me.rtbDisplay.Location = New System.Drawing.Point(7, 19)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.Size = New System.Drawing.Size(300, 234)
        Me.rtbDisplay.TabIndex = 3
        Me.rtbDisplay.Text = ""
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(335, 271)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(100, 23)
        Me.cmdSend.TabIndex = 5
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.cboData)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.cboStop)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.Label1)
        Me.groupBox2.Controls.Add(Me.cboBaud)
        Me.groupBox2.Controls.Add(Me.cboPort)
        Me.groupBox2.Location = New System.Drawing.Point(335, 13)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(96, 182)
        Me.groupBox2.TabIndex = 11
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Options"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(6, 138)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(50, 13)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Data Bits"
        '
        'cboData
        '
        Me.cboData.FormattingEnabled = True
        Me.cboData.Items.AddRange(New Object() {"7", "8", "9"})
        Me.cboData.Location = New System.Drawing.Point(9, 154)
        Me.cboData.Name = "cboData"
        Me.cboData.Size = New System.Drawing.Size(76, 21)
        Me.cboData.TabIndex = 14
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 98)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 13)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Stop Bits"
        '
        'cboStop
        '
        Me.cboStop.FormattingEnabled = True
        Me.cboStop.Location = New System.Drawing.Point(8, 114)
        Me.cboStop.Name = "cboStop"
        Me.cboStop.Size = New System.Drawing.Size(76, 21)
        Me.cboStop.TabIndex = 13
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 13)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Baud Rate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Port"
        '
        'cboBaud
        '
        Me.cboBaud.FormattingEnabled = True
        Me.cboBaud.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "14400", "28800", "36000", "115000"})
        Me.cboBaud.Location = New System.Drawing.Point(9, 74)
        Me.cboBaud.Name = "cboBaud"
        Me.cboBaud.Size = New System.Drawing.Size(76, 21)
        Me.cboBaud.TabIndex = 11
        '
        'cboPort
        '
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.Location = New System.Drawing.Point(9, 34)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(76, 21)
        Me.cboPort.TabIndex = 10
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(19, 306)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(100, 23)
        Me.cmdOpen.TabIndex = 13
        Me.cmdOpen.Text = "Open Port"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SpeedSlider)
        Me.GroupBox4.Controls.Add(Me.SpeedDisplay)
        Me.GroupBox4.Controls.Add(Me.SendSpeed)
        Me.GroupBox4.Controls.Add(Me.speed50)
        Me.GroupBox4.Controls.Add(Me.speed75)
        Me.GroupBox4.Controls.Add(Me.stopall)
        Me.GroupBox4.Controls.Add(Me.speed80)
        Me.GroupBox4.Location = New System.Drawing.Point(446, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(192, 252)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Motor Controls"
        '
        'SpeedSlider
        '
        Me.SpeedSlider.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpeedSlider.Location = New System.Drawing.Point(121, 114)
        Me.SpeedSlider.Name = "SpeedSlider"
        Me.SpeedSlider.Size = New System.Drawing.Size(44, 20)
        Me.SpeedSlider.TabIndex = 16
        '
        'SpeedDisplay
        '
        Me.SpeedDisplay.Location = New System.Drawing.Point(6, 19)
        Me.SpeedDisplay.Name = "SpeedDisplay"
        Me.SpeedDisplay.Size = New System.Drawing.Size(180, 24)
        Me.SpeedDisplay.Step = 1
        Me.SpeedDisplay.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.SpeedDisplay.TabIndex = 15
        '
        'SendSpeed
        '
        Me.SendSpeed.Location = New System.Drawing.Point(102, 149)
        Me.SendSpeed.Name = "SendSpeed"
        Me.SendSpeed.Size = New System.Drawing.Size(84, 42)
        Me.SendSpeed.TabIndex = 0
        Me.SendSpeed.Text = "Send Speed"
        Me.SendSpeed.UseVisualStyleBackColor = True
        '
        'speed50
        '
        Me.speed50.Location = New System.Drawing.Point(6, 53)
        Me.speed50.Name = "speed50"
        Me.speed50.Size = New System.Drawing.Size(84, 42)
        Me.speed50.TabIndex = 0
        Me.speed50.Text = "50% Speed"
        Me.speed50.UseVisualStyleBackColor = True
        '
        'speed75
        '
        Me.speed75.Location = New System.Drawing.Point(6, 101)
        Me.speed75.Name = "speed75"
        Me.speed75.Size = New System.Drawing.Size(84, 42)
        Me.speed75.TabIndex = 0
        Me.speed75.Text = "75% Speed"
        Me.speed75.UseVisualStyleBackColor = True
        '
        'stopall
        '
        Me.stopall.BackColor = System.Drawing.Color.Red
        Me.stopall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopall.ForeColor = System.Drawing.Color.MediumBlue
        Me.stopall.Location = New System.Drawing.Point(56, 204)
        Me.stopall.Name = "stopall"
        Me.stopall.Size = New System.Drawing.Size(84, 42)
        Me.stopall.TabIndex = 0
        Me.stopall.Text = "STOP"
        Me.stopall.UseVisualStyleBackColor = False
        '
        'speed80
        '
        Me.speed80.Location = New System.Drawing.Point(6, 149)
        Me.speed80.Name = "speed80"
        Me.speed80.Size = New System.Drawing.Size(84, 42)
        Me.speed80.TabIndex = 0
        Me.speed80.Text = "80% Speed"
        Me.speed80.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ErrLight)
        Me.GroupBox5.Location = New System.Drawing.Point(657, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(98, 95)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Error Response"
        '
        'btnLapCount
        '
        Me.btnLapCount.Location = New System.Drawing.Point(6, 76)
        Me.btnLapCount.Name = "btnLapCount"
        Me.btnLapCount.Size = New System.Drawing.Size(84, 42)
        Me.btnLapCount.TabIndex = 0
        Me.btnLapCount.Text = "Lap Count"
        Me.btnLapCount.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LapDisplay)
        Me.GroupBox6.Controls.Add(Me.btnLapCount)
        Me.GroupBox6.Location = New System.Drawing.Point(659, 114)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(96, 124)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Lap Counter"
        '
        'LapDisplay
        '
        Me.LapDisplay.Location = New System.Drawing.Point(6, 37)
        Me.LapDisplay.Name = "LapDisplay"
        Me.LapDisplay.ReadOnly = True
        Me.LapDisplay.Size = New System.Drawing.Size(84, 20)
        Me.LapDisplay.TabIndex = 1
        Me.LapDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSavelog
        '
        Me.btnSavelog.Location = New System.Drawing.Point(665, 300)
        Me.btnSavelog.Name = "btnSavelog"
        Me.btnSavelog.Size = New System.Drawing.Size(84, 29)
        Me.btnSavelog.TabIndex = 15
        Me.btnSavelog.Text = "Save Log"
        Me.btnSavelog.UseVisualStyleBackColor = True
        '
        'btnTestMotor
        '
        Me.btnTestMotor.Location = New System.Drawing.Point(501, 286)
        Me.btnTestMotor.Name = "btnTestMotor"
        Me.btnTestMotor.Size = New System.Drawing.Size(85, 57)
        Me.btnTestMotor.TabIndex = 16
        Me.btnTestMotor.Text = "TEST Motor speed"
        Me.btnTestMotor.UseVisualStyleBackColor = True
        Me.btnTestMotor.Visible = False
        '
        'ErrorBlink
        '
        Me.ErrorBlink.Interval = 500
        '
        'ErrLight
        '
        Me.ErrLight.Location = New System.Drawing.Point(26, 28)
        Me.ErrLight.Name = "ErrLight"
        Me.ErrLight.Size = New System.Drawing.Size(53, 50)
        Me.ErrLight.TabIndex = 0
        Me.ErrLight.TabStop = False
        '
        'CarControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 339)
        Me.Controls.Add(Me.btnTestMotor)
        Me.Controls.Add(Me.btnSavelog)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.cmdOpen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CarControl"
        Me.Text = "Car Control"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.SpeedSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ErrLight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdClose As System.Windows.Forms.Button
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents rdoText As System.Windows.Forms.RadioButton
    Private WithEvents rdoHex As System.Windows.Forms.RadioButton
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents cmdSend As System.Windows.Forms.Button
    Private WithEvents txtSend As System.Windows.Forms.TextBox
    Private WithEvents rtbDisplay As System.Windows.Forms.RichTextBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents cboData As System.Windows.Forms.ComboBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents cboStop As System.Windows.Forms.ComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboBaud As System.Windows.Forms.ComboBox
    Private WithEvents cboPort As System.Windows.Forms.ComboBox
    Private WithEvents cmdOpen As System.Windows.Forms.Button
    Private WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents speed80 As System.Windows.Forms.Button
    Friend WithEvents speed50 As System.Windows.Forms.Button
    Friend WithEvents speed75 As System.Windows.Forms.Button
    Friend WithEvents stopall As System.Windows.Forms.Button
    Friend WithEvents SpeedSlider As System.Windows.Forms.NumericUpDown
    Friend WithEvents SpeedDisplay As System.Windows.Forms.ProgressBar
    Friend WithEvents SendSpeed As System.Windows.Forms.Button
    Private WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrLight As System.Windows.Forms.PictureBox
    Friend WithEvents btnLapCount As System.Windows.Forms.Button
    Private WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LapDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnSavelog As System.Windows.Forms.Button
    Friend WithEvents btnTestMotor As System.Windows.Forms.Button
    Friend WithEvents SaveLogDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ErrorBlink As System.Windows.Forms.Timer
End Class
