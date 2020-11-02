Imports System
Imports System.Math

Module module1
	Sub Main()

		Dim mynumbers() As Integer = {10,9,8,7,6,5,4,3,2,1} 'another way of dimension arrays'
		Dim i, temp, n As Integer
		Dim swapped As boolean
		


		' can you output the array contents of the array all on 1 line separated by comma'

		For i = 0 To 9 Step 1
			Console.Write(mynumbers(i) & " , ")
		Next

		n = mynumbers.Length
	
		'Bubble sort'

		Do

			swapped = false

			For i = 1 To n - 1
				if mynumbers(i - 1) > mynumbers(i) Then
					temp = mynumbers(i - 1)
					mynumbers(i - 1) = mynumbers(i)
					mynumbers(i) = temp
					swapped = True
				End if
			Next

		Loop Until Not swapped 

			Console.WriteLine()
			Console.WriteLine("Sorted Array")
			
			For i = 0 To mynumbers.Length - 1
				Console.Write(mynumbers(i) & " , ")
			
			Next

	End Sub
End Module