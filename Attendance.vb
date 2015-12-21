Public Class Attendance
    Private _timeIn As String
    Private _timeOut As String
    Private _date As String
    Private _totalWork As Double
    Private _totalLate As Double
    Private _employeeID As String
    Public Property TimeIn As String
        Get
            Return _timeIn
        End Get
        Set(value As String)
            _timeIn = value
        End Set
    End Property
    Public Property TimeOut As String
        Get
            Return _timeOut
        End Get
        Set(value As String)
            _timeOut = value
        End Set
    End Property
    Public Property TotalWork As Double
        Get
            Return _totalWork
        End Get
        Set(value As Double)
            _totalWork = value
        End Set
    End Property
    Public Property TotalLate As Double
        Get
            Return _totalLate
        End Get
        Set(value As Double)
            _totalLate = value
        End Set
    End Property

    Sub Insert(id As String, tin As String, tout As String, d As String, work As String, late As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblAttendance (EmployeeID,TimeIn,TimeOut,Date,TotalWork,TotalLate) values ('" & id & "','" & tin & "','" & tout & "','" & d & "','" & work & "','" & late & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("attendance was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Function Sum(table As String, field As String, id As String) As String
        Dim total As String = ""
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT SUM(" & field & ") FROM " & table & " where EmployeeID='" & id & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                total = dr(0)
            End If
            cmd.Dispose()
        Catch ex As Exception
            total = 0
        End Try
        Return total
    End Function

    Sub Update(id As String, out As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "update tblAttendance TimeOut='" & out & "' where EmployeeID='" & id & "' and Date='" & DateTime.Now.ToString("dd\MM\yyyy") & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("attendance was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Late(id As String, late As Integer, d As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblLate (EmployeeID,Late,Date) values ('" & id & "','" & late & "','" & d & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("attendance was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Work(id As String, late As Integer, d As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblWork (EmployeeID,WorkDay,Date) values ('" & id & "','" & late & "','" & d & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("attendance was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Show(dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblAttendance"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Show(sql As String, dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = sql
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
            cmd.CommandText = "select * from tblAttendance where EmployeeID='" & department & "'%"
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
            cmd.CommandText = "delete tblAttendance where ID='" & department & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("dapartment was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

End Class
