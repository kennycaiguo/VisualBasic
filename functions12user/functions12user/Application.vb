
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1

	Function Initial(ByVal s As Decimal) As Decimal
			Dim celsius As Decimal

			celsius = ((s - 32) * (5/9))

		Return celsius
		End Function

	Sub Main()

		
		Dim temp As Decimal
		Console.WriteLine("Type in the temperature in Fahrenheit: ")
		temp = Console.ReadLine()

		Console.WriteLine("Celsius = " & Initial(temp))
			

	End Sub
End Module	