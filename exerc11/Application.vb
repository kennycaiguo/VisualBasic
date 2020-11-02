
Imports System

Module module1
	Sub Main()
		Dim number1, number2, number3 As Integer


		Console.WriteLine("Exercise 10")
		Console.WriteLine("Type the first number: ")
		number1 = Console.ReadLine()

		Console.WriteLine("Type the second number: ")
		number2 = Console.ReadLine()

		Console.WriteLine("Type the third number: ")
		number3 = Console.ReadLine()


		If (number1 > number2 and number1 > number3) Then

			Console.WriteLine("Larger number: " & number1)

		Else

			If (number2 > number1 and number2 > number3) Then

				Console.WriteLine("Larger number: " & number2)

			Else 

				Console.WriteLine("Larger number: " & number3)

			End if

		End If

	End Sub
End Module
