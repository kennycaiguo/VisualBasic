Imports System

Module module1
	Sub Main()

	Dim month, NoOfDays As Integer

	Console.WriteLine("Exercise 13")
	Console.WriteLine()
	Console.WriteLine("Please type a MONTH number: ")
	month = Console.ReadLine()

	Select Case month

		Case 1, 3, 5, 7, 8, 10, 12
			NoOfDays = 31
		Case 4, 6, 9, 11
			NoOfDays = 30
		Case 2
			NoOfDays = 28
		Case Else
			Console.WriteLine("Not a month.")
	End Select

	Console.WriteLine("This month has " & NoOfDays & " days. ")
	


	End Sub
End Module
