
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()

		Dim guess, counter, r_number As Integer
		Dim repeat As Char
		Dim truvalue As Boolean
		Dim r As Random = New Random
		
		Do 
			Console.Clear()
			r_number = r.Next(1,11)
			counter = 0

			Do 

				Do
					' The method try and catch e para validar os erros / colocar cor e entrar em um loop ate entrar o correto valor'

					Try 
						Console.ForegroundColor = ConsoleColor.Black
						Console.WriteLine("Please enter your guess: ")
						guess = Console.ReadLine()
						truvalue = True

					Catch ex As Exception 
						Console.ForegroundColor = ConsoleColor.Red
						Console.WriteLine("Error. This is not a number. ")
						Console.WriteLine(Chr(7))
						truvalue = False

					End Try

				Loop Until truvalue  = True
				

				if (guess = r_number) Then
					counter += 1
					Console.WriteLine("Correct. It took you {0} chance", counter)

				Else
					if (guess > r_number) Then 
						counter += 1
						Console.WriteLine("Wrong number. Guess Lower.")
					Else 
						counter += 1
						Console.WriteLine("Wrong number. Guess Higher.")
					End If
				End If


			Loop While guess <> r_number
			
			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"

	End Sub
End Module	