Public Class Tax
    Private _taxNo As String
    Private _taxTo As Double
    Private _taxFrom As Double
    Private _percent As Double
    Private _taxException As Double
    Private _dependent As String
    Private _dependentNo As String
    Private _taxType As String
    Private _employee As New Employee
    Public Property TaxNo As String
        Get
            Return _taxNo
        End Get
        Set(value As String)
            _taxNo = value
        End Set
    End Property
    Public Property TaxTo As Double
        Get
            Return _taxTo
        End Get
        Set(value As Double)
            _taxTo = value
        End Set
    End Property
    Public Property TaxFrom As Double
        Get
            Return _taxFrom
        End Get
        Set(value As Double)
            _taxFrom = value
        End Set
    End Property
    Public Property Percent As Double
        Get
            Return _percent
        End Get
        Set(value As Double)
            _percent = value
        End Set
    End Property
    Public Property TaxException As Double
        Get
            Return _taxException
        End Get
        Set(value As Double)
            _taxException = value
        End Set
    End Property
    Public Property Dependent As String
        Get
            Return _dependent
        End Get
        Set(value As String)
            _dependent = value
        End Set
    End Property
    Public Property DependentNo As String
        Get
            Return _dependentNo
        End Get
        Set(value As String)
            _dependentNo = value
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
    Public Property TaxType As String
        Get
            Return _taxType
        End Get
        Set(value As String)
            _taxType = value
        End Set
    End Property
End Class
