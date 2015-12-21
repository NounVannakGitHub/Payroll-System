Public Class Education
    Private _employeeID As String
    Private _eductionNo As String
    Private _eductionLevel As String
    Private _educationQty As String
    Private _name As String
    Private _major As String
    Private _startYear As String
    Private _endYear As String
    Private _gpa As String
    Private _grade As String

    Sub New()
    End Sub
    Sub New(employeeID As String, educationQty As String, educationLevel As String, educationNo As String, name As String, major As String, start As String, endYear As String, gpa As String, grade As String)
        _employeeID = employeeID
        _eductionNo = educationNo
        _educationQty = educationQty
        _eductionLevel = educationLevel
        _name = name
        _major = major
        _startYear = start
        _endYear = endYear
        _gpa = gpa
        _grade = grade
    End Sub

    Public Overrides Function ToString() As String
        Return "EducationQty='" & _educationQty & "',EducationLevel=N'" & _eductionLevel & "',EducationNo='" & _eductionNo & "',Name=N'" & _name & "',Major='" & _major & "',StartYear='" & _startYear & "',EndYear='" & _endYear & "',GPA='" & _gpa & "',Grade='" & _grade & "'"
    End Function
    Public Property EducationQty As String
        Get
            Return _educationQty
        End Get
        Set(value As String)
            _educationQty = value
        End Set
    End Property

    Public Property Grade As String
        Get
            Return _grade
        End Get
        Set(value As String)
            _grade = value
        End Set
    End Property

    Public Property GPA As String
        Get
            Return _gpa
        End Get
        Set(value As String)
            _gpa = value
        End Set
    End Property

    Public Property StartYear As String
        Get
            Return _startYear
        End Get
        Set(value As String)
            _startYear = value
        End Set
    End Property
    Public Property EndYear As String
        Get
            Return _endYear
        End Get
        Set(value As String)
            _endYear = value
        End Set
    End Property

    Public Property Major As String
        Get
            Return _major
        End Get
        Set(value As String)
            _major = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property EductionLevel As String
        Get
            Return _eductionLevel
        End Get
        Set(value As String)
            _eductionLevel = value
        End Set
    End Property

    Public Property EductionNo As String
        Get
            Return _eductionNo
        End Get
        Set(value As String)
            _eductionNo = value
        End Set
    End Property

    Public Property EmployeeID As String
        Get
            Return _employeeID
        End Get
        Set(value As String)
            _employeeID = value
        End Set
    End Property
End Class
