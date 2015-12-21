Public Class BonusImpl
    Sub Insert(bonus As Bonus)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblBonus (EmployeeID,BonusDateFrom,BonusDateTo,BonusType,BonusTime,BonusCost,BonusAmount) values ('" & bonus.Employee & "','" & bonus.BonusDateFrom & "','" & bonus.BonusDateTo & "','" & bonus.BonusType & "','" & bonus.BonusTime & "','" & bonus.BonusCost & "','" & bonus.BonusAmount & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("bonus was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Show(dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblBonus"
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
            cmd.CommandText = "select * from tblBonus where EmployeeID='" & department & "'%"
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
            cmd.CommandText = "delete tblBonus where ID='" & department & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("bonus was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Update(id As String, bonus As Bonus)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "update tblBonus set " & bonus.ToString & " where ID='" & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("bonus was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
End Class
