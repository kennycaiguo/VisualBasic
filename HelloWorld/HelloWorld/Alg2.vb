Imports System
				
Public Module Module1
	Public Sub Main()
		Dim Number1, Number2, Number3, sum As Integer
		Console.WriteLine("Please enter in a number:")
		Number1 = Console.ReadLine
		
		Console.WriteLine("Please enter another number:")
		Number2 = Console.ReadLine
		
		Console.WriteLine("Please enter the last number")
		Number3 = Console.ReadLine
		
		sum = Number1 + Number2 + Number3
		
		Console.WriteLine(Number1 & " + " & Number2 & " + " & Number3 & " = " & sum)  

		
		REM 
		
	End Sub
End Module