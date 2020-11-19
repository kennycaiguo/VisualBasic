Module Module3
    Function CalcPlanCost(ByVal PT As String) As Decimal
        Dim cost As Decimal

        If PT = "3G" Or PT = "3g" Then
            cost = 10
        ElseIf PT = "4g" Or PT = "4G" Then
            cost = 20

        ElseIf PT = "5g" Or PT = "5G" Then
            cost = 30

        End If

        Return cost

        'min cost, data cost and text'

    End Function
End Module
