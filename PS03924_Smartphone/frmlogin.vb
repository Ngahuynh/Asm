Imports System.Data.SqlClient

Public Class frmlogin

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        Dim conn As New SqlConnection("workstation id=SmartPhone.mssql.somee.com;packet size=4096;user id=ps03937_SQLLogin_1;pwd=Nhocaxq4;data source=SmartPhone.mssql.somee.com;persist security info=False;initial catalog=SmartPhone")
        Dim laydulieu = New SqlDataAdapter("select * from LOGIN where ID='" & txtuser.Text & "' and PASSWORD='" & txtpwd.Text & "'", conn)
        Dim tb As New DataTable()
        Try
            conn.Open()
            laydulieu.Fill(tb)
            conn.Close()
        Catch ex As Exception

        End Try
        If (tb.Rows.Count > 0) Then
            Dim f As New frmtrangchu()
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show("Bạn đã nhập sai Username or password")
        End If
    End Sub

    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Me.Close()
    End Sub
End Class