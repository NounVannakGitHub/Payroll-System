Public Class Bonus
    Private _bonusNo As String
    Private _bonusDateTo As String
    Private _bonusDateFrom As String
    Private _bonusAmout As Double
    Private _bonusType As String
    Private _employee As New Employee
    Sub New()

    End Sub
    Sub New(ByVal No As String, ByVal DateTo As String, ByVal DateFrom As String, ByVal Amount As Double, ByVal Type As String)
        _bonusAmout = Amount
        _bonusDateFrom = DateFrom
        _bonusDateTo = DateTo
        _bonusNo = No
        _bonusType = Type
    End Sub
    Public Property BonusNo As String
        Get
            Return _bonusNo
        End Get
        Set(value As String)
            _bonusNo = value
        End Set
    End Property
    Public Property BonusDateTo As String
        Get
            Return _bonusDateTo
        End Get
        Set(value As String)
            _bonusDateTo = value
        End Set
    End Property
    Public Property BonusDateFrom As String
        Get
            Return _bonusDateFrom
        End Get
        Set(value As String)
            _bonusDateFrom = value
        End Set
    End Property
    Public Property BonusAmount As Double
        Get
            Return _bonusAmout
        End Get
        Set(value As Double)
            _bonusAmout = value
        End Set
    End Property
    Public Property Employee As Employee
        Get
            Return _employee
        End Get
        Set(value As Employee)
            _employee = value
        End Set
    End Property
End Class
