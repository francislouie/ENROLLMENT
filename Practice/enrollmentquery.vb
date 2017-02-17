Imports MySql.Data.MySqlClient
Module enrollmentquery
    Dim query, query1
    Public studid, fname, mname, lname, nname, brthplace, gender, citizenshp, religion, height, weight, brthday As String
    Dim uname, pwd As String
    Dim count As Integer

    Public Sub clearfields()
        frmstudinfo.txtcfname.Clear()
        frmstudinfo.txtclname.Clear()
        frmstudinfo.txtcnickname.Clear()
        frmstudinfo.txtcmname.Clear()
        frmstudinfo.txtcstudid.Clear()

        frmlogin.txtusername.Clear()
        frmlogin.txtpassword.Clear()

    End Sub

    Public Sub createcombostudinfo()
        frmstudinfo.txcbgender.Items.Add("MALE")
        frmstudinfo.txcbgender.Items.Add("FEMALE")

    End Sub

    Public Sub querylogin()
        uname = frmlogin.txtusername.Text
        pwd = frmlogin.txtpassword.Text
        Try
            exec_conn.Open()
            query = ("select * from user where username = ? and password = ?")
            exec_command = New MySqlCommand(query, exec_conn)
            exec_command.Parameters.AddWithValue("username", uname)
            exec_command.Parameters.AddWithValue("password", pwd)
            exec_dreader = exec_command.ExecuteReader

            count = 0
            While exec_dreader.Read
                count = count + 1
            End While

            If count = 1 Then
                frmmain.tsmain.Show()
                frmmain.Show()
                frmmain.Enabled = True
                frmlogin.Hide()
                clearfields()

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are Duplicate")
            Else
                MessageBox.Show("Username and Password are not Correct")
            End If
            exec_conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            exec_conn.Dispose()
        End Try

    End Sub

    Public Sub autoid()

        If frmstudinfo.txtcstudid.Text = "" Then
            frmstudinfo.txtcstudid.Text = "S0001"
        Else

            Try
                exec_conn.Open()
                query = ("select MAX(RIGHT(cstudno,4)) from studinfo")
                exec_command = New MySqlCommand(query, exec_conn)
                exec_dreader = exec_command.ExecuteReader
                If exec_dreader.Read() Then
                    Dim number As Integer = exec_dreader.Item(0)
                    number = number + 1
                    Dim emplang As String = "S"
                    Dim append As String = emplang + number.ToString().PadLeft(4, "000")
                    frmstudinfo.txtcstudid.Text = append
                Else
                    Exit Sub
                End If
                exec_conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Public Sub createcolumnstudinfo()
        Dim columnHeaderStyle As New DataGridViewCellStyle()

        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Verdana", 15, FontStyle.Bold)
        frmstudinfo.datagridstud.ColumnHeadersDefaultCellStyle = columnHeaderStyle


        frmstudinfo.datagridstud.ColumnCount = 2
        frmstudinfo.datagridstud.Columns(0).Name = "ID"
        frmstudinfo.datagridstud.Columns(0).Visible = False
        frmstudinfo.datagridstud.Columns(1).Name = "FULLNAME"

        Dim test As DataGridViewColumn = frmstudinfo.datagridstud.Columns(1)
        test.Width = 300
        frmstudinfo.datagridstud.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Public Sub gridstudinfo()
        Dim table As New DataTable
        Try
            frmstudinfo.datagridstud.Rows.Clear()
            exec_conn.Open()
            query = ("SELECT cstudno,UPPER(CONCAT(cfname,' ',cmname,' ',clname)) as fullname FROM studinfo")
            exec_command = New MySqlCommand(query, exec_conn)
            exec_dadapter = New MySqlDataAdapter(exec_command)
            exec_dadapter.Fill(table)

            For Each row In table.Rows
                Populate(row(0), row(1))
            Next

            exec_conn.Close()
            table.Rows.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
            exec_conn.Close()
        Finally
            exec_conn.Dispose()

        End Try
    End Sub

    Private Sub Populate(ByVal id As String, ByVal name As String)
        Dim row As String() = New String() {id, name}
        frmstudinfo.datagridstud.Rows.Add(row)
    End Sub

    Public Sub querydatagrid()

        Dim id = frmstudinfo.datagridstud.SelectedRows(0).Cells(0).Value
        Try
            exec_conn.Open()
            query = ("SELECT * FROM studinfo where cstudno = '" & id & "'")
            exec_command = New MySqlCommand(query, exec_conn)
            exec_dreader = exec_command.ExecuteReader

            If Not exec_dreader.HasRows Then Exit Sub

            Do While exec_dreader.Read()
                frmstudinfo.txtcstudid.Text = exec_dreader.GetString(0)
                frmstudinfo.txtcfname.Text = exec_dreader.GetString(1)
                frmstudinfo.txtcmname.Text = exec_dreader.GetString(2)
                frmstudinfo.txtclname.Text = exec_dreader.GetString(3)
                frmstudinfo.txtcnickname.Text = exec_dreader.GetString(4)
            Loop

            exec_conn.Close()

            exec_conn.Open()
            query1 = ("select * from studpersonalinfo where cstudid = '" & id & "'")
            exec_command = New MySqlCommand(query1, exec_conn)
            exec_dreader = exec_command.ExecuteReader

            If Not exec_dreader.HasRows Then Exit Sub

            Do While exec_dreader.Read()

                frmstudinfo.txdtpbirthday.Text = exec_dreader.GetString(1) '.ToString("dd/MM/yyyy")
                frmstudinfo.txtbirthplace.Text = exec_dreader.GetString(2)
                frmstudinfo.txcbgender.Text = exec_dreader.GetString(3)
                frmstudinfo.txtcitizen.Text = exec_dreader.GetString(4)
                frmstudinfo.txtheight.Text = exec_dreader.GetString(5)
                frmstudinfo.txtweight.Text = exec_dreader.GetString(6)
                frmstudinfo.txtreligion.Text = exec_dreader.GetString(7)
            Loop
            exec_conn.Close()
        Catch ex As Exception
            exec_conn.Close()
            ' MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub queryadd()

        studid = frmstudinfo.txtcstudid.Text
        fname = frmstudinfo.txtcfname.Text
        mname = frmstudinfo.txtcmname.Text
        lname = frmstudinfo.txtclname.Text
        nname = frmstudinfo.txtcnickname.Text
        Dim llock = "0"

        brthday = frmstudinfo.txdtpbirthday.Value.Date.ToString("yyyy/MM/dd")
        brthplace = frmstudinfo.txtbirthplace.Text
        gender = frmstudinfo.txcbgender.Text
        citizenshp = frmstudinfo.txtcitizen.Text
        religion = frmstudinfo.txtreligion.Text
        height = frmstudinfo.txtheight.Text
        weight = frmstudinfo.txtweight.Text

        Try
            exec_conn.Open()
            query = ("insert into studinfo (cstudno,cfname,cmname,clname,cnickname,clocked) " & _
                "values ('" + studid + "','" + fname + "','" + mname + "','" + lname + "','" + nname + "','" + llock + "')")
            exec_command = New MySqlCommand(query, exec_conn)
            exec_dreader = exec_command.ExecuteReader

            exec_conn.Close()
            exec_conn.Open()
            query1 = ("insert into studpersonalinfo (cstudid,cbirthdate,cbirthplace,cgender,ccitizenship, " & _
                  " cheight,cweight,creligion) values ('" + studid + "','" + brthday + "','" + brthplace + "','" + gender + "',  " & _
                  " '" + citizenshp + "','" + height + "','" + weight + "','" + religion + "')")
            exec_command = New MySqlCommand(query1, exec_conn)
            exec_dreader = exec_command.ExecuteReader

      
            MsgBox("Record Successfully Saved!", MsgBoxStyle.Information, "SAVE")

            'exec_dadapter.UpdateCommand = exec_conn.CreateCommand
            'exec_dadapter.UpdateCommand.CommandText = query
            'If exec_dadapter.UpdateCommand.ExecuteNonQuery() > 0 Then
            'msg here
            'End If

            exec_conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            exec_conn.Close()
        Finally
            exec_conn.Dispose()
        End Try
    End Sub

    Public Sub queryupdate()
        Dim id As String = frmstudinfo.datagridstud.SelectedRows(0).Cells(0).Value
        fname = frmstudinfo.txtcfname.Text
        mname = frmstudinfo.txtcmname.Text
        lname = frmstudinfo.txtclname.Text
        nname = frmstudinfo.txtcnickname.Text
        Try
            exec_conn.Open()
            query = ("update studinfo set cfname ='" + fname + "',cmname = '" + mname + "', clname = '" + lname + "' , " & _
                     "cnickname = '" + nname + "' where cstudno = '" + id + "'")
            exec_command = New MySqlCommand(query, exec_conn)

            exec_dadapter.UpdateCommand = exec_conn.CreateCommand
            exec_dadapter.UpdateCommand.CommandText = query
            If exec_dadapter.UpdateCommand.ExecuteNonQuery() > 0 Then
                MsgBox("Record Successfully Updated", MsgBoxStyle.Information, "UPDATE")
            End If
            'query.ExecuteNonQuery()
            exec_conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            exec_conn.Dispose()
        End Try

    End Sub

    Public Sub querydelete()
        Dim id As String = frmstudinfo.txtcstudid.Text

        Try
            exec_conn.Open()
            query = "DELETE from studinfo where cstudno = '" + id + "'"
            exec_command = New MySqlCommand(query, exec_conn)
            ' exec_dreader = exec_command.ExecuteReader()
            'exec_dadapter.UpdateCommand = exec_conn.CreateCommand
            'exec_dadapter.UpdateCommand.CommandText = query
            'If exec_dadapter.UpdateCommand.ExecuteNonQuery() > 0 Then
            exec_command.ExecuteNonQuery()
            MsgBox("Record Successfully Deleted", MsgBoxStyle.Information, "DELETE")
            'End If

            exec_conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            exec_conn.Dispose()
        End Try
    End Sub
End Module
