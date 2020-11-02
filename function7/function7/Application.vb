
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim data As Date = Now()
		Dim tomorrow As Date

		
		Console.WriteLine("Today's date: " & data.addDays(1))
		
		Console.ReadKey()

	End Sub
End Module
