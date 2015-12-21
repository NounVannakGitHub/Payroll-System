Public Interface ISalary
    Sub Show(dgv As DataGridView)
    Sub Search(empId As String, dgv As DataGridView)
    Sub Insert(salary As Salary)
    Sub Insert(table As String, salary As Salary)
    Sub Delete(id As String)
    Sub Delete(id As String, table As String)
End Interface
