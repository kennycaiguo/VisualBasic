Imports System
Imports System.Math

Module module1
	Sub Main()

		Dim TallyChart(0 To 29) As Integer 
		Dim i, a, b, c, d, e, f, counter As Integer
		Dim repeat As Char

		counter = 0
		
		Do 
			Console.Clear() 

			For i = counter To 29 Step 1
				Console.WriteLine("Type a number: ")
				TallyChart(i) = Console.ReadLine()

				Select Case TallyChart(i)

					case 1
						a = a + 1

					case 2
						b = b + 1

					case 3
						c = c + 1

					case 4
						d = d + 1
	
					case 5
						e = e + 1

					case 6
						f = f + 1

				End Select

			Next 

			Console.WriteLine()

			Console.WriteLine("Number | Repeated x")
			Console.WriteLine("Number 1: " & a)
			Console.WriteLine("Number 2: " & b)
			Console.WriteLine("Number 3: " & c)
			Console.WriteLine("Number 4: " & d)
			Console.WriteLine("Number 5: " & e)
			Console.WriteLine("Number 6: " & f)
		
			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



	End Sub
End Module