Public Class AttEmp
    Sub Show(dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblAttendance"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Search(id As String, dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblAttendance where EmployeeID='" & id & "'"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub WriteIn(id As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblAttendance (EmployeeID,TimeIn,Date,Late) Values ('" & id & "','" & GetTime() & "','" & GetDate() & "','" & GetLate(GetTime) & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub WriteOut(id As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "update tblAttendance set TimeOut='" & GetTime() & "' where EmployeeID='" & id & "' And Date='" & GetDate() & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Delete(id As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "delete tblAttendance where ID='" & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

End Class
