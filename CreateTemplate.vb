Imports System.IO
Public Class CreateTemplate

    Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click
        Try
            If CBGroup.Text.Length < 1 Then
                MsgBox("Please select a template group.", MsgBoxStyle.Information)
                Exit Sub
            End If

            If Txttemplatename.Text.Trim = "" Then
                MsgBox("Please enter a template name.", MsgBoxStyle.Information)
                Exit Sub
            End If

            If CType(Form1.TC.SelectedTab.Controls(0), RichTextBox).Text.Trim = "" Then
                MsgBox("Please create a template in the main window and then save it.", MsgBoxStyle.Information)
                Exit Sub
            End If

            If Txttemplatename.Text.IndexOf(".") <> -1 Then
                MsgBox("Please remove the . from the template name.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If My.Computer.FileSystem.DirectoryExists(Common.TemplateRoot) = False Then
                My.Computer.FileSystem.CreateDirectory(Common.TemplateRoot)
            End If

            If My.Computer.FileSystem.DirectoryExists(Common.TemplateRoot & "\" & CBGroup.Text.Trim) = False Then
                If MsgBox("Are you sure you want to create a new group for this template?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.CreateDirectory(Common.TemplateRoot & "\" & CBGroup.Text.Trim)

                    'My.Computer.FileSystem.WriteAllText(Common.TemplateRoot & "\" & CBGroup.Text.Trim & "\" & Txttemplatename.Text & ".txt", CType(Form1.TC.SelectedTab.Controls(0), RichTextBox).Text.Trim, True)
                    CType(Form1.TC.SelectedTab.Controls(0), RichTextBox).SaveFile(Common.TemplateRoot & "\" & CBGroup.Text.Trim & "\" & Txttemplatename.Text & ".txt", RichTextBoxStreamType.PlainText)
                    MsgBox("Template created successfully.", MsgBoxStyle.Information)
                    Form1.Btnrefresh_Click(sender, e)
                    Me.Dispose()

                End If

            Else
                'My.Computer.FileSystem.WriteAllText(Common.TemplateRoot & "\" & CBGroup.Text.Trim & "\" & Txttemplatename.Text & ".txt", CType(Form1.TC.SelectedTab.Controls(0), RichTextBox).Text.Trim, True)
                CType(Form1.TC.SelectedTab.Controls(0), RichTextBox).SaveFile(Common.TemplateRoot & "\" & CBGroup.Text.Trim & "\" & Txttemplatename.Text & ".txt", RichTextBoxStreamType.PlainText)
                MsgBox("Template created successfully.", MsgBoxStyle.Information)
                Form1.Btnrefresh_Click(sender, e)
                Me.Dispose()
            End If

            
        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Else
                MsgBox("Please create a template in the main window and then save it.", MsgBoxStyle.Information)
            End If
        End Try
    End Sub

    Private Sub CreateTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim dr As DirectoryInfo
            Dim DrToScan As New DirectoryInfo(Common.TemplateRoot)
            CBGroup.Items.Clear()
            If My.Computer.FileSystem.DirectoryExists(Common.TemplateRoot) Then
                For Each dr In DrToScan.GetDirectories
                    CBGroup.Items.Add(dr.Name)
                Next
                If CBGroup.Items.Count > 0 Then CBGroup.SelectedItem = CBGroup.Items(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class