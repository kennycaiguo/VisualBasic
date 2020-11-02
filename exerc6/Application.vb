Imports System


Module module1
	Sub Main()


		Dim length, width, area, turfing As Decimal

		Console.WriteLine("Exercise 6")
		Console.WriteLine()
		Console.WriteLine("Please type the length of your garden (metre): ")
		length = Console.ReadLine()

		Console.WriteLine("Please type the width of your garden (metre): ")
		width = Console.ReadLine()

		Console.WriteLine()
		Console.WriteLine("Calculating the area.......")
		Console.WriteLine()

		
		area = ((length - 2) * (width - 2))
		turfing = (area * 10)


		Console.WriteLine("Area: " & area & " square metres")
		Console.WriteLine("The TOTAL cost of turfing a lawn is: " & turfing & " Pounds")
		

	End Sub
End Module
