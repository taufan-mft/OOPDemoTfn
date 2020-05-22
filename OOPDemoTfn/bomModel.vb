Public Class bomModel
    Public Shared dbBOM As New List(Of bomModel)
    Public Property kodebom As String
    Public Property qtychassisA As Integer
    Public Property qtyChassisB As Integer
    Public Property qtyChassisC As Integer
    Public Property qtyChassisD As Integer
    Public Property qtyInjectorA As Integer
    Public Property qtyInjectorB As Integer
    Public Property qtyInjectorC As Integer
    Public Property qtyInjectorD As Integer

    Sub New(kode As String, qtyA As Integer, qtyB As Integer, qtyC As Integer,
            qtyD As Integer, qtyIA As Integer, qtyIB As Integer, qtyIC As Integer, qtyID As Integer)
        kodebom = kode
        qtychassisA = qtyA
        qtyChassisB = qtyB
        qtyChassisC = qtyC
        qtyChassisD = qtyD
        qtyInjectorA = qtyIA
        qtyInjectorB = qtyIB
        qtyInjectorC = qtyIC
        qtyInjectorD = qtyID

    End Sub
    Sub saveData()
        dbBOM.Add(Me)
    End Sub




End Class
