<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRNGame
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
        Me.grpDifficulty = New System.Windows.Forms.GroupBox()
        Me.rbEasy = New System.Windows.Forms.RadioButton()
        Me.rbMedium = New System.Windows.Forms.RadioButton()
        Me.rbHard = New System.Windows.Forms.RadioButton()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.grpDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDifficulty
        '
        Me.grpDifficulty.Controls.Add(Me.rbHard)
        Me.grpDifficulty.Controls.Add(Me.rbMedium)
        Me.grpDifficulty.Controls.Add(Me.rbEasy)
        Me.grpDifficulty.Location = New System.Drawing.Point(34, 66)
        Me.grpDifficulty.Name = "grpDifficulty"
        Me.grpDifficulty.Size = New System.Drawing.Size(452, 87)
        Me.grpDifficulty.TabIndex = 0
        Me.grpDifficulty.TabStop = False
        Me.grpDifficulty.Text = "&Difficulty Selection"
        '
        'rbEasy
        '
        Me.rbEasy.AutoSize = True
        Me.rbEasy.Location = New System.Drawing.Point(42, 33)
        Me.rbEasy.Name = "rbEasy"
        Me.rbEasy.Size = New System.Drawing.Size(60, 21)
        Me.rbEasy.TabIndex = 0
        Me.rbEasy.TabStop = True
        Me.rbEasy.Text = "Easy"
        Me.rbEasy.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Location = New System.Drawing.Point(187, 33)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(78, 21)
        Me.rbMedium.TabIndex = 1
        Me.rbMedium.TabStop = True
        Me.rbMedium.Text = "Medium"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbHard
        '
        Me.rbHard.AutoSize = True
        Me.rbHard.Location = New System.Drawing.Point(350, 33)
        Me.rbHard.Name = "rbHard"
        Me.rbHard.Size = New System.Drawing.Size(60, 21)
        Me.rbHard.TabIndex = 2
        Me.rbHard.TabStop = True
        Me.rbHard.Text = "Hard"
        Me.rbHard.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(79, 186)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(102, 41)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "&Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(339, 186)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 41)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDescription.Location = New System.Drawing.Point(98, 21)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(325, 20)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Select the game difficulty, then press play!"
        '
        'frmRNGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 258)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.grpDifficulty)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRNGame"
        Me.ShowIcon = False
        Me.Text = "Random Number Guessing Game"
        Me.grpDifficulty.ResumeLayout(False)
        Me.grpDifficulty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpDifficulty As GroupBox
    Friend WithEvents rbHard As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents rbEasy As RadioButton
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDescription As Label
End Class
