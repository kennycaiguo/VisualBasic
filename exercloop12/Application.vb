
Imports System

Module module1
	Sub Main()

		Dim counter, number, sum, average As Integer
		Dim repeat As Char

		counter = 0 'initialize variables'
		sum = 0
		
 
		Do ' execute more times.'
			Console.Clear() 'limpar o console'

			Do
				Console.WriteLine("Please type a number between 10 and 20")
				number = Console.ReadLine()
				sum = sum + number
				
				counter = counter  + 1
			Loop until number <= 20 and number >= 10

			average = (sum / counter)

			Console.WriteLine("Total Sum: " & sum)
			Console.WriteLine("Average: " & average)
			

			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"


	End Sub
End Module

