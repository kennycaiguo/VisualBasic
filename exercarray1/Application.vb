Imports System
Imports System.Math

Module module1
	Sub Main()

		Dim Name(0 To 6) As String  'the array' 
		Dim i, counter, counterrev As Integer
		Dim repeat As Char

		counter = 1
		counterrev = 6
		
		Do 
			Console.Clear() 

			For i = counter To 6 Step 1
				Console.WriteLine("Type a name please: ")
				Name(i) = Console.ReadLine()
			Next

			Console.WriteLine()
			Console.WriteLine("NORMAL ORDER")

			For i = counter To 6 Step 1
				Console.WriteLine("Name " & i & ": " & Name(i))
			Next 


			Console.WriteLine()
			Console.WriteLine("REVERSE ORDER")

		
			For i = counterrev To 1 Step -1
				Console.WriteLine("Name " & i & ": " & Name(i))
			Next 

			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



	End Sub
End Module