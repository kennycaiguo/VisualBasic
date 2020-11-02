Imports System

Module module1
	Sub Main()
		Dim number1, number2 As Integer


		Console.WriteLine("Exercise 10")
		Console.WriteLine("Type the first number: ")
		number1 = Console.ReadLine()

		Console.WriteLine("Type the second number: ")
		number2 = Console.ReadLine()

		If number1 > number2 Then

			Console.WriteLine("Larger number: " & number1)

		Else

			Console.WriteLine("Larger number: " &number2)

		End If

	End Sub
End Module
