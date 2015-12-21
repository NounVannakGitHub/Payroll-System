Public Class EducationImpl
    Implements IEducation
    Private Shared Shadows INSERT_EDUCATION As String = "INSERT INTO tblEducation (EmployeeID,EducationQty,EducationLevel,EducationNo,Name,Major,StartYear,EndYear,GPA,Grade) VALUES "
    Public Sub Delete(empID As String, eduNo As String) Implements IEducation.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "DELETE FROM tblEducation WHERE EmployeeID='" & empID & "' AND EducationNo='" & eduNo & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Education was deleted !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Insert(education As Education) Implements IEducation.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = INSERT_EDUCATION & "('" & education.EmployeeID & "','" & education.EducationQty & "',N'" & education.EductionLevel & "','" & education.EductionNo & "',N'" & education.Name & "','" & education.Major & "','" & education.StartYear & "','" & education.EndYear & "','" & education.GPA & "','" & education.Grade & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Education was inserted !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Show(empID As String, dataGridView As DataGridView) Implements IEducation.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT * FROM tblEducation WHERE EmployeeID='" & empID & "'"
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dataGridView.DataSource = dt
            cmd.Dispose()
            SetProcessStatus("Education are showing data !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Update(empID As String, eduNo As String, education As Education) Implements IEducation.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "UPDATE tblEducation SET '" & education.ToString & "' WHERE EmployeeID='" & empID & "' AND EducationNo='" & eduNo & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Education was updated !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Delete(empID As String) Implements IEducation.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "DELETE FROM tblEducation WHERE EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Education was deleted !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub
End Class
