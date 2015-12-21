Public Interface IChild

    Sub Insert(ByVal child As Child)
    Sub Delete(ByVal id As String)
    Sub Delete(empId As String, Id As String)
    Sub Update(ByVal child As Child, ByVal empID As String, ByVal id As String)
    Sub Show(ByVal empID As String, dataGridView As DataGridView)
    Sub Search(ByVal id As String)
    Sub AddToDataGridView(ByVal dataGridView As DataGridView, ByVal frmAddEmployee As frmAddEmployee)
End Interface
