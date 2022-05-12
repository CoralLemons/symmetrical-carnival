Option Strict On
' Leeann Warren

' Fix label names, add numonics


Public Class frmHealthClub
    Dim gintMemberPriceSelect, gintMonths, gintYoga, gintKarate, gintTrainer, gintMonthlyFee, gintTotal As Integer

    Private Sub rbChild_CheckedChanged(sender As Object, e As EventArgs) Handles rbChild.CheckedChanged
        If rbChild.Checked Then
            gintMemberPriceSelect = 20
        End If
    End Sub

    Private Sub rbStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rbStudent.CheckedChanged
        If rbStudent.Checked Then
            gintMemberPriceSelect = 25
        End If
    End Sub

    Private Sub rbSenior_CheckedChanged(sender As Object, e As EventArgs) Handles rbSenior.CheckedChanged
        If rbSenior.Checked Then
            gintMemberPriceSelect = 30

        End If
    End Sub

    Private Sub chkYoga_CheckedChanged(sender As Object, e As EventArgs) Handles chkYoga.CheckedChanged
        If chkYoga.Checked Then
            gintYoga = 10
        Else
            gintYoga = 0
        End If
    End Sub

    Private Sub chkKarate_CheckedChanged(sender As Object, e As EventArgs) Handles chkKarate.CheckedChanged
        If chkKarate.Checked Then
            gintKarate = 30
        Else
            gintKarate = 0
        End If
    End Sub

    Private Sub chkPersonalTrainer_CheckedChanged(sender As Object, e As EventArgs) Handles chkPersonalTrainer.CheckedChanged
        If chkPersonalTrainer.Checked Then
            gintTrainer = 50
        Else
            gintTrainer = 0
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        subReset()
    End Sub

    Private Sub frmHealthClub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subReset()
    End Sub

    Private Sub txtMemberLength_TextChanged(sender As Object, e As EventArgs) Handles txtMemberLength.TextChanged
        ' this part is important, will be part of exam so make sure to know how to do tryParse
        If txtMemberLength.Focused Then
            If Integer.TryParse(txtMemberLength.Text, gintMonths) = False Then
                btnCalculate.Enabled = False
                lblStatus.Text = "Months must be an integer"
            ElseIf gintMonths < 1 OrElse gintMonths > 24 Then
                btnCalculate.Enabled = False
                lblStatus.Text = "Months must be between the range 1 - 24"
            Else
                btnCalculate.Enabled = True
                lblStatus.Text = String.Empty

            End If
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        gintMonthlyFee = gintMemberPriceSelect + gintKarate + gintTrainer + gintYoga
        txtMonthlyFee.Text = Format(gintMonthlyFee, "Currency")
        txtTotal.Text = Format(gintMonthlyFee * gintMonths, "Currency")
    End Sub

    Private Sub rbAdult_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdult.CheckedChanged
        If rbAdult.Checked Then
            gintMemberPriceSelect = 40
        End If
    End Sub

    Private Sub subReset()
        rbAdult.Checked = True
        chkKarate.Checked = False
        chkPersonalTrainer.Checked = False
        chkYoga.Checked = False
        txtMemberLength.Focus()
        txtMemberLength.SelectAll()
        txtMemberLength.Text = String.Empty
        txtMonthlyFee.Text = String.Empty
        txtTotal.Text = String.Empty
        lblStatus.Text = "Months must be in the range of 1-24"
        btnCalculate.Enabled = False

    End Sub

End Class
