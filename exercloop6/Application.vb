
Imports System

Module module1
	Sub Main()

		Dim num, result, i As Integer

		Console.WriteLine("Please enter a number")
		num = Console.ReadLine()

		For i = 1 To num Step  1

			result = (i * i)

			Console.WriteLine(i & " squared = " &result)

			If i MOD 5 = 0 Then
				Console.WriteLine(" --- ")
			End If 

		Next

		Console.ReadLine()


	End Sub
End Module


