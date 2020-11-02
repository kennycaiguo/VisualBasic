Imports System

Module module1

		Structure Employee
			Dim name As String 
			Dim number As Integer
			Dim hoursWorked As Integer
			Dim rateOfPay As Decimal
		End Structure

	Sub Main()

		Dim employer1 As Employee
		Dim grossPay As Decimal

	    
		Console.WriteLine("Type for me the Employee name: ")
		employer1.name = Console.ReadLine()

		Console.WriteLine("Employee number: ")
		employer1.number = Console.ReadLine()

		Console.WriteLine("Hours worked this week: ")
		employer1.hoursWorked = Console.ReadLine()

		Console.WriteLine("Hourly rate of pay: ")
		employer1.rateOfPay = Console.ReadLine()
		
		Console.WriteLine("--------------------")

		grossPay = (employer1.hoursWorked * employer1.rateOfPay)

		Console.WriteLine("Name of the Employee: {0}", employer1.name)
		Console.WriteLine("Employee Number: {0}", employer1.number)
		Console.WriteLine("Hours worked this week: {0}", employer1.hoursWorked)
		Console.WriteLine("Hourly rate of pay: {0}", grossPay)
		
	End Sub
End Module