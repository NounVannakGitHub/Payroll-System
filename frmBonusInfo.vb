Public Class frmBonusInfo

    Private Sub frmBonusInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlBonusInformation.Height = 40
        Label1.Height = 25
    End Sub

    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        Me.Close()
    End Sub

    Private Sub tbtnNew_Click(sender As Object, e As EventArgs) Handles tbtnNew.Click
        frmAddbonus.ShowDialog()
    End Sub

    Private Sub tbtnEdit_Click(sender As Object, e As EventArgs) Handles tbtnEdit.Click
        frmEditBonus.ShowDialog()
    End Sub
End Class