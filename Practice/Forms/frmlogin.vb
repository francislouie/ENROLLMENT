Public Class frmlogin
    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectDatabase()
        frmmain.Show()
        frmmain.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        querylogin()
        clearfields()
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class