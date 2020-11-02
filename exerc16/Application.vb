Imports System

Module module1
	Sub Main()

	Dim marks As Integer
	Dim grade As String

	Console.WriteLine("Exercise 16")
	Console.WriteLine()

	Console.WriteLine("Please type your marks: ")
	marks = Console.ReadLine()

	
	Select Case marks

		Case 0 to 40
			grade = "grade U"
		Case 41 to 50
			grade = "grade E"
		Case 51 to 60
			grade = "grade D"
		Case 61 to 70
			grade = "grade C"
		Case 71 to 80
			grade = "grade B"
		Case 81 to 100
			grade = "grade A"
		Case Else 
			grade = "Not valid marks"

	End Select

	Console.WriteLine("Your grade is: " &grade)
	
	End Sub
End Module
