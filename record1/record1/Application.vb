
Imports System

Module module1
		Structure Country 
			Dim nameOfCountry As String 
			Dim nameOfcurrency As String
			Dim exchangeRate As Decimal

		End Structure

	Sub Main()

		Dim country1, country2, country3 As Country

	
		Console.WriteLine("Type for me name of the Country: ")
		country1.nameOfCountry = Console.ReadLine()

		Console.WriteLine("Type for the Currency: ")
		country1.nameOfcurrency = Console.ReadLine()

		Console.WriteLine("Exchange Rate to Pounds: ")
		country1.exchangeRate = Console.ReadLine()

		Console.WriteLine("Type for me name of the Country: ")
		country2.nameOfCountry = Console.ReadLine()

		Console.WriteLine("Type for the Currency: ")
		country2.nameOfcurrency = Console.ReadLine()

		Console.WriteLine("Exchange Rate to Pounds: ")
		country2.exchangeRate = Console.ReadLine()

		Console.WriteLine("Type for me name of the Country: ")
		country3.nameOfCountry = Console.ReadLine()

		Console.WriteLine("Type for the Currency: ")
		country3.nameOfcurrency = Console.ReadLine()

		Console.WriteLine("Exchange Rate to Pounds: ")
		country3.exchangeRate = Console.ReadLine()

		
		Console.WriteLine("--------------------")

		Console.WriteLine("Name of the country: {0}", country1.nameOfCountry)
		Console.WriteLine("Name of the currency: {0}", country1.nameOfcurrency)
		Console.WriteLine("Exchange Rate to Pounds: {0}", country1.exchangeRate)

		Console.WriteLine("--------------------")

		Console.WriteLine("Name of the country: {0}", country1.nameOfCountry)
		Console.WriteLine("Name of the currency: {0}", country1.nameOfcurrency)
		Console.WriteLine("Exchange Rate to Pounds: {0}", country1.exchangeRate)

		Console.WriteLine("--------------------")

		Console.WriteLine("Name of the country: {0}", country1.nameOfCountry)
		Console.WriteLine("Name of the currency: {0}", country1.nameOfcurrency)
		Console.WriteLine("Exchange Rate to Pounds: {0}", country1.exchangeRate)


	End Sub
End Module

