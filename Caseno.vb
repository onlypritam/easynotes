Imports System.Windows.Forms
Imports System.IO

Public Class Caseno
    Dim common As New Common


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If common.IsCaseNo(TxtCaseno.Text.Trim) = True Then

            If String.IsNullOrWhiteSpace(TxtCname.Text) Then
                MsgBox("Please enter a valid customer name.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Me.Visible = False

            If ChkDonotLoadNotes.Checked = True Then
                Common.DonotLoadPreviousNotes = True
            Else
                Common.DonotLoadPreviousNotes = False
            End If

            Common.CaseNo = TxtCaseno.Text.Trim
            Common.CustomerName = TxtCname.Text.Trim
            If TxtCname.Text.Trim.Length > 0 Then
                If TxtCname.Text.Trim.IndexOf(" ") = -1 Then
                    Common.CustomerFName = TxtCname.Text.Trim
                    Common.CustomerLName = ""
                Else
                    Common.CustomerFName = TxtCname.Text.Trim.Substring(0, TxtCname.Text.Trim.IndexOf(" ")).Trim
                    Common.CustomerLName = TxtCname.Text.Trim.Substring(TxtCname.Text.Trim.IndexOf(" "), TxtCname.Text.Trim.Length - TxtCname.Text.Trim.IndexOf(" ")).Trim
                End If
            End If
            Form1.LblCustomer.Text = Common.CustomerName
            Form1.lblCaseno.Text = Common.CaseNo
            Form1.Text = "Easy Notes v " & Common.Version & " [" & Common.CustomerName & "] , [" & Common.CaseNo & "]"
            'Form1.BtnReset_Click(sender, e)
            Form1.SW.Reset()
            Form1.SW.Start()
            Form1.TimeElapsedAfterLastSave = 0
            Dim t As New Threading.Thread(AddressOf Form1.AsyncGetFiles)
            t.Start()
            Me.Close()
        Else
            MsgBox("Please enter a valid case no.", MsgBoxStyle.Exclamation)
        End If

    End Sub


    Private Sub Caseno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            If common.OverRideCaseNo.Trim = "" Then
                TxtCaseno.Text = common.GetCaseInfo(1) '"SRX" & System.DateTime.Today.Year.ToString.Substring(2, 2) & IIf(System.DateTime.Today.Month < 10, "0" & System.DateTime.Today.Month.ToString, System.DateTime.Today.Month.ToString) & IIf(System.DateTime.Today.Day < 10, "0" & System.DateTime.Today.Day.ToString, System.DateTime.Today.Day.ToString)
                If TxtCaseno.Text.StartsWith("SR") = False Then TxtCname.Text = common.GetCaseInfo(2)
            Else
                TxtCaseno.Text = common.OverRideCaseNo
                common.OverRideCaseNo = ""
            End If
            

            If TxtCaseno.Text.Trim = "" Then
                Me.Height = 220
                lblerr.Text = "Unable  to  get  any  case  information. If your MSSolve or Clarify case" & vbCrLf & "window is already open,  please click cancel, make the case window" & vbCrLf & "active by clicking on it and try again."
            End If

            '=============For Case List=================
            CmbCases.Items.Clear()
            Dim dr As DirectoryInfo
            Dim dri As New DirectoryInfo(common.NotesRoot)

            'If TxtCname.Text.Trim = "" Then

            For Each dr In dri.GetDirectories
                If common.IsCaseNo(dr.Name) = True Then
                    If dr.LastAccessTime > DateAdd(DateInterval.Day, (0 - (common.RecentDays)), Now) Then
                        'If My.Computer.FileSystem.FileExists(common.NotesRoot & "\" & dr.Name & "\Info.txt") Then
                        If common.GetCaseAttribute("CustomerName", dr.Name).Trim <> "" Then
                            CmbCases.Items.Add(dr.Name & " - " & common.GetCaseAttribute("CustomerName", dr.Name))
                        Else
                            CmbCases.Items.Add(dr.Name)
                        End If
                    End If
                End If
            Next

            'ElseIf TxtCname.Text.Trim <> "" Then

            '    For Each dr In dri.GetDirectories
            '        If common.IsCaseNo(dr.Name) = True Then
            '            ' If dr.LastAccessTime > DateAdd(DateInterval.Day, (0 - (common.RecentDays)), Now) Then
            '            'If My.Computer.FileSystem.FileExists(common.NotesRoot & "\" & dr.Name & "\Info.txt") Then
            '            If common.GetCaseAttribute("CustomerName", dr.Name).Trim.Contains(TxtCname.Text.Trim) Then
            '                CmbCases.Items.Add(dr.Name & " - " & common.GetCaseAttribute("CustomerName", dr.Name))
            '                'Else
            '                '    CmbCases.Items.Add(dr.Name)
            '            End If
            '            'End If
            '        End If
            '    Next

            'End If



            '=====================================
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub


    Private Sub TxtCaseno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCaseno.TextChanged
        Try
            If common.IsCaseNo(TxtCaseno.Text.Trim) Then
                'TxtCaseno.ForeColor = Color.Green
                PBR.Visible = False
                PBG.Visible = True
                'If My.Computer.FileSystem.FileExists(common.NotesRoot & "\" & TxtCaseno.Text.Trim & "\Info.txt") Then
                TxtCname.Text = common.GetCaseAttribute("CustomerName", TxtCaseno.Text.Trim)
                'End If
                Me.Height = 180
                lblerr.Text = " "
            Else
                'TxtCaseno.ForeColor = Color.Black
                PBR.Visible = True
                PBG.Visible = False
                TxtCname.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CmbCases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCases.SelectedIndexChanged
        Try

            If CmbCases.SelectedItem.ToString.IndexOf("-") = -1 Then
                TxtCaseno.Text = CmbCases.SelectedItem.ToString.Trim
                TxtCname.Text = ""
            Else
                TxtCaseno.Text = CmbCases.SelectedItem.ToString.Substring(0, CmbCases.SelectedItem.ToString.IndexOf("-")).Trim
                TxtCname.Text = CmbCases.SelectedItem.ToString.Substring(CmbCases.SelectedItem.ToString.IndexOf("-") + 1, CmbCases.SelectedItem.ToString.Length - (CmbCases.SelectedItem.ToString.IndexOf("-") + 1)).Trim

            End If

            Me.Height = 180
            lblerr.Text = " "

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnSearchCases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchCases.Click
        Try
            CmbCases.Items.Clear()
            Dim dr As DirectoryInfo
            Dim dri As New DirectoryInfo(common.NotesRoot)


            If TxtCname.Text.Trim = "" Then

                For Each dr In dri.GetDirectories
                    If common.IsCaseNo(dr.Name) = True Then
                        If dr.LastAccessTime > DateAdd(DateInterval.Day, (0 - (common.RecentDays)), Now) Then
                            'If My.Computer.FileSystem.FileExists(common.NotesRoot & "\" & dr.Name & "\Info.txt") Then
                            If common.GetCaseAttribute("CustomerName", dr.Name).Trim <> "" Then
                                CmbCases.Items.Add(dr.Name & " - " & common.GetCaseAttribute("CustomerName", dr.Name))
                            Else
                                CmbCases.Items.Add(dr.Name)
                            End If
                        End If
                    End If
                Next

            ElseIf TxtCname.Text.Trim <> "" Then

                For Each dr In dri.GetDirectories
                    If common.IsCaseNo(dr.Name) = True Then
                        ' If dr.LastAccessTime > DateAdd(DateInterval.Day, (0 - (common.RecentDays)), Now) Then
                        'If My.Computer.FileSystem.FileExists(common.NotesRoot & "\" & dr.Name & "\Info.txt") Then
                        If common.GetCaseAttribute("CustomerName", dr.Name).Trim.ToLower.Contains(TxtCname.Text.Trim.ToLower) Then
                            CmbCases.Items.Add(dr.Name & " - " & common.GetCaseAttribute("CustomerName", dr.Name))
                            'Else
                            '    CmbCases.Items.Add(dr.Name)
                        End If
                        'End If
                    End If
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TxtCname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCname.TextChanged
        Try
            If TxtCname.Text.Trim = "" Then
                BtnSearchCases_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class
