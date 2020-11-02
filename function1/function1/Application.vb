
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim number, rounded, truncated As Decimal

		Console.WriteLine("Type a number please")
		number = Console.ReadLine()

		rounded = Math.Round(number)
		truncated = Math.Truncate(number)


		Console.WriteLine("Rounded: {0} ", rounded)
		Console.WriteLine("Truncated: {0} ", truncated)
			
		Console.ReadKey()

	End Sub
End Module
