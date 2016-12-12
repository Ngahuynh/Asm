<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmthongtinKH
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btquaylai = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.dgvkhachhang = New System.Windows.Forms.DataGridView()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtdienthoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(304, 152)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(81, 24)
        Me.btSua.TabIndex = 8
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'btquaylai
        '
        Me.btquaylai.Location = New System.Drawing.Point(434, 152)
        Me.btquaylai.Name = "btquaylai"
        Me.btquaylai.Size = New System.Drawing.Size(81, 24)
        Me.btquaylai.TabIndex = 9
        Me.btquaylai.Text = "Quay lại"
        Me.btquaylai.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(174, 152)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(81, 24)
        Me.btXoa.TabIndex = 7
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(44, 152)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(81, 24)
        Me.btThem.TabIndex = 6
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'dgvkhachhang
        '
        Me.dgvkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvkhachhang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkhachhang.Location = New System.Drawing.Point(2, 187)
        Me.dgvkhachhang.Name = "dgvkhachhang"
        Me.dgvkhachhang.Size = New System.Drawing.Size(557, 188)
        Me.dgvkhachhang.TabIndex = 10
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(100, 114)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(187, 20)
        Me.txtemail.TabIndex = 3
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(100, 67)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(187, 20)
        Me.txthoten.TabIndex = 2
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(100, 20)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(187, 20)
        Me.txtmakh.TabIndex = 1
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(382, 67)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(134, 20)
        Me.txtdiachi.TabIndex = 5
        '
        'txtdienthoai
        '
        Me.txtdienthoai.Location = New System.Drawing.Point(382, 20)
        Me.txtdienthoai.Name = "txtdienthoai"
        Me.txtdienthoai.Size = New System.Drawing.Size(134, 20)
        Me.txtdienthoai.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(336, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Địa chỉ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số điện thoại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Họ và tên:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng:"
        '
        'frmthongtinKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(561, 377)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.btquaylai)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btThem)
        Me.Controls.Add(Me.dgvkhachhang)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtdienthoai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmthongtinKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin khách hàng"
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSua As Button
    Friend WithEvents btquaylai As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
    Friend WithEvents dgvkhachhang As DataGridView
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txthoten As TextBox
    Friend WithEvents txtmakh As TextBox
    Friend WithEvents txtdiachi As TextBox
    Friend WithEvents txtdienthoai As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
