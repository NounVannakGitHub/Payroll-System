Public Interface IPreAttendance
    Sub Insert(ByVal Preattendance As Preattendance)
    Sub Update(ByVal Preattendance As Preattendance)
    Sub Delete(ByVal Preattendance As Preattendance)
    Sub Show()
    Sub Search()
    Function SelectId() As String
End Interface
