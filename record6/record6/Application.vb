Imports System.Maths
Imports System
Imports System.Date
Imports Microsoft.VisualBasic

Module module1

		Structure Student
			Dim name As String 
			Dim id As Integer
			Dim course As String
			Dim DateOfBirth As Date
		End Structure

		Dim students(0 To 5) As Student

	Sub Main()
		Dim index, counter As Integer
	
		index = 1

		For index = 1 To 5
			Console.WriteLine("-----------------")
			Console.WriteLine("Student {0} Name: ", index)
			students(index).name = Console.ReadLine()

			Console.WriteLine("Student {0} ID: ", index)
			students(index).id = Console.ReadLine()

			Console.WriteLine("Student {0} Date Of Birth: ", index)
			students(index).DateOfBirth = Console.ReadLine()

			Console.WriteLine("Student {0} Course: ", index)
			students(index).course = Console.ReadLine()
		Next

		For index = 1 To 5
			Console.WriteLine()
			Console.WriteLine("Name: {0} ", students(index).name)
			Console.WriteLine("ID: {0} ", students(index).id)
			Console.WriteLine("Date of Birth: {0} ", students(index).DateOfBirth)
			Console.WriteLine("Course: {0} ", students(index).course)

		Next
		
			
	End Sub
End Module