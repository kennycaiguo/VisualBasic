Imports System.Console
Module Module1
    '|=============================================================================|
    '| Student Grades  Application      V1.0 Nov 2019                              |
    '| Author: Abrar Hamid                                                         |
    '| Date: Nov 2019                                                              |
    '|If you make any changes then please add comments stating your name, date     |
    '|and details of what was changed                                              |
    '|=============================================================================|


    ' Define Structure for a Student
    Structure student
        Dim id As Integer
        Dim firstname As String
        Dim surname As String
        Dim dob As Date
        'Define another structure to store unit names and Grades
        Structure unit
            Dim unitname As String
            Dim credit As Byte
            Dim graded As Char
            Dim grade As Char
        End Structure
        Dim grades() As unit        ' Array to store grades  . This will be dimensioned when a new student is added 
    End Structure

    ' Declare Public Variables as these will be used througout the project

    Public access2computing(-1) As student          ' Array based on student Data type. This is a Dynamic Array  as size will change when a new student is added 
    ' reason for the -1 in brackets is that if ypou leave it blank or put a 0 this will  .

    Public position As Integer                      ' Variable used to track the size of the Array

    ' Define 2 Dimensional Array for all 18 Units for the Access to Computing Course.
    Public subjects(,) As String = {{"Note Taking", 3, "N"}, {"Finding &  Reading Information", 3, "N"}, {"Examination Skills", 3, "N"}, {"Word Processing", 3, "N"}, {"Writing Seminar Papers", 3, "N"}, {"Computer Hardware", 3, "Y"}, {"Computer Architecture", 3, "Y"}, {"Routing and TCP/IP", 3, "Y"}, {"Algebra", 3, "Y"}, {"Maths for Computing", 3, "Y"}, {"Numerical Methods", 3, "Y"}, {"Arrays and Data Types", 3, "Y"}, {"Visual Programming", 3, "Y"}, {"Systems Analysis", 3, "Y"}, {"Spreadsheets", 3, "Y"}, {"HTML & CSS", 3, "Y"}, {"Relational Database Development", 6, "Y"}, {"Research Project", 6, "Y"}}

    Sub Main()

        Dim choice As Integer
        Dim trueval As Boolean = False

        Loaddata()      ' Load Customer Data


        Do
            Console.Clear()

            WriteLine(vbCrLf & "**** Student Information System ***" & vbCrLf)
            Console.WriteLine("Version 1.0" & vbCrLf)
            Console.WriteLine("KC Systems Ltd (c) 2018" & vbCrLf)


            ' Display Main Menu
            Console.WriteLine("1. Create  Student")
            Console.WriteLine("2. Enter Grades")
            Console.WriteLine("3. Display All Students")
            Console.WriteLine("4. Search for Student")
            Console.WriteLine("5. Complex Search")
            Console.WriteLine("6. Exit")


            ' Validate user Selection 
            Do
                Try
                    Console.Write(vbCrLf & "Please make a selection [1-5]: ")
                    choice = Console.ReadLine
                    trueval = True
                Catch ex As Exception
                    Console.WriteLine("Error. You have not typed in a number. Press any key to continue... ")
                End Try
            Loop Until trueval = True

            trueval = False

            ' Use Select Case to 
            Select Case choice
                Case 1
                    Addstudent()
                Case 2
                    Entergrades()
                Case 3
                    Displayall()
                Case 4
                    FindStudent()
                Case 5
                    Console.WriteLine(vbCrLf & "You have chosen to exit. Press any key to exit")
                Case Else
                    Console.WriteLine("Invalid selection. press any key to continue ...")
                    Console.ReadKey()
            End Select
        Loop Until choice = 5   ' Loop until user selects menu option 5


        Savedata()      ' Save Data before program terminates

        Console.ReadKey()
    End Sub

End Module
