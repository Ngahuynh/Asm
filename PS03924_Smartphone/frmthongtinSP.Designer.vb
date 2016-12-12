<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmthongtinSP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btquaylai = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.dgvsanpham = New System.Windows.Forms.DataGridView()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.txtmaloaisp = New System.Windows.Forms.TextBox()
        Me.txtgiasp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttenloaisp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btquaylai
        '
        Me.btquaylai.Location = New System.Drawing.Point(443, 142)
        Me.btquaylai.Name = "btquaylai"
        Me.btquaylai.Size = New System.Drawing.Size(81, 24)
        Me.btquaylai.TabIndex = 9
        Me.btquaylai.Text = "Quay lại"
        Me.btquaylai.UseVisualStyleBackColor = True
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(309, 142)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(81, 24)
        Me.btSua.TabIndex = 8
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(175, 142)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(81, 24)
        Me.btXoa.TabIndex = 7
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(41, 142)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(81, 24)
        Me.btThem.TabIndex = 6
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'dgvsanpham
        '
        Me.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvsanpham.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsanpham.Location = New System.Drawing.Point(1, 176)
        Me.dgvsanpham.Name = "dgvsanpham"
        Me.dgvsanpham.Size = New System.Drawing.Size(557, 188)
        Me.dgvsanpham.TabIndex = 10
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(98, 67)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(187, 20)
        Me.txttensp.TabIndex = 2
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(98, 20)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(187, 20)
        Me.txtmasp.TabIndex = 1
        '
        'txtmaloaisp
        '
        Me.txtmaloaisp.Location = New System.Drawing.Point(390, 20)
        Me.txtmaloaisp.Name = "txtmaloaisp"
        Me.txtmaloaisp.Size = New System.Drawing.Size(134, 20)
        Me.txtmaloaisp.TabIndex = 4
        '
        'txtgiasp
        '
        Me.txtgiasp.Location = New System.Drawing.Point(98, 113)
        Me.txtgiasp.Name = "txtgiasp"
        Me.txtgiasp.Size = New System.Drawing.Size(187, 20)
        Me.txtgiasp.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mã loại SP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Giá sản phẩm:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên sản phẩm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sản phẩm:"
        '
        'txttenloaisp
        '
        Me.txttenloaisp.Location = New System.Drawing.Point(390, 67)
        Me.txttenloaisp.Name = "txttenloaisp"
        Me.txttenloaisp.Size = New System.Drawing.Size(134, 20)
        Me.txttenloaisp.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tên loại SP:"
        '
        'frmthongtinSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(560, 367)
        Me.Controls.Add(Me.txttenloaisp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btquaylai)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btThem)
        Me.Controls.Add(Me.dgvsanpham)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.txtmaloaisp)
        Me.Controls.Add(Me.txtgiasp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmthongtinSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin sản phẩm"
        CType(Me.dgvsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btquaylai As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
    Friend WithEvents dgvsanpham As DataGridView
    Friend WithEvents txttensp As TextBox
    Friend WithEvents txtmasp As TextBox
    Friend WithEvents txtmaloaisp As TextBox
    Friend WithEvents txtgiasp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttenloaisp As TextBox
    Friend WithEvents Label5 As Label
End Class
