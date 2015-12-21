Public Interface IWorkInfomation
    Sub Show(ByVal dataGridView As DataGridView)
    Sub Show(ByVal empID As String, ByVal dataGridView As DataGridView)
    Sub Insert(ByVal workinfo As WorkInformation)
    Sub Update(ByVal empID As String, ByVal workInfo As WorkInformation)
    Sub Delete(ByVal empID As String)
End Interface
