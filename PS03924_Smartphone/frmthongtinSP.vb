Imports System.Data.SqlClient

Public Class frmthongtinSP

    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLyDT.mssql.somee.com;packet size=4096;user id=ngahtkps039024_SQLLogin_1;pwd=sv1ud7z6nt;data source=QuanLyDT.mssql.somee.com;persist security info=False;initial catalog=QuanLyDT"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim LoadSP As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MASP as 'Mã SP', SAN_PHAM.TENSP as 'Tên SP', SAN_PHAM.GIA as 'Giá SP', LOAI_SAN_PHAM.MALOAI_SP as 'Mã loại SP', LOAI_SAN_PHAM.TENLOAI_SP as 'Tên loại SP' from SAN_PHAM inner join LOAI_SAN_PHAM ON SAN_PHAM.MALOAI_SP = LOAI_SAN_PHAM.MALOAI_SP", conn)
        db.Clear()
        LoadSP.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub dgvsanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsanpham.CellContentClick
        Dim click As Integer = dgvsanpham.CurrentCell.RowIndex
        txtmasp.Text = dgvsanpham.Item(0, click).Value
        txttensp.Text = dgvsanpham.Item(1, click).Value
        txtgiasp.Text = dgvsanpham.Item(2, click).Value
        txtmaloaisp.Text = dgvsanpham.Item(3, click).Value
        txttenloaisp.Text = dgvsanpham.Item(4, click).Value
    End Sub

    Private Sub frmthongtinSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SAN_PHAM values(@MASP,@TENSP,@GIA,@MALOAI_SP) insert into LOAI_SAN_PHAM values(@MALOAI_SP,@TENLOAI_SP)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtmasp.Focus()
            If txtmasp.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmasp.Focus()
                If txttensp.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txttensp.Focus()
                    If txtgiasp.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập giá sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtgiasp.Focus()
                        If txtmaloaisp.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mã loại sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtmaloaisp.Focus()
                            If txttenloaisp.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập tên loại sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MASP", txtmasp.Text)
                                save.Parameters.AddWithValue("@TENSP", txttensp.Text)
                                save.Parameters.AddWithValue("@GIA", txtgiasp.Text)
                                save.Parameters.AddWithValue("@MALOAI_SP", txtmaloaisp.Text)
                                save.Parameters.AddWithValue("@TENLOAI_SP", txttenloaisp.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtmasp.Text = Nothing
                                txttensp.Text = Nothing
                                txtgiasp.Text = Nothing
                                txtmaloaisp.Text = Nothing
                                txttenloaisp.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MASP as 'Mã SP', SAN_PHAM.TENSP as 'Tên SP', SAN_PHAM.GIA as 'Giá SP', LOAI_SAN_PHAM.MALOAI_SP as 'Mã loại SP', LOAI_SAN_PHAM.TENLOAI_SP as 'Tên loại SP' from SAN_PHAM inner join LOAI_SAN_PHAM ON SAN_PHAM.MALOAI_SP = LOAI_SAN_PHAM.MALOAI_SP", conn)
        db.Clear()
        refesh.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim delquery As String = "delete from SAN_PHAM where MALOAI_SP=@MALOAI_SP delete from LOAI_SAN_PHAM where MALOAI_SP=@MALOAI_SP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạnn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmasp.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmasp.Focus()
            Else
                If resulft = DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MALOAI_sP", txtmaloaisp.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmasp.Text = Nothing
                    txttensp.Text = Nothing
                    txtgiasp.Text = Nothing
                    txtmaloaisp.Text = Nothing
                    txttenloaisp.Text = Nothing
                    txtmasp.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        'làm mới bảng
        db.Clear()
        dgvsanpham.DataSource = db
        dgvsanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SAN_PHAM set MASP=N'" & txtmasp.Text & "', TENSP=N'" & txttensp.Text & "', GIA=N'" & txtgiasp.Text & "' where MASP=N'" & txtmasp.Text & "' update LOAI_SAN_PHAM set MALOAI_SP=N'" & txtmaloaisp.Text & "',TENLOAI_SP=N'" & txttenloaisp.Text & "' where MALOAI_SP=N'" & txtmaloaisp.Text & "'"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtmasp.Focus()
            If txtmasp.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmasp.Focus()
                If txttensp.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txttensp.Focus()
                    If txtgiasp.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtgiasp.Focus()
                        If txtmaloaisp.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            txtmaloaisp.Focus()
                        Else
                            If txttenloaisp.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập Tên hãng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                txttenloaisp.Focus()
                            Else
                                addupdate.Parameters.AddWithValue("@MASP", txtmasp.Text)
                                addupdate.Parameters.AddWithValue("@TENSP", txttensp.Text)
                                addupdate.Parameters.AddWithValue("@GIA", txtgiasp.Text)
                                addupdate.Parameters.AddWithValue("@MALOAI_SP", txtmaloaisp.Text)
                                addupdate.Parameters.AddWithValue("@TENLOAI_SP", txttenloaisp.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'dóng k?t n?i
                                MessageBox.Show("Cập nhật thành công")
                                txtmasp.Text = Nothing
                                txttensp.Text = Nothing
                                txtgiasp.Text = Nothing
                                txtmaloaisp.Text = Nothing
                                txttenloaisp.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi sửa xong sẽ tụ làm mới lại bảng
        db.Clear()
        dgvsanpham.DataSource = db
        dgvsanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btquaylai_Click(sender As Object, e As EventArgs) Handles btquaylai.Click
        frmtrangchu.Show()
        Me.Hide()
    End Sub
End Class