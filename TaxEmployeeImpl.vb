Public Class TaxEmployeeImpl
    Implements ITaxEmployee

    Public Sub Delete(taxID As String) Implements ITaxEmployee.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "delete from tblTaxEmployee where TaxId='" & taxID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Tax employee was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Insert(tax As TaxEmployee) Implements ITaxEmployee.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "INSERT INTO tblTaxEmployee (TaxId,EmployeeID,EmpLName,EmpFName,EmpGender,EmpStatus,Department,Position,EmpSalary,EmpTaxSalary,SpouseLName,SpouseFName,SpouseGender,SpouseJob,Child,ChildQty,SpouseTax,ChildTax,ChildTaxTotal) VALUES ('" & tax.TaxId & "','" & tax.EmployeeID & "',N'" & tax.EmployeeLastName & "',N'" & tax.EmployeeFirstName & "',N'" & tax.EmployeeGender & "',N'" & tax.EmployeeStatus & "',N'" & tax.Department & "',N'" & tax.Position & "','" & tax.Salary & "','" & tax.Persent & "',N'" & tax.SLastName & "',N'" & tax.SFirstName & "',N'" & tax.SGender & "',N'" & tax.SJob & "',N'" & tax.Child & "','" & tax.ChildQty & "','" & tax.TaxForSpouse & "','" & tax.TaxForChild & "','" & tax.TaxForChildTotal & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Tax employee was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Search(taxID As String, dgv As DataGridView) Implements ITaxEmployee.Search
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblTaxEmployee where TaxId='" & taxID & "'"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Sub Show(dgv As DataGridView) Implements ITaxEmployee.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblTaxEmployee"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Public Sub Update(taxID As String, tax As TaxEmployee) Implements ITaxEmployee.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "update tblTaxEmployee set " & tax.ToString & " where TaxId='" & taxID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Tax employee was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
End Class
