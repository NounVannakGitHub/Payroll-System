Public Class LeaveImpl
    Sub Insert(empID As String, name As String, annual As String, sick As String, special As String, maternity As String, day As String, remark As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblLeave (EmployeeID,Name,AnnualLeave,SickLeave,SpecialLeave,MaternityLeave,Day,Remark) values ('" & empID & "','" & name & "','" & annual & "','" & sick & "','" & special & "','" & maternity & "','" & day & "','" & remark & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("leave was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Show(dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblLeave"
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
            cmd.CommandText = "select * from tblLeave where EmployeeID='" & department & "'%"
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
            cmd.CommandText = "delete tblLeave where EmployeeID='" & department & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("leave was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Update(empID As String, name As String, annual As String, sick As String, special As String, maternity As String, day As String, remark As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "update tblLeave set Name='" & name & "',AnnualLeave='" & annual & "',SickLeave='" & sick & "',SpecialLeave='" & special & "',MaternityLeave='" & maternity & "',Day='" & day & "',Remark='" & remark & "' where EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("leave was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
End Class
