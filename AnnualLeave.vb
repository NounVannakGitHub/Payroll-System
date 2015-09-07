Public Class AnnualLeave
    Private _annualLeaveNo As String
    Private _annualLeaveValue As Integer
    Private _annualLeaveAvailable As Integer
    Private _employee As Employee
    Sub New()
    End Sub
    Sub New(ByVal LeaveNo As String, ByVal LeaveValue As Integer, ByVal LeaveAvailable As String)
        _annualLeaveAvailable = LeaveAvailable
        _annualLeaveNo = LeaveNo
        _annualLeaveValue = LeaveValue
    End Sub
    Public Property AnnualLeaveNo As String
        Get
            Return _annualLeaveNo
        End Get
        Set(value As String)
            _annualLeaveNo = value
        End Set
    End Property
    Public Property AnnualLeaveValue As Integer
        Get
            Return _annualLeaveValue
        End Get
        Set(value As Integer)
            _annualLeaveValue = value
        End Set
    End Property
    Public Property AnnualLeaveAvailable As Integer
        Get
            Return _annualLeaveAvailable
        End Get
        Set(value As Integer)
            _annualLeaveAvailable = value
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
