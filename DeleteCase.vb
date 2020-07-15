Imports System.IO

Public Class DeleteCase

    Dim common As New Common

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Form1.Timer1.Enabled = False
            Form1.TimerTabTime.Enabled = False

            Dim tp As TabPage
            For Each tp In Form1.TC.TabPages
                tp.Dispose()
            Next
            Form1.ForceShutDoNotSaveChanges = True
            Threading.Thread.Sleep(1000)

            If MsgBox("Are you sure you want to parmanently delete the selected resources?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.SystemModal) = MsgBoxResult.Yes Then
                '------------deleting only case notes--------------------
                Try
                    If ChkLocalNts.Checked = True Then
                        If Directory.Exists(common.NotesRoot & "\" & common.CaseNo & "\" & "AllNotes") Then
                            Directory.Delete(common.NotesRoot & "\" & common.CaseNo & "\" & "AllNotes", True)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

                '------------deleting Local case resources--------------------
                Try

                    If ChkLocalres.Checked = True Then
                        Dim Dr As String
                        For Each Dr In Directory.GetDirectories(common.NotesRoot & "\" & common.CaseNo)
                            If Dr <> common.NotesRoot & "\" & common.CaseNo & "\AllNotes" Then
                                Directory.Delete(Dr, True)
                            End If
                        Next
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
                '------------deleting Local case folder--------------------
                Try
                    If ChkLocalres.Checked = True And ChkLocalNts.Checked = True Then
                        If Directory.Exists(common.NotesRoot & "\" & common.CaseNo) Then
                            Directory.Delete(common.NotesRoot & "\" & common.CaseNo, True)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

                If ChkPublic.Checked = True Or ChkCF.Checked = True Then
                    If MsgBox("Are you sure you want to delete shared resources." & vbCrLf & vbCrLf & "If you click on 'Yes' the shared resources will be deleted and no other engineer will be able to access them." & vbCrLf & vbCrLf & "If you click on 'Cancel', only local resource will be deleted.", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel + MsgBoxStyle.SystemModal) = MsgBoxResult.Ok Then
                        '------------deleting DSDB case folder--------------------
                        Try
                            If ChkPublic.Checked = True Then
                                If Directory.Exists(common.DSDBshare & "\" & common.CaseNo) Then
                                    Directory.Delete(common.DSDBshare & "\" & common.CaseNo, True)
                                End If
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                        End Try
                        '------------deleting MSSolve customer file case folder--------------------
                        Try
                            If ChkCF.Checked = True Then
                                Dim s As String = Form1.LblFTP.Text.Trim 'common.getCustomerFilePath
                                If s.Trim <> "" Then
                                    If Directory.Exists(s) Then
                                        Directory.Delete(s, True)
                                    End If
                                End If
                                
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                        End Try
                    End If
                End If

                MsgBox("All selected resources successfully deleted.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information + MsgBoxStyle.SystemModal)
                Application.Exit()
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Dispose()
    End Sub

End Class