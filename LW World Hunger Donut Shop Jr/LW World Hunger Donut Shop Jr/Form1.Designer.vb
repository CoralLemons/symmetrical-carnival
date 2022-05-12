<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWHDSjr
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpFood = New System.Windows.Forms.GroupBox()
        Me.rbCake = New System.Windows.Forms.RadioButton()
        Me.rbSprinkles = New System.Windows.Forms.RadioButton()
        Me.rbGlazed = New System.Windows.Forms.RadioButton()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTendered = New System.Windows.Forms.Label()
        Me.lblChangeDue = New System.Windows.Forms.Label()
        Me.chkCoffee = New System.Windows.Forms.CheckBox()
        Me.txtChangeDue = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTendered = New System.Windows.Forms.TextBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.grpFood.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(272, 363)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 33)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(55, 363)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 33)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'grpFood
        '
        Me.grpFood.Controls.Add(Me.rbCake)
        Me.grpFood.Controls.Add(Me.rbSprinkles)
        Me.grpFood.Controls.Add(Me.rbGlazed)
        Me.grpFood.Location = New System.Drawing.Point(242, 33)
        Me.grpFood.Name = "grpFood"
        Me.grpFood.Size = New System.Drawing.Size(137, 171)
        Me.grpFood.TabIndex = 3
        Me.grpFood.TabStop = False
        Me.grpFood.Text = "&Food"
        '
        'rbCake
        '
        Me.rbCake.AutoSize = True
        Me.rbCake.Location = New System.Drawing.Point(25, 117)
        Me.rbCake.Name = "rbCake"
        Me.rbCake.Size = New System.Drawing.Size(61, 21)
        Me.rbCake.TabIndex = 2
        Me.rbCake.TabStop = True
        Me.rbCake.Text = "Ca&ke"
        Me.rbCake.UseVisualStyleBackColor = True
        '
        'rbSprinkles
        '
        Me.rbSprinkles.AutoSize = True
        Me.rbSprinkles.Location = New System.Drawing.Point(25, 75)
        Me.rbSprinkles.Name = "rbSprinkles"
        Me.rbSprinkles.Size = New System.Drawing.Size(87, 21)
        Me.rbSprinkles.TabIndex = 1
        Me.rbSprinkles.TabStop = True
        Me.rbSprinkles.Text = "&Sprinkles"
        Me.rbSprinkles.UseVisualStyleBackColor = True
        '
        'rbGlazed
        '
        Me.rbGlazed.AutoSize = True
        Me.rbGlazed.Location = New System.Drawing.Point(25, 33)
        Me.rbGlazed.Name = "rbGlazed"
        Me.rbGlazed.Size = New System.Drawing.Size(74, 21)
        Me.rbGlazed.TabIndex = 0
        Me.rbGlazed.TabStop = True
        Me.rbGlazed.Text = "&Glazed"
        Me.rbGlazed.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(89, 51)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(61, 17)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "&Quantity"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(99, 227)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 17)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total"
        '
        'lblTendered
        '
        Me.lblTendered.AutoSize = True
        Me.lblTendered.Location = New System.Drawing.Point(261, 227)
        Me.lblTendered.Name = "lblTendered"
        Me.lblTendered.Size = New System.Drawing.Size(70, 17)
        Me.lblTendered.TabIndex = 4
        Me.lblTendered.Text = "&Tendered"
        '
        'lblChangeDue
        '
        Me.lblChangeDue.AutoSize = True
        Me.lblChangeDue.Location = New System.Drawing.Point(88, 312)
        Me.lblChangeDue.Name = "lblChangeDue"
        Me.lblChangeDue.Size = New System.Drawing.Size(91, 17)
        Me.lblChangeDue.TabIndex = 9
        Me.lblChangeDue.Text = "Change Due:"
        '
        'chkCoffee
        '
        Me.chkCoffee.AutoSize = True
        Me.chkCoffee.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCoffee.Location = New System.Drawing.Point(91, 141)
        Me.chkCoffee.Name = "chkCoffee"
        Me.chkCoffee.Size = New System.Drawing.Size(75, 21)
        Me.chkCoffee.TabIndex = 2
        Me.chkCoffee.Text = "&Coffee:"
        Me.chkCoffee.UseVisualStyleBackColor = True
        '
        'txtChangeDue
        '
        Me.txtChangeDue.Location = New System.Drawing.Point(196, 312)
        Me.txtChangeDue.Name = "txtChangeDue"
        Me.txtChangeDue.ReadOnly = True
        Me.txtChangeDue.Size = New System.Drawing.Size(130, 22)
        Me.txtChangeDue.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(63, 247)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(112, 22)
        Me.txtTotal.TabIndex = 9
        '
        'txtTendered
        '
        Me.txtTendered.Location = New System.Drawing.Point(240, 247)
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.Size = New System.Drawing.Size(112, 22)
        Me.txtTendered.TabIndex = 5
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(59, 72)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 22)
        Me.nudQuantity.TabIndex = 1
        '
        'frmWHDSjr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(415, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.txtTendered)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtChangeDue)
        Me.Controls.Add(Me.chkCoffee)
        Me.Controls.Add(Me.lblChangeDue)
        Me.Controls.Add(Me.lblTendered)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.grpFood)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWHDSjr"
        Me.ShowIcon = False
        Me.Text = "World Hunger Donut Shop Jr"
        Me.grpFood.ResumeLayout(False)
        Me.grpFood.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents grpFood As GroupBox
    Friend WithEvents rbCake As RadioButton
    Friend WithEvents rbSprinkles As RadioButton
    Friend WithEvents rbGlazed As RadioButton
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTendered As Label
    Friend WithEvents lblChangeDue As Label
    Friend WithEvents chkCoffee As CheckBox
    Friend WithEvents txtChangeDue As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTendered As TextBox
    Friend WithEvents nudQuantity As NumericUpDown
End Class
