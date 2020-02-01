Module Module1

    Sub Main()
        Dim id As Integer
        Dim name As String
        Dim more As String
        Dim search As String
        Dim flag As Boolean
        flag = False
        FileOpen(1, "D:\ABCD1.txt", OpenMode.Append)
        Do
            Console.Write("Enter ID: ")
            id = Console.ReadLine
            Console.Write("Enter Name: ")
            name = Console.ReadLine
            Console.Write("Want to enter more records? Y\N : ")
            more = Console.ReadLine

        Loop Until more = "N" Or more = "n"
        WriteLine(1, id)
        WriteLine(1, name)

        FileClose(1)
        id = 0
        name = ""
        more = ""
        FileOpen(1, "D:\ABCD1.txt", OpenMode.Input)
        Console.Write("search member: ")
        search = Console.ReadLine
        Do

            Input(1, id)
            Input(1, name)



            If search = name Then
                flag = True

                Exit Do


            End If


        Loop Until EOF(1)
        If flag = True Then
            Console.WriteLine("ID of the user is" & " " & id)
        Else
            Console.WriteLine("User not found")
        End If
        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
