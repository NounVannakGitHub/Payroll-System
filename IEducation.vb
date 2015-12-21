Public Interface IEducation
    Sub Insert(ByVal education As Education)
    Sub Update(ByVal empID As String, eduNo As String, education As Education)
    Sub Delete(ByVal empID As String)
    Sub Delete(ByVal empID As String, eduNo As String)
    Sub Show(ByVal empID As String, dataGridView As DataGridView)
End Interface
