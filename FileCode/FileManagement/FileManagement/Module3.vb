Module Module3
    '|=============================================================================|
    '| Module 3 Used to Define Functions        ONLY                               |
    '| Author: Abrar Hamid                                                         |
    '|=============================================================================|
    Function totalcredits(ByVal x As Integer) As Integer
        Dim result As Integer

        For i = 0 To 17
            If access2computing(x).grades(i).grade = "P" Or access2computing(x).grades(i).grade = "M" Or access2computing(x).grades(i).grade = "D" Then
                result += access2computing(x).grades(i).credit
            End If
        Next
        Return result
    End Function

    Function CreditsatPass(ByVal x As Integer) As Integer
        ' Function that Computes total number of credits at Pass. 
        'needs a parameter to identify the index of the array i.e. for a praticular student
        Dim result As Integer


        For i = 0 To 17
            If access2computing(x).grades(i).grade = "P" Then
                result += access2computing(x).grades(i).credit
            End If
        Next
        Return result
    End Function
    Function CreditsatMerit(ByVal x As Integer) As Integer
        ' Function that Computes total number of credits at Merit. 
        'needs a parameter to identify the index of the array i.e. for a praticular student
        Dim result As Integer

        For i = 0 To 17
            If access2computing(x).grades(i).grade = "M" And access2computing(x).grades(i).graded = "Y" Then
                result += access2computing(x).grades(i).credit
            End If
        Next
        Return result
    End Function

    Function creditsatdistinction(ByVal x As Integer) As Integer

        Dim result As Integer = 0
        For i = 0 To 17
            If access2computing(x).grades(i).graded = "Y" Then
                If access2computing(x).grades(i).grade = "D" Then
                    result += access2computing(x).grades(i).credit
                End If
            End If
        Next
        Return result
    End Function

    Function numberofPMD(ByVal x As Integer, ByVal grade As Char) As Integer
        ' Function that Computes total number of Passess,Meritrs or Distinctions  at Pass. 
        'needs 2  parameters to identify the index of the array and the Grade for a particular Unit
        Dim result As Integer
        For i = 0 To 17

            If access2computing(x).grades(i).grade = grade Then
                result += 1
            End If
        Next

        Return result
    End Function
End Module
