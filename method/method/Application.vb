Imports System
Imports System.Math
Imports Microsoft.VisualBasic

Module Module1

	Sub Main()
		Call displayTheMessage() 'call like this'
		displayTheMessage() 'or call like this'


		Dim message As String
		message = superSecretFormula()
		Console.WriteLine(message)
		Console.WriteLine(superSecretFormula(" Rui Neto "))

	End Sub





	Sub displayTheMessage()
		Console.WriteLine("From display TheMessage")
	End Sub


	Function superSecretFormula() As String
		Return "Hello World!"
	End function


	Function superSecretFormula(ByVal name As String) As String
		return String.Format("Hello {0} ", name)
	End Function

	'you can create as many as you want but different number or data type, input parameters.'

End Module
