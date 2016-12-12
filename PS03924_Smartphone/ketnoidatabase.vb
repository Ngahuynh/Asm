Imports System.Data.SqlClient

Public Class ketnoidatabase
    Public Function Loadkhachhang() As DataSet
        Dim chuoiketnoi As String = "workstation id=QuanLyDT.mssql.somee.com;packet size=4096;user id=ngahtkps039024_SQLLogin_1;pwd=sv1ud7z6nt;data source=QuanLyDT.mssql.somee.com;persist security info=False;initial catalog=QuanLyDT"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH', HOTEN as 'Tên KH', DIENTHOAI as 'Số ĐT', DIACHI as 'Địa Chỉ', EMAIL as 'EMAIL'", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function

    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=QuanLyDT.mssql.somee.com;packet size=4096;user id=ngahtkps039024_SQLLogin_1;pwd=sv1ud7z6nt;data source=QuanLyDT.mssql.somee.com;persist security info=False;initial catalog=QuanLyDT"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select MASP as 'Mã SP', TENSP as 'Tên SP', GIA as 'Giá SP', MALOAI_SP as 'Mã loại SP'", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
