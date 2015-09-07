Public Class Holiday
    Private _holidayId As String
    Private _holidayDate As String
    Private _holidayReason As String
    Private _holidayStatus As String
    Private _holidayName As String

    Public Property HolidayId As String
        Get
            Return _holidayId
        End Get
        Set(value As String)
            _holidayId = value
        End Set
    End Property

    Public Property HolidayDate As String
        Get
            Return _holidayDate
        End Get
        Set(value As String)
            _holidayDate = value
        End Set
    End Property

    Public Property HolidayReason As String
        Get
            Return _holidayReason
        End Get
        Set(value As String)
            _holidayReason = value
        End Set
    End Property

    Public Property HolidayStatus As String
        Get
            Return _holidayStatus
        End Get
        Set(value As String)
            _holidayStatus = value
        End Set
    End Property

    Public Property HolidayName As String
        Get
            Return _holidayName
        End Get
        Set(value As String)
            _holidayName = value
        End Set
    End Property
    ''this is class holiday
End Class
