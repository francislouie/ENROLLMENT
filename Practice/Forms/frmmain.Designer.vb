<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.tsmain = New System.Windows.Forms.ToolStrip()
        Me.tslstudent = New System.Windows.Forms.ToolStripDropDownButton()
        Me.STUDENTINFOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tslteacher = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TEACHERINFOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tslexit = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CITIZENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOCATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELIGIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsmain
        '
        Me.tsmain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslstudent, Me.tslteacher, Me.ToolStripLabel1, Me.tslexit})
        Me.tsmain.Location = New System.Drawing.Point(0, 0)
        Me.tsmain.Name = "tsmain"
        Me.tsmain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsmain.Size = New System.Drawing.Size(925, 25)
        Me.tsmain.TabIndex = 0
        Me.tsmain.Text = "ToolStrip1"
        Me.tsmain.Visible = False
        '
        'tslstudent
        '
        Me.tslstudent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTINFOToolStripMenuItem})
        Me.tslstudent.Name = "tslstudent"
        Me.tslstudent.Size = New System.Drawing.Size(65, 22)
        Me.tslstudent.Text = "STUDENT"
        '
        'STUDENTINFOToolStripMenuItem
        '
        Me.STUDENTINFOToolStripMenuItem.Name = "STUDENTINFOToolStripMenuItem"
        Me.STUDENTINFOToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.STUDENTINFOToolStripMenuItem.Text = "STUDENT INFO"
        '
        'tslteacher
        '
        Me.tslteacher.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TEACHERINFOToolStripMenuItem})
        Me.tslteacher.Name = "tslteacher"
        Me.tslteacher.Size = New System.Drawing.Size(66, 22)
        Me.tslteacher.Text = "TEACHER"
        '
        'TEACHERINFOToolStripMenuItem
        '
        Me.TEACHERINFOToolStripMenuItem.Name = "TEACHERINFOToolStripMenuItem"
        Me.TEACHERINFOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TEACHERINFOToolStripMenuItem.Text = "TEACHER INFO"
        '
        'tslexit
        '
        Me.tslexit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.tslexit.Name = "tslexit"
        Me.tslexit.Size = New System.Drawing.Size(87, 22)
        Me.tslexit.Text = "LOGOUT/EXIT"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CITIZENToolStripMenuItem, Me.LOCATIONToolStripMenuItem, Me.RELIGIONToolStripMenuItem})
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripLabel1.Text = "OTHERS"
        '
        'CITIZENToolStripMenuItem
        '
        Me.CITIZENToolStripMenuItem.Name = "CITIZENToolStripMenuItem"
        Me.CITIZENToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CITIZENToolStripMenuItem.Text = "CITIZEN"
        '
        'LOCATIONToolStripMenuItem
        '
        Me.LOCATIONToolStripMenuItem.Name = "LOCATIONToolStripMenuItem"
        Me.LOCATIONToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LOCATIONToolStripMenuItem.Text = "LOCATION"
        '
        'RELIGIONToolStripMenuItem
        '
        Me.RELIGIONToolStripMenuItem.Name = "RELIGIONToolStripMenuItem"
        Me.RELIGIONToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RELIGIONToolStripMenuItem.Text = "RELIGION"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(925, 428)
        Me.Controls.Add(Me.tsmain)
        Me.Name = "frmmain"
        Me.Text = "ENROLLMENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsmain.ResumeLayout(False)
        Me.tsmain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsmain As System.Windows.Forms.ToolStrip
    Friend WithEvents tslstudent As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents STUDENTINFOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tslteacher As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TEACHERINFOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem


    Private Sub MAIN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub
    Friend WithEvents tslexit As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CITIZENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOCATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RELIGIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
