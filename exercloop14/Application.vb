Imports System
Imports System.Math

Module module1
	Sub Main()

		Dim maior, menor, i, counter, number, MaxValue, MinValue As Integer
		Dim repeat As Char

		counter = 0 'initialize variables' 
		
		Do ' execute more times.'
			Console.Clear() 'limpar o console'

			For i = counter To 3 Step 1

				Console.WriteLine("Type a number: ")
				number = Console.ReadLine()

				MaxValue = number > MaxValue
				MinValue = number < MinValue

                ' maior = Math.max(maior, number)'
				' menor = Math.Min(menor, number)'

			Next

			Console.WriteLine("Largest number: " & MaxValue)
			Console.WriteLine("Smaller number: " & MinValue)

			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



	End Sub
End Module