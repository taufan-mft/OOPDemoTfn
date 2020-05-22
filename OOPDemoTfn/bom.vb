Public Class bom

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim totalA As Integer = 0
        Dim totalB As Integer = 0
        Dim totalC As Integer = 0
        Dim totalD As Integer = 0
        Dim ijA, ijB, ijC, ijD As Integer
        For Each pesenan In pesanClass.database
            totalA = totalA + pesenan.qt1
            totalB = totalB + pesenan.qt2
            totalC = totalC + pesenan.qt3
            totalD = totalD + pesenan.qt4
            ijA = totalA * 2
            ijB = totalB * 4
            ijC = totalC * 3
            ijD = totalD * 5
        Next
        Dim label As String
        label = totalA.ToString + " pcs"
        MetroLabel1.Text = label
        MetroLabel2.Text = totalB.ToString + " pcs"
        MetroLabel3.Text = totalC.ToString + " pcs"
        MetroLabel4.Text = totalD.ToString + " pcs"
        MetroLabel5.Text = ijA.ToString + " pcs"
        MetroLabel6.Text = ijB.ToString + " pcs"
        MetroLabel7.Text = ijC.ToString + " pcs"
        MetroLabel8.Text = ijD.ToString + " pcs"
    End Sub
End Class