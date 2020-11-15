Module Module1

    Structure student
        Dim studentId As Integer
        Dim FirstName As String
        Dim SurName As String
        Dim dob As Date

        Structure unit
            Dim grade As Char
            Dim unitName As String
            Dim credit As Byte
            Dim graded As Char
        End Structure

        Dim results() As unit
    End Structure

    Public AccesstoComputing(-1) As student
    Public sizeofArray As Integer


    Public subjects(,) As String = {{"Note Taking", 3, "N"},
        {"Finding &  Reading Information", 3, "N"},
        {"Examination Skills", 3, "N"},
        {"Word Processing", 3, "N"},
        {"Writing Seminar Papers", 3, "N"},
        {"Computer Hardware", 3, "Y"},
        {"Computer Architecture", 3, "Y"},
        {"Routing and TCP/IP", 3, "Y"},
        {"Algebra", 3, "Y"},
        {"Maths for Computing", 3, "Y"},
        {"Numerical Methods", 3, "Y"},
        {"Arrays and Data Types", 3, "Y"},
        {"Visual Programming", 3, "Y"},
        {"Systems Analysis", 3, "Y"},
        {"Spreadsheets", 3, "Y"},
        {"HTML & CSS", 3, "Y"},
        {"Relational Database Development", 6, "Y"},
        {"Research Project", 6, "Y"}
    }

    Sub Main()
        Dim choice As Integer
        Dim trueval As Boolean
        Dim ruioscalss(19) As student


        LoadData()
        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine("Student Informatiomn System")
            Console.WriteLine("Kingston College" & vbCrLf)

            Console.WriteLine("1. Enter Student Details")
            Console.WriteLine("2. Display Students")
            Console.WriteLine("3. Add Student Grades")
            Console.WriteLine("4. FUNCTION TO IMPLEMENT")
            Console.WriteLine("5. FUNCTION TO IMPLEMENT")
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
                Case 3
                    EnterStudentGrades()
                Case 4
                    DisplayStudentGrades()
                Case 5

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
