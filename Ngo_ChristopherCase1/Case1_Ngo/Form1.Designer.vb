<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnFV = New System.Windows.Forms.Button()
        Me.btnPV = New System.Windows.Forms.Button()
        Me.btnNPer = New System.Windows.Forms.Button()
        Me.btnRate = New System.Windows.Forms.Button()
        Me.btnSln = New System.Windows.Forms.Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblHeaderTimer = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtNPer = New System.Windows.Forms.TextBox()
        Me.txtPmt = New System.Windows.Forms.TextBox()
        Me.txtPV = New System.Windows.Forms.TextBox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblNPer = New System.Windows.Forms.Label()
        Me.lblPmt = New System.Windows.Forms.Label()
        Me.lblPV = New System.Windows.Forms.Label()
        Me.lblLife = New System.Windows.Forms.Label()
        Me.lblSalvage = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtLife = New System.Windows.Forms.TextBox()
        Me.txtSalvage = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClearResult = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblCalculate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRateCaption = New System.Windows.Forms.Label()
        Me.lblNPerCaption = New System.Windows.Forms.Label()
        Me.lblPMCaption = New System.Windows.Forms.Label()
        Me.lblPVCaption = New System.Windows.Forms.Label()
        Me.lblCostCaption = New System.Windows.Forms.Label()
        Me.lblSalvageCaption = New System.Windows.Forms.Label()
        Me.lblLifeCaption = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFV
        '
        Me.btnFV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFV.Location = New System.Drawing.Point(12, 40)
        Me.btnFV.Name = "btnFV"
        Me.btnFV.Size = New System.Drawing.Size(123, 46)
        Me.btnFV.TabIndex = 1
        Me.btnFV.Text = "FV"
        Me.btnFV.UseVisualStyleBackColor = True
        '
        'btnPV
        '
        Me.btnPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPV.Location = New System.Drawing.Point(141, 40)
        Me.btnPV.Name = "btnPV"
        Me.btnPV.Size = New System.Drawing.Size(123, 46)
        Me.btnPV.TabIndex = 2
        Me.btnPV.Text = "PV"
        Me.btnPV.UseVisualStyleBackColor = True
        '
        'btnNPer
        '
        Me.btnNPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNPer.Location = New System.Drawing.Point(270, 40)
        Me.btnNPer.Name = "btnNPer"
        Me.btnNPer.Size = New System.Drawing.Size(123, 46)
        Me.btnNPer.TabIndex = 3
        Me.btnNPer.Text = "NPer"
        Me.btnNPer.UseVisualStyleBackColor = True
        '
        'btnRate
        '
        Me.btnRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRate.Location = New System.Drawing.Point(399, 40)
        Me.btnRate.Name = "btnRate"
        Me.btnRate.Size = New System.Drawing.Size(123, 46)
        Me.btnRate.TabIndex = 4
        Me.btnRate.Text = "Rate"
        Me.btnRate.UseVisualStyleBackColor = True
        '
        'btnSln
        '
        Me.btnSln.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSln.Location = New System.Drawing.Point(528, 40)
        Me.btnSln.Name = "btnSln"
        Me.btnSln.Size = New System.Drawing.Size(123, 46)
        Me.btnSln.TabIndex = 5
        Me.btnSln.Text = "Sln"
        Me.btnSln.UseVisualStyleBackColor = True
        '
        'lblDateTime
        '
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(9, 301)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(270, 23)
        Me.lblDateTime.TabIndex = 6
        Me.lblDateTime.Text = "Date and Time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblHour
        '
        Me.lblHour.Location = New System.Drawing.Point(205, 325)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(85, 13)
        Me.lblHour.TabIndex = 9
        Me.lblHour.Text = "0"
        '
        'lblMin
        '
        Me.lblMin.Location = New System.Drawing.Point(296, 324)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(91, 14)
        Me.lblMin.TabIndex = 10
        Me.lblMin.Text = "0"
        '
        'lblSecond
        '
        Me.lblSecond.Location = New System.Drawing.Point(393, 325)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(69, 13)
        Me.lblSecond.TabIndex = 11
        Me.lblSecond.Text = "0"
        '
        'lblHeaderTimer
        '
        Me.lblHeaderTimer.AutoSize = True
        Me.lblHeaderTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTimer.Location = New System.Drawing.Point(9, 325)
        Me.lblHeaderTimer.Name = "lblHeaderTimer"
        Me.lblHeaderTimer.Size = New System.Drawing.Size(178, 13)
        Me.lblHeaderTimer.TabIndex = 12
        Me.lblHeaderTimer.Text = "Timer: (Hours, Mins, Seconds)"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(15, 13)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(63, 24)
        Me.lblMode.TabIndex = 13
        Me.lblMode.Text = "Mode"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(418, 179)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(68, 24)
        Me.lblResult.TabIndex = 15
        Me.lblResult.Text = "Result"
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtRate.Location = New System.Drawing.Point(104, 126)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(95, 20)
        Me.txtRate.TabIndex = 16
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNPer
        '
        Me.txtNPer.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNPer.Location = New System.Drawing.Point(104, 157)
        Me.txtNPer.Name = "txtNPer"
        Me.txtNPer.Size = New System.Drawing.Size(95, 20)
        Me.txtNPer.TabIndex = 17
        Me.txtNPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPmt
        '
        Me.txtPmt.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtPmt.Location = New System.Drawing.Point(104, 183)
        Me.txtPmt.Name = "txtPmt"
        Me.txtPmt.Size = New System.Drawing.Size(95, 20)
        Me.txtPmt.TabIndex = 18
        Me.txtPmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPV
        '
        Me.txtPV.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtPV.Location = New System.Drawing.Point(104, 216)
        Me.txtPV.Name = "txtPV"
        Me.txtPV.Size = New System.Drawing.Size(95, 20)
        Me.txtPV.TabIndex = 19
        Me.txtPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(12, 127)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(41, 16)
        Me.lblRate.TabIndex = 21
        Me.lblRate.Text = "Rate"
        '
        'lblNPer
        '
        Me.lblNPer.AutoSize = True
        Me.lblNPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPer.Location = New System.Drawing.Point(12, 157)
        Me.lblNPer.Name = "lblNPer"
        Me.lblNPer.Size = New System.Drawing.Size(47, 16)
        Me.lblNPer.TabIndex = 22
        Me.lblNPer.Text = "NPer "
        '
        'lblPmt
        '
        Me.lblPmt.AutoSize = True
        Me.lblPmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPmt.Location = New System.Drawing.Point(12, 183)
        Me.lblPmt.Name = "lblPmt"
        Me.lblPmt.Size = New System.Drawing.Size(30, 16)
        Me.lblPmt.TabIndex = 23
        Me.lblPmt.Text = "Pm"
        '
        'lblPV
        '
        Me.lblPV.AutoSize = True
        Me.lblPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPV.Location = New System.Drawing.Point(12, 216)
        Me.lblPV.Name = "lblPV"
        Me.lblPV.Size = New System.Drawing.Size(32, 16)
        Me.lblPV.TabIndex = 24
        Me.lblPV.Text = "PV "
        '
        'lblLife
        '
        Me.lblLife.AutoSize = True
        Me.lblLife.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLife.Location = New System.Drawing.Point(205, 191)
        Me.lblLife.Name = "lblLife"
        Me.lblLife.Size = New System.Drawing.Size(37, 16)
        Me.lblLife.TabIndex = 33
        Me.lblLife.Text = "Life "
        '
        'lblSalvage
        '
        Me.lblSalvage.AutoSize = True
        Me.lblSalvage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalvage.Location = New System.Drawing.Point(205, 157)
        Me.lblSalvage.Name = "lblSalvage"
        Me.lblSalvage.Size = New System.Drawing.Size(70, 16)
        Me.lblSalvage.TabIndex = 32
        Me.lblSalvage.Text = "Salvage "
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(205, 127)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(43, 16)
        Me.lblCost.TabIndex = 31
        Me.lblCost.Text = "Cost "
        '
        'txtLife
        '
        Me.txtLife.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtLife.Location = New System.Drawing.Point(293, 194)
        Me.txtLife.Name = "txtLife"
        Me.txtLife.Size = New System.Drawing.Size(94, 20)
        Me.txtLife.TabIndex = 30
        Me.txtLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalvage
        '
        Me.txtSalvage.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSalvage.Location = New System.Drawing.Point(293, 163)
        Me.txtSalvage.Name = "txtSalvage"
        Me.txtSalvage.Size = New System.Drawing.Size(94, 20)
        Me.txtSalvage.TabIndex = 29
        Me.txtSalvage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCost.Location = New System.Drawing.Point(293, 127)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(94, 20)
        Me.txtCost.TabIndex = 28
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(420, 127)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(231, 49)
        Me.btnCalculate.TabIndex = 34
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClearResult
        '
        Me.btnClearResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearResult.Location = New System.Drawing.Point(401, 3)
        Me.btnClearResult.Name = "btnClearResult"
        Me.btnClearResult.Size = New System.Drawing.Size(250, 31)
        Me.btnClearResult.TabIndex = 35
        Me.btnClearResult.Text = "CLEAR RESULT"
        Me.btnClearResult.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(85, 21)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(294, 13)
        Me.lblInfo.TabIndex = 36
        Me.lblInfo.Text = "Please choose one of the modes listed below and enter input"
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.SystemColors.Info
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(424, 205)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(227, 45)
        Me.lblAnswer.TabIndex = 37
        Me.lblAnswer.Text = "0"
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCalculate
        '
        Me.lblCalculate.AutoSize = True
        Me.lblCalculate.Location = New System.Drawing.Point(18, 103)
        Me.lblCalculate.Name = "lblCalculate"
        Me.lblCalculate.Size = New System.Drawing.Size(369, 13)
        Me.lblCalculate.TabIndex = 38
        Me.lblCalculate.Text = "Please enter input below and press calculate or choose another mode above"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(415, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Note: Select mode first before clicking calculate"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(450, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 30)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "If recalculating on same mode, select mode again before clicking Calculate again"
        '
        'lblRateCaption
        '
        Me.lblRateCaption.AutoSize = True
        Me.lblRateCaption.Location = New System.Drawing.Point(18, 144)
        Me.lblRateCaption.Name = "lblRateCaption"
        Me.lblRateCaption.Size = New System.Drawing.Size(80, 13)
        Me.lblRateCaption.TabIndex = 41
        Me.lblRateCaption.Text = "Format ex: 0.05"
        '
        'lblNPerCaption
        '
        Me.lblNPerCaption.AutoSize = True
        Me.lblNPerCaption.Location = New System.Drawing.Point(18, 170)
        Me.lblNPerCaption.Name = "lblNPerCaption"
        Me.lblNPerCaption.Size = New System.Drawing.Size(71, 13)
        Me.lblNPerCaption.TabIndex = 42
        Me.lblNPerCaption.Text = "Format ex: 10"
        '
        'lblPMCaption
        '
        Me.lblPMCaption.AutoSize = True
        Me.lblPMCaption.Location = New System.Drawing.Point(18, 201)
        Me.lblPMCaption.Name = "lblPMCaption"
        Me.lblPMCaption.Size = New System.Drawing.Size(83, 13)
        Me.lblPMCaption.TabIndex = 43
        Me.lblPMCaption.Text = "Format ex: 1000"
        '
        'lblPVCaption
        '
        Me.lblPVCaption.AutoSize = True
        Me.lblPVCaption.Location = New System.Drawing.Point(18, 232)
        Me.lblPVCaption.Name = "lblPVCaption"
        Me.lblPVCaption.Size = New System.Drawing.Size(83, 13)
        Me.lblPVCaption.TabIndex = 44
        Me.lblPVCaption.Text = "Format ex: 6500"
        '
        'lblCostCaption
        '
        Me.lblCostCaption.AutoSize = True
        Me.lblCostCaption.Location = New System.Drawing.Point(216, 146)
        Me.lblCostCaption.Name = "lblCostCaption"
        Me.lblCostCaption.Size = New System.Drawing.Size(71, 13)
        Me.lblCostCaption.TabIndex = 45
        Me.lblCostCaption.Text = "Format ex: 10"
        '
        'lblSalvageCaption
        '
        Me.lblSalvageCaption.AutoSize = True
        Me.lblSalvageCaption.Location = New System.Drawing.Point(214, 173)
        Me.lblSalvageCaption.Name = "lblSalvageCaption"
        Me.lblSalvageCaption.Size = New System.Drawing.Size(65, 13)
        Me.lblSalvageCaption.TabIndex = 46
        Me.lblSalvageCaption.Text = "Format ex: 0"
        '
        'lblLifeCaption
        '
        Me.lblLifeCaption.AutoSize = True
        Me.lblLifeCaption.Location = New System.Drawing.Point(216, 210)
        Me.lblLifeCaption.Name = "lblLifeCaption"
        Me.lblLifeCaption.Size = New System.Drawing.Size(65, 13)
        Me.lblLifeCaption.TabIndex = 47
        Me.lblLifeCaption.Text = "Format ex: 7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 346)
        Me.Controls.Add(Me.lblLifeCaption)
        Me.Controls.Add(Me.lblSalvageCaption)
        Me.Controls.Add(Me.lblCostCaption)
        Me.Controls.Add(Me.lblPVCaption)
        Me.Controls.Add(Me.lblPMCaption)
        Me.Controls.Add(Me.lblNPerCaption)
        Me.Controls.Add(Me.lblRateCaption)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCalculate)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnClearResult)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblLife)
        Me.Controls.Add(Me.lblSalvage)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtLife)
        Me.Controls.Add(Me.txtSalvage)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblPV)
        Me.Controls.Add(Me.lblPmt)
        Me.Controls.Add(Me.lblNPer)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.txtPV)
        Me.Controls.Add(Me.txtPmt)
        Me.Controls.Add(Me.txtNPer)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.lblHeaderTimer)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.btnSln)
        Me.Controls.Add(Me.btnRate)
        Me.Controls.Add(Me.btnNPer)
        Me.Controls.Add(Me.btnPV)
        Me.Controls.Add(Me.btnFV)
        Me.Name = "Form1"
        Me.Text = "Financial Calculator IS350"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFV As Button
    Friend WithEvents btnPV As Button
    Friend WithEvents btnNPer As Button
    Friend WithEvents btnRate As Button
    Friend WithEvents btnSln As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblHour As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblHeaderTimer As Label
    Friend WithEvents lblMode As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtNPer As TextBox
    Friend WithEvents txtPmt As TextBox
    Friend WithEvents txtPV As TextBox
    Friend WithEvents lblRate As Label
    Friend WithEvents lblNPer As Label
    Friend WithEvents lblPmt As Label
    Friend WithEvents lblPV As Label
    Friend WithEvents lblLife As Label
    Friend WithEvents lblSalvage As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtLife As TextBox
    Friend WithEvents txtSalvage As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClearResult As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblCalculate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRateCaption As Label
    Friend WithEvents lblNPerCaption As Label
    Friend WithEvents lblPMCaption As Label
    Friend WithEvents lblPVCaption As Label
    Friend WithEvents lblCostCaption As Label
    Friend WithEvents lblSalvageCaption As Label
    Friend WithEvents lblLifeCaption As Label
End Class
