Public Class Leave
    Private _leaveNo As String
    Private _leaveDate As String
    Private _leaveReason As String
    Private _employee As New Employee
    Public Property LeaveNo As String
        Get
            Return _leaveNo
        End Get
        Set(value As String)
            _leaveNo = value
        End Set
    End Property
    Public Property LeaveDate As String
        Get
            Return _leaveDate
        End Get
        Set(value As String)
            _leaveDate = value
        End Set
    End Property
    Public Property LeaveReason As String
        Get
            Return _leaveReason
        End Get
        Set(value As String)
            _leaveReason = value
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
