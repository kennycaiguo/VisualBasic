Imports System.Maths
Imports System
Imports System.Date
Imports Microsoft.VisualBasic

Module module1

		Structure Friends
			Dim name As String 
			Dim age As Integer
		End Structure

		Dim friends1(0 To 5) As Friends

	Sub Main()
		Dim index, counter, sum As Integer
		Dim average As Double
	
		index = 1

		For index = 1 To 5
			Console.WriteLine("-----------------")
			Console.WriteLine("First Name: ")
			friends1(index).name = Console.ReadLine()

			Console.WriteLine("Age: ")
			friends1(index).age = Console.ReadLine()
			sum = sum + friends1(index).age
		Next
		
		average = (sum / 5)
		Console.WriteLine()
		Console.WriteLine("Average Age: {0}", average.ToString("#,##0.00"))

		
		For index = 1 To 5
			Console.WriteLine()
			if (friends1(index).age > average) Then
				Console.WriteLine("Name: {0} ", friends1(index).name)
				Console.WriteLine("You are older than average.")
			Else
				Console.WriteLine("Name: {0} ", friends1(index).name)
				Console.WriteLine("You are younger than average.")
			End If

		Next
		
			
	End Sub
End Module