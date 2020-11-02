Imports System
				
' Calcular o volume de uma piscina com diferentes volumes '

Public Module Module1
	Public Sub Main()
		Dim length, width, shallowend, deepend, depth, volumeLiters, volume As Decimal 'Dim : used to variable data type / Dim ... As ... '
		
		Console.WriteLine("Calculating the Volume of your pool!")
		
		Console.WriteLine("Please enter the length (m):")
		length = Console.ReadLine
		
		Console.WriteLine("Please enter the width (m):")
		width = Console.ReadLine
		
		Console.WriteLine("Please enter the depth of Shallow end (m):")
		shallowend = Console.ReadLine

		Console.WriteLine("Please enter the depth of Deep end (m):")
		deepend = Console.ReadLine

		depth = (deepend - shallowend) 'calculate the depth of the swimming pool'
		
		Console.WriteLine() 'Pular linha'
		
		volume = (length * width * depth)

		volumeLiters = (length * width * depth) * 1000
		
		Console.WriteLine("The volume in cubic meters is: " & volume)

		Console.WriteLine("The volume of the swimming pool in Liters is: " & volumeLiters.ToString("N2")) 'To convert the Decimal 1,000.00'

		
	End Sub
End Module
