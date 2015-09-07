Public Class Position
    Private _positionId As String
    Private _positionName As String
    Private _positionType As String
    Private _salary As Double
    Public Property PositionId As String
        Get
            Return _positionId
        End Get
        Set(value As String)
            _positionId = value
        End Set
    End Property
    Public Property PositionName As String
        Get
            Return _positionName
        End Get
        Set(value As String)
            _positionName = value
        End Set
    End Property
    Public Property PositionType As String
        Get
            Return _positionType
        End Get
        Set(value As String)
            _positionType = value
        End Set
    End Property
    Public Property Salary As Double
        Get
            Return _salary
        End Get
        Set(value As Double)
            _salary = value
        End Set
    End Property
End Class
