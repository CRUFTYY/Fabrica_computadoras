Public Class Netebook
    Inherits Computadora
    Private Pantalla As Short
    Private Bateria As Short

    Public Property GetPantalla() As Short
        Get
            Return Pantalla
        End Get
        Set(value As Short)
            Pantalla = value
        End Set
    End Property

    Public Property GetBateria() As Short
        Get
            Return Bateria
        End Get
        Set(value As Short)
            Bateria = value
        End Set
    End Property

    Public Sub IngresarDatos()
        MyBase.IngresarDatos()
        Console.Write("Ingrese tamaño de pantalla (en pulgadas): ")
        Pantalla = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese autonomía de batería (en horas): ")
        Bateria = Integer.Parse(Console.ReadLine())
    End Sub
    Public Function Precio() As Integer
        Dim precioBase As Integer = MyBase.Precio()

        precioBase += Pantalla * Pulgada
        precioBase += Bateria * HoraBat


        Return precioBase
    End Function
End Class
