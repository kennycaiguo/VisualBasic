Imports System
Imports System.Math

Module module1

		Dim MaxNoOfStars, NoOfStars, NoOfSpaces As Integer


	Sub InitialiseNoOfSpacesAndStars()

		Console.WriteLine("How many stars should be at the base?")
		MaxNoOfStars = Console.ReadLine()

		NoOfSpaces = MaxNoOfStars / 2
		NoOfStars = 1

	End Sub

	Sub OutputLeadingSpaces()

		Dim count As Integer

		For count = 1 To NoOfSpaces Step 1
			Console.Write(" ")
		Next count

	End Sub

	Sub OutputLineOfStars()
		Dim count As Integer

		For count = 1 To NoOfStars Step 1
			Console.Write("*")

		Next count
		Console.WriteLine()

	End Sub

	Sub AdjustNoOfSpacesAndStars()
		NoOfSpaces = NoOfSpaces - 1
		NoOfStars = NoOfStars + 2
	End Sub


	'main program starts here'


	Sub Main()

		Dim repeat As Char

		Do

			InitialiseNoOfSpacesAndStars()

			Do

				OutputLeadingSpaces()
				OutputLineOfStars()
				AdjustNoOfSpacesAndStars()

			Loop Until NoOfStars > MaxNoOfStars

			
			

			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



	End Sub
End Module