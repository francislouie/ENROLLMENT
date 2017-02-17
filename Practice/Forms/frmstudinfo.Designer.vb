<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudinfo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnlocked = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.pbstudent = New System.Windows.Forms.PictureBox()
        Me.txtcnickname = New System.Windows.Forms.TextBox()
        Me.txtclname = New System.Windows.Forms.TextBox()
        Me.txtcmname = New System.Windows.Forms.TextBox()
        Me.txtcfname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcstudid = New System.Windows.Forms.TextBox()
        Me.datagridstud = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbirthplace = New System.Windows.Forms.TextBox()
        Me.txdtpbirthday = New System.Windows.Forms.DateTimePicker()
        Me.txcbgender = New System.Windows.Forms.ComboBox()
        Me.txtreligion = New System.Windows.Forms.TextBox()
        Me.txtweight = New System.Windows.Forms.TextBox()
        Me.txtcitizen = New System.Windows.Forms.TextBox()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridstud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btnlocked)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Location = New System.Drawing.Point(12, 372)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 53)
        Me.Panel1.TabIndex = 21
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(244, 8)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(112, 37)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(480, 8)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(112, 37)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(8, 8)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(112, 37)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnlocked
        '
        Me.btnlocked.Location = New System.Drawing.Point(362, 8)
        Me.btnlocked.Name = "btnlocked"
        Me.btnlocked.Size = New System.Drawing.Size(112, 37)
        Me.btnlocked.TabIndex = 4
        Me.btnlocked.Text = "LOCKED"
        Me.btnlocked.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(126, 8)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(112, 37)
        Me.btnedit.TabIndex = 1
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'pbstudent
        '
        Me.pbstudent.BackColor = System.Drawing.SystemColors.Desktop
        Me.pbstudent.Location = New System.Drawing.Point(12, 12)
        Me.pbstudent.Name = "pbstudent"
        Me.pbstudent.Size = New System.Drawing.Size(150, 150)
        Me.pbstudent.TabIndex = 20
        Me.pbstudent.TabStop = False
        '
        'txtcnickname
        '
        Me.txtcnickname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcnickname.Enabled = False
        Me.txtcnickname.Location = New System.Drawing.Point(297, 133)
        Me.txtcnickname.Multiline = True
        Me.txtcnickname.Name = "txtcnickname"
        Me.txtcnickname.Size = New System.Drawing.Size(305, 25)
        Me.txtcnickname.TabIndex = 19
        '
        'txtclname
        '
        Me.txtclname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtclname.Enabled = False
        Me.txtclname.Location = New System.Drawing.Point(297, 102)
        Me.txtclname.Multiline = True
        Me.txtclname.Name = "txtclname"
        Me.txtclname.Size = New System.Drawing.Size(305, 25)
        Me.txtclname.TabIndex = 18
        '
        'txtcmname
        '
        Me.txtcmname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcmname.Enabled = False
        Me.txtcmname.Location = New System.Drawing.Point(297, 71)
        Me.txtcmname.Multiline = True
        Me.txtcmname.Name = "txtcmname"
        Me.txtcmname.Size = New System.Drawing.Size(305, 25)
        Me.txtcmname.TabIndex = 17
        '
        'txtcfname
        '
        Me.txtcfname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcfname.Enabled = False
        Me.txtcfname.Location = New System.Drawing.Point(297, 40)
        Me.txtcfname.Multiline = True
        Me.txtcfname.Name = "txtcfname"
        Me.txtcfname.Size = New System.Drawing.Size(305, 25)
        Me.txtcfname.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(174, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "NICKNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(174, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "LASTNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "MIDDLENAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "FIRSTNAME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(174, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "ID NO"
        '
        'txtcstudid
        '
        Me.txtcstudid.Enabled = False
        Me.txtcstudid.Location = New System.Drawing.Point(297, 9)
        Me.txtcstudid.Multiline = True
        Me.txtcstudid.Name = "txtcstudid"
        Me.txtcstudid.Size = New System.Drawing.Size(100, 25)
        Me.txtcstudid.TabIndex = 27
        '
        'datagridstud
        '
        Me.datagridstud.BackgroundColor = System.Drawing.SystemColors.Window
        Me.datagridstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridstud.Location = New System.Drawing.Point(625, 12)
        Me.datagridstud.Name = "datagridstud"
        Me.datagridstud.ReadOnly = True
        Me.datagridstud.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.datagridstud.Size = New System.Drawing.Size(357, 416)
        Me.datagridstud.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "BIRTHDAY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "BIRTHPLACE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "HEIGHT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "CITIZEN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(331, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "RELIGION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(331, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "WEIGHT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(331, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 20)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "GENDER"
        '
        'txtbirthplace
        '
        Me.txtbirthplace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbirthplace.Enabled = False
        Me.txtbirthplace.Location = New System.Drawing.Point(124, 181)
        Me.txtbirthplace.Multiline = True
        Me.txtbirthplace.Name = "txtbirthplace"
        Me.txtbirthplace.Size = New System.Drawing.Size(477, 25)
        Me.txtbirthplace.TabIndex = 40
        '
        'txdtpbirthday
        '
        Me.txdtpbirthday.CustomFormat = ""
        Me.txdtpbirthday.Enabled = False
        Me.txdtpbirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txdtpbirthday.Location = New System.Drawing.Point(125, 212)
        Me.txdtpbirthday.Name = "txdtpbirthday"
        Me.txdtpbirthday.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txdtpbirthday.Size = New System.Drawing.Size(178, 20)
        Me.txdtpbirthday.TabIndex = 41
        Me.txdtpbirthday.Value = New Date(2017, 2, 15, 13, 18, 11, 0)
        '
        'txcbgender
        '
        Me.txcbgender.Enabled = False
        Me.txcbgender.FormattingEnabled = True
        Me.txcbgender.Location = New System.Drawing.Point(424, 212)
        Me.txcbgender.Name = "txcbgender"
        Me.txcbgender.Size = New System.Drawing.Size(121, 21)
        Me.txcbgender.TabIndex = 42
        '
        'txtreligion
        '
        Me.txtreligion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreligion.Enabled = False
        Me.txtreligion.Location = New System.Drawing.Point(424, 241)
        Me.txtreligion.Multiline = True
        Me.txtreligion.Name = "txtreligion"
        Me.txtreligion.Size = New System.Drawing.Size(178, 25)
        Me.txtreligion.TabIndex = 45
        '
        'txtweight
        '
        Me.txtweight.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtweight.Enabled = False
        Me.txtweight.Location = New System.Drawing.Point(424, 272)
        Me.txtweight.Multiline = True
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(178, 25)
        Me.txtweight.TabIndex = 46
        '
        'txtcitizen
        '
        Me.txtcitizen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcitizen.Enabled = False
        Me.txtcitizen.Location = New System.Drawing.Point(125, 241)
        Me.txtcitizen.Multiline = True
        Me.txtcitizen.Name = "txtcitizen"
        Me.txtcitizen.Size = New System.Drawing.Size(178, 25)
        Me.txtcitizen.TabIndex = 47
        '
        'txtheight
        '
        Me.txtheight.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtheight.Enabled = False
        Me.txtheight.Location = New System.Drawing.Point(125, 272)
        Me.txtheight.Multiline = True
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(178, 25)
        Me.txtheight.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(8, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 15)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "GUARDIAN"
        '
        'frmstudinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(993, 440)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtheight)
        Me.Controls.Add(Me.txtcitizen)
        Me.Controls.Add(Me.txtweight)
        Me.Controls.Add(Me.txtreligion)
        Me.Controls.Add(Me.txcbgender)
        Me.Controls.Add(Me.txdtpbirthday)
        Me.Controls.Add(Me.txtbirthplace)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.datagridstud)
        Me.Controls.Add(Me.txtcstudid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbstudent)
        Me.Controls.Add(Me.txtcnickname)
        Me.Controls.Add(Me.txtclname)
        Me.Controls.Add(Me.txtcmname)
        Me.Controls.Add(Me.txtcfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmstudinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmstudinfo"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridstud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnlocked As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents pbstudent As System.Windows.Forms.PictureBox
    Friend WithEvents txtcnickname As System.Windows.Forms.TextBox
    Friend WithEvents txtclname As System.Windows.Forms.TextBox
    Friend WithEvents txtcmname As System.Windows.Forms.TextBox
    Friend WithEvents txtcfname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcstudid As System.Windows.Forms.TextBox
    Friend WithEvents datagridstud As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtbirthplace As System.Windows.Forms.TextBox
    Friend WithEvents txdtpbirthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents txcbgender As System.Windows.Forms.ComboBox
    Friend WithEvents txtreligion As System.Windows.Forms.TextBox
    Friend WithEvents txtweight As System.Windows.Forms.TextBox
    Friend WithEvents txtcitizen As System.Windows.Forms.TextBox
    Friend WithEvents txtheight As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
