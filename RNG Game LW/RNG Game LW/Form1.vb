Option Strict On
' Leeann Warren
' RNG Number Guessing Game

'---------------------------------------------------------------
' InputBox("Prompt here:", "RNG Title", "Default Response")
' figure out a way to exit the game when exit btn or x clicked, not just when 
' the guess is correct
' use something to test text input

'' random numbers - generate when the user clicks play
'Dim intRandomNumber As New Random
'intRandomNumber.Next(1, 101) ' from 1 to 100

'' message box - use when the user loses, wins, etc when applicable
'' when the user presses ok go to menu
'MsgBox("Prompt", , "Title")

'' do-until loop for guessing, try this ig?
'' when the loop breaks, make sure to know if the user wins or loses using if statements AFTER LOOP
'' include tryParse, loops, me.close, check change
'----------------------------------------------------------------


Public Class frmRNGame
    ' this holds the max range based off the level selection chosen
    Dim gintMaxRange, gintRnValue, gintAttempts, gintUserGuess As Integer
    Dim gintBoxPrompt As String

    Private Sub rbEasy_CheckedChanged(sender As Object, e As EventArgs) Handles rbEasy.CheckedChanged
        If rbEasy.Checked Then
            gintMaxRange = 11
            gintAttempts = 3
        End If
    End Sub

    Private Sub rbMedium_CheckedChanged(sender As Object, e As EventArgs) Handles rbMedium.CheckedChanged
        If rbMedium.Checked Then
            gintMaxRange = 101
            gintAttempts = 5
        End If
    End Sub

    Private Sub rbHard_CheckedChanged(sender As Object, e As EventArgs) Handles rbHard.CheckedChanged
        If rbHard.Checked Then
            gintMaxRange = 1001
            gintAttempts = 7
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ' edit this to prompt user to check a box if play is pressed with no option selected
        subPlay()
    End Sub
    Private Sub subPlay() ' finish this
        Dim randomNumber As New Random
        Dim intCounter As Integer
        gintRnValue = randomNumber.Next(1, gintMaxRange)
        Console.WriteLine(gintRnValue)
        'gintBoxPrompt = InputBox("Guess a number between 1 and " & (gintMaxRange - 1), "Guess the Number!")
        ' use try parse to test the inputbox text to see if int or string

        intCounter = gintAttempts
        Do Until gintUserGuess = gintRnValue Or intCounter = 0
            gintBoxPrompt = InputBox("Guess a number between 1 and " & (gintMaxRange - 1), "Guess the Number!")
            If Integer.TryParse(gintBoxPrompt, gintUserGuess) = False Then
                If gintBoxPrompt = String.Empty Or gintBoxPrompt = vbNullString Then
                    Exit Do
                Else
                    MsgBox("Please enter a number between 1 and " & (gintMaxRange - 1),, "Try Again!")
                End If
            End If

            If Integer.TryParse(gintBoxPrompt, gintUserGuess) Then
                If gintUserGuess > gintMaxRange Or gintUserGuess < 1 Then
                    MsgBox("Your guess is outside of the range between 1 and " & (gintMaxRange - 1),, "Oops!")
                ElseIf gintUserGuess > gintRnValue Then
                    MsgBox("Your guess is too high! You have " & (intCounter - 1) & " attempts left.",, "Try again")
                    intCounter = intCounter - 1
                ElseIf gintUserGuess < gintRnValue Then
                    MsgBox("Your guess is too low! You have " & (intCounter - 1) & " attempts left.",, "Try again")
                    intCounter = intCounter - 1
                End If
            End If
        Loop

        If intCounter <= 0 Then
            MsgBox("Sorry, you did not guess the number and ran out of attempts!",, "Sorry, try again!")
        ElseIf gintUserGuess = gintRnValue Then
            MsgBox("You guessed the number " & gintRnValue & " correctly!",, "Congratulations!")
        End If

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
