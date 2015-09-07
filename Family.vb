Public Class Family
    Private _parent As New Parent
    Private _spouses As New Spouses
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
