Public Class frmRegister

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Function InitLicenseObject() As License
        Dim license As New License
        With license
            .LicenseName = txtName.Text
            .LicenseKey = txtKey.Text
            .Token = txtToken.Text
        End With
        Return license
    End Function

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnGenerateName_Click(sender As Object, e As EventArgs) Handles btnGenerateName.Click
        Dim Server As String = String.Empty
        Dim instance As Sql.SqlDataSourceEnumerator = Sql.SqlDataSourceEnumerator.Instance
        Dim table As System.Data.DataTable = instance.GetDataSources()
        For Each row As System.Data.DataRow In table.Rows
            Server = String.Empty
            Server = row("ServerName")
            If row("InstanceName").ToString.Length > 0 Then
                Server = Server & "\" & row("InstanceName")
            End If
            txtName.Text = Server
        Next
        btnGenerateKey.Enabled = True
    End Sub

    Private Sub btnGenerateKey_Click(sender As Object, e As EventArgs) Handles btnGenerateKey.Click
        txtKey.Text = GetSerialNumberHDD()
        txtToken.Text = DoEncode(MyByte(txtKey.Text))
        btnRegister.Enabled = True
    End Sub

    Private Sub btnRegister_Click_1(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim iLicense As ILicense = New LicenseImpl
        'iLicense.Insert(InitLicenseObject)
        iLicense.PutLicense(InitLicenseObject.LicenseName, InitLicenseObject.LicenseKey, InitLicenseObject.Token)
        MessageBox.Show("Your system was registered")
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm(txtKey)
        ClearForm(txtName)
        ClearForm(txtToken)
        btnGenerateName.Enabled = True
    End Sub
End Class