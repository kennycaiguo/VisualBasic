Imports System

Module module1
	Sub Main()

	Dim month As Integer
	Dim MonthName As String 

	Console.WriteLine("Exercise 13")
	Console.WriteLine()
	Console.WriteLine("Please type a MONTH number: ")
	month = Console.ReadLine()

	Select Case month

		Case 1
			MonthName = "January"

		Case 2
			MonthName = "February"

		Case 3
			MonthName = "March" 

		Case 4
			MonthName = "April"

		Case 5
			MonthName = "May"

		Case 6
			MonthName = "June"

		Case 7
			MonthName = "July"

		Case 8
			MonthName = "August"

		Case 9
			MonthName = "September"

		Case 10
			MonthName = "October"

		Case 11
			MonthName = "November"

		Case 12
			MonthName = "December"
		
		Case Else
			Console.WriteLine("Not a month.")
	End Select

	Console.WriteLine("Month: " & MonthName)
	


	End Sub
End Module
