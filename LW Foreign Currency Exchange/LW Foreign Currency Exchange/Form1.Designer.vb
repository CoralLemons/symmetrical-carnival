<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFCE
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
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.grpStability = New System.Windows.Forms.GroupBox()
        Me.lblExchangeRate = New System.Windows.Forms.Label()
        Me.lblExchangeVal = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.nudRate = New System.Windows.Forms.NumericUpDown()
        Me.txtExchangeValue = New System.Windows.Forms.TextBox()
        Me.txtCommission = New System.Windows.Forms.TextBox()
        Me.rbGood = New System.Windows.Forms.RadioButton()
        Me.rbModerate = New System.Windows.Forms.RadioButton()
        Me.rbPoor = New System.Windows.Forms.RadioButton()
        Me.txtDollars = New System.Windows.Forms.TextBox()
        Me.grpStability.SuspendLayout()
        CType(Me.nudRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Location = New System.Drawing.Point(127, 56)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(56, 17)
        Me.lblDollars.TabIndex = 0
        Me.lblDollars.Text = "&Dollars:"
        '
        'grpStability
        '
        Me.grpStability.Controls.Add(Me.rbPoor)
        Me.grpStability.Controls.Add(Me.rbModerate)
        Me.grpStability.Controls.Add(Me.rbGood)
        Me.grpStability.Location = New System.Drawing.Point(248, 114)
        Me.grpStability.Name = "grpStability"
        Me.grpStability.Size = New System.Drawing.Size(119, 144)
        Me.grpStability.TabIndex = 3
        Me.grpStability.TabStop = False
        Me.grpStability.Text = "Currency Stability"
        '
        'lblExchangeRate
        '
        Me.lblExchangeRate.AutoSize = True
        Me.lblExchangeRate.Location = New System.Drawing.Point(57, 163)
        Me.lblExchangeRate.Name = "lblExchangeRate"
        Me.lblExchangeRate.Size = New System.Drawing.Size(104, 17)
        Me.lblExchangeRate.TabIndex = 2
        Me.lblExchangeRate.Text = "Exchange &Rate"
        '
        'lblExchangeVal
        '
        Me.lblExchangeVal.AutoSize = True
        Me.lblExchangeVal.Location = New System.Drawing.Point(61, 289)
        Me.lblExchangeVal.Name = "lblExchangeVal"
        Me.lblExchangeVal.Size = New System.Drawing.Size(110, 17)
        Me.lblExchangeVal.TabIndex = 3
        Me.lblExchangeVal.Text = "Exchange Value"
        '
        'lblCommission
        '
        Me.lblCommission.AutoSize = True
        Me.lblCommission.Location = New System.Drawing.Point(267, 289)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(83, 17)
        Me.lblCommission.TabIndex = 4
        Me.lblCommission.Text = "Commission"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(171, 368)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'nudRate
        '
        Me.nudRate.Location = New System.Drawing.Point(49, 189)
        Me.nudRate.Name = "nudRate"
        Me.nudRate.Size = New System.Drawing.Size(120, 22)
        Me.nudRate.TabIndex = 2
        Me.nudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtExchangeValue
        '
        Me.txtExchangeValue.Location = New System.Drawing.Point(55, 314)
        Me.txtExchangeValue.Name = "txtExchangeValue"
        Me.txtExchangeValue.ReadOnly = True
        Me.txtExchangeValue.Size = New System.Drawing.Size(123, 22)
        Me.txtExchangeValue.TabIndex = 7
        Me.txtExchangeValue.TabStop = False
        '
        'txtCommission
        '
        Me.txtCommission.Location = New System.Drawing.Point(255, 314)
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.ReadOnly = True
        Me.txtCommission.Size = New System.Drawing.Size(107, 22)
        Me.txtCommission.TabIndex = 8
        Me.txtCommission.TabStop = False
        '
        'rbGood
        '
        Me.rbGood.AutoSize = True
        Me.rbGood.Location = New System.Drawing.Point(13, 49)
        Me.rbGood.Name = "rbGood"
        Me.rbGood.Size = New System.Drawing.Size(64, 21)
        Me.rbGood.TabIndex = 0
        Me.rbGood.TabStop = True
        Me.rbGood.Text = "&Good"
        Me.rbGood.UseVisualStyleBackColor = True
        '
        'rbModerate
        '
        Me.rbModerate.AutoSize = True
        Me.rbModerate.Location = New System.Drawing.Point(13, 76)
        Me.rbModerate.Name = "rbModerate"
        Me.rbModerate.Size = New System.Drawing.Size(89, 21)
        Me.rbModerate.TabIndex = 1
        Me.rbModerate.TabStop = True
        Me.rbModerate.Text = "&Moderate"
        Me.rbModerate.UseVisualStyleBackColor = True
        '
        'rbPoor
        '
        Me.rbPoor.AutoSize = True
        Me.rbPoor.Location = New System.Drawing.Point(12, 103)
        Me.rbPoor.Name = "rbPoor"
        Me.rbPoor.Size = New System.Drawing.Size(59, 21)
        Me.rbPoor.TabIndex = 2
        Me.rbPoor.TabStop = True
        Me.rbPoor.Text = "&Poor"
        Me.rbPoor.UseVisualStyleBackColor = True
        '
        'txtDollars
        '
        Me.txtDollars.Location = New System.Drawing.Point(190, 53)
        Me.txtDollars.Name = "txtDollars"
        Me.txtDollars.Size = New System.Drawing.Size(100, 22)
        Me.txtDollars.TabIndex = 1
        Me.txtDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmFCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 424)
        Me.Controls.Add(Me.txtDollars)
        Me.Controls.Add(Me.txtCommission)
        Me.Controls.Add(Me.txtExchangeValue)
        Me.Controls.Add(Me.nudRate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.lblExchangeVal)
        Me.Controls.Add(Me.lblExchangeRate)
        Me.Controls.Add(Me.grpStability)
        Me.Controls.Add(Me.lblDollars)
        Me.Name = "frmFCE"
        Me.ShowIcon = False
        Me.Text = "Foreign Currency Exchange"
        Me.grpStability.ResumeLayout(False)
        Me.grpStability.PerformLayout()
        CType(Me.nudRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDollars As Label
    Friend WithEvents grpStability As GroupBox
    Friend WithEvents rbPoor As RadioButton
    Friend WithEvents rbModerate As RadioButton
    Friend WithEvents rbGood As RadioButton
    Friend WithEvents lblExchangeRate As Label
    Friend WithEvents lblExchangeVal As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents nudRate As NumericUpDown
    Friend WithEvents txtExchangeValue As TextBox
    Friend WithEvents txtCommission As TextBox
    Friend WithEvents txtDollars As TextBox
End Class
