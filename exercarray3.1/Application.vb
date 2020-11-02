Imports System
Imports System.Math

Module module1
	Sub Main()

		Dim numbers(0 To 4), i, index, counter As Integer
		Dim repeat As Char

		counter = 0
		
		Do 
			Console.Clear()

			numbers(0) = 4
			numbers(1) = 5
			numbers(2) = 40
			numbers(3) = 48
			numbers(4) = 7

			Console.WriteLine("The third element of this array contains: " & numbers(3))

			Console.WriteLine("Interacting through the entire array: ")

			For index = 0 To numbers.Length - 1
				Console.WriteLine(numbers(index))
			Next 
			

			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



	End Sub
End Module