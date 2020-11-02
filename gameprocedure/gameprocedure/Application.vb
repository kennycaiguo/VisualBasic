Imports System
Imports System.Math
Imports Microsoft.VisualBasic

Module Module1

	Sub Main()
		Call nim()
	End Sub

	Sub nim()
		Dim n As Integer
		Dim counter As Integer
		Dim remove As Integer
		Console.WriteLine("Begin of NIM game!")
		Console.WriteLine()
		Console.WriteLine("Type the number of piles: ")
		n = Console.ReadLine()

		counter = n

		Do
		Console.WriteLine("Type the remove counter (1-3): ")
		remove = Console.ReadLine()

			If (counter >= remove) Then

				Select Case remove
					Case 1
						counter = counter - 1 

					Case 2
						counter = counter - 2

					Case 3
						counter = counter - 3
					Case Else
						Console.WriteLine("Not a valid number. Out of range.")

				End Select

					Console.WriteLine("Piles left are: " & counter)

			Else
				counter = counter - remove
			End If

		
		Loop Until counter <= 0

		If counter = 0 Then
			Console.WriteLine("You are the winner ")
		Else
			Console.WriteLine("You are the loser ")
		End If

	End Sub


End Module
