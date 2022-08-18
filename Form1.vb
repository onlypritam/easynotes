Imports System.IO
Imports Outlook = Microsoft.Office.Interop.Outlook

Public Class Form1

    Dim common As New Common
    Friend SW As New System.Diagnostics.Stopwatch
    Dim DS As New DataSet
    Friend TimeElapsedAfterLastSave As Int64 = 0
    Friend TimeElapsedAfterLastDataGridBinding As Int64 = 0
    Friend TimeElapsedAfterLastCaseinfoGathered As Int64 = 0
    Friend DTLocal As New DataTable 'for getting local files
    Friend DTRemote As New DataTable
    Friend DTCF As New DataTable
    Friend DTFTP As New DataTable
    Friend FTPLocation As String
    Friend CFLocation As String
    Friend IsFirstCase As Boolean = True 'to decide whether to close all the previous tab
    Friend DSAlert As New DataSet("AlertsDS")
    Private LastSpliterDistance As Int32 = 280 ' to remember the spliter distance when they close it.
    Friend ForceShutDoNotSaveChanges As Boolean = False ' set to true only when deleting case in Form1_FormClosing
    'Friend Blinkspeed As Int64 = 0


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If common.IsCaseNo(common.CaseNo) = True Then
            If ForceShutDoNotSaveChanges = False Then SaveAllTabs()
            Me.Dispose()
        Else
            Me.Dispose()
        End If
    End Sub


    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = 66 And e.Control = True Then
            ChkBullet.Checked = Not ChkBullet.Checked
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'SplitContainer1.SplitterDistance = 280
            Me.Text = "Easy Notes v " & common.Version
            ToolStripComboBox1.SelectedIndex = 5


            ' TC1.TabPages(0).ForeColor = Color.Red
            ' TCMain.DrawMode = TabDrawMode.OwnerDrawFixed ' for changing tab color.

            If File.Exists("Easynotes.Config") Then
                DS.ReadXml("Easynotes.Config")
                common.NotesRoot = DS.Tables(0).Rows(0).Item(0)
                common.TemplateRoot = DS.Tables(0).Rows(1).Item(0)
                common.AltTemplateRoot = DS.Tables(0).Rows(2).Item(0)
                common.DSDBshare = DS.Tables(0).Rows(3).Item(0)
                common.Bullet = DS.Tables(0).Rows(4).Item(0)
                If DS.Tables(0).Rows(5).Item(0).ToString = "Yes" Then
                    ChkBullet.Checked = True
                Else
                    ChkBullet.Checked = False
                End If

                If IsNumeric(DS.Tables(0).Rows(6).Item(0)) = False Then
                    common.RecentDays = 0
                    sc.Close()
                    MsgBox("The 'Maintain recent case history for' value in settings seems to be corrupted or non numeric. Please fix it and restart the application.", MsgBoxStyle.Critical)
                Else
                    common.RecentDays = CType(DS.Tables(0).Rows(6).Item(0), Integer)
                End If

                common.FontName = DS.Tables(0).Rows(7).Item(0)
                common.FontColor = DS.Tables(0).Rows(8).Item(0)
                common.BackColor = DS.Tables(0).Rows(9).Item(0)
                common.FontSize = DS.Tables(0).Rows(10).Item(0)

                lblCaseno.Text = common.CaseNo
                PopulateTV()
                SW.Start()

                '========create browser tab=====================

                For i = 11 To DS.Tables(0).Rows.Count - 1
                    CreateBrowserTab(DS.Tables(0).Rows(i).Item(1), DS.Tables(0).Rows(i).Item(0), True)
                Next

                '===============================================

                If TV.Nodes.Count < 1 Then
                    CreateTab("Blank template")
                End If
            Else
                'Threading.Thread.Sleep(5000)
                sc.Close()

                MsgBox("It seems that you are using the application for the first time.Please set your configurations before using the application.", MsgBoxStyle.Information)
                Dim settings1 As New Settings
                settings1.ShowDialog()
            End If
            '============================================

            Alert()


            If DSAlert.Tables.Count > 0 Then
                DGAlert.DataSource = DSAlert.Tables(0)
                DGAlert.Columns(1).Width = 110
                DGAlert.Columns(2).Width = 50
                DGAlert.Columns(3).Width = 300
            End If


            'Dim t As New Threading.Thread(AddressOf LogAndVersion)
            't.Start()
            common.ExtraDataToLog = "EasyNotes Opened"
            Dim WL As New Threading.Thread(AddressOf common.WriteLog)
            WL.Start()

            Dim CV As New Threading.Thread(AddressOf common.CheckVersion)
            CV.Start()

            Dim Msg As New Threading.Thread(AddressOf common.CheckMessage)
            Msg.Start()


        Catch ex As Exception
            If ex.Message.StartsWith("Cannot find table 0") Then
                MsgBox("The Alerts.config file that contain all the reminder information is corrupted.Please remove this file from the application directory, And restart the application." & vbCrLf & "Note: All reminders will be lost.", MsgBoxStyle.Exclamation)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If

        Finally
            'sc.Close()
            SplitContainer1.SplitterDistance = 280
            Me.Visible = True
        End Try

    End Sub

    'Private Sub LogAndVersion()
    '    Try
    '        Dim lg As String
    '        lg = vbCrLf & My.User.Name & "  ,  " & My.Computer.Name & "  ,  " & Now & "  ,  " & common.Version
    '        File.AppendAllText("\\snehach1\ENLog\ENlog.txt", lg)

    '        If File.Exists("\\snehach1\ENVersion\ENVersion.txt") Then
    '            Dim V As String = File.ReadAllText("\\snehach1\ENVersion\ENVersion.txt")
    '            'MsgBox(V.IndexOf("<ENVersion>") + 11)
    '            'MsgBox(V.IndexOf("<ENVersion/>"))
    '            Dim VN As Double = V.Substring(11, 3) '<ENVersion>4.6<ENVersion/>
    '            If VN > CType(common.Version, Double) Then
    '                If MsgBox("A higher version of this product is available. Would you like to Upgrade it.", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    Process.Start("http://toolbox/easynotes")
    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Friend Sub Alert()
        Try
            Dim Dt As New DataTable("Alert")
            If File.Exists("Alerts.Config") Then
                DSAlert.ReadXml("Alerts.Config")
            Else
                '============Creating the dataset====================
                Dim c1 As New DataColumn("Caseno")
                Dim c2 As New DataColumn("Priority")
                Dim c3 As New DataColumn("Action")
                Dt.Columns.Add(c1)
                Dt.Columns.Add(c2)
                Dt.Columns.Add(c3)
                '---------------------------------------
                DSAlert.Tables.Add(Dt)
                DSAlert.WriteXml("Alerts.Config")
            End If

        Catch ex As Exception
            If ex.Message.StartsWith("Cannot find table 0") Then
                MsgBox("The Alerts.config file that contain all the reminder information is corrupted.Please remove this file from the application directory, And restart the application." & vbCrLf & "Note: All reminders will be lost.", MsgBoxStyle.Exclamation)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub

    Friend Sub AsyncGetFiles()

        Dim DTLocal As New DataTable 'for getting local files
        Dim DTRemote As New DataTable 'for getting Remote files
        Dim DTFTP As New DataTable 'for getting FTP files
        Dim DTCF As New DataTable 'for getting FTP files

        Try
            '----DTLocal---------------
            DTLocal.Rows.Clear()
            DTLocal.Columns.Clear()
            Dim c1 As New DataColumn("FileName")
            Dim c2 As New DataColumn("FilePath")
            Dim c3 As New DataColumn("FileSize")
            DTLocal.Columns.Add(c1)
            DTLocal.Columns.Add(c2)
            DTLocal.Columns.Add(c3)

            '-----DTRemote---------------
            DTRemote.Rows.Clear()
            DTRemote.Columns.Clear()
            Dim ca As New DataColumn("FileName")
            Dim cb As New DataColumn("FilePath")
            Dim cc As New DataColumn("FileSize")
            DTRemote.Columns.Add(ca)
            DTRemote.Columns.Add(cb)
            DTRemote.Columns.Add(cc)



            ''-----DTFTP---------------
            'DTFTP.Rows.Clear()
            'DTFTP.Columns.Clear()
            'Dim cx As New DataColumn("FileName")
            'Dim cy As New DataColumn("FilePath")
            'Dim cz As New DataColumn("FileSize")
            'DTFTP.Columns.Add(cx)
            'DTFTP.Columns.Add(cy)
            'DTFTP.Columns.Add(cz)

            ''-----DTCustomerFile---------------
            'DTCF.Rows.Clear()
            'DTCF.Columns.Clear()
            'Dim ci As New DataColumn("FileName")
            'Dim cj As New DataColumn("FilePath")
            'Dim ck As New DataColumn("FileSize")
            'DTCF.Columns.Add(ci)
            'DTCF.Columns.Add(cj)
            'DTCF.Columns.Add(ck)


            '----DTLocal---------------
            Try
                Dim FileList As ObjectModel.ReadOnlyCollection(Of String)
                FileList = My.Computer.FileSystem.GetFiles(common.NotesRoot & "\" & common.CaseNo, FileIO.SearchOption.SearchAllSubDirectories)

                DTLocal.Rows.Clear()
                For Each Files As String In FileList
                    If Files.Contains(common.NotesRoot & "\" & common.CaseNo & "\AllNotes\") = False And String.Compare(Files.ToString.Trim, common.NotesRoot & "\" & common.CaseNo & "\Info.txt") <> 0 Then
                        Dim Fl As New FileInfo(Files)
                        Dim drl As DataRow = DTLocal.NewRow
                        drl.Item(0) = Fl.Name.ToString
                        drl.Item(1) = Files
                        drl.Item(2) = common.GetFileSize(Fl.Length) ' Math.Round(Fl.Length / 1024) & " (KB)"
                        DTLocal.Rows.Add(drl)
                    End If
                Next
                Me.DTLocal = DTLocal.Copy()
                common.PBLS = False
            Catch ex As Exception
                common.PBLS = False
                If ex.Message.ToString.Contains("Could not find a part of the path") = False And ex.Message.ToString.Contains("The network path was not found") = False Then
                    MsgBox("Error with local share : " & ex.Message, MsgBoxStyle.Exclamation)
                End If
            End Try


            '-----DTRemote---------------
            Try
                Dim SFileList As ObjectModel.ReadOnlyCollection(Of String)
                SFileList = My.Computer.FileSystem.GetFiles(common.DSDBshare & "\" & common.CaseNo, FileIO.SearchOption.SearchAllSubDirectories)

                DTRemote.Rows.Clear()
                For Each Files As String In SFileList
                    Dim Fl As New FileInfo(Files)
                    Dim dr2 As DataRow = DTRemote.NewRow
                    dr2.Item(0) = Fl.Name.ToString
                    dr2.Item(1) = Files
                    dr2.Item(2) = common.GetFileSize(Fl.Length) 'Math.Round(Fl.Length / 1024) & " (KB)"

                    DTRemote.Rows.Add(dr2)
                Next
                Me.DTRemote = DTRemote.Copy()
                common.PBPS = False
            Catch ex As Exception
                common.PBPS = False
                If ex.Message.ToString.Contains("Could not find a part of the path") = False And ex.Message.ToString.Contains("The network path was not found") = False Then
                    MsgBox("Error with Public share : " & ex.Message, MsgBoxStyle.Exclamation)
                End If
            End Try


            '-----DTCustomerFile---------------
            'Try
            '    If common.IsMSSolveCase = True Then

            '        Dim cf As String
            '        cf = common.getCustomerFilePath

            '        If cf <> "" Then

            '            CFLocation = cf

            '            Dim SFileList As ObjectModel.ReadOnlyCollection(Of String)
            '            'SFileList = My.Computer.FileSystem.GetFiles(common.getCustomerFilePath, FileIO.SearchOption.SearchAllSubDirectories)
            '            SFileList = My.Computer.FileSystem.GetFiles(CFLocation, FileIO.SearchOption.SearchAllSubDirectories)
            '            DTCF.Rows.Clear()
            '            Me.DTCF = DTCF.Copy()
            '            For Each Files As String In SFileList
            '                Dim Fl As New FileInfo(Files)
            '                Dim dr2 As DataRow = DTCF.NewRow
            '                dr2.Item(0) = Fl.Name.ToString
            '                dr2.Item(1) = Files
            '                dr2.Item(2) = common.GetFileSize(Fl.Length) 'Math.Round(Fl.Length / 1024) & " (KB)"

            '                DTCF.Rows.Add(dr2)
            '            Next
            '        End If
            '        Me.DTCF = DTCF.Copy()
            '    Else
            '        DTCF.Rows.Clear()
            '        Me.DTCF = DTCF.Copy()
            '    End If
            '    common.PBCF = False
            'Catch ex As Exception
            '    common.PBCF = False
            '    If ex.Message.ToString.Contains("Could not find a part of the path") = False And ex.Message.ToString.Contains("The network path was not found") = False Then
            '        MsgBox("Error with Customer files : " & ex.Message, MsgBoxStyle.Exclamation)
            '    End If
            'End Try

            '----DTFTP---------------
            'Try
            '    Dim FTPPath As String = common.GetFTPInternalDirectory(common.CaseNo)

            '    If FTPPath <> "" Then ' checking if the ftp workspace exists
            '        FTPLocation = FTPPath ' setting the value, it will be set by timer
            '        Dim FFileList As ObjectModel.ReadOnlyCollection(Of String)
            '        FFileList = My.Computer.FileSystem.GetFiles(FTPPath, FileIO.SearchOption.SearchAllSubDirectories)

            '        DTFTP.Rows.Clear()
            '        For Each Files As String In FFileList
            '            Dim Fl As New FileInfo(Files)
            '            Dim drl As DataRow = DTFTP.NewRow
            '            drl.Item(0) = Fl.Name.ToString
            '            drl.Item(1) = Files
            '            drl.Item(2) = common.GetFileSize(Fl.Length) ' Math.Round(Fl.Length / 1024) & " (KB)"
            '            DTFTP.Rows.Add(drl)
            '        Next
            '    End If
            '    Me.DTFTP = DTFTP.Copy()
            '    common.PBFTP = False
            'Catch ex As Exception
            '    common.PBFTP = False
            '    If ex.Message.ToString.Contains("Could not find a part of the path") = False And ex.Message.ToString.Contains("The network path was not found") = False And ex.Message.ToString.Contains("The remote server returned an error") = False Then
            '        MsgBox("Error with FTP server : " & ex.Message, MsgBoxStyle.Exclamation)
            '    End If
            'End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Me.DTLocal = DTLocal.Copy()
            Me.DTRemote = DTRemote.Copy()
            Me.DTFTP = DTFTP.Copy()
        End Try
    End Sub

    Private Sub PopulateTV()
        Try
            Dim fl As FileInfo
            Dim dr As DirectoryInfo

            If common.TemplateRoot.Trim <> "" Then
                Dim DrToScan As New DirectoryInfo(common.TemplateRoot)
                TV.Nodes.Clear()
                If My.Computer.FileSystem.DirectoryExists(common.TemplateRoot) Then
                    For Each dr In DrToScan.GetDirectories
                        Dim tn As New TreeNode
                        TV.Nodes.Add(dr.Name, dr.Name)
                        TV.Nodes(dr.Name).ForeColor = Color.Firebrick
                        For Each fl In dr.GetFiles
                            Dim fn As String = fl.Name
                            If fn.ToUpper.EndsWith(".TXT") Then
                                fn = fn.Substring(0, fn.LastIndexOf("."))
                                TV.Nodes(dr.Name).Nodes.Add(fn, fn)
                                TV.Nodes(dr.Name).Nodes(fn).ForeColor = Color.ForestGreen
                            ElseIf fn.ToUpper.EndsWith(".MSG") Then    'changed march 2014 for .msg support
                                fn = fn.Substring(0, fn.LastIndexOf("."))
                                fn = fn & "<External>"
                                TV.Nodes(dr.Name).Nodes.Add(fn, fn)
                                TV.Nodes(dr.Name).Nodes(fn).ForeColor = Color.Indigo
                            End If

                        Next
                    Next

                ElseIf common.AltTemplateRoot.Trim <> "" Then

                    '===========For local=========================================


                    Dim DrToScan2 As New DirectoryInfo(common.AltTemplateRoot)
                    If My.Computer.FileSystem.DirectoryExists(common.AltTemplateRoot) Then
                        For Each dr In DrToScan2.GetDirectories
                            Dim tn As New TreeNode
                            TV.Nodes.Add(dr.Name, dr.Name)
                            TV.Nodes(dr.Name).ForeColor = Color.Firebrick
                            For Each fl In dr.GetFiles
                                Dim fn As String = fl.Name
                                If fn.ToUpper.EndsWith(".TXT") Then
                                    fn = fn.Substring(0, fn.LastIndexOf("."))
                                    TV.Nodes(dr.Name).Nodes.Add(fn, fn)
                                    TV.Nodes(dr.Name).Nodes(fn).ForeColor = Color.ForestGreen
                                ElseIf fn.ToUpper.EndsWith(".MSG") Then    'changed march 2014 for .msg support
                                    fn = fn.Substring(0, fn.LastIndexOf("."))
                                    fn = fn & "<External>"
                                    TV.Nodes(dr.Name).Nodes.Add(fn, fn)
                                    TV.Nodes(dr.Name).Nodes(fn).ForeColor = Color.Indigo
                                End If

                            Next
                        Next
                    Else : MsgBox("Could not find the primary or alternate path to load templates.", MsgBoxStyle.Critical)

                    End If

                Else : MsgBox("Could not find the primary or alternate path to load templates.", MsgBoxStyle.Critical)

                End If


            Else : MsgBox("Could not find path to load templates.", MsgBoxStyle.Critical)

            End If


        Catch ex As Exception
            MsgBox("Error while loading Template : " & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub



    Private Sub TV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TV.DoubleClick

        Try
            If TV.SelectedNode.Level = 1 Then
                ''common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text & ".txt"
                If TV.SelectedNode.Text.EndsWith("<External>") Then
                    Dim pth As String = common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text
                    pth = pth.Substring(0, pth.LastIndexOf("<External>")) & ".msg"
                    Process.Start(pth)
                    Return
                End If
                CreateTab(TV.SelectedNode.Text)
                '=========================================================
                If common.CaseNo.Trim <> "" Then
                    Try
                        CType(TC.SelectedTab.Controls(0), RichTextBox).LoadFile(common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text & ".txt", RichTextBoxStreamType.PlainText)
                    Catch ex As Exception
                        If ex.Message.StartsWith("Could not find a part of the path") Then
                            CType(TC.SelectedTab.Controls(0), RichTextBox).LoadFile(common.AltTemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text & ".txt", RichTextBoxStreamType.PlainText)
                        End If
                    End Try
                    'CType(TC.SelectedTab.Controls(0), RichTextBox).Text = CType(TC.SelectedTab.Controls(0), RichTextBox).Text.Replace("<Caseno>", common.CaseNo)
                    Dim Ts As String
                    Ts = CType(TC.SelectedTab.Controls(0), RichTextBox).Text 'rtf
                    Ts = Ts.Replace("<Caseno>", common.CaseNo)
                    Ts = Ts.Replace("<Customername>", common.CustomerName)
                    Ts = Ts.Replace("<Customerfname>", common.CustomerFName)
                    Ts = Ts.Replace("<Customerlname>", common.CustomerLName)
                    Ts = Ts.Replace("<Date>", Today)

                    '===NEW====
                    ' If common.CaseNo.Trim <> "" Then
                    Ts = Ts.Replace("<Email>", common.GetCaseAttribute("Email", common.CaseNo).Trim)
                    Ts = Ts.Replace("<Problem>", common.GetCaseAttribute("Problem", common.CaseNo).Trim)
                    Ts = Ts.Replace("<Environment>", common.GetCaseAttribute("Environment", common.CaseNo).Trim)
                    ' End If

                    Ts = Ts.Replace("<Datalocations>", common.getFileLocations)

                    CType(TC.SelectedTab.Controls(0), RichTextBox).Text = Ts 'rtf


                Else
                    Try
                        CType(TC.SelectedTab.Controls(0), RichTextBox).LoadFile(common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text & ".txt", RichTextBoxStreamType.PlainText)
                    Catch ex As Exception
                        If ex.Message.StartsWith("Could not find a part of the path") Then
                            CType(TC.SelectedTab.Controls(0), RichTextBox).LoadFile(common.AltTemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text & ".txt", RichTextBoxStreamType.PlainText)
                        End If
                    End Try
                    Dim Ts As String
                    Ts = CType(TC.SelectedTab.Controls(0), RichTextBox).Text 'Rtf
                    'Ts = Ts.Replace("<Caseno>", common.CaseNo)
                    Ts = Ts.Replace("<Date>", Today)
                    CType(TC.SelectedTab.Controls(0), RichTextBox).Text = Ts 'rtf

                End If


                CType(TC.SelectedTab.Controls(0), RichTextBox).ForeColor = Color.FromName(common.FontColor) ' this is put here again to fix a bug where if there is a link at the start of the page the fore color turns black
                CType(TC.SelectedTab.Controls(0), RichTextBox).BackColor = Color.FromName(common.BackColor) ' this is put here again to fix a bug where if there is a link at the start of the page the fore color turns black

                '===PUTING SPACE BEFORE ENTER==================================================
                'MsgBox(CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf)
                CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace(" \par", "\par")
                'MsgBox(CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf)
                CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace("\par", " \par")
                'MsgBox(CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf)
                'CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace("\par" & vbCrLf & " \par", "\par" & vbCrLf & "\par")
                'CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace("\par" & vbCrLf & " \par", "\par" & vbCrLf & "\par")
                CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace(" \cf", "\cf") 'this line is implemented  to get ride of initial space
                '==============================================================================

                'If BtnReset.Text.Contains("PAUSE") Then
                '    SW.Start()
                '    TimerTabTime.Enabled = True
                'Else
                '    SW.Stop()
                '    TimerTabTime.Enabled = False
                'End If

            End If
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try

    End Sub


    Private Sub UpdateTabTimer()
        Try
            Dim TimerValue, Finalstring As String
            Dim Hr, Min, Sec As String

            If TC.TabCount > 0 Then
                If TC.SelectedTab.Text.Contains("[") And TC.SelectedTab.Text.Contains("]") And TC.SelectedTab.Text.LastIndexOf("]") > TC.SelectedTab.Text.LastIndexOf("[") Then
                    TimerValue = TC.SelectedTab.Text.Substring(TC.SelectedTab.Text.LastIndexOf("[") + 1, TC.SelectedTab.Text.LastIndexOf("]") - (TC.SelectedTab.Text.LastIndexOf("[") + 1))
                    'MsgBox(TimerValue)
                    If TimerValue.Length = 8 Then



                        Hr = TimerValue.Substring(0, 2)
                        Min = TimerValue.Substring(3, 2)
                        Sec = TimerValue.Substring(6, 2)

                        If IsNumeric(Hr) And IsNumeric(Min) And IsNumeric(Sec) Then
                            Dim Hrn, Minn, Secn As Int32
                            Hrn = Hr
                            Minn = Min
                            Secn = Sec

                            If Secn < 59 Then
                                Secn = Secn + 1
                            ElseIf Secn >= 59 And Minn < 59 Then
                                Minn = Minn + 1
                                Secn = 0
                            ElseIf Secn >= 59 And Minn >= 59 Then
                                Hrn = Hrn + 1
                                Minn = 0
                                Secn = 0
                            ElseIf Hrn >= 98 Then
                                Hrn = 0
                                Minn = 0
                                Secn = 0
                            End If

                            If Hrn < 10 Then
                                Hr = "0" & Hrn
                            ElseIf Hrn >= 10 Then
                                Hr = Hrn
                            End If

                            If Minn < 10 Then
                                Min = "0" & Minn
                            ElseIf Minn >= 10 Then
                                Min = Minn
                            End If

                            If Secn < 10 Then
                                Sec = "0" & Secn
                            ElseIf Secn >= 10 Then
                                Sec = Secn
                            End If


                            Finalstring = TC.SelectedTab.Text.Substring(0, TC.SelectedTab.Text.LastIndexOf("["))
                            TC.SelectedTab.Text = Finalstring & "[" & Hr & ":" & Min & ":" & Sec & "]"

                        Else
                            TC.SelectedTab.Text = TC.SelectedTab.Text & "[00:00:00]"
                        End If
                    Else
                        Finalstring = TC.SelectedTab.Text.Substring(0, TC.SelectedTab.Text.LastIndexOf("["))
                        TC.SelectedTab.Text = Finalstring & "[00:00:00]"
                    End If
                Else
                    TC.SelectedTab.Text = TC.SelectedTab.Text & "[00:00:00]"
                End If
            End If
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub


    Private Sub TimerTabTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTabTime.Tick
        Try

            TxtTimer.Text = IIf(SW.Elapsed.Hours < 10, "0" & SW.Elapsed.Hours, SW.Elapsed.Hours) & ":" & IIf(SW.Elapsed.Minutes < 10, "0" & SW.Elapsed.Minutes, SW.Elapsed.Minutes) & ":" & IIf(SW.Elapsed.Seconds < 10, "0" & SW.Elapsed.Seconds, SW.Elapsed.Seconds)

            UpdateTabTimer()

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub CreateTab(ByVal Tabname As String) ' first time without any template  and template doubleclick
        Try
            '====Creating tab page
            Dim TP As New TabPage
            TP.Name = "Tab"
            TP.BackColor = Color.White
            TC.TabPages.Add(TP)
            TP.Text = Tabname
            TP.Tag = Tabname & "-" & Format(Now, "yyyyMMddHHmmss") 'http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx
            TP.BorderStyle = BorderStyle.FixedSingle

            
            '=======Adding textbox inside it
            Dim CN As New RTBSpellChecker
            CN.Name = "CN"

            TP.Controls.Add(CN)

            TC.SelectedIndex = TC.TabPages.Count - 1
            CN.AcceptsTab = True
            CN.Multiline = True
            CN.BorderStyle = BorderStyle.None
            CN.Top = 0
            CN.Left = 0
            CN.Width = TP.Width - 4
            CN.Height = TP.Height
            CN.ScrollBars = RichTextBoxScrollBars.Vertical   'both
            CN.DetectUrls = True
            ' CN.ShowSelectionMargin = True ' issue with scrollbar if enabled
            CN.AutoWordSelection = True
            CN.AcceptsTab = True
            CN.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
            CN.WordWrap = True 'false
            CN.Font = New System.Drawing.Font(common.FontName, common.FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CN.ForeColor = Color.FromName(common.FontColor)  'CType(common.FontColor, System.Drawing.Color) 'Color.RoyalBlue
            CN.BackColor = Color.FromName(common.BackColor)


            '===============================
            If Chkwordwrap.Checked = True Then
                CType(TP.Controls(0), RichTextBox).WordWrap = True
                CType(TP.Controls(0), RichTextBox).ScrollBars = RichTextBoxScrollBars.Vertical
            ElseIf Chkwordwrap.Checked = False Then
                CType(TP.Controls(0), RichTextBox).WordWrap = False
                CType(TP.Controls(0), RichTextBox).ScrollBars = RichTextBoxScrollBars.Both
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CreateTab(ByVal Tabname As String, ByVal TabTag As String) ' new case no
        Try
            '====Creating tab page
            Dim TP As New TabPage
            TP.Name = "Tab"
            ' TP.Text = Tabname

            Try
                Dim TimerValue As String = "[" & TabTag.Substring(TabTag.LastIndexOf("[") + 1, TabTag.LastIndexOf("]") - (TabTag.LastIndexOf("[") + 1)) & "]"
                TimerValue = TimerValue.Replace("_", ":")
                TP.Text = Tabname & TimerValue
            Catch ex As Exception
                If ex.Message.Trim.StartsWith("Length cannot be less than zero") Then
                    TP.Text = Tabname & "[00:00:00]"
                End If
            End Try


            TP.Tag = TabTag
            TP.BorderStyle = BorderStyle.FixedSingle

            '=======Adding textbox inside it
            Dim CN As New RTBSpellChecker
            CN.Name = "CN"
            TP.Controls.Add(CN)
            TC.TabPages.Add(TP)
            TC.SelectedIndex = TC.TabPages.Count - 1

            ' CN.Font = New System.Drawing.Font("Courier New", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CN.AcceptsTab = True
            CN.Multiline = True
            CN.BorderStyle = BorderStyle.None
            CN.Top = 0
            CN.Left = 0
            CN.Width = TP.Width
            CN.Height = TP.Height
            'CN.Font = New System.Drawing.Font("Courier New", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CN.DetectUrls = True
            'CN.ShowSelectionMargin = True
            CN.AutoWordSelection = True
            CN.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
            CN.WordWrap = True 'false
            CN.ScrollBars = RichTextBoxScrollBars.Vertical 'Both 
            CN.Font = New System.Drawing.Font(common.FontName, common.FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CN.ForeColor = Color.FromName(common.FontColor) 'Color.RoyalBlue
            CN.BackColor = Color.FromName(common.BackColor)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Friend Sub CreateBrowserTab(ByVal Tabname As String, ByVal lnk As String, ByVal unclosable As Boolean)
        Try
            '====Creating tab page
            Dim TP As New TabPage
            TP.Name = "BrowserTab"
            TP.Text = Tabname
            If unclosable = True Then
                TP.Tag = "UnClosable"
            Else
                TP.Tag = "Closable"
            End If
            TP.BorderStyle = BorderStyle.FixedSingle
            '=======Adding browser inside it
            Dim WB As New WebBrowser
            WB.Name = "MyWB"
            WB.Top = 0
            WB.Left = 0
            WB.Width = TP.Width
            WB.Height = TP.Height
            WB.Url = New System.Uri(lnk, System.UriKind.Absolute)


            WB.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top

            TP.Controls.Add(WB)
            TCMain.TabPages.Add(TP)
            'TC.SelectedIndex = TC.TabPages.Count - 1


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Friend Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        Try
            'SW.Reset()
            'SW.Start()
            'TimerTabTime.Enabled = Not TimerTabTime.Enabled
            If SW.IsRunning Then
                SW.Stop()
                TimerTabTime.Enabled = False
                BtnReset.Text = "         START"
            Else
                SW.Start()
                TimerTabTime.Enabled = True
                BtnReset.Text = "         PAUSE"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            'uncomment the line below for general timer
            'TxtTimer.Text = IIf(SW.Elapsed.Hours < 10, "0" & SW.Elapsed.Hours, SW.Elapsed.Hours) & ":" & IIf(SW.Elapsed.Minutes < 10, "0" & SW.Elapsed.Minutes, SW.Elapsed.Minutes) & ":" & IIf(SW.Elapsed.Seconds < 10, "0" & SW.Elapsed.Seconds, SW.Elapsed.Seconds)

            'Auto saving after every 30secs
            TimeElapsedAfterLastSave = TimeElapsedAfterLastSave + 1
            If TimeElapsedAfterLastSave > 60 And common.IsCaseNo(common.CaseNo.Trim) = True Then

                SaveAllTabs()
                ExtractCaseInfoIntoConfigFile() ' also fetching caseinfo
                TimeElapsedAfterLastSave = 0

            End If


            'Blinking the alert when there is a reminder.  "(" & DGAlert.RowCount & ") Reminder(s)"
            If TC1.TabPages(1).Text <> "(0) Reminder(s)" Then
                PicAlert.Visible = Not PicAlert.Visible
            Else
                PicAlert.Visible = False
            End If

            If common.IsCaseNo(common.CaseNo.Trim) = True Then
                If common.PBPS = True Then
                    PBPS.Visible = True
                End If
                If common.PBLS = True Then
                    PBLS.Visible = True
                End If
                'If common.PBCF = True Then
                '    PBCF.Visible = True
                'End If
                'If common.PBFTP = True Then
                '    PBFTP.Visible = True
                'End If
            End If


            'getting case info after every 1 min
            TimeElapsedAfterLastCaseinfoGathered = TimeElapsedAfterLastCaseinfoGathered + 1
            If TimeElapsedAfterLastSave > 120 And common.IsCaseNo(common.CaseNo.Trim) = True Then
                ExtractCaseInfoIntoConfigFile() ' also fetching caseinfo
                TimeElapsedAfterLastCaseinfoGathered = 0

            End If

            'binding datagrid after about 7-8 secs
            TimeElapsedAfterLastDataGridBinding = TimeElapsedAfterLastDataGridBinding + 1
            If TimeElapsedAfterLastDataGridBinding > 10 And common.IsCaseNo(common.CaseNo.Trim) = True Then
                'filling grids with file list

                DGLocal.DataSource = DTLocal
                DGRemote.DataSource = DTRemote
                'DGCF.DataSource = DTCF
                'DGFTP.DataSource = DTFTP
                'LblFTP.Text = FTPLocation
                'LblCF.Text = CFLocation



                If common.PBPS = False Then
                    PBPS.Visible = False
                End If
                If common.PBLS = False Then
                    PBLS.Visible = False
                End If
                'If common.PBCF = False Then
                '    PBCF.Visible = False
                'End If
                'If common.PBFTP = False Then
                '    PBFTP.Visible = False
                'End If


                'Try 'so that these lines does not throws an error in case of cases with lots of files
                '    DGLocal.Columns(3).Width = 250
                '    DGRemote.Columns(3).Width = 250
                'Catch ex As Exception
                'End Try


                'gettting file list since a file is newly copied
                If common.CollectFileList = True Then
                    common.CollectFileList = False
                    Dim t As New Threading.Thread(AddressOf AsyncGetFiles)
                    t.Start()

                End If

                TimeElapsedAfterLastDataGridBinding = 0
            End If

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem1.Click
        Try
            Dim settings As New Settings
            settings.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub NewCaseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCaseToolStripMenuItem1.Click
        BtnNew_Click(sender, e)
    End Sub

    Friend Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Try

            Cursor.Current = Cursors.WaitCursor
            If common.IsCaseNo(common.CaseNo.Trim) = True Then
                'If MsgBox("Do you want to save the notes before entering a new case no?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                SaveAllTabs()
                'Dim tp As TabPage
                'For Each tp In TC.TabPages
                '    tp.Dispose()
                'Next
                'End If
            End If

            If lblCaseno.Text.Trim = "" Then
                IsFirstCase = True
            Else
                IsFirstCase = False
            End If


            Dim cno As New Caseno
            cno.ShowDialog()

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub SaveAllTabs()
        Try
            If common.IsCaseNo(common.CaseNo) Then  '2/12/09
                If My.Computer.FileSystem.DirectoryExists(common.NotesRoot & "\" & common.CaseNo & "\" & "AllNotes") = False Then
                    My.Computer.FileSystem.CreateDirectory(common.NotesRoot & "\" & common.CaseNo & "\" & "AllNotes")
                End If
                '===============================================================

                Dim fl As FileInfo
                Dim Dr As New DirectoryInfo(common.NotesRoot & "\" & common.CaseNo & "\AllNotes")

                Dim tp As TabPage
                For Each tp In TC.TabPages
                    'If File.Exists(common.NotesRoot & "\" & common.CaseNo & "\" & "AllNotes" & "\" & tp.Tag & ".txt") = True Then
                    '    File.Delete(common.NotesRoot & "\" & common.CaseNo & "\" & "AllNotes" & "\" & tp.Tag & ".txt")
                    'End If
                    Try
                        Dim Fln As String = tp.Tag.ToString.Substring(0, tp.Tag.ToString.LastIndexOf("["))
                        For Each fl In Dr.GetFiles
                            If fl.Name.StartsWith(Fln) Then
                                fl.Delete()
                                Exit For
                            End If
                        Next
                    Catch ex As Exception
                        If ex.Message.Trim.StartsWith("Length cannot be less than zero") Then

                            If File.Exists(common.NotesRoot & "\" & common.CaseNo & "\" & "AllNotes" & "\" & tp.Tag & ".txt") = True Then
                                File.Delete(common.NotesRoot & "\" & common.CaseNo & "\" & "AllNotes" & "\" & tp.Tag & ".txt")
                            End If

                            tp.Tag = tp.Tag & "[00_00_00]"

                        End If
                    End Try


                    Dim SaveName As String = tp.Tag
                    If SaveName.Contains("[") And SaveName.Contains("]") And SaveName.LastIndexOf("]") > SaveName.LastIndexOf("[") Then
                        Dim TimerValue As String = tp.Text.Substring(tp.Text.LastIndexOf("[") + 1, tp.Text.LastIndexOf("]") - (tp.Text.LastIndexOf("[") + 1))
                        TimerValue = TimerValue.Replace(":", "_")
                        SaveName = SaveName.Substring(0, SaveName.LastIndexOf("[")) & "[" & TimerValue & "]"
                    ElseIf tp.Text.Contains("[") And tp.Text.Contains("]") And tp.Text.LastIndexOf("]") > tp.Text.LastIndexOf("[") Then
                        Dim TimerValue As String = tp.Text.Substring(tp.Text.LastIndexOf("[") + 1, tp.Text.LastIndexOf("]") - (tp.Text.LastIndexOf("[") + 1))
                        TimerValue = TimerValue.Replace(":", "_")
                        SaveName = SaveName & "[" & TimerValue & "]"
                    Else
                        SaveName = tp.Tag & "[00_00_00]"
                    End If
                    'MsgBox(SaveName)


                    CType(tp.Controls(0), RichTextBox).SaveFile(common.NotesRoot & "\" & common.CaseNo & "\" & "AllNotes" & "\" & SaveName & ".txt", RichTextBoxStreamType.PlainText)
                Next
            End If
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." And ex.Message.StartsWith("Length cannot be less than zero") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub

    Private Sub ExtractCaseInfoIntoConfigFile()
        Try
            Dim tp As TabPage
            If common.CaseNo.Trim <> "" Then
                For Each tp In TC.TabPages
                    Dim TabContent As String
                    TabContent = CType(tp.Controls(0), RichTextBox).Text.Trim

                    If TabContent.Contains("<PrimaryEmail>") And TabContent.Contains("<PrimaryEmail/>") And TabContent.IndexOf("<PrimaryEmail>") < TabContent.IndexOf("<PrimaryEmail/>") Then
                        If TabContent.LastIndexOf("<PrimaryEmail>") = TabContent.IndexOf("<PrimaryEmail>") And TabContent.LastIndexOf("<PrimaryEmail/>") = TabContent.IndexOf("<PrimaryEmail/>") Then
                            If TabContent.Substring(TabContent.IndexOf("<PrimaryEmail>") + 14, TabContent.IndexOf("<PrimaryEmail/>") - (TabContent.IndexOf("<PrimaryEmail>") + 14)).Trim <> "" Then
                                common.SetCaseAttribute("Email", TabContent.Substring(TabContent.IndexOf("<PrimaryEmail>") + 14, TabContent.IndexOf("<PrimaryEmail/>") - (TabContent.IndexOf("<PrimaryEmail>") + 14)), common.CaseNo)
                            End If
                        End If
                    End If

                    If TabContent.Contains("<ScopeProblem>") And TabContent.Contains("<ScopeProblem/>") And TabContent.IndexOf("<ScopeProblem>") < TabContent.IndexOf("<ScopeProblem/>") Then
                        If TabContent.LastIndexOf("<ScopeProblem>") = TabContent.IndexOf("<ScopeProblem>") And TabContent.LastIndexOf("<ScopeProblem/>") = TabContent.IndexOf("<ScopeProblem/>") Then
                            If TabContent.Substring(TabContent.IndexOf("<ScopeProblem>") + 14, TabContent.IndexOf("<ScopeProblem/>") - (TabContent.IndexOf("<ScopeProblem>") + 14)).Trim <> "" Then
                                common.SetCaseAttribute("Problem", TabContent.Substring(TabContent.IndexOf("<ScopeProblem>") + 14, TabContent.IndexOf("<ScopeProblem/>") - (TabContent.IndexOf("<ScopeProblem>") + 14)), common.CaseNo)
                            End If
                        End If
                    End If

                    If TabContent.Contains("<ScopeEnvironment>") And TabContent.Contains("<ScopeEnvironment/>") And TabContent.IndexOf("<ScopeEnvironment>") < TabContent.IndexOf("<ScopeEnvironment/>") Then
                        If TabContent.LastIndexOf("<ScopeEnvironment>") = TabContent.IndexOf("<ScopeEnvironment>") And TabContent.LastIndexOf("<ScopeEnvironment/>") = TabContent.IndexOf("<ScopeEnvironment/>") Then
                            If TabContent.Substring(TabContent.IndexOf("<ScopeEnvironment>") + 18, TabContent.IndexOf("<ScopeEnvironment/>") - (TabContent.IndexOf("<ScopeEnvironment>") + 18)).Trim <> "" Then
                                common.SetCaseAttribute("Environment", TabContent.Substring(TabContent.IndexOf("<ScopeEnvironment>") + 18, TabContent.IndexOf("<ScopeEnvironment/>") - (TabContent.IndexOf("<ScopeEnvironment>") + 18)), common.CaseNo)
                            End If
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            If ex.Message.StartsWith("Length cannot be less than zero") Or ex.Message.StartsWith("startIndex cannot be larger than length of string") Then

            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub

    Private Sub CopyResourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyResourceToolStripMenuItem.Click
        Btncopy_Click(sender, e)
    End Sub

    Private Sub Btncopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncopy.Click
        Try
            If common.IsCaseNo(common.CaseNo.Trim) = False Then
                MsgBox("Please specify a valid case no.", MsgBoxStyle.Information)
                Exit Sub
            Else
                Dim Cr As New CopyResource
                Cr.Show()

                '------Writing log ------------------
                common.ExtraDataToLog = "File copied from toolbar for Case no - " & common.CaseNo
                Dim WL As New Threading.Thread(AddressOf common.WriteLog)
                WL.Start()
                '------------------------------------
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub SendMailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendMailToolStripMenuItem1.Click
        Btnmail_Click(sender, e)
    End Sub

    Private Sub SettingsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem2.Click
        Btnsetting_Click(sender, e)
    End Sub

    Private Sub Btnsetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsetting.Click
        Try
            Dim settings As New Settings
            settings.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Btnrefresh_Click(sender, e)
    End Sub

    Friend Sub Btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnrefresh.Click
        Try
            PopulateTV()

            '===========for copy progress bar

            common.PBPS = True

            common.PBLS = True

            common.PBCF = True

            common.PBFTP = True

            '===============================

            Dim t As New Threading.Thread(AddressOf AsyncGetFiles)
            t.Start()
            If DSAlert.Tables.Count > 0 Then DGAlert.DataSource = DSAlert.Tables(0)

            '------Writing log ------------------
            common.ExtraDataToLog = "Refresh from toolbar for Case no - " & common.CaseNo
            Dim WL As New Threading.Thread(AddressOf common.WriteLog)
            WL.Start()
            '------------------------------------
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Try
            SaveAllTabs()
            TC.SelectedTab.Dispose()
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Try
            Dim about As New About
            about.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnOpendir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpendir.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            If common.IsCaseNo(common.CaseNo.Trim) = False Then
                'MsgBox("Please specify a valid case no.", MsgBoxStyle.Information)
                Process.Start(common.NotesRoot)
                Exit Sub
            Else
                Process.Start(common.NotesRoot & "\" & common.CaseNo)
            End If
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub BtnOpenFtp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Cursor.Current = Cursors.WaitCursor
            If common.IsCaseNo(Common.CaseNo.Trim) = False Then
                MsgBox("Please specify a valid case no.", MsgBoxStyle.Information)
                Exit Sub
            Else
                If FTPLocation.Trim = "" Then
                    MsgBox("Please Check if there is a FTP workspace associated with this case.", MsgBoxStyle.Information)
                    Exit Sub
                Else
                    Process.Start(FTPLocation)
                End If

            End If
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            If ex.Message.StartsWith("Object reference not set to an instance of an object") Then
                MsgBox("Still searching for associated workspace.", MsgBoxStyle.Information)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If

        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub OpenCaseDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BtnOpendir_Click(sender, e)
    End Sub

    Private Sub BtnOpenNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpenNotes.Click
        Try


            Dim Cleanoldcases As New CleanOldCases
            Cleanoldcases.ShowDialog()

            '------Writing log ------------------
            Common.ExtraDataToLog = "Manage cases"
            Dim WL As New Threading.Thread(AddressOf common.WriteLog)
            WL.Start()
            '------------------------------------



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub CaseNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaseNotesToolStripMenuItem.Click
        BtnOpenNotes_Click(sender, e)
    End Sub

    Private Sub BtnCreateTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreateTemplate.Click
        Try
            If My.Computer.FileSystem.DirectoryExists(Common.TemplateRoot) Then
                Dim CT As New CreateTemplate
                CT.ShowDialog()
            End If

            '------Writing log ------------------
            Common.ExtraDataToLog = "Create template from toolbar"
            Dim WL As New Threading.Thread(AddressOf common.WriteLog)
            WL.Start()
            '------------------------------------

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TxtCaseNotes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Common.AllDataSaved = False
    End Sub

    Private Sub BtnDeletetemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletetemplate.Click
        Try
            Dim pth As String
            If TV.SelectedNode.Level = 1 Then
                If TV.SelectedNode.Text.EndsWith("<External>") Then
                    pth = Common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text
                    pth = pth.Substring(0, pth.LastIndexOf("<External>")) & ".msg"
                Else
                    pth = Common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text & ".txt"
                End If

                If My.Computer.FileSystem.FileExists(pth) = False Then
                    MsgBox("This Template does not exists.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                If MsgBox("Are you sure you want to delete this Template ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(pth)
                End If

                Btnrefresh_Click(sender, e)

                '------Writing log ------------------
                Common.ExtraDataToLog = "Delete Template"
                Dim WL As New Threading.Thread(AddressOf common.WriteLog)
                WL.Start()
                '------------------------------------
                'Else
                '    MsgBox("Please select a template to delete.", MsgBoxStyle.Exclamation)
                'End If
            ElseIf TV.SelectedNode.Level = 0 Then

                If My.Computer.FileSystem.DirectoryExists(Common.TemplateRoot & "\" & TV.SelectedNode.Text) = False Then
                    MsgBox("This Group does not exists.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                If MsgBox("Are you sure you want to delete this Template Group? All the templates inside group will be deleted as well.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteDirectory(Common.TemplateRoot & "\" & TV.SelectedNode.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If

                Btnrefresh_Click(sender, e)


            Else
                MsgBox("Please select a template to delete.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try
    End Sub

    Private Sub NewTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTemplateToolStripMenuItem.Click
        BtnCreateTemplate_Click(sender, e)
    End Sub

    Private Sub DeleteTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTemplateToolStripMenuItem.Click
        BtnDeletetemplate_Click(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Dispose()
    End Sub

    Private Sub Btnmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmail.Click
        Try
            OpenMail()

            '------Writing log ------------------
            Common.ExtraDataToLog = "Mail for Case no - " & Common.CaseNo
            Dim WL As New Threading.Thread(AddressOf common.WriteLog)
            WL.Start()
            '------------------------------------
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub

    Private Sub OpenMail()
        Try
            Dim OApp As Outlook.Application = New Outlook.Application()
            Dim MI As Outlook.MailItem = OApp.CreateItem(Outlook.OlItemType.olMailItem)


            If common.IsClarifyCase = True Then
                MI.To = common.GetCaseAttribute("Email", Common.CaseNo)
                MI.Subject = "Microsoft Support Case " & Common.CaseNo
                MI.CC = "compmail@microsoft.com"
            ElseIf common.IsMSSolveCase = True Then
                MI.To = common.GetCaseAttribute("Email", Common.CaseNo)
                MI.Subject = " " & Common.CaseNo.ToString.Substring(0, 15) & " " '[REG:109041063115314] 
                'MI.To = common.CustomerName
                MI.CC = "casemail@microsoft.com"

            End If

            MI.BodyFormat = Outlook.OlBodyFormat.olFormatRichText
            MI.Body = CType(TC.SelectedTab.Controls(0), RichTextBox).Text
            MI.Display()



        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub

    Private Sub OpenInNewTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenInNewTabToolStripMenuItem.Click
        TV_DoubleClick(sender, e)
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        Try
            Dim pth As String ' for .eml added on 18th march
            If TV.SelectedNode.Text.EndsWith("<External>") Then
                pth = Common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text
                pth = pth.Substring(0, pth.LastIndexOf("<External>")) & ".msg"
            Else
                pth = Common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text & ".txt"
            End If

            If TV.SelectedNode.Level = 1 Then
                Process.Start(pth)
            Else
                MsgBox("Please select a template to open.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        BtnDeletetemplate_Click(sender, e)
    End Sub

    Private Sub lblCaseno_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCaseno.DoubleClick
        Try
            BtnNew_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTeamShare.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            If common.IsCaseNo(Common.CaseNo.Trim) = False Then
                Process.Start(Common.DSDBshare)
            Else
                Process.Start(Common.DSDBshare & "\" & Common.CaseNo)
            End If
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub TeamShareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeamShareToolStripMenuItem.Click
        Button2_Click(sender, e)
    End Sub

    Private Sub FTPWorkspaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTPWorkspaceToolStripMenuItem.Click
        BtnOpenFtp_Click(sender, e)
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabToolStripMenuItem.Click
        Btnexit_Click(sender, e)
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        Btnrefresh_Click(sender, e)
    End Sub

    Private Sub TCMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TCMain.MouseDown
        Try
            If e.Button = MouseButtons.Right Then
                For i = 0 To TCMain.TabCount - 1
                    Dim r As Rectangle = TCMain.GetTabRect(i)
                    If r.Contains(e.Location) Then
                        TCMain.SelectedIndex = i
                    End If

                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    'this is for changing the tab color
    'Private Sub TCMain_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TCMain.DrawItem
    '    Try
    '        Dim g As Graphics = e.Graphics
    '        Dim tp As TabPage = TCMain.TabPages(0)
    '        Dim br As Brush
    '        Dim sf As New StringFormat
    '        Dim r As New RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2)

    '        If e.Index = 0 Then
    '            sf.Alignment = StringAlignment.Center

    '            Dim strTitle As String = tp.Text
    '            'If the current index is the Selected Index, change the color
    '            ' If TCMain.SelectedIndex = e.Index Then
    '            'this is the background color of the tabpage
    '            'you could make this a stndard color for the selected page
    '            br = New SolidBrush(Color.Bisque)
    '            'this is the background color of the tab page
    '            g.FillRectangle(br, e.Bounds)
    '            'this is the background color of the tab page
    '            'you could make this a stndard color for the selected page
    '            br = New SolidBrush(tp.ForeColor)

    '            g.DrawString(strTitle, TCMain.Font, br, r, sf)
    '            'Else
    '            '    'these are the standard colors for the unselected tab pages
    '            '    br = New SolidBrush(Color.WhiteSmoke)
    '            '    g.FillRectangle(br, e.Bounds)
    '            '    br = New SolidBrush(Color.Black)
    '            '    g.DrawString(strTitle, TCMain.Font, br, r, sf)
    '            'End If
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    Private Sub TCMain_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TCMain.SelectedIndexChanged
        Try

            If TCMain.SelectedIndex + 1 = 1 Then
                BtnPrevious.Enabled = False
                BtnrefreshPage.Enabled = False
                BtnForeward.Enabled = False
                PanelBB.Visible = False
            Else
                BtnPrevious.Enabled = True
                BtnrefreshPage.Enabled = True
                BtnForeward.Enabled = True
                PanelBB.Visible = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#Region "Browser buttons"

    Private Sub BtnrefreshPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnrefreshPage.Click
        Try
            If TCMain.SelectedIndex + 1 > 1 Then
                CType(TCMain.TabPages(TCMain.SelectedIndex).Controls(0), WebBrowser).Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        Try
            If TCMain.SelectedIndex + 1 > 1 Then
                CType(TCMain.TabPages(TCMain.SelectedIndex).Controls(0), WebBrowser).GoBack()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnForeward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForeward.Click
        Try
            If TCMain.SelectedIndex + 1 > 1 Then
                CType(TCMain.TabPages(TCMain.SelectedIndex).Controls(0), WebBrowser).GoForward()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub




#End Region



    Private Sub lblCaseno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCaseno.TextChanged
        Try

            '=============== test for clearing the file grids immediately after chenging case no. 4th aug 2010
            DTLocal.Rows.Clear()
            DTRemote.Rows.Clear()
            DTCF.Rows.Clear()
            DTFTP.Rows.Clear()

            DGLocal.DataSource = DTLocal
            DGRemote.DataSource = DTRemote
            'DGCF.DataSource = DTCF
            'DGFTP.DataSource = DTFTP

            '=========================================================



            'TimerTabTime.Enabled = False
            Timer1.Enabled = False ' to fix a bug where when we open a case over a orphan  note after 1 minute idealness it creates duplicate tab
            Chkwordwrap.Checked = True
            If common.IsCaseNo(Common.CaseNo) Then
                Cursor.Current = Cursors.WaitCursor

                '===========for copy progress bar
                Common.PBPS = True
                Common.PBLS = True
                Common.PBCF = True
                Common.PBFTP = True
                '===============================

                BtnMSSolve.Enabled = True
                'If common.IsMSSolveCase = True Then
                '    BtnMSSolve.Enabled = True
                'Else
                '    BtnMSSolve.Enabled = False
                'End If

                If IsFirstCase = False Then
                    Dim tp As TabPage
                    For Each tp In TC.TabPages
                        tp.Dispose()
                    Next
                ElseIf IsFirstCase = True And TC.TabPages.Count > 0 Then
                    If MsgBox("Would you like to add the present notes to the case that you are opening?" & vbCrLf & "'NO', the present notes would be discarded." & vbCrLf & "'YES', The present notes will be addes to the case you are opening.", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    Else
                        Dim tp As TabPage
                        For Each tp In TC.TabPages
                            tp.Dispose()
                        Next
                    End If
                End If
                If Directory.Exists(Common.NotesRoot & "\" & lblCaseno.Text.Trim & "\" & "AllNotes") = False Then
                    My.Computer.FileSystem.CreateDirectory(Common.NotesRoot & "\" & lblCaseno.Text.Trim & "\" & "AllNotes")
                    common.SetCaseAttribute("CustomerName", Common.CustomerName, lblCaseno.Text.Trim)
                    'My.Computer.FileSystem.WriteAllText(common.NotesRoot & "\" & lblCaseno.Text.Trim & "\Info.txt", common.CustomerName, False)
                Else
                    '-------------------------------------

                    If Common.CustomerName.Trim <> "" Then common.SetCaseAttribute("CustomerName", Common.CustomerName, lblCaseno.Text.Trim) 'My.Computer.FileSystem.WriteAllText(common.NotesRoot & "\" & lblCaseno.Text.Trim & "\Info.txt", common.CustomerName, False)

                    'If MsgBox("This seems to be an old case. You probably already have some case notes for this case. Click on 'Yes' to load the previous saved case notes in tabs or Go to Open > Local Case directory or Open > Local Case notes to check the case history.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Dim fl As FileInfo
                    Dim Dr As New DirectoryInfo(Common.NotesRoot & "\" & Common.CaseNo & "\AllNotes")
                    'for progress bar
                    'Dim fc As Integer
                    'For Each fl In Dr.GetFiles
                    '    fc = fc + 1
                    'Next

                    If Common.DonotLoadPreviousNotes = False Then

                        '=====Creating datatable
                        Dim DT As New DataTable
                        Dim Namebeforedash As New DataColumn("Namebeforedash")
                        Dim Namebeforedot As New DataColumn("Namebeforedot")
                        Dim fullname As New DataColumn("fullname")
                        Dim Timestamp As New DataColumn("Timestamp")

                        DT.Columns.Add(Namebeforedash)
                        DT.Columns.Add(Namebeforedot)
                        DT.Columns.Add(fullname)
                        DT.Columns.Add(Timestamp)

                        For Each fl In Dr.GetFiles
                            Dim drow As DataRow = DT.NewRow
                            drow.Item(0) = fl.Name.ToString.Substring(0, fl.Name.ToString.LastIndexOf("-"))
                            drow.Item(1) = fl.Name.ToString.Substring(0, fl.Name.ToString.LastIndexOf("."))
                            drow.Item(2) = fl.FullName
                            drow.Item(3) = fl.Name.ToString.Substring(fl.Name.ToString.LastIndexOf("-") + 1, fl.Name.ToString.LastIndexOf("[") - fl.Name.ToString.LastIndexOf("-") - 1) 'fl.CreationTime
                            DT.Rows.Add(drow)

                        Next
                        Dim dv As DataView
                        dv = DT.DefaultView
                        dv.Sort = "Timestamp,Namebeforedash DESC"

                        For i = 0 To dv.Table.Rows.Count - 1
                            CreateTab(dv(i).Item(0), dv(i).Item(1))
                            CType(TC.SelectedTab.Controls(0), RichTextBox).LoadFile(dv(i).Item(2), RichTextBoxStreamType.PlainText)


                            '===PUTING SPACE BEFORE ENTER==================================================
                            CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace(" \par", "\par")
                            CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace("\par", " \par")
                            CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace("\par" & vbCrLf & " \par", "\par" & vbCrLf & "\par")
                            CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace("\par" & vbCrLf & " \par", "\par" & vbCrLf & "\par")
                            CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf = CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf.Replace(" \cf", "\cf") 'this line is implemented  to get ride of initial space
                            '==============================================================================

                        Next

                    End If

                    'End If

                End If

                lbllocal.Text = Common.NotesRoot & "\" & Common.CaseNo
                lblremote.Text = Common.DSDBshare & "\" & Common.CaseNo
                'If common.IsMSSolveCase = True Then
                '    LblCF.Enabled = True
                '    BtnOpenCF.Enabled = True
                '    LblCF.Text = common.getCustomerFilePath
                'Else
                '    LblCF.Enabled = False
                '    BtnOpenCF.Enabled = False
                '    LblCF.Text = ""
                'End If

                'LblCF.Text = ""
                CFLocation = ""
                'LblFTP.Text = ""
                FTPLocation = ""

                '------Writing log with case no------
                Common.ExtraDataToLog = "Case Opened - " & Common.CaseNo
                Dim WL As New Threading.Thread(AddressOf common.WriteLog)
                WL.Start()
                '------------------------------------

                Cursor.Current = Cursors.Default

            Else
                BtnMSSolve.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Timer1.Enabled = True
            Cursor.Current = Cursors.Default
        End Try

    End Sub


    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            Me.Opacity = ToolStripComboBox1.Text / 100
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CloseTabToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabToolStripMenuItem1.Click
        Try
            SaveAllTabs()
            TC.SelectedTab.Dispose()
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub

    Private Sub DeleteThisNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteThisNoteToolStripMenuItem.Click
        Try
            If common.IsCaseNo(Common.CaseNo) = False Then
                MsgBox("Notes Can't be saved or deleted without Case number.", MsgBoxStyle.Information)
            Else

                If MsgBox("This note will be deleted parmanently. Are you sure ?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    File.Delete(Common.NotesRoot & "\" & Common.CaseNo & "\" & "AllNotes" & "\" & TC.SelectedTab.Tag & ".txt")
                    TC.SelectedTab.Dispose()
                End If

            End If

        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try

    End Sub

    Private Sub LblCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblCustomer.DoubleClick
        Try
            BtnNew_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'Private Sub DGLocal_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGLocal.CellContentClick
    '    Try
    '        If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
    '            Process.Start(DGLocal.SelectedRows(0).Cells(3).Value.ToString)
    '        ElseIf e.ColumnIndex = 1 And e.RowIndex >= 0 Then
    '            Dim cr As New CopyResource
    '            cr.TxtCopyFrom.Text = DGLocal.SelectedRows(0).Cells(3).Value.ToString
    '            cr.ChkCopyLocalShare.Checked = False
    '            cr.ShowDialog()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try

    'End Sub

    'Private Sub DGRemote_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGRemote.CellContentClick
    '    Try
    '        If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
    '            Process.Start(DGRemote.SelectedRows(0).Cells(3).Value.ToString)
    '        ElseIf e.ColumnIndex = 1 And e.RowIndex >= 0 Then
    '            Dim cr As New CopyResource
    '            cr.TxtCopyFrom.Text = DGRemote.SelectedRows(0).Cells(3).Value.ToString
    '            cr.ChkCopyDSDB.Checked = False
    '            cr.ShowDialog()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    'Private Sub DGFTP_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGFTP.CellContentClick
    '    Try
    '        If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
    '            Process.Start(DGFTP.SelectedRows(0).Cells(3).Value.ToString)
    '        ElseIf e.ColumnIndex = 1 And e.RowIndex >= 0 Then
    '            Dim cr As New CopyResource
    '            cr.TxtCopyFrom.Text = DGFTP.SelectedRows(0).Cells(3).Value.ToString
    '            'cr.ChkCopyLocalShare.Checked = False
    '            cr.ShowDialog()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    'Private Sub DGCF_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCF.CellContentClick
    '    Try
    '        If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
    '            Process.Start(DGCF.SelectedRows(0).Cells(3).Value.ToString)
    '        ElseIf e.ColumnIndex = 1 And e.RowIndex >= 0 Then
    '            Dim cr As New CopyResource
    '            cr.TxtCopyFrom.Text = DGCF.SelectedRows(0).Cells(3).Value.ToString
    '            'cr.ChkCopyLocalShare.Checked = False
    '            cr.ShowDialog()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    Friend Sub EventDragDrop(ByVal e As System.Windows.Forms.DragEventArgs, ByVal Wheretocopy As Integer) '1=local,2=remote,3=cf,4=all
        Dim f As String()
        Try

            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                f = e.Data.GetData(DataFormats.FileDrop)

                If common.IsCaseNo(Common.CaseNo.Trim) = False Then
                    MsgBox("Please specify a valid case no.", MsgBoxStyle.Information)
                    Exit Sub
                Else
                    For i = 0 To f.GetUpperBound(0)
                        Dim cr As New CopyResource
                        cr.TxtCopyFrom.Text = f(i)
                        If Wheretocopy = 1 Then
                            cr.ChkCopyDSDB.Checked = False
                            'cr.ChkCopyCF.Checked = False
                            cr.ChkCopyLocalShare.Checked = True
                        ElseIf Wheretocopy = 2 Then
                            cr.ChkCopyDSDB.Checked = True
                            cr.ChkCopyLocalShare.Checked = False
                            'cr.ChkCopyCF.Checked = False
                        ElseIf Wheretocopy = 3 Then
                            cr.ChkCopyDSDB.Checked = False
                            cr.ChkCopyLocalShare.Checked = False
                            'cr.ChkCopyCF.Checked = True
                        ElseIf Wheretocopy = 4 Then
                            cr.ChkCopyDSDB.Checked = True
                            cr.ChkCopyLocalShare.Checked = True
                            'cr.ChkCopyCF.Checked = True
                        End If

                        cr.ShowDialog()
                    Next
                End If

                '------Writing log ------------------
                Common.ExtraDataToLog = "Draged and dropped to copy with option " & Wheretocopy
                Dim WL As New Threading.Thread(AddressOf common.WriteLog)
                WL.Start()
                '------------------------------------

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Friend Sub EventDragEnter(ByVal e As System.Windows.Forms.DragEventArgs)
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.All
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DGRemote_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DGRemote.DragDrop
        EventDragDrop(e, 2)
    End Sub

    Private Sub DGRemote_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DGRemote.DragEnter
        EventDragEnter(e)
    End Sub

    Private Sub DGLocal_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DGLocal.DragDrop
        EventDragDrop(e, 1)
    End Sub

    Private Sub DGLocal_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DGLocal.DragEnter
        EventDragEnter(e)
    End Sub

    Private Sub DGCF_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        EventDragDrop(e, 3)
    End Sub

    Private Sub DGCF_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        EventDragEnter(e)
    End Sub

    Private Sub AlertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlertToolStripMenuItem.Click
        BtnAlert_Click(sender, e)
    End Sub

    Private Sub OpenCaseDirectoryToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenCaseDirectoryToolStripMenuItem.Click
        BtnOpendir_Click(sender, e)
    End Sub

    Private Sub TimerStartStopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerStartStopToolStripMenuItem.Click
        BtnTimer_Click(sender, e)
    End Sub

    Private Sub DeleteCaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCaseToolStripMenuItem.Click
        BtnDeleteCase_Click(sender, e)
    End Sub

    Private Sub ShowHidePanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowHidePanelToolStripMenuItem.Click
        BtnHide_Click(sender, e)
    End Sub

    Private Sub MnuCloseactivebrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCloseactivebrowser.Click
        Try
            If TCMain.SelectedTab.Tag = "Closable" Then
                TCMain.SelectedTab.Dispose()
            Else
                MsgBox("This tab cannot be closed.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'Private Sub TC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TC.SelectedIndexChanged
    '    Try
    '        'Dim t As New Threading.Thread(AddressOf ExtractCaseInfoIntoConfigFile)
    '        't.Start()

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    'Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    'ExtractCaseInfoIntoConfigFile()
    'End Sub

    'Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
    '    MsgBox(common.GetCaseAttribute("Email", common.CaseNo))
    '    MsgBox(common.GetCaseAttribute("Problem", common.CaseNo))
    '    MsgBox(common.GetCaseAttribute("Environment", common.CaseNo))
    'End Sub


    Private Sub FeedbackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeedbackToolStripMenuItem.Click
        Try
            common.SendFeedback()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnMSSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMSSolve.Click
        Try
            '------Writing log ------------------
            Common.ExtraDataToLog = "Open Servicedesk for case no - " & lblCaseno.Text.Trim
            Dim WL As New Threading.Thread(AddressOf common.WriteLog)
            WL.Start()
            '------------------------------------

            'Process.Start("https://servicedesk.microsoft.com/#/customer/cases?caseNumber=" & lblCaseno.Text.Trim)
            Process.Start("https://onesupport.crm.dynamics.com/main.aspx?appid=101acb62-8d00-eb11-a813-000d3a8b3117&pagetype=search&searchText=" & lblCaseno.Text.Trim)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnAlert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlert.Click
        Try
            If common.IsCaseNo(Common.CaseNo.Trim) = False Then
                Dim Alert As New Alert
                Alert.ShowDialog()
            Else
                Dim Alert As New Alert
                Alert.TxtCaseno.Text = Common.CaseNo
                Alert.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DGAlert_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGAlert.CellContentClick
        Try

            If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
                If MsgBox("Are you sure you want to delete this alert parmanently?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '------Writing log ------------------
                    Dim l As String = "Reminder removed - " & DGAlert.SelectedRows(0).ToString
                    l = l.Replace(vbCrLf, " ")
                    Common.ExtraDataToLog = l
                    Dim WL As New Threading.Thread(AddressOf common.WriteLog)
                    WL.Start()
                    '------------------------------------
                    DSAlert.Tables(0).Rows.RemoveAt(DGAlert.SelectedRows(0).Index)
                    DSAlert.WriteXml("Alerts.config")
                End If
            End If




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DGAlert_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGAlert.CellContentDoubleClick
        Try
            Common.OverRideCaseNo = DGAlert.SelectedRows(0).Cells(1).Value  'DSAlert.Tables(0).Rows(DGAlert.SelectedRows(0).Index).Item(0).ToString
            BtnNew_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub DGAlert_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGAlert.CellFormatting
        Try
            If e.Value = "High" Then
                e.CellStyle.BackColor = Color.Red
            ElseIf e.Value = "Medium" Then
                e.CellStyle.BackColor = Color.Yellow
            ElseIf e.Value = "Low" Then
                e.CellStyle.BackColor = Color.Green
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub DGAlert_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DGAlert.RowsAdded
        Try
            If DGAlert.RowCount > 0 Then
                TC1.TabPages(1).Text = "     (" & DGAlert.RowCount & ") Reminder(s)"
            Else
                TC1.TabPages(1).Text = "(" & DGAlert.RowCount & ") Reminder(s)"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DGAlert_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGAlert.RowsRemoved
        Try
            If DGAlert.RowCount > 0 Then
                TC1.TabPages(1).Text = "     (" & DGAlert.RowCount & ") Reminder(s)"
            Else
                TC1.TabPages(1).Text = "(" & DGAlert.RowCount & ") Reminder(s)"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub BtnTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTimer.Click
        Try
            TimerTabTime.Enabled = Not TimerTabTime.Enabled
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'Private Sub SplitContainer1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer1.DoubleClick
    '    Try
    '        If SplitContainer1.SplitterDistance <= 2 Then
    '            SplitContainer1.SplitterDistance = LastSpliterDistance
    '        ElseIf SplitContainer1.SplitterDistance >= 2 Then
    '            SplitContainer1.SplitterDistance = 2
    '        End If


    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try

    'End Sub


    'Private Sub SplitContainer1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer1.MouseMove
    '    Try
    '        If SplitContainer1.SplitterDistance < 5 Then
    '            SplitContainer1.SplitterDistance = LastSpliterDistance

    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub


    'Private Sub PicHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicHide.Click
    '    Try
    '        If SplitContainer1.SplitterDistance >= 2 Then
    '            LastSpliterDistance = SplitContainer1.SplitterDistance
    '            SplitContainer1.SplitterDistance = 1
    '        Else
    '            SplitContainer1.SplitterDistance = LastSpliterDistance
    '            LastSpliterDistance = SplitContainer1.SplitterDistance
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub




    Private Sub BtnDeleteCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteCase.Click
        Try
            If common.IsCaseNo(Common.CaseNo.Trim) = False Then
                MsgBox("Please specify a valid case no.", MsgBoxStyle.Information)
                Exit Sub
            Else
                Dim DC As New DeleteCase
                DC.Show()

                '------Writing log ------------------
                Common.ExtraDataToLog = "Case Resources deleted - " & Common.CaseNo
                Dim WL As New Threading.Thread(AddressOf common.WriteLog)
                WL.Start()
                '------------------------------------
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Chkwordwrap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkwordwrap.CheckedChanged
        Try
            Dim tp As TabPage
            For Each tp In TC.TabPages
                If Chkwordwrap.Checked = True Then
                    CType(tp.Controls(0), RichTextBox).WordWrap = True
                    CType(tp.Controls(0), RichTextBox).ScrollBars = RichTextBoxScrollBars.Vertical
                ElseIf Chkwordwrap.Checked = False Then
                    CType(tp.Controls(0), RichTextBox).WordWrap = False
                    CType(tp.Controls(0), RichTextBox).ScrollBars = RichTextBoxScrollBars.Both
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnOpenSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpenSelected.Click
        Try
            Dim p As String
            p = CType(TBFile.SelectedTab.Controls(3), DataGridView).SelectedRows(0).Cells(1).Value.ToString
            Process.Start(p)
        Catch ex As Exception
            If ex.Message.Trim.StartsWith("Index was out of range") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try
    End Sub

    Private Sub BtnCopyselected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopyselected.Click
        Try
            Dim p As String
            p = CType(TBFile.SelectedTab.Controls(3), DataGridView).SelectedRows(0).Cells(1).Value.ToString

            Dim cr As New CopyResource

            If CType(TBFile.SelectedTab.Controls(3), DataGridView).Name = "DGLocal" Then
                'cr.ChkCopyCF.Checked = True
                cr.ChkCopyDSDB.Checked = True
                cr.ChkCopyLocalShare.Checked = False
                cr.ChkCopyLocalShare.Enabled = False
            ElseIf CType(TBFile.SelectedTab.Controls(3), DataGridView).Name = "DGRemote" Then
                'cr.ChkCopyCF.Checked = True
                cr.ChkCopyDSDB.Checked = False
                cr.ChkCopyDSDB.Enabled = False
                cr.ChkCopyLocalShare.Checked = True
            ElseIf CType(TBFile.SelectedTab.Controls(3), DataGridView).Name = "DGCF" Then
                'cr.ChkCopyCF.Checked = False
                'cr.ChkCopyCF.Enabled = False
                cr.ChkCopyDSDB.Checked = True
                cr.ChkCopyLocalShare.Checked = True
            End If

            'cr.ChkCopyCF.Checked = False
            cr.TxtCopyFrom.Text = p
            cr.ShowDialog()
        Catch ex As Exception
            If ex.Message.Trim.StartsWith("Index was out of range") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub

    Private Sub BtnDeleteselected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteselected.Click
        Try

            Dim p As String
            p = CType(TBFile.SelectedTab.Controls(3), DataGridView).SelectedRows(0).Cells(0).Value.ToString

            If MsgBox("Are you sure you want to delete """ & p & """ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

                'for progress bar==================
                If TBFile.SelectedTab.Name = "TPTeam" Then
                    Common.PBPS = True
                ElseIf TBFile.SelectedTab.Name = "TPLocal" Then
                    Common.PBLS = True
                ElseIf TBFile.SelectedTab.Name = "TPCF" Then
                    Common.PBCF = True
                End If
                '======================================

                File.Delete(CType(TBFile.SelectedTab.Controls(3), DataGridView).SelectedRows(0).Cells(1).Value.ToString)
                Common.CollectFileList = True
            End If
        Catch ex As Exception
            If ex.Message.Trim.StartsWith("Index was out of range") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub


    Private Sub BtnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHide.Click
        Try
            If SplitContainer1.SplitterDistance >= 2 Then
                LastSpliterDistance = SplitContainer1.SplitterDistance
                SplitContainer1.SplitterDistance = 1
                BtnHide.BackgroundImage = My.Resources.Resources.Show
            Else
                SplitContainer1.SplitterDistance = LastSpliterDistance
                LastSpliterDistance = SplitContainer1.SplitterDistance
                BtnHide.BackgroundImage = My.Resources.Resources.Hide
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub



    Private Sub CopyContentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyContentToolStripMenuItem.Click
        Try
            If TV.SelectedNode.Text.EndsWith("<External>") Then
                ' pth = common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text
                'pth = pth.Substring(0, pth.LastIndexOf("<External>")) & ".msg"
                MsgBox("Cannot copy external file from here. Double-Click to open it and then copy the content manually.", MsgBoxStyle.Information)
                Exit Sub
            End If

            If TV.SelectedNode.Level = 1 Then
                My.Computer.Clipboard.SetData(System.Windows.Forms.DataFormats.Text, File.ReadAllText(Common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text & ".txt")) 'CType(TC.SelectedTab.Controls(0), RichTextBox).Rtf)
            Else
                MsgBox("Please select a template to Copy.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            ' If ex.Message <> "Object reference not set to an instance of an object." Then
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            ' End If
        End Try
    End Sub

    Private Sub MailContentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailContentToolStripMenuItem.Click
        Try
            If TV.SelectedNode.Level = 1 Then

                Dim pth As String ' added for .eml date 18th march 2014
                If TV.SelectedNode.Text.EndsWith("<External>") Then
                    pth = Common.TemplateRoot & "\" & TV.SelectedNode.Parent.Name.ToString & "\" & TV.SelectedNode.Text
                    pth = pth.Substring(0, pth.LastIndexOf("<External>")) & ".msg"
                    Process.Start(pth)
                    Exit Sub
                End If

                TV_DoubleClick(sender, e)
                Threading.Thread.Sleep(1000)
                OpenMail()



                Try
                    File.Delete(Common.NotesRoot & "\" & Common.CaseNo & "\" & "AllNotes" & "\" & TC.SelectedTab.Tag & ".txt")

                Catch ex As Exception
                    If ex.Message.ToString.StartsWith("Could not find a part of the path") = False And ex.Message.ToString.StartsWith("Object reference not set to an instance of an object") = False Then
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End If
                End Try

                TC.SelectedTab.Dispose()

            Else
                MsgBox("Please select a template to mail.", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            ' If ex.Message <> "Object reference not set to an instance of an object." Then
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            ' End If
        End Try
    End Sub


    Private Sub TV_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TV.MouseDown
        Try
            TV.SelectedNode = TV.GetNodeAt(e.Location)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TC_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TC.MouseDown
        Try
            If e.Button = MouseButtons.Right Then
                For i = 0 To TC.TabCount - 1
                    Dim r As Rectangle = TC.GetTabRect(i)
                    If r.Contains(e.Location) Then
                        TC.SelectedIndex = i
                    End If

                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub



    'Private Sub BtnOpenCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Try
    '    '    Cursor.Current = Cursors.WaitCursor
    '    '    If common.IsCaseNo(Common.CaseNo.Trim) = True Then
    '    '        If LblCF.Text.Trim <> "" Then
    '    '            Process.Start(LblCF.Text.Trim)
    '    '        End If

    '    '    End If
    '    '    Cursor.Current = Cursors.Default
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    'Finally
    '    '    Cursor.Current = Cursors.Default
    '    'End Try
    'End Sub


    Private Sub ManageCaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageCaseToolStripMenuItem.Click
        BtnOpenNotes_Click(sender, e)
    End Sub

  
    Private Sub BtnCopyNotes_Click(sender As Object, e As EventArgs) Handles BtnCopyNotes.Click

        Try
            My.Computer.Clipboard.SetData(System.Windows.Forms.DataFormats.Text, CType(TC.SelectedTab.Controls(0), RichTextBox).Text)
        Catch ex As Exception
            If ex.Message.StartsWith("Object") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try
    End Sub
End Class
