Option Strict On
' Leeann Warren
' This program provides crude driving directions to the location on the map in the window
' the user is able to toggle the directions display and click the close button to exit the window


Public Class frmDriveDr
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click

        If lblDirections.Visible = True Then
            lblDirections.Visible = False
            btnShowHide.Text = "Show Directions"
        Else
            lblDirections.Visible = True
            btnShowHide.Text = "Hide Directions"
        End If

    End Sub

End Class
