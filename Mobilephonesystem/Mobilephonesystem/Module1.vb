Module Module1


    Structure Customer
        Dim customerid As Integer
        Dim customerFirstName As String
        Dim Surname As String
        Dim address As String
        Dim town As String
        Dim postcode As String
        Dim phonenumber As String
        Dim DoB As Date

        Structure planusage
            Dim plantype As String
            Dim minutes As UShort
            Dim text As UShort
            Dim data As UShort
            Dim month As Byte

        End Structure

        Dim statements() As planusage
    End Structure


    Public ruimobile(9) As Customer

    Sub Main()

        Dim customer1 As Customer
        customer1.customerid = 5
        customer1.customerFirstName = "Rui"



        ReDim Preserve ruimobile(0).statements(11)
        ReDim Preserve ruimobile(1).statements(11)

        ruimobile(0).customerid = 5
        ruimobile(0).statements(0).plantype = "3G"
        ruimobile(0).statements(0).minutes = 199
        ruimobile(0).statements(0).text = 550
        ruimobile(0).statements(0).data = 509

        If ruimobile(0).statements(0).plantype = "3G" Then
            Console.WriteLine("£10")
        ElseIf ruimobile(0).statements(0).plantype = "4G" Then
            Console.WriteLine("£20")
        ElseIf ruimobile(0).statements(0).plantype = "5G" Then
            Console.WriteLine("£30")
        End If


        Console.ReadKey()

    End Sub

End Module
