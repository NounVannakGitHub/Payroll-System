Public Class ParentImpl
    Implements IParent
    Private Shared Shadows INSERT_DAD As String = "INSERT INTO tblFather (EmployeeID,LastName,FirstName,Age,LifeStatus,Job,Phone,Home,Street,City,District,Commune,Village) VALUES "
    Private Shared Shadows INSERT_MOM As String = "INSERT INTO tblMother (EmployeeID,LastName,FirstName,Age,LifeStatus,Job,Phone,Home,Street,City,District,Commune,Village) VALUES "
    Public Sub Delete(empID As String, table As String) Implements IParent.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "DELETE FROM " & table & " WHERE EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Parent was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Insert(dad As Father) Implements IParent.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = INSERT_DAD & "('" & dad.EmployeeID & "',N'" & dad.LastName & "',N'" & dad.FirstName & "','" & dad.Age & "',N'" & dad.LifeStatus & "','" & dad.Job & "','" & dad.Phone & "',N'" & dad.Home & "',N'" & dad.Street & "',N'" & dad.City & "',N'" & dad.District & "',N'" & dad.Commune & "',N'" & dad.Village & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Father information was inserted to database!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            MessageBox.Show(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Insert(mom As Mother) Implements IParent.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = INSERT_MOM & "('" & mom.EmployeeID & "',N'" & mom.LastName & "',N'" & mom.FirstName & "','" & mom.Age & "',N'" & mom.LifeStatus & "','" & mom.Job & "','" & mom.Phone & "',N'" & mom.Home & "',N'" & mom.Street & "',N'" & mom.City & "',N'" & mom.District & "',N'" & mom.Commune & "',N'" & mom.Village & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Mother information was inserted to database!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            MessageBox.Show(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Show(empID As String, table As String, dataGridView As DataGridView) Implements IParent.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT * FROM " & table & " WHERE EmployeeID='" & empID & "'"
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dataGridView.DataSource = dt
            cmd.Dispose()
            SetProcessStatus("Show completed!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Update(empID As String, dad As Father) Implements IParent.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "UPDATE tblFather SET " & dad.ToString & " WHERE EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Father was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Update(empID As String, mom As Mother) Implements IParent.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "UPDATE tblMother SET " & mom.ToString & " WHERE EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Mother was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub
End Class
