
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim code As Char
		Dim test As Integer

		Console.WriteLine("Type a the ASCII code please")
		test = Console.ReadLine()

		code = ChrW(test)

		Console.WriteLine("Char: {0} ", code)
			
		Console.ReadKey()

	End Sub
End Module
