Imports System
Imports System.Math

Module module1
	Sub Main()

		Dim numbers(0 To 10), index As Integer
		Dim Rand as New Random()
		Dim repeat As Char
		Dim SelectedValue
		
		Do 
			Console.Clear()
			numbers(0) =  3
			numbers(1) =  60
			numbers(2) =  30
			numbers(3) =  32
			numbers(4) =  33
			numbers(5) =  9
			numbers(6) =  31
			numbers(7) =  10
			numbers(8) =  5
			numbers(9) =  6


			Console.WriteLine(numbers(3))
			Console.WriteLine("Random Numbers")
			
			index = Rand.Next(0, numbers.Length - 1)
		    SelectedValue = numbers(index)

			Console.WriteLine("Number: " & SelectedValue)
	
		
			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



	End Sub
End Module