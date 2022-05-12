<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSBM
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
        Me.cmboMode = New System.Windows.Forms.ComboBox()
        Me.cmboMonth = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmboMode
        '
        Me.cmboMode.FormattingEnabled = True
        Me.cmboMode.Items.AddRange(New Object() {"Sum", "Count"})
        Me.cmboMode.Location = New System.Drawing.Point(87, 52)
        Me.cmboMode.Name = "cmboMode"
        Me.cmboMode.Size = New System.Drawing.Size(121, 24)
        Me.cmboMode.TabIndex = 0
        '
        'cmboMonth
        '
        Me.cmboMonth.FormattingEnabled = True
        Me.cmboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmboMonth.Location = New System.Drawing.Point(87, 112)
        Me.cmboMonth.Name = "cmboMonth"
        Me.cmboMonth.Size = New System.Drawing.Size(121, 24)
        Me.cmboMonth.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(105, 168)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(85, 27)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(105, 231)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(85, 27)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmSBM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 310)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cmboMonth)
        Me.Controls.Add(Me.cmboMode)
        Me.Name = "frmSBM"
        Me.ShowIcon = False
        Me.Text = "Sales By Month"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmboMode As ComboBox
    Friend WithEvents cmboMonth As ComboBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnReset As Button
End Class
