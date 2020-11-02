
Imports System

Module module1
	Sub Main()

		Dim counter, number,  result As Integer
		Dim repeat As Char

		counter = 0 'initialize variables'
		result = 0
 
		Do ' Usa um Do Loop While para executar o programa mais vezes.'
			Console.Clear() 'limpar o console'

			Do
				Console.WriteLine("Please enter a number -0 to finish: ")
				number = Console.ReadLine()
				result = result + number
				counter = counter  + 1
			Loop until number = 0

			Console.WriteLine("The TOTAL sum is: " &result)


			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



		Console.ReadLine()


	End Sub
End Module


