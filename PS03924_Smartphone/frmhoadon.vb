Imports System.Data.SqlClient

Public Class frmhoadon
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLyDT.mssql.somee.com;packet size=4096;user id=ngahtkps039024_SQLLogin_1;pwd=sv1ud7z6nt;data source=QuanLyDT.mssql.somee.com;persist security info=False;initial catalog=QuanLyDT"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAhd as 'Mã hóa đơn', MASP as 'Mã sản phẩm', SOLUONG as 'Số lượng' from CHI_TIET_HOA_DON", conn)
        db.Clear()
        load.Fill(db)
        dgvhoadon.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub frmhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    Private Sub btxemtatca_Click(sender As Object, e As EventArgs) Handles btxemtatca.Click
        LoadData()
    End Sub

    Private Sub bttimmahd_Click(sender As Object, e As EventArgs) Handles bttimmahd.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timmahd As SqlDataAdapter = New SqlDataAdapter("select MAhd as 'Mã hóa đơn', MASP as 'Mã sản phẩm', SOLUONG as 'Số lượng' from CHI_TIET_HOA_DON where MAHD = '" & txtmahd.Text & "'", connect)
        Try
            If txtmahd.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvhoadon.DataSource = Nothing
                timmahd.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvhoadon.DataSource = db.DefaultView
                    txtmahd.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtmahd.Text = Nothing
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