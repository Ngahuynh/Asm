<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Me.btxemtatca = New System.Windows.Forms.Button()
        Me.btquaylai = New System.Windows.Forms.Button()
        Me.bttimmahd = New System.Windows.Forms.Button()
        Me.dgvhoadon = New System.Windows.Forms.DataGridView()
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvhoadon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btxemtatca
        '
        Me.btxemtatca.Location = New System.Drawing.Point(178, 44)
        Me.btxemtatca.Name = "btxemtatca"
        Me.btxemtatca.Size = New System.Drawing.Size(81, 51)
        Me.btxemtatca.TabIndex = 3
        Me.btxemtatca.Text = "Xem tất cả"
        Me.btxemtatca.UseVisualStyleBackColor = True
        '
        'btquaylai
        '
        Me.btquaylai.Location = New System.Drawing.Point(297, 44)
        Me.btquaylai.Name = "btquaylai"
        Me.btquaylai.Size = New System.Drawing.Size(81, 51)
        Me.btquaylai.TabIndex = 4
        Me.btquaylai.Text = "Quay lại"
        Me.btquaylai.UseVisualStyleBackColor = True
        '
        'bttimmahd
        '
        Me.bttimmahd.Location = New System.Drawing.Point(382, 13)
        Me.bttimmahd.Name = "bttimmahd"
        Me.bttimmahd.Size = New System.Drawing.Size(81, 29)
        Me.bttimmahd.TabIndex = 2
        Me.bttimmahd.Text = "Tìm mã HD"
        Me.bttimmahd.UseVisualStyleBackColor = True
        '
        'dgvhoadon
        '
        Me.dgvhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvhoadon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhoadon.Location = New System.Drawing.Point(2, 101)
        Me.dgvhoadon.Name = "dgvhoadon"
        Me.dgvhoadon.Size = New System.Drawing.Size(557, 188)
        Me.dgvhoadon.TabIndex = 5
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(136, 18)
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.Size = New System.Drawing.Size(240, 20)
        Me.txtmahd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn:"
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(561, 292)
        Me.Controls.Add(Me.btxemtatca)
        Me.Controls.Add(Me.btquaylai)
        Me.Controls.Add(Me.bttimmahd)
        Me.Controls.Add(Me.dgvhoadon)
        Me.Controls.Add(Me.txtmahd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmhoadon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chi tiết hóa đơn"
        CType(Me.dgvhoadon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btxemtatca As Button
    Friend WithEvents btquaylai As Button
    Friend WithEvents bttimmahd As Button
    Friend WithEvents dgvhoadon As DataGridView
    Friend WithEvents txtmahd As TextBox
    Friend WithEvents Label1 As Label
End Class
