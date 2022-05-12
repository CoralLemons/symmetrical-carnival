Option Strict On
' Leeann Warren
' Exam 2: Math game


Public Class frmGame
    Dim gintMaxRange, gintUserGuess, gintCorrectGuessCount, gintRandOne, gintRandTwo, gintRNTotal As Integer
    Dim strHolder As String
    Private Sub subPlay()
        gintCorrectGuessCount = 0
        Do Until gintCorrectGuessCount = 3
            subNumbers()
            strHolder = InputBox(gintRandOne & " + " & gintRandTwo, "Evaluate the expresssion", "0")
            If Integer.TryParse(strHolder, gintUserGuess) = False Then
                If strHolder = String.Empty Then
                    Exit Do
                Else
                    MsgBox("Please enter a valid number!",, "Try again!")
                End If
            ElseIf Integer.TryParse(strHolder, gintUserGuess) Then
                If gintUserGuess = gintRNTotal Then
                    gintCorrectGuessCount = gintCorrectGuessCount + 1
                    If gintCorrectGuessCount < 3 Then
                        MsgBox("That is correct! Win " & (3 - gintCorrectGuessCount) & " more round(s) in a row.",, "Congratulations!")
                    End If
                Else
                    MsgBox("Please try again! Your streak has been reset! Win 3 rounds in a row!",, "Oops, try again!")
                    gintCorrectGuessCount = 0
                End If
            End If
        Loop

        If gintCorrectGuessCount = 3 Then
            MsgBox("Hooray! You won 3 games in a row! Celebrate your achievement with a self high-five!",, "Whoa, cool!")
        End If
    End Sub
    Private Sub subNumbers()
        Dim randomNumber As New Random
        gintRandOne = randomNumber.Next(1, gintMaxRange)
        gintRandTwo = randomNumber.Next(1, gintMaxRange)
        gintRNTotal = gintRandOne + gintRandTwo
    End Sub
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        subPlay()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rbEasy_CheckedChanged(sender As Object, e As EventArgs) Handles rbEasy.CheckedChanged
        If rbEasy.Checked Then
            gintMaxRange = 11
        End If
    End Sub

    Private Sub rbMedium_CheckedChanged(sender As Object, e As EventArgs) Handles rbMedium.CheckedChanged
        If rbMedium.Checked Then
            gintMaxRange = 101
        End If
    End Sub

    Private Sub rbHard_CheckedChanged(sender As Object, e As EventArgs) Handles rbHard.CheckedChanged
        If rbHard.Checked Then
            gintMaxRange = 1001
        End If
    End Sub
End Class
