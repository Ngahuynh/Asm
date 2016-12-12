Imports System.Data.SqlClient
Imports System.Data.DataSet

Public Class frmthongtinKH

    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLyDT.mssql.somee.com;packet size=4096;user id=ngahtkps039024_SQLLogin_1;pwd=sv1ud7z6nt;data source=QuanLyDT.mssql.somee.com;persist security info=False;initial catalog=QuanLyDT"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim LoadKH As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH', HOTEN as 'Tên KH', DIENTHOAI as 'Số ĐT', DIACHI as 'Địa chỉ', EMAIL as 'EMAIL' from KHACH_HANG", conn)
        db.Clear()
        LoadKH.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub dgvkhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkhachhang.CellContentClick
        Dim click As Integer = dgvkhachhang.CurrentCell.RowIndex
        txtmakh.Text = dgvkhachhang.Item(0, click).Value
        txthoten.Text = dgvkhachhang.Item(1, click).Value
        txtdiachi.Text = dgvkhachhang.Item(2, click).Value
        txtdienthoai.Text = dgvkhachhang.Item(3, click).Value
        txtemail.Text = dgvkhachhang.Item(4, click).Value
    End Sub

    Private Sub frmthongtinKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACH_HANG values(@MAKH,@HOTEN,@DIACHI,@DIENTHOAI,@EMAIL)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtmakh.Focus()
            If txtmakh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmakh.Focus()
                If txthoten.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txthoten.Focus()
                    If txtdiachi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtdiachi.Focus()
                        If txtdienthoai.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtdienthoai.Focus()
                            If txtemail.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập Email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MAKH", txtmakh.Text)
                                save.Parameters.AddWithValue("@HOTEN", txthoten.Text)
                                save.Parameters.AddWithValue("@DIENTHOAI", txtdienthoai.Text)
                                save.Parameters.AddWithValue("@DIACHI", txtdiachi.Text)
                                save.Parameters.AddWithValue("@EMAIL", txtemail.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtmakh.Text = Nothing
                                txthoten.Text = Nothing
                                txtdienthoai.Text = Nothing
                                txtdiachi.Text = Nothing
                                txtemail.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH', HOTEN as 'Tên KH', DIENTHOAI as 'Số ĐT', DIACHI as 'Địa Chỉ', EMAIL as 'EMAIL'from KHACH_HANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim delquery As String = "delete from KHACH_HANG where MAKH=@MAKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmakh.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmakh.Focus()
            Else
                If resulft = DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MAKH", txtmakh.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmakh.Text = Nothing
                    txthoten.Text = Nothing
                    txtdienthoai.Text = Nothing
                    txtdiachi.Text = Nothing
                    txtemail.Text = Nothing
                    txtmakh.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        'làm mới bảng
        db.Clear()
        dgvkhachhang.DataSource = db
        dgvkhachhang.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACH_HANG set MAKH=@MAKH, HOTEN=@HOTEN, DIACHI=@DIACHI, DIENTHOAI=@DIENTHOAI, EMAIL=@EMAIL where MAKH=@MAKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtmakh.Focus()
            If txtmakh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmakh.Focus()
                If txthoten.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txthoten.Focus()
                    If txtdiachi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtdiachi.Focus()
                        If txtdienthoai.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtdienthoai.Focus()
                            If txtemail.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập Email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                addupdate.Parameters.AddWithValue("@MAKH", txtmakh.Text)
                                addupdate.Parameters.AddWithValue("@HOTEN", txthoten.Text)
                                addupdate.Parameters.AddWithValue("@DIENTHOAI", txtdienthoai.Text)
                                addupdate.Parameters.AddWithValue("@DIACHI", txtdiachi.Text)
                                addupdate.Parameters.AddWithValue("@EMAIL", txtemail.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtmakh.Text = Nothing
                                txthoten.Text = Nothing
                                txtdienthoai.Text = Nothing
                                txtdiachi.Text = Nothing
                                txtemail.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvkhachhang.DataSource = db
        dgvkhachhang.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btquaylai_Click(sender As Object, e As EventArgs) Handles btquaylai.Click
        frmtrangchu.Show()
        Me.Hide()
    End Sub
End Class
