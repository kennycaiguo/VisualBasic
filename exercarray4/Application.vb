
Imports System
Imports System.Date
Imports Microsoft.VisualBasic

Module module1
	Sub Main()

		Dim student(0 To 5), repeat As String
		Dim DoB(0 To 5) As Date
		Dim myValue As Date = Now()
		Dim index, i, counter As Integer

		
		
		Do 
			Console.Clear()

			For index = 0 To 5 Step 1
				Console.WriteLine("Please type the name of student " & index & ": ")
				student(index) = Console.ReadLine()

				Console.WriteLine("Please type the Date of Birth of student " & index & ": ")
				DoB(index) = Console.ReadLine()
			Next

			Console.WriteLine()
			
			Console.WriteLine("Tell me which student do you want to get details: ")
			index = Console.ReadLine()
			

			if(index > 5 or  index < 0) Then 
				Console.WriteLine("Student details could not be found.")
			Else 
				Dim age =  CalculateAge(DoB(index))
				Console.WriteLine("Student: " & student(index))
				Console.WriteLine("Date of Birth: " & DoB(index))
				Console.WriteLine(String.Format("The age is {0} ", age))
			End If 
			
		
			Console.WriteLine("Do you want to repeat the code? [y/n]")
			repeat = Console.ReadLine()
			Console.WriteLine("Press any other letter to exit.")

		Loop While repeat = "y" Or repeat = "Y"

		

	End Sub

		Public Function CalculateAge(DoB As DateTime) As Integer
            Dim todaysDate = DateTime.Today
            Dim ageCalculated = todaysDate.Year - DoB.Year
            If DoB > todaysDate.AddYears(- ageCalculated) Then
                ageCalculated = ageCalculated - 1
            End If
            Return ageCalculated
        End Function
End Module

		
