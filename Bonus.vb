Public Class Bonus
    Private _bonusDateTo As String
    Private _bonusDateFrom As String
    Private _bonusAmout As String
    Private _bonusType As String
    Private _bonusTime As String
    Private _bonusCost As String
    Private _employee As String
    Sub New(emp As String, froms As String, t As String, bt As String, time As String, cost As String, total As String)
        _employee = emp
        _bonusDateFrom = froms
        _bonusDateTo = t
        _bonusType = bt
        _bonusTime = time
        _bonusCost = cost
        _bonusAmout = total
    End Sub

    Public Overrides Function ToString() As String
        Return "EmployeeID='" & _employee & "',BonusDateFrom='" & _bonusDateFrom & "',BonusDateTo='" & _bonusDateTo & "',BonusType='" & _bonusType & "',BonusTime='" & _bonusTime & "',BonusCost='" & _bonusCost & "',BonusAmount='" & _bonusAmout & "'"
    End Function

    Public Property BonusType As String
        Get
            Return _bonusType
        End Get
        Set(value As String)
            _bonusType = value
        End Set
    End Property
    Public Property BonusCost As String
        Get
            Return _bonusCost
        End Get
        Set(value As String)
            _bonusCost = value
        End Set
    End Property
    Public Property BonusTime As String
        Get
            Return _bonusTime
        End Get
        Set(value As String)
            _bonusTime = value
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
    Public Property BonusAmount As String
        Get
            Return _bonusAmout
        End Get
        Set(value As String)
            _bonusAmout = value
        End Set
    End Property
    Public Property Employee As String
        Get
            Return _employee
        End Get
        Set(value As String)
            _employee = value
        End Set
    End Property
End Class
