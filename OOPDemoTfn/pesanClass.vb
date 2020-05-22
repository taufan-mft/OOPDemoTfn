Public Class pesanClass
    Public Shared database As New List(Of pesanClass)
    Public Property kodepo As String
    Public Property nama As String
    Public Property alamat As String
    Public Property qt1 As Integer
    Public Property qt2 As Integer
    Public Property qt3 As Integer
    Public Property qt4 As Integer

    Sub New(kode As String, nam As String, alama As String, q1 As Integer, q2 As Integer,
             q3 As Integer, q4 As Integer)
        kodepo = kode
        nama = nam
        alamat = alama
        qt1 = q1
        qt2 = q2
        qt3 = q3
        qt4 = q4
    End Sub
    Sub saveData()
        ' database.Add(New pesanClass(kodepo, nama, alamat, qt1, qt2, qt3, qt4))
        database.Add(Me)
    End Sub
End Class
