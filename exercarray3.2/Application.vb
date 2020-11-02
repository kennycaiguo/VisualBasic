Imports System
Imports System.Math

Module module1
	Sub Main()

		Dim numbers(0 To 10), index, counter As Integer
		Dim Rand as New Random()
		Dim repeat As Char
		Dim SelectedValue, num As Integer

		counter = 0
		
		Do 
			Console.Clear()

			For index = 0 To 10 Step 1
				numbers(index) = index + 1

			Next

			Console.WriteLine("Random Numbers")
			
			Do 
				index = Rand.Next(0, numbers.Length - 1)
				SelectedValue = numbers(index)
				Console.WriteLine("Number: " & SelectedValue)
				counter = counter + 1
				
			Loop Until (counter = 10)

		
			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



	End Sub
End Module