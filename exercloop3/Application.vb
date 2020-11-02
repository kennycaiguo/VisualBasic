
Imports System

Module module1
	Sub Main()

		Dim i, counter, initial As Integer
		Dim message As String

		initial = 1

		Console.WriteLine("Enter a short message please")
		message = Console.ReadLine()

		Console.WriteLine("Enter how many times you want to be displayed.")
		counter = Console.ReadLine()


		For i = initial To counter Step  1
			Console.WriteLine(message)
		
		Next 

		Console.ReadLine()

	End Sub
End Module
