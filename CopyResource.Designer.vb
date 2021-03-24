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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkCopyDSDB = New System.Windows.Forms.CheckBox()
        Me.ChkCopyLocalShare = New System.Windows.Forms.CheckBox()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.ODD = New System.Windows.Forms.FolderBrowserDialog()
        Me.ChkDateTS = New System.Windows.Forms.CheckBox()
        Me.ChkDateLS = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtCopyFrom
        '
        Me.TxtCopyFrom.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCopyFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCopyFrom.Location = New System.Drawing.Point(225, 18)
        Me.TxtCopyFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCopyFrom.Name = "TxtCopyFrom"
        Me.TxtCopyFrom.Size = New System.Drawing.Size(578, 26)
        Me.TxtCopyFrom.TabIndex = 0
        '
        'TxtDSDBPath
        '
        Me.TxtDSDBPath.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDSDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDSDBPath.Location = New System.Drawing.Point(225, 94)
        Me.TxtDSDBPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDSDBPath.Name = "TxtDSDBPath"
        Me.TxtDSDBPath.ReadOnly = True
        Me.TxtDSDBPath.Size = New System.Drawing.Size(617, 26)
        Me.TxtDSDBPath.TabIndex = 3
        '
        'TxtLocalPath
        '
        Me.TxtLocalPath.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLocalPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLocalPath.Location = New System.Drawing.Point(225, 158)
        Me.TxtLocalPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtLocalPath.Name = "TxtLocalPath"
        Me.TxtLocalPath.ReadOnly = True
        Me.TxtLocalPath.Size = New System.Drawing.Size(617, 26)
        Me.TxtLocalPath.TabIndex = 6
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'BtnCopyFrom
        '
        Me.BtnCopyFrom.Location = New System.Drawing.Point(804, 17)
        Me.BtnCopyFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCopyFrom.Name = "BtnCopyFrom"
        Me.BtnCopyFrom.Size = New System.Drawing.Size(39, 34)
        Me.BtnCopyFrom.TabIndex = 1
        Me.BtnCopyFrom.Text = "..."
        Me.BtnCopyFrom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Copy resource From  -"
        '
        'ChkCopyDSDB
        '
        Me.ChkCopyDSDB.AutoSize = True
        Me.ChkCopyDSDB.Checked = True
        Me.ChkCopyDSDB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCopyDSDB.Location = New System.Drawing.Point(20, 95)
        Me.ChkCopyDSDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkCopyDSDB.Name = "ChkCopyDSDB"
        Me.ChkCopyDSDB.Size = New System.Drawing.Size(195, 24)
        Me.ChkCopyDSDB.TabIndex = 2
        Me.ChkCopyDSDB.Text = "Copy to Public Share  -"
        Me.ChkCopyDSDB.UseVisualStyleBackColor = True
        '
        'ChkCopyLocalShare
        '
        Me.ChkCopyLocalShare.AutoSize = True
        Me.ChkCopyLocalShare.Checked = True
        Me.ChkCopyLocalShare.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCopyLocalShare.Location = New System.Drawing.Point(20, 162)
        Me.ChkCopyLocalShare.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkCopyLocalShare.Name = "ChkCopyLocalShare"
        Me.ChkCopyLocalShare.Size = New System.Drawing.Size(191, 24)
        Me.ChkCopyLocalShare.TabIndex = 5
        Me.ChkCopyLocalShare.Text = "Copy to Local Share  -"
        Me.ChkCopyLocalShare.UseVisualStyleBackColor = True
        '
        'BtnCopy
        '
        Me.BtnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCopy.Enabled = False
        Me.BtnCopy.Location = New System.Drawing.Point(730, 265)
        Me.BtnCopy.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(112, 35)
        Me.BtnCopy.TabIndex = 11
        Me.BtnCopy.Text = "&Copy"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'ChkDateTS
        '
        Me.ChkDateTS.AutoSize = True
        Me.ChkDateTS.Checked = True
        Me.ChkDateTS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDateTS.Location = New System.Drawing.Point(478, 125)
        Me.ChkDateTS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkDateTS.Name = "ChkDateTS"
        Me.ChkDateTS.Size = New System.Drawing.Size(358, 24)
        Me.ChkDateTS.TabIndex = 4
        Me.ChkDateTS.Text = "Create and copy to directory with today's Date"
        Me.ChkDateTS.UseVisualStyleBackColor = True
        '
        'ChkDateLS
        '
        Me.ChkDateLS.AutoSize = True
        Me.ChkDateLS.Checked = True
        Me.ChkDateLS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDateLS.Location = New System.Drawing.Point(478, 189)
        Me.ChkDateLS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkDateLS.Name = "ChkDateLS"
        Me.ChkDateLS.Size = New System.Drawing.Size(358, 24)
        Me.ChkDateLS.TabIndex = 7
        Me.ChkDateLS.Text = "Create and copy to directory with today's Date"
        Me.ChkDateLS.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(20, 260)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(680, 40)
        Me.TextBox1.TabIndex = 101
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "After you click on ""Copy"" this window will disapear and copy will start in the ba" &
    "ckground, you'll get a message after the copy completes."
        '
        'CopyResource
        '
        Me.AcceptButton = Me.BtnCopy
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 313)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ChkDateLS)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtLocalPath)
        Me.Controls.Add(Me.TxtDSDBPath)
        Me.Controls.Add(Me.BtnCopyFrom)
        Me.Controls.Add(Me.TxtCopyFrom)
        Me.Controls.Add(Me.ChkDateTS)
        Me.Controls.Add(Me.ChkCopyDSDB)
        Me.Controls.Add(Me.ChkCopyLocalShare)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkCopyDSDB As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCopyLocalShare As System.Windows.Forms.CheckBox
    Friend WithEvents BtnCopy As System.Windows.Forms.Button
    Friend WithEvents ODD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ChkDateTS As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDateLS As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
