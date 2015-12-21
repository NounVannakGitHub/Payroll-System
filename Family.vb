Public Class Family
    Private _parent As Parent
    Private _spouses As Spouses
    Private _employeeID As String
    Public Property EmployeeID As String
        Get
            Return _employeeID
        End Get
        Set(value As String)
            _employeeID = value
        End Set
    End Property
    Public Property Parent As Parent
        Get
            Return _parent
        End Get
        Set(value As Parent)
            _parent = value
        End Set
    End Property
    Public Property Spouses As Spouses
        Get
            Return _spouses
        End Get
        Set(value As Spouses)
            _spouses = value
        End Set
    End Property
End Class
