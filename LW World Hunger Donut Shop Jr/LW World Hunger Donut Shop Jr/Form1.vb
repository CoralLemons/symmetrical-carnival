Option Strict On
' Leeann Warren
' Program calculates the price of the specified donut order, 
' the amount tendered, And how much money to return to (or ask from) the customer


Public Class frmWHDSjr

    Dim gdecCoffee, gdecDonutMultiplier, gdecTotal, gdecTendered, gdecChangeDue, gdecQuantity As Decimal
    Private Sub subCalculate()
        subCalcTotal()
        txtChangeDue.Text = Format(gdecTendered - gdecTotal, "Currency")
    End Sub
    Private Sub subCalcTotal()
        gdecTotal = CDec(Format((gdecQuantity * gdecDonutMultiplier) + (gdecCoffee * gdecQuantity), "Standard"))
        txtTotal.Text = Format(gdecTotal, "Currency")
    End Sub
    Private Sub subReset()
        txtTotal.Text = "$0.00"
        txtTendered.Text = "$0.00"
        txtChangeDue.Text = "$0.00"
        chkCoffee.Checked = False
        txtTotal.TabStop = False
        txtChangeDue.TabStop = False
        rbGlazed.Checked = True
        nudQuantity.Focus()
        nudQuantity.Maximum = 10
        nudQuantity.Minimum = 0
        nudQuantity.Increment = 1
        nudQuantity.Value = 0
    End Sub
    Private Sub frmWHDSjr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        txtChangeDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        subReset()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        subReset()
    End Sub

    Private Sub txtTendered_TextChanged(sender As Object, e As EventArgs) Handles txtTendered.TextChanged
        gdecTendered = CDec("0" & Format(txtTendered.Text, "Standard"))
        subCalculate()
    End Sub

    Private Sub nudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged
        If nudQuantity.Focused Then
            gdecQuantity = nudQuantity.Value
            subCalculate()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub chkCoffee_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoffee.CheckedChanged
        If chkCoffee.Checked Then
            gdecCoffee = 4
            subCalculate()
        Else
            gdecCoffee = 0
            subCalculate()
        End If
    End Sub

    Private Sub rbGlazed_CheckedChanged(sender As Object, e As EventArgs) Handles rbGlazed.CheckedChanged
        If rbGlazed.Checked Then
            gdecDonutMultiplier = 1
            subCalculate()
        End If
    End Sub

    Private Sub rbSprinkles_CheckedChanged(sender As Object, e As EventArgs) Handles rbSprinkles.CheckedChanged
        If rbSprinkles.Checked Then
            gdecDonutMultiplier = 2
            subCalculate()
        End If
    End Sub

    Private Sub rbCake_CheckedChanged(sender As Object, e As EventArgs) Handles rbCake.CheckedChanged
        If rbCake.Checked Then
            gdecDonutMultiplier = 3
            subCalculate()
        End If
    End Sub

    Private Sub txtTendered_LostFocus(sender As Object, e As EventArgs) Handles txtTendered.LostFocus
        txtTendered.Text = Format(txtTendered.Text, "Currency")
    End Sub
End Class
