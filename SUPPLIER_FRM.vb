Imports System.IO
'Imports Excel = Microsoft.Office.Interop.Excel
Public Class SUPPLIER_FRM
    'Dim CLONE() As String
    'Dim DT As DataTable
    'Sub CLEARE_TEXTBOX()
    '    With ADDNEW_SUPPLIER_FRM
    '        ClearTextBox(.SuppCode_TextBox, .SuppName_TextBox, .KhmerName_TextBox, .Address2_TextBox, .Address3_TextBox, .Tel_TextBox, .Fax_TextBox, .Email_TextBox, .Website_TextBox, .ContName_TextBox, .ContTel_TextBox, .ContEmail_TextBox, .txtCredit_limit, .txtPayement, .txtPayterm)
    '    End With
    'End Sub
    'Sub INSERT_DATA()
    '    With ADDNEW_SUPPLIER_FRM
    '        Dim cmd As New SqlClient.SqlCommand("INSERT INTO OCSUPPLIER VALUES(@SCODE,@SNAME,@ADD1,@ADD2,@ADD3,@TEL,@FAX,@EMAIL,@WEBSITE,@CNAME,@CTEL,@CEMAIL,@C0,@C1,@C2,@C3,@C4,@C5,@C6,@C7,@C8,@C9,@STATUS,@TRAN,@USERC,@DATEC,@USERU,@DATEU)", CN)
    '        cmd.CommandType = CommandType.Text
    '        CreatePar(cmd, "SCODE", .SuppCode_TextBox.Text, "SNAME", .SuppName_TextBox.Text, "ADD1", .KhmerName_TextBox.Text, "ADD2", .Address2_TextBox.Text, "ADD3", .Address3_TextBox.Text, "TEL", .Tel_TextBox.Text, "FAX", .Fax_TextBox.Text, "EMAIL", .Email_TextBox.Text, "WEBSITE", .Website_TextBox.Text, "CNAME", .ContName_TextBox.Text, "CTEL", .ContTel_TextBox.Text, "CEMAIL", .ContEmail_TextBox.Text, "C0", IIf(.txtCredit_limit.Text = "", 0, .txtCredit_limit.Text), "C1", .txtPayterm.Text, "C2", "", "C3", "", "C4", "", "C5", "", "C6", "", "C7", "", "C8", "", "C9", "", "STATUS", .Status_ComboBox.SelectedItem.ToString.Substring(0, 1), "TRAN", "N", "USERC", USERCODE, "DATEC", DATE_INT, "USERU", "", "DATEU", "")
    '        cmd.ExecuteNonQuery()
    '        cmd.Parameters.Clear()
    '        cmd.CommandText = "UPDATE OCSYSDATA SET KEY_DATA1=LEFT(KEY_DATA1,5)+'Y' WHERE KEY_TYPE='PAYTERM' AND KEY_CODE=@KEY_CODE"
    '        cmd.CommandType = CommandType.Text
    '        CreatePar(cmd, "KEY_CODE", .txtPayterm.Text)
    '        cmd.ExecuteNonQuery()

    '        Dim DR As DataRow
    '        DR = DT.NewRow
    '        DR(0) = .SuppCode_TextBox.Text
    '        DR(1) = .SuppName_TextBox.Text
    '        DR(2) = .KhmerName_TextBox.Text
    '        DR(3) = .Address2_TextBox.Text
    '        DR(4) = .Address3_TextBox.Text
    '        DR(5) = .Tel_TextBox.Text
    '        DR(6) = .Fax_TextBox.Text
    '        DR(7) = .Email_TextBox.Text
    '        DR(8) = .Website_TextBox.Text
    '        DR(9) = .ContName_TextBox.Text
    '        DR(10) = .ContTel_TextBox.Text
    '        DR(11) = .ContEmail_TextBox.Text
    '        DR(12) = .txtCredit_limit.Text
    '        DR(13) = .txtPayterm.Text
    '        DR(14) = .txtPayement.Text
    '        DR(15) = .Status_ComboBox.SelectedItem.ToString
    '        DR(16) = USERCODE
    '        DR(17) = Format(Now, "dd-MMM-yyyy hh:mm:ss")
    '        DR(18) = ""
    '        DR(19) = ""
    '        DT.Rows.Add(DR)

    '    End With
    'End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'If ALLOW_ACTION_PERMISSION(USERCODE, "Supplier Information", "V", "New Supplier") = False Then Exit Sub
        'With ADDNEW_SUPPLIER_FRM
        '    .Tag = "New"
        '    .Text = IIf(LANGUAGE="en","Add New Supplier Information","បន្ថែមព័ត៌មានអ្នកផ្គត់ផ្គង់ថ្មី")
        '    .Title_Label.Text = IIf(LANGUAGE = "en", "Add New Supplier", "បន្ថែមព័ត៌មានអ្នកផ្គត់ផ្គង់ថ្មី")
        '    .SuppCode_TextBox.Enabled = True
        '    CLEARE_TEXTBOX()
        '    .Status_ComboBox.SelectedIndex = 0
        '    If .ShowDialog = Windows.Forms.DialogResult.OK Then
        '        INSERT_DATA()
        '    End If
        '    .Close()
        'End With

    End Sub

    Private Sub Exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub SUPPLIER_FRM_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'MAIN_FRM.Text = String.Format("{0} [{1}]", Company_Name, Me.Text)
        'MAIN_FRM.dgRow.Text = dg_data.Rows.Count
    End Sub

    Private Sub SUPPLIER_FRM_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'MAIN_FRM.Text = Company_Name
    End Sub

    Private Sub SUPPLIER_FRM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DT = SelectData("SELECT SUP_CODE,SUP_NAME,SUP_ADD1,SUP_ADD2,SUP_ADD3,SUP_TEL,SUP_FAX,SUP_EMAIL,SUP_WEB,CONT_NAME,CONT_TEL,CONT_EMAIL,SUP_CF0,SUP_CF1,ISNULL((SELECT KEY_DATA FROM OCSYSDATA WHERE KEY_TYPE='PAYTERM' AND KEY_CODE=SUP_CF1),'')[KEY_DATA],(CASE WHEN SUP_STAT='A' THEN 'Active' ELSE 'Disable' END) AS SUP_STAT,USER_CREA,dbo.DATE_FORMAT(DATE_CREA,'dd-MMM-yyyy HH:MI:SS') AS DATE_CREA,USER_UPDT,dbo.DATE_FORMAT(DATE_UPDT,'dd-MMM-yyyy HH:MI:SS') AS DATE_UPDT FROM OCSUPPLIER")
        'dg_data.DataSource = DT
        'PasteToolStripMenuItem.Enabled = False
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        'If ALLOW_ACTION_PERMISSION(USERCODE, "Supplier Information", "V", "Edit Supplier") = False Then Exit Sub
        'With ADDNEW_SUPPLIER_FRM
        '    If dg_data.SelectedRows.Count > 0 Then
        '        .Tag = "Edit"
        '        .Text = IIf(LANGUAGE = "en", "Edit Supplier Information", "កែប្រែព័ត៌មានអ្នកផ្គត់ផ្គង")
        '        .Title_Label.Text = IIf(LANGUAGE = "en", "Edit Supplier", "កែប្រែព័ត៌មានអ្នកផ្គត់ផ្គង")
        '        .SuppCode_TextBox.Enabled = False
        '        .SuppCode_TextBox.Text = dg_data.SelectedRows(0).Cells(0).Value
        '        .SuppName_TextBox.Text = dg_data.SelectedRows(0).Cells(1).Value
        '        .KhmerName_TextBox.Text = dg_data.SelectedRows(0).Cells(2).Value
        '        .Address2_TextBox.Text = dg_data.SelectedRows(0).Cells(3).Value
        '        .Address3_TextBox.Text = dg_data.SelectedRows(0).Cells(4).Value
        '        .Tel_TextBox.Text = dg_data.SelectedRows(0).Cells(5).Value
        '        .Fax_TextBox.Text = dg_data.SelectedRows(0).Cells(6).Value
        '        .Email_TextBox.Text = dg_data.SelectedRows(0).Cells(7).Value
        '        .Website_TextBox.Text = dg_data.SelectedRows(0).Cells(8).Value
        '        .ContName_TextBox.Text = dg_data.SelectedRows(0).Cells(9).Value
        '        .ContTel_TextBox.Text = dg_data.SelectedRows(0).Cells(10).Value
        '        .ContEmail_TextBox.Text = dg_data.SelectedRows(0).Cells(11).Value
        '        .txtCredit_limit.Text = dg_data.SelectedRows(0).Cells(12).Value
        '        .txtPayterm.Text = dg_data.SelectedRows(0).Cells(13).Value
        '        .txtPayement.Text = dg_data.SelectedRows(0).Cells(14).Value
        '        .Status_ComboBox.SelectedIndex = IIf(dg_data.SelectedRows(0).Cells(15).Value.ToString = "Active", 0, 1)
        '        If .ShowDialog = Windows.Forms.DialogResult.OK Then

        '            Dim cmd As New SqlClient.SqlCommand("UPDATE OCSUPPLIER SET SUP_NAME=@SNAME,SUP_ADD1=@ADD1,SUP_ADD2=@ADD2,SUP_ADD3=@ADD3,SUP_TEL=@TEL,SUP_FAX=@FAX,SUP_EMAIL=@EMAIL,SUP_WEB=@WEB,CONT_NAME=@CNAME,CONT_TEL=@CTEL,CONT_EMAIL=@CEMAIL,SUP_CF0=@SUP_CF0,SUP_CF1=@SUP_CF1,SUP_STAT=@STAT,USER_UPDT=@USERU,DATE_UPDT=@DATEU WHERE SUP_CODE='" & .SuppCode_TextBox.Text & "'", CN)
        '            cmd.CommandType = CommandType.Text
        '            CreatePar(cmd, "SNAME", .SuppName_TextBox.Text, "ADD1", .KhmerName_TextBox.Text, "ADD2", .Address2_TextBox.Text, "ADD3", .Address3_TextBox.Text, "TEL", .Tel_TextBox.Text, "FAX", .Fax_TextBox.Text, "EMAIL", .Email_TextBox.Text, "WEB", .Website_TextBox.Text, "CNAME", .ContName_TextBox.Text, "CTEL", .ContTel_TextBox.Text, "CEMAIL", .ContEmail_TextBox.Text, "SUP_CF0", IIf(.txtCredit_limit.Text = "", 0, .txtCredit_limit.Text), "SUP_CF1", .txtPayterm.Text, "STAT", .Status_ComboBox.SelectedItem.ToString.Substring(0, 1), "USERU", USERCODE, "DATEU", DATE_INT)
        '            cmd.ExecuteNonQuery()
        '            cmd.Parameters.Clear()
        '            cmd.CommandText = "UPDATE OCSYSDATA SET KEY_DATA1=LEFT(KEY_DATA1,5)+'Y' WHERE KEY_TYPE='PAYTERM' AND KEY_CODE=@KEY_CODE"
        '            cmd.CommandType = CommandType.Text
        '            CreatePar(cmd, "KEY_CODE", .txtPayterm.Text)
        '            cmd.ExecuteNonQuery()

        '            dg_data.SelectedRows(0).Cells(1).Value = .SuppName_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(2).Value = .KhmerName_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(3).Value = .Address2_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(4).Value = .Address3_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(5).Value = .Tel_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(6).Value = .Fax_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(7).Value = .Email_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(8).Value = .Website_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(9).Value = .ContName_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(10).Value = .ContTel_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(11).Value = .ContEmail_TextBox.Text
        '            dg_data.SelectedRows(0).Cells(12).Value = .txtCredit_limit.Text
        '            dg_data.SelectedRows(0).Cells(13).Value = .txtPayterm.Text
        '            dg_data.SelectedRows(0).Cells(14).Value = .txtPayement.Text
        '            dg_data.SelectedRows(0).Cells(15).Value = .Status_ComboBox.Text
        '            dg_data.SelectedRows(0).Cells(18).Value = USERCODE
        '            dg_data.SelectedRows(0).Cells(19).Value = Format(Now, "dd-MMM-yyyy hh:mm:ss")
        '            MsgBox(IIf(LANGUAGE = "en", "Supplier information has been updated!", "ទិន្នន័យត្រូវបានកែប្រែ និងរក្សាទុក!"), MsgBoxStyle.Information)
        '        End If
        '    Else
        '        MsgBox(IIf(LANGUAGE = "en", "Pleas select record to edit!", "មិនមានទិន្នន័យត្រូវកែប្រែ!"), MsgBoxStyle.Information)
        '    End If
        '    .Close()
        'End With
    End Sub

    Private Sub DeleteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripButton.Click
        'If ALLOW_ACTION_PERMISSION(USERCODE, "Supplier Information", "V", "Delete Supplier") = False Then Exit Sub
        'If dg_data.Rows.Count > 0 Then
        '    If dg_data.SelectedRows.Count > 0 Then
        '        If Exists(CN, "OCSUPPLIER", "SUP_CODE", dg_data.SelectedRows(0).Cells(0).Value, "TRANS_PRES", "N") Then
        '            If (MsgBox(IIf(LANGUAGE = "en", "Are you sure want to delete this record?", "តើអ្នកចង់លុបទិន្នន័យនេះមែនទេ?"), MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.Yes Then
        '                Dim cmd As New SqlClient.SqlCommand("DELETE OCSUPPLIER WHERE SUP_CODE='" & dg_data.SelectedRows(0).Cells(0).Value & "'", CN)
        '                cmd.ExecuteNonQuery()
        '                DT.Rows.Remove(DT.Select("SUP_CODE ='" & dg_data.SelectedRows(0).Cells(0).Value & "'")(0))
        '                MsgBox(IIf(LANGUAGE = "en", "Supplier has been deleted.", "ទិន្នន័យត្រូវបានលុប!"), MsgBoxStyle.Information)
        '            End If
        '        Else
        '            MsgBox(IIf(LANGUAGE = "en", "This supplier cannot delete, transaction present!", "ទិន្នន័យមិនអាចលុបបានទេ ព្រោះកំពុងប្រើប្រាស់!"), MsgBoxStyle.Exclamation)
        '        End If
        '    Else
        '        MsgBox(IIf(LANGUAGE = "en", "Please select record to delete!", "មិនមានទិន្នន័យត្រូវលុប!"), MsgBoxStyle.Exclamation)
        '    End If
        'Else
        '    MsgBox(IIf(LANGUAGE = "en", "No data to delete!", "មិនមានទិន្នន័យត្រូវលុប!"), MsgBoxStyle.Exclamation)
        'End If

    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        'If ALLOW_ACTION_PERMISSION(USERCODE, "Supplier Information", "V", "Copy Data") = False Then Exit Sub
        'With ADDNEW_SUPPLIER_FRM
        '    If dg_data.Rows.Count > 0 Then
        '        If dg_data.SelectedRows.Count > 0 Then
        '            PasteToolStripMenuItem.Enabled = True
        '            For I As Integer = 0 To dg_data.ColumnCount - 1
        '                ReDim Preserve CLONE(I)
        '                CLONE(I) = dg_data.SelectedRows(0).Cells(I).Value
        '            Next
        '        Else
        '            MsgBox(IIf(LANGUAGE = "en", "Pleas select record to copy!", "មិនមានទិន្នន័យត្រូវចំលង!"))
        '        End If
        '    Else
        '        MessageBox.Show(IIf(LANGUAGE = "en", "No data from clone!", "មិនមានទិន្នន័យត្រូវចំលង!"), "Clone Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'End With
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        'With ADDNEW_SUPPLIER_FRM
        '    .Tag = "New"
        '    .Title_Label.Text = IIf(LANGUAGE = "en", "Add New Supplier", "បន្ថែមអ្នកផ្គត់ផ្គង់ថ្មី")
        '    .SuppCode_TextBox.Enabled = True
        '    .SuppCode_TextBox.Text = CLONE(0)
        '    .SuppCode_TextBox.SelectAll()
        '    .SuppName_TextBox.Text = CLONE(1)
        '    .KhmerName_TextBox.Text = CLONE(2)
        '    .Address2_TextBox.Text = CLONE(3)
        '    .Address3_TextBox.Text = CLONE(4)
        '    .Tel_TextBox.Text = CLONE(5)
        '    .Fax_TextBox.Text = CLONE(6)
        '    .Email_TextBox.Text = CLONE(7)
        '    .Website_TextBox.Text = CLONE(8)
        '    .ContName_TextBox.Text = CLONE(9)
        '    .ContTel_TextBox.Text = CLONE(10)
        '    .ContEmail_TextBox.Text = CLONE(11)
        '    .txtCredit_limit.Text = CLONE(12)
        '    .txtPayterm.Text = CLONE(13)
        '    .txtPayement.Text = CLONE(14)
        '    .Status_ComboBox.SelectedIndex = IIf(CLONE(15) = "Active", 0, 1)
        '    If .ShowDialog = Windows.Forms.DialogResult.OK Then
        '        INSERT_DATA()
        '    End If
        '    .Close()
        'End With

    End Sub
