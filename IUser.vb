Public Interface IUser
    Sub Show(dgv As DataGridView)
    Sub Delete(userID As String)
    Sub Search(empId As String, dgv As DataGridView)
    Sub Insert(user As User)
    Sub ChangePassword(userID As String, password As String, conPassword As String)
End Interface
