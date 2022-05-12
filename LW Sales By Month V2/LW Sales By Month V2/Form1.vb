Option Strict On
Imports System.IO
' Leeann Warren

Public Class frmSBM
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Console.Clear()
        cmboMonth.SelectedIndex = -1
        cmboMode.SelectedIndex = -1
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim strMonth() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Dim intMonthCount(11) As Integer ' this array keeps count of month frequency
        Dim fsrFile As StreamReader = New StreamReader("SalesByMonth.csv")
        Dim strLine As String
        Dim strSplitLine(1) As String
        Dim decMonthlyTotal(11) As Decimal




        Do Until fsrFile.EndOfStream ' loops until end of stream
            strLine = fsrFile.ReadLine
            strSplitLine = Split(strLine, ",")

            For intIndex = 0 To strMonth.GetUpperBound(0) ' from index 0 to the upper bound, search for match if == +1 counter
                If strSplitLine(0) = strMonth(intIndex) Then
                    intMonthCount(intIndex) += 1
                    decMonthlyTotal(intIndex) += CDec(strSplitLine(1))
                    Exit For
                End If

            Next

        Loop
        If cmboMode.SelectedIndex = 0 Then ' if sum is selected; 
            If cmboMonth.SelectedIndex >= 0 And cmboMonth.SelectedIndex <= 11 Then
                For intIndex = cmboMonth.SelectedIndex To 11
                    Console.WriteLine(strMonth(intIndex) & ":  $" & decMonthlyTotal(intIndex))
                Next
                For intIndex = 0 To (cmboMonth.SelectedIndex - 1)
                    Console.WriteLine(strMonth(intIndex) & ":  $" & decMonthlyTotal(intIndex))
                Next
            Else
                For intIndex = 0 To 11
                    Console.WriteLine(strMonth(intIndex) & ":  $" & decMonthlyTotal(intIndex))
                Next

            End If
            For intBCount = 0 To 15
                Console.Write("--")
            Next
            Console.WriteLine()
        ElseIf cmboMode.SelectedIndex = 1 Then ' if count is selected '
            If cmboMonth.SelectedIndex >= 0 And cmboMonth.SelectedIndex <= 11 Then
                For intIndex = cmboMonth.SelectedIndex To 11
                    Console.WriteLine(strMonth(intIndex) & ":  " & intMonthCount(intIndex))
                Next
                For intIndex = 0 To (cmboMonth.SelectedIndex - 1)
                    Console.WriteLine(strMonth(intIndex) & ":  " & intMonthCount(intIndex))
                Next
            Else
                For intIndex = 0 To 11
                    Console.WriteLine(strMonth(intIndex) & ":  " & intMonthCount(intIndex))
                Next
            End If
            For intBCount = 0 To 15
                Console.Write("--")
            Next
            Console.WriteLine()

        ElseIf cmboMode.Focused = False Then
            If cmboMonth.SelectedIndex >= 0 And cmboMonth.SelectedIndex <= 11 Then
                For intIndex = cmboMonth.SelectedIndex To 11
                    Console.WriteLine(strMonth(intIndex) & ":  $" & decMonthlyTotal(intIndex))
                Next
                For intIndex = 0 To (cmboMonth.SelectedIndex - 1)
                    Console.WriteLine(strMonth(intIndex) & ":  $" & decMonthlyTotal(intIndex))
                Next
            Else
                For intIndex = 0 To 11
                    Console.WriteLine(strMonth(intIndex) & ":  $" & decMonthlyTotal(intIndex))
                Next

            End If
            For intBCount = 0 To 15
                Console.Write("--")
            Next
            Console.WriteLine()

        Else ' else if no mode is selected default to sum of january
            For intIndex = 0 To 11
                Console.WriteLine(strMonth(intIndex) & ":  $" & decMonthlyTotal(intIndex))
            Next
            For intBCount = 0 To 15
                Console.Write("--")
            Next
            Console.WriteLine()
        End If


    End Sub
End Class
