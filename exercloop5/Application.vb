
Imports System

Module module1
	Sub Main()

		Dim counter, initial As Integer
		Dim i, y As Integer
		Dim a, b As String


		Console.WriteLine("Please enter the number of rows to be displayed")
		counter = Console.ReadLine()

		Console.WriteLine("Please enter the number of stars per row")
		initial = Console.ReadLine()


		For i = 1 To counter Step  1

			For y = 1 To i Step  1

				Console.WriteLine("*")

			Next

			Console.WriteLine()

		Next

		Console.ReadLine()


	End Sub
End Module


