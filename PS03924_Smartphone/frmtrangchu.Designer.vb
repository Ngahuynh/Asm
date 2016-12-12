<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtrangchu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtrangchu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SmartphoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKháchHàngToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTiếtHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmartphoneToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.HóaĐơnToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(652, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SmartphoneToolStripMenuItem
        '
        Me.SmartphoneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinSảnPhẩmToolStripMenuItem, Me.TìmSảnPhẩmToolStripMenuItem})
        Me.SmartphoneToolStripMenuItem.Name = "SmartphoneToolStripMenuItem"
        Me.SmartphoneToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.SmartphoneToolStripMenuItem.Text = "Smartphone"
        '
        'ThôngTinSảnPhẩmToolStripMenuItem
        '
        Me.ThôngTinSảnPhẩmToolStripMenuItem.Name = "ThôngTinSảnPhẩmToolStripMenuItem"
        Me.ThôngTinSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ThôngTinSảnPhẩmToolStripMenuItem.Text = "Thông tin sản phẩm"
        '
        'TìmSảnPhẩmToolStripMenuItem
        '
        Me.TìmSảnPhẩmToolStripMenuItem.Name = "TìmSảnPhẩmToolStripMenuItem"
        Me.TìmSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.TìmSảnPhẩmToolStripMenuItem.Text = "Tìm sản phẩm"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinKháchHàngToolStripMenuItem, Me.TìmKháchHàngToolStripMenuItem1})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'ThôngTinKháchHàngToolStripMenuItem
        '
        Me.ThôngTinKháchHàngToolStripMenuItem.Name = "ThôngTinKháchHàngToolStripMenuItem"
        Me.ThôngTinKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ThôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng"
        '
        'TìmKháchHàngToolStripMenuItem1
        '
        Me.TìmKháchHàngToolStripMenuItem1.Name = "TìmKháchHàngToolStripMenuItem1"
        Me.TìmKháchHàngToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.TìmKháchHàngToolStripMenuItem1.Text = "Tìm khách hàng"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChiTiếtHóaĐơnToolStripMenuItem})
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa đơn"
        '
        'ChiTiếtHóaĐơnToolStripMenuItem
        '
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Name = "ChiTiếtHóaĐơnToolStripMenuItem"
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Text = "Chi tiết hóa đơn"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ThoátToolStripMenuItem.Text = "Đăng xuất"
        '
        'frmtrangchu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(652, 427)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmtrangchu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ứng dụng quản lý sản phẩm Smartphone"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SmartphoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThôngTinSảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TìmSảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThôngTinKháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TìmKháchHàngToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiTiếtHóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
End Class
