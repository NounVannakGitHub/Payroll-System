Public Class Permission
    Sub Insert(position As String, a As String, b As String, c As String, d As String, e As String, f As String, g As String, h As String, i As String, j As String, k As String, l As String, m As String, n As String, o As String, p As String, q As String, r As String, s As String, t As String, u As String, v As String, w As String, x As String, y As String, z As String, aa As String, ab As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "insert into tblPermission (Position,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,aa,ab) values ('" & position & "','" & a & "','" & b & "','" & c & "','" & d & "','" & e & "','" & f & "','" & g & "','" & h & "','" & i & "','" & j & "','" & k & "','" & l & "','" & m & "','" & n & "','" & o & "','" & p & "','" & q & "','" & r & "','" & s & "','" & t & "','" & u & "','" & v & "','" & w & "','" & x & "','" & y & "','" & z & "','" & aa & "','" & ab & "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("dapartment was inserted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Show(dgv As DataGridView)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "select * from tblPermission"
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            cmd.Dispose()
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub

    Sub Delete(department As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "delete tblPermission where Position='" & department & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("dapartment was deleted!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
    Sub Update(position As String, a As String, b As String, c As String, d As String, e As String, f As String, g As String, h As String, i As String, j As String, k As String, l As String, m As String, n As String, o As String, p As String, q As String, r As String, s As String, t As String, u As String, v As String, w As String, x As String, y As String, z As String, aa As String, ab As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Connection()
            cmd.CommandText = "update tblPermission set a='" & a & "',b='" & b & "',c='" & c & "',d='" & d & "',e='" & e & "',f='" & f & "',g='" & g & "',h='" & h & "',i='" & i & "',j='" & j & "',k='" & k & "',l='" & l & "',m='" & m & "',n='" & n & "',o='" & o & "',p='" & p & "',q='" & q & "',r='" & r & "',s='" & s & "',t='" & t & "',u='" & u & "',v='" & v & "',w='" & w & "',x='" & x & "',y='" & y & "',z='" & z & "',aa='" & aa & "','" & ab & "' where Position='" & position & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            SetProcessStatus("dapartment was updated!")
        Catch ex As Exception
            SetProcessStatus(ex.Message)
        End Try
    End Sub
End Class
