Option Strict On
' Leeann Warren

Public Class frmMcCoys
    Dim gdecPintsCost, gdecChkMultiply, gdecHatfield, gdecPintsAmount As Decimal
    Private Sub subReset()
        txtPints.Focus()
        txtPints.Text = "0"
        txtPints.SelectAll()
        rbLight.Checked = True
        rbLight.Checked = False
        rbLight.TabStop = True
        chkHatfield.Checked = False
        gdecHatfield = 1
        txtPintCost.Text = "0.00"
        txtIncome.Text = "$0.00"
    End Sub
    Private Sub frmMcCoys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subReset()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        subReset()
    End Sub
    Private Sub subCalcIncome()
        txtIncome.Text = Format((gdecPintsCost + gdecChkMultiply) * gdecPintsAmount * gdecHatfield, "Currency")
    End Sub
    Private Sub rbLight_CheckedChanged(sender As Object, e As EventArgs) Handles rbLight.CheckedChanged
        If rbLight.Checked Then
            gdecChkMultiply = 1
            subCalcIncome()
        Else
            gdecChkMultiply = 0
            subCalcIncome()
        End If

    End Sub

    Private Sub rbMedium_CheckedChanged(sender As Object, e As EventArgs) Handles rbMedium.CheckedChanged
        If rbMedium.Checked Then
            gdecChkMultiply = 2
            subCalcIncome()
        Else
            gdecChkMultiply = 0
            subCalcIncome()
        End If

    End Sub

    Private Sub rbDark_CheckedChanged(sender As Object, e As EventArgs) Handles rbDark.CheckedChanged
        If rbDark.Checked Then
            gdecChkMultiply = 3
            subCalcIncome()
        Else
            gdecChkMultiply = 0
            subCalcIncome()
        End If
    End Sub

    Private Sub txtPintCost_TextChanged(sender As Object, e As EventArgs) Handles txtPintCost.TextChanged
        If txtPintCost.Focused Then
            gdecPintsCost = CDec("0" & Format(txtPintCost.Text, "Standard"))
            subCalcIncome()
        End If
    End Sub

    Private Sub txtPints_TextChanged(sender As Object, e As EventArgs) Handles txtPints.TextChanged
        If txtPints.Focused Then
            gdecPintsAmount = CDec("0" & Format(txtPints.Text, "Standard"))
            subCalcIncome()
        End If
    End Sub
    Private Sub chkHatfield_CheckedChanged(sender As Object, e As EventArgs) Handles chkHatfield.CheckedChanged
        If chkHatfield.Checked Then
            gdecHatfield = 100
            subCalcIncome()
        ElseIf chkHatfield.Checked = False Then
            gdecHatfield = 1
            subCalcIncome()
        End If
    End Sub

    Private Sub txtPintCost_LostFocus(sender As Object, e As EventArgs) Handles txtPintCost.LostFocus
        txtPintCost.Text = Format(txtPintCost.Text, "Standard")
    End Sub
End Class
