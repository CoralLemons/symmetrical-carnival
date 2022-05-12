<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMcCoys
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
        Me.lblUntaxIncome = New System.Windows.Forms.Label()
        Me.lblMoonPintCost = New System.Windows.Forms.Label()
        Me.lblPints = New System.Windows.Forms.Label()
        Me.chkHatfield = New System.Windows.Forms.CheckBox()
        Me.grpMolasses = New System.Windows.Forms.GroupBox()
        Me.rbDark = New System.Windows.Forms.RadioButton()
        Me.rbMedium = New System.Windows.Forms.RadioButton()
        Me.rbLight = New System.Windows.Forms.RadioButton()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.txtPintCost = New System.Windows.Forms.TextBox()
        Me.txtPints = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpMolasses.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUntaxIncome
        '
        Me.lblUntaxIncome.AutoSize = True
        Me.lblUntaxIncome.Location = New System.Drawing.Point(38, 249)
        Me.lblUntaxIncome.Name = "lblUntaxIncome"
        Me.lblUntaxIncome.Size = New System.Drawing.Size(124, 17)
        Me.lblUntaxIncome.TabIndex = 6
        Me.lblUntaxIncome.Text = "Untaxable Income:"
        '
        'lblMoonPintCost
        '
        Me.lblMoonPintCost.AutoSize = True
        Me.lblMoonPintCost.Location = New System.Drawing.Point(41, 59)
        Me.lblMoonPintCost.Name = "lblMoonPintCost"
        Me.lblMoonPintCost.Size = New System.Drawing.Size(117, 17)
        Me.lblMoonPintCost.TabIndex = 2
        Me.lblMoonPintCost.Text = "&Moonshine Pint $"
        '
        'lblPints
        '
        Me.lblPints.AutoSize = True
        Me.lblPints.Location = New System.Drawing.Point(115, 21)
        Me.lblPints.Name = "lblPints"
        Me.lblPints.Size = New System.Drawing.Size(43, 17)
        Me.lblPints.TabIndex = 0
        Me.lblPints.Text = "&Pints:"
        '
        'chkHatfield
        '
        Me.chkHatfield.AutoSize = True
        Me.chkHatfield.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHatfield.Location = New System.Drawing.Point(43, 159)
        Me.chkHatfield.Name = "chkHatfield"
        Me.chkHatfield.Size = New System.Drawing.Size(82, 21)
        Me.chkHatfield.TabIndex = 4
        Me.chkHatfield.Text = "&Hatfield:"
        Me.chkHatfield.UseVisualStyleBackColor = True
        '
        'grpMolasses
        '
        Me.grpMolasses.Controls.Add(Me.rbDark)
        Me.grpMolasses.Controls.Add(Me.rbMedium)
        Me.grpMolasses.Controls.Add(Me.rbLight)
        Me.grpMolasses.Location = New System.Drawing.Point(163, 104)
        Me.grpMolasses.Name = "grpMolasses"
        Me.grpMolasses.Size = New System.Drawing.Size(135, 121)
        Me.grpMolasses.TabIndex = 5
        Me.grpMolasses.TabStop = False
        Me.grpMolasses.Text = "M&olasses"
        '
        'rbDark
        '
        Me.rbDark.AutoSize = True
        Me.rbDark.Location = New System.Drawing.Point(28, 89)
        Me.rbDark.Name = "rbDark"
        Me.rbDark.Size = New System.Drawing.Size(59, 21)
        Me.rbDark.TabIndex = 2
        Me.rbDark.TabStop = True
        Me.rbDark.Text = "Dark"
        Me.rbDark.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Location = New System.Drawing.Point(28, 54)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(78, 21)
        Me.rbMedium.TabIndex = 1
        Me.rbMedium.TabStop = True
        Me.rbMedium.Text = "Medium"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbLight
        '
        Me.rbLight.AutoSize = True
        Me.rbLight.Location = New System.Drawing.Point(28, 18)
        Me.rbLight.Name = "rbLight"
        Me.rbLight.Size = New System.Drawing.Size(60, 21)
        Me.rbLight.TabIndex = 0
        Me.rbLight.TabStop = True
        Me.rbLight.Text = "Light"
        Me.rbLight.UseVisualStyleBackColor = True
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(168, 246)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.ReadOnly = True
        Me.txtIncome.Size = New System.Drawing.Size(135, 22)
        Me.txtIncome.TabIndex = 8
        Me.txtIncome.TabStop = False
        Me.txtIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPintCost
        '
        Me.txtPintCost.Location = New System.Drawing.Point(164, 56)
        Me.txtPintCost.Name = "txtPintCost"
        Me.txtPintCost.Size = New System.Drawing.Size(135, 22)
        Me.txtPintCost.TabIndex = 3
        Me.txtPintCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPints
        '
        Me.txtPints.Location = New System.Drawing.Point(164, 18)
        Me.txtPints.Name = "txtPints"
        Me.txtPints.Size = New System.Drawing.Size(135, 22)
        Me.txtPints.TabIndex = 1
        Me.txtPints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(126, 285)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 30)
        Me.btnReset.TabIndex = 6
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmMcCoys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(341, 327)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtPints)
        Me.Controls.Add(Me.txtPintCost)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.grpMolasses)
        Me.Controls.Add(Me.chkHatfield)
        Me.Controls.Add(Me.lblPints)
        Me.Controls.Add(Me.lblMoonPintCost)
        Me.Controls.Add(Me.lblUntaxIncome)
        Me.Name = "frmMcCoys"
        Me.ShowIcon = False
        Me.Text = "McCoy's Moonshine & Molasses"
        Me.grpMolasses.ResumeLayout(False)
        Me.grpMolasses.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUntaxIncome As Label
    Friend WithEvents lblMoonPintCost As Label
    Friend WithEvents lblPints As Label
    Friend WithEvents chkHatfield As CheckBox
    Friend WithEvents grpMolasses As GroupBox
    Friend WithEvents rbDark As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents rbLight As RadioButton
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents txtPintCost As TextBox
    Friend WithEvents txtPints As TextBox
    Friend WithEvents btnReset As Button

End Class
