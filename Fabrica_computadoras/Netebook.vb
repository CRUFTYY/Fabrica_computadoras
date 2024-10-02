Public Class Notebook
    Inherits Computadora

    ' Atributos 
    Private pantalla As Short
    Private bateria As Short

    '  Pantalla
    Public Property GetPantalla() As Short
        Get
            Return pantalla
        End Get
        Set(value As Short)
            If value > 0 Then
                pantalla = value
            Else
                Throw New ArgumentException("La pantalla debe ser mayor a 0 pulgadas.")
            End If
        End Set
    End Property

    '  Batería
    Public Property GetBateria() As Short
        Get
            Return bateria
        End Get
        Set(value As Short)
            If value > 0 Then
                bateria = value
            Else
                Throw New ArgumentException("La batería debe ser mayor a 0 horas.")
            End If
        End Set
    End Property

    ' Constructor
    Public Sub New(modelo As String, cpu As Char, memoria As Integer, disco As Integer, pantalla As Short, bateria As Short)
        MyBase.New(modelo, cpu, memoria, disco)
        Me.GetPantalla = pantalla
        Me.GetBateria = bateria
    End Sub

    '  Precio
    Public Overrides Function Precio() As Integer
        Dim PrecioBase As Integer = MyBase.Precio()
        Precio += pantalla * 30 ' 
        Precio += bateria * 5    ' 
        Return precio
    End Function
End Class
