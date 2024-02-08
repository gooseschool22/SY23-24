Public Class coinslot
    Public Property quarters As Integer
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property dollars As Integer
    Public ReadOnly Property total As Decimal
        Get
            Return dollars + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
        End Get
    End Property
    Public Sub coinreturn()
        quarters = 0
        dollars = 0
        dimes = 0
        nickels = 0
    End Sub
    Public Sub insertquarter()
        quarters = quarters + 1
    End Sub
    Public Sub insertnickel()
        nickels = nickels + 1
    End Sub
    Public Sub insertdime()
        dimes = dimes + 1
    End Sub
    Public Sub insertdollar()
        dollars = dollars + 1
    End Sub
End Class
