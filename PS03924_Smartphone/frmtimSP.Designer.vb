<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtimSP
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
        Me.bttimmasp = New System.Windows.Forms.Button()
        Me.dgvsanpham = New System.Windows.Forms.DataGridView()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttimtensp = New System.Windows.Forms.Button()
        Me.btxemtatca = New System.Windows.Forms.Button()
        CType(Me.dgvsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btquaylai
        '
        Me.btquaylai.Location = New System.Drawing.Point(297, 105)
        Me.btquaylai.Name = "btquaylai"
        Me.btquaylai.Size = New System.Drawing.Size(81, 51)
        Me.btquaylai.TabIndex = 6
        Me.btquaylai.Text = "Quay lại"
        Me.btquaylai.UseVisualStyleBackColor = True
        '
        'bttimmasp
        '
        Me.bttimmasp.Location = New System.Drawing.Point(382, 11)
        Me.bttimmasp.Name = "bttimmasp"
        Me.bttimmasp.Size = New System.Drawing.Size(81, 29)
        Me.bttimmasp.TabIndex = 2
        Me.bttimmasp.Text = "Tìm mã SP"
        Me.bttimmasp.UseVisualStyleBackColor = True
        '
        'dgvsanpham
        '
        Me.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvsanpham.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsanpham.Location = New System.Drawing.Point(2, 162)
        Me.dgvsanpham.Name = "dgvsanpham"
        Me.dgvsanpham.Size = New System.Drawing.Size(557, 188)
        Me.dgvsanpham.TabIndex = 7
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(136, 63)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(240, 20)
        Me.txttensp.TabIndex = 3
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(136, 16)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(240, 20)
        Me.txtmasp.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên sản phẩm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sản phẩm:"
        '
        'bttimtensp
        '
        Me.bttimtensp.Location = New System.Drawing.Point(382, 58)
        Me.bttimtensp.Name = "bttimtensp"
        Me.bttimtensp.Size = New System.Drawing.Size(81, 29)
        Me.bttimtensp.TabIndex = 4
        Me.bttimtensp.Text = "Tìm tên SP"
        Me.bttimtensp.UseVisualStyleBackColor = True
        '
        'btxemtatca
        '
        Me.btxemtatca.Location = New System.Drawing.Point(178, 105)
        Me.btxemtatca.Name = "btxemtatca"
        Me.btxemtatca.Size = New System.Drawing.Size(81, 51)
        Me.btxemtatca.TabIndex = 5
        Me.btxemtatca.Text = "Xem tất cả"
        Me.btxemtatca.UseVisualStyleBackColor = True
        '
        'frmtimSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(560, 353)
        Me.Controls.Add(Me.btxemtatca)
        Me.Controls.Add(Me.btquaylai)
        Me.Controls.Add(Me.bttimtensp)
        Me.Controls.Add(Me.bttimmasp)
        Me.Controls.Add(Me.dgvsanpham)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmtimSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm sản phẩm"
        CType(Me.dgvsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btquaylai As Button
    Friend WithEvents bttimmasp As Button
    Friend WithEvents dgvsanpham As DataGridView
    Friend WithEvents txttensp As TextBox
    Friend WithEvents txtmasp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bttimtensp As Button
    Friend WithEvents btxemtatca As Button
End Class
