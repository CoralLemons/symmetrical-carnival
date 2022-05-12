<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriveDr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDriveDr))
        Me.lblDirectionsTitle = New System.Windows.Forms.Label()
        Me.pbMap = New System.Windows.Forms.PictureBox()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnShowHide = New System.Windows.Forms.Button()
        CType(Me.pbMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDirectionsTitle
        '
        Me.lblDirectionsTitle.AutoSize = True
        Me.lblDirectionsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirectionsTitle.Location = New System.Drawing.Point(129, 9)
        Me.lblDirectionsTitle.Name = "lblDirectionsTitle"
        Me.lblDirectionsTitle.Size = New System.Drawing.Size(376, 36)
        Me.lblDirectionsTitle.TabIndex = 3
        Me.lblDirectionsTitle.Text = "Driving to Panda Express"
        '
        'pbMap
        '
        Me.pbMap.Image = CType(resources.GetObject("pbMap.Image"), System.Drawing.Image)
        Me.pbMap.Location = New System.Drawing.Point(122, 48)
        Me.pbMap.Name = "pbMap"
        Me.pbMap.Size = New System.Drawing.Size(390, 403)
        Me.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMap.TabIndex = 1
        Me.pbMap.TabStop = False
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Location = New System.Drawing.Point(3, 473)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(620, 51)
        Me.lblDirections.TabIndex = 2
        Me.lblDirections.Text = resources.GetString("lblDirections.Text")
        Me.lblDirections.Visible = False
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(392, 546)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(167, 70)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnShowHide
        '
        Me.btnShowHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowHide.Location = New System.Drawing.Point(72, 546)
        Me.btnShowHide.Name = "btnShowHide"
        Me.btnShowHide.Size = New System.Drawing.Size(167, 70)
        Me.btnShowHide.TabIndex = 0
        Me.btnShowHide.Text = "Show Directions"
        Me.btnShowHide.UseVisualStyleBackColor = True
        '
        'frmDriveDr
        '
        Me.AcceptButton = Me.btnShowHide
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(635, 633)
        Me.Controls.Add(Me.btnShowHide)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.pbMap)
        Me.Controls.Add(Me.lblDirectionsTitle)
        Me.Name = "frmDriveDr"
        Me.ShowIcon = False
        Me.Text = "Directions to Panda Express"
        CType(Me.pbMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDirectionsTitle As Label
    Friend WithEvents pbMap As PictureBox
    Friend WithEvents lblDirections As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnShowHide As Button
End Class
