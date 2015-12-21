Public Class frmAddHoliday
    Dim holiday As New Holiday
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub dtpFrom_TextChanged(sender As Object, e As EventArgs) Handles dtpFrom.TextChanged
        txtTotal.Text = holiday.DoCalculateDay(dtpFrom, dtpTo)
    End Sub

    Private Sub dtpTo_TextChanged(sender As Object, e As EventArgs) Handles dtpTo.TextChanged
        txtTotal.Text = holiday.DoCalculateDay(dtpFrom, dtpTo)
    End Sub

    Private Sub txtHolidayName_GotFocus(sender As Object, e As EventArgs) Handles txtHolidayName.GotFocus
        SwitchLanguage("kh")
    End Sub
    Private Sub txtHolidayName_TextChanged(sender As Object, e As EventArgs) Handles txtHolidayName.TextChanged
        txtTotal.Text = holiday.DoCalculateDay(dtpFrom, dtpTo)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            holiday.Insert(txtHolidayName.Text, dtpFrom.Text, dtpTo.Text, txtTotal.Text)
            ClearForm(GroupBox1)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        holiday.Update(PayrollUtils.GetValue, txtHolidayName.Text, dtpFrom.Text, dtpTo.Text, txtTotal.Text)
        ClearForm(GroupBox1)
    End Sub

    Private Sub frmAddHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmHoliday.btnNew.Pressed = True Then
            btnSave.Enabled = True
            btnUpdate.Enabled = False
        Else
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        End If
    End Sub
End Class