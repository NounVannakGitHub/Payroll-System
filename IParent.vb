Public Interface IParent
    Sub Insert(dad As Father)
    Sub Update(empID As String, dad As Father)
    Sub Insert(mom As Mother)
    Sub Update(empID As String, mom As Mother)
    Sub Delete(empID As String, table As String)
    Sub Show(empID As String, table As String, dataGridView As DataGridView)
End Interface
