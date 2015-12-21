Public Class WorkInformation
    Private _employeeID As String
    Private _hireDate As String
    Private _contractDate As String
    Private _endContractDate As String
    Private _department As String
    Private _contractType As String
    Private _period As String
    Private _position As String
    Private _salary As String

    Sub New(employeeID As String, hireDate As String, contractDate As String, endContractDate As String, department As String, contractType As String, period As String, position As String, salary As String)
        _employeeID = employeeID
        _hireDate = hireDate
        _contractDate = contractDate
        _endContractDate = endContractDate
        _department = department
        _contractType = contractType
        _period = period
        _position = position
        _salary = salary
    End Sub

    Public Overrides Function ToString() As String
        Return "HireDate='" & _hireDate & "',ContractDate='" & _contractDate & "',EndContractDate='" & _endContractDate & "',Department='" & _department & "',ContractType='" & _contractType & "',Period='" & _period & "',Position='" & _position & "',Salary='" & _salary & "'"
    End Function

    Public Property EmployeeID As String
        Get
            Return _employeeID
        End Get
        Set(value As String)
            _employeeID = value
        End Set
    End Property
    Public Property HireDate As String
        Get
            Return _hireDate
        End Get
        Set(value As String)
            _hireDate = value
        End Set
    End Property
    Public Property ContractDate As String
        Get
            Return _contractDate
        End Get
        Set(value As String)
            _contractDate = value
        End Set
    End Property
    Public Property EndContractDate As String
        Get
            Return _endContractDate
        End Get
        Set(value As String)
            _endContractDate = value
        End Set
    End Property
    Public Property Department As String
        Get
            Return _department
        End Get
        Set(value As String)
            _department = value
        End Set
    End Property
    Public Property ContractType As String
        Get
            Return _contractType
        End Get
        Set(value As String)
            _contractType = value
        End Set
    End Property
    Public Property Period As String
        Get
            Return _period
        End Get
        Set(value As String)
            _period = value
        End Set
    End Property
    Public Property Position As String
        Get
            Return _position
        End Get
        Set(value As String)
            _position = value
        End Set
    End Property
    Public Property Salary As String
        Get
            Return _salary
        End Get
        Set(value As String)
            _salary = value
        End Set
    End Property
End Class
