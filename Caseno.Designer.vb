<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caseno
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

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caseno))
        Me.TxtCaseno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PBR = New System.Windows.Forms.PictureBox()
        Me.PBG = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbCases = New System.Windows.Forms.ComboBox()
        Me.lblerr = New System.Windows.Forms.Label()
        Me.ChkDonotLoadNotes = New System.Windows.Forms.CheckBox()
        Me.BtnSearchCases = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PBR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCaseno
        '
        Me.TxtCaseno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCaseno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaseno.Location = New System.Drawing.Point(105, 12)
        Me.TxtCaseno.MaxLength = 18
        Me.TxtCaseno.Name = "TxtCaseno"
        Me.TxtCaseno.Size = New System.Drawing.Size(220, 23)
        Me.TxtCaseno.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Case no         -"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(217, 111)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 1
        Me.OK_Button.Text = "&OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(290, 111)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = "&Cancel"
        '
        'PBR
        '
        Me.PBR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBR.Image = Global.EasyNotes.My.Resources.Resources.Cross
        Me.PBR.Location = New System.Drawing.Point(330, 8)
        Me.PBR.Name = "PBR"
        Me.PBR.Size = New System.Drawing.Size(27, 27)
        Me.PBR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBR.TabIndex = 4
        Me.PBR.TabStop = False
        '
        'PBG
        '
        Me.PBG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBG.Image = Global.EasyNotes.My.Resources.Resources.OK
        Me.PBG.Location = New System.Drawing.Point(331, 8)
        Me.PBG.Name = "PBG"
        Me.PBG.Size = New System.Drawing.Size(27, 27)
        Me.PBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBG.TabIndex = 3
        Me.PBG.TabStop = False
        Me.PBG.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Customer       - "
        '
        'TxtCname
        '
        Me.TxtCname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtCname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCname.Location = New System.Drawing.Point(105, 43)
        Me.TxtCname.MaxLength = 18
        Me.TxtCname.Name = "TxtCname"
        Me.TxtCname.Size = New System.Drawing.Size(220, 23)
        Me.TxtCname.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Recent cases - "
        '
        'CmbCases
        '
        Me.CmbCases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCases.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCases.FormattingEnabled = True
        Me.CmbCases.Location = New System.Drawing.Point(105, 75)
        Me.CmbCases.Name = "CmbCases"
        Me.CmbCases.Size = New System.Drawing.Size(253, 24)
        Me.CmbCases.TabIndex = 9
        '
        'lblerr
        '
        Me.lblerr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblerr.AutoSize = True
        Me.lblerr.ForeColor = System.Drawing.Color.Red
        Me.lblerr.Location = New System.Drawing.Point(2, 106)
        Me.lblerr.Name = "lblerr"
        Me.lblerr.Size = New System.Drawing.Size(0, 13)
        Me.lblerr.TabIndex = 10
        '
        'ChkDonotLoadNotes
        '
        Me.ChkDonotLoadNotes.AutoSize = True
        Me.ChkDonotLoadNotes.Location = New System.Drawing.Point(3, 115)
        Me.ChkDonotLoadNotes.Name = "ChkDonotLoadNotes"
        Me.ChkDonotLoadNotes.Size = New System.Drawing.Size(153, 17)
        Me.ChkDonotLoadNotes.TabIndex = 11
        Me.ChkDonotLoadNotes.Text = "Do not load previous notes"
        Me.ChkDonotLoadNotes.UseVisualStyleBackColor = True
        '
        'BtnSearchCases
        '
        Me.BtnSearchCases.BackgroundImage = Global.EasyNotes.My.Resources.Resources.View_Doc
        Me.BtnSearchCases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearchCases.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearchCases.Location = New System.Drawing.Point(331, 41)
        Me.BtnSearchCases.Name = "BtnSearchCases"
        Me.BtnSearchCases.Size = New System.Drawing.Size(27, 27)
        Me.BtnSearchCases.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.BtnSearchCases, "Click to search cases by customer name.")
        Me.BtnSearchCases.UseVisualStyleBackColor = True
        '
        'Caseno
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(364, 152)
        Me.Controls.Add(Me.BtnSearchCases)
        Me.Controls.Add(Me.ChkDonotLoadNotes)
        Me.Controls.Add(Me.CmbCases)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblerr)
        Me.Controls.Add(Me.TxtCaseno)
        Me.Controls.Add(Me.TxtCname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PBR)
        Me.Controls.Add(Me.PBG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Caseno"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Caseno"
        Me.TopMost = True
        CType(Me.PBR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TxtCaseno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBG As System.Windows.Forms.PictureBox
    Friend WithEvents PBR As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbCases As System.Windows.Forms.ComboBox
    Friend WithEvents lblerr As System.Windows.Forms.Label
    Friend WithEvents ChkDonotLoadNotes As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSearchCases As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
