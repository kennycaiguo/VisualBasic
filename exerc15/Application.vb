Imports System.Math
Imports System.Strings
Imports System

Public Module module1
	Public Sub Main()

	Dim hoursWorked, rateOfPay, grossPay, extraHourSalary As Decimal

	Console.WriteLine("Exercise 15")
	Console.WriteLine()

	Console.WriteLine("Please type your hourly rate of pay: ")
	rateOfPay = Console.ReadLine()

	Console.WriteLine("Please type your hours worked this week: ")
	hoursWorked = Console.ReadLine()

	
	if (hoursWorked >= 0 and hoursWorked <= 60) Then 

		if(hoursWorked > 40) Then

			extraHourSalary = ((hoursWorked - 40) * (1.5 * rateOfPay))
			grossPay = ((hoursWorked * rateOfPay) + extraHourSalary)

			Console.WriteLine("Salary for this week: " & grossPay)

		Else

			grossPay = (hoursWorked * rateOfPay)
			Console.WriteLine("Salary for this week: " & grossPay)

		end If 
		

	Else 
		Console.WriteLine("Incorret input. Should be between 0 - 60")

	End If

		Console.ReadKey()

	End Sub
End Module
