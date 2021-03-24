Imports System.Drawing.Text

Public Class Settings

    Private Sub BtnNotesroot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotesroot.Click
        Try
            FBD.ShowDialog()
            TxtNotesroot.Text = FBD.SelectedPath
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnTemplateroot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTemplateroot.Click
        Try
            FBD.ShowDialog()
            TxtTemplateroot.Text = FBD.SelectedPath
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub BtnAltTemplateRoot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAltTemplateRoot.Click
        Try
            FBD.ShowDialog()
            TxtAltTemplateroot.Text = FBD.SelectedPath
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnDSDBshare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDSDBshare.Click
        Try
            FBD.ShowDialog()
            TxtDSDBshare.Text = FBD.SelectedPath
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim common As New Common

        Try
            BtnSave.Text = "Wait..."
            PB.Visible = True
            Application.DoEvents()


            PB.Value = 10
            If Not IsNumeric(TxtRecentCase.Text.Trim) Then
                MsgBox("Please enter a numeric value for recent case history.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            PB.Value = 20
            If TxtBullet.Text.Trim = "" Then
                MsgBox("Please enter a default bullet.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            PB.Value = 30
            If My.Computer.FileSystem.DirectoryExists(TxtNotesroot.Text.Trim) = False Then
                If MsgBox("The path '" & TxtNotesroot.Text.Trim & "' does not exists. Would you like to create it?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.CreateDirectory(TxtNotesroot.Text.Trim)
                Else
                    Exit Sub
                End If
            End If

            PB.Value = 50
            If My.Computer.FileSystem.DirectoryExists(TxtTemplateroot.Text.Trim) = False And TxtTemplateroot.Text.Trim <> "" Then
                If MsgBox("The path '" & TxtTemplateroot.Text.Trim & "' does not exists. Would you like to create it?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.CreateDirectory(TxtTemplateroot.Text.Trim)
                Else
                    Exit Sub
                End If
            End If

            PB.Value = 60
            If My.Computer.FileSystem.DirectoryExists(TxtAltTemplateroot.Text.Trim) = False And TxtAltTemplateroot.Text.Trim <> "" Then
                If MsgBox("The path '" & TxtAltTemplateroot.Text.Trim & "' does not exists. Would you like to create it?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.CreateDirectory(TxtAltTemplateroot.Text.Trim)
                Else
                    Exit Sub
                End If
            End If

            PB.Value = 70
            If TxtTemplateroot.Text.Trim = "" Then 'And TxtAltTemplateroot.Text.Trim = "" Then
                MsgBox("Please enter the template path.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If TxtTemplateroot.Text.Trim = TxtAltTemplateroot.Text.Trim Then
                MsgBox("Template and alternate template path should be different.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If


            PB.Value = 80
            If My.Computer.FileSystem.DirectoryExists(TxtDSDBshare.Text.Trim) = False Then
                If MsgBox("The path '" & TxtDSDBshare.Text.Trim & "' does not exists. Would you like to create it?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.CreateDirectory(TxtDSDBshare.Text.Trim)
                Else
                    Exit Sub
                End If
            End If

            PB.Value = 90
            If My.Computer.FileSystem.DirectoryExists(TxtDSDBshare.Text.Trim) = True And My.Computer.FileSystem.DirectoryExists(TxtNotesroot.Text.Trim) = True And (My.Computer.FileSystem.DirectoryExists(TxtTemplateroot.Text.Trim) = True Or My.Computer.FileSystem.DirectoryExists(TxtAltTemplateroot.Text.Trim) = True) And (My.Computer.FileSystem.DirectoryExists(TxtAltTemplateroot.Text.Trim) = True Or TxtAltTemplateroot.Text.Trim = "") Then
                Dim DS As New DataSet
                Dim DT As New DataTable("Easy Notes Settings")
                DT.Columns.Add("Data")
                DT.Columns.Add("Tag")
                DT.Columns.Add("category")

                Dim DR As DataRow = DT.NewRow
                DT.Rows.Add(DR) 'for notes root

                Dim DR1 As DataRow = DT.NewRow
                DT.Rows.Add(DR1) 'for template root

                Dim DR2 As DataRow = DT.NewRow
                DT.Rows.Add(DR2) 'for alt template root

                Dim DR3 As DataRow = DT.NewRow
                DT.Rows.Add(DR3) 'for dsdb share

                Dim DR4 As DataRow = DT.NewRow
                DT.Rows.Add(DR4) 'for bullet

                Dim DR5 As DataRow = DT.NewRow
                DT.Rows.Add(DR5) 'for bullet enabled or not

                Dim DR6 As DataRow = DT.NewRow
                DT.Rows.Add(DR6) 'for recent case days

                Dim DR7 As DataRow = DT.NewRow
                DT.Rows.Add(DR7) 'for font name

                Dim DR8 As DataRow = DT.NewRow
                DT.Rows.Add(DR8) 'for font color

                Dim DR9 As DataRow = DT.NewRow
                DT.Rows.Add(DR9) 'for back color

                Dim DR10 As DataRow = DT.NewRow
                DT.Rows.Add(DR10) 'for fornt size

                DT.Rows(0).Item(0) = TxtNotesroot.Text.Trim
                DT.Rows(0).Item(2) = "NotesRoot"

                DT.Rows(1).Item(0) = TxtTemplateroot.Text.Trim
                DT.Rows(1).Item(2) = "TemplateRoot"

                DT.Rows(2).Item(0) = TxtAltTemplateroot.Text.Trim
                DT.Rows(2).Item(2) = "AltTemplateRoot"

                DT.Rows(3).Item(0) = TxtDSDBshare.Text.Trim
                DT.Rows(3).Item(2) = "DSDBshare"

                DT.Rows(4).Item(0) = TxtBullet.Text
                DT.Rows(4).Item(2) = "Bullet"


                DT.Rows(5).Item(0) = IIf(ChkBulletEnabled.Checked, "Yes", "No")
                DT.Rows(5).Item(2) = "Bullet enabled?"


                DT.Rows(6).Item(0) = TxtRecentCase.Text.Trim
                DT.Rows(6).Item(2) = "Recent Case days"

                DT.Rows(7).Item(0) = CBFont.SelectedItem.ToString
                DT.Rows(7).Item(2) = "Font Name"

                DT.Rows(8).Item(0) = CBForeColor.SelectedItem.ToString
                DT.Rows(8).Item(2) = "Font Color"

                DT.Rows(9).Item(0) = CBBackcolor.SelectedItem.ToString
                DT.Rows(9).Item(2) = "Back Color"

                DT.Rows(10).Item(0) = CBFontSize.SelectedItem.ToString
                DT.Rows(10).Item(2) = "Font Size"

                '-save from list box---------------------------
                For i = 0 To LB.Items.Count - 1
                    Dim DR0 As DataRow = DT.NewRow
                    DT.Rows.Add(DR0)
                    DT.Rows(11 + i).Item(1) = common.Splitlink(LB.Items(i), 1)
                    DT.Rows(11 + i).Item(0) = common.Splitlink(LB.Items(i), 2)
                Next

                '----------------------------------------------


                DS.Tables.Add(DT)
                DS.WriteXml("Easynotes.Config")
                PB.Value = 100

                'loading the settings fro config file to variables
                'If File.Exists("Easynotes.Config") Then
                '    Dim DSC As New DataSet
                '    DSC.ReadXml("Easynotes.Config")
                '    Common.NotesRoot = DSC.Tables(0).Rows(0).Item(0)
                '    Common.TemplateRoot = DSC.Tables(0).Rows(1).Item(0)
                '    Common.DSDBshare = DSC.Tables(0).Rows(2).Item(0)
                'Else
                '    MsgBox("Please set your configurations.", MsgBoxStyle.Information)
                'End If
                '=================================================
                BtnSave.Text = "Save"
                PB.Value = 100

                '------Writing log ------------------
                Dim l As String = "Setting saved with following details - " & DS.GetXml
                l = l.Replace(vbCrLf, " ")

                common.ExtraDataToLog = l
                Dim WL As New Threading.Thread(AddressOf common.WriteLog)
                WL.Start()
                '------------------------------------


                MsgBox("Please restart the application for the changes to take effect", MsgBoxStyle.Information)
                Me.Dispose()

            Else
                MsgBox("Enter a valid Path.", MsgBoxStyle.Exclamation)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            BtnSave.Text = "Save"
            PB.Visible = False
        End Try
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '===========loading fonts
            Dim f As New InstalledFontCollection
            For Each fam As FontFamily In f.Families
                CBFont.Items.Add(fam.Name)
            Next
            CBFont.SelectedIndex = 0
            For i = 0 To CBFont.Items.Count - 1
                If CBFont.Items(i) = "Courier New" Then
                    CBFont.SelectedIndex = i
                    Exit For
                End If
            Next


            '===========loading forecolors
            Dim colorsEnum As Type = GetType(KnownColor)
            Dim mColor As String
            Dim ToAdd As Boolean = False
            For Each mColor In [Enum].GetNames(colorsEnum)
                If ToAdd = True Then
                    CBForeColor.Items.Add(mColor)
                Else
                    If mColor = "Transparent" Then
                        ToAdd = True
                    End If

                End If
            Next mColor

            CBForeColor.SelectedIndex = 0
            For i = 0 To CBForeColor.Items.Count - 1
                If CBForeColor.Items(i) = "Black" Then
                    CBForeColor.SelectedIndex = i
                    Exit For
                End If
            Next


            '===========loading forecolors
            Dim colorsEnum1 As Type = GetType(KnownColor)
            Dim mColor1 As String
            Dim ToAdd1 As Boolean = False
            For Each mColor1 In [Enum].GetNames(colorsEnum)
                If ToAdd1 = True Then
                    CBBackcolor.Items.Add(mColor1)
                Else
                    If mColor1 = "Transparent" Then
                        ToAdd1 = True
                    End If

                End If
            Next mColor1

            CBBackcolor.SelectedIndex = 0
            For i = 0 To CBBackcolor.Items.Count - 1
                If CBBackcolor.Items(i) = "White" Then
                    CBBackcolor.SelectedIndex = i
                    Exit For
                End If
            Next

            '===========loading font size

            For i = 8 To 30
                CBFontSize.Items.Add(i.ToString)
            Next
            CBFontSize.SelectedIndex = 4
            '=================================

            If My.Computer.FileSystem.FileExists("Easynotes.Config") Then
                Dim DS As New DataSet
                DS.ReadXml("Easynotes.Config")
                TxtNotesroot.Text = DS.Tables(0).Rows(0).Item(0)
                TxtTemplateroot.Text = DS.Tables(0).Rows(1).Item(0)
                TxtAltTemplateroot.Text = DS.Tables(0).Rows(2).Item(0)
                TxtDSDBshare.Text = DS.Tables(0).Rows(3).Item(0)
                TxtBullet.Text = DS.Tables(0).Rows(4).Item(0)
                If DS.Tables(0).Rows(5).Item(0).ToString = "Yes" Then
                    ChkBulletEnabled.Checked = True
                Else
                    ChkBulletEnabled.Checked = False
                End If
                TxtRecentCase.Text = DS.Tables(0).Rows(6).Item(0)

                For i = 0 To CBFont.Items.Count - 1
                    If CBFont.Items(i).ToString = DS.Tables(0).Rows(7).Item(0).ToString Then
                        CBFont.SelectedIndex = i
                        Exit For
                    End If
                Next

                For i = 0 To CBForeColor.Items.Count - 1
                    If CBForeColor.Items(i).ToString = DS.Tables(0).Rows(8).Item(0).ToString Then
                        CBForeColor.SelectedIndex = i
                        Exit For
                    End If
                Next

                For i = 0 To CBBackcolor.Items.Count - 1
                    If CBBackcolor.Items(i).ToString = DS.Tables(0).Rows(9).Item(0).ToString Then
                        CBBackcolor.SelectedIndex = i
                        Exit For
                    End If
                Next

                For i = 0 To CBFontSize.Items.Count - 1
                    If CBFontSize.Items(i).ToString = DS.Tables(0).Rows(10).Item(0).ToString Then
                        CBFontSize.SelectedIndex = i
                        Exit For
                    End If
                Next


                For i = 11 To DS.Tables(0).Rows.Count - 1
                    LB.Items.Add(DS.Tables(0).Rows(i).Item(1) & "<-->" & DS.Tables(0).Rows(i).Item(0))
                Next


            End If


            SetSampleText()
        

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub BtnLstAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLstAdd.Click
        Try

            If TxtLst.Text.Trim = "" Or TxtLinkname.Text.Trim = "" Then
                MsgBox("Please enter a link name and a link address.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            For i = 0 To LB.Items.Count - 1
                If LB.Items(i) = TxtLst.Text.Trim Then
                    Exit Sub
                End If
            Next
            LB.Items.Add(TxtLinkname.Text.Trim & "<-->" & TxtLst.Text.Trim)

            TxtLinkname.Text = ""
            TxtLst.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnLstDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLstDelete.Click
        Try
            LB.Items.Remove(LB.SelectedItem)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TxtLinkname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLinkname.Leave
        TxtLinkname.Text = TxtLinkname.Text.ToUpper
    End Sub

    Private Sub TxtLst_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLst.Leave
        Try

            'If TxtLst.Text.Trim <> "" And TxtLst.Text.StartsWith("http://") = False And TxtLst.Text.StartsWith("https://") = False Then
            '    TxtLst.Text = "http://" & TxtLst.Text
            'Else
            If TxtLst.Text.StartsWith("http:\\") Then
                TxtLst.Text = TxtLst.Text.Replace("http:\\", "http://")
            ElseIf TxtLst.Text.StartsWith("https:\\") Then
                TxtLst.Text = TxtLst.Text.Replace("https:\\", "https://")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub SetSampleText()
        Try
            RTBSample.Font = New System.Drawing.Font(CBFont.SelectedItem.ToString, CBFontSize.SelectedItem.ToString, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            RTBSample.ForeColor = Color.FromName(CBForeColor.SelectedItem.ToString)
            RTBSample.BackColor = Color.FromName(CBBackcolor.SelectedItem.ToString)
        Catch ex As Exception
            If ex.Message.StartsWith("Object reference not set to an instance of an object") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try
    End Sub

    Private Sub CBFont_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFont.SelectedIndexChanged
        Try
            SetSampleText()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CBBackcolor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBBackcolor.SelectedIndexChanged
        Try
            SetSampleText()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CBForeColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBForeColor.SelectedIndexChanged
        Try
            SetSampleText()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CBFontSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFontSize.SelectedIndexChanged
        Try
            SetSampleText()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

End Class