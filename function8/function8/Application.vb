
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim name, surname, firstcapital As String

		Console.WriteLine("Enter your first name: ")
		name = Console.ReadLine()

		Console.WriteLine("Enter your surname: ")
		surname = Console.ReadLine()

		Dim s2 As String = StrConv(name, VbStrConv.ProperCase)

		Console.Write("Your full name is: {0} ", s2)
		Console.WriteLine(surname.ToUpper)
	
		Console.ReadKey()

	End Sub
End Module
