Imports System
Imports System.Math

Module module1
	Sub Main()

		Dim TallyChart(0 To 6) As String  
		Dim i, x, counter As Integer
		Dim repeat As Char

		counter = 0
		
		Do 
			Console.Clear() 

			For i = counter To 6 Step 1
				Console.WriteLine("Type a number: ")
				TallyChart(i) = Console.ReadLine()

				Select Case TallyChart(i)

					case 1
						x = x + 1

					case 2
						x = x + 1

					case 3
						x = x + 1

					case 4
						x = x + 1
	
					case 5
						x = x + 1

					case 6
						x = x + 1

				End Select

			Next 

			Console.WriteLine()
	
			Console.WriteLine("Number | Repeated x")

			For i = counter To 6 Step 1
				Console.WriteLine("Number " & i & ": " & x)
			Next 
		
			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



	End Sub
End Module