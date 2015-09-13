Public Class frmAttendance

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlAttendenceInformation.Height = 40
        Label1.Height = 25
    End Sub

    Private Sub tbtnNew_Click(sender As Object, e As EventArgs) Handles tbtnNew.Click
        frmAddAttendance.ShowDialog()
    End Sub

    Private Sub tbtnEdit_Click(sender As Object, e As EventArgs) Handles tbtnEdit.Click
        frmEditAttendance.ShowDialog()
    End Sub
End Class