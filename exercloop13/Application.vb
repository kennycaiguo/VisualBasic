
Imports System

Module module1
	Sub Main()

		Dim kg, pounds, conversion, i, counter As Decimal
		Dim repeat As Char

		counter = 0 'initialize variables'
		
		Do ' execute more times.'
			Console.Clear() 'limpar o console'

			For i = counter To 12 Step  1

				kg = (i * 2.2)
				Console.WriteLine(i & " pound = " & kg & "kg.")

			Next 

			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"


	End Sub
End Module

