<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CleanOldCases
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CleanOldCases))
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.DFM = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EasyNotes = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Selectt = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastAccess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon
        Me.DG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DFM, Me.EasyNotes, Me.Selectt, Me.CaseNumber, Me.CustomerName, Me.LastAccess, Me.DataSize})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG.Location = New System.Drawing.Point(-2, 2)
        Me.DG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG.RowHeadersVisible = False
        Me.DG.RowHeadersWidth = 62
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon
        Me.DG.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG.Size = New System.Drawing.Size(904, 588)
        Me.DG.TabIndex = 2
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Location = New System.Drawing.Point(762, 598)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(122, 35)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "D&elete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'DFM
        '
        Me.DFM.FillWeight = 60.0!
        Me.DFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DFM.Frozen = True
        Me.DFM.HeaderText = "DFM"
        Me.DFM.MinimumWidth = 60
        Me.DFM.Name = "DFM"
        Me.DFM.ReadOnly = True
        Me.DFM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DFM.Text = "DFM"
        Me.DFM.UseColumnTextForButtonValue = True
        Me.DFM.Width = 60
        '
        'EasyNotes
        '
        Me.EasyNotes.FillWeight = 70.0!
        Me.EasyNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EasyNotes.Frozen = True
        Me.EasyNotes.HeaderText = "EasyNotes"
        Me.EasyNotes.MinimumWidth = 70
        Me.EasyNotes.Name = "EasyNotes"
        Me.EasyNotes.ReadOnly = True
        Me.EasyNotes.Text = "EasyNotes"
        Me.EasyNotes.UseColumnTextForButtonValue = True
        Me.EasyNotes.Width = 70
        '
        'Selectt
        '
        Me.Selectt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Selectt.DataPropertyName = "Select"
        Me.Selectt.FalseValue = "False"
        Me.Selectt.Frozen = True
        Me.Selectt.HeaderText = "Select"
        Me.Selectt.IndeterminateValue = ""
        Me.Selectt.MinimumWidth = 8
        Me.Selectt.Name = "Selectt"
        Me.Selectt.ReadOnly = True
        Me.Selectt.TrueValue = "True"
        Me.Selectt.Width = 62
        '
        'CaseNumber
        '
        Me.CaseNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CaseNumber.DataPropertyName = "Case Number"
        Me.CaseNumber.HeaderText = "Case Number"
        Me.CaseNumber.MinimumWidth = 8
        Me.CaseNumber.Name = "CaseNumber"
        Me.CaseNumber.ReadOnly = True
        Me.CaseNumber.Width = 148
        '
        'CustomerName
        '
        Me.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CustomerName.DataPropertyName = "Customer Name"
        Me.CustomerName.FillWeight = 150.0!
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.MinimumWidth = 8
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        Me.CustomerName.Width = 153
        '
        'LastAccess
        '
        Me.LastAccess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LastAccess.DataPropertyName = "Last Access"
        Me.LastAccess.FillWeight = 150.0!
        Me.LastAccess.HeaderText = "Last Access"
        Me.LastAccess.MinimumWidth = 8
        Me.LastAccess.Name = "LastAccess"
        Me.LastAccess.ReadOnly = True
        Me.LastAccess.Width = 128
        '
        'DataSize
        '
        Me.DataSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataSize.DataPropertyName = "Data Size"
        Me.DataSize.HeaderText = "Data Size"
        Me.DataSize.MinimumWidth = 80
        Me.DataSize.Name = "DataSize"
        Me.DataSize.ReadOnly = True
        Me.DataSize.Width = 81
        '
        'CleanOldCases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 648)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.DG)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CleanOldCases"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delete old cases"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents DFM As DataGridViewButtonColumn
    Friend WithEvents EasyNotes As DataGridViewButtonColumn
    Friend WithEvents Selectt As DataGridViewCheckBoxColumn
    Friend WithEvents CaseNumber As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents LastAccess As DataGridViewTextBoxColumn
    Friend WithEvents DataSize As DataGridViewTextBoxColumn
End Class
