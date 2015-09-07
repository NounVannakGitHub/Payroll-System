Public Class University
    Private _bachelor As New Bachelor
    Private _master As New MasterDegree
    Private _phD As New PhD

    Public Property Bachelor As Bachelor
        Get
            Return _bachelor
        End Get
        Set(value As Bachelor)
            _bachelor = value
        End Set
    End Property
    Public Property MasterDegree As MasterDegree
        Get
            Return _master
        End Get
        Set(value As MasterDegree)
            _master = value
        End Set
    End Property
    Public Property PhD As PhD
        Get
            Return _phD
        End Get
        Set(value As PhD)
            _phD = value
        End Set
    End Property
End Class
