Public Class SQLValue
    Public Shared Shadows INSERT_LINCENSE As String = "INSERT INTO tblLicense (LicenseName,LicenseCode,LicenseDate) VALUES"
    Public Shared Shadows INSTERT_CHILD As String = "INSERT INTO tblChild (EmployeeID,ChildNo,LastName,FirstName,Gender,Age,Home,Street,City,District,Commune,Village) VALUES "
    Public Shared Shadows DELETE_CHILD As String = "DELETE FROM tblChild WHERE EmployeeID='"
    Public Shared Shadows UPDATE_CHILD As String = "UPDATE tblChild SET "
    Public Shared Shadows SHOW_CHILD As String = "SELECT * FROM tblChild WHERE EmployeeID='"
    Public Shared Shadows SEARCH_CHILD As String = "SELECT * FROM tblChild WHERE EmployeeID='"
End Class
