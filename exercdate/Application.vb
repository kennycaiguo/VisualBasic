Imports System
Imports Microsoft.VisualBasic

Module module1 
	Sub Main()

		Dim myValue As Date = Now()
		Console.WriteLine(myValue.ToShortDateString())
		Console.WriteLine(myValue.ToShortTimeString())
		Console.WriteLine(myValue.ToLongDateString())
		Console.WriteLine(myValue.AddDays(3).ToShortDateString())
		Console.WriteLine(myValue.AddHours(3).ToShortTimeString())
		Console.WriteLine(myValue.AddDays(-3).ToShortDateString())
		Console.WriteLine(myValue.Month())
		Console.WriteLine(myValue.DayOfWeek())
		'Future'

		Dim myBirthDate As New Date(1969, 12, 7)
		Console.WriteLine(myBirthdate)

		Dim myBirthdate1 As New Date
		myBirthdate = Date.Parse("12/7/1969")

		Dim myBirthdate2 = #12/7/1969#

		Dim myBirthdate3 = New Date(1969, 12, 7)
		Dim myAge As TimeSpan = Date.Now.Subtract(myBirthdate3)


		'calculate the date of birth'

		Dim DoB As Date
		Dim today As Date
		DoB = #10/05/2000#
		today = Now 
		
		Dim dInYears As Integer
		dInYears = DateDiff(DateInterval.Year, DoB, today) 'subtract the date of birth in years'
		Console.WriteLine("Your age is: " & dInYears)
		Console.WriteLine("Today's date is "& FormatDateTime(today, DateFormat.LongDate)) 'format into long date'
		

		Console.WriteLine(myAge.ToString())
		
		


	End Sub
End Module