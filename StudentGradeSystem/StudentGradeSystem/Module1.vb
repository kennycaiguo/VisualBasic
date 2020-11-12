Module Module1
    Structure student
        Dim studentId As Integer
        Dim FirstName As String
        Dim SurName As String
        Dim dob As Date
    End Structure

    Public AccesstoComputing(-1) As student
    Public sizeofArray As Integer

    Sub Main()
        Dim choice As Integer
        Dim trueval As Boolean

        LoadData()
        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine("Student Informatiomn System")
            Console.WriteLine("Kingston College" & vbCrLf)

            Console.WriteLine("1. Enter Student Details")
            Console.WriteLine("2. Display Students")
            Console.WriteLine("6. Exit" & vbCrLf)

            Do
                Try
                    Console.ForegroundColor = ConsoleColor.Gray
                    Console.Write("Please make a selection [1-6]: ")
                    choice = Console.ReadLine
                    trueval = True
                Catch ex As Exception
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Error! This is not a number")
                    Console.WriteLine("Press any key to continue....")
                    Console.ReadKey()
                    trueval = False
                End Try
            Loop Until trueval = True


            Select Case choice
                Case 1
                    AddStudent()
                Case 2
                    DisplayStudents()
                Case 6
                    Console.WriteLine("You have chosen to exit. Press any key to exit")
                    Console.ReadKey()

                Case Else
                    Console.WriteLine("Incorrect menu choice. Press any key to exit ")
                    Console.ReadKey()
            End Select

        Loop Until choice = 6

        SaveData()

    End Sub

End Module
