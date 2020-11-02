Imports System

Module module1
	Sub Main()

	Dim num1, result As Decimal

	Console.WriteLine("Exercise 9")
	Console.WriteLine()
	Console.WriteLine("Please type a number: ")
	num1 = Console.ReadLine()

	if (num1 >= 21 and num1 <= 29) then 
	Console.WriteLine()
	Console.WriteLine("Your number is between 21 - 29.")

	else 

	Console.WriteLine()
	Console.WriteLine("Your number is out of the range.")

	End if 
	


	End Sub
End Module
