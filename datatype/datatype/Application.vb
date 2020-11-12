
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()

		'pay attention to the type of variavel because takes memory and runtime'

		Dim a, b As Double
		Dim result As Double
		a = 6.04539009458
		b = 3.98535986884
		result = (a * b)
		Console.WriteLine("Result {0}", result)



		Dim numberofCarsperPeople As Short
		numberofCarsperPeople  = -3000
		Console.WriteLine("London used to have {0} amount of cars per citizen.", numberofCarsperPeople )


		Dim price As Decimal
		price = 5.99
		Console.WriteLine(FormatNumber(price,1))

		Dim initial As char
		initial = "A"
		Console.WriteLine(initial)


		Dim myname As String
		myname = "Rui Neto"
		Console.WriteLine(myname)
		Console.WriteLine(myname.ToUpper)
		Console.WriteLine(myname.ToLower)
		Console.WriteLine(myname.Length)


		Dim DoB As Date
		DoB = #10/30/1990# 'American Format'
		Console.WriteLine("My date of birth is: " &DoB)

		Dim DateofBirth As Date
		Dim age2 As Byte
		DateofBirth = #10-05-2000#
		Console.WriteLine("My age is: {0} "  &age2)
		

		Module SimpleArray

		Public Sub Main()
			' Declare an array with 7 elements.
		Dim students(6) As Integer

		 ' Assign values to each element.
		  students(0) = 23
		  students(1) = 19
		  students(2) = 21
		  students(3) = 17
		  students(4) = 19
		  students(5) = 20
		  students(6) = 22

		' The example displays the following output:
		'     Students in kindergarten: 23
		'     Students in grade 1: 19
		'     Students in grade 2: 21
		'     Students in grade 3: 17
		'     Students in grade 4: 19
		'     Students in grade 5: 20
		'     Students in grade 6: 22




		Dim countries(3,3) As String
		Dim country As String
		Dim capital As String

		countries(3,3) =  ("Brazil", "Brazilia")

		For index = 0 To 3 Step 1
			Console.WriteLine(countries(country, capital))
		Next




		Dim grid(3, 3) As Integer
		Dim row As Integer
		Dim col As Integer
		Dim counter As Integer = 1

		For row = 0 To 3
			For col = 0 To 3
				grid(row, col) = counter
				counter = counter + 1
			Next
		Next


		Dim a As Integer
		Dim b As Integer

		If a > b Then
			Console.WriteLine(a & b)
		Else
			Console.WriteLine(b & a)
		End If 

		

		Console.ReadKey()

	End Sub
End Module	