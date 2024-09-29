Public Class Computadora
    Public Const Intel As Short = 10000
    Public Const AMD As Short = 9000
    Public Const GigaRAM As Short = 50
    Public Const GigaDisco As Short = 5
    Public Const Pulgada As Short = 30
    Public Const HoraBat As Short = 5
    Public Const GigaVideo As Short = 10

    Private Modelo As String
    Private Cpu As Char
    Private Memoria_ram As Integer
    Private Disco As Integer

    Public Property GetModelo() As String
        Get
            Return Modelo
        End Get
        Set(value As String)
            If value.Length <= 10 Then
                Modelo = value
            Else
                Throw New ArgumentException("El modelo no puede tener más de 10 caracteres")
            End If
        End Set
    End Property

    Public Property GetCpu() As String
        Get
            Return Cpu
        End Get
        Set(value As String)
            If value = "I" OrElse value = "A" Then
                Cpu = Char.ToUpper(value)
            Else
                Throw New ArgumentException("CPU debe ser 'I' para Intel o 'A' para AMD.")
            End If
        End Set
    End Property
    Public Property GetDisco() As Integer
        Get
            Return Disco
        End Get
        Set(value As Integer)
            Disco = value
        End Set
    End Property

    Public Sub IngresarDatos()
        Console.Write("Ingrese el modelo (max 10 caracteres): ")
        Modelo = Console.ReadLine()

        Console.Write("Ingrese CPU (I para Intel, A para AMD): ")
        Cpu = Convert.ToChar(Console.ReadLine())

        Console.Write("Ingrese cantidad de Memoria RAM (8 a 64 GB): ")
        Memoria_ram = Convert.ToInt32(Console.ReadLine())

        Console.Write("Ingrese capacidad de Disco (en GB): ")
        Disco = Convert.ToInt32(Console.ReadLine())
    End Sub

    Public Function Precio() As Integer
        Dim precioBase As Integer
        If Cpu = "I" Then
            precioBase = Intel
        Else
            precioBase = AMD
        End If

        precioBase += Memoria_ram * GigaRAM
        precioBase += Disco * GigaDisco


        Return precioBase
    End Function

End Class
