﻿Imports System.IO
Imports System.FileStyleUriParser

'|=============================================================================|
'| Module 2 Used to Define Sub Procedures                                      |
'| Author: Rui Vergani Neto                                                    |
'| Date: December 2020                                                         |
'|=============================================================================|

Module Module2



    Sub addCustomer()

        'Sub Procedure to add a new customer
        Dim trueval As Boolean = False
        Dim i As Integer

        position = UBound(vetorCustomer) + 1
        ReDim Preserve vetorCustomer(position)

        Console.WriteLine()
        Console.WriteLine("**** Enter the Customer Details *****")
        Console.WriteLine()

        'Input and validate Customer ID
        Do
            Try
                Console.Write("ID: ")
                vetorCustomer(position).id = Console.ReadLine()
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error! This is not a number...")
                Console.ForegroundColor = ConsoleColor.Gray
                trueval = False
            End Try

        Loop Until trueval = True

        trueval = False

        'Input and validate Customer First Name (Structure to validate the string)
        Do
            Console.Write("First Name: ")
            vetorCustomer(position).firstName = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).firstName) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Name cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).firstName))

        'Input and validate Customer Surname Name (Structure to validate the string)
        Do
            Console.Write("Surname: ")
            vetorCustomer(position).surname = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).surname) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Surname cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).surname))

        'Get Input for Customer Date of Birth. User has to type in DoB using dd/mm/yyyy format
        trueval = False
        Do
            Try
                Console.Write("Date of Birth [dd/mm/yyyy]: ")
                vetorCustomer(position).DoB = Console.ReadLine()
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error! This is not a Date")
                Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True

        'Input and validate Customer address (Structure to validate the string)
        Do
            Console.Write("Address: ")
            vetorCustomer(position).address = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).address) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Address cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).address))

        'Input and validate Customer PostCode (Structure to validate the string)
        Do
            Console.Write("Post Code: ")
            vetorCustomer(position).postcode = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).postcode) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("PostCode cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).postcode))

        'Input and validate Customer Phone Number (Structure to validate the string)
        Do
            Console.Write("Phone Number: ")
            vetorCustomer(position).phoneNumber = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).phoneNumber) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Phone Number cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).phoneNumber))



    End Sub

    Sub Displayall()

        'Sub Procedure to display all Customers'

        Dim i As Integer
        Dim swapped As Boolean = False
        Dim temp As customer

        'Use Bubble Sort algorithm to sort an array by Customer ID'
        Do
            swapped = False

            For i = 1 To vetorCustomer.Length - 1
                If vetorCustomer(i - 1).id > vetorCustomer(i).id Then
                    temp = vetorCustomer(i - 1)
                    vetorCustomer(i - 1) = vetorCustomer(i)
                    vetorCustomer(i) = temp
                    swapped = True
                End If
            Next
        Loop Until Not swapped

        'Use a For Loop to display all the customers'
        Console.WriteLine()
        Console.WriteLine("Customer Details" & vbCrLf)
        Console.WriteLine("ID" & vbTab & "Name" & vbTab & vbTab & "Date of Birth" & vbTab & vbTab & "Phone Number")
        Console.WriteLine("===========================================================")

        For i = 0 To UBound(vetorCustomer)
            Console.WriteLine(vetorCustomer(i).id & vbTab &
                              vetorCustomer(i).firstName & " " & vetorCustomer(i).surname & vbTab &
                              vetorCustomer(i).DoB & vbTab & vbTab &
                              vetorCustomer(i).phoneNumber)
        Next

        Console.WriteLine(vbCrLf & "Press any key to continue... ")
        Console.ReadKey()
    End Sub

    Sub Savedata()
        ' Sub Procedure to Save Data
        Dim myfile As System.IO.StreamWriter            'Declare object of type StreamWriter
        Dim i, j As Integer
        Dim temp As String              'Used to build up a string of all the grades

        'Assign a file to StreamWriter Object. Will Overwrite file when program terminates 
        ' File is located in teh Bin Folder of the VB project folder 

        myfile = My.Computer.FileSystem.OpenTextFileWriter("data.txt", False)
        'Use a For Loop to traverse array and write each element of thge array to the text file 
        For i = 0 To vetorCustomer.Length - 1
            temp = ""
            ' A for Loop to used to build up a string storing all the grades 
            For j = 0 To 17
                temp = temp & ","
            Next
            'Write  Student Details to File including grades. This is a CSV file using a Comma as seperator 
            myfile.WriteLine(vetorCustomer(i).id & "," & vetorCustomer(i).firstName & "," & vetorCustomer(i).surname & "," & vetorCustomer(i).DoB & "," & vetorCustomer(i).address & "," & vetorCustomer(i).postcode & "," & vetorCustomer(i).phoneNumber & temp)

        Next
        myfile.Close()
    End Sub 'NOT WORKING SUB PROCEDURE'

    Sub Loaddata()
        Dim i As Integer
        Dim myfile As FileIO.TextFieldParser
        Dim record() As String

        myfile = My.Computer.FileSystem.OpenTextFieldParser("data.txt") 'Assign file
        myfile.TextFieldType = FileIO.FieldType.Delimited
        myfile.SetDelimiters(",")

        While Not myfile.EndOfData 'do loop to read each line of text until the end of the file
            record = myfile.ReadFields 'read each line of the file into an array. The comma will act as separator so that each field is read into the array

            'Load data into de array
            position = UBound(vetorCustomer) + 1
            ReDim Preserve vetorCustomer(position) 'Resize the array and preserve the data inside

            'Assign the values read from file
            vetorCustomer(position).id = record(0)
            vetorCustomer(position).firstName = record(1)
            vetorCustomer(position).surname = record(2)
            vetorCustomer(position).DoB = record(3)
            vetorCustomer(position).address = record(4)
            vetorCustomer(position).postcode = record(5)
            vetorCustomer(position).phoneNumber = record(6)

        End While
        myfile.Close()
    End Sub

    Sub ComplexSearch()
        Dim begchar, endchar As Char
        Dim i, age, searchage As Integer

        Console.WriteLine()
        Console.WriteLine("***** Search for Customers by Surname ******" & vbCrLf)

        Console.Write("Enter beginning letter: ")
        begchar = Console.ReadLine()

        Console.Write("Enter end letter: ")
        endchar = Console.ReadLine()

        Console.Write("Enter age limit: ")
        searchage = Console.ReadLine()

        For i = 0 To UBound(vetorCustomer)
            age = Now.Year - vetorCustomer(i).DoB.Year
            If Left(vetorCustomer(i).surname, 1) >= begchar And Left(vetorCustomer(i).surname, 1) <= endchar And age <= searchage Then
                Console.WriteLine(vetorCustomer(i).id & "," & vetorCustomer(i).firstName & " " & vetorCustomer(i).surname)
            End If
        Next


        Console.WriteLine(vbCrLf & "Press any key to continue...")
        Console.ReadKey()
    End Sub

    Sub FindCustomer()
        ' 'Sub Procedure to find a Student and display Grades
        Dim tempid, i As Integer
        Dim found As Boolean = False

        Dim trueval As Boolean = False

        'Validate input of Integer
        Do
            Try
                Console.Write("Type in customer ID: ")
                tempid = Console.ReadLine
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Error! This is not a Number ...")
                trueval = False
                Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True

        'Use For Loop to search array for customer ID using Simple Linear Search
        For i = 0 To vetorCustomer.Length - 1
            If tempid = vetorCustomer(i).id Then
                found = True
                Exit For                             ' If customer is found then Exit For Loop
            End If
        Next

        'Display Customer Details and 
        If found = True Then
            Console.ForegroundColor = ConsoleColor.Green

            Console.WriteLine()
            Console.WriteLine("*** Customer found ***" & vbCrLf)

            Console.WriteLine()
            Console.WriteLine("Customer Details" & vbCrLf)
            Console.WriteLine("ID" & vbTab & "Name" & vbTab & vbTab & "Date of Birth" & vbTab & vbTab & "Phone Number")
            Console.WriteLine("===========================================================")


            Console.WriteLine(vetorCustomer(i).id & vbTab &
                                  vetorCustomer(i).firstName & " " & vetorCustomer(i).surname & vbTab &
                                  vetorCustomer(i).DoB & vbTab & vbTab &
                                  vetorCustomer(i).phoneNumber)


            Console.ForegroundColor = ConsoleColor.Gray
        Else

            Console.WriteLine("No student found with ID " & tempid)
        End If

        Console.Write(vbCrLf & "Press any key to continue.....")
        Console.ReadKey()
    End Sub
End Module