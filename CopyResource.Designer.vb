<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopyResource
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyResource))
        Me.TxtCopyFrom = New System.Windows.Forms.TextBox()
        Me.TxtDSDBPath = New System.Windows.Forms.TextBox()
        Me.TxtLocalPath = New System.Windows.Forms.TextBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.BtnCopyFrom = New System.Windows.Forms.Button()
        Me.TxtOtherPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkCopyDSDB = New System.Windows.Forms.CheckBox()
        Me.ChkCopyLocalShare = New System.Windows.Forms.CheckBox()
        Me.ChkCopyOtherLocation = New System.Windows.Forms.CheckBox()
        Me.BtnCopyTo = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.ODD = New System.Windows.Forms.FolderBrowserDialog()
        Me.ChkDateTS = New System.Windows.Forms.CheckBox()
        Me.ChkDateLS = New System.Windows.Forms.CheckBox()
        Me.ChkDateCF = New System.Windows.Forms.CheckBox()
        Me.TxtCFPath = New System.Windows.Forms.TextBox()
        Me.ChkCopyCF = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtCopyFrom
        '
        Me.TxtCopyFrom.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCopyFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCopyFrom.Location = New System.Drawing.Point(150, 12)
        Me.TxtCopyFrom.Name = "TxtCopyFrom"
        Me.TxtCopyFrom.Size = New System.Drawing.Size(386, 20)
        Me.TxtCopyFrom.TabIndex = 0
        '
        'TxtDSDBPath
        '
        Me.TxtDSDBPath.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDSDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDSDBPath.Location = New System.Drawing.Point(150, 61)
        Me.TxtDSDBPath.Name = "TxtDSDBPath"
        Me.TxtDSDBPath.ReadOnly = True
        Me.TxtDSDBPath.Size = New System.Drawing.Size(412, 20)
        Me.TxtDSDBPath.TabIndex = 3
        '
        'TxtLocalPath
        '
        Me.TxtLocalPath.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLocalPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLocalPath.Location = New System.Drawing.Point(150, 103)
        Me.TxtLocalPath.Name = "TxtLocalPath"
        Me.TxtLocalPath.ReadOnly = True
        Me.TxtLocalPath.Size = New System.Drawing.Size(412, 20)
        Me.TxtLocalPath.TabIndex = 6
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'BtnCopyFrom
        '
        Me.BtnCopyFrom.Location = New System.Drawing.Point(536, 11)
        Me.BtnCopyFrom.Name = "BtnCopyFrom"
        Me.BtnCopyFrom.Size = New System.Drawing.Size(26, 22)
        Me.BtnCopyFrom.TabIndex = 1
        Me.BtnCopyFrom.Text = "..."
        Me.BtnCopyFrom.UseVisualStyleBackColor = True
        '
        'TxtOtherPath
        '
        Me.TxtOtherPath.BackColor = System.Drawing.SystemColors.Window
        Me.TxtOtherPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOtherPath.Location = New System.Drawing.Point(150, 189)
        Me.TxtOtherPath.Name = "TxtOtherPath"
        Me.TxtOtherPath.Size = New System.Drawing.Size(386, 20)
        Me.TxtOtherPath.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Copy resource From  -"
        '
        'ChkCopyDSDB
        '
        Me.ChkCopyDSDB.AutoSize = True
        Me.ChkCopyDSDB.Checked = True
        Me.ChkCopyDSDB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCopyDSDB.Location = New System.Drawing.Point(13, 62)
        Me.ChkCopyDSDB.Name = "ChkCopyDSDB"
        Me.ChkCopyDSDB.Size = New System.Drawing.Size(134, 17)
        Me.ChkCopyDSDB.TabIndex = 2
        Me.ChkCopyDSDB.Text = "Copy to Public Share  -"
        Me.ChkCopyDSDB.UseVisualStyleBackColor = True
        '
        'ChkCopyLocalShare
        '
        Me.ChkCopyLocalShare.AutoSize = True
        Me.ChkCopyLocalShare.Checked = True
        Me.ChkCopyLocalShare.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCopyLocalShare.Location = New System.Drawing.Point(13, 105)
        Me.ChkCopyLocalShare.Name = "ChkCopyLocalShare"
        Me.ChkCopyLocalShare.Size = New System.Drawing.Size(131, 17)
        Me.ChkCopyLocalShare.TabIndex = 5
        Me.ChkCopyLocalShare.Text = "Copy to Local Share  -"
        Me.ChkCopyLocalShare.UseVisualStyleBackColor = True
        '
        'ChkCopyOtherLocation
        '
        Me.ChkCopyOtherLocation.AutoSize = True
        Me.ChkCopyOtherLocation.Enabled = False
        Me.ChkCopyOtherLocation.Location = New System.Drawing.Point(13, 190)
        Me.ChkCopyOtherLocation.Name = "ChkCopyOtherLocation"
        Me.ChkCopyOtherLocation.Size = New System.Drawing.Size(140, 17)
        Me.ChkCopyOtherLocation.TabIndex = 8
        Me.ChkCopyOtherLocation.Text = "Copy to Other location  -"
        Me.ChkCopyOtherLocation.UseVisualStyleBackColor = True
        '
        'BtnCopyTo
        '
        Me.BtnCopyTo.Location = New System.Drawing.Point(536, 188)
        Me.BtnCopyTo.Name = "BtnCopyTo"
        Me.BtnCopyTo.Size = New System.Drawing.Size(26, 22)
        Me.BtnCopyTo.TabIndex = 10
        Me.BtnCopyTo.Text = "..."
        Me.BtnCopyTo.UseVisualStyleBackColor = True
        '
        'BtnCopy
        '
        Me.BtnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCopy.Enabled = False
        Me.BtnCopy.Location = New System.Drawing.Point(484, 224)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(75, 23)
        Me.BtnCopy.TabIndex = 11
        Me.BtnCopy.Text = "&Copy"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'ChkDateTS
        '
        Me.ChkDateTS.AutoSize = True
        Me.ChkDateTS.Checked = True
        Me.ChkDateTS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDateTS.Location = New System.Drawing.Point(319, 81)
        Me.ChkDateTS.Name = "ChkDateTS"
        Me.ChkDateTS.Size = New System.Drawing.Size(243, 17)
        Me.ChkDateTS.TabIndex = 4
        Me.ChkDateTS.Text = "Create and copy to directory with today's Date"
        Me.ChkDateTS.UseVisualStyleBackColor = True
        '
        'ChkDateLS
        '
        Me.ChkDateLS.AutoSize = True
        Me.ChkDateLS.Checked = True
        Me.ChkDateLS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDateLS.Location = New System.Drawing.Point(319, 123)
        Me.ChkDateLS.Name = "ChkDateLS"
        Me.ChkDateLS.Size = New System.Drawing.Size(243, 17)
        Me.ChkDateLS.TabIndex = 7
        Me.ChkDateLS.Text = "Create and copy to directory with today's Date"
        Me.ChkDateLS.UseVisualStyleBackColor = True
        '
        'ChkDateCF
        '
        Me.ChkDateCF.AutoSize = True
        Me.ChkDateCF.Checked = True
        Me.ChkDateCF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDateCF.Location = New System.Drawing.Point(319, 166)
        Me.ChkDateCF.Name = "ChkDateCF"
        Me.ChkDateCF.Size = New System.Drawing.Size(243, 17)
        Me.ChkDateCF.TabIndex = 15
        Me.ChkDateCF.Text = "Create and copy to directory with today's Date"
        Me.ChkDateCF.UseVisualStyleBackColor = True
        '
        'TxtCFPath
        '
        Me.TxtCFPath.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCFPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCFPath.Location = New System.Drawing.Point(150, 146)
        Me.TxtCFPath.Name = "TxtCFPath"
        Me.TxtCFPath.ReadOnly = True
        Me.TxtCFPath.Size = New System.Drawing.Size(412, 20)
        Me.TxtCFPath.TabIndex = 14
        '
        'ChkCopyCF
        '
        Me.ChkCopyCF.AutoSize = True
        Me.ChkCopyCF.Location = New System.Drawing.Point(13, 147)
        Me.ChkCopyCF.Name = "ChkCopyCF"
        Me.ChkCopyCF.Size = New System.Drawing.Size(139, 17)
        Me.ChkCopyCF.TabIndex = 13
        Me.ChkCopyCF.Text = "Copy to Customer files  -"
        Me.ChkCopyCF.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(13, 224)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(453, 26)
        Me.TextBox1.TabIndex = 101
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "After you click on ""Copy"" this window will disapear and copy will start in the ba" & _
            "ckground, you'll get a message after the copy completes."
        '
        'CopyResource
        '
        Me.AcceptButton = Me.BtnCopy
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 259)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ChkDateCF)
        Me.Controls.Add(Me.TxtCFPath)
        Me.Controls.Add(Me.ChkCopyCF)
        Me.Controls.Add(Me.ChkDateLS)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.BtnCopyTo)
        Me.Controls.Add(Me.TxtOtherPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtLocalPath)
        Me.Controls.Add(Me.TxtDSDBPath)
        Me.Controls.Add(Me.BtnCopyFrom)
        Me.Controls.Add(Me.TxtCopyFrom)
        Me.Controls.Add(Me.ChkDateTS)
        Me.Controls.Add(Me.ChkCopyDSDB)
        Me.Controls.Add(Me.ChkCopyLocalShare)
        Me.Controls.Add(Me.ChkCopyOtherLocation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CopyResource"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Copy Resource"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCopyFrom As System.Windows.Forms.TextBox
    Friend WithEvents TxtDSDBPath As System.Windows.Forms.TextBox
    Friend WithEvents TxtLocalPath As System.Windows.Forms.TextBox
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnCopyFrom As System.Windows.Forms.Button
    Friend WithEvents TxtOtherPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkCopyDSDB As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCopyLocalShare As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCopyOtherLocation As System.Windows.Forms.CheckBox
    Friend WithEvents BtnCopyTo As System.Windows.Forms.Button
    Friend WithEvents BtnCopy As System.Windows.Forms.Button
    Friend WithEvents ODD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ChkDateTS As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDateLS As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDateCF As System.Windows.Forms.CheckBox
    Friend WithEvents TxtCFPath As System.Windows.Forms.TextBox
    Friend WithEvents ChkCopyCF As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
