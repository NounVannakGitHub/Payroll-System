Public Class Attendance
    Private _timeIn As String
    Private _timeOut As String
    Private _date As String
    Private _totalWork As Double
    Private _totalLate As Double
    Private _employee As New Employee
    Public Property TimeIn As String
        Get
            Return _timeIn
        End Get
        Set(value As String)
            _timeIn = value
        End Set
    End Property
    Public Property TimeOut As String
        Get
            Return _timeOut
        End Get
        Set(value As String)
            _timeOut = value
        End Set
    End Property
    Public Property TotalWork As Double
        Get
            Return _totalWork
        End Get
        Set(value As Double)
            _totalWork = value
        End Set
    End Property
    Public Property TotalLate As Double
        Get
            Return _totalLate
        End Get
        Set(value As Double)
            _totalLate = value
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
