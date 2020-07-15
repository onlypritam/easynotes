<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.BtnNotesroot = New System.Windows.Forms.Button()
        Me.TxtNotesroot = New System.Windows.Forms.TextBox()
        Me.BtnTemplateroot = New System.Windows.Forms.Button()
        Me.TxtTemplateroot = New System.Windows.Forms.TextBox()
        Me.BtnDSDBshare = New System.Windows.Forms.Button()
        Me.TxtDSDBshare = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.LB = New System.Windows.Forms.ListBox()
        Me.TxtLst = New System.Windows.Forms.TextBox()
        Me.BtnLstAdd = New System.Windows.Forms.Button()
        Me.BtnLstDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLinkname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBullet = New System.Windows.Forms.TextBox()
        Me.ChkBulletEnabled = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRecentCase = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RTBSample = New System.Windows.Forms.RichTextBox()
        Me.CBBackcolor = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBFontSize = New System.Windows.Forms.ComboBox()
        Me.CBForeColor = New System.Windows.Forms.ComboBox()
        Me.CBFont = New System.Windows.Forms.ComboBox()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.TxtAltTemplateroot = New System.Windows.Forms.TextBox()
        Me.BtnAltTemplateRoot = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNotesroot
        '
        Me.BtnNotesroot.Location = New System.Drawing.Point(461, 12)
        Me.BtnNotesroot.Name = "BtnNotesroot"
        Me.BtnNotesroot.Size = New System.Drawing.Size(26, 22)
        Me.BtnNotesroot.TabIndex = 2
        Me.BtnNotesroot.Text = "..."
        Me.BtnNotesroot.UseVisualStyleBackColor = True
        '
        'TxtNotesroot
        '
        Me.TxtNotesroot.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNotesroot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotesroot.Location = New System.Drawing.Point(102, 12)
        Me.TxtNotesroot.Name = "TxtNotesroot"
        Me.TxtNotesroot.Size = New System.Drawing.Size(355, 20)
        Me.TxtNotesroot.TabIndex = 0
        Me.TxtNotesroot.Text = "C:\EasyNotes\Notesroot"
        '
        'BtnTemplateroot
        '
        Me.BtnTemplateroot.Location = New System.Drawing.Point(461, 36)
        Me.BtnTemplateroot.Name = "BtnTemplateroot"
        Me.BtnTemplateroot.Size = New System.Drawing.Size(26, 22)
        Me.BtnTemplateroot.TabIndex = 4
        Me.BtnTemplateroot.Text = "..."
        Me.BtnTemplateroot.UseVisualStyleBackColor = True
        '
        'TxtTemplateroot
        '
        Me.TxtTemplateroot.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTemplateroot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTemplateroot.Location = New System.Drawing.Point(102, 36)
        Me.TxtTemplateroot.Name = "TxtTemplateroot"
        Me.TxtTemplateroot.Size = New System.Drawing.Size(355, 20)
        Me.TxtTemplateroot.TabIndex = 3
        Me.TxtTemplateroot.Text = "C:\EasyNotes\Templateroot"
        '
        'BtnDSDBshare
        '
        Me.BtnDSDBshare.Location = New System.Drawing.Point(461, 84)
        Me.BtnDSDBshare.Name = "BtnDSDBshare"
        Me.BtnDSDBshare.Size = New System.Drawing.Size(26, 22)
        Me.BtnDSDBshare.TabIndex = 6
        Me.BtnDSDBshare.Text = "..."
        Me.BtnDSDBshare.UseVisualStyleBackColor = True
        '
        'TxtDSDBshare
        '
        Me.TxtDSDBshare.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDSDBshare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDSDBshare.Location = New System.Drawing.Point(102, 84)
        Me.TxtDSDBshare.MaxLength = 500
        Me.TxtDSDBshare.Name = "TxtDSDBshare"
        Me.TxtDSDBshare.Size = New System.Drawing.Size(355, 20)
        Me.TxtDSDBshare.TabIndex = 5
        Me.TxtDSDBshare.Text = "C:\EasyNotes\Teamshare"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Notes root"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Template root"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Team share"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(333, 530)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(414, 530)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 16
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LB
        '
        Me.LB.FormattingEnabled = True
        Me.LB.Location = New System.Drawing.Point(12, 310)
        Me.LB.Name = "LB"
        Me.LB.Size = New System.Drawing.Size(475, 212)
        Me.LB.TabIndex = 14
        '
        'TxtLst
        '
        Me.TxtLst.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLst.Location = New System.Drawing.Point(110, 287)
        Me.TxtLst.MaxLength = 500
        Me.TxtLst.Name = "TxtLst"
        Me.TxtLst.Size = New System.Drawing.Size(327, 20)
        Me.TxtLst.TabIndex = 11
        '
        'BtnLstAdd
        '
        Me.BtnLstAdd.Location = New System.Drawing.Point(437, 286)
        Me.BtnLstAdd.Name = "BtnLstAdd"
        Me.BtnLstAdd.Size = New System.Drawing.Size(26, 22)
        Me.BtnLstAdd.TabIndex = 12
        Me.BtnLstAdd.Text = "+"
        Me.BtnLstAdd.UseVisualStyleBackColor = True
        '
        'BtnLstDelete
        '
        Me.BtnLstDelete.Location = New System.Drawing.Point(463, 286)
        Me.BtnLstDelete.Name = "BtnLstDelete"
        Me.BtnLstDelete.Size = New System.Drawing.Size(26, 22)
        Me.BtnLstDelete.TabIndex = 13
        Me.BtnLstDelete.Text = "X"
        Me.BtnLstDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Link Name-: "
        '
        'TxtLinkname
        '
        Me.TxtLinkname.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLinkname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLinkname.Location = New System.Drawing.Point(12, 287)
        Me.TxtLinkname.MaxLength = 50
        Me.TxtLinkname.Name = "TxtLinkname"
        Me.TxtLinkname.Size = New System.Drawing.Size(99, 20)
        Me.TxtLinkname.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Link -: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(12, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Bullet"
        '
        'TxtBullet
        '
        Me.TxtBullet.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBullet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBullet.Location = New System.Drawing.Point(102, 114)
        Me.TxtBullet.MaxLength = 5
        Me.TxtBullet.Name = "TxtBullet"
        Me.TxtBullet.Size = New System.Drawing.Size(44, 20)
        Me.TxtBullet.TabIndex = 7
        Me.TxtBullet.Text = "+>>"
        '
        'ChkBulletEnabled
        '
        Me.ChkBulletEnabled.AutoSize = True
        Me.ChkBulletEnabled.Location = New System.Drawing.Point(152, 115)
        Me.ChkBulletEnabled.Name = "ChkBulletEnabled"
        Me.ChkBulletEnabled.Size = New System.Drawing.Size(93, 17)
        Me.ChkBulletEnabled.TabIndex = 8
        Me.ChkBulletEnabled.Text = "Bullet enabled"
        Me.ChkBulletEnabled.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(274, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Maintain recent case history for "
        '
        'TxtRecentCase
        '
        Me.TxtRecentCase.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRecentCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRecentCase.Location = New System.Drawing.Point(428, 114)
        Me.TxtRecentCase.MaxLength = 2
        Me.TxtRecentCase.Name = "TxtRecentCase"
        Me.TxtRecentCase.Size = New System.Drawing.Size(29, 20)
        Me.TxtRecentCase.TabIndex = 9
        Me.TxtRecentCase.Text = "7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(458, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Days"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RTBSample)
        Me.GroupBox1.Controls.Add(Me.CBBackcolor)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CBFontSize)
        Me.GroupBox1.Controls.Add(Me.CBForeColor)
        Me.GroupBox1.Controls.Add(Me.CBFont)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 121)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'RTBSample
        '
        Me.RTBSample.BackColor = System.Drawing.Color.White
        Me.RTBSample.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBSample.DetectUrls = False
        Me.RTBSample.Location = New System.Drawing.Point(10, 67)
        Me.RTBSample.Multiline = False
        Me.RTBSample.Name = "RTBSample"
        Me.RTBSample.ReadOnly = True
        Me.RTBSample.Size = New System.Drawing.Size(462, 47)
        Me.RTBSample.TabIndex = 50
        Me.RTBSample.Text = "This is how your text will look like"
        '
        'CBBackcolor
        '
        Me.CBBackcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBackcolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBBackcolor.FormattingEnabled = True
        Me.CBBackcolor.Location = New System.Drawing.Point(341, 12)
        Me.CBBackcolor.Name = "CBBackcolor"
        Me.CBBackcolor.Size = New System.Drawing.Size(131, 21)
        Me.CBBackcolor.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(263, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Back color"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(263, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Font size"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(7, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Fore color"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(7, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Font"
        '
        'CBFontSize
        '
        Me.CBFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBFontSize.FormattingEnabled = True
        Me.CBFontSize.Location = New System.Drawing.Point(341, 39)
        Me.CBFontSize.Name = "CBFontSize"
        Me.CBFontSize.Size = New System.Drawing.Size(131, 21)
        Me.CBFontSize.TabIndex = 44
        '
        'CBForeColor
        '
        Me.CBForeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBForeColor.FormattingEnabled = True
        Me.CBForeColor.Location = New System.Drawing.Point(89, 39)
        Me.CBForeColor.Name = "CBForeColor"
        Me.CBForeColor.Size = New System.Drawing.Size(131, 21)
        Me.CBForeColor.TabIndex = 43
        '
        'CBFont
        '
        Me.CBFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFont.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBFont.FormattingEnabled = True
        Me.CBFont.Location = New System.Drawing.Point(89, 12)
        Me.CBFont.Name = "CBFont"
        Me.CBFont.Size = New System.Drawing.Size(131, 21)
        Me.CBFont.TabIndex = 42
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(12, 530)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(295, 20)
        Me.PB.TabIndex = 43
        Me.PB.Visible = False
        '
        'TxtAltTemplateroot
        '
        Me.TxtAltTemplateroot.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAltTemplateroot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAltTemplateroot.Location = New System.Drawing.Point(102, 60)
        Me.TxtAltTemplateroot.Name = "TxtAltTemplateroot"
        Me.TxtAltTemplateroot.Size = New System.Drawing.Size(355, 20)
        Me.TxtAltTemplateroot.TabIndex = 44
        '
        'BtnAltTemplateRoot
        '
        Me.BtnAltTemplateRoot.Location = New System.Drawing.Point(461, 60)
        Me.BtnAltTemplateRoot.Name = "BtnAltTemplateRoot"
        Me.BtnAltTemplateRoot.Size = New System.Drawing.Size(26, 22)
        Me.BtnAltTemplateRoot.TabIndex = 45
        Me.BtnAltTemplateRoot.Text = "..."
        Me.BtnAltTemplateRoot.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Alt. Template root"
        '
        'Settings
        '
        Me.AcceptButton = Me.BtnSave
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(496, 562)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnAltTemplateRoot)
        Me.Controls.Add(Me.TxtAltTemplateroot)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtRecentCase)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ChkBulletEnabled)
        Me.Controls.Add(Me.TxtBullet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtLinkname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnLstDelete)
        Me.Controls.Add(Me.BtnLstAdd)
        Me.Controls.Add(Me.TxtLst)
        Me.Controls.Add(Me.LB)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDSDBshare)
        Me.Controls.Add(Me.TxtDSDBshare)
        Me.Controls.Add(Me.BtnTemplateroot)
        Me.Controls.Add(Me.TxtTemplateroot)
        Me.Controls.Add(Me.BtnNotesroot)
        Me.Controls.Add(Me.TxtNotesroot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNotesroot As System.Windows.Forms.Button
    Friend WithEvents TxtNotesroot As System.Windows.Forms.TextBox
    Friend WithEvents BtnTemplateroot As System.Windows.Forms.Button
    Friend WithEvents TxtTemplateroot As System.Windows.Forms.TextBox
    Friend WithEvents BtnDSDBshare As System.Windows.Forms.Button
    Friend WithEvents TxtDSDBshare As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LB As System.Windows.Forms.ListBox
    Friend WithEvents TxtLst As System.Windows.Forms.TextBox
    Friend WithEvents BtnLstAdd As System.Windows.Forms.Button
    Friend WithEvents BtnLstDelete As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtLinkname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtBullet As System.Windows.Forms.TextBox
    Friend WithEvents ChkBulletEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtRecentCase As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents CBForeColor As System.Windows.Forms.ComboBox
    Friend WithEvents CBFont As System.Windows.Forms.ComboBox
    Friend WithEvents PB As System.Windows.Forms.ProgressBar
    Friend WithEvents TxtAltTemplateroot As System.Windows.Forms.TextBox
    Friend WithEvents BtnAltTemplateRoot As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CBBackcolor As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RTBSample As System.Windows.Forms.RichTextBox
End Class
