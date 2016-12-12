<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtimKH
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
        Me.btquaylai = New System.Windows.Forms.Button()
        Me.bttimtheoMAKH = New System.Windows.Forms.Button()
        Me.dgvkhachhang = New System.Windows.Forms.DataGridView()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttimtheoHOTEN = New System.Windows.Forms.Button()
        Me.btxemtatca = New System.Windows.Forms.Button()
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btquaylai
        '
        Me.btquaylai.Location = New System.Drawing.Point(298, 88)
        Me.btquaylai.Name = "btquaylai"
        Me.btquaylai.Size = New System.Drawing.Size(81, 39)
        Me.btquaylai.TabIndex = 6
        Me.btquaylai.Text = "Quay lại"
        Me.btquaylai.UseVisualStyleBackColor = True
        '
        'bttimtheoMAKH
        '
        Me.bttimtheoMAKH.Location = New System.Drawing.Point(424, 19)
        Me.bttimtheoMAKH.Name = "bttimtheoMAKH"
        Me.bttimtheoMAKH.Size = New System.Drawing.Size(81, 24)
        Me.bttimtheoMAKH.TabIndex = 2
        Me.bttimtheoMAKH.Text = "Tìm mã KH"
        Me.bttimtheoMAKH.UseVisualStyleBackColor = True
        '
        'dgvkhachhang
        '
        Me.dgvkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvkhachhang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkhachhang.Location = New System.Drawing.Point(2, 133)
        Me.dgvkhachhang.Name = "dgvkhachhang"
        Me.dgvkhachhang.Size = New System.Drawing.Size(557, 157)
        Me.dgvkhachhang.TabIndex = 7
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(95, 22)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(323, 20)
        Me.txtmakh.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng:"
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(95, 62)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(323, 20)
        Me.txthoten.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên khách hàng:"
        '
        'bttimtheoHOTEN
        '
        Me.bttimtheoHOTEN.Location = New System.Drawing.Point(424, 59)
        Me.bttimtheoHOTEN.Name = "bttimtheoHOTEN"
        Me.bttimtheoHOTEN.Size = New System.Drawing.Size(81, 24)
        Me.bttimtheoHOTEN.TabIndex = 4
        Me.bttimtheoHOTEN.Text = "Tìm tên KH"
        Me.bttimtheoHOTEN.UseVisualStyleBackColor = True
        '
        'btxemtatca
        '
        Me.btxemtatca.Location = New System.Drawing.Point(176, 88)
        Me.btxemtatca.Name = "btxemtatca"
        Me.btxemtatca.Size = New System.Drawing.Size(81, 39)
        Me.btxemtatca.TabIndex = 5
        Me.btxemtatca.Text = "Xem tất cả"
        Me.btxemtatca.UseVisualStyleBackColor = True
        '
        'frmtimKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(561, 292)
        Me.Controls.Add(Me.bttimtheoHOTEN)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btxemtatca)
        Me.Controls.Add(Me.btquaylai)
        Me.Controls.Add(Me.bttimtheoMAKH)
        Me.Controls.Add(Me.dgvkhachhang)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmtimKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm khách hàng"
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btquaylai As Button
    Friend WithEvents bttimtheoMAKH As Button
    Friend WithEvents dgvkhachhang As DataGridView
    Friend WithEvents txtmakh As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txthoten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bttimtheoHOTEN As Button
    Friend WithEvents btxemtatca As Button
End Class
