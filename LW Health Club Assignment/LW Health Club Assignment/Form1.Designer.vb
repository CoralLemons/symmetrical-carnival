<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHealthClub
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
        Me.grpMemberLength = New System.Windows.Forms.GroupBox()
        Me.lblMemberLength = New System.Windows.Forms.Label()
        Me.txtMemberLength = New System.Windows.Forms.TextBox()
        Me.grpMemberTypes = New System.Windows.Forms.GroupBox()
        Me.rbSenior = New System.Windows.Forms.RadioButton()
        Me.rbStudent = New System.Windows.Forms.RadioButton()
        Me.rbChild = New System.Windows.Forms.RadioButton()
        Me.rbAdult = New System.Windows.Forms.RadioButton()
        Me.grpMemberFees = New System.Windows.Forms.GroupBox()
        Me.txtMonthlyFee = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMonthlyFee = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkPersonalTrainer = New System.Windows.Forms.CheckBox()
        Me.chkKarate = New System.Windows.Forms.CheckBox()
        Me.chkYoga = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpMemberLength.SuspendLayout()
        Me.grpMemberTypes.SuspendLayout()
        Me.grpMemberFees.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMemberLength
        '
        Me.grpMemberLength.Controls.Add(Me.lblMemberLength)
        Me.grpMemberLength.Controls.Add(Me.txtMemberLength)
        Me.grpMemberLength.Location = New System.Drawing.Point(12, 223)
        Me.grpMemberLength.Name = "grpMemberLength"
        Me.grpMemberLength.Size = New System.Drawing.Size(200, 100)
        Me.grpMemberLength.TabIndex = 0
        Me.grpMemberLength.TabStop = False
        Me.grpMemberLength.Text = "Membership Length"
        '
        'lblMemberLength
        '
        Me.lblMemberLength.AutoSize = True
        Me.lblMemberLength.Location = New System.Drawing.Point(6, 32)
        Me.lblMemberLength.Name = "lblMemberLength"
        Me.lblMemberLength.Size = New System.Drawing.Size(190, 17)
        Me.lblMemberLength.TabIndex = 1
        Me.lblMemberLength.Text = "Enter the Number of Months:"
        '
        'txtMemberLength
        '
        Me.txtMemberLength.Location = New System.Drawing.Point(10, 62)
        Me.txtMemberLength.Name = "txtMemberLength"
        Me.txtMemberLength.Size = New System.Drawing.Size(156, 22)
        Me.txtMemberLength.TabIndex = 0
        '
        'grpMemberTypes
        '
        Me.grpMemberTypes.Controls.Add(Me.rbSenior)
        Me.grpMemberTypes.Controls.Add(Me.rbStudent)
        Me.grpMemberTypes.Controls.Add(Me.rbChild)
        Me.grpMemberTypes.Controls.Add(Me.rbAdult)
        Me.grpMemberTypes.Location = New System.Drawing.Point(12, 24)
        Me.grpMemberTypes.Name = "grpMemberTypes"
        Me.grpMemberTypes.Size = New System.Drawing.Size(200, 167)
        Me.grpMemberTypes.TabIndex = 4
        Me.grpMemberTypes.TabStop = False
        Me.grpMemberTypes.Text = "Types Of Membership"
        '
        'rbSenior
        '
        Me.rbSenior.AutoSize = True
        Me.rbSenior.Location = New System.Drawing.Point(15, 134)
        Me.rbSenior.Name = "rbSenior"
        Me.rbSenior.Size = New System.Drawing.Size(116, 21)
        Me.rbSenior.TabIndex = 3
        Me.rbSenior.TabStop = True
        Me.rbSenior.Text = "Se&nior Citizen"
        Me.rbSenior.UseVisualStyleBackColor = True
        '
        'rbStudent
        '
        Me.rbStudent.AutoSize = True
        Me.rbStudent.Location = New System.Drawing.Point(15, 97)
        Me.rbStudent.Name = "rbStudent"
        Me.rbStudent.Size = New System.Drawing.Size(78, 21)
        Me.rbStudent.TabIndex = 2
        Me.rbStudent.TabStop = True
        Me.rbStudent.Text = "&Student"
        Me.rbStudent.UseVisualStyleBackColor = True
        '
        'rbChild
        '
        Me.rbChild.AutoSize = True
        Me.rbChild.Location = New System.Drawing.Point(15, 60)
        Me.rbChild.Name = "rbChild"
        Me.rbChild.Size = New System.Drawing.Size(146, 21)
        Me.rbChild.TabIndex = 1
        Me.rbChild.TabStop = True
        Me.rbChild.Text = "Chil&d (12 && Under)"
        Me.rbChild.UseVisualStyleBackColor = True
        '
        'rbAdult
        '
        Me.rbAdult.AutoSize = True
        Me.rbAdult.Location = New System.Drawing.Point(15, 23)
        Me.rbAdult.Name = "rbAdult"
        Me.rbAdult.Size = New System.Drawing.Size(123, 21)
        Me.rbAdult.TabIndex = 0
        Me.rbAdult.TabStop = True
        Me.rbAdult.Text = "Standard &Adult"
        Me.rbAdult.UseVisualStyleBackColor = True
        '
        'grpMemberFees
        '
        Me.grpMemberFees.Controls.Add(Me.txtMonthlyFee)
        Me.grpMemberFees.Controls.Add(Me.txtTotal)
        Me.grpMemberFees.Controls.Add(Me.lblTotal)
        Me.grpMemberFees.Controls.Add(Me.lblMonthlyFee)
        Me.grpMemberFees.Location = New System.Drawing.Point(238, 223)
        Me.grpMemberFees.Name = "grpMemberFees"
        Me.grpMemberFees.Size = New System.Drawing.Size(200, 100)
        Me.grpMemberFees.TabIndex = 6
        Me.grpMemberFees.TabStop = False
        Me.grpMemberFees.Text = "Membership Fees"
        '
        'txtMonthlyFee
        '
        Me.txtMonthlyFee.Location = New System.Drawing.Point(106, 30)
        Me.txtMonthlyFee.Name = "txtMonthlyFee"
        Me.txtMonthlyFee.ReadOnly = True
        Me.txtMonthlyFee.Size = New System.Drawing.Size(85, 22)
        Me.txtMonthlyFee.TabIndex = 3
        Me.txtMonthlyFee.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(106, 64)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(85, 22)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(51, 67)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 17)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total:"
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.AutoSize = True
        Me.lblMonthlyFee.Location = New System.Drawing.Point(3, 33)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(89, 17)
        Me.lblMonthlyFee.TabIndex = 0
        Me.lblMonthlyFee.Text = "Monthly Fee:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkPersonalTrainer)
        Me.grpOptions.Controls.Add(Me.chkKarate)
        Me.grpOptions.Controls.Add(Me.chkYoga)
        Me.grpOptions.Location = New System.Drawing.Point(238, 24)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(200, 167)
        Me.grpOptions.TabIndex = 5
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkPersonalTrainer
        '
        Me.chkPersonalTrainer.AutoSize = True
        Me.chkPersonalTrainer.Location = New System.Drawing.Point(32, 119)
        Me.chkPersonalTrainer.Name = "chkPersonalTrainer"
        Me.chkPersonalTrainer.Size = New System.Drawing.Size(136, 21)
        Me.chkPersonalTrainer.TabIndex = 2
        Me.chkPersonalTrainer.Text = "&Personal Trainer"
        Me.chkPersonalTrainer.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.AutoSize = True
        Me.chkKarate.Location = New System.Drawing.Point(32, 75)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(72, 21)
        Me.chkKarate.TabIndex = 1
        Me.chkKarate.Text = "&Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.AutoSize = True
        Me.chkYoga.Location = New System.Drawing.Point(32, 32)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(63, 21)
        Me.chkYoga.TabIndex = 0
        Me.chkYoga.Text = "&Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(49, 339)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 35)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(183, 339)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 35)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(317, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 385)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(450, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'frmHealthClub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 407)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpMemberFees)
        Me.Controls.Add(Me.grpMemberTypes)
        Me.Controls.Add(Me.grpMemberLength)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHealthClub"
        Me.ShowIcon = False
        Me.Text = "Membership Fee Calculator"
        Me.grpMemberLength.ResumeLayout(False)
        Me.grpMemberLength.PerformLayout()
        Me.grpMemberTypes.ResumeLayout(False)
        Me.grpMemberTypes.PerformLayout()
        Me.grpMemberFees.ResumeLayout(False)
        Me.grpMemberFees.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpMemberLength As GroupBox
    Friend WithEvents grpMemberTypes As GroupBox
    Friend WithEvents grpMemberFees As GroupBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblMemberLength As Label
    Friend WithEvents txtMemberLength As TextBox
    Friend WithEvents rbSenior As RadioButton
    Friend WithEvents rbStudent As RadioButton
    Friend WithEvents rbChild As RadioButton
    Friend WithEvents rbAdult As RadioButton
    Friend WithEvents chkPersonalTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtMonthlyFee As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
