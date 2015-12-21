Public Interface IEmployee
    Sub Insert(ByVal employee As Employee)
    Sub Insert(ByVal address As EmployeeAddress)
    Sub Insert(ByVal pob As PlaceOfBirth)
    Sub Update(ByVal empID As String, ByVal address As EmployeeAddress)
    Sub Update(ByVal empID As String, ByVal pob As PlaceOfBirth)
    Sub Update(ByVal id As String, ByVal employee As Employee)
    Sub Delete(ByVal id As String)
    Sub Delete(ByVal empID As String, ByVal table As String)
    Sub Show(ByVal dataGridView As DataGridView, ByVal sql As String)
    Sub Show(ByVal dataGridView As DataGridView)
    Sub Search(ByVal id As String, ByVal dataGridView As DataGridView)
    Function GetID() As Long
    Function SetAutoID(ByVal val As Long) As String
End Interface
