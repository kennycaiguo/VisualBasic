
Imports System

Module module1

		Structure Employee
			Dim name As String 
			Dim number As Integer
			Dim hoursWorked As Integer
			Dim rateOfPay As Decimal
		End Structure

		Dim employer(0 To 2) As Employee

	Sub Main()
		Dim index, counter As Integer
		Dim grossPay As Decimal
		Dim SelectedEmployee As Integer

		index = 0
	
		For index = 0 To 2
			Console.WriteLine("Type for me the Employee name: ")
			employer(index).name = Console.ReadLine()

			Console.WriteLine("Employee number: ")
			employer(index).number = Console.ReadLine()

			Console.WriteLine("Hours worked this week: ")
			employer(index).hoursWorked = Console.ReadLine()

			Console.WriteLine("Hourly rate of pay: ")
			employer(index).rateOfPay = Console.ReadLine()
		Next

		Console.WriteLine("--------------------")

		Console.WriteLine("Type for me the specific employer number: ")
		SelectedEmployee = Console.ReadLine()

		For index = 0 To 2
			If employer(index).number = SelectedEmployee Then
				grossPay = (employer(index).hoursWorked * employer(index).rateOfPay)
				Console.WriteLine()
				Console.WriteLine("Name of the Employee: {0}", employer(index).name)
				Console.WriteLine("Employee Number: {0}", employer(index).number)
				Console.WriteLine("Hours worked this week: {0}", employer(index).hoursWorked)
				Console.WriteLine("Hourly rate of pay: {0}", grossPay)
			End If
			If employer(index).number <> SelectedEmployee Then
				Console.WriteLine("Employee could not be found")
			End If
			
		
		Next
			
	End Sub
End Module