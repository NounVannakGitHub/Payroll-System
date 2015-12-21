Public Class SpouseImpl
    Implements ISpouse
    Private Shared Shadows INSERT_SPOUSE As String = "INSERT INTO tblSpouse (EmployeeID,LastName,FirstName,Gender,Age,Job,Child,ChildTotal,Phone,Home,Street,City,District,Commune,Village) VALUES "
    Private Shared Shadows DELETE_SPOUSE As String = "DELETE * FROM tblSpouse WHERE EmployeeID='"
    Private Shared Shadows UPDATE_SPOUSE As String = "UPDATE tblSpouse SET "
    Public Sub Delete(empID As String) Implements ISpouse.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = DELETE_SPOUSE & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Spouse was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Insert(spouse As Spouses) Implements ISpouse.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = INSERT_SPOUSE & "('" & spouse.EmployeeID & "',N'" & spouse.SpousesLastName & "',N'" & spouse.SpousesFirstName & "',N'" & spouse.SpousesGender & "','" & spouse.SpousesAge & "','" & spouse.SpousesOccupation & "',N'" & spouse.Child & "','" & spouse.SpousesTotal & "','" & spouse.Phone & "',N'" & spouse.Home & "',N'" & spouse.Street & "',N'" & spouse.City & "',N'" & spouse.District & "',N'" & spouse.Commune & "',N'" & spouse.Village & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Spouse was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Update(empID As String, spouse As Spouses) Implements ISpouse.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = UPDATE_SPOUSE & spouse.ToString & " WHERE EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Spouse was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub
End Class
