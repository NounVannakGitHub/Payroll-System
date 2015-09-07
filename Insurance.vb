Public Class Insurance
    Private _insuranceNo As String
    Private _insuranceType As String
    Private _insuranceAmount As Double
    Private _employee As New Employee
    Public Property InsuranceNo As String
        Get
            Return _insuranceNo
        End Get
        Set(value As String)
            _insuranceAmount = value
        End Set
    End Property
    Public Property InsuranceType As String
        Get
            Return _insuranceType
        End Get
        Set(value As String)
            _insuranceType = value
        End Set
    End Property
    Public Property InsuranceAmount As Double
        Get
            Return _insuranceAmount
        End Get
        Set(value As Double)
            _insuranceAmount = value
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
