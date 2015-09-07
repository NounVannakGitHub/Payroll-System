Public Class frmEmployee

    Private Sub frmEmployee_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtID_GotFocus(sender As Object, e As EventArgs) Handles txtID.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtfName_GotFocus(sender As Object, e As EventArgs) Handles txtfName.GotFocus
        SwitchLanguage("kh")
    End Sub
End Class