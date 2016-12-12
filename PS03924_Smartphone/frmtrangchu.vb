Public Class frmtrangchu
    Private Sub ThôngTinSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinSảnPhẩmToolStripMenuItem.Click
        frmthongtinSP.Show()
        Me.Hide()
    End Sub

    Private Sub TìmSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmSảnPhẩmToolStripMenuItem.Click
        frmtimSP.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinKháchHàngToolStripMenuItem.Click
        frmthongtinKH.Show()
        Me.Hide()
    End Sub

    Private Sub TìmKháchHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TìmKháchHàngToolStripMenuItem1.Click
        frmtimKH.Show()
        Me.Hide()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        frmhoadon.Show()
        Me.Hide()
    End Sub

    Private Sub frmtrangchu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        frmlogin.Show()
        Me.Close()
    End Sub
End Class