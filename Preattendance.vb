Public Class Preattendance
    Private _pAttendanceNo As String
    Private _pAttendanceDateFrom As String
    Private _pAttendanceDateTo As String
    Private _pAttendanceReason As String
    Private _pAttendanceType As String
    Private _pAttendanceTotal As Integer
    Private _employee As Employee
    Sub New()
    End Sub
    Sub New(ByVal preAttNo As String, ByVal preAttDateFrom As String, ByVal preAttDateTo As String, ByVal preAttReason As String, ByVal preAttType As String, ByVal preAttTotal As Integer)
        _pAttendanceNo = preAttNo
        _pAttendanceDateFrom = preAttDateFrom
        _pAttendanceDateTo = preAttDateTo
        _pAttendanceReason = preAttReason
        _pAttendanceTotal = preAttTotal
        _pAttendanceType = preAttType
    End Sub
    Public Property PreAttendanceNo As String
        Get
            Return _pAttendanceNo
        End Get
        Set(value As String)
            _pAttendanceNo = value
        End Set
    End Property
    Public Property PreAttendanceDateFrom As String
        Get
            Return _pAttendanceDateFrom
        End Get
        Set(value As String)
            _pAttendanceDateFrom = value
        End Set
    End Property
    Public Property PreAttendanceDateTo As String
        Get
            Return _pAttendanceDateTo
        End Get
        Set(value As String)
            _pAttendanceDateTo = value
        End Set
    End Property
    Public Property PreAttendanceTotal As Integer
        Get
            Return _pAttendanceTotal
        End Get
        Set(value As Integer)
            _pAttendanceTotal = value
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
    Public Property AttendanceReason As String
        Get
            Return _pAttendanceReason
        End Get
        Set(value As String)
            _pAttendanceReason = value
        End Set
    End Property

    Public Property AttendanceType As String
        Get
            Return _pAttendanceType
        End Get
        Set(value As String)
            _pAttendanceType = value
        End Set
    End Property
End Class