#Region "EXCEL"
    'Dim Ea As Excel.Application
    'Dim W As Excel.Workbook
    'Dim S As Excel.Worksheet
    'Dim COL_SEL() As Boolean
    'Private Sub ExportToExcelToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToExcelToolStripButton4.Click
    '    If ALLOW_ACTION_PERMISSION(USERCODE, "Supplier Information", "V", "Export Data to Excel") = False Then Exit Sub
    '    Ea = New Excel.Application
    '    W = Ea.Workbooks.Add
    '    S = W.Worksheets.Add
    '    For I = 0 To dg_data.Columns.Count - 1
    '        S.Cells(1, I + 1) = dg_data.Columns(I).HeaderText
    '    Next
    '    With PROGRESSBAR_FRM
    '        .Text = Exporttoexcel
    '        .ProgressBarX1.Value = 0
    '        bgwExcel.RunWorkerAsync()
    '        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
    '            bgwExcel.CancelAsync()
    '            .Close()
    '        End If
    '    End With
    'End Sub

    Private Sub bgwExcel_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwExcel.DoWork
        Try
            For I As Integer = 0 To dg_data.Rows.Count - 1
                Dim K As Integer = 0
                For J As Integer = 0 To dg_data.Columns.Count - 1
                    K += 1
                    'S.Cells(I + 2, K) = "'" & dg_data.Rows(I).Cells(J).Value
                Next
                Dim ROWC As Integer = dg_data.Rows.Count - 1
                If ROWC = 0 Then
                    ROWC = 1 : I = 1
                End If
                bgwExcel.ReportProgress((I / ROWC) * 100)
                If bgwExcel.CancellationPending Then Exit Sub
            Next
        Catch ex As Exception
            'Ea = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub bgwExcel_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwExcel.ProgressChanged
        'PROGRESSBAR_FRM.ProgressBarX1.Value = e.ProgressPercentage
        'PROGRESSBAR_FRM.lblExport.Text = String.Format("{0} ({1}%)", Exporttoexcel, e.ProgressPercentage)
        'PROGRESSBAR_FRM.Refresh()
    End Sub

    Private Sub bgwExcel_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwExcel.RunWorkerCompleted
        'PROGRESSBAR_FRM.Close()
        'Ea.Visible = True
        'S.Columns.AutoFit()
        'S = Nothing
        'W = Nothing
        'Ea = Nothing
    End Sub
