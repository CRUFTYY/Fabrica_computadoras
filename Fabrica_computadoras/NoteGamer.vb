Public Class NoteGamer
    Inherits Netebook
    Private Memoria_video As Short

    Public Property GetMemoria_video() As Short
        Get
            Return Memoria_video
        End Get
        Set(value As Short)
            Memoria_video = value
        End Set
    End Property
    Public Sub IngresarDatos()
        MyBase.IngresarDatos()

        Console.Write("Ingrese memoria de video dedicada (en GB): ")
        Memoria_video = Integer.Parse(Console.ReadLine())

    End Sub

    Public Function Precio() As Integer
        Dim precioBase As Integer = MyBase.Precio()
        precioBase += Memoria_video * GigaVideo

        Return precioBase
    End Function

End Class
