Imports System
Imports System.Math
Imports Microsoft.VisualBasic


Module module1
	Sub Main()

		Dim TallyChart(29) As Integer 
		Dim i, j As Integer
		Dim results(6) As Integer
		Dim repeat As Char
		Dim temp As Integer

		Dim r As Random = New Random

		
		Do 
			Console.Clear() 

			For i = 0 To 29 Step 1
				TallyChart(i) = r.Next(1, 7)
			Next

			Console.WriteLine()
			Console.WriteLine("Random numbers: ")
			For i = 0 To 29
				Console.Write(TallyChart(i) & " , ")
			
			Next

			For i = 0 To 29
				if TallyChart(i) = 1 Then
					results(0) += 1

					Elseif TallyChart(i) = 2 Then
					results(1) += 1

					Elseif TallyChart(i) = 3 Then
					results(2) += 1

					Elseif TallyChart(i) = 4 Then
					results(3) += 1

					Elseif TallyChart(i) = 5 Then
					results(4) += 1

					Elseif TallyChart(i) = 6 Then
					results(5) += 1
				End if
			Next

			Console.WriteLine()
			Console.WriteLine()
			Console.WriteLine("Number 1: " & results(0))
			Console.WriteLine("Number 2: " & results(1))
			Console.WriteLine("Number 3: " & results(2))
			Console.WriteLine("Number 4: " & results(3))
			Console.WriteLine("Number 5: " & results(4))
			Console.WriteLine("Number 6: " & results(5))

			Console.WriteLine()

			'or using array: '

		
			For i = 0 To 5
				Console.WriteLine("Number " & i + 1 & ": " & results(i))
			Next

			'sorting array into ascending order'

			For i = 1 To TallyChart.Length -1
				For j = 1 To TallyChart.Length -1
					if TallyChart(j - 1) > TallyChart (j)
						temp = TallyChart(j - 1)
						TallyChart(j - 1) = TallyChart(j)
						TallyChart(j) = temp
					end if 
				Next
			Next

			Console.WriteLine()
			Console.WriteLine("Orderd list of random numbers")
			For i = 1 To TallyChart.Length -1
				Console.Write(TallyChart(i) & " , ")
			Next

			Console.WriteLine()
		
			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"



	End Sub
End Module