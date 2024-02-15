Public Class coinslot
    Public Event dispenseevent(p As Image)
    Public Event coinreturnevent(d As Integer, q As Integer, dm As Integer, n As Integer)
    Public Property quarters As Integer
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = dollars * 1 + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
            Return _total
        End Get
    End Property
    Public Sub coinreturn()
        RaiseEvent coinreturnevent(dollars, quarters, dimes, nickels)
        dollars = 0
        quarters = 0
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
    Public Sub buy(p As productControl)
        If p.count > 0 And total >= p.price Then
            p.buy()
            _total = _total - p.price
            dollars = 0
            quarters = 0
            dimes = 0
            nickels = _total / 0.05
            RaiseEvent dispenseevent(p.picture)
        End If
    End Sub
End Class
