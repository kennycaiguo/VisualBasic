Imports System.IO
Imports System.FileStyleUriParser
Module Module2
    '|=============================================================================|
    '| Module 2 Used to Define Sub Procedures        ONLY                          |
    '| Author: Abrar Hamid                                                         |
    '|=============================================================================|

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub Addstudent()

        ' Sub Procedure to add a  new student
        Dim trueval As Boolean = False
        Dim i As Integer


        position = UBound(access2computing) + 1                 'This gets the upper bound of the Array 
        ' Resize the Array and preserve existing data at the same time. This will allow a new record to be added to the Array
        ReDim Preserve access2computing(position)


        ' Input and validate Student id
        Do
            Try
                Console.Write(vbCrLf & "Enter student id: ")
                access2computing(position).id = Console.ReadLine
                trueval = True
            Catch ex As Exception
                ' Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Error! This is not a number...")
                trueval = False
                ' Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True

        trueval = False

        'Get Input for Student First Name. User will not be able to enter a Null Value
        Do
            Console.Write(vbCrLf & "Enter firstname: ")
            access2computing(position).firstname = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(access2computing(position).firstname) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Name cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If
        Loop Until Not (String.IsNullOrEmpty(access2computing(position).firstname))

        'Get Input for Student Surname. User will not be able to enter a Null Value
        Do
            Console.Write("Enter surname: ")
            access2computing(position).surname = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(access2computing(position).surname) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Name cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If
        Loop Until Not (String.IsNullOrEmpty(access2computing(position).surname))

        'Get Input for Student DoB. User has to type in DoB using dd/mm/yyyy format
      
        trueval = False
        Do
            Try
                Console.Write("Enter Date of Birth: ")
                access2computing(position).dob = Console.ReadLine
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Error! This is not a Date ...")
                trueval = False
                Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True


        ReDim Preserve access2computing(position).grades(17)        ' Dimension array so that 18 units can be stored in array for new student

        ' Use a For Loop to populate unitname, credits for the new student 
        For i = 0 To 17
            access2computing(position).grades(i).unitname = subjects(i, 0)
            access2computing(position).grades(i).credit = subjects(i, 1)
            access2computing(position).grades(i).graded = subjects(i, 2)
        Next
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub Entergrades()
        ' Sub Procedure to enter grades for a student
        Dim tempid, i, j As Integer
        Dim found As Boolean = False
        Dim trueval As Boolean = False

        'Validate student ID 
        Do
            Try
                Console.Write("Type in student ID ")
                tempid = Console.ReadLine
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Error! This is not a Number ...")
                trueval = False
                Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True

        'Use For Loop to search array for student ID using Simple Linear Search

        For i = 0 To UBound(access2computing)
            If tempid = access2computing(i).id Then
                found = True
                Exit For                ' If student is found then Exit For Loop
            End If
        Next


        If found = True Then
            Console.WriteLine(vbCrLf & "Student found")
            Console.Write(access2computing(i).id & " " & access2computing(i).firstname & " " & access2computing(i).surname)
            Console.WriteLine(vbCrLf & vbCrLf & "*** Enter Grades ***" & " for " & access2computing(i).firstname & " " & access2computing(i).surname & vbCrLf)

            ' Enter Grades for Student

            For j = 0 To 17
                ' Display Appropriate output dependding upon if unit is graded or Not
                If access2computing(i).grades(j).graded = "Y" Then
                    Console.Write(access2computing(i).grades(j).unitname & " [P, M or D]: ")
                Else
                    Console.Write(access2computing(i).grades(j).unitname & " [P]: ")
                End If

                'Get user to Input P,M or D if unit is graded
                If access2computing(i).grades(j).graded = "Y" Then
                    Do
                        access2computing(i).grades(j).grade = Console.ReadLine.ToUpper
                        If access2computing(i).grades(j).grade <> "P" And access2computing(i).grades(j).grade <> "M" And access2computing(i).grades(j).grade <> "D" Then
                            Console.Write("Error!! Please enter P, M or D  only.")
                        End If
                    Loop Until access2computing(i).grades(j).grade = "P" Or access2computing(i).grades(j).grade = "M" Or access2computing(i).grades(j).grade = "D"
                Else
                    '  'Get user to Input P if unit is not graded
                    Do
                        access2computing(i).grades(j).grade = Console.ReadLine.ToUpper
                        If access2computing(i).grades(j).grade <> "P" Then
                            Console.Write("Error!! Please enter P only.  ")
                            '  Console.ReadKey()
                        End If
                    Loop Until access2computing(i).grades(j).grade = "P"
                End If
            Next
        Else
            ' Display mesage if Student not found
            Console.WriteLine("No student found with ID " & tempid)
        End If

        Console.Write(vbCrLf & "Press any key to continue.....")
        Console.ReadKey()
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub Displayall()
        'Sub Procedure to display all Students
        Dim i As Integer
        Dim swapped As Boolean = False
        Dim temp As student

        'Use Bubble Sort algorithm to sort array by Studednt ID
        Do
            swapped = False

            For i = 1 To access2computing.Length - 1
                If access2computing(i - 1).id > access2computing(i).id Then
                    temp = access2computing(i - 1)
                    access2computing(i - 1) = access2computing(i)
                    access2computing(i) = temp
                    swapped = True
                End If
            Next
        Loop Until Not swapped

        'Use a For Loop to Display all Students

        Console.WriteLine("Student Details" & vbCrLf)
        Console.WriteLine("ID" & vbTab & "Name")
        Console.WriteLine("====================================")

        For i = 0 To UBound(access2computing)
            Console.WriteLine(access2computing(i).id & vbTab & access2computing(i).firstname & " " & access2computing(i).surname)
        Next
        Console.WriteLine(vbCrLf & "Press any key to continue..... ")
        Console.ReadKey()
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub FindStudent()
        ' 'Sub Procedure to find a Student and display Grades
        Dim tempid, i As Integer
        Dim found As Boolean = False

        Dim trueval As Boolean = False

        'Validate input of Integer
        Do
            Try
                Console.Write("Type in student ID ")
                tempid = Console.ReadLine
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Error! This is not a Number ...")
                trueval = False
                Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True

        'Use For Loop to search array for student ID using Simple Linear Search
        For i = 0 To access2computing.Length - 1
            If tempid = access2computing(i).id Then
                found = True
                Exit For                             ' If student is found then Exit For Loop
            End If
        Next

        'Display Student Details and Grades
        If found = True Then
            Console.WriteLine("Student found" & vbCrLf)


            Console.Write("Student ID " & access2computing(i).id & " Student Name " & access2computing(i).firstname & " " & access2computing(i).surname)
            '     Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(vbCrLf & vbCrLf & "Unit Name".PadRight(35, " ") & "Grade" & vbCrLf)
            Console.WriteLine("".PadRight(40, "="))


            ' Use For Lopop to display grdes for 18 Units
            For j = 0 To 17
                Console.WriteLine(access2computing(i).grades(j).unitname.PadRight(35, " ") & access2computing(i).grades(j).grade)
                ' Reason for using Pad Right 35 is that the longest Unit Name is 
                'Relational Database Development which is 31 Characters.
                ' so 35 is used so that there is gap of 4 characters 
            Next

            'Display summary information 
            Console.WriteLine(vbCrLf & " *** Summary ***" & vbCrLf)

            Console.WriteLine("Total Number of Passes".PadRight(35, " ") & numberofPMD(i, "P") & " (" & creditsatPass(i) & " credits)")
            Console.WriteLine("Total Number of Merits".PadRight(35, " ") & numberofPMD(i, "M") & " (" & creditsatMerit(i) & " credits)")
            Console.WriteLine("Total Number of Distinctions".PadRight(35, " ") & numberofPMD(i, "D") & " (" & creditsatdistinction(i) & " credits)")
        Else

            Console.WriteLine("No student found with ID " & tempid)
        End If

        Console.Write(vbCrLf & "Press any key to continue.....")
        Console.ReadKey()
    End Sub


    Sub ComplexSearch()
        Dim begchar, endchar As Char
        Dim i, age, searchage As Integer
        Console.WriteLine("Search for Employees by Surname " & vbCrLf)

        Console.Write("Enter beginning letter ")
        begchar = Console.ReadLine
        Console.Write("Enter end letter ")
        endchar = Console.ReadLine
        Console.Write("Enter age limit  ")
        searchage = Console.ReadLine

        For i = 0 To UBound(access2computing)
            age = Now.Year - access2computing(i).dob.Year
            If Left(access2computing(i).surname, 1) >= begchar And Left(access2computing(i).surname, 1) <= endchar And age <= searchage Then
                Console.WriteLine(access2computing(i).id & "," & access2computing(i).firstname & " " & access2computing(i).surname)
            End If
        Next
        Console.WriteLine(vbCrLf & "Press any key to continue...")
        Console.ReadKey()

    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub Savedata()
        ' Sub Procedure to Save Data
        Dim myfile As System.IO.StreamWriter            'Declare object of type StreamWriter
        Dim i, j As Integer
        Dim temp As String              'Used to build up a string of all the grades

        'Assign a file to StreamWriter Object. Will Overwrite file when program terminates 
        ' File is located in teh Bin Folder of the VB project folder 

        myfile = My.Computer.FileSystem.OpenTextFileWriter("data.txt", False)
        'Use a For Loop to traverse array and write each element of thge array to the text file 
        For i = 0 To access2computing.Length - 1
            temp = ""
            ' A for Loop to used to build up a string storing all the grades 
            For j = 0 To 17
                temp = temp & "," & access2computing(i).grades(j).grade
            Next
            'Write  Student Details to File including grades. This is a CSV file using a Comma as seperator 
            myfile.WriteLine(access2computing(i).id & "," & access2computing(i).firstname & "," & access2computing(i).surname & "," & access2computing(i).dob & temp)
        Next
        myfile.Close()
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub Loaddata()

        ' Sub Procedure to Load  Data when program is run
        Dim i As Integer

        Dim myfile As FileIO.TextFieldParser        ' Decalre object of type Text Field Parser
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
            position = UBound(access2computing) + 1             'Get the upper bound of the Array
            ReDim Preserve access2computing(position)           'Resize the Array whilst preserving existing Data
            ReDim Preserve access2computing(position).grades(17) ' Dimension Grades array so that 18 units can be stored in array for new student

            'Assign Array  values read from file
            access2computing(position).id = record(0)
            access2computing(position).firstname = record(1)
            access2computing(position).surname = record(2)
            access2computing(position).dob = record(3)

            ' Use a For Loop to populate unitname, credits for the new student  and the grade s
            For i = 0 To 17
                access2computing(position).grades(i).unitname = subjects(i, 0)
                access2computing(position).grades(i).credit = subjects(i, 1)
                access2computing(position).grades(i).graded = subjects(i, 2)
                access2computing(position).grades(i).grade = record(i + 4)  ' Assign grade for each unit as read from the file 
            Next
        End While
        myfile.Close()
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
   
End Module
