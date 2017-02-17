Public Class frmmain

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub STUDENTINFOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STUDENTINFOToolStripMenuItem.Click
        frmstudinfo.Show()
    End Sub


    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        frmlogin.Show()
        Me.Enabled = False
        Me.tsmain.Hide()
    End Sub

End Class
