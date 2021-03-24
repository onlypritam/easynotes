Imports System.IO
Public Class CopyResource

    Dim FLName As String = "noname"
    Dim common As New Common
    Dim DateDirectory As String = "\" & Format(Now(), "ddMMMMMMMMMyyyy")

    Private Sub BtnCopyFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopyFrom.Click
        Try
            OFD.FileName = ""
            OFD.ShowDialog()

            If OFD.FileName.Trim <> "" Then
                TxtCopyFrom.Text = OFD.FileName
                ' FLName = My.Computer.FileSystem.GetName(TxtCopyFrom.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopy.Click

        Try
            Cursor.Current = Cursors.WaitCursor
            BtnCopy.Enabled = False
            FLName = My.Computer.FileSystem.GetName(TxtCopyFrom.Text)

            If common.IsCaseNo(common.CaseNo.Trim) = False Then
                MsgBox("Please specify a valid case no.", MsgBoxStyle.Information)
                Exit Sub
            Else
                If My.Computer.FileSystem.FileExists(TxtCopyFrom.Text.Trim) = False Then
                    MsgBox("The file or directory to copy from , doesn't exists.", MsgBoxStyle.Critical)
                Else
                    Dim t As New Threading.Thread(AddressOf DoCopy)
                    t.Start()
                    'MsgBox("Copying has started in the background." & vbCrLf & "You will get a message on completion.", MsgBoxStyle.Information)
                    Me.Hide()

                    ''DoCopy()
                End If

            End If
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MsgBox("Error while copying file " & FLName & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub DoCopy()
        Dim S As String = ""
        Try

            '===========for copy progress bar
            If ChkCopyDSDB.Checked = True Then
                common.PBPS = True
            End If
            If ChkCopyLocalShare.Checked = True Then
                common.PBLS = True
            End If
            'If ChkCopyCF.Checked = True Then
            '    common.PBCF = True
            'End If
            'If ChkCopyOtherLocation.Checked = True Then
            '    common.PBFTP = True
            'End If
            '===============================




            If ChkCopyDSDB.Checked = True Then

                If My.Computer.FileSystem.DirectoryExists(TxtDSDBPath.Text.Trim) = True Then
                    My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtDSDBPath.Text.Trim & "\" & FLName, True)
                Else
                    My.Computer.FileSystem.CreateDirectory(TxtDSDBPath.Text.Trim)
                    My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtDSDBPath.Text.Trim & "\" & FLName, True)
                End If

                S = TxtDSDBPath.Text.Trim & vbCrLf & vbCrLf

            End If

            If ChkCopyLocalShare.Checked = True Then
                If My.Computer.FileSystem.DirectoryExists(TxtLocalPath.Text.Trim) = True Then
                    My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtLocalPath.Text.Trim & "\" & FLName, True)
                Else
                    My.Computer.FileSystem.CreateDirectory(TxtLocalPath.Text.Trim)
                    My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtLocalPath.Text.Trim & "\" & FLName, True)
                End If

                S = S & TxtLocalPath.Text.Trim & vbCrLf & vbCrLf

            End If

            'If ChkCopyCF.Checked = True Then
            '    If My.Computer.FileSystem.DirectoryExists(TxtCFPath.Text.Trim) = True Then
            '        My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtCFPath.Text.Trim & "\" & FLName, True)
            '    Else
            '        'MsgBox("The customer file location does not exists, Please create it through the 'Customer Files' section in MSSolve and try again.", MsgBoxStyle.Exclamation)
            '        My.Computer.FileSystem.CreateDirectory(TxtCFPath.Text.Trim)
            '        My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtCFPath.Text.Trim & "\" & FLName, True)
            '    End If

            '    S = S & TxtCFPath.Text.Trim & vbCrLf & vbCrLf

            'End If

            'If ChkCopyOtherLocation.Checked = True Then
            '    If My.Computer.FileSystem.DirectoryExists(TxtOtherPath.Text.Trim) = True Then
            '        My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtOtherPath.Text.Trim & "\" & FLName, True)
            '    Else
            '        My.Computer.FileSystem.CreateDirectory(TxtOtherPath.Text.Trim)
            '        My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtOtherPath.Text.Trim & "\" & FLName, True)
            '    End If
            '    S = S & TxtOtherPath.Text.Trim & vbCrLf

            'End If
            MsgBox("Copying the file """ & FLName & """ completed successfully to the following location." & vbCrLf & vbCrLf & S, MsgBoxStyle.Information)
            common.CollectFileList = True

            '------Writing log ------------------
            Try
                Dim l As String = "Files - " & FLName & " copied to following location - " & S
                l = l.Replace(vbCrLf, " ")
                common.ExtraDataToLog = l
                Dim WL As New Threading.Thread(AddressOf common.WriteLog)
                WL.Start()
            Catch ex As Exception

            End Try

            '------------------------------------
            ' Form1.AsyncGetFiles()

        Catch ex As Exception

            If ex.Message.Contains("Error creating window handle") Then
                MsgBox("Error creating file handle. This might happen while copying large file or copying file from remote location." & vbCrLf & "Try to copy again after about half a minute.", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while copying file " & FLName & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try
    End Sub

    'Private Sub DoCopyCMD()
    '    Dim S As String
    '    Try
    '        If ChkCopyDSDB.Checked = True Then

    '            If My.Computer.FileSystem.DirectoryExists(TxtDSDBPath.Text.Trim) = True Then
    '                My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtDSDBPath.Text.Trim & "\" & FLName, True)
    '            Else
    '                My.Computer.FileSystem.CreateDirectory(TxtDSDBPath.Text.Trim)
    '                My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtDSDBPath.Text.Trim & "\" & FLName, True)
    '            End If

    '            S = TxtDSDBPath.Text.Trim & " , " & vbCrLf
    '        End If

    '        If ChkCopyLocalShare.Checked = True Then
    '            If My.Computer.FileSystem.DirectoryExists(TxtLocalPath.Text.Trim) = True Then
    '                My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtLocalPath.Text.Trim & "\" & FLName, True)
    '            Else
    '                My.Computer.FileSystem.CreateDirectory(TxtLocalPath.Text.Trim)
    '                My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtLocalPath.Text.Trim & "\" & FLName, True)
    '            End If

    '            S = S & TxtLocalPath.Text.Trim & " , " & vbCrLf
    '        End If

    '        If ChkCopyOtherLocation.Checked = True Then
    '            If My.Computer.FileSystem.DirectoryExists(TxtOtherPath.Text.Trim) = True Then
    '                My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtOtherPath.Text.Trim & "\" & FLName, True)
    '            Else
    '                My.Computer.FileSystem.CreateDirectory(TxtOtherPath.Text.Trim)
    '                My.Computer.FileSystem.CopyFile(TxtCopyFrom.Text.Trim, TxtOtherPath.Text.Trim & "\" & FLName, True)
    '            End If
    '            S = S & TxtOtherPath.Text.Trim & " , " & vbCrLf
    '        End If
    '        MsgBox("Copying the file << " & FLName & " >> completed successfully to the following location." & vbCrLf & S, MsgBoxStyle.Information)


    '    Catch ex As Exception
    '        MsgBox("Error while copying file " & FLName & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    Private Sub BtnCopyTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ODD.ShowDialog()
            'TxtOtherPath.Text = ODD.SelectedPath
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CopyResource_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TxtDSDBPath.Text = Common.DSDBshare & "\" & Common.CaseNo & DateDirectory
            TxtLocalPath.Text = Common.NotesRoot & "\" & Common.CaseNo & DateDirectory

            'If common.IsMSSolveCase = True Then
            '    'TxtCFPath.Enabled = True
            '    'ChkCopyCF.Enabled = True
            '    'ChkDateCF.Enabled = True

            '    'If Form1.LblCF.Text.Trim = "" Then
            '    '    TxtCFPath.Text = ""
            '    '    TxtCFPath.Enabled = False
            '    '    ChkCopyCF.Checked = False
            '    '    ChkCopyCF.Enabled = False
            '    'Else
            '    '    TxtCFPath.Text = Form1.LblCF.Text.Trim & DateDirectory
            '    '    TxtCFPath.Enabled = True
            '    '    'ChkCopyCF.Checked = True
            '    '    'ChkCopyCF.Enabled = True
            '    'End If
            'Else
            '    TxtCFPath.Enabled = False
            '    ChkCopyCF.Checked = False
            '    ChkCopyCF.Enabled = False
            '    ChkDateCF.Enabled = False
            '    TxtCFPath.Text = ""
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TxtCopyFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCopyFrom.TextChanged
        If TxtCopyFrom.Text.Trim = "" Then
            BtnCopy.Enabled = False
        Else
            BtnCopy.Enabled = True
        End If

    End Sub

    'Private Sub TxtOtherPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TxtOtherPath.Text.Trim = "" Then
    '        ChkCopyOtherLocation.Enabled = False
    '        ChkCopyOtherLocation.Checked = False
    '    Else
    '        ChkCopyOtherLocation.Enabled = True
    '        ChkCopyOtherLocation.Checked = True
    '    End If

    'End Sub

    Private Sub ChkDateTS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkDateTS.Click
        Try
            If ChkDateTS.Checked = True Then
                TxtDSDBPath.Text = TxtDSDBPath.Text.Trim & DateDirectory
                'MsgBox(Format(Now, "ddMMMMMMMMMyyyy"))
            Else

                TxtDSDBPath.Text = TxtDSDBPath.Text.Replace(DateDirectory, "")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub



    Private Sub ChkDateLS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkDateLS.Click
        Try
            If ChkDateLS.Checked = True Then
                TxtLocalPath.Text = TxtLocalPath.Text.Trim & DateDirectory
                'MsgBox(Format(Now, "ddMMMMMMMMMyyyy"))
            Else

                TxtLocalPath.Text = TxtLocalPath.Text.Replace(DateDirectory, "")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    ''Private Sub ChkDateCF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    Try
    ''        If ChkDateCF.Checked = True Then
    ''            TxtCFPath.Text = TxtCFPath.Text.Trim & DateDirectory
    ''            'MsgBox(Format(Now, "ddMMMMMMMMMyyyy"))
    ''        Else

    ''            TxtCFPath.Text = TxtCFPath.Text.Replace(DateDirectory, "")

    ''        End If

    ''    Catch ex As Exception
    ''        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    ''    End Try
    ''End Sub
End Class