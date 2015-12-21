Public Class frmPrintSalaryPaySlip
    Private Sub frmPrintSalaryPaySlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim control() As String = {frmSalaryPaySlip.txtBasicSalary.Text, frmSalaryPaySlip.txtAnnualAward.Text, frmSalaryPaySlip.txtAdjust.Text, frmSalaryPaySlip.txtIncre.Text, frmSalaryPaySlip.txtDecre.Text, frmSalaryPaySlip.txtSalary13.Text, frmSalaryPaySlip.txtSalary14.Text, frmSalaryPaySlip.txtNetBase.Text, frmSalaryPaySlip.txtIncentive.Text, frmSalaryPaySlip.txtReginal.Text, frmSalaryPaySlip.txtTransport.Text, frmSalaryPaySlip.txtOverTime.Text, frmSalaryPaySlip.txtSubTotal.Text, frmSalaryPaySlip.txtLastName.Text, frmSalaryPaySlip.txtFirstName.Text, frmSalaryPaySlip.dtpTo.Text, GetFieldValue("tblWorkInformation", "Position", frmSalaryPaySlip.cboEmpId.Text)}
        Dim parameter() As String = {"a", "b", "c", "d", "d1", "e", "e1", "f", "g", "i", "h", "j", "k", "LName", "FName", "DateTo", "Position"}
        DoShowReport(rptSalaryPaySlip, "rptSalaryPaySlip.rpt", parameter, control)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class