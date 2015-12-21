Public Class SalaryImpl
    Implements ISalary


    Private Shared Shadows INSERT_DATA As String = "INSERT INTO tblSalary(EmployeeID,LastName,FirstName,BasicSalary,TaxSpouse,TaxChild,BasicSalaryTwo,AnnualAward,Adjust,Incre,Decre,Thirdteen,Fourteen,NetBase,Incentive,Reginal,Transport,OverTime,SalaryBeforeTax,Tax,SubTotal,DateFrom,DateTo) VALUES "
    Public Sub Delete(id As String) Implements ISalary.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "DELETE tblSalary WHERE ID='" & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Salary was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Insert(salary As Salary) Implements ISalary.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = INSERT_DATA & "('" & salary.EmployeeID & "',N'" & salary.LastName & "',N'" & salary.FirstName & "','" & salary.BasicSalary1 & "','" & salary.TaxSpouse & "','" & salary.TaxChild & "','" & salary.BasicSalary2 & "','" & salary.AnnualAward & "','" & salary.Adjust & "','" & salary.Incre & "','" & salary.Decre & "','" & salary.ThirdteenSalary & "','" & salary.FourteenSalary & "','" & salary.NetBase & "','" & salary.Incentive & "','" & salary.Reginal & "','" & salary.Transport & "','" & salary.OverTime & "','" & salary.SalaryBeforeTax & "','" & salary.Tax & "','" & salary.SubTotal & "','" & salary.DateFrom & "','" & salary.DateTo & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("salary was inserted !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Search(empId As String, dgv As DataGridView) Implements ISalary.Search
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT * FROM tblSalary WHERE EmployeeID='" & empId & "'"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Show(dgv As DataGridView) Implements ISalary.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT * FROM tblSalary"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Insert(table As String, salary As Salary) Implements ISalary.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "INSERT INTO " & table & " (EmployeeID,Salary,Date) VALUES ('" & salary.EmployeeID & "','" & salary.TaxSpouse & "','" & salary.DateTo & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Delete(id As String, table As String) Implements ISalary.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "Delete " & table & " where EmployeeID='" & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
End Class
