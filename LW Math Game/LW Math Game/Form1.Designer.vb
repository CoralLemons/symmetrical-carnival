<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbHard = New System.Windows.Forms.RadioButton()
        Me.rbMedium = New System.Windows.Forms.RadioButton()
        Me.rbEasy = New System.Windows.Forms.RadioButton()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbHard)
        Me.GroupBox1.Controls.Add(Me.rbMedium)
        Me.GroupBox1.Controls.Add(Me.rbEasy)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Difficulty"
        '
        'rbHard
        '
        Me.rbHard.AutoSize = True
        Me.rbHard.Location = New System.Drawing.Point(41, 150)
        Me.rbHard.Name = "rbHard"
        Me.rbHard.Size = New System.Drawing.Size(60, 21)
        Me.rbHard.TabIndex = 2
        Me.rbHard.TabStop = True
        Me.rbHard.Text = "Hard"
        Me.rbHard.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Location = New System.Drawing.Point(41, 90)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(78, 21)
        Me.rbMedium.TabIndex = 1
        Me.rbMedium.TabStop = True
        Me.rbMedium.Text = "Medium"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbEasy
        '
        Me.rbEasy.AutoSize = True
        Me.rbEasy.Location = New System.Drawing.Point(41, 30)
        Me.rbEasy.Name = "rbEasy"
        Me.rbEasy.Size = New System.Drawing.Size(60, 21)
        Me.rbEasy.TabIndex = 0
        Me.rbEasy.TabStop = True
        Me.rbEasy.Text = "Easy"
        Me.rbEasy.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(201, 32)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(102, 57)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(201, 145)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 57)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 235)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGame"
        Me.ShowIcon = False
        Me.Text = "Math Game"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbHard As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents rbEasy As RadioButton
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnClose As Button
End Class
