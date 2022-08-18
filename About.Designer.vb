<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.BackColor = System.Drawing.Color.White
        Me.TextBoxDescription.Location = New System.Drawing.Point(23, 68)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(9, 5, 4, 5)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDescription.Size = New System.Drawing.Size(820, 330)
        Me.TextBoxDescription.TabIndex = 1
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        '
        'LabelVersion
        '
        Me.LabelVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelVersion.Location = New System.Drawing.Point(226, 262)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(9, 0, 4, 0)
        Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 26)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(0, 26)
        Me.LabelVersion.TabIndex = 5
        Me.LabelVersion.Text = "Version - 1.0"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCopyright
        '
        Me.LabelCopyright.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelCopyright.Location = New System.Drawing.Point(226, 235)
        Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(9, 0, 4, 0)
        Me.LabelCopyright.MaximumSize = New System.Drawing.Size(0, 26)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(0, 26)
        Me.LabelCopyright.TabIndex = 2
        Me.LabelCopyright.Text = "Copyright - Copyright © Microsoft 2007"
        Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.SystemColors.Control
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OKButton.Location = New System.Drawing.Point(723, 425)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(122, 35)
        Me.OKButton.TabIndex = 6
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'About
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(862, 478)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.Padding = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button

End Class
