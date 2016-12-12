Imports System.Data.SqlClient

Public Class frmtimKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLyDT.mssql.somee.com;packet size=4096;user id=ngahtkps039024_SQLLogin_1;pwd=sv1ud7z6nt;data source=QuanLyDT.mssql.somee.com;persist security info=False;initial catalog=QuanLyDT"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH', HOTEN as 'Tên KH', DIENTHOAI as 'Số ĐT', DIACHI as 'Địa chỉ', EMAIL as 'EMAIL' from KHACH_HANG", conn)
        db.Clear()
        load.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub frmtimKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btxemtatca_Click(sender As Object, e As EventArgs) Handles btxemtatca.Click
        LoadData()
    End Sub

    Private Sub bttimtheoMAKH_Click(sender As Object, e As EventArgs) Handles bttimtheoMAKH.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timmakh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' , HOTEN as 'Tên KH', DIENTHOAI as 'Số ĐT', DIACHI as 'Địa chỉ', EMAIL as 'Mail'from KHACH_HANG where MAKH = '" & txtmakh.Text & "'", connect)
        Try
            If txtmakh.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvkhachhang.DataSource = Nothing
                timmakh.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvkhachhang.DataSource = db.DefaultView
                    txtmakh.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtmakh.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bttimtheoHOTEN_Click(sender As Object, e As EventArgs) Handles bttimtheoHOTEN.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timhoten As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' , HOTEN as 'Tên KH', DIENTHOAI as 'Số ĐT', DIACHI as 'Địa chỉ', EMAIL as 'Mail' from KHACH_HANG where HOTEN like '%" & txthoten.Text & "%'", connect)
        Try
            If txthoten.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvkhachhang.DataSource = Nothing
                timhoten.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvkhachhang.DataSource = db.DefaultView
                    txthoten.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txthoten.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btquaylai_Click(sender As Object, e As EventArgs) Handles btquaylai.Click
        frmtrangchu.Show()
        Me.Hide()
    End Sub

End Class