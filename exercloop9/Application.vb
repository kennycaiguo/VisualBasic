
Imports System

Module module1
	Sub Main()

		Dim counter, result, i As Integer
		Dim repeat As Char

		Do
			Console.Clear() 'limpar o console'

			Console.WriteLine("Please enter a number for N times table: ")
			counter = Console.ReadLine()

			Console.WriteLine(counter & " Times Table " & vbCrLf & vbCrLf)

			For i = 1 To 10
				result = (i * counter)
				Console.WriteLine(i & " x " & counter & " = " &result)
			Next 

			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



		Console.ReadLine()


	End Sub
End Module


