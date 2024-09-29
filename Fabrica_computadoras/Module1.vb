Module Module1

    Sub Main()
        Dim opcion As Char
        Do
            Console.WriteLine("Menú de opciones:")
            Console.WriteLine("
            1- Fabricar Computadora
            2- Fabricar  Notebook
            3- Fabricar Notebook Gamer
            0- Salir
            ")
            opcion = Char.Parse(Console.ReadLine())

            Select Case opcion
                Case "1"
                    Dim computadora As New Computadora()
                    computadora.IngresarDatos()
                    Console.WriteLine("El precio de la computadora es: $" & computadora.Precio())
                Case "2"
                    'Dim notebook As New Notebook()
                    'notebook.IngresarDatos()
                    'Console.WriteLine("El precio de la notebook es: $" & notebook.Precio())
                Case "3"
                    'Dim gamer As New NoteGamer()
                    'gamer.IngresarDatos()
                    'Console.WriteLine("El precio de la notebook gamer es: $" & gamer.Precio())
                Case Else
                    Console.WriteLine("Opcion inválida")
            End Select
        Loop While opcion <> "0"

    End Sub

End Module
