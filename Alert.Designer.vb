<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alert))
        Me.TxtCaseno = New System.Windows.Forms.TextBox()
        Me.CboPriority = New System.Windows.Forms.ComboBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboAction = New System.Windows.Forms.ComboBox()
        Me.LblCNO = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtCaseno
        '
        Me.TxtCaseno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCaseno.Location = New System.Drawing.Point(96, 12)
        Me.TxtCaseno.MaxLength = 18
        Me.TxtCaseno.Name = "TxtCaseno"
        Me.TxtCaseno.Size = New System.Drawing.Size(177, 20)
        Me.TxtCaseno.TabIndex = 0
        '
        'CboPriority
        '
        Me.CboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPriority.FormattingEnabled = True
        Me.CboPriority.Items.AddRange(New Object() {"Medium", "Low", "High"})
        Me.CboPriority.Location = New System.Drawing.Point(96, 65)
        Me.CboPriority.MaxLength = 25
        Me.CboPriority.Name = "CboPriority"
        Me.CboPriority.Size = New System.Drawing.Size(177, 21)
        Me.CboPriority.TabIndex = 2
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(198, 101)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(96, 101)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Case no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Action"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Priority"
        '
        'CboAction
        '
        Me.CboAction.FormattingEnabled = True
        Me.CboAction.Items.AddRange(New Object() {"Write solution", "Analyze trace/dump", "TM recovery", "Consult TM", "Consult TL", "Consult CO", "Callback", "Repro", "Refund", "Escalate"})
        Me.CboAction.Location = New System.Drawing.Point(96, 38)
        Me.CboAction.MaxLength = 50
        Me.CboAction.Name = "CboAction"
        Me.CboAction.Size = New System.Drawing.Size(177, 21)
        Me.CboAction.TabIndex = 8
        '
        'LblCNO
        '
        Me.LblCNO.AutoSize = True
        Me.LblCNO.BackColor = System.Drawing.Color.Transparent
        Me.LblCNO.ForeColor = System.Drawing.Color.Red
        Me.LblCNO.Location = New System.Drawing.Point(14, 135)
        Me.LblCNO.Name = "LblCNO"
        Me.LblCNO.Size = New System.Drawing.Size(142, 13)
        Me.LblCNO.TabIndex = 9
        Me.LblCNO.Text = "Note : This case already has"
        '
        'Alert
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(284, 132)
        Me.Controls.Add(Me.CboAction)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.CboPriority)
        Me.Controls.Add(Me.TxtCaseno)
        Me.Controls.Add(Me.LblCNO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Alert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Reminder"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCaseno As System.Windows.Forms.TextBox
    Friend WithEvents CboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboAction As System.Windows.Forms.ComboBox
    Friend WithEvents LblCNO As System.Windows.Forms.Label
End Class
