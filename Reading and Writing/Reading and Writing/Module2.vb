Imports System.IO
Imports System.Console

Module Module2
    Sub AddStudent()
        Dim trueval As Boolean

        Console.WriteLine("Add student Details")

        sizeofArray = UBound(AccesstoComputing) + 1
        ReDim Preserve AccesstoComputing(sizeofArray)
        ReDim Preserve AccesstoComputing(sizeofArray).results(17)

        'AccesstoComputing(0).results(0).firstName = "Jhon" '
        'AccesstoComputing(0).results(0).grade = P'

        Do
            Try
                Console.ForegroundColor = ConsoleColor.Gray
                Console.Write("Enter student id: ")
                AccesstoComputing(sizeofArray).studentId = Console.ReadLine
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error! this is not a number.")
                trueval = False
            End Try
        Loop Until trueval = True


        Console.Write("Enter First Name: ")
        AccesstoComputing(sizeofArray).FirstName = Console.ReadLine

        Console.Write("Enter Surname: ")
        AccesstoComputing(sizeofArray).SurName = Console.ReadLine

        Do
            Try
                Console.Write("Enter DoB [dd/mm/yyyy]: ")
                AccesstoComputing(sizeofArray).dob = Console.ReadLine
                trueval = True
            Catch ex As Exception
                Console.WriteLine("Error! Incorect date")
                trueval = False
            End Try
        Loop Until trueval = True

    End Sub

    Sub DisplayStudents()
        Dim i As Integer
        Dim swapped As Boolean
        Dim temp As student

        Console.WriteLine("List of Students")

        ' Sort data using Bubble sort algorithm

        Do
            swapped = False
            For i = 1 To AccesstoComputing.Length - 1
                If AccesstoComputing(i - 1).studentId > AccesstoComputing(i).studentId Then
                    temp = AccesstoComputing(i - 1)
                    AccesstoComputing(i - 1) = AccesstoComputing(i)
                    AccesstoComputing(i) = temp
                    swapped = True
                End If
            Next
        Loop Until Not swapped

        Console.WriteLine("Student Id" & vbTab & "FirstName" & vbTab & "Surname " & vbTab & "Dob")
        Console.WriteLine("===================================================================" & vbCrLf)


        'For i = 0 To AccesstoComputing.Length - 1
        For i = 0 To UBound(AccesstoComputing)
            Console.WriteLine(AccesstoComputing(i).studentId & vbTab & AccesstoComputing(i).FirstName & vbTab & AccesstoComputing(i).SurName & vbTab & AccesstoComputing(i).dob)
        Next

        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()
    End Sub

    Sub SaveData()
        Dim myfile As StreamWriter
        Dim i As Integer

        myfile = My.Computer.FileSystem.OpenTextFileWriter("data.txt", False)
        'myfile = New StreamWriter("data.txt")



        For i = 0 To AccesstoComputing.Length - 1
            myfile.WriteLine(AccesstoComputing(i).studentId & "," & AccesstoComputing(i).FirstName & "," & AccesstoComputing(i).SurName & "," & AccesstoComputing(i).dob)
        Next
        myfile.Close()
    End Sub

    Sub LoadData()


        ' Sub Procedure to Load  Data when program is run
        Dim i As Integer

        Dim myfile As FileIO.TextFieldParser        ' Declare object of type Text Field Parser
        'Dim record() As String = {}
        Dim record() As String


        myfile = My.Computer.FileSystem.OpenTextFieldParser("data.txt")     'Assign file 
        myfile.TextFieldType = FileIO.FieldType.Delimited
        myfile.SetDelimiters(",")

        ' Can also use:     myfile = My.Computer.FileSystem.OpenTextFieldParser("data.txt", ",")

        ' Use a Do Loopp to read each line of text until end of file is reached
        While Not myfile.EndOfData

            record = myfile.ReadFields  'Read each linbe of the file  into an array . The comma will act as seperator so that each field is read into the  array

            ' Need to load data into Array
            sizeofArray = UBound(AccesstoComputing) + 1             'Get the upper bound of the Array
            ReDim Preserve AccesstoComputing(sizeofArray)           'Resize the Array whilst preserving existing Data
            ReDim Preserve AccesstoComputing(sizeofArray).results(17)

            'Assign Array  values read from file
            AccesstoComputing(sizeofArray).studentId = record(0)
            AccesstoComputing(sizeofArray).FirstName = record(1)
            AccesstoComputing(sizeofArray).SurName = record(2)
            AccesstoComputing(sizeofArray).dob = record(3)
        End While
        myfile.Close()
    End Sub
    Sub testloadsimple()
        Dim myfile As StreamReader

        myfile = My.Computer.FileSystem.OpenTextFileReader("data.txt")

        While Not myfile.EndOfStream

            Console.WriteLine(myfile.ReadLine())
        End While
        myfile.Close()
        Console.WriteLine("Press any key to contionue...")
        Console.ReadKey()

    End Sub

End Module
