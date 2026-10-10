Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim frm As New Register()
        frm.Show()
    End Sub


    Private Sub AssignToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignToToolStripMenuItem.Click
        Dim frm As New Assign()
        frm.Show()
    End Sub

    Private Sub UpdateDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDetailsToolStripMenuItem.Click
        Dim frm As New Update()
        frm.Show()
    End Sub

    Private Sub ComplaintsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplaintsToolStripMenuItem.Click
        Dim frm As New Log()
        frm.Show()
    End Sub

End Class
