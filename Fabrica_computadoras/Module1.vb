Module Module1

    Sub Main()
        Dim opcion As Integer

        Do
            Console.WriteLine("Menú:")
            Console.WriteLine("1 - Fabricar Computadora")
            Console.WriteLine("2 - Fabricar Notebook")
            Console.WriteLine("3 - Fabricar Notebook Gamer")
            Console.WriteLine("0 - Salir")
            Console.Write("Elija una opción: ")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    FabricarComputadora()
                Case 2
                    FabricarNotebook()
                Case 3
                    FabricarNoteGamer()
                Case 0
                    Console.WriteLine("Saliendo...")
                Case Else
                    Console.WriteLine("Opción no válida, intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While opcion <> 0
    End Sub

    Sub FabricarComputadora()
        Dim modelo As String = ""
        Dim cpu As Char = ""
        Dim memoria As Integer = 0
        Dim disco As Integer = 0

        ' modelo
        Do
            Console.Write("Ingrese el modelo (máx 10 caracteres): ")
            modelo = Console.ReadLine()
            modelo = Left(modelo, 10)
        Loop While String.IsNullOrWhiteSpace(modelo)


        ' CPU
        Do
            Console.Write("Ingrese la CPU (I para Intel, A para AMD): ")
            cpu = Convert.ToChar(Console.ReadLine().ToUpper())
            Console.WriteLine()
            If cpu <> "I" And cpu <> "A" Then
                Console.WriteLine("")
                Console.WriteLine("Error: CPU debe ser 'I' para Intel o 'A' para AMD.")
            End If
        Loop While cpu <> "I" And cpu <> "A"

        '  memoria
        Do
            Console.Write("Ingrese la memoria RAM (8 a 64 GB): ")
            memoria = Convert.ToInt32(Console.ReadLine())
            If memoria < 8 Or memoria > 64 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La memoria debe estar entre 8 y 64 GB.")
            End If
        Loop While memoria < 8 Or memoria > 64

        ' disco
        Do
            Console.Write("Ingrese la capacidad del disco (GB): ")
            disco = Convert.ToInt32(Console.ReadLine())
            If disco <= 0 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La capacidad del disco debe ser un valor positivo.")
            End If
        Loop While disco <= 0
        Console.Clear()
        Dim computadora As New Computadora(modelo, cpu, memoria, disco)
        Console.WriteLine($"El precio de la computadora {modelo} es: {computadora.Precio()}$")
    End Sub

    Sub FabricarNotebook()
        Dim modelo As String = ""
        Dim cpu As Char = ""
        Dim memoria As Integer = 0
        Dim disco As Integer = 0
        Dim pantalla As Short = 0
        Dim bateria As Short = 0

        '  modelo
        Do
            Console.Write("Ingrese el modelo (máx 10 caracteres): ")
            modelo = Console.ReadLine()
            modelo = Left(modelo, 10)
        Loop While String.IsNullOrWhiteSpace(modelo)

        '  CPU
        Do
            Console.Write("Ingrese la CPU (I para Intel, A para AMD): ")
            cpu = Convert.ToChar(Console.ReadLine().ToUpper())
            Console.WriteLine()
            If cpu <> "I" And cpu <> "A" Then
                Console.WriteLine("")
                Console.WriteLine("Error: CPU debe ser 'I' para Intel o 'A' para AMD.")
            End If
        Loop While cpu <> "I" And cpu <> "A"

        '  memoria
        Do
            Console.Write("Ingrese la memoria RAM (8 a 64 GB): ")
            memoria = Convert.ToInt32(Console.ReadLine())
            If memoria < 8 Or memoria > 64 Then
                Console.WriteLine("Error: La memoria debe estar entre 8 y 64 GB.")
            End If
        Loop While memoria < 8 Or memoria > 64

        ' disco
        Do
            Console.Write("Ingrese la capacidad del disco (GB): ")
            disco = Convert.ToInt32(Console.ReadLine())
            If disco <= 0 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La capacidad del disco debe ser un valor positivo.")
            End If
        Loop While disco <= 0

        '  pantalla
        Do
            Console.Write("Ingrese el tamaño de la pantalla (pulgadas): ")
            pantalla = Convert.ToInt16(Console.ReadLine())
            If pantalla <= 0 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La pantalla debe ser mayor a 0 pulgadas.")
            End If
        Loop While pantalla <= 0

        ' batería
        Do
            Console.Write("Ingrese la autonomía de la batería (horas): ")
            bateria = Convert.ToInt16(Console.ReadLine())
            If bateria <= 0 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La batería debe ser mayor a 0 horas.")
            End If
        Loop While bateria <= 0
        Console.Clear()
        Dim notebook As New Notebook(modelo, cpu, memoria, disco, pantalla, bateria)
        Console.WriteLine($"El precio de la notebook {modelo} es: {notebook.Precio()}$")
    End Sub

    Sub FabricarNoteGamer()
        Dim modelo As String = ""
        Dim cpu As Char = ""
        Dim memoria As Integer = 0
        Dim disco As Integer = 0
        Dim pantalla As Short = 0
        Dim bateria As Short = 0
        Dim memVideo As Short = 0

        '  modelo
        Do
            Console.Write("Ingrese el modelo (máx 10 caracteres): ")
            modelo = Console.ReadLine()
            modelo = Left(modelo, 10)
        Loop While String.IsNullOrWhiteSpace(modelo)

        '  CPU
        Do
            Console.Write("Ingrese la CPU (I para Intel, A para AMD): ")
            cpu = Convert.ToChar(Console.ReadLine().ToUpper())
            Console.WriteLine()
            If cpu <> "I" And cpu <> "A" Then
                Console.WriteLine("")
                Console.WriteLine("Error: CPU debe ser 'I' para Intel o 'A' para AMD.")
            End If
        Loop While cpu <> "I" And cpu <> "A"

        '  memoria
        Do
            Console.Write("Ingrese la memoria RAM (8 a 64 GB): ")
            memoria = Convert.ToInt32(Console.ReadLine())
            If memoria < 8 Or memoria > 64 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La memoria debe estar entre 8 y 64 GB.")
            End If
        Loop While memoria < 8 Or memoria > 64

        '  disco
        Do
            Console.Write("Ingrese la capacidad del disco (GB): ")
            disco = Convert.ToInt32(Console.ReadLine())
            If disco <= 0 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La capacidad del disco debe ser un valor positivo.")
            End If
        Loop While disco <= 0

        '  pantalla
        Do
            Console.Write("Ingrese el tamaño de la pantalla (pulgadas): ")
            pantalla = Convert.ToInt16(Console.ReadLine())
            If pantalla <= 0 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La pantalla debe ser mayor a 0 pulgadas.")
            End If
        Loop While pantalla <= 0

        '  batería
        Do
            Console.Write("Ingrese la autonomía de la batería (horas): ")
            bateria = Convert.ToInt16(Console.ReadLine())
            If bateria <= 0 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La batería debe ser mayor a 0 horas.")
            End If
        Loop While bateria <= 0

        '  memoria de video
        Do
            Console.Write("Ingrese la memoria de video dedicada (GB): ")
            memVideo = Convert.ToInt16(Console.ReadLine())
            If memVideo < 0 Then
                Console.WriteLine("")
                Console.WriteLine("Error: La memoria de video debe ser un valor no negativo.")
            End If
        Loop While memVideo < 0
        Console.Clear()

        Dim noteGamer As New NoteGamer(modelo, cpu, memoria, disco, pantalla, bateria, memVideo)
        Console.WriteLine($"El precio de la notebook gamer {modelo} es: {noteGamer.Precio()}$")
    End Sub
End Module
