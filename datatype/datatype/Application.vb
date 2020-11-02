
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()

		'pay attention to the type of variavel because takes memory and runtime'

		Dim a, b As ULong
		Dim result As Decimal
		a = 6039
		b = 395049599
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
		DoB = #10/30/1990#
		Console.WriteLine("My date of birth is: {0} " &DoB)

		Dim DateofBirth As Date
		Dim age2 As Byte
		DateofBirth = #10-05-2000#
		Console.WriteLine("My age is: {0} "  &age2)
		

		Console.ReadKey()

	End Sub
End Module	