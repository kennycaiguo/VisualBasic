
Imports System
Imports Microsoft.VisualBasic
Imports System.Math

Module module1
	Sub Main()
		Dim countries(9,1), capital, capitalLower As String
		Dim counter, i As Integer
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

			Console.WriteLine(countries(9,0))

			random_country = aleatorio.Next(0,10) 'numero aleatorio para os paises '
			SelectedCountry = countries(random_country,0) 'selecionar um pais com o numero aleatorio'

			Console.WriteLine("Random country: " & SelectedCountry)

			Do 
				Console.WriteLine("Type the capital: ")
				capital = Console.ReadLine()

				capitalLower = capital.ToLower() 'para converter tudo em minuscula'

				SelectedCountry = countries(random_country, 1) 'selecionar um pais e capital'
				counter += 1

				if (capitalLower = SelectedCountry) Then 'se a string capitalLower for igual a string da posicao (random,1)'
					Console.WriteLine("Correct. It took you {0} chances", counter)
				Else
					Console.WriteLine("Wrong guess. Try again.")
					
				End If
				
			Loop While capitalLower <> SelectedCountry


			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"

		Console.ReadKey()

	End Sub
End Module

			