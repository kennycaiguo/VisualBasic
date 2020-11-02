
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim r As Random = New Random
		Dim r_number As Integer
		Dim repeat As String
		Do 
			Console.Clear()
			r_number = r.Next(5,11)
			Console.WriteLine(r_number)
			
			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"

	End Sub
End Module	