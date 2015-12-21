Public Class EmployeeImpl

    Implements IEmployee

    Private Shared Shadows MAX_ID As String = "SELECT MAX(ID) FROM tblEmployee"
    Private Shared Shadows UPDATE_EMPLOYEE As String = "UPDATE tblEmployee SET "
    Private Shared Shadows DELETE_EMPLOYEE As String = "DELETE FROM tblEmployee WHERE EmployeeID='"
    Private Shared Shadows SEARCH_EMPLOYEE As String = "SELECT * FROM tblEmployee WHERE EmployeeID='"
    Private Shared Shadows INSERT_EMPLOYEE As String = "INSERT INTO tblEmployee (EmployeeID,LastName,FirstName,LatinName,Gender,Age,Nationality,DOB,PersonalStatus,Phone,PeopleCard,Photo) VALUES "
    Private Shared Shadows SHOW_EMPLOYEE As String = "SELECT * FROM tblEmployee"
    Private Shared Shadows INSTERT_ADDRESS As String = "INSERT INTO tblAddress (EmployeeID,Home,Street,City,District,Commune,Village) VALUES "
    Private Shared Shadows UPDATE_ADDRESS As String = "UPDATE tblAddress SET "
    Private Shared Shadows DELETE_ADDRESS As String = "DELETE FROM tblAddress WHERE EmployeeID='"
    Private Shared Shadows INSTERT_PLACEOFBIRTH As String = "INSERT INTO tblPlaceOfBirth (EmployeeID,Home,Street,City,District,Commune,Village) VALUES "
    Private Shared Shadows UPDATE_PLACEOFBIRTH As String = "UPDATE tblPlaceOfBirth SET "
    Private Shared Shadows DELETE_PLACEOFBIRTH As String = "DELETE FROM tblPlaceOfBirth WHERE EmployeeID='"

    Public Sub Delete(id As String) Implements IEmployee.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = DELETE_EMPLOYEE & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Employee was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Insert(employee As Employee) Implements IEmployee.Insert
        Try
            With employee
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = Connection()
                cmd.CommandText = INSERT_EMPLOYEE & "('" & .EmployeeId & "',N'" & .LastName & "',N'" & .FirstName & "','" & .FullName & "',N'" & .Gender & "','" & .Age & "',N'" & .Nationality & "','" & .DOB & "',N'" & .PersonalStatus & "','" & .Phone & "','" & .IDCard & "','" & .Photo & "')"
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End With
            SetProcessStatus("Employee was inserted!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Show(dataGridView As DataGridView) Implements IEmployee.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            cmd.Connection = Connection()
            cmd.CommandText = SHOW_EMPLOYEE
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dataGridView.DataSource = dt
            SetProcessStatus("Employee is showing in datagrridview!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Update(id As String, employee As Employee) Implements IEmployee.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = UPDATE_EMPLOYEE & employee.ToString() & " WHERE EmployeeID='" & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Employee was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Search(id As String, dataGridView As DataGridView) Implements IEmployee.Search
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = SEARCH_EMPLOYEE & id & "'"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dataGridView.DataSource = dt
            SetProcessStatus("Searching data of employee!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Function GetID() As Long Implements IEmployee.GetID
        Dim myLong As Long = 0
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = MAX_ID
            Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
            If dr.Read Then
                If IsDBNull(dr(0)) Then
                    myLong = 1
                Else
                    myLong = CLng(dr(0)) + 1
                End If
            End If
            cmd.Dispose()
            SetProcessStatus("EmployeeID was set !")
        Catch ex As Exception
            SetProcessStatus("Employee id was set auto value !")
        End Try
        Return myLong
    End Function

    Public Function SetAutoID(val As Long) As String Implements IEmployee.SetAutoID
        Return Format(val, "EMP-0000")
    End Function

    Public Sub Delete(empID As String, table As String) Implements IEmployee.Delete
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "DELETE * FROM " & table & " WHERE EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Employee was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Insert(address As EmployeeAddress) Implements IEmployee.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = INSTERT_ADDRESS & "('" & address.EmployeeID & "',N'" & address.Home & "',N'" & address.Street & "',N'" & address.City & "',N'" & address.District & "',N'" & address.Commune & "',N'" & address.Village & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Employee address was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Insert(pob As PlaceOfBirth) Implements IEmployee.Insert
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = INSTERT_PLACEOFBIRTH & "('" & pob.EmployeeID & "',N'" & pob.Home & "',N'" & pob.Street & "',N'" & pob.City & "',N'" & pob.District & "',N'" & pob.Commune & "',N'" & pob.Village & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Employee place of birth was inserted !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Show(dataGridView As DataGridView, sql As String) Implements IEmployee.Show
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = sql
            Dim dr As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            dr.Fill(dt)
            dataGridView.DataSource = dt
            cmd.Dispose()
            SetProcessStatus("data are showing !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Update(empID As String, address As EmployeeAddress) Implements IEmployee.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = UPDATE_ADDRESS & address.ToString() & " WHERE EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Employee address was updated !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub Update(empID As String, pob As PlaceOfBirth) Implements IEmployee.Update
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = UPDATE_PLACEOFBIRTH & pob.ToString() & " WHERE EmployeeID='" & empID & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("Employee place of birth was updated !")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
            ''Connection.Close()
        End Try
    End Sub

    Public Sub New()

    End Sub
End Class