#End Region
    Private Sub SearchToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripButton.Click
        'If ALLOW_ACTION_PERMISSION(USERCODE, "Supplier Information", "V", "Search Data") = False Then Exit Sub
        'DT = SelectData("SELECT SUP_CODE,SUP_NAME,SUP_ADD1,SUP_ADD2,SUP_ADD3,SUP_TEL,SUP_FAX,SUP_EMAIL,SUP_WEB,CONT_NAME,CONT_TEL,CONT_EMAIL,(CASE WHEN SUP_STAT='A' THEN 'Active' ELSE 'Disable' END) AS SUP_STAT,USER_CREA,dbo.DATE_FORMAT(DATE_CREA,'dd/MM/yyyy HH:MI:SS') AS DATE_CREA,USER_UPDT,dbo.DATE_FORMAT(DATE_UPDT,'dd/MM/yyyy HH:MI:SS') AS DATE_UPDT FROM OCSUPPLIER WHERE SUP_CODE LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR SUP_NAME LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR SUP_ADD1 LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR SUP_ADD2 LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR SUP_ADD3 LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR SUP_TEL LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR SUP_FAX LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR SUP_EMAIL LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR SUP_WEB LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR CONT_NAME LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR CONT_TEL LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR CONT_EMAIL LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR SUP_STAT LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR USER_CREA LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR DATE_CREA LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR USER_UPDT LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%' OR DATE_UPDT LIKE '" & SearchToolStripTextBox.Text.Replace("'", "") & "%'")
        'dg_data.DataSource = DT
    End Sub

    Private Sub SearchToolStripTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchToolStripTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchToolStripButton_Click(sender, e)
        End If
    End Sub

    Private Sub DataGridViewX1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        EditToolStripButton_Click(sender, e)
    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        'If ALLOW_ACTION_PERMISSION(USERCODE, "Supplier Information", "V", "Export Data") = False Then Exit Sub
        'With EXPORT_DATA_FRM
        '    .cboselect_date.Items.Clear()
        '    .cboselect_date.Items.Add("Supplier Information")
        '    .cboselect_date.SelectedIndex = .cboselect_date.Items.IndexOf("Supplier Information")
        '    .cboselect_date.Enabled = True
        '    If .ShowDialog = Windows.Forms.DialogResult.OK Then
        '        .Close()
        '    End If
        'End With
    End Sub

    Private Sub ImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripMenuItem.Click
        'If ALLOW_ACTION_PERMISSION(USERCODE, "Supplier Information", "V", "Import Data") = False Then Exit Sub
        'With IMPORT_DATA_FRM
        '    .cboselect_data.Items.Clear()
        '    .cboselect_data.Items.Add("Supplier Information")
        '    .cboselect_data.SelectedIndex = .cboselect_data.Items.IndexOf("Supplier Information")
        '    .cboselect_data.Enabled = False
        '    If .ShowDialog = Windows.Forms.DialogResult.OK Then
        '        If .dgimport_data.Rows.Count > 0 Then
        '            Me.Cursor = Cursors.WaitCursor
        '            For i As Integer = 0 To .dgimport_data.Rows.Count - 1
        '                Dim r As DataRow
        '                r = DT.NewRow
        '                Dim j As Integer
        '                For j = 0 To .dgimport_data.Columns.Count - 2
        '                    If j = 16 Then
        '                        r(j) = USERCODE
        '                    ElseIf j = 17 Then
        '                        r(j) = Format(Now, "dd-MMM-yyyy hh:mm:ss")
        '                    ElseIf j = 18 Then
        '                        r(j) = ""
        '                    ElseIf j = 19 Then
        '                        r(j) = 0
        '                    Else
        '                        r(j) = .dgimport_data.Rows(i).Cells(j).Value
        '                    End If
        '                Next
        '                DT.Rows.Add(r)
        '                dg_data.MultiSelect = True
        '                dg_data.Rows(dg_data.Rows.Count - 1).Selected = True
        '            Next
        '            Me.Cursor = Cursors.Default
        '            MsgBox(IIf(LANGUAGE = "en", "All data was imported successfully", "ទិន្នន័យទាំងអស់ត្រូវបាននាំចេញ!"), MsgBoxStyle.Information)
        '        End If
        '    End If
        '    .Close()
        'End With
    End Sub

    'Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If dg_data.SelectedRows.Count > 0 Then
    '        With ADDNEW_DELIVERY_FRM
    '            .Title_Label.Text = "Add New Delivery"
    '            .DelCode_TextBox.Enabled = True
    '            CLEARE_TEXTBOX()
    '            .Status_ComboBox.SelectedIndex = 0
    '            If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '                Dim cmd As New SqlClient.SqlCommand("INSERT INTO OCSUPDEL VALUES(@SCODE,@DCODE,@DNAME,@ADD1,@ADD2,@ADD3,@TEL,@FAX,@EMAIL,@WEBSITE,@CNAME,@CTEL,@CEMAIL,@C0,@C1,@C2,@C3,@C4,@C5,@C6,@C7,@C8,@C9,@STATUS,@TRAN,@USERC,@DATEC,@USERU,@DATEU)", CN)
    '                cmd.CommandType = CommandType.Text
    '                CreatePar(cmd, "SCODE", dg_data.SelectedRows(0).Cells(0).Value, "DCODE", .DelCode_TextBox.Text, "DNAME", .DelName_TextBox.Text, "ADD1", .KhmerName_TextBox.Text, "ADD2", .Address2_TextBox.Text, "ADD3", .Address3_TextBox.Text, "TEL", .Tel_TextBox.Text, "FAX", .Fax_TextBox.Text, "EMAIL", .Email_TextBox.Text, "WEBSITE", .Website_TextBox.Text, "CNAME", .ContName_TextBox.Text, "CTEL", .ContTel_TextBox.Text, "CEMAIL", .ContEmail_TextBox.Text, "C0", "", "C1", "", "C2", "", "C3", "", "C4", "", "C5", "", "C6", "", "C7", "", "C8", "", "C9", "", "STATUS", .Status_ComboBox.SelectedItem.ToString.Substring(0, 1), "TRAN", "N", "USERC", USERCODE, "DATEC", DATE_INT, "USERU", "", "DATEU", "")
    '                cmd.ExecuteNonQuery()
    '                Dim DR As DataRow
    '                DR = DT.NewRow
    '                DR(0) = .DelCode_TextBox.Text
    '                DR(1) = .DelCode_TextBox.Text
    '                DR(2) = .KhmerName_TextBox.Text
    '                DR(3) = .Address2_TextBox.Text
    '                DR(4) = .Address3_TextBox.Text
    '                DR(5) = .Tel_TextBox.Text
    '                DR(6) = .Fax_TextBox.Text
    '                DR(7) = .Email_TextBox.Text
    '                DR(8) = .Website_TextBox.Text
    '                DR(9) = .ContName_TextBox.Text
    '                DR(10) = .ContTel_TextBox.Text
    '                DR(11) = .ContEmail_TextBox.Text
    '                DR(12) = .Status_ComboBox.SelectedItem.ToString
    '                DR(13) = USERCODE
    '                DR(14) = Format(Now, "dd-MMM-yyyy hh:mm:ss")
    '                DR(18) = ""
    '                DR(19) = ""
    '                DT.Rows.Add(DR)
    '            End If
    '        End With
    '    End If
    'End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        'DT = New DataTable
        'Dim STR As String = "SELECT SUP_CODE,SUP_NAME,SUP_ADD1,SUP_ADD2,SUP_ADD3,SUP_TEL,SUP_FAX,SUP_EMAIL,SUP_WEB,CONT_NAME,CONT_TEL,CONT_EMAIL,SUP_CF0,SUP_CF1,ISNULL((SELECT KEY_DATA FROM OCSYSDATA WHERE KEY_TYPE='PAYTERM' AND KEY_CODE=SUP_CF1),'')[KEY_DATA],(CASE WHEN SUP_STAT='A' THEN 'Active' ELSE 'Disable' END) AS SUP_STAT,USER_CREA,dbo.DATE_FORMAT(DATE_CREA,'dd-MMM-yyyy HH:MI:SS') AS DATE_CREA,USER_UPDT,dbo.DATE_FORMAT(DATE_UPDT,'dd-MMM-yyyy HH:MI:SS') AS DATE_UPDT FROM OCSUPPLIER"
        'If TreeView1.Nodes.Count > 0 Then
        '    Select Case e.Node.Level
        '        Case 0
        '            If e.Node.Index = 0 Then
        '                DT = SelectData(STR & " WHERE LEFT(DATE_CREA,6)='" & Format(Now(), "yyyyMM") & "'")
        '            ElseIf e.Node.Index = 1 Then
        '                DT = SelectData(STR)
        '            End If
        '        Case 1
        '            If e.Node.Parent.Index = 0 Then
        '                DT = SelectData(STR & " WHERE LEFT(DATE_CREA,6)='" & Format(Now(), "yyyyMM") & "' AND SUP_STAT='" & e.Node.Tag & "'")
        '            ElseIf e.Node.Parent.Index = 1 Then
        '                DT = SelectData(STR & " WHERE  SUP_STAT='" & e.Node.Tag & "'")
        '            End If
        '    End Select
        'End If
        'dg_data.DataSource = DT
    End Sub

    Private Sub dg_data_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dg_data.RowsAdded
        'MAIN_FRM.dgRow.Text = dg_data.Rows.Count
    End Sub
End Class