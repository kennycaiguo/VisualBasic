Imports System


Module module1
	Sub Main()


		Dim num1, num2, result as Decimal

		Console.WriteLine("Exercise 2")
		Console.WriteLine()

		Console.WriteLine("Please type the first number: ")
		num1 = Console.ReadLine()

		Console.WriteLine("Please type the second number: ")
		num2 = Console.ReadLine()
		
		result = (num1 * num2)

		Console.WriteLine(num1 & "x" & num2  & " = " & result)


	End Sub
End Module
