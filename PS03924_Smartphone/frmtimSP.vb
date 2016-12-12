Imports System.Data.SqlClient

Public Class frmtimSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLyDT.mssql.somee.com;packet size=4096;user id=ngahtkps039024_SQLLogin_1;pwd=sv1ud7z6nt;data source=QuanLyDT.mssql.somee.com;persist security info=False;initial catalog=QuanLyDT"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("Select SAN_PHAM.MASP as 'Mã SP', SAN_PHAM.TENSP as 'Tên SP', SAN_PHAM.GIA as 'Giá SP', LOAI_SAN_PHAM.MALOAI_SP as 'Mã loại SP', LOAI_SAN_PHAM.TENLOAI_SP as 'Tên loại SP' from SAN_PHAM inner join LOAI_SAN_PHAM ON SAN_PHAM.MALOAI_SP = LOAI_SAN_PHAM.MALOAI_SP", conn)
        db.Clear()
        load.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub frmtimSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btxemtatca_Click(sender As Object, e As EventArgs) Handles btxemtatca.Click
        LoadData()
    End Sub

    Private Sub bttimmasp_Click(sender As Object, e As EventArgs) Handles bttimmasp.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timmasp As SqlDataAdapter = New SqlDataAdapter("Select SAN_PHAM.MASP as 'Mã SP', SAN_PHAM.TENSP as 'Tên SP', SAN_PHAM.GIA as 'Giá SP', LOAI_SAN_PHAM.MALOAI_SP as 'Mã loại SP', LOAI_SAN_PHAM.TENLOAI_SP as 'Tên loại SP' from SAN_PHAM inner join LOAI_SAN_PHAM ON SAN_PHAM.MALOAI_SP = LOAI_SAN_PHAM.MALOAI_SP where MASP = '" & txtmasp.Text & "'", connect)
        Try
            If txtmasp.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvsanpham.DataSource = Nothing
                timmasp.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvsanpham.DataSource = db.DefaultView
                    txtmasp.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtmasp.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bttimtensp_Click(sender As Object, e As EventArgs) Handles bttimtensp.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timtensp As SqlDataAdapter = New SqlDataAdapter("Select SAN_PHAM.MASP as 'Mã SP', SAN_PHAM.TENSP as 'Tên SP', SAN_PHAM.GIA as 'Giá SP', LOAI_SAN_PHAM.MALOAI_SP as 'Mã loại SP', LOAI_SAN_PHAM.TENLOAI_SP as 'Tên loại SP' from SAN_PHAM inner join LOAI_SAN_PHAM ON SAN_PHAM.MALOAI_SP = LOAI_SAN_PHAM.MALOAI_SP where TENSP like '%" & txttensp.Text & "%'", connect)
        Try
            If txttensp.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvsanpham.DataSource = Nothing
                timtensp.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvsanpham.DataSource = db.DefaultView
                    txttensp.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txttensp.Text = Nothing
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