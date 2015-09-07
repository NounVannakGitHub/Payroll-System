Public Class ConnectionSingleton
    Private Shared s_objDBConnect As ConnectionSingleton
    Private Shared s_objConnection As OleDb.OleDbConnection

    Protected Sub New()

        s_objConnection = New OleDb.OleDbConnection
        s_objConnection.ConnectionString = My.Settings.MyConnectionString
        s_objConnection.Open()

    End Sub

    Public Shared Function GetInstance() As ConnectionSingleton

        If s_objDBConnect Is Nothing Then
            s_objDBConnect = New ConnectionSingleton
        End If

        Return s_objDBConnect

    End Function

    Public ReadOnly Property GetConnection() As OleDb.OleDbConnection
        Get
            Return s_objConnection
        End Get
    End Property
End Class
