<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteCase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteCase))
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.ChkLocalNts = New System.Windows.Forms.CheckBox()
        Me.ChkLocalres = New System.Windows.Forms.CheckBox()
        Me.ChkPublic = New System.Windows.Forms.CheckBox()
        Me.ChkCF = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(219, 101)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 4
        Me.Cancel_Button.Text = "&Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(218, 130)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 3
        Me.OK_Button.Text = "&Delete"
        '
        'ChkLocalNts
        '
        Me.ChkLocalNts.AutoSize = True
        Me.ChkLocalNts.Checked = True
        Me.ChkLocalNts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkLocalNts.Location = New System.Drawing.Point(6, 19)
        Me.ChkLocalNts.Name = "ChkLocalNts"
        Me.ChkLocalNts.Size = New System.Drawing.Size(137, 17)
        Me.ChkLocalNts.TabIndex = 5
        Me.ChkLocalNts.Text = "Delete local case notes"
        Me.ChkLocalNts.UseVisualStyleBackColor = True
        '
        'ChkLocalres
        '
        Me.ChkLocalres.AutoSize = True
        Me.ChkLocalres.Checked = True
        Me.ChkLocalres.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkLocalres.Location = New System.Drawing.Point(6, 42)
        Me.ChkLocalres.Name = "ChkLocalres"
        Me.ChkLocalres.Size = New System.Drawing.Size(131, 17)
        Me.ChkLocalres.TabIndex = 6
        Me.ChkLocalres.Text = "Delete local resources"
        Me.ChkLocalres.UseVisualStyleBackColor = True
        '
        'ChkPublic
        '
        Me.ChkPublic.AutoSize = True
        Me.ChkPublic.Location = New System.Drawing.Point(6, 19)
        Me.ChkPublic.Name = "ChkPublic"
        Me.ChkPublic.Size = New System.Drawing.Size(177, 17)
        Me.ChkPublic.TabIndex = 7
        Me.ChkPublic.Text = "Delete resources in public share"
        Me.ChkPublic.UseVisualStyleBackColor = True
        '
        'ChkCF
        '
        Me.ChkCF.AutoSize = True
        Me.ChkCF.Location = New System.Drawing.Point(6, 42)
        Me.ChkCF.Name = "ChkCF"
        Me.ChkCF.Size = New System.Drawing.Size(184, 17)
        Me.ChkCF.TabIndex = 8
        Me.ChkCF.Text = "Delete resources in customer files"
        Me.ChkCF.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkLocalNts)
        Me.GroupBox1.Controls.Add(Me.ChkLocalres)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 70)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Local Resource"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkCF)
        Me.GroupBox2.Controls.Add(Me.ChkPublic)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 67)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shared Resource"
        '
        'DeleteCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 161)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteCase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteCase"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents ChkLocalNts As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLocalres As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPublic As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCF As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
