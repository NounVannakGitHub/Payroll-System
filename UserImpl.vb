Public Class UserImpl
    Implements IUser

    Public Sub Delete(userID As String) Implements IUser.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "DELETE tblUser WHERE UserId='" & userID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("User was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Insert(user As User) Implements IUser.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "INSERT INTO tblUser(UserId,EmployeeId,LastName,FirstName,Position,UserName,Password,ConfirmPassword,Photo) VALUES ('" & user.UserID & "','" & user.EmployeeID & "',N'" & user.LastName & "',N'" & user.FirstName & "',N'" & user.Position & "','" & user.UserName & "','" & DoEncode(MyByte(user.Password)) & "','" & DoEncode(MyByte(user.ConfirmPassword)) & "','" & user.Photo & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("User was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Search(empId As String, dgv As DataGridView) Implements IUser.Search
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT * FROM tblUser WHERE EmployeeId='" & empId & "'"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Show(dgv As DataGridView) Implements IUser.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT * FROM tblUser"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub ChangePassword(userID As String, password As String, conPassword As String) Implements IUser.ChangePassword
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "UPDATE tblUser SET Password='" & DoEncode(MyByte(password)) & "',ConfirmPassword='" & DoEncode(MyByte(conPassword)) & "' WHERE UserId='" & userID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Password was changed!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
End Class
