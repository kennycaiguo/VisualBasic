﻿
Imports System

Module module1
	Sub Main()

		Dim counter, number As Integer
		Dim repeat As Char

		counter = 0 'initialize variables'
		
 
		Do ' Usa um Do Loop While para executar o programa mais vezes.'
			Console.Clear() 'limpar o console'

			Do
				Console.WriteLine("Please type a number between 10 and 20")
				number = Console.ReadLine()
				counter = counter  + 1
			Loop until number <= 20 and number >= 10


			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



		Console.ReadLine()


	End Sub
End Module

