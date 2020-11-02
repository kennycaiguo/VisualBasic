Imports System


Module module1
	Sub Main()


		Dim fahrenheit, celsius, result As Decimal

		Console.WriteLine("Exercise 3")
		Console.WriteLine()
		Console.WriteLine("Please type the temperature in Fahrenheit: ")
		fahrenheit = Console.ReadLine()
		result = ((fahrenheit - 32) * (5/9))

		Console.WriteLine("The conversion to Celsius is: " & result & " °C")

	End Sub
End Module
