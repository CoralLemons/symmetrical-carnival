Option Strict On
' Leeann Warren
' min rate = 0.5
' max rate = 1.5
' good  = 1%
' moderate = 2%
' poor = 3%

Public Class frmFCE
    Dim gdecDollars, gdecExchangeValue, gdecCurrencyStab As Decimal
    Private Sub subCalculate()
        gdecExchangeValue = Math.Round(gdecDollars * nudRate.Value, 2, MidpointRounding.AwayFromZero) ' remember this, forgot on test
        txtExchangeValue.Text = Format(gdecExchangeValue, "Currency")
        subCalcCommission()
    End Sub
    Public Sub subReset()
        txtDollars.Focus()
        txtDollars.Text = "$0.00"
        txtDollars.SelectAll()
        rbGood.Checked = True
        nudRate.Value = 1

    End Sub
    Private Sub subCalcCommission()
        txtCommission.Text = Format(gdecExchangeValue * gdecCurrencyStab, "Currency")
    End Sub
    Private Sub frmFCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right ' just because this suggests to delete the greyed, dont
        nudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        txtCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        txtExchangeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        nudRate.Increment = 0.01D
        nudRate.DecimalPlaces = 2
        nudRate.Maximum = 1.5D
        nudRate.Minimum = 0.5D
        txtExchangeValue.Text = "$0.00"
        subReset()
    End Sub

    Private Sub rbGood_CheckedChanged(sender As Object, e As EventArgs) Handles rbGood.CheckedChanged
        If rbGood.Checked Then
            gdecCurrencyStab = 0.01D
            subCalculate()
            subCalcCommission()
        End If
    End Sub

    Private Sub rbModerate_CheckedChanged(sender As Object, e As EventArgs) Handles rbModerate.CheckedChanged
        If rbModerate.Checked Then
            gdecCurrencyStab = 0.02D
            subCalculate()
            subCalcCommission()
        End If
    End Sub

    Private Sub rbPoor_CheckedChanged(sender As Object, e As EventArgs) Handles rbPoor.CheckedChanged
        If rbPoor.Checked Then
            gdecCurrencyStab = 0.03D
            subCalculate()
            subCalcCommission()
        End If
    End Sub

    Private Sub nudRate_ValueChanged(sender As Object, e As EventArgs) Handles nudRate.ValueChanged
        subCalculate()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        subReset()
    End Sub

    Private Sub txtDollars_TextChanged(sender As Object, e As EventArgs) Handles txtDollars.TextChanged
        If txtDollars.Focused Then
            gdecDollars = CDec("0" & Format(txtDollars.Text, "Standard"))
            subCalculate()
        End If
    End Sub

    Private Sub txtDollars_LostFocus(sender As Object, e As EventArgs) Handles txtDollars.LostFocus
        txtDollars.Text = Format(txtDollars.Text, "Currency")
    End Sub
End Class
