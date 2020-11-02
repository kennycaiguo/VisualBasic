
Imports System

Module module1
	Sub Main()

		Dim counter, result, i, number, average As Integer 

		i = 0
		result = 0

		Console.WriteLine("Please enter how many numbers to be averaged: ")
		counter = Console.ReadLine()

		Do 
			Console.WriteLine("Enter the " & i & " number:")
			number = Console.ReadLine()
			result = result + number 'somar numeros'
			i = i + 1 'contador'
		Loop Until i = counter  'restrict the loop'

		average = (result / counter)

		Console.WriteLine("Average: " & result & " / " & counter & " = " &average)

		Console.ReadKey()

	End Sub
End Module


