
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1

	Function Initial(ByVal s As String) As String
			Dim ret As String

			ret = Left(s,1) 'funcao para pegar posicao numero um de uma string'
			ret = UCase(ret) 'maiuscula'

		Return ret
		End Function

	Sub Main()

		Do

		Dim name As String
		Console.WriteLine("Type in a name: ")
		name = Console.ReadLine()

		Console.WriteLine("Initial = " & Initial(name))
			
		Loop While repeat = "y" Or repeat = "Y"

	End Sub
End Module	