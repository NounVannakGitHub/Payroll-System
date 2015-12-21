Public Class Department
    Sub Insert(department As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblDepartment (Department) values ('" & department & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("dapartment was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Show(dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblDepartment"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Search(department As String, dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblDepartment where Department='" & department & "'%"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Delete(department As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "delete tblDepartment where department='" & department & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("dapartment was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Update(id As String, department As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "update tblDepartment set Department='" & department & "' where ID='" & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("dapartment was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
End Class
