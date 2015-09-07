Public Class Education
    Private _primarySchool As New PrimarySchool
    Private _secondarySchool As New SecondarySchool
    Private _highSchool As New HighSchool
    Private _university As New University

    Public Property PrimarySchool As PrimarySchool
        Get
            Return _primarySchool
        End Get
        Set(value As PrimarySchool)
            _primarySchool = value
        End Set
    End Property
    Public Property SecondarySchool As SecondarySchool
        Get
            Return _secondarySchool
        End Get
        Set(value As SecondarySchool)
            _secondarySchool = value
        End Set
    End Property
    Public Property University As University
        Get
            Return _university
        End Get
        Set(value As University)
            _university = value
        End Set
    End Property
    Public Property HighSchool As HighSchool
        Get
            Return _highSchool
        End Get
        Set(value As HighSchool)
            _highSchool = value
        End Set
    End Property
End Class
