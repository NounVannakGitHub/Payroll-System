Public Class Parent
    Private _mother As Mother
    Private _father As Father

    Sub New(mother As Mother, father As Father)
        _mother = mother
        _father = father
    End Sub

    Public Property Mother As Mother
        Get
            Return _mother
        End Get
        Set(value As Mother)
            _mother = value
        End Set
    End Property

    Public Property Father As Father
        Get
            Return _father
        End Get
        Set(value As Father)
            _father = value
        End Set
    End Property
End Class
