Imports System
				
Public Module Module2
	Public Sub Main()
		Dim length, width, depth, volume As Decimal 'Dim : used to variable data type / Dim ... As ... '
		
		Console.WriteLine("Calculating the Volume of your pool!")
		
		Console.WriteLine("Please enter the length:")
		length = Console.ReadLine
		
		Console.WriteLine("Please enter the width:")
		width = Console.ReadLine
		
		Console.WriteLine("Please enter the depth")
		depth = Console.ReadLine
		
		Console.WriteLine() 'Pular linha'
		
		volume = (length * width * depth)
		
		Console.WriteLine("Volume = " & volume & "m³")  

		
		REM 
		
	End Sub
End Module