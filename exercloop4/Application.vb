
Imports System

Module module1
	Sub Main()

		Dim counter, initial As Integer
		Dim i, result As Double 

		initial = 1
		counter = 12


		Console.WriteLine("Number = Square of Number")


		For i = initial To counter Step  1
			result = (i * i)
			Console.WriteLine(i & "² = " & result)

		Next 

		Console.ReadLine()


	End Sub
End Module
