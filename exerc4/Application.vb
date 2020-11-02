Imports System


Module module1
	Sub Main()


		Dim height, weight, centimetres, kilograms As Decimal

		Console.WriteLine("Exercise 4")
		Console.WriteLine()
		Console.WriteLine("Please type your height (inches): ")
		height = Console.ReadLine()

		Console.WriteLine("Please type your weight (stones): ")
		weight = Console.ReadLine()


		centimetres = ( height * 2.54)
		kilograms =  ( weight * 6.364)

		Console.WriteLine("Height: " & centimetres & " centimetres")
		Console.WriteLine("Weight: " & kilograms & " kilograms")

	End Sub
End Module
