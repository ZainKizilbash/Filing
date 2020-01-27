Module Module1

    Sub Main()
        Dim level As String
        Dim section As String
        Dim idcard As Integer
        Dim fees As Integer
        Dim more As String
        Dim search As Integer
        Dim flag As Boolean
        flag = False
        FileOpen(1, "D:\ABCD.txt", OpenMode.Append)
        Do
            Console.Write("Enter ID: ")
            idcard = Console.ReadLine
            Console.Write("Enter class: ")
            level = Console.ReadLine
            Console.Write("Enter Section: ")
            section = Console.ReadLine
            Console.Write("Fee Amount: ")
            fees = Console.ReadLine
            Console.Write("Want to enter more records? Y\N : ")
            more = Console.ReadLine
            WriteLine(1, idcard)
            WriteLine(1, level)
            WriteLine(1, section)
            WriteLine(1, fees)
        Loop Until more = "N" Or more = "n"
        FileClose(1)
        level = ""
        section = ""
        idcard = 0
        fees = 0
        more = ""
        FileOpen(1, "D:\ABCD.txt", OpenMode.Input)
        Console.Write("search An IDCARD: ")
        search = Console.ReadLine
        Do

            Input(1, idcard)
            Input(1, level)
            Input(1, section)
            Input(1, fees)


            If search = idcard Then
                Console.WriteLine(idcard)
                Console.WriteLine(level)
                Console.WriteLine(section)
                Console.WriteLine(fees)
                flag = True

            End If


        Loop Until EOF(1)
        If flag = True Then
            Console.WriteLine("ID card was found")
        Else
            Console.WriteLine("ID card wasn't found")
        End If
        FileClose(1)
        Console.ReadKey()

    End Sub

End Module
