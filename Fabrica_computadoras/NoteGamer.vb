Public Class NoteGamer
    Inherits Notebook
    Public Const GigaVideo As Short = 10

    ' Atributo 
    Private memVideo As Short

    '  Memoria de Video
    Public Property GetMemVideo() As Short
        Get
            Return memVideo
        End Get
        Set(value As Short)
            If value >= 0 Then
                memVideo = value
            Else
                Throw New ArgumentException("La memoria de video debe ser un valor no negativo.")
            End If
        End Set
    End Property

    ' Constructor
    Public Sub New(modelo As String, cpu As Char, memoria As Integer, disco As Integer, pantalla As Short, bateria As Short, memVideo As Short)
        MyBase.New(modelo, cpu, memoria, disco, pantalla, bateria)
        Me.GetMemVideo = memVideo
    End Sub

    ' Método Precio
    Public Overrides Function Precio() As Integer
        Dim PrecioBase As Integer = MyBase.Precio()
        Precio = PrecioBase
        PrecioBase += memVideo * GigaVideo '
        Return Precio
    End Function
End Class