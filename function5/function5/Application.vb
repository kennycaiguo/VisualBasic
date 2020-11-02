
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim surname As String
		Dim index As String

		Console.WriteLine("Type your surname:")
		surname = Console.ReadLine()

		Console.WriteLine("Your name in uppercase: " & surname.ToUpper())
		
		
		Console.ReadKey()

	End Sub
End Module
