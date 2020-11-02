
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim countries(9,1), capital, capitalLower As String
		Dim correct, i, wrong, counter As Integer
		Dim aleatorio As Random = New Random 
		Dim SelectedCountry As String
		Dim random_country, index As Integer
		Dim repeat As Char

		Do
			Console.Clear()
			countries(0,0) = "Brazil"
			countries(1,0) = "Jamaica"
			countries(2,0) = "United Kingdom"
			countries(3,0) = "United States"
			countries(4,0) = "Argentina"
			countries(5,0) = "Espanha"
			countries(6,0) = "Portugal"
			countries(7,0) = "Chile"
			countries(8,0) = "Bolivia"
			countries(9,0) = "France"

			countries(0,1) = "brazilia"
			countries(1,1) = "kingston"
			countries(2,1) = "london"
			countries(3,1) = "washington"
			countries(4,1) = "buenos Aires"
			countries(5,1) = "madrid"
			countries(6,1) = "lisbon"
			countries(7,1) = "santiago"
			countries(8,1) = "bogota"
			countries(9,1) = "paris"

			'Console.WriteLine(countries(9,0))'

			For i = 0 To 4 Step 1

				random_country = aleatorio.Next(0,10)
				SelectedCountry = countries(random_country,0) 
				Console.WriteLine("Random country: " & SelectedCountry)

				Console.WriteLine("Type the capital: ")
				capital = Console.ReadLine()

				capitalLower = capital.ToLower() 'para converter tudo em minuscula'

				SelectedCountry = countries(random_country, 1) 'selecionar um pais e capital'
				
				if (capitalLower = SelectedCountry) Then 'se a string capitalLower for igual a string da posicao (random,1)'
					correct += 1
				Else
					wrong += 1
				End If

			Next 

			Console.WriteLine("You got {0} correct. ", correct)
			Console.WriteLine("And {0} wrong. ", wrong)
	
			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"

		Console.ReadKey()

	End Sub
End Module
