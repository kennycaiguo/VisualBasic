Imports System

Module module1
	Sub Main()
		Dim age As Integer


		Console.WriteLine("Type your age: ")
		age = Console.ReadLine()

		If age >= 16 Then

			Console.WriteLine("You are old enough to drive.")

		Else

			Console.WriteLine("Not old enough to drive!")

		End If

	End Sub
End Module
