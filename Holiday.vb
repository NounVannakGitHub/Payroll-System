Public Class Holiday
    Private _holidayId As String
    Private _holidayDate As String
    Private _holidayReason As String
    Private _holidayStatus As String
    Private _holidayName As String

    Function DoCalculateDay(dtpFrom As DateTimePicker, dtpTo As DateTimePicker) As String
        Dim total As String = ""
        Dim dateFrom As New System.DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day)
        Dim dateTo As New System.DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day)
        Dim timeTotal As Long = (dateTo - dateFrom).TotalDays
        If timeTotal = 0 Then
            total = 1
        Else
            total = timeTotal
        End If
        Return total
    End Function

    Sub Insert(name As String, datefrom As String, dateto As String, total As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblHoliday (HolidayName,HolidayDateFrom,HolidayDateTo,HolidayTotal) values (N'" & name & "','" & datefrom & "','" & dateto & "','" & total & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("holiday was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Show(dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblHoliday"
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
            cmd.CommandText = "select * from tblHoliday where ID='" & department & "'%"
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
            cmd.CommandText = "delete tblHoliday where ID='" & department & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("holiday was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Update(id As String, name As String, datefrom As String, dateto As String, total As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "update tblHoliday set HolidayName=N'" & name & "',HolidayDateFrom='" & datefrom & "',HolidayDateTo='" & dateto & "',HolidayTotal='" & total & "' where ID='" & id & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("holiday was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Public Property HolidayId As String
        Get
            Return _holidayId
        End Get
        Set(value As String)
            _holidayId = value
        End Set
    End Property

    Public Property HolidayDate As String
        Get
            Return _holidayDate
        End Get
        Set(value As String)
            _holidayDate = value
        End Set
    End Property

    Public Property HolidayReason As String
        Get
            Return _holidayReason
        End Get
        Set(value As String)
            _holidayReason = value
        End Set
    End Property

    Public Property HolidayStatus As String
        Get
            Return _holidayStatus
        End Get
        Set(value As String)
            _holidayStatus = value
        End Set
    End Property

    Public Property HolidayName As String
        Get
            Return _holidayName
        End Get
        Set(value As String)
            _holidayName = value
        End Set
    End Property
    ''this is class holiday
End Class
