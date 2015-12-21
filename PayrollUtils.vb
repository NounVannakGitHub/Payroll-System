Imports System.IO
Imports System.Management
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Module PayrollUtils
    Private pGetValue As Object
    Public Property GetValue As Object
        Get
            Return pGetValue
        End Get
        Set(value As Object)
            pGetValue = value
        End Set
    End Property

    Sub SwitchLanguage(ByVal language As String)
        If language.Equals("kh") Then
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(1)
        ElseIf language.Equals("en") Then
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(0)
        Else
            MessageBox.Show("Your language don't have in this system.")
        End If
    End Sub
    Function GetSerialNumberHDD() As String
        Dim hdd_ser As String = ""
        Dim hdd As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
        For Each hd In hdd.Get
            hdd_ser = hd("SerialNumber")
        Next
        Return hdd_ser
    End Function

    Function DoEncode(ByVal myByte() As Byte) As String
        Return System.Convert.ToBase64String(myByte)
    End Function

    Function DoDecode(ByVal encodeStr As String) As Byte()
        Return System.Convert.FromBase64String(encodeStr)
    End Function

    Function MyByte(ByVal str As String) As Byte()
        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function

    Function MyString(ByVal mB() As Byte) As String
        Return System.Text.Encoding.Unicode.GetString(mB)
    End Function

    Function GetSerialNumberMainBoard() As String
        Dim mboard As String = ""
        Dim mbd As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
        For Each mb In mbd.Get
            mboard = mb("SerialNumber")
        Next
        Return mboard
    End Function

    Function GetCurrentDateAndTime() As String
        Dim nowDate As DateTime
        Return nowDate.Date.ToString("dd-MMM-yyyy hh:mm:ss")
    End Function

    Function GetDate() As String
        Dim nowDate = DateTime.Now.ToString("dd-MMM-yyyy")
        Return nowDate
    End Function

    Function GetTime() As String
        Dim nowDate = DateTime.Now.ToString("H:mm:ss")
        Return nowDate
    End Function

    Function GetLate(time As String) As String
        Dim mainTime = DateTime.Parse("8:00:00")
        Dim startTime = DateTime.Parse(time)
        Return startTime.Subtract(mainTime).ToString
    End Function

    Function DoSelectPictureBackground(ByVal openFileDialog As OpenFileDialog) As String
        Dim fileName As String = ""
        With openFileDialog
            .FileName = ""
            .Title = "Choose image file"
            .InitialDirectory = Application.StartupPath
            .Filter = "PNG|*.png|JPEG|*.jpeg|JPG|*.jpg|All|*.*"
        End With
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                fileName = openFileDialog.FileName
            Catch ex As Exception
                MessageBox.Show("DoSelectPictureBackground" & ex.Message)
            End Try
        Else
            fileName = ""
        End If
        Return fileName
    End Function

    Sub SaveBackgroundImage(ByVal path As String, ByVal content As String)
        System.IO.File.WriteAllText(Application.StartupPath & path, content)
    End Sub

    Function LoadBackgroundImage(ByVal path As String) As String
        Dim src As String = ""
        If System.IO.File.Exists(path) Then
            src = System.IO.File.ReadAllText(Application.StartupPath & path)
        Else
            SetProcessStatus("Your path not exits")
            MessageBox.Show("Your path not exits")
        End If
        Return src
    End Function

    Function DoGetServerName() As String
        Dim Server As String = String.Empty
        Dim instance As Sql.SqlDataSourceEnumerator = Sql.SqlDataSourceEnumerator.Instance
        Dim table As System.Data.DataTable = instance.GetDataSources()
        For Each row As System.Data.DataRow In table.Rows
            Server = String.Empty
            Server = row("ServerName")
            If row("InstanceName").ToString.Length > 0 Then
                Server = Server & "\" & row("InstanceName")
            End If
        Next
        Return Server
    End Function

    Sub LoadServer(ByVal comboBox As ComboBox)
        Dim Server As String = String.Empty
        Dim instance As Sql.SqlDataSourceEnumerator = Sql.SqlDataSourceEnumerator.Instance
        Dim table As System.Data.DataTable = instance.GetDataSources()
        For Each row As System.Data.DataRow In table.Rows
            comboBox.Items.Clear()
            Server = String.Empty
            Server = row("ServerName")
            If row("InstanceName").ToString.Length > 0 Then
                Server = Server & "\" & row("InstanceName")
            End If
            comboBox.Items.Add(Server)
        Next
        comboBox.SelectedIndex = comboBox.FindStringExact(Environment.MachineName)
    End Sub

    Sub LoadDatabase(ByVal server As String, ByVal comboBox As ComboBox)
        Try
            Dim con As New SqlClient.SqlConnection("Data Source=" & server & ";Integrated Security=True")
            con.Open()
            Dim cmd As New SqlClient.SqlCommand("sp_databases", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim read As SqlClient.SqlDataReader = cmd.ExecuteReader()
            comboBox.Items.Clear()
            While (read.Read())
                comboBox.Items.Add(read("DATABASE_NAME"))
            End While
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub ShowPassword(ByVal checkBox As CheckBox, ByVal textBox As TextBox)
        If checkBox.Checked = True Then
            textBox.UseSystemPasswordChar = False
        Else
            textBox.UseSystemPasswordChar = True
        End If
    End Sub

    Sub SetConnectionString(ByVal serverName As String, ByVal database As String, ByVal username As String, ByVal password As String)
        ''Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password
        My.Settings.MyConnectionString() = "Provider=SQLOLEDB;Data Source=" & serverName & ";Initial Catalog=" & database & ";User ID=" & username & ";Password=" & password
    End Sub

    Function Connection() As OleDb.OleDbConnection
        Dim singletonConnection As ConnectionSingleton
        singletonConnection = ConnectionSingleton.GetInstance
        Return singletonConnection.GetConnection
    End Function

    Sub SetComboBox(ByVal comboBox As ComboBox, ByVal table As String, ByVal field As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT " & field & " FROM " & table
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader()
            comboBox.Items.Clear()
            While dr.Read
                comboBox.Items.Add(dr(0))
            End While
            cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Sub SetComboBox(ByVal comboBox As ComboBox, ByVal comboBox1 As ComboBox, ByVal table As String, ByVal field As String, ByVal condField As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT " & field & " FROM " & table & " WHERE " & condField & " = " & comboBox1.SelectedIndex + 1
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader()
            comboBox.Items.Clear()
            While dr.Read
                comboBox.Items.Add(dr(0))
            End While
            cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Sub DoSetValueFromDBToControls(ByVal control() As Control, ByVal empID As String, ByVal tblName As String, ByVal over As Integer)
        Dim i As Integer
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT * FROM " & tblName & " WHERE EmployeeID='" & empID & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                For i = 0 To control.Length - 1
                    control(i).Text = dr(i + over)
                Next
            End While
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub DoPermission(ByVal controls() As ToolStripMenuItem, ByVal position As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT * FROM tblPermission where Position='" & position & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                For i As Integer = 0 To controls.Length - 1
                    controls(i).Tag = dr(i + 2)
                    If controls(i).Tag.ToString.StartsWith("1") Then
                        controls(i).Enabled = True
                    Else
                        controls(i).Enabled = False
                    End If
                Next
            End While
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Function GetFieldValue(table As String, field As String, cond As String, id As String) As String
        Dim myValue As String = ""
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select " & field & " from " & table & " where " & cond & "='" & id & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                myValue = dr(0)
            End If
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
        Return myValue
    End Function

    Function GetFieldValue(table As String, field As String, id As String) As String
        Dim myValue As String = ""
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select " & field & " from " & table & " where EmployeeID='" & id & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                myValue = dr(0)
            End If
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
        Return myValue
    End Function

    Sub DoCheckJobSpouse(job As TextBox, taxSpouse As TextBox)
        If job.Text = "N/A" Or job.Text = Nothing Then
            taxSpouse.Enabled = True
        Else
            taxSpouse.Enabled = False
            taxSpouse.Text = 0
        End If
    End Sub

    Function DoTotalTaxChild(childQty As String, childTax As String) As String
        Dim total As String = ""
        Try
            If childQty.StartsWith("N/A") Or childQty = Nothing Or childQty.Equals("") Then
                total = 0
            Else
                total = CDbl(childTax) * CInt(childQty)
            End If
        Catch ex As Exception
            total = 0
        End Try
        Return total
    End Function

    Sub DoCheckBox(ByVal checkBox As CheckBox, ByVal textBox As TextBox)
        If checkBox.Checked = True Then
            textBox.Enabled = True
            textBox.Text = 0
        Else
            textBox.Enabled = False
            textBox.Text = 0
        End If
    End Sub

    Sub DoCheckChild(ByVal child As TextBox, ByVal childQty As TextBox)
        If child.Text.StartsWith("មិនមាន") Then
            childQty.Enabled = False
        Else
            childQty.Enabled = True
        End If
    End Sub

    Sub DoCheckChild(ByVal status As String, ByVal gbox As GroupBox)
        If status.StartsWith("មិនមាន") Or status.StartsWith("") Then
            gbox.Enabled = False
        Else
            gbox.Enabled = True
        End If
    End Sub

    Sub DoCheckStatus(ByVal status As String, ByVal gbox As GroupBox)
        If status.StartsWith("នៅលីវ") Then
            gbox.Enabled = False
        Else
            gbox.Enabled = True
        End If

    End Sub

    Function SetPersent(ByVal salary As String) As String
        Dim persent As String = ""
        If salary.Equals("") Or salary.Equals("N/A") Or salary = Nothing Then
            persent = ""
        Else
            If CDbl(salary) <= SalaryTax.EIGHTY Then
                persent = "0%"
            ElseIf CDbl(salary) > SalaryTax.EIGHTY And CDbl(salary) <= SalaryTax.ONE_HUNDRET_TWENTY_FIVE Then
                persent = "5%"
            ElseIf CDbl(salary) > SalaryTax.ONE_HUNDRET_TWENTY_FIVE And CDbl(salary) <= SalaryTax.EIGHT_HUNDRET_FIFTY Then
                persent = "10%"
            ElseIf CDbl(salary) > SalaryTax.EIGHT_HUNDRET_FIFTY And CDbl(salary) <= SalaryTax.ONE_HUNDRET_TWENTY_FIVE Then
                persent = "15%"
            Else
                persent = "20%"
            End If
        End If
        Return persent
    End Function

    Function GetImagePathFromDB(ByVal empID As String) As String
        Dim path As String = ""
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT Photo FROM tblEmployee WHERE EmployeeID='" & empID & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                path = dr(0)
            End If
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
        Return path
    End Function

    Sub ShowFormInsidePanel(ByVal panel As Panel, ByVal frm1 As Form, ByVal frm2 As Form, ByVal comboBox As ComboBox)
        If comboBox.SelectedIndex = 0 Or comboBox.SelectedIndex = 1 Then
            frm1.TopLevel = False
            panel.Controls.Add(frm1)
            frm1.Show()
        Else
            frm2.TopLevel = False
            panel.Controls.Add(frm2)
            frm2.Show()
        End If
    End Sub

    Sub SetComboBoxValue(ByVal comboBox As ComboBox, ByVal sqlStatement As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = sqlStatement
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                comboBox.Items.Add(dr(0))
            End While
            cmd.Dispose()
        Catch ex As Exception
            Connection.Close()
        End Try
    End Sub

    Sub DoControlPersonalStatus(ByVal comboBox As ComboBox, ByVal panel As Panel)
        If comboBox.SelectedIndex = 0 Then
            panel.Enabled = False
        Else
            panel.Enabled = True
        End If
    End Sub
    Sub DoControlChildCondition(ByVal comboBox As ComboBox, ByVal groupPanel As GroupBox)
        If comboBox.SelectedIndex = 0 Then
            groupPanel.Enabled = False
        Else
            groupPanel.Enabled = True
        End If
    End Sub

    Sub DoAutoDateAndTime(ByVal lblDate As DevComponents.DotNetBar.LabelX, ByVal lblTime As DevComponents.DotNetBar.LabelX)
        lblDate.Text = Date.Now.ToString("dd-MMM-yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Function SetAutoDate() As String
        Return Date.Now.ToString("dd-MM-yyyy-hh-mm-ss")
    End Function

    Function AutoDate() As String
        Return Date.Now.ToString("dd-MMM-yyyy")
    End Function

    Sub doCalculateDate(ByVal cboType As ComboBox, ByVal txtHired As TextBox, txtExpired As TextBox)
        Dim dt1 As DateTime
        Try
            If cboType.SelectedIndex = 0 Then
                txtHired.Text = Date.Now.ToString("M/dd/yyyy")
                dt1 = DateTime.ParseExact(txtHired.Text, "M/dd/yyyy", Nothing)
                txtExpired.Text = dt1.AddDays(10)
            ElseIf cboType.SelectedIndex = 1 Then
                txtHired.Text = Date.Now.ToString("M/dd/yyyy")
                dt1 = DateTime.ParseExact(txtHired.Text, "M/dd/yyyy", Nothing)
                txtExpired.Text = dt1.AddMonths(3)
            Else
                txtHired.Text = Date.Now.ToString("M/dd/yyyy")
                dt1 = DateTime.ParseExact(txtHired.Text, "M/dd/yyyy", Nothing)
                txtExpired.Text = dt1.AddYears(1)
            End If
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Function GetIndexFromDataGridView(i As Integer, ByVal dataGridView As DataGridView) As String
        Dim index As Integer = dataGridView.CurrentRow.Index
        Return dataGridView.Item(i, index).Value
    End Function

    Sub DoGenerateExcel(ByVal dataGridView As DataGridView)
        Dim xlsx As Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i, j As Integer
        Try
            xlsx = New Microsoft.Office.Interop.Excel.Application
            wb = xlsx.Workbooks.Add(misValue)
            ws = wb.Sheets("sheet1")

            For i = 0 To dataGridView.RowCount - 1
                For j = 0 To dataGridView.ColumnCount - 1
                    For k As Integer = 0 To dataGridView.Columns.Count - 1
                        ws.Cells(1, k) = dataGridView.Columns(k).HeaderText
                        ws.Cells(i + 2, j + 1) = dataGridView(j, i).Value.ToString
                    Next
                Next
            Next

            ws.SaveAs(Application.StartupPath & "\Excel\" & DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") & ".xlsx")
            wb.Close()
            xlsx.Quit()

            releaseObject(xlsx)
            releaseObject(wb)
            releaseObject(ws)

        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Function AutoChildNo(ByVal employeeID As String, ByVal txtChildQty As String) As String
        Dim idStyle As String = ""
        Dim i As Integer
        If Not i = CInt(txtChildQty) Then
            i += 1
            idStyle = employeeID & "-" & i
        End If
        Return idStyle
    End Function

    Function AutoNo(ByVal qty As String, ByVal no As String, ByVal control As Control) As Integer
        Dim myNo As Integer = 0
        If no.Equals(qty) Then
            myNo = CInt(no)
            control.Enabled = False
        Else
            myNo = CInt(no) + 1
            control.Enabled = True
        End If
        Return myNo
    End Function

    Sub GetValueFromDataGridView(ByRef controls() As Control, ByVal dataGridView As DataGridView, ByVal over As Integer)
        Dim column As Integer = controls.Length
        Dim row As Integer = dataGridView.CurrentRow.Index
        Dim i As Integer
        For i = 0 To column - 1
            controls(i).Text = dataGridView.Item(i + over, row).Value
        Next
    End Sub

    Sub SetFalseOrTrueCheckBox(ByRef controls() As CheckBox, ByVal dataGridView As DataGridView, ByVal over As Integer)
        Dim column As Integer = controls.Length
        Dim row As Integer = dataGridView.CurrentRow.Index
        Dim i As Integer
        For i = 0 To column - 1
            If dataGridView.Item(i + over, row).Value = "1" Then
                controls(i).Checked = True
            Else
                controls(i).Checked = False
            End If
        Next
    End Sub

    Function SetValueToControl(ByVal dataGridView As DevComponents.DotNetBar.Controls.DataGridViewX) As List(Of String)
        Dim col As Integer = dataGridView.ColumnCount
        Dim row As Integer = dataGridView.CurrentRow.Index
        Dim myList As New List(Of String)
        Dim i As Integer
        For i = 0 To i < col Step 1
            myList.Item(i) = dataGridView.Item(i, row).Value
        Next
        Return myList
    End Function

    Sub ClearForm(ByVal F As Object)
        Dim c As Control
        For Each c In F.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                c.Text = ""
            End If
        Next
    End Sub

    Sub DoSetNA(ByVal obj As Object)
        Dim c As Control
        For Each c In obj.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                If c.Text = "" Or c.Text = Nothing Then
                    c.Text = "N/A"
                End If
            End If
        Next
    End Sub

    Sub ClearCheckBox(ByVal obj As Object)
        Dim c As CheckBox
        For Each c In obj.Controls
            If TypeOf c Is CheckBox Then
                c.Checked = False
            End If
        Next
    End Sub

    Function SetCheckBox(checkbox As CheckBox) As String
        Dim value As String = ""
        If checkbox.Checked = True Then
            value = 1
        Else
            value = 0
        End If
        Return value
    End Function

    Sub DoSet0(ByVal obj As Object)
        Dim c As Control
        For Each c In obj.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                c.Text = 0
            End If
        Next
    End Sub

    Sub NumberOnly(ByVal e As Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Function ControlEducationCondition(comboBox As ComboBox, frmUnversity As frmUniversity, frmSchool As frmSchool) As Education
        Dim edu As New Education
        If comboBox.SelectedIndex = 0 Or comboBox.SelectedIndex = 1 Then
            edu.Name = frmSchool.txtSchool.Text
            edu.StartYear = frmSchool.txtStartYear.Text
            edu.EndYear = frmSchool.txtEndYear.Text
            edu.Grade = frmSchool.cboGrade.Text
            edu.GPA = "N/A"
        Else
            edu.Name = frmUnversity.cboUniversity.Text
            edu.Major = frmUnversity.cboMajor.Text
            edu.StartYear = frmUnversity.txtUniStartYear.Text
            edu.EndYear = frmUnversity.txtUniEndYear.Text
            edu.GPA = frmUnversity.txtGPA.Text
            edu.Grade = "N/A"
        End If
        edu.EductionLevel = comboBox.Text
        Return edu
    End Function

    Function IsCheckEducation(comboBox As ComboBox) As Boolean
        If comboBox.SelectedIndex = 0 Or comboBox.SelectedIndex = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub SetProcessStatus(message As String)
        frmMenu.lblProcessStatus.Text = message
    End Sub

    Function SetAutoGender(comboBox As ComboBox) As String
        If comboBox.SelectedIndex = 0 Then
            Return "ប្រុស"
        Else
            Return "ស្រី"
        End If
    End Function

    Function DoImageEnabled(ByVal txtOldPassword As String, table As String, field As String) As Boolean
        Dim b As Boolean = False
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT " & field & " FROM " & table & " WHERE " & field & "='" & txtOldPassword & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                If txtOldPassword.Equals(dr(0)) Then
                    b = True
                Else
                    b = False
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return b
    End Function

    Sub DoCheckBox(chb1 As CheckBox, chb2 As CheckBox, txt1 As TextBox, txt2 As TextBox)
        If chb1.Checked = True Then
            chb2.Checked = False
            txt1.Enabled = True
            txt2.Enabled = False
        Else
            chb2.Checked = True
            txt1.Enabled = False
            txt2.Enabled = True
        End If
    End Sub

    Function DoImageEnabled(ByVal newPass As String, ByVal conPass As String) As Boolean
        Dim myB As Boolean = False
        Try
            If newPass.Equals(conPass) Then
                myB = True
            Else
                myB = False
            End If
        Catch ex As Exception
            myB = False
        End Try
        Return myB
    End Function
    Public Function GetID(table As String) As Long
        Dim myLong As Long = 0
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "SELECT MAX(ID) FROM " & table
            Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
            If dr.Read Then
                If IsDBNull(dr(0)) Then
                    myLong = 1
                Else
                    myLong = CLng(dr(0)) + 1
                End If
            End If
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
        Return myLong
    End Function

    Public Function SetAutoID(val As Long, formatStyle As String) As String
        Return Format(val, formatStyle)
    End Function

    Sub DoChangeEducationPanel(cboEducationLevel As ComboBox, frmSchool As frmSchool, panel As Panel, frmUniversity As frmUniversity, dgvEducation As DataGridView)
        Dim row As Integer = dgvEducation.CurrentRow.Index
        If cboEducationLevel.Text.Equals("បឋមភូមិ") Or cboEducationLevel.Text.Equals("ទុតិយភូមិ") Then
            frmSchool.TopLevel = False
            panel.Controls.Add(frmSchool)
            frmSchool.Show()
            frmSchool.txtSchool.Text = dgvEducation.Item(5, row).Value
            frmSchool.txtStartYear.Text = dgvEducation.Item(7, row).Value
            frmSchool.txtEndYear.Text = dgvEducation.Item(8, row).Value
            frmSchool.cboGrade.Text = dgvEducation.Item(10, row).Value
        Else
            frmUniversity.TopLevel = False
            panel.Controls.Add(frmUniversity)
            frmUniversity.Show()
            frmUniversity.cboUniversity.Text = dgvEducation.Item(5, row).Value
            frmUniversity.cboMajor.Text = dgvEducation.Item(6, row).Value
            frmUniversity.txtUniStartYear.Text = dgvEducation.Item(7, row).Value
            frmUniversity.txtUniEndYear.Text = dgvEducation.Item(8, row).Value
            frmUniversity.txtGPA.Text = dgvEducation.Item(9, row).Value
        End If
    End Sub
    Sub DoShowReport(report As CrystalReportViewer, path As String, parameter() As String, control() As String)
        Try
            Dim rpt As New ReportDocument
            Dim i As Integer
            rpt.Load(Application.StartupPath & "/Report/" & path)
            For i = 0 To parameter.Length - 1
                rpt.SetParameterValue(parameter(i), control(i))
            Next
            report.ReportSource = rpt
            report.Refresh()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub DoShowReport(report As CrystalReportViewer, path As String, parameter As String, control As String)
        Try
            Dim rpt As New ReportDocument
            rpt.Load(Application.StartupPath & "/Report/" & path)
            rpt.SetParameterValue(parameter, control)
            report.ReportSource = rpt
            report.Refresh()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Function IsLogin(userName As String, password As String) As Boolean
        Dim myB As Boolean = False
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select UserName,Password from tblUser where UserName='" & userName & "' and Password='" & password & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                If IsDBNull(dr(0)) And IsDBNull(dr(1)) And dr(0).Equals("") And dr(1).Equals("") Then
                    myB = False
                    MessageBox.Show(myB)
                ElseIf IsDBNull(dr(0)) Or IsDBNull(dr(1)) Or dr(0).Equals("") Or dr(1).Equals("") Then
                    myB = False
                Else
                    myB = True
                End If
            End While
        Catch ex As Exception
            MessageBox.Show("Incorrected! username and password please try again.", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return myB
    End Function
    Function SetPosition(userName As String, password As String) As String
        Dim myB As String = ""
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select Position from tblUser where UserName='" & userName & "' and Password='" & password & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                myB = dr(0)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SetProcessStatus(ex.Message)
        End Try
        Return myB
    End Function

    Sub Backup(ByVal database As String, saveDialog As SaveFileDialog, timer As Timer, progress As ProgressBar)
        Try
            saveDialog.FileName = SetAutoDate() & ".bak"
            saveDialog.ShowDialog()
            saveDialog.Filter = "Backup files | *.bak"
            timer.Enabled = True
            progress.Visible = True
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "BACKUP DATABASE " & database & " TO disk='" & saveDialog.FileName & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Restore(ByVal database As String, openDialog As OpenFileDialog, timer As Timer, progress As ProgressBar)
        Try
            openDialog.ShowDialog()
            openDialog.Filter = "Backup files | *.bak"
            timer.Enabled = True
            progress.Visible = True
            Dim cmd As New OleDb.OleDbCommand
            ''cmd = New OleDb.OleDbCommand("USE master", Connection())
            cmd.Connection = Connection()
            cmd.CommandText = "RESTORE DATABASE " & database & " FROM disk='" & openDialog.FileName & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub DoProgressBar(timer As Timer, progress As ProgressBar)
        If progress.Value = 100 Then
            timer.Enabled = False
            progress.Value = 0
            MessageBox.Show("Successfully")
        Else
            progress.Value = progress.Value + 5
        End If
    End Sub
End Module
