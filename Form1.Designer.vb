<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Dim sc As New SplashScreen

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

    Public Sub New()
        'Me.Visible = False
        'sc.Show()
        'System.Threading.Thread.Sleep(1000)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        sc.Show()
        'sc.Close()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CMTV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenInNewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailContentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyContentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabCM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseTabToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteThisNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtTimer = New System.Windows.Forms.TextBox()
        Me.NewCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DGAlert = New System.Windows.Forms.DataGridView()
        Me.Btn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblCaseno = New System.Windows.Forms.TextBox()
        Me.LblCustomer = New System.Windows.Forms.TextBox()
        Me.lblremote = New System.Windows.Forms.TextBox()
        Me.DGRemote = New System.Windows.Forms.DataGridView()
        Me.lbllocal = New System.Windows.Forms.TextBox()
        Me.DGLocal = New System.Windows.Forms.DataGridView()
        Me.DGFTP = New System.Windows.Forms.DataGridView()
        Me.DGCF = New System.Windows.Forms.DataGridView()
        Me.BtnTeamShare = New System.Windows.Forms.Button()
        Me.BtnOpendir = New System.Windows.Forms.Button()
        Me.BtnOpenFtp = New System.Windows.Forms.Button()
        Me.BtnOpenCF = New System.Windows.Forms.Button()
        Me.BtnTimer = New System.Windows.Forms.Button()
        Me.ChkBullet = New System.Windows.Forms.CheckBox()
        Me.mnuBrowserTab = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MnuCloseactivebrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerTabTime = New System.Windows.Forms.Timer(Me.components)
        Me.Chkwordwrap = New System.Windows.Forms.CheckBox()
        Me.PanelBB = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TC1 = New System.Windows.Forms.TabControl()
        Me.TPTemplates = New System.Windows.Forms.TabPage()
        Me.TV = New System.Windows.Forms.TreeView()
        Me.TPAlerts = New System.Windows.Forms.TabPage()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnDeleteselected = New System.Windows.Forms.Button()
        Me.BtnOpenSelected = New System.Windows.Forms.Button()
        Me.BtnCopyselected = New System.Windows.Forms.Button()
        Me.TBFile = New System.Windows.Forms.TabControl()
        Me.TPLocal = New System.Windows.Forms.TabPage()
        Me.TPFTP = New System.Windows.Forms.TabPage()
        Me.LblFTP = New System.Windows.Forms.TextBox()
        Me.TPCF = New System.Windows.Forms.TabPage()
        Me.LblCF = New System.Windows.Forms.TextBox()
        Me.TPTeam = New System.Windows.Forms.TabPage()
        Me.TCMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TC = New System.Windows.Forms.TabControl()
        Me.BtnCopyNotes = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.PicAlert = New System.Windows.Forms.PictureBox()
        Me.BtnMSSolve = New System.Windows.Forms.Button()
        Me.PBLS = New System.Windows.Forms.PictureBox()
        Me.PBFTP = New System.Windows.Forms.PictureBox()
        Me.PBCF = New System.Windows.Forms.PictureBox()
        Me.PBPS = New System.Windows.Forms.PictureBox()
        Me.BtnForeward = New System.Windows.Forms.Button()
        Me.BtnrefreshPage = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.Btnmail = New System.Windows.Forms.Button()
        Me.Btncopy = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.NewCaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyResourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendMailToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerStartStopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHidePanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaseNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCaseDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamShareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FTPWorkspaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnHide = New System.Windows.Forms.Button()
        Me.BtnDeleteCase = New System.Windows.Forms.Button()
        Me.BtnAlert = New System.Windows.Forms.Button()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Btnsetting = New System.Windows.Forms.Button()
        Me.BtnOpenNotes = New System.Windows.Forms.Button()
        Me.BtnDeletetemplate = New System.Windows.Forms.Button()
        Me.BtnCreateTemplate = New System.Windows.Forms.Button()
        Me.CMTV.SuspendLayout()
        Me.TabCM.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRemote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGFTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGCF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuBrowserTab.SuspendLayout()
        Me.PanelBB.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TC1.SuspendLayout()
        Me.TPTemplates.SuspendLayout()
        Me.TPAlerts.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TBFile.SuspendLayout()
        Me.TPLocal.SuspendLayout()
        Me.TPFTP.SuspendLayout()
        Me.TPCF.SuspendLayout()
        Me.TPTeam.SuspendLayout()
        Me.TCMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PicAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMTV
        '
        Me.CMTV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenInNewTabToolStripMenuItem, Me.OpenFileToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.MailContentToolStripMenuItem, Me.CopyContentToolStripMenuItem})
        Me.CMTV.Name = "CMTV"
        Me.CMTV.Size = New System.Drawing.Size(162, 114)
        '
        'OpenInNewTabToolStripMenuItem
        '
        Me.OpenInNewTabToolStripMenuItem.Name = "OpenInNewTabToolStripMenuItem"
        Me.OpenInNewTabToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenInNewTabToolStripMenuItem.Text = "Open in new tab"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open file"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'MailContentToolStripMenuItem
        '
        Me.MailContentToolStripMenuItem.Name = "MailContentToolStripMenuItem"
        Me.MailContentToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.MailContentToolStripMenuItem.Text = "Mail Content"
        '
        'CopyContentToolStripMenuItem
        '
        Me.CopyContentToolStripMenuItem.Name = "CopyContentToolStripMenuItem"
        Me.CopyContentToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CopyContentToolStripMenuItem.Text = "Copy Content"
        '
        'TabCM
        '
        Me.TabCM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseTabToolStripMenuItem1, Me.DeleteThisNoteToolStripMenuItem})
        Me.TabCM.Name = "TabCM"
        Me.TabCM.Size = New System.Drawing.Size(162, 48)
        '
        'CloseTabToolStripMenuItem1
        '
        Me.CloseTabToolStripMenuItem1.Name = "CloseTabToolStripMenuItem1"
        Me.CloseTabToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.CloseTabToolStripMenuItem1.Text = "Close active tab"
        '
        'DeleteThisNoteToolStripMenuItem
        '
        Me.DeleteThisNoteToolStripMenuItem.Name = "DeleteThisNoteToolStripMenuItem"
        Me.DeleteThisNoteToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DeleteThisNoteToolStripMenuItem.Text = "Delete active tab"
        '
        'TxtTimer
        '
        Me.TxtTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTimer.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTimer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTimer.ForeColor = System.Drawing.Color.Black
        Me.TxtTimer.Location = New System.Drawing.Point(835, 22)
        Me.TxtTimer.Name = "TxtTimer"
        Me.TxtTimer.ReadOnly = True
        Me.TxtTimer.Size = New System.Drawing.Size(143, 37)
        Me.TxtTimer.TabIndex = 18
        Me.TxtTimer.TabStop = False
        Me.TxtTimer.Text = "00:00:00"
        '
        'NewCaseToolStripMenuItem
        '
        Me.NewCaseToolStripMenuItem.Name = "NewCaseToolStripMenuItem"
        Me.NewCaseToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.NewCaseToolStripMenuItem.Text = "&New Case"
        '
        'SaveCaseToolStripMenuItem
        '
        Me.SaveCaseToolStripMenuItem.Name = "SaveCaseToolStripMenuItem"
        Me.SaveCaseToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.SaveCaseToolStripMenuItem.Text = "&Save Case"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.SettingsToolStripMenuItem.Text = "&Copy Resource"
        '
        'SendMailToolStripMenuItem
        '
        Me.SendMailToolStripMenuItem.Name = "SendMailToolStripMenuItem"
        Me.SendMailToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.SendMailToolStripMenuItem.Text = "Send &Mail"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem1.Text = "S&ettings"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.RefreshToolStripMenuItem.Text = "Re&fresh"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaseToolStripMenuItem, Me.ActionToolStripMenuItem, Me.OpenToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(974, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CaseToolStripMenuItem
        '
        Me.CaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCaseToolStripMenuItem1, Me.NewTemplateToolStripMenuItem, Me.DeleteTemplateToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.CaseToolStripMenuItem.Name = "CaseToolStripMenuItem"
        Me.CaseToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.CaseToolStripMenuItem.Text = "Ca&se"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyResourceToolStripMenuItem, Me.SendMailToolStripMenuItem1, Me.RefreshToolStripMenuItem1, Me.AlertToolStripMenuItem, Me.SettingsToolStripMenuItem2, Me.ManageCaseToolStripMenuItem, Me.CloseTabToolStripMenuItem, Me.TimerStartStopToolStripMenuItem, Me.DeleteCaseToolStripMenuItem, Me.ShowHidePanelToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ActionToolStripMenuItem.Text = "&Action"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaseNotesToolStripMenuItem, Me.OpenCaseDirectoryToolStripMenuItem, Me.TeamShareToolStripMenuItem, Me.FTPWorkspaceToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.ToolStripComboBox1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"50", "60", "70", "80", "90", "100"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(75, 23)
        Me.ToolStripComboBox1.ToolTipText = "Select Opacity level"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'DGAlert
        '
        Me.DGAlert.AllowUserToAddRows = False
        Me.DGAlert.AllowUserToDeleteRows = False
        Me.DGAlert.AllowUserToOrderColumns = True
        Me.DGAlert.AllowUserToResizeRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        Me.DGAlert.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DGAlert.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGAlert.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlert.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DGAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAlert.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Btn})
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGAlert.DefaultCellStyle = DataGridViewCellStyle23
        Me.DGAlert.Location = New System.Drawing.Point(-2, -2)
        Me.DGAlert.MultiSelect = False
        Me.DGAlert.Name = "DGAlert"
        Me.DGAlert.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlert.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.DGAlert.RowHeadersVisible = False
        Me.DGAlert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGAlert.Size = New System.Drawing.Size(272, 317)
        Me.DGAlert.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DGAlert, "Doubleclick to open a case.")
        '
        'Btn
        '
        Me.Btn.HeaderText = ""
        Me.Btn.Name = "Btn"
        Me.Btn.ReadOnly = True
        Me.Btn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Btn.Text = "X"
        Me.Btn.ToolTipText = "Click to remove reminder."
        Me.Btn.UseColumnTextForButtonValue = True
        Me.Btn.Width = 20
        '
        'lblCaseno
        '
        Me.lblCaseno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaseno.BackColor = System.Drawing.SystemColors.Window
        Me.lblCaseno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCaseno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaseno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCaseno.Location = New System.Drawing.Point(0, -1)
        Me.lblCaseno.Name = "lblCaseno"
        Me.lblCaseno.ReadOnly = True
        Me.lblCaseno.Size = New System.Drawing.Size(253, 22)
        Me.lblCaseno.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.lblCaseno, "Double click to add a new case no.")
        '
        'LblCustomer
        '
        Me.LblCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCustomer.BackColor = System.Drawing.SystemColors.Window
        Me.LblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblCustomer.Location = New System.Drawing.Point(0, 24)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.ReadOnly = True
        Me.LblCustomer.Size = New System.Drawing.Size(277, 22)
        Me.LblCustomer.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.LblCustomer, "Double click to add a new case no.")
        '
        'lblremote
        '
        Me.lblremote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblremote.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblremote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblremote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremote.ForeColor = System.Drawing.Color.Maroon
        Me.lblremote.Location = New System.Drawing.Point(0, 0)
        Me.lblremote.Margin = New System.Windows.Forms.Padding(0)
        Me.lblremote.Name = "lblremote"
        Me.lblremote.ReadOnly = True
        Me.lblremote.Size = New System.Drawing.Size(256, 16)
        Me.lblremote.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.lblremote, "Drag and drop your files directly in the grid below.")
        '
        'DGRemote
        '
        Me.DGRemote.AllowDrop = True
        Me.DGRemote.AllowUserToAddRows = False
        Me.DGRemote.AllowUserToDeleteRows = False
        Me.DGRemote.AllowUserToOrderColumns = True
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.LightBlue
        Me.DGRemote.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.DGRemote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGRemote.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRemote.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.DGRemote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGRemote.DefaultCellStyle = DataGridViewCellStyle27
        Me.DGRemote.Location = New System.Drawing.Point(-2, 14)
        Me.DGRemote.MultiSelect = False
        Me.DGRemote.Name = "DGRemote"
        Me.DGRemote.ReadOnly = True
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRemote.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.DGRemote.RowHeadersVisible = False
        Me.DGRemote.RowTemplate.ReadOnly = True
        Me.DGRemote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGRemote.Size = New System.Drawing.Size(276, 207)
        Me.DGRemote.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.DGRemote, "Drag and drop files here.")
        '
        'lbllocal
        '
        Me.lbllocal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbllocal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbllocal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbllocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocal.ForeColor = System.Drawing.Color.Maroon
        Me.lbllocal.Location = New System.Drawing.Point(0, 0)
        Me.lbllocal.Name = "lbllocal"
        Me.lbllocal.ReadOnly = True
        Me.lbllocal.Size = New System.Drawing.Size(257, 16)
        Me.lbllocal.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.lbllocal, "Drag and drop your files directly in the grid below.")
        '
        'DGLocal
        '
        Me.DGLocal.AllowDrop = True
        Me.DGLocal.AllowUserToAddRows = False
        Me.DGLocal.AllowUserToDeleteRows = False
        Me.DGLocal.AllowUserToOrderColumns = True
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.LightBlue
        Me.DGLocal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
        Me.DGLocal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGLocal.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGLocal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.DGLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLocal.DefaultCellStyle = DataGridViewCellStyle31
        Me.DGLocal.Location = New System.Drawing.Point(-2, 14)
        Me.DGLocal.MultiSelect = False
        Me.DGLocal.Name = "DGLocal"
        Me.DGLocal.ReadOnly = True
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGLocal.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.DGLocal.RowHeadersVisible = False
        Me.DGLocal.RowTemplate.ReadOnly = True
        Me.DGLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGLocal.Size = New System.Drawing.Size(276, 207)
        Me.DGLocal.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.DGLocal, "Drag and drop files here.")
        '
        'DGFTP
        '
        Me.DGFTP.AllowDrop = True
        Me.DGFTP.AllowUserToAddRows = False
        Me.DGFTP.AllowUserToDeleteRows = False
        Me.DGFTP.AllowUserToOrderColumns = True
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.LightBlue
        Me.DGFTP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle33
        Me.DGFTP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGFTP.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGFTP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.DGFTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGFTP.DefaultCellStyle = DataGridViewCellStyle35
        Me.DGFTP.Location = New System.Drawing.Point(-2, 14)
        Me.DGFTP.MultiSelect = False
        Me.DGFTP.Name = "DGFTP"
        Me.DGFTP.ReadOnly = True
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGFTP.RowHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.DGFTP.RowHeadersVisible = False
        Me.DGFTP.RowTemplate.ReadOnly = True
        Me.DGFTP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGFTP.Size = New System.Drawing.Size(276, 207)
        Me.DGFTP.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.DGFTP, "Drag and drop files here.")
        '
        'DGCF
        '
        Me.DGCF.AllowDrop = True
        Me.DGCF.AllowUserToAddRows = False
        Me.DGCF.AllowUserToDeleteRows = False
        Me.DGCF.AllowUserToOrderColumns = True
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.LightBlue
        Me.DGCF.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.DGCF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCF.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCF.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle38
        Me.DGCF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGCF.DefaultCellStyle = DataGridViewCellStyle39
        Me.DGCF.Location = New System.Drawing.Point(-2, 14)
        Me.DGCF.MultiSelect = False
        Me.DGCF.Name = "DGCF"
        Me.DGCF.ReadOnly = True
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCF.RowHeadersDefaultCellStyle = DataGridViewCellStyle40
        Me.DGCF.RowHeadersVisible = False
        Me.DGCF.RowTemplate.ReadOnly = True
        Me.DGCF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGCF.Size = New System.Drawing.Size(276, 207)
        Me.DGCF.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.DGCF, "Drag and drop files here.")
        '
        'BtnTeamShare
        '
        Me.BtnTeamShare.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTeamShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTeamShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTeamShare.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.BtnTeamShare.Location = New System.Drawing.Point(255, 0)
        Me.BtnTeamShare.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTeamShare.Name = "BtnTeamShare"
        Me.BtnTeamShare.Size = New System.Drawing.Size(16, 16)
        Me.BtnTeamShare.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.BtnTeamShare, "Open team share")
        Me.BtnTeamShare.UseVisualStyleBackColor = True
        '
        'BtnOpendir
        '
        Me.BtnOpendir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpendir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOpendir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpendir.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.BtnOpendir.Location = New System.Drawing.Point(255, 0)
        Me.BtnOpendir.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnOpendir.Name = "BtnOpendir"
        Me.BtnOpendir.Size = New System.Drawing.Size(16, 16)
        Me.BtnOpendir.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.BtnOpendir, "Open Local Case Directory")
        Me.BtnOpendir.UseVisualStyleBackColor = True
        '
        'BtnOpenFtp
        '
        Me.BtnOpenFtp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenFtp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOpenFtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenFtp.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.BtnOpenFtp.Location = New System.Drawing.Point(255, 0)
        Me.BtnOpenFtp.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnOpenFtp.Name = "BtnOpenFtp"
        Me.BtnOpenFtp.Size = New System.Drawing.Size(16, 16)
        Me.BtnOpenFtp.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.BtnOpenFtp, "Open FTP Workspace")
        Me.BtnOpenFtp.UseVisualStyleBackColor = True
        '
        'BtnOpenCF
        '
        Me.BtnOpenCF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenCF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOpenCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenCF.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.BtnOpenCF.Location = New System.Drawing.Point(255, 0)
        Me.BtnOpenCF.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnOpenCF.Name = "BtnOpenCF"
        Me.BtnOpenCF.Size = New System.Drawing.Size(16, 16)
        Me.BtnOpenCF.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.BtnOpenCF, "Open team share")
        Me.BtnOpenCF.UseVisualStyleBackColor = True
        '
        'BtnTimer
        '
        Me.BtnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTimer.Location = New System.Drawing.Point(580, 27)
        Me.BtnTimer.Name = "BtnTimer"
        Me.BtnTimer.Size = New System.Drawing.Size(30, 30)
        Me.BtnTimer.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.BtnTimer, "Stop/Start Task Timer")
        Me.BtnTimer.UseVisualStyleBackColor = True
        Me.BtnTimer.Visible = False
        '
        'ChkBullet
        '
        Me.ChkBullet.AutoSize = True
        Me.ChkBullet.Location = New System.Drawing.Point(207, 4)
        Me.ChkBullet.Name = "ChkBullet"
        Me.ChkBullet.Size = New System.Drawing.Size(130, 17)
        Me.ChkBullet.TabIndex = 0
        Me.ChkBullet.Text = "&Enable bullet (Ctrl + B)"
        Me.ChkBullet.UseVisualStyleBackColor = True
        '
        'mnuBrowserTab
        '
        Me.mnuBrowserTab.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCloseactivebrowser})
        Me.mnuBrowserTab.Name = "ContextMenuStrip1"
        Me.mnuBrowserTab.ShowItemToolTips = False
        Me.mnuBrowserTab.Size = New System.Drawing.Size(185, 26)
        Me.mnuBrowserTab.Text = "BrowserTab"
        '
        'MnuCloseactivebrowser
        '
        Me.MnuCloseactivebrowser.Name = "MnuCloseactivebrowser"
        Me.MnuCloseactivebrowser.Size = New System.Drawing.Size(184, 22)
        Me.MnuCloseactivebrowser.Text = "Close Active Browser"
        '
        'TimerTabTime
        '
        Me.TimerTabTime.Enabled = True
        Me.TimerTabTime.Interval = 1000
        '
        'Chkwordwrap
        '
        Me.Chkwordwrap.AutoSize = True
        Me.Chkwordwrap.Checked = True
        Me.Chkwordwrap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chkwordwrap.Location = New System.Drawing.Point(356, 4)
        Me.Chkwordwrap.Name = "Chkwordwrap"
        Me.Chkwordwrap.Size = New System.Drawing.Size(78, 17)
        Me.Chkwordwrap.TabIndex = 1
        Me.Chkwordwrap.Text = "&Word wrap"
        Me.Chkwordwrap.UseVisualStyleBackColor = True
        '
        'PanelBB
        '
        Me.PanelBB.Controls.Add(Me.BtnForeward)
        Me.PanelBB.Controls.Add(Me.BtnrefreshPage)
        Me.PanelBB.Controls.Add(Me.BtnPrevious)
        Me.PanelBB.Location = New System.Drawing.Point(461, 27)
        Me.PanelBB.Name = "PanelBB"
        Me.PanelBB.Size = New System.Drawing.Size(99, 31)
        Me.PanelBB.TabIndex = 25
        Me.PanelBB.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AllowDrop = True
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 60)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(1)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AllowDrop = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1MinSize = 0
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AllowDrop = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TCMain)
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(974, 664)
        Me.SplitContainer1.SplitterDistance = 277
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PicAlert)
        Me.Panel3.Controls.Add(Me.TC1)
        Me.Panel3.Controls.Add(Me.BtnMSSolve)
        Me.Panel3.Controls.Add(Me.lblCaseno)
        Me.Panel3.Controls.Add(Me.LblCustomer)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(275, 389)
        Me.Panel3.TabIndex = 27
        '
        'TC1
        '
        Me.TC1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC1.Controls.Add(Me.TPTemplates)
        Me.TC1.Controls.Add(Me.TPAlerts)
        Me.TC1.Location = New System.Drawing.Point(0, 52)
        Me.TC1.Name = "TC1"
        Me.TC1.SelectedIndex = 0
        Me.TC1.Size = New System.Drawing.Size(277, 338)
        Me.TC1.TabIndex = 23
        '
        'TPTemplates
        '
        Me.TPTemplates.Controls.Add(Me.TV)
        Me.TPTemplates.Location = New System.Drawing.Point(4, 22)
        Me.TPTemplates.Margin = New System.Windows.Forms.Padding(0)
        Me.TPTemplates.Name = "TPTemplates"
        Me.TPTemplates.Size = New System.Drawing.Size(269, 312)
        Me.TPTemplates.TabIndex = 0
        Me.TPTemplates.Text = "Templates"
        Me.TPTemplates.UseVisualStyleBackColor = True
        '
        'TV
        '
        Me.TV.AllowDrop = True
        Me.TV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TV.ContextMenuStrip = Me.CMTV
        Me.TV.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TV.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TV.HideSelection = False
        Me.TV.Location = New System.Drawing.Point(-4, -2)
        Me.TV.Name = "TV"
        Me.TV.ShowLines = False
        Me.TV.Size = New System.Drawing.Size(276, 317)
        Me.TV.TabIndex = 1
        '
        'TPAlerts
        '
        Me.TPAlerts.BackColor = System.Drawing.Color.Transparent
        Me.TPAlerts.Controls.Add(Me.DGAlert)
        Me.TPAlerts.Location = New System.Drawing.Point(4, 22)
        Me.TPAlerts.Margin = New System.Windows.Forms.Padding(0)
        Me.TPAlerts.Name = "TPAlerts"
        Me.TPAlerts.Size = New System.Drawing.Size(269, 312)
        Me.TPAlerts.TabIndex = 1
        Me.TPAlerts.Text = "(0) Reminder(s)"
        Me.TPAlerts.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 389)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(275, 5)
        Me.Splitter1.TabIndex = 24
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnDeleteselected)
        Me.Panel1.Controls.Add(Me.BtnOpenSelected)
        Me.Panel1.Controls.Add(Me.BtnCopyselected)
        Me.Panel1.Controls.Add(Me.TBFile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 394)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 268)
        Me.Panel1.TabIndex = 23
        '
        'BtnDeleteselected
        '
        Me.BtnDeleteselected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteselected.Location = New System.Drawing.Point(121, 245)
        Me.BtnDeleteselected.Name = "BtnDeleteselected"
        Me.BtnDeleteselected.Size = New System.Drawing.Size(60, 20)
        Me.BtnDeleteselected.TabIndex = 27
        Me.BtnDeleteselected.Text = "&DELETE"
        Me.BtnDeleteselected.UseVisualStyleBackColor = True
        '
        'BtnOpenSelected
        '
        Me.BtnOpenSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenSelected.Location = New System.Drawing.Point(3, 245)
        Me.BtnOpenSelected.Name = "BtnOpenSelected"
        Me.BtnOpenSelected.Size = New System.Drawing.Size(60, 20)
        Me.BtnOpenSelected.TabIndex = 25
        Me.BtnOpenSelected.Text = "O&PEN"
        Me.BtnOpenSelected.UseVisualStyleBackColor = True
        '
        'BtnCopyselected
        '
        Me.BtnCopyselected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCopyselected.Location = New System.Drawing.Point(62, 245)
        Me.BtnCopyselected.Name = "BtnCopyselected"
        Me.BtnCopyselected.Size = New System.Drawing.Size(60, 20)
        Me.BtnCopyselected.TabIndex = 26
        Me.BtnCopyselected.Text = "&COPY"
        Me.BtnCopyselected.UseVisualStyleBackColor = True
        '
        'TBFile
        '
        Me.TBFile.AllowDrop = True
        Me.TBFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBFile.Controls.Add(Me.TPLocal)
        Me.TBFile.Controls.Add(Me.TPFTP)
        Me.TBFile.Controls.Add(Me.TPCF)
        Me.TBFile.Controls.Add(Me.TPTeam)
        Me.TBFile.Location = New System.Drawing.Point(0, 0)
        Me.TBFile.Margin = New System.Windows.Forms.Padding(0)
        Me.TBFile.Name = "TBFile"
        Me.TBFile.SelectedIndex = 0
        Me.TBFile.Size = New System.Drawing.Size(279, 246)
        Me.TBFile.TabIndex = 24
        '
        'TPLocal
        '
        Me.TPLocal.Controls.Add(Me.PBLS)
        Me.TPLocal.Controls.Add(Me.BtnOpendir)
        Me.TPLocal.Controls.Add(Me.lbllocal)
        Me.TPLocal.Controls.Add(Me.DGLocal)
        Me.TPLocal.Location = New System.Drawing.Point(4, 22)
        Me.TPLocal.Name = "TPLocal"
        Me.TPLocal.Padding = New System.Windows.Forms.Padding(3)
        Me.TPLocal.Size = New System.Drawing.Size(271, 220)
        Me.TPLocal.TabIndex = 1
        Me.TPLocal.Text = "Local Share"
        Me.TPLocal.UseVisualStyleBackColor = True
        '
        'TPFTP
        '
        Me.TPFTP.Controls.Add(Me.PBFTP)
        Me.TPFTP.Controls.Add(Me.BtnOpenFtp)
        Me.TPFTP.Controls.Add(Me.LblFTP)
        Me.TPFTP.Controls.Add(Me.DGFTP)
        Me.TPFTP.Location = New System.Drawing.Point(4, 22)
        Me.TPFTP.Name = "TPFTP"
        Me.TPFTP.Size = New System.Drawing.Size(271, 220)
        Me.TPFTP.TabIndex = 2
        Me.TPFTP.Text = "FTP"
        Me.TPFTP.UseVisualStyleBackColor = True
        '
        'LblFTP
        '
        Me.LblFTP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFTP.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblFTP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblFTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFTP.ForeColor = System.Drawing.Color.Maroon
        Me.LblFTP.Location = New System.Drawing.Point(0, 0)
        Me.LblFTP.Name = "LblFTP"
        Me.LblFTP.ReadOnly = True
        Me.LblFTP.Size = New System.Drawing.Size(256, 16)
        Me.LblFTP.TabIndex = 22
        '
        'TPCF
        '
        Me.TPCF.Controls.Add(Me.PBCF)
        Me.TPCF.Controls.Add(Me.BtnOpenCF)
        Me.TPCF.Controls.Add(Me.LblCF)
        Me.TPCF.Controls.Add(Me.DGCF)
        Me.TPCF.Location = New System.Drawing.Point(4, 22)
        Me.TPCF.Name = "TPCF"
        Me.TPCF.Size = New System.Drawing.Size(271, 220)
        Me.TPCF.TabIndex = 3
        Me.TPCF.Text = "Customer Files"
        Me.TPCF.UseVisualStyleBackColor = True
        '
        'LblCF
        '
        Me.LblCF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCF.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblCF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCF.ForeColor = System.Drawing.Color.Maroon
        Me.LblCF.Location = New System.Drawing.Point(0, 0)
        Me.LblCF.Name = "LblCF"
        Me.LblCF.ReadOnly = True
        Me.LblCF.Size = New System.Drawing.Size(256, 16)
        Me.LblCF.TabIndex = 23
        '
        'TPTeam
        '
        Me.TPTeam.Controls.Add(Me.PBPS)
        Me.TPTeam.Controls.Add(Me.BtnTeamShare)
        Me.TPTeam.Controls.Add(Me.lblremote)
        Me.TPTeam.Controls.Add(Me.DGRemote)
        Me.TPTeam.Location = New System.Drawing.Point(4, 22)
        Me.TPTeam.Margin = New System.Windows.Forms.Padding(0)
        Me.TPTeam.Name = "TPTeam"
        Me.TPTeam.Size = New System.Drawing.Size(271, 220)
        Me.TPTeam.TabIndex = 0
        Me.TPTeam.Text = "Public Share"
        Me.TPTeam.UseVisualStyleBackColor = True
        '
        'TCMain
        '
        Me.TCMain.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TCMain.AllowDrop = True
        Me.TCMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TCMain.ContextMenuStrip = Me.mnuBrowserTab
        Me.TCMain.Controls.Add(Me.TabPage1)
        Me.TCMain.HotTrack = True
        Me.TCMain.Location = New System.Drawing.Point(-5, -7)
        Me.TCMain.Margin = New System.Windows.Forms.Padding(1)
        Me.TCMain.Name = "TCMain"
        Me.TCMain.SelectedIndex = 0
        Me.TCMain.Size = New System.Drawing.Size(700, 670)
        Me.TCMain.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TC)
        Me.TabPage1.ForeColor = System.Drawing.Color.Maroon
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(692, 644)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "UnClosable"
        Me.TabPage1.Text = "HOME"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TC
        '
        Me.TC.AllowDrop = True
        Me.TC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC.ContextMenuStrip = Me.TabCM
        Me.TC.ItemSize = New System.Drawing.Size(0, 20)
        Me.TC.Location = New System.Drawing.Point(-4, -1)
        Me.TC.Margin = New System.Windows.Forms.Padding(0)
        Me.TC.Name = "TC"
        Me.TC.SelectedIndex = 0
        Me.TC.Size = New System.Drawing.Size(702, 647)
        Me.TC.TabIndex = 28
        '
        'BtnCopyNotes
        '
        Me.BtnCopyNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCopyNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCopyNotes.Location = New System.Drawing.Point(375, 27)
        Me.BtnCopyNotes.Name = "BtnCopyNotes"
        Me.BtnCopyNotes.Size = New System.Drawing.Size(30, 30)
        Me.BtnCopyNotes.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.BtnCopyNotes, "Copy")
        Me.BtnCopyNotes.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnReset.Location = New System.Drawing.Point(734, 26)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(95, 30)
        Me.BtnReset.TabIndex = 19
        Me.BtnReset.Text = "           STOP"
        Me.ToolTip1.SetToolTip(Me.BtnReset, "Reset the timer")
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'PicAlert
        '
        Me.PicAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicAlert.Location = New System.Drawing.Point(67, 56)
        Me.PicAlert.Margin = New System.Windows.Forms.Padding(0)
        Me.PicAlert.Name = "PicAlert"
        Me.PicAlert.Size = New System.Drawing.Size(15, 15)
        Me.PicAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAlert.TabIndex = 25
        Me.PicAlert.TabStop = False
        Me.PicAlert.Visible = False
        '
        'BtnMSSolve
        '
        Me.BtnMSSolve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMSSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMSSolve.Enabled = False
        Me.BtnMSSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMSSolve.Location = New System.Drawing.Point(252, -1)
        Me.BtnMSSolve.Name = "BtnMSSolve"
        Me.BtnMSSolve.Size = New System.Drawing.Size(24, 22)
        Me.BtnMSSolve.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.BtnMSSolve, "Open this MSSolve case")
        Me.BtnMSSolve.UseVisualStyleBackColor = True
        '
        'PBLS
        '
        Me.PBLS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBLS.Location = New System.Drawing.Point(226, 174)
        Me.PBLS.Name = "PBLS"
        Me.PBLS.Size = New System.Drawing.Size(30, 30)
        Me.PBLS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLS.TabIndex = 23
        Me.PBLS.TabStop = False
        Me.PBLS.Visible = False
        '
        'PBFTP
        '
        Me.PBFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBFTP.Location = New System.Drawing.Point(226, 174)
        Me.PBFTP.Name = "PBFTP"
        Me.PBFTP.Size = New System.Drawing.Size(30, 30)
        Me.PBFTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFTP.TabIndex = 25
        Me.PBFTP.TabStop = False
        Me.PBFTP.Visible = False
        '
        'PBCF
        '
        Me.PBCF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBCF.Location = New System.Drawing.Point(226, 174)
        Me.PBCF.Name = "PBCF"
        Me.PBCF.Size = New System.Drawing.Size(30, 30)
        Me.PBCF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCF.TabIndex = 26
        Me.PBCF.TabStop = False
        Me.PBCF.Visible = False
        '
        'PBPS
        '
        Me.PBPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBPS.Location = New System.Drawing.Point(226, 174)
        Me.PBPS.Name = "PBPS"
        Me.PBPS.Size = New System.Drawing.Size(30, 30)
        Me.PBPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPS.TabIndex = 22
        Me.PBPS.TabStop = False
        Me.PBPS.Visible = False
        '
        'BtnForeward
        '
        Me.BtnForeward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnForeward.Enabled = False
        Me.BtnForeward.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnForeward.Location = New System.Drawing.Point(66, 0)
        Me.BtnForeward.Name = "BtnForeward"
        Me.BtnForeward.Size = New System.Drawing.Size(30, 30)
        Me.BtnForeward.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.BtnForeward, "Go foreward")
        Me.BtnForeward.UseVisualStyleBackColor = True
        '
        'BtnrefreshPage
        '
        Me.BtnrefreshPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnrefreshPage.Enabled = False
        Me.BtnrefreshPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnrefreshPage.Location = New System.Drawing.Point(35, 0)
        Me.BtnrefreshPage.Name = "BtnrefreshPage"
        Me.BtnrefreshPage.Size = New System.Drawing.Size(30, 30)
        Me.BtnrefreshPage.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.BtnrefreshPage, "Refresh web page")
        Me.BtnrefreshPage.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrevious.Enabled = False
        Me.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrevious.Location = New System.Drawing.Point(4, 0)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(30, 30)
        Me.BtnPrevious.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BtnPrevious, "Go previous ")
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'Btnmail
        '
        Me.Btnmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnmail.Location = New System.Drawing.Point(65, 27)
        Me.Btnmail.Name = "Btnmail"
        Me.Btnmail.Size = New System.Drawing.Size(30, 30)
        Me.Btnmail.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Btnmail, "Send mail")
        Me.Btnmail.UseVisualStyleBackColor = True
        '
        'Btncopy
        '
        Me.Btncopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btncopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btncopy.Location = New System.Drawing.Point(34, 27)
        Me.Btncopy.Name = "Btncopy"
        Me.Btncopy.Size = New System.Drawing.Size(30, 30)
        Me.Btncopy.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Btncopy, "Copy Resources")
        Me.Btncopy.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnNew.Location = New System.Drawing.Point(3, 27)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(30, 30)
        Me.BtnNew.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BtnNew, "Enter a Case id")
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'NewCaseToolStripMenuItem1
        '
        Me.NewCaseToolStripMenuItem1.Name = "NewCaseToolStripMenuItem1"
        Me.NewCaseToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.NewCaseToolStripMenuItem1.Text = "&New Case"
        '
        'NewTemplateToolStripMenuItem
        '
        Me.NewTemplateToolStripMenuItem.Name = "NewTemplateToolStripMenuItem"
        Me.NewTemplateToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.NewTemplateToolStripMenuItem.Text = "New &Template"
        '
        'DeleteTemplateToolStripMenuItem
        '
        Me.DeleteTemplateToolStripMenuItem.Name = "DeleteTemplateToolStripMenuItem"
        Me.DeleteTemplateToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DeleteTemplateToolStripMenuItem.Text = "&Delete Template"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'CopyResourceToolStripMenuItem
        '
        Me.CopyResourceToolStripMenuItem.Name = "CopyResourceToolStripMenuItem"
        Me.CopyResourceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CopyResourceToolStripMenuItem.Text = "&Copy Resource"
        '
        'SendMailToolStripMenuItem1
        '
        Me.SendMailToolStripMenuItem1.Name = "SendMailToolStripMenuItem1"
        Me.SendMailToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.SendMailToolStripMenuItem1.Text = "Send &Mail"
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.RefreshToolStripMenuItem1.Text = "Re&fresh List"
        '
        'AlertToolStripMenuItem
        '
        Me.AlertToolStripMenuItem.Name = "AlertToolStripMenuItem"
        Me.AlertToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AlertToolStripMenuItem.Text = "&Alert"
        '
        'SettingsToolStripMenuItem2
        '
        Me.SettingsToolStripMenuItem2.Name = "SettingsToolStripMenuItem2"
        Me.SettingsToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.SettingsToolStripMenuItem2.Text = "S&ettings"
        '
        'ManageCaseToolStripMenuItem
        '
        Me.ManageCaseToolStripMenuItem.Name = "ManageCaseToolStripMenuItem"
        Me.ManageCaseToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ManageCaseToolStripMenuItem.Text = "Mana&ge Case"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CloseTabToolStripMenuItem.Text = "Cl&ose Tab"
        '
        'TimerStartStopToolStripMenuItem
        '
        Me.TimerStartStopToolStripMenuItem.Name = "TimerStartStopToolStripMenuItem"
        Me.TimerStartStopToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.TimerStartStopToolStripMenuItem.Text = "&Timer Start/Stop"
        '
        'DeleteCaseToolStripMenuItem
        '
        Me.DeleteCaseToolStripMenuItem.Name = "DeleteCaseToolStripMenuItem"
        Me.DeleteCaseToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DeleteCaseToolStripMenuItem.Text = "&Delete Case"
        '
        'ShowHidePanelToolStripMenuItem
        '
        Me.ShowHidePanelToolStripMenuItem.Name = "ShowHidePanelToolStripMenuItem"
        Me.ShowHidePanelToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ShowHidePanelToolStripMenuItem.Text = "Show/Hide Panel"
        '
        'CaseNotesToolStripMenuItem
        '
        Me.CaseNotesToolStripMenuItem.Name = "CaseNotesToolStripMenuItem"
        Me.CaseNotesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CaseNotesToolStripMenuItem.Text = "Local Case &Notes"
        '
        'OpenCaseDirectoryToolStripMenuItem
        '
        Me.OpenCaseDirectoryToolStripMenuItem.Name = "OpenCaseDirectoryToolStripMenuItem"
        Me.OpenCaseDirectoryToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.OpenCaseDirectoryToolStripMenuItem.Text = "&Local Share"
        '
        'TeamShareToolStripMenuItem
        '
        Me.TeamShareToolStripMenuItem.Name = "TeamShareToolStripMenuItem"
        Me.TeamShareToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TeamShareToolStripMenuItem.Text = "&Team Share"
        '
        'FTPWorkspaceToolStripMenuItem
        '
        Me.FTPWorkspaceToolStripMenuItem.Name = "FTPWorkspaceToolStripMenuItem"
        Me.FTPWorkspaceToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FTPWorkspaceToolStripMenuItem.Text = "&FTP Workspace"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Image = CType(resources.GetObject("FeedbackToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'BtnHide
        '
        Me.BtnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHide.Location = New System.Drawing.Point(344, 27)
        Me.BtnHide.Name = "BtnHide"
        Me.BtnHide.Size = New System.Drawing.Size(30, 30)
        Me.BtnHide.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.BtnHide, "Show/Hide Panel")
        Me.BtnHide.UseVisualStyleBackColor = True
        '
        'BtnDeleteCase
        '
        Me.BtnDeleteCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeleteCase.Location = New System.Drawing.Point(313, 27)
        Me.BtnDeleteCase.Name = "BtnDeleteCase"
        Me.BtnDeleteCase.Size = New System.Drawing.Size(30, 30)
        Me.BtnDeleteCase.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.BtnDeleteCase, "Delete the case notes and all related data and exit application.")
        Me.BtnDeleteCase.UseVisualStyleBackColor = True
        '
        'BtnAlert
        '
        Me.BtnAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAlert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAlert.Location = New System.Drawing.Point(189, 27)
        Me.BtnAlert.Name = "BtnAlert"
        Me.BtnAlert.Size = New System.Drawing.Size(30, 30)
        Me.BtnAlert.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.BtnAlert, "Create a reminder for this case")
        Me.BtnAlert.UseVisualStyleBackColor = True
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnrefresh.Location = New System.Drawing.Point(220, 27)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(30, 30)
        Me.Btnrefresh.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Btnrefresh, "Reload templates and resource list.")
        Me.Btnrefresh.UseVisualStyleBackColor = True
        '
        'Btnexit
        '
        Me.Btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnexit.Location = New System.Drawing.Point(282, 27)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(30, 30)
        Me.Btnexit.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Btnexit, "Close active Tab")
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Btnsetting
        '
        Me.Btnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnsetting.Location = New System.Drawing.Point(251, 27)
        Me.Btnsetting.Name = "Btnsetting"
        Me.Btnsetting.Size = New System.Drawing.Size(30, 30)
        Me.Btnsetting.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.Btnsetting, "Settings")
        Me.Btnsetting.UseVisualStyleBackColor = True
        '
        'BtnOpenNotes
        '
        Me.BtnOpenNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOpenNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpenNotes.Location = New System.Drawing.Point(158, 27)
        Me.BtnOpenNotes.Name = "BtnOpenNotes"
        Me.BtnOpenNotes.Size = New System.Drawing.Size(30, 30)
        Me.BtnOpenNotes.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.BtnOpenNotes, "Manage Cases")
        Me.BtnOpenNotes.UseVisualStyleBackColor = True
        '
        'BtnDeletetemplate
        '
        Me.BtnDeletetemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeletetemplate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeletetemplate.Location = New System.Drawing.Point(127, 27)
        Me.BtnDeletetemplate.Name = "BtnDeletetemplate"
        Me.BtnDeletetemplate.Size = New System.Drawing.Size(30, 30)
        Me.BtnDeletetemplate.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnDeletetemplate, "Delete the selected template")
        Me.BtnDeletetemplate.UseVisualStyleBackColor = True
        '
        'BtnCreateTemplate
        '
        Me.BtnCreateTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCreateTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCreateTemplate.Location = New System.Drawing.Point(96, 27)
        Me.BtnCreateTemplate.Name = "BtnCreateTemplate"
        Me.BtnCreateTemplate.Size = New System.Drawing.Size(30, 30)
        Me.BtnCreateTemplate.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BtnCreateTemplate, "Create Template")
        Me.BtnCreateTemplate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 724)
        Me.Controls.Add(Me.BtnCopyNotes)
        Me.Controls.Add(Me.TxtTimer)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PanelBB)
        Me.Controls.Add(Me.Chkwordwrap)
        Me.Controls.Add(Me.BtnTimer)
        Me.Controls.Add(Me.ChkBullet)
        Me.Controls.Add(Me.Btnmail)
        Me.Controls.Add(Me.Btncopy)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnHide)
        Me.Controls.Add(Me.BtnDeleteCase)
        Me.Controls.Add(Me.BtnAlert)
        Me.Controls.Add(Me.Btnrefresh)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btnsetting)
        Me.Controls.Add(Me.BtnOpenNotes)
        Me.Controls.Add(Me.BtnDeletetemplate)
        Me.Controls.Add(Me.BtnCreateTemplate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Easy Notes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CMTV.ResumeLayout(False)
        Me.TabCM.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGAlert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRemote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGFTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGCF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuBrowserTab.ResumeLayout(False)
        Me.PanelBB.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TC1.ResumeLayout(False)
        Me.TPTemplates.ResumeLayout(False)
        Me.TPAlerts.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TBFile.ResumeLayout(False)
        Me.TPLocal.ResumeLayout(False)
        Me.TPLocal.PerformLayout()
        Me.TPFTP.ResumeLayout(False)
        Me.TPFTP.PerformLayout()
        Me.TPCF.ResumeLayout(False)
        Me.TPCF.PerformLayout()
        Me.TPTeam.ResumeLayout(False)
        Me.TPTeam.PerformLayout()
        Me.TCMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PicAlert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents NewCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendMailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtTimer As System.Windows.Forms.TextBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SettingsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents Btncopy As System.Windows.Forms.Button
    Friend WithEvents Btnmail As System.Windows.Forms.Button
    Friend WithEvents Btnsetting As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCaseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyResourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendMailToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnOpenNotes As System.Windows.Forms.Button
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenCaseDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaseNotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCreateTemplate As System.Windows.Forms.Button
    Friend WithEvents BtnDeletetemplate As System.Windows.Forms.Button
    Friend WithEvents NewTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMTV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenInNewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamShareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ChkBullet As System.Windows.Forms.CheckBox
    Friend WithEvents TabCM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseTabToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteThisNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btnrefresh As System.Windows.Forms.Button
    Friend WithEvents mnuBrowserTab As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MnuCloseactivebrowser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FTPWorkspaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnAlert As System.Windows.Forms.Button
    Friend WithEvents AlertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerTabTime As System.Windows.Forms.Timer
    Friend WithEvents BtnTimer As System.Windows.Forms.Button
    Friend WithEvents TimerStartStopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnDeleteCase As System.Windows.Forms.Button
    Friend WithEvents DeleteCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Chkwordwrap As System.Windows.Forms.CheckBox
    Friend WithEvents BtnHide As System.Windows.Forms.Button
    Friend WithEvents ShowHidePanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelBB As System.Windows.Forms.Panel
    Friend WithEvents BtnForeward As System.Windows.Forms.Button
    Friend WithEvents BtnrefreshPage As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents MailContentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyContentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PicAlert As System.Windows.Forms.PictureBox
    Friend WithEvents TC1 As System.Windows.Forms.TabControl
    Friend WithEvents TPTemplates As System.Windows.Forms.TabPage
    Friend WithEvents TV As System.Windows.Forms.TreeView
    Friend WithEvents TPAlerts As System.Windows.Forms.TabPage
    Friend WithEvents DGAlert As System.Windows.Forms.DataGridView
    Friend WithEvents Btn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents BtnMSSolve As System.Windows.Forms.Button
    Friend WithEvents lblCaseno As System.Windows.Forms.TextBox
    Friend WithEvents LblCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnDeleteselected As System.Windows.Forms.Button
    Friend WithEvents BtnOpenSelected As System.Windows.Forms.Button
    Friend WithEvents BtnCopyselected As System.Windows.Forms.Button
    Friend WithEvents TBFile As System.Windows.Forms.TabControl
    Friend WithEvents TPTeam As System.Windows.Forms.TabPage
    Friend WithEvents PBPS As System.Windows.Forms.PictureBox
    Friend WithEvents BtnTeamShare As System.Windows.Forms.Button
    Friend WithEvents lblremote As System.Windows.Forms.TextBox
    Friend WithEvents DGRemote As System.Windows.Forms.DataGridView
    Friend WithEvents TPLocal As System.Windows.Forms.TabPage
    Friend WithEvents PBLS As System.Windows.Forms.PictureBox
    Friend WithEvents BtnOpendir As System.Windows.Forms.Button
    Friend WithEvents lbllocal As System.Windows.Forms.TextBox
    Friend WithEvents DGLocal As System.Windows.Forms.DataGridView
    Friend WithEvents TPFTP As System.Windows.Forms.TabPage
    Friend WithEvents PBFTP As System.Windows.Forms.PictureBox
    Friend WithEvents BtnOpenFtp As System.Windows.Forms.Button
    Friend WithEvents LblFTP As System.Windows.Forms.TextBox
    Friend WithEvents DGFTP As System.Windows.Forms.DataGridView
    Friend WithEvents TPCF As System.Windows.Forms.TabPage
    Friend WithEvents PBCF As System.Windows.Forms.PictureBox
    Friend WithEvents BtnOpenCF As System.Windows.Forms.Button
    Friend WithEvents LblCF As System.Windows.Forms.TextBox
    Friend WithEvents DGCF As System.Windows.Forms.DataGridView
    Friend WithEvents TCMain As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TC As System.Windows.Forms.TabControl
    Friend WithEvents ManageCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCopyNotes As System.Windows.Forms.Button

End Class
