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
    Public Property GetMemoria() As Integer
        Get
            Return Memoria_ram
        End Get
        Set(value As Integer)
            If value >= 8 AndAlso value <= 64 Then
                Memoria_ram = value
            Else
                Throw New ArgumentException("La memoria debe estar entre 8 y 64 GB.")
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
        ' modelo
        Do
            Console.Write("Ingrese el modelo (máx 10 caracteres): ")
            Dim input As String = Console.ReadLine()
            If input.Length <= 10 Then
                Modelo = input
                Exit Do
            Else
                Console.WriteLine("Error: El modelo no puede tener más de 10 caracteres.")
            End If
        Loop

        ' CPU
        Do
            Console.Write("Ingrese CPU (I para Intel, A para AMD): ")
            Dim input As Char = Char.ToUpper(Convert.ToChar(Console.ReadLine()))
            If input = "I" OrElse input = "A" Then
                Cpu = input
                Exit Do
            Else
                Console.WriteLine("Error: CPU debe ser 'I' para Intel o 'A' para AMD.")
            End If
        Loop

        '  RAM
        Do
            Console.Write("Ingrese cantidad de Memoria RAM (8 a 64 GB): ")
            Dim input As Integer = Convert.ToInt32(Console.ReadLine())
            If input >= 8 AndAlso input <= 64 Then
                Memoria_ram = input
                Exit Do
            Else
                Console.WriteLine("Error: La memoria debe estar entre 8 y 64 GB.")
            End If
        Loop

        ' Disco
        Do
            Console.Write("Ingrese capacidad de Disco (en GB): ")
            Dim input As Integer = Convert.ToInt32(Console.ReadLine())
            If input > 0 Then
                Disco = input
                Exit Do
            Else
                Console.WriteLine("Error: La capacidad del disco debe ser un valor positivo.")
            End If
        Loop
    End Sub

    Public Function Precio() As Integer
        Dim precioBase As Integer
        If Cpu = "I" Then
            precioBase = Intel
        ElseIf Cpu = "A" Then
            precioBase = AMD
        End If

        precioBase += Memoria_ram * GigaRAM
        precioBase += Disco * GigaDisco


        Return precioBase
    End Function

End Class
