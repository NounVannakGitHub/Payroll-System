Public Class ChildImpl
    Implements IChild

    Public Sub Delete(id As String) Implements IChild.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SQLValue.DELETE_CHILD & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Child was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Insert(child As Child) Implements IChild.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SQLValue.INSTERT_CHILD & "('" & child.EmployeeID & "','" & child.ChildId & "',N'" & child.ChildLastName & "',N'" & child.ChildFirstName & "',N'" & child.ChildGender & "','" & child.ChildAge & "',N'" & child.Address.Home & "',N'" & child.Address.Street & "',N'" & child.Address.City & "',N'" & child.Address.District & "',N'" & child.Address.Commune & "',N'" & child.Address.Village & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Child was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            MessageBox.Show(ex.StackTrace)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Update(child As Child, empID As String, id As String) Implements IChild.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SQLValue.UPDATE_CHILD & child.ToString & " WHERE EmployeeID='" & empID & "' AND ChildNo='" & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Child was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub AddToDataGridView(dataGridView As DataGridView, frmAddEmployee As frmAddEmployee) Implements IChild.AddToDataGridView
        Dim control() As Control = {frmAddEmployee.txtChildNo, frmAddEmployee.txtCLastName, frmAddEmployee.txtCFirstName, frmAddEmployee.cboCGender, frmAddEmployee.txtCAge, frmAddEmployee.txtCHome, frmAddEmployee.txtCStreet, frmAddEmployee.cboCCity, frmAddEmployee.cboCDistrict, frmAddEmployee.cboCCommune, frmAddEmployee.cboCVillage}
        Dim r As Integer
        Try
            dataGridView.ColumnCount = control.Length
            For r = 0 To r < control.Length Step 1
                dataGridView.Columns(r).Name = control(r).Name.Substring(3)
                If control(r).Text = Nothing Then
                    control(r).Text = "N/A"
                End If
            Next
            dataGridView.Rows.Add(New String() {control(0).Text, control(1).Text, control(2).Text, control(3).Text, control(4).Text, control(5).Text, control(6).Text, control(7).Text, control(8).Text, control(9).Text, control(10).Text})
            dataGridView.Refresh()
            If frmAddEmployee.txtChildQty.Text.Equals(frmAddEmployee.txtChildNo.Text) Then
                For r = 0 To r < control.Length Step 1
                    control(r).Enabled = False
                    frmAddEmployee.btnAddChild.Enabled = False
                Next
            End If
            SetProcessStatus("data was added to datagridview!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Search(id As String) Implements IChild.Search
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SQLValue.SEARCH_CHILD & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("searching child information!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Show(empID As String, dataGridView As DataGridView) Implements IChild.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SQLValue.SHOW_CHILD & empID & "'"
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dataGridView.DataSource = dt
            cmd.Dispose()
            SetProcessStatus("Showing data in datagridview!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Delete(empId As String, Id As String) Implements IChild.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SQLValue.DELETE_CHILD & empId & "' AND ChildNo='" & Id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Child was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub
End Class
