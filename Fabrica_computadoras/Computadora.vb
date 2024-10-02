Public Class Computadora
    ' Constantes 
    Public Const Intel As Short = 10000
    Public Const AMD As Short = 9000
    Public Const GigaRAM As Short = 50
    Public Const GigaDisco As Short = 5

    ' Atributos 
    Private modelo As String
    Private cpu As Char
    Private memoria As Integer
    Private disco As Integer

    ' Modelo
    Public Property GetModelo() As String
        Get
            Return modelo
        End Get
        Set(value As String)
            If value.Length <= 10 Then
                modelo = value
            Else
                Throw New ArgumentException("El modelo no puede tener más de 10 caracteres.")
            End If
        End Set
    End Property

    '  CPU
    Public Property GetCpu() As Char
        Get
            Return cpu
        End Get
        Set(value As Char)
            If value = "I" OrElse value = "A" Then
                cpu = Char.ToUpper(value)
            Else
                Throw New ArgumentException("CPU debe ser 'I' para Intel o 'A' para AMD.")
            End If
        End Set
    End Property

    '  Memoria
    Public Property GetMemoria() As Integer
        Get
            Return memoria
        End Get
        Set(value As Integer)
            If value >= 8 AndAlso value <= 64 Then
                memoria = value
            Else
                Throw New ArgumentException("La memoria debe estar entre 8 y 64 GB.")
            End If
        End Set
    End Property

    '  Disco
    Public Property GetDisco() As Integer
        Get
            Return disco
        End Get
        Set(value As Integer)
            If value > 0 Then
                disco = value
            Else
                Throw New ArgumentException("La capacidad del disco debe ser un valor positivo.")
            End If
        End Set
    End Property

    ' Constructor
    Public Sub New(modelo As String, cpu As Char, memoria As Integer, disco As Integer)
        Me.GetModelo = modelo
        Me.GetCpu = cpu
        Me.GetMemoria = memoria
        Me.GetDisco = disco
    End Sub

    ' Precio
    Public Overridable Function Precio() As Integer
        Dim precioBase As Integer = If(cpu = "I", Intel, AMD)
        precioBase += memoria * GigaRAM
        precioBase += disco * GigaDisco
        Return precioBase
    End Function
End Class
