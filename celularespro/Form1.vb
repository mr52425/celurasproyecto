Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub MisiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisiónToolStripMenuItem.Click
        Mision.Show()
        Me.Hide()
    End Sub

    Private Sub QuienesSomosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuienesSomosToolStripMenuItem.Click
        Mision.Show()
    End Sub
End Class
