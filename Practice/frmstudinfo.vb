Public Class frmstudinfo

    Private Sub frmstudinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectDatabase()

        createcolumnstudinfo()

        gridstudinfo()

        querydatagrid()

        createcombostudinfo()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If Me.btnadd.Text = "ADD" Then
            Me.btnadd.Text = "SAVE"
            Me.btnedit.Text = "REVERT"

            txtcfname.Enabled = True
            txtclname.Enabled = True
            txtcmname.Enabled = True
            txtcnickname.Enabled = True

            txtbirthplace.Enabled = True
            txtcitizen.Enabled = True
            txtreligion.Enabled = True
            txtheight.Enabled = True
            txtweight.Enabled = True
            txdtpbirthday.Enabled = True
            txcbgender.Enabled = True

            Call autoid()

            txtcfname.Clear()
            txtclname.Clear()
            txtcnickname.Clear()
            txtcmname.Clear()

        ElseIf Me.btnadd.Text = "SAVE" Then
            Me.btnadd.Text = "ADD"
            Me.btnedit.Text = "EDIT"
            queryadd()
            txtcfname.Enabled = False
            txtclname.Enabled = False
            txtcmname.Enabled = False
            txtcnickname.Enabled = False
            clearfields()
            querydatagrid()
            gridstudinfo()
            ' test 
        End If

        If Me.btnadd.Text = "UPDATE" Then
            Me.btnadd.Text = "ADD"
            Me.btnedit.Text = "EDIT"
            txtcfname.Enabled = False
            txtclname.Enabled = False
            txtcmname.Enabled = False
            txtcnickname.Enabled = False
            queryupdate()
            clearfields()
            querydatagrid()

        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If Me.btnedit.Text = "EDIT" Then
            Me.btnadd.Text = "UPDATE"
            Me.btnedit.Text = "REVERT"
            txtcfname.Enabled = True
            txtclname.Enabled = True
            txtcmname.Enabled = True
            txtcnickname.Enabled = True

            'ElseIf Me.btnadd.Text = "UPDATE" Then
            '   Me.btnedit.Text = "EDIT"
            '       ElseIf Me.btnadd.Text = "UPDATE" Then
            '          Me.btnedit.Text = "EDIT"
            '         txtcfname.Enabled = False
            '          txtclname.Enabled = False
            '        txtcmname.Enabled = False
            '        txtcnickname.Enabled = False
            '       queryupdate()
            '       clearfields()
            '      querydatagrid()
       
            '   End If

        ElseIf Me.btnedit.Text = "REVERT" Then
            Me.btnedit.Text = "EDIT"
            Me.btnadd.Text = "ADD"
            txtcfname.Enabled = False
            txtclname.Enabled = False
            txtcmname.Enabled = False
            txtcnickname.Enabled = False
            clearfields()
            querydatagrid()
        End If
    End Sub

    Private Sub datagridstud_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles datagridstud.Click
        querydatagrid()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        querydelete()
        For Each row As DataGridViewRow In datagridstud.SelectedRows
            datagridstud.Rows.Remove(row)
        Next
        clearfields()
    End Sub

End Class