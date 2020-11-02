
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim code As Integer
		Dim test As Char

		Console.WriteLine("Type a Char please")
		test = Console.ReadLine()

		code = Asc(test)

		Console.WriteLine("ASCII code: {0} ", code)
			
		Console.ReadKey()

	End Sub
End Module
