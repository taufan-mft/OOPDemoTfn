Public Class pemesanan
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim pesanan As New pesanClass(txtKode.Text, txtNama.Text, txtAlamat.Text, txtQt1.Text, txtQt2.Text,
                                      txtQt3.Text, txtQt4.Text)
        pesanan.saveData()
        MetroListView1.Items.Clear() 'karena aku pake tema Metro, maka listview nya begini. kalo kalian temanya biasa, hanya ListView1 saja
        For Each pesenan In pesanClass.database
            MetroListView1.Items.Add(New ListViewItem({pesenan.kodepo, pesenan.nama, pesenan.alamat,
                                     pesenan.qt1, pesenan.qt2, pesenan.qt3, pesenan.qt4}))
        Next
        MetroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub pemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        bom.Show()
    End Sub
End Class
