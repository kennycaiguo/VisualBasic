
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim test, counter As String

		Console.WriteLine("Type a string please")
		test = Console.ReadLine()

		counter = Len(test)

		Console.WriteLine("Numbers of characteres: {0} ", counter)
			
		Console.ReadKey()

	End Sub
End Module
