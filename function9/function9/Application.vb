
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim number As Integer

		Randomize()

		Do 
			number = Int(Rnd() * 6)
			number = number + 1

			Console.WriteLine(number)
		Loop Until number = 6


		Console.ReadKey()

	End Sub
End Module
