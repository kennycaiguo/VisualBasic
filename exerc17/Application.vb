Imports System

Module module1
	Sub Main()

	Dim month, NoOfDays, year As Double
	Dim repeat As String

	Console.WriteLine("Exercise 13")
	Console.WriteLine()


	Do 

		Console.WriteLine("Please type a MONTH number: ")
		month = Console.ReadLine()
		Console.WriteLine("Please type the year: ")
		year = Console.ReadLine()

	
		If ((year MOD 100) = 0) Then

			If ((year MOD 400) = 0) Then 'comment: rest of division 400 equals 0 means the year is leap.'

				Select Case month

					Case 1, 3, 5, 7, 8, 10, 12
						NoOfDays = 31
					Case 4, 6, 9, 11
						NoOfDays = 30
					Case 2
						NoOfDays = 29
					Case Else
						Console.WriteLine("Not a month.")
				End Select
				'Leap year'
			Else 

				Select Case month

					Case 1, 3, 5, 7, 8, 10, 12
						NoOfDays = 31
					Case 4, 6, 9, 11
						NoOfDays = 30
					Case 2
						NoOfDays = 28
					Case Else
						Console.WriteLine("Not a month.")
				End Select

			End If


			Else

				If ((year MOD 4) = 0) Then

					Select Case month

						Case 1, 3, 5, 7, 8, 10, 12
							NoOfDays = 31
						Case 4, 6, 9, 11
							NoOfDays = 30
						Case 2
							NoOfDays = 29
						Case Else
							Console.WriteLine("Not a month.")
					End Select
					' Leap Year'
				Else 

					Select Case month

						Case 1, 3, 5, 7, 8, 10, 12
							NoOfDays = 31
						Case 4, 6, 9, 11
							NoOfDays = 30
						Case 2
							NoOfDays = 28
						Case Else
							Console.WriteLine("Not a month.")
					End Select

				End If


		End If

		Console.WriteLine("This month has " & NoOfDays & " days. ")

	Console.WriteLine("Do you want to continue [y/n]")
	repeat = Console.ReadLine.ToLower

	Loop until repeat = "n"

	Console.WriteLine("Press any key to exit")
	Console.ReadKey()

	End Sub
End Module
