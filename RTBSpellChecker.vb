'Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.Reflection


Public Class RTBSpellChecker
    Inherits System.Windows.Forms.RichTextBox
    Dim bullet As String = Common.Bullet & " "
    Dim BulletEntered As Boolean = False  ' to find out whether the last key entered was "Enter" or not, if so then pressing backspace should remove the entire bullet

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

    End Sub


#Region "Variables"

    Dim m_blnSpellCheck As Boolean = True
    Shared m_app As Word.Application = New Word.Application()
    Shared m_doc As Word.Document = m_app.Documents.Add()


#End Region






    Private Sub RTBSpellChecker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.Control AndAlso e.KeyCode = Keys.V Then

                Dim s As String = Clipboard.GetText
                s = s.Replace(" " & vbCrLf, vbCrLf)
                s = s.Replace(vbCrLf, " " & vbCrLf)

                Me.SelectedText = s 'Clipboard.GetText
                e.Handled = True
                'PuttingSpaceBeforeEnter()
            ElseIf e.KeyCode = 13 Then
                UnderlineWrongWord(True)
                Me.SelectedText = " "
                'SendKeys.Send(" ")
                'SendKeys.Send("{BS}")

                'SendKeys.Send(vbCrLf)
                'Me.SelectedText = " " '& vbCrLf
                'e.Handled = True



            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try


    End Sub

    'Private Sub PuttingSpaceBeforeEnter()
    '    Try
    '        MsgBox(Me.Rtf)
    '        Dim i As Integer = Me.SelectionStart
    '        ' Me.Text = Me.Text.Replace("\par", "")
    '        Me.Rtf = Me.Rtf.Replace(" \par", "\par")
    '        Dim a As Integer = Me.Rtf.Split(" \par").GetUpperBound(0)


    '        MsgBox(a)
    '        Me.Rtf = Me.Rtf.Replace("\par", " \par")
    '        Dim b As Integer = Me.Rtf.Split("\par").GetUpperBound(0)
    '        MsgBox(b)

    '        MsgBox(a - b)
    '        'Me.Rtf = Me.Rtf.Replace("\par" & vbCrLf & " \par", "\par" & vbCrLf & "\par")
    '        'Me.Rtf = Me.Rtf.Replace("\par" & vbCrLf & " \par", "\par" & vbCrLf & "\par")
    '        Me.Rtf = Me.Rtf.Replace(" \cf", "\cf") 'this line is implemented  to get ride of initial space
    '        Me.ForeColor = Color.FromName(Common.FontColor) 'this line is implemented  to get ride of color change to black after paste
    '        Me.SelectionStart = i '+ 1
    '        MsgBox(Me.Rtf)

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub


    Private Sub RTBSpellChecker_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        Try
            If (Me.Text.Length = 0) Then
                Me.SelectionFont = New Font(Me.SelectionFont.FontFamily, Me.SelectionFont.Size, FontStyle.Regular)
                Me.Refresh()
            End If


            If e.KeyCode = 8 Then  'backspace  
                If BulletEntered = True Then
                    Me.SelectionStart = Me.SelectionStart - bullet.Length + 1
                    Me.SelectionLength = bullet.Length - 1
                    Me.SelectedText = ""
                    Form1.ChkBullet.Checked = False
                End If
                BulletEntered = False ' if bullet is entered for this key, Bulletentered will be turned onn below.
            ElseIf e.KeyCode = 13 Then 'enter    only this section have BulletEntered = True


                If BulletEntered = True Then
                    Me.SelectionStart = Me.SelectionStart - bullet.Length - 1 - 1 '(the last -1 after fixing the \par issue) '+ 1
                    Me.SelectionLength = bullet.Length + 1 '- 1
                    Me.SelectedText = ""
                    Form1.ChkBullet.Checked = False
                    BulletEntered = False
                End If


                If Form1.ChkBullet.Checked = True Then

                    '---------------------this should be better------------------------
                    Me.SelectionLength = 0
                    Me.SelectedText = bullet
                    BulletEntered = True
                    '---------------------------------------------
                End If

                '=for putting a space before enter=================
                'Dim i As Integer
                'i = Me.SelectionStart
                'Me.Rtf = Me.Rtf.Replace(" \par", "\par")
                'Me.Rtf = Me.Rtf.Replace("\par", " \par")
                'Me.SelectionStart = i + 1
                '==================================================

            ElseIf (e.KeyValue = 32 Or (e.KeyValue = 39 And e.Shift = False)) Then '32=space  39=right arrow.
                BulletEntered = False ' if bullet is entered for this key, Bulletentered will be turned on above.
                UnderlineWrongWord(False)
                '    Dim m_strRecentWord As String = String.Empty
                '    Dim m_intLastIndex As Integer = Me.Text.Substring(0, Me.SelectionStart - 1).LastIndexOf(" ")
                '    Dim m_intLength As Integer = Me.SelectionStart - m_intLastIndex - 2
                '    m_strRecentWord = Me.Text.Substring(m_intLastIndex + 1, m_intLength)
                '    m_strRecentWord = m_strRecentWord.Trim()

                '    If m_strRecentWord.EndsWith(bullet.Trim) Then
                '        'MsgBox(m_strRecentWord)
                '        Form1.ChkBullet.Checked = True
                '        BulletEntered = True
                '    End If

                '    If (m_strRecentWord.Length > 0 And IsWrongWord(m_strRecentWord) = True) Then
                '        Me.SelectionStart = m_intLastIndex + 1
                '        Me.SelectionLength = m_intLength
                '        Me.SelectionFont = New Font(Me.SelectionFont.FontFamily, Me.SelectionFont.Size, FontStyle.Underline)
                '        Me.SelectionStart = Me.SelectionStart + Me.SelectionLength + 1
                '        Me.SelectionLength = 0
                '        Me.Refresh()
                '    Else
                '        Me.SelectionStart = m_intLastIndex + 1
                '        Me.SelectionLength = m_intLength + 1
                '        Me.SelectionFont = New Font(Me.SelectionFont.FontFamily, Me.SelectionFont.Size, FontStyle.Regular)
                '        Me.SelectionStart = Me.SelectionStart + Me.SelectionLength '+ 1
                '        Me.SelectionLength = 0
                '        Me.Refresh()
                '    End If
            Else
                'If BulletEntered = True Then   ' converting first letter after bullet to caps  ///this block commented on 30-12-2010 and unbloked on 28/10/2011
                '    If e.KeyCode >= 65 And e.KeyCode <= 90 Then
                '        Me.SelectionStart = Me.SelectionStart - 1 '+ 1
                '        Me.SelectionLength = 1 '- 1
                '        Me.SelectedText = Me.SelectedText.ToUpper
                '    End If
                'End If
                BulletEntered = False ' if bullet is entered for this key, Bulletentered will be turned on above.

            End If

        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Else
                Me.SelectionStart = Me.SelectionStart + Me.SelectionLength '+ 1
                Me.SelectionLength = 0
                Me.Refresh()
            End If

        End Try
    End Sub

    Private Sub UnderlineWrongWord(ByVal EnterKey As Boolean)
        Try
            Dim m_strRecentWord As String = String.Empty
            Dim m_intLastIndex As Integer = Me.Text.Substring(0, Me.SelectionStart - 1).LastIndexOf(" ")
            Dim m_intLength As Integer = Me.SelectionStart - m_intLastIndex - 2
            If EnterKey = True Then
                m_strRecentWord = Me.Text.Substring(m_intLastIndex + 1, m_intLength + 1)
            Else
                m_strRecentWord = Me.Text.Substring(m_intLastIndex + 1, m_intLength)
            End If
            'm_strRecentWord = Me.Text.Substring(m_intLastIndex + 1, m_intLength)
            m_strRecentWord = m_strRecentWord.Trim()

            If m_strRecentWord.EndsWith(bullet.Trim) Then
                'MsgBox(m_strRecentWord)
                Form1.ChkBullet.Checked = True
                BulletEntered = True
            End If


            If (m_strRecentWord.Length > 0 And IsWrongWord(m_strRecentWord) = True) Then
                Me.SelectionStart = m_intLastIndex + 1
                'If EnterKey = True Then
                '    Me.SelectionLength = m_intLength + 1
                'Else
                '    Me.SelectionLength = m_intLength
                'End If
                Me.SelectionLength = m_intLength
                Me.SelectionFont = New Font(Me.SelectionFont.FontFamily, Me.SelectionFont.Size, FontStyle.Underline)
                Me.SelectionStart = Me.SelectionStart + Me.SelectionLength + 1
                Me.SelectionLength = 0
                Me.Refresh()
            Else
                Me.SelectionStart = m_intLastIndex + 1
                Me.SelectionLength = m_intLength + 1
                Me.SelectionFont = New Font(Me.SelectionFont.FontFamily, Me.SelectionFont.Size, FontStyle.Regular)
                Me.SelectionStart = Me.SelectionStart + Me.SelectionLength '+ 1
                Me.SelectionLength = 0
                Me.Refresh()
            End If
            ' If EnterKey = False Then BulletEntered = False ' if bullet is entered for this key, Bulletentered will be turned on above.
        Catch ex As Exception
            If ex.Message.StartsWith("Length cannot be less than zero") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub



    Private Sub RTBSpellChecker_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles Me.LinkClicked
        Try
            System.Diagnostics.Process.Start(e.LinkText)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub



    'Private Sub RTBSpellChecker_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
    '    UnderLineWrongWords()
    '    'Call SpellChecking()
    'End Sub



    Private Sub RTBSpellChecker_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Try
            'If (Me.SpellCheck = False) Then
            BulletEntered = False
            If (e.Button = Windows.Forms.MouseButtons.Right) Then

                Dim m_objContextMenuStrip As New ContextMenuStrip

                'get string from starting to clicked position
                Dim m_intClickIndex As Int32 = Me.GetCharIndexFromPosition(New Point(e.X, e.Y))

                'index of clicked char
                Dim m_strInitialString As String = Me.Text.Substring(0, m_intClickIndex)

                'MsgBox(Me.Text.Substring(0, m_intClickIndex))
                'MsgBox(Me.Text.Substring(0, m_intClickIndex).LastIndexOf(" "))
                'MsgBox(Me.Text.Substring(0, m_intClickIndex).LastIndexOf(vbCrLf))

                'MsgBox(Me.Text.LastIndexOf(vbCrLf))

                'initialise index upto total lengh in case we are clicking on last word
                Dim m_intStartIndex As Int64 = Me.Text.Length - 1

                'if clicked word is not last word
                If (Me.Text.IndexOf(" ", m_intClickIndex) <> -1) Then
                    m_intStartIndex = Me.Text.IndexOf(" ", m_intClickIndex)
                End If

                'moving towords starting of string from clicked position
                Dim m_intLastIndex As Int64 = m_strInitialString.LastIndexOf(" ")
                ''==================TEST======================
                'If m_strInitialString.LastIndexOf(" ") > m_strInitialString.LastIndexOf(vbCrLf) Then
                '    m_intLastIndex = m_strInitialString.LastIndexOf(" ")
                'ElseIf m_strInitialString.LastIndexOf(" ") < m_strInitialString.LastIndexOf(vbCrLf) Then
                '    m_intLastIndex = m_strInitialString.LastIndexOf(vbCrLf)
                'End If


                ''========================================


                'original clicked word
                Dim m_strWord As String = Me.Text.Substring(m_intLastIndex + 1, m_intStartIndex - m_intLastIndex)

                Dim m_listOfAlternateWords As Word.SpellingSuggestions

                If (m_strWord.Length > 0) Then
                    Dim m_doc As Word.Document = m_app.Documents.Add()

                    Try
                        m_listOfAlternateWords = m_app.GetSpellingSuggestions(m_strWord)
                    Catch ex As Exception
                        If ex.Message <> "String too long" Then 'Or ex.Message <> "Bad parameter" Or ex.Message <> "Object reference not set to an instance of an object." Then
                            If ex.Message <> "Bad parameter" Then
                                ' If ex.Message <> "Object reference not set to an instance of an object." Then
                                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                                'End If

                            End If

                        Else
                            m_listOfAlternateWords = m_app.GetSpellingSuggestions("") ' to get a count of 0
                        End If
                    End Try


                    If m_listOfAlternateWords.Count > 0 Then
                        m_objContextMenuStrip.Items.Clear()

                        '============ADDING IGNORE=======================

                        Dim Item1 As New ToolStripMenuItem()
                        Item1.Name = "{Ignore}"
                        Item1.Text = "{Ignore}"

                        Item1.Tag = New Int64() {m_intLastIndex, m_intStartIndex}

                        AddHandler Item1.Click, AddressOf ToolStripMenuItem_Click

                        m_objContextMenuStrip.Items.Add(Item1)

                        '==================================

                        Dim m_word As Integer
                        For m_word = 1 To m_listOfAlternateWords.Count
                            Dim Item As New ToolStripMenuItem()
                            Item.Name = m_listOfAlternateWords.Item(m_word).Name
                            Item.Text = Item.Name

                            Item.Tag = New Int64() {m_intLastIndex, m_intStartIndex}

                            AddHandler Item.Click, AddressOf ToolStripMenuItem_Click

                            m_objContextMenuStrip.Items.Add(Item)
                        Next

                        If (m_objContextMenuStrip.Items.Count > 0) Then
                            m_objContextMenuStrip.Show(Me, New Point(e.X, e.Y))
                        End If
                    Else

                        '===This code is to remove underline on right clicking if word is correct
                        Dim SS As Integer = Me.SelectionStart
                        Dim SE As Integer = Me.SelectionLength

                        Dim Ignr As New ToolStripMenuItem
                        Ignr.Name = "{Ignore}"
                        Ignr.Text = "{Ignore}"
                        Ignr.Tag = New Int64() {m_intLastIndex, m_intStartIndex}

                        ToolStripMenuItem_Click(Ignr, e)

                        Me.SelectionStart = SS
                        Me.SelectionLength = SE
                        '=====================================================================


                        m_objContextMenuStrip.Items.Clear()

                        Dim Item1 As New ToolStripMenuItem()
                        Item1.Name = "Select all"
                        Item1.Text = "Select all"
                        AddHandler Item1.Click, AddressOf ToolStrip2ndMenuItem_Click
                        m_objContextMenuStrip.Items.Add(Item1)

                        Dim Item2 As New ToolStripMenuItem()
                        Item2.Name = "Cut"
                        Item2.Text = "Cut"
                        AddHandler Item2.Click, AddressOf ToolStrip2ndMenuItem_Click
                        m_objContextMenuStrip.Items.Add(Item2)

                        Dim Item3 As New ToolStripMenuItem()
                        Item3.Name = "Copy"
                        Item3.Text = "Copy"
                        AddHandler Item3.Click, AddressOf ToolStrip2ndMenuItem_Click
                        m_objContextMenuStrip.Items.Add(Item3)

                        Dim Item4 As New ToolStripMenuItem()
                        Item4.Name = "Paste"
                        Item4.Text = "Paste"
                        AddHandler Item4.Click, AddressOf ToolStrip2ndMenuItem_Click
                        m_objContextMenuStrip.Items.Add(Item4)

                        Dim Item5 As New ToolStripMenuItem()
                        Item5.Name = "Bing it"
                        Item5.Text = "Bing it"
                        AddHandler Item5.Click, AddressOf ToolStrip2ndMenuItem_Click
                        m_objContextMenuStrip.Items.Add(Item5)

                        Dim Item6 As New ToolStripMenuItem()
                        Item6.Name = "Bing it in New window"
                        Item6.Text = "Bing it in New window"
                        AddHandler Item6.Click, AddressOf ToolStrip2ndMenuItem_Click
                        m_objContextMenuStrip.Items.Add(Item6)

                        If (m_objContextMenuStrip.Items.Count > 0) Then
                            m_objContextMenuStrip.Show(Me, New Point(e.X, e.Y))
                        End If

                    End If

                End If

                m_objContextMenuStrip = Nothing

            End If
            'End If
        Catch ex As Exception
            If ex.Message <> "String too long" Then
                If ex.Message <> "Object reference not set to an instance of an object." Then
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End If
            End If

        End Try
    End Sub


    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

        If disposing Then
            If Not (m_app Is Nothing) Then
                Dim m_saveChanges As Object = False
                Dim m_originalFormat As Object = Missing.Value
                Dim m_routeDocument As Object = Missing.Value
                'm_app.Documents.Close(False)
                m_app.Quit(m_saveChanges, m_originalFormat, m_routeDocument)
                m_app = Nothing
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Dim m_item As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim m_pointArray As Int64() = CType(m_item.Tag, Int64())
            Dim m_strFirstPart As String = String.Empty
            If (m_pointArray(0) > 0) Then
                m_strFirstPart = Me.Text.Substring(0, m_pointArray(0)) + " "
            End If
            Dim m_strMiddlePart As String = Me.Text.Substring(m_pointArray(0) + 1, m_pointArray(1) - m_pointArray(0))
            Dim m_strLastPart As String = Me.Text.Substring(m_pointArray(1) + 1)
            Me.SelectionStart = m_pointArray(0) + 1
            Me.SelectionLength = m_strMiddlePart.Length

            'Me.SelectionFont = New Font(Me.SelectionFont.FontFamily, Me.SelectionFont.Size, FontStyle.Regular)

            'Me.SelectedText = m_item.Text + " "

            '================FOR IGNORE========================
            If m_item.Name = "{Ignore}" Then

                Me.SelectionFont = New Font(Me.SelectionFont.FontFamily, Me.SelectionFont.Size, FontStyle.Regular)
                Me.SelectedText = Me.SelectedText '+ " "
            Else
                Me.SelectionFont = New Font(Me.SelectionFont.FontFamily, Me.SelectionFont.Size, FontStyle.Regular)

                Me.SelectedText = m_item.Text + " "
            End If
            '=====================================================

            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub ToolStrip2ndMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            Dim m_item As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            If m_item.Name = "Select all" Then
                Me.SelectAll()
            ElseIf m_item.Name = "Cut" Then
                If Me.SelectionLength > 0 Then
                    My.Computer.Clipboard.SetText(Me.SelectedText, TextDataFormat.Text)
                    Me.Text = Me.Text.Replace(Me.SelectedText, "")
                End If
            ElseIf m_item.Name = "Copy" Then
                If Me.SelectionLength > 0 Then
                    My.Computer.Clipboard.SetText(Me.SelectedText, TextDataFormat.Text)
                End If
            ElseIf m_item.Name = "Paste" Then
                Dim s As String = Clipboard.GetText
                s = s.Replace(" " & vbCrLf, vbCrLf)
                s = s.Replace(vbCrLf, " " & vbCrLf)

                Me.SelectedText = s

                'PuttingSpaceBeforeEnter()

                'Me.Paste()
            ElseIf m_item.Name = "Bing it" Then
                If Me.SelectionLength > 0 Then
                    Form1.CreateBrowserTab("BING(" & Me.SelectedText.Trim & ")", "http://www.bing.com/search?q=" & Me.SelectedText.Trim, False)
                    'Process.Start("http://www.bing.com/search?q=" & Me.SelectedText.Trim)
                End If

            ElseIf m_item.Name = "Bing it in New window" Then
                If Me.SelectionLength > 0 Then
                    'Form1.CreateBrowserTab("BING(" & Me.SelectedText.Trim & ")", "http://www.bing.com/search?q=" & Me.SelectedText.Trim, False)
                    Process.Start("http://www.bing.com/search?q=" & Me.SelectedText.Trim)
                End If

            End If
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


#Region "Methods"


    Private Sub InitiatVariable()
        Try
            If (m_app Is Nothing) Then
                Dim m_app As Word.Application = New Word.Application()
                Dim m_doc As Word.Document = m_app.Documents.Add()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Function IsWrongWord(ByVal m_strWord As String) As Boolean
        Try
            Dim m_listOfAlternateWords As Word.SpellingSuggestions = m_app.GetSpellingSuggestions(m_strWord)
            If (m_listOfAlternateWords.Count > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If ex.Message <> "String too long" And ex.Message <> "Bad parameter" And ex.Message.StartsWith("Object reference not set") = False And ex.Message.Contains("RPC") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                Return False
            End If

        End Try
    End Function


#End Region

End Class
