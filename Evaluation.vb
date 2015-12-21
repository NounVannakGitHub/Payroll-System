Public Class Evaluation
    Sub Show(dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblEvaluationStaff"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Search(empID As String, dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblEvaluationStaff where EmployeeID='" & empID & "'"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Delete(empID As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "delete tblEvaluationStaff where EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Insert(empID As String, lname As String, fname As String, pos As String, type As String, hire As String, expire As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblEvaluationStaff (EmployeeID,LastName,FirstName,Position,StaffType,HiredDate,ExpireDate) values ('" & empID & "',N'" & lname & "',N'" & fname & "','" & pos & "','" & type & "','" & hire & "','" & expire & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Insert(empID As String, lname As String, fname As String, pos As String, type As String, hire As String, expire As String, action As String, username As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblEvaluationStaff (EmployeeID,LastName,FirstName,Position,StaffType,HiredDate,ExpireDate,Action,UserName) values ('" & empID & "',N'" & lname & "',N'" & fname & "','" & pos & "','" & type & "','" & hire & "','" & expire & "','" & action & "','" & username & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub


    Sub Update(empID As String, type As String, hired As String, expire As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "update tblEvaluationStaff set StaffType='" & type & "',HiredDate='" & hired & "',ExpireDate='" & expire & "' where EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
End Class
