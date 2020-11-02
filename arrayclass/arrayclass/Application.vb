Imports System
Imports System.Math

Module module1
	Sub Main()

		'Array for sort the string (ordem alfabetica)'
	
		Dim classList(7) As String
		Dim temp As String
		Dim i, j As Integer
		

		classlist(0) = "Patrick"
		classlist(1) = "Rui"
		classlist(2) = "Gabor"
		classlist(3) = "Kimberly"
		classlist(4) = "Adriana"
		classlist(5) = "Parth"
		classlist(6) = "Chindi"


		Console.WriteLine("******* Unsorted Class List ********")

		For i = 0 To 7
			Console.Write(classlist(i) & " ")
		Next

		'sort Array into Ascending order'


		For j = 1 To classlist.Length - 1
			For i = 1 To classlist.Length - 1
				if  classlist(i-1) > classlist(i) Then
					Console.WriteLine()
					Console.WriteLine(classlist(i - 1) & " is greater than " & classlist(i))
					Console.WriteLine("Swap")
					Console.ReadKey()
					temp = classlist(i - 1)
					classlist(i - 1) = classlist(i)
					classlist(i) = temp
				End if
			Next
		Next

		Console.WriteLine()
		Console.WriteLine()

		Console.WriteLine("******* Sorted Class List ********")

		For i = 0 To classlist.Length - 1
			Console.Write(classlist(i) & " ")
		Next

	End Sub
End Module