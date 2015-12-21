Public Class WorkImpl

    Implements IWorkInfomation
    Private Shared Shadows INSERT_WORK As String = "INSERT INTO tblWorkInformation (EmployeeID,HireDate,ContractDate,EndContractDate,Department,ContractType,Period,Position,Salary) VALUES "
    Private Shared Shadows UPDATE_WORK As String = "UPDATE tblWorkInformation SET "
    Private Shared Shadows DELETE_WORK As String = "DELETE FROM tblWrokInformation WHERE EmployeeID='"
    Private Shared Shadows SHOW_WORK As String = "SELECT * FROM tblWorkInformation"
    Private Shared Shadows SHOW_WORK_EMPLOYEE As String = "SELECT * FROM tblWorkInformation WHERE EmployeeID='"

    Public Sub Delete(empID As String) Implements IWorkInfomation.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = DELETE_WORK & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Work information was deleted !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Insert(workinfo As WorkInformation) Implements IWorkInfomation.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = INSERT_WORK & "('" & workinfo.EmployeeID & "','" & workinfo.HireDate & "','" & workinfo.ContractDate & "','" & workinfo.EndContractDate & "','" & workinfo.Department & "','" & workinfo.ContractType & "','" & workinfo.Period & "','" & workinfo.Position & "','" & workinfo.Salary & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Work information was inserted !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Show(dataGridView As DataGridView) Implements IWorkInfomation.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SHOW_WORK
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dataGridView.DataSource = dt
            cmd.Dispose()
            SetProcessStatus("Work information are showing !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Update(empID As String, workInfo As WorkInformation) Implements IWorkInfomation.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = UPDATE_WORK & workInfo.ToString & " WHERE EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Work information was updated !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Show(empID As String, dataGridView As DataGridView) Implements IWorkInfomation.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SHOW_WORK_EMPLOYEE & empID & "'"
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dataGridView.DataSource = dt
            cmd.Dispose()
            SetProcessStatus("Work information are showing !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
End Class
