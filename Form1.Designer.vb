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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.NewCaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaseNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCaseDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamShareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FTPWorkspaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.BtnTeamShare = New System.Windows.Forms.Button()
        Me.BtnOpendir = New System.Windows.Forms.Button()
        Me.BtnTimer = New System.Windows.Forms.Button()
        Me.BtnMSSolve = New System.Windows.Forms.Button()
        Me.BtnCopyNotes = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnForeward = New System.Windows.Forms.Button()
        Me.BtnrefreshPage = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.Btnmail = New System.Windows.Forms.Button()
        Me.Btncopy = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnHide = New System.Windows.Forms.Button()
        Me.BtnDeleteCase = New System.Windows.Forms.Button()
        Me.BtnAlert = New System.Windows.Forms.Button()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Btnsetting = New System.Windows.Forms.Button()
        Me.BtnOpenNotes = New System.Windows.Forms.Button()
        Me.BtnDeletetemplate = New System.Windows.Forms.Button()
        Me.BtnCreateTemplate = New System.Windows.Forms.Button()
        Me.ChkBullet = New System.Windows.Forms.CheckBox()
        Me.mnuBrowserTab = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MnuCloseactivebrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerTabTime = New System.Windows.Forms.Timer(Me.components)
        Me.Chkwordwrap = New System.Windows.Forms.CheckBox()
        Me.PanelBB = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PicAlert = New System.Windows.Forms.PictureBox()
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
        Me.PBLS = New System.Windows.Forms.PictureBox()
        Me.TPTeam = New System.Windows.Forms.TabPage()
        Me.PBPS = New System.Windows.Forms.PictureBox()
        Me.TCMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TC = New System.Windows.Forms.TabControl()
        Me.CMTV.SuspendLayout()
        Me.TabCM.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRemote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuBrowserTab.SuspendLayout()
        Me.PanelBB.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PicAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TC1.SuspendLayout()
        Me.TPTemplates.SuspendLayout()
        Me.TPAlerts.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TBFile.SuspendLayout()
        Me.TPLocal.SuspendLayout()
        CType(Me.PBLS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPTeam.SuspendLayout()
        CType(Me.PBPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMTV
        '
        Me.CMTV.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CMTV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenInNewTabToolStripMenuItem, Me.OpenFileToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.MailContentToolStripMenuItem, Me.CopyContentToolStripMenuItem})
        Me.CMTV.Name = "CMTV"
        Me.CMTV.Size = New System.Drawing.Size(216, 164)
        '
        'OpenInNewTabToolStripMenuItem
        '
        Me.OpenInNewTabToolStripMenuItem.Name = "OpenInNewTabToolStripMenuItem"
        Me.OpenInNewTabToolStripMenuItem.Size = New System.Drawing.Size(215, 32)
        Me.OpenInNewTabToolStripMenuItem.Text = "Open in new tab"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(215, 32)
        Me.OpenFileToolStripMenuItem.Text = "Open file"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(215, 32)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'MailContentToolStripMenuItem
        '
        Me.MailContentToolStripMenuItem.Name = "MailContentToolStripMenuItem"
        Me.MailContentToolStripMenuItem.Size = New System.Drawing.Size(215, 32)
        Me.MailContentToolStripMenuItem.Text = "Mail Content"
        '
        'CopyContentToolStripMenuItem
        '
        Me.CopyContentToolStripMenuItem.Name = "CopyContentToolStripMenuItem"
        Me.CopyContentToolStripMenuItem.Size = New System.Drawing.Size(215, 32)
        Me.CopyContentToolStripMenuItem.Text = "Copy Content"
        '
        'TabCM
        '
        Me.TabCM.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TabCM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseTabToolStripMenuItem1, Me.DeleteThisNoteToolStripMenuItem})
        Me.TabCM.Name = "TabCM"
        Me.TabCM.Size = New System.Drawing.Size(216, 68)
        '
        'CloseTabToolStripMenuItem1
        '
        Me.CloseTabToolStripMenuItem1.Name = "CloseTabToolStripMenuItem1"
        Me.CloseTabToolStripMenuItem1.Size = New System.Drawing.Size(215, 32)
        Me.CloseTabToolStripMenuItem1.Text = "Close active tab"
        '
        'DeleteThisNoteToolStripMenuItem
        '
        Me.DeleteThisNoteToolStripMenuItem.Name = "DeleteThisNoteToolStripMenuItem"
        Me.DeleteThisNoteToolStripMenuItem.Size = New System.Drawing.Size(215, 32)
        Me.DeleteThisNoteToolStripMenuItem.Text = "Delete active tab"
        '
        'TxtTimer
        '
        Me.TxtTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTimer.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTimer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTimer.ForeColor = System.Drawing.Color.Black
        Me.TxtTimer.Location = New System.Drawing.Point(1252, 34)
        Me.TxtTimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTimer.Name = "TxtTimer"
        Me.TxtTimer.ReadOnly = True
        Me.TxtTimer.Size = New System.Drawing.Size(214, 55)
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
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaseToolStripMenuItem, Me.ActionToolStripMenuItem, Me.OpenToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1461, 33)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CaseToolStripMenuItem
        '
        Me.CaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCaseToolStripMenuItem1, Me.NewTemplateToolStripMenuItem, Me.DeleteTemplateToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.CaseToolStripMenuItem.Name = "CaseToolStripMenuItem"
        Me.CaseToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.CaseToolStripMenuItem.Text = "Ca&se"
        '
        'NewCaseToolStripMenuItem1
        '
        Me.NewCaseToolStripMenuItem1.Image = Global.EasyNotes.My.Resources.Resources._New
        Me.NewCaseToolStripMenuItem1.Name = "NewCaseToolStripMenuItem1"
        Me.NewCaseToolStripMenuItem1.Size = New System.Drawing.Size(240, 34)
        Me.NewCaseToolStripMenuItem1.Text = "&New Case"
        '
        'NewTemplateToolStripMenuItem
        '
        Me.NewTemplateToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.CreateTemplate
        Me.NewTemplateToolStripMenuItem.Name = "NewTemplateToolStripMenuItem"
        Me.NewTemplateToolStripMenuItem.Size = New System.Drawing.Size(240, 34)
        Me.NewTemplateToolStripMenuItem.Text = "New &Template"
        '
        'DeleteTemplateToolStripMenuItem
        '
        Me.DeleteTemplateToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.DEleteTemplate
        Me.DeleteTemplateToolStripMenuItem.Name = "DeleteTemplateToolStripMenuItem"
        Me.DeleteTemplateToolStripMenuItem.Size = New System.Drawing.Size(240, 34)
        Me.DeleteTemplateToolStripMenuItem.Text = "&Delete Template"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.EasyNotes.My.Resources.Resources.close
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(240, 34)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyResourceToolStripMenuItem, Me.SendMailToolStripMenuItem1, Me.RefreshToolStripMenuItem1, Me.AlertToolStripMenuItem, Me.SettingsToolStripMenuItem2, Me.ManageCaseToolStripMenuItem, Me.CloseTabToolStripMenuItem, Me.TimerStartStopToolStripMenuItem, Me.DeleteCaseToolStripMenuItem, Me.ShowHidePanelToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.ActionToolStripMenuItem.Text = "&Action"
        '
        'CopyResourceToolStripMenuItem
        '
        Me.CopyResourceToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.CopyResource
        Me.CopyResourceToolStripMenuItem.Name = "CopyResourceToolStripMenuItem"
        Me.CopyResourceToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.CopyResourceToolStripMenuItem.Text = "&Copy Resource"
        '
        'SendMailToolStripMenuItem1
        '
        Me.SendMailToolStripMenuItem1.Image = Global.EasyNotes.My.Resources.Resources.mail
        Me.SendMailToolStripMenuItem1.Name = "SendMailToolStripMenuItem1"
        Me.SendMailToolStripMenuItem1.Size = New System.Drawing.Size(248, 34)
        Me.SendMailToolStripMenuItem1.Text = "Send &Mail"
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Image = Global.EasyNotes.My.Resources.Resources.Refresh
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(248, 34)
        Me.RefreshToolStripMenuItem1.Text = "Re&fresh List"
        '
        'AlertToolStripMenuItem
        '
        Me.AlertToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.information
        Me.AlertToolStripMenuItem.Name = "AlertToolStripMenuItem"
        Me.AlertToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.AlertToolStripMenuItem.Text = "&Alert"
        '
        'SettingsToolStripMenuItem2
        '
        Me.SettingsToolStripMenuItem2.Image = Global.EasyNotes.My.Resources.Resources.settings
        Me.SettingsToolStripMenuItem2.Name = "SettingsToolStripMenuItem2"
        Me.SettingsToolStripMenuItem2.Size = New System.Drawing.Size(248, 34)
        Me.SettingsToolStripMenuItem2.Text = "S&ettings"
        '
        'ManageCaseToolStripMenuItem
        '
        Me.ManageCaseToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.information
        Me.ManageCaseToolStripMenuItem.Name = "ManageCaseToolStripMenuItem"
        Me.ManageCaseToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.ManageCaseToolStripMenuItem.Text = "Mana&ge Case"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.close
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.CloseTabToolStripMenuItem.Text = "Cl&ose Tab"
        '
        'TimerStartStopToolStripMenuItem
        '
        Me.TimerStartStopToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.Watch
        Me.TimerStartStopToolStripMenuItem.Name = "TimerStartStopToolStripMenuItem"
        Me.TimerStartStopToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.TimerStartStopToolStripMenuItem.Text = "&Timer Start/Stop"
        '
        'DeleteCaseToolStripMenuItem
        '
        Me.DeleteCaseToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.DeleteAll
        Me.DeleteCaseToolStripMenuItem.Name = "DeleteCaseToolStripMenuItem"
        Me.DeleteCaseToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.DeleteCaseToolStripMenuItem.Text = "&Delete Case"
        '
        'ShowHidePanelToolStripMenuItem
        '
        Me.ShowHidePanelToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.ShowHide
        Me.ShowHidePanelToolStripMenuItem.Name = "ShowHidePanelToolStripMenuItem"
        Me.ShowHidePanelToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.ShowHidePanelToolStripMenuItem.Text = "Show/Hide Panel"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaseNotesToolStripMenuItem, Me.OpenCaseDirectoryToolStripMenuItem, Me.TeamShareToolStripMenuItem, Me.FTPWorkspaceToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(72, 29)
        Me.OpenToolStripMenuItem.Text = "&Open"
        Me.OpenToolStripMenuItem.Visible = False
        '
        'CaseNotesToolStripMenuItem
        '
        Me.CaseNotesToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.Download
        Me.CaseNotesToolStripMenuItem.Name = "CaseNotesToolStripMenuItem"
        Me.CaseNotesToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.CaseNotesToolStripMenuItem.Text = "Local Case &Notes"
        '
        'OpenCaseDirectoryToolStripMenuItem
        '
        Me.OpenCaseDirectoryToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.Download
        Me.OpenCaseDirectoryToolStripMenuItem.Name = "OpenCaseDirectoryToolStripMenuItem"
        Me.OpenCaseDirectoryToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.OpenCaseDirectoryToolStripMenuItem.Text = "&Local Share"
        '
        'TeamShareToolStripMenuItem
        '
        Me.TeamShareToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.Download
        Me.TeamShareToolStripMenuItem.Name = "TeamShareToolStripMenuItem"
        Me.TeamShareToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.TeamShareToolStripMenuItem.Text = "&Team Share"
        '
        'FTPWorkspaceToolStripMenuItem
        '
        Me.FTPWorkspaceToolStripMenuItem.Image = Global.EasyNotes.My.Resources.Resources.Download
        Me.FTPWorkspaceToolStripMenuItem.Name = "FTPWorkspaceToolStripMenuItem"
        Me.FTPWorkspaceToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.FTPWorkspaceToolStripMenuItem.Text = "&FTP Workspace"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.ToolStripComboBox1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(189, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Image = CType(resources.GetObject("FeedbackToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(189, 34)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"50", "60", "70", "80", "90", "100"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(75, 33)
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGAlert.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGAlert.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGAlert.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlert.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAlert.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Btn})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGAlert.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGAlert.Location = New System.Drawing.Point(-3, -3)
        Me.DGAlert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGAlert.MultiSelect = False
        Me.DGAlert.Name = "DGAlert"
        Me.DGAlert.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlert.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGAlert.RowHeadersVisible = False
        Me.DGAlert.RowHeadersWidth = 62
        Me.DGAlert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGAlert.Size = New System.Drawing.Size(614, 720)
        Me.DGAlert.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DGAlert, "Doubleclick to open a case.")
        '
        'Btn
        '
        Me.Btn.HeaderText = ""
        Me.Btn.MinimumWidth = 8
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
        Me.lblCaseno.Location = New System.Drawing.Point(0, -2)
        Me.lblCaseno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblCaseno.Name = "lblCaseno"
        Me.lblCaseno.ReadOnly = True
        Me.lblCaseno.Size = New System.Drawing.Size(379, 30)
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
        Me.LblCustomer.Location = New System.Drawing.Point(0, 37)
        Me.LblCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.ReadOnly = True
        Me.LblCustomer.Size = New System.Drawing.Size(415, 30)
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
        Me.lblremote.Size = New System.Drawing.Size(65535, 23)
        Me.lblremote.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.lblremote, "Drag and drop your files directly in the grid below.")
        '
        'DGRemote
        '
        Me.DGRemote.AllowDrop = True
        Me.DGRemote.AllowUserToAddRows = False
        Me.DGRemote.AllowUserToDeleteRows = False
        Me.DGRemote.AllowUserToOrderColumns = True
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue
        Me.DGRemote.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGRemote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGRemote.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRemote.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGRemote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGRemote.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGRemote.Location = New System.Drawing.Point(-3, 22)
        Me.DGRemote.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGRemote.MultiSelect = False
        Me.DGRemote.Name = "DGRemote"
        Me.DGRemote.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRemote.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGRemote.RowHeadersVisible = False
        Me.DGRemote.RowHeadersWidth = 62
        Me.DGRemote.RowTemplate.ReadOnly = True
        Me.DGRemote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGRemote.Size = New System.Drawing.Size(623, 462)
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
        Me.lbllocal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbllocal.Name = "lbllocal"
        Me.lbllocal.ReadOnly = True
        Me.lbllocal.Size = New System.Drawing.Size(387, 23)
        Me.lbllocal.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.lbllocal, "Drag and drop your files directly in the grid below.")
        '
        'DGLocal
        '
        Me.DGLocal.AllowDrop = True
        Me.DGLocal.AllowUserToAddRows = False
        Me.DGLocal.AllowUserToDeleteRows = False
        Me.DGLocal.AllowUserToOrderColumns = True
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightBlue
        Me.DGLocal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGLocal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGLocal.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGLocal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLocal.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGLocal.Location = New System.Drawing.Point(-3, 22)
        Me.DGLocal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGLocal.MultiSelect = False
        Me.DGLocal.Name = "DGLocal"
        Me.DGLocal.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGLocal.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGLocal.RowHeadersVisible = False
        Me.DGLocal.RowHeadersWidth = 62
        Me.DGLocal.RowTemplate.ReadOnly = True
        Me.DGLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGLocal.Size = New System.Drawing.Size(415, 308)
        Me.DGLocal.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.DGLocal, "Drag and drop files here.")
        '
        'BtnTeamShare
        '
        Me.BtnTeamShare.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTeamShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTeamShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTeamShare.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.BtnTeamShare.Location = New System.Drawing.Point(575, 0)
        Me.BtnTeamShare.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTeamShare.Name = "BtnTeamShare"
        Me.BtnTeamShare.Size = New System.Drawing.Size(24, 25)
        Me.BtnTeamShare.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.BtnTeamShare, "Open team share")
        Me.BtnTeamShare.UseVisualStyleBackColor = True
        '
        'BtnOpendir
        '
        Me.BtnOpendir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpendir.BackgroundImage = Global.EasyNotes.My.Resources.Resources.View_Doc
        Me.BtnOpendir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOpendir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpendir.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.BtnOpendir.Location = New System.Drawing.Point(383, 0)
        Me.BtnOpendir.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnOpendir.Name = "BtnOpendir"
        Me.BtnOpendir.Size = New System.Drawing.Size(24, 25)
        Me.BtnOpendir.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.BtnOpendir, "Open Local Case Directory")
        Me.BtnOpendir.UseVisualStyleBackColor = True
        '
        'BtnTimer
        '
        Me.BtnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTimer.Location = New System.Drawing.Point(870, 42)
        Me.BtnTimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnTimer.Name = "BtnTimer"
        Me.BtnTimer.Size = New System.Drawing.Size(45, 46)
        Me.BtnTimer.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.BtnTimer, "Stop/Start Task Timer")
        Me.BtnTimer.UseVisualStyleBackColor = True
        Me.BtnTimer.Visible = False
        '
        'BtnMSSolve
        '
        Me.BtnMSSolve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMSSolve.BackgroundImage = Global.EasyNotes.My.Resources.Resources.ServiceDesk
        Me.BtnMSSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMSSolve.Enabled = False
        Me.BtnMSSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMSSolve.Location = New System.Drawing.Point(379, -2)
        Me.BtnMSSolve.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnMSSolve.Name = "BtnMSSolve"
        Me.BtnMSSolve.Size = New System.Drawing.Size(36, 34)
        Me.BtnMSSolve.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.BtnMSSolve, "Open this MSSolve case")
        Me.BtnMSSolve.UseVisualStyleBackColor = True
        '
        'BtnCopyNotes
        '
        Me.BtnCopyNotes.BackgroundImage = Global.EasyNotes.My.Resources.Resources.CopyResource
        Me.BtnCopyNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCopyNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCopyNotes.Location = New System.Drawing.Point(562, 42)
        Me.BtnCopyNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCopyNotes.Name = "BtnCopyNotes"
        Me.BtnCopyNotes.Size = New System.Drawing.Size(45, 46)
        Me.BtnCopyNotes.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.BtnCopyNotes, "Copy")
        Me.BtnCopyNotes.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReset.BackgroundImage = Global.EasyNotes.My.Resources.Resources.Watch
        Me.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnReset.Location = New System.Drawing.Point(1101, 40)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(142, 46)
        Me.BtnReset.TabIndex = 19
        Me.BtnReset.Text = "           STOP"
        Me.ToolTip1.SetToolTip(Me.BtnReset, "Reset the timer")
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnForeward
        '
        Me.BtnForeward.BackgroundImage = Global.EasyNotes.My.Resources.Resources.forward
        Me.BtnForeward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnForeward.Enabled = False
        Me.BtnForeward.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnForeward.Location = New System.Drawing.Point(99, 0)
        Me.BtnForeward.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnForeward.Name = "BtnForeward"
        Me.BtnForeward.Size = New System.Drawing.Size(45, 46)
        Me.BtnForeward.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.BtnForeward, "Go foreward")
        Me.BtnForeward.UseVisualStyleBackColor = True
        '
        'BtnrefreshPage
        '
        Me.BtnrefreshPage.BackgroundImage = Global.EasyNotes.My.Resources.Resources.browser_refresh
        Me.BtnrefreshPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnrefreshPage.Enabled = False
        Me.BtnrefreshPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnrefreshPage.Location = New System.Drawing.Point(52, 0)
        Me.BtnrefreshPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnrefreshPage.Name = "BtnrefreshPage"
        Me.BtnrefreshPage.Size = New System.Drawing.Size(45, 46)
        Me.BtnrefreshPage.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.BtnrefreshPage, "Refresh web page")
        Me.BtnrefreshPage.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackgroundImage = Global.EasyNotes.My.Resources.Resources.back
        Me.BtnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrevious.Enabled = False
        Me.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrevious.Location = New System.Drawing.Point(6, 0)
        Me.BtnPrevious.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(45, 46)
        Me.BtnPrevious.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BtnPrevious, "Go previous ")
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'Btnmail
        '
        Me.Btnmail.BackgroundImage = Global.EasyNotes.My.Resources.Resources.mail
        Me.Btnmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnmail.Location = New System.Drawing.Point(98, 42)
        Me.Btnmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnmail.Name = "Btnmail"
        Me.Btnmail.Size = New System.Drawing.Size(45, 46)
        Me.Btnmail.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Btnmail, "Send mail")
        Me.Btnmail.UseVisualStyleBackColor = True
        '
        'Btncopy
        '
        Me.Btncopy.BackgroundImage = Global.EasyNotes.My.Resources.Resources.copy
        Me.Btncopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btncopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btncopy.Location = New System.Drawing.Point(51, 42)
        Me.Btncopy.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btncopy.Name = "Btncopy"
        Me.Btncopy.Size = New System.Drawing.Size(45, 46)
        Me.Btncopy.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Btncopy, "Copy Resources")
        Me.Btncopy.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.BackgroundImage = CType(resources.GetObject("BtnNew.BackgroundImage"), System.Drawing.Image)
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnNew.Location = New System.Drawing.Point(4, 42)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(45, 46)
        Me.BtnNew.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BtnNew, "Enter a Case id")
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnHide
        '
        Me.BtnHide.BackgroundImage = CType(resources.GetObject("BtnHide.BackgroundImage"), System.Drawing.Image)
        Me.BtnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHide.Location = New System.Drawing.Point(516, 42)
        Me.BtnHide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnHide.Name = "BtnHide"
        Me.BtnHide.Size = New System.Drawing.Size(45, 46)
        Me.BtnHide.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.BtnHide, "Show/Hide Panel")
        Me.BtnHide.UseVisualStyleBackColor = True
        '
        'BtnDeleteCase
        '
        Me.BtnDeleteCase.BackgroundImage = Global.EasyNotes.My.Resources.Resources.DeleteAll
        Me.BtnDeleteCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeleteCase.Location = New System.Drawing.Point(470, 42)
        Me.BtnDeleteCase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDeleteCase.Name = "BtnDeleteCase"
        Me.BtnDeleteCase.Size = New System.Drawing.Size(45, 46)
        Me.BtnDeleteCase.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.BtnDeleteCase, "Delete the case notes and all related data and exit application.")
        Me.BtnDeleteCase.UseVisualStyleBackColor = True
        '
        'BtnAlert
        '
        Me.BtnAlert.BackgroundImage = Global.EasyNotes.My.Resources.Resources.information
        Me.BtnAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAlert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAlert.Location = New System.Drawing.Point(284, 42)
        Me.BtnAlert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAlert.Name = "BtnAlert"
        Me.BtnAlert.Size = New System.Drawing.Size(45, 46)
        Me.BtnAlert.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.BtnAlert, "Create a reminder for this case")
        Me.BtnAlert.UseVisualStyleBackColor = True
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackgroundImage = Global.EasyNotes.My.Resources.Resources.Refresh
        Me.Btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnrefresh.Location = New System.Drawing.Point(330, 42)
        Me.Btnrefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(45, 46)
        Me.Btnrefresh.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Btnrefresh, "Reload templates and resource list.")
        Me.Btnrefresh.UseVisualStyleBackColor = True
        '
        'Btnexit
        '
        Me.Btnexit.BackgroundImage = Global.EasyNotes.My.Resources.Resources.close
        Me.Btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnexit.Location = New System.Drawing.Point(423, 42)
        Me.Btnexit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(45, 46)
        Me.Btnexit.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Btnexit, "Close active Tab")
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Btnsetting
        '
        Me.Btnsetting.BackgroundImage = Global.EasyNotes.My.Resources.Resources.settings
        Me.Btnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnsetting.Location = New System.Drawing.Point(376, 42)
        Me.Btnsetting.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnsetting.Name = "Btnsetting"
        Me.Btnsetting.Size = New System.Drawing.Size(45, 46)
        Me.Btnsetting.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.Btnsetting, "Settings")
        Me.Btnsetting.UseVisualStyleBackColor = True
        '
        'BtnOpenNotes
        '
        Me.BtnOpenNotes.BackgroundImage = Global.EasyNotes.My.Resources.Resources.edit
        Me.BtnOpenNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOpenNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpenNotes.Location = New System.Drawing.Point(237, 42)
        Me.BtnOpenNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOpenNotes.Name = "BtnOpenNotes"
        Me.BtnOpenNotes.Size = New System.Drawing.Size(45, 46)
        Me.BtnOpenNotes.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.BtnOpenNotes, "Manage Cases")
        Me.BtnOpenNotes.UseVisualStyleBackColor = True
        '
        'BtnDeletetemplate
        '
        Me.BtnDeletetemplate.BackgroundImage = Global.EasyNotes.My.Resources.Resources.DEleteTemplate
        Me.BtnDeletetemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeletetemplate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeletetemplate.Location = New System.Drawing.Point(190, 42)
        Me.BtnDeletetemplate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDeletetemplate.Name = "BtnDeletetemplate"
        Me.BtnDeletetemplate.Size = New System.Drawing.Size(45, 46)
        Me.BtnDeletetemplate.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnDeletetemplate, "Delete the selected template")
        Me.BtnDeletetemplate.UseVisualStyleBackColor = True
        '
        'BtnCreateTemplate
        '
        Me.BtnCreateTemplate.BackgroundImage = Global.EasyNotes.My.Resources.Resources.CreateTemplate
        Me.BtnCreateTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCreateTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCreateTemplate.Location = New System.Drawing.Point(144, 42)
        Me.BtnCreateTemplate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCreateTemplate.Name = "BtnCreateTemplate"
        Me.BtnCreateTemplate.Size = New System.Drawing.Size(45, 46)
        Me.BtnCreateTemplate.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BtnCreateTemplate, "Create Template")
        Me.BtnCreateTemplate.UseVisualStyleBackColor = True
        '
        'ChkBullet
        '
        Me.ChkBullet.AutoSize = True
        Me.ChkBullet.Location = New System.Drawing.Point(239, 6)
        Me.ChkBullet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkBullet.Name = "ChkBullet"
        Me.ChkBullet.Size = New System.Drawing.Size(193, 24)
        Me.ChkBullet.TabIndex = 0
        Me.ChkBullet.Text = "&Enable bullet (Ctrl + B)"
        Me.ChkBullet.UseVisualStyleBackColor = True
        '
        'mnuBrowserTab
        '
        Me.mnuBrowserTab.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuBrowserTab.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCloseactivebrowser})
        Me.mnuBrowserTab.Name = "ContextMenuStrip1"
        Me.mnuBrowserTab.ShowItemToolTips = False
        Me.mnuBrowserTab.Size = New System.Drawing.Size(249, 36)
        Me.mnuBrowserTab.Text = "BrowserTab"
        '
        'MnuCloseactivebrowser
        '
        Me.MnuCloseactivebrowser.Name = "MnuCloseactivebrowser"
        Me.MnuCloseactivebrowser.Size = New System.Drawing.Size(248, 32)
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
        Me.Chkwordwrap.Location = New System.Drawing.Point(463, 6)
        Me.Chkwordwrap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chkwordwrap.Name = "Chkwordwrap"
        Me.Chkwordwrap.Size = New System.Drawing.Size(111, 24)
        Me.Chkwordwrap.TabIndex = 1
        Me.Chkwordwrap.Text = "&Word wrap"
        Me.Chkwordwrap.UseVisualStyleBackColor = True
        '
        'PanelBB
        '
        Me.PanelBB.Controls.Add(Me.BtnForeward)
        Me.PanelBB.Controls.Add(Me.BtnrefreshPage)
        Me.PanelBB.Controls.Add(Me.BtnPrevious)
        Me.PanelBB.Location = New System.Drawing.Point(692, 42)
        Me.PanelBB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelBB.Name = "PanelBB"
        Me.PanelBB.Size = New System.Drawing.Size(148, 48)
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
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 92)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1461, 1022)
        Me.SplitContainer1.SplitterDistance = 415
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
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 601)
        Me.Panel3.TabIndex = 27
        '
        'PicAlert
        '
        Me.PicAlert.BackgroundImage = Global.EasyNotes.My.Resources.Resources.alert_blink
        Me.PicAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicAlert.Location = New System.Drawing.Point(94, 84)
        Me.PicAlert.Margin = New System.Windows.Forms.Padding(0)
        Me.PicAlert.Name = "PicAlert"
        Me.PicAlert.Size = New System.Drawing.Size(22, 23)
        Me.PicAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAlert.TabIndex = 25
        Me.PicAlert.TabStop = False
        Me.PicAlert.Visible = False
        '
        'TC1
        '
        Me.TC1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC1.Controls.Add(Me.TPTemplates)
        Me.TC1.Controls.Add(Me.TPAlerts)
        Me.TC1.Location = New System.Drawing.Point(0, 80)
        Me.TC1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TC1.Name = "TC1"
        Me.TC1.SelectedIndex = 0
        Me.TC1.Size = New System.Drawing.Size(417, 523)
        Me.TC1.TabIndex = 23
        '
        'TPTemplates
        '
        Me.TPTemplates.Controls.Add(Me.TV)
        Me.TPTemplates.Location = New System.Drawing.Point(4, 29)
        Me.TPTemplates.Margin = New System.Windows.Forms.Padding(0)
        Me.TPTemplates.Name = "TPTemplates"
        Me.TPTemplates.Size = New System.Drawing.Size(409, 490)
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
        Me.TV.Location = New System.Drawing.Point(-6, -3)
        Me.TV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TV.Name = "TV"
        Me.TV.ShowLines = False
        Me.TV.Size = New System.Drawing.Size(414, 479)
        Me.TV.TabIndex = 1
        '
        'TPAlerts
        '
        Me.TPAlerts.BackColor = System.Drawing.Color.Transparent
        Me.TPAlerts.Controls.Add(Me.DGAlert)
        Me.TPAlerts.Location = New System.Drawing.Point(4, 29)
        Me.TPAlerts.Margin = New System.Windows.Forms.Padding(0)
        Me.TPAlerts.Name = "TPAlerts"
        Me.TPAlerts.Size = New System.Drawing.Size(409, 490)
        Me.TPAlerts.TabIndex = 1
        Me.TPAlerts.Text = "(0) Reminder(s)"
        Me.TPAlerts.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 601)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(413, 7)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 608)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(413, 412)
        Me.Panel1.TabIndex = 23
        '
        'BtnDeleteselected
        '
        Me.BtnDeleteselected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteselected.Location = New System.Drawing.Point(182, 377)
        Me.BtnDeleteselected.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDeleteselected.Name = "BtnDeleteselected"
        Me.BtnDeleteselected.Size = New System.Drawing.Size(90, 31)
        Me.BtnDeleteselected.TabIndex = 27
        Me.BtnDeleteselected.Text = "&DELETE"
        Me.BtnDeleteselected.UseVisualStyleBackColor = True
        '
        'BtnOpenSelected
        '
        Me.BtnOpenSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenSelected.Location = New System.Drawing.Point(4, 377)
        Me.BtnOpenSelected.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOpenSelected.Name = "BtnOpenSelected"
        Me.BtnOpenSelected.Size = New System.Drawing.Size(90, 31)
        Me.BtnOpenSelected.TabIndex = 25
        Me.BtnOpenSelected.Text = "O&PEN"
        Me.BtnOpenSelected.UseVisualStyleBackColor = True
        '
        'BtnCopyselected
        '
        Me.BtnCopyselected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCopyselected.Location = New System.Drawing.Point(93, 377)
        Me.BtnCopyselected.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCopyselected.Name = "BtnCopyselected"
        Me.BtnCopyselected.Size = New System.Drawing.Size(90, 31)
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
        Me.TBFile.Controls.Add(Me.TPTeam)
        Me.TBFile.Location = New System.Drawing.Point(0, 0)
        Me.TBFile.Margin = New System.Windows.Forms.Padding(0)
        Me.TBFile.Name = "TBFile"
        Me.TBFile.SelectedIndex = 0
        Me.TBFile.Size = New System.Drawing.Size(419, 378)
        Me.TBFile.TabIndex = 24
        '
        'TPLocal
        '
        Me.TPLocal.Controls.Add(Me.PBLS)
        Me.TPLocal.Controls.Add(Me.BtnOpendir)
        Me.TPLocal.Controls.Add(Me.lbllocal)
        Me.TPLocal.Controls.Add(Me.DGLocal)
        Me.TPLocal.Location = New System.Drawing.Point(4, 29)
        Me.TPLocal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TPLocal.Name = "TPLocal"
        Me.TPLocal.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TPLocal.Size = New System.Drawing.Size(411, 345)
        Me.TPLocal.TabIndex = 1
        Me.TPLocal.Text = "Local Share"
        Me.TPLocal.UseVisualStyleBackColor = True
        '
        'PBLS
        '
        Me.PBLS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBLS.Location = New System.Drawing.Point(340, 257)
        Me.PBLS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PBLS.Name = "PBLS"
        Me.PBLS.Size = New System.Drawing.Size(45, 46)
        Me.PBLS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLS.TabIndex = 23
        Me.PBLS.TabStop = False
        Me.PBLS.Visible = False
        '
        'TPTeam
        '
        Me.TPTeam.Controls.Add(Me.PBPS)
        Me.TPTeam.Controls.Add(Me.BtnTeamShare)
        Me.TPTeam.Controls.Add(Me.lblremote)
        Me.TPTeam.Controls.Add(Me.DGRemote)
        Me.TPTeam.Location = New System.Drawing.Point(4, 29)
        Me.TPTeam.Margin = New System.Windows.Forms.Padding(0)
        Me.TPTeam.Name = "TPTeam"
        Me.TPTeam.Size = New System.Drawing.Size(411, 345)
        Me.TPTeam.TabIndex = 0
        Me.TPTeam.Text = "Public Share"
        Me.TPTeam.UseVisualStyleBackColor = True
        '
        'PBPS
        '
        Me.PBPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBPS.Location = New System.Drawing.Point(340, 257)
        Me.PBPS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PBPS.Name = "PBPS"
        Me.PBPS.Size = New System.Drawing.Size(45, 46)
        Me.PBPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPS.TabIndex = 22
        Me.PBPS.TabStop = False
        Me.PBPS.Visible = False
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
        Me.TCMain.Location = New System.Drawing.Point(-8, -11)
        Me.TCMain.Margin = New System.Windows.Forms.Padding(2)
        Me.TCMain.Name = "TCMain"
        Me.TCMain.SelectedIndex = 0
        Me.TCMain.Size = New System.Drawing.Size(1054, 1033)
        Me.TCMain.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TC)
        Me.TabPage1.ForeColor = System.Drawing.Color.Maroon
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1046, 1000)
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
        Me.TC.Location = New System.Drawing.Point(-6, -2)
        Me.TC.Margin = New System.Windows.Forms.Padding(0)
        Me.TC.Name = "TC"
        Me.TC.SelectedIndex = 0
        Me.TC.Size = New System.Drawing.Size(1055, 997)
        Me.TC.TabIndex = 28
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1461, 1114)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.mnuBrowserTab.ResumeLayout(False)
        Me.PanelBB.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PicAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TC1.ResumeLayout(False)
        Me.TPTemplates.ResumeLayout(False)
        Me.TPAlerts.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TBFile.ResumeLayout(False)
        Me.TPLocal.ResumeLayout(False)
        Me.TPLocal.PerformLayout()
        CType(Me.PBLS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPTeam.ResumeLayout(False)
        Me.TPTeam.PerformLayout()
        CType(Me.PBPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TCMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
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
    Friend WithEvents TCMain As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TC As System.Windows.Forms.TabControl
    Friend WithEvents ManageCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCopyNotes As System.Windows.Forms.Button

End Class
