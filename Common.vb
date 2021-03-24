Imports System.Text
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net
Imports Outlook = Microsoft.Office.Interop.Outlook



Public Class Common

    Public Shared NotesRoot As String = ""
    Public Shared TemplateRoot As String = ""
    Public Shared AltTemplateRoot As String = ""
    Public Shared DSDBshare As String = ""
    Public Shared CaseNo As String = ""
    Public Shared CustomerName As String = ""
    Public Shared CustomerFName As String = ""
    Public Shared CustomerLName As String = ""
    Public Shared Bullet As String = ""
    Public Shared AllDataSaved As Boolean = False
    Public Shared RecentDays As Integer = 7
    Public Shared FontName As String = "Courier New"
    Public Shared FontColor As String = "RoyalBlue"
    Public Shared BackColor As String = "White"
    Public Shared FontSize As String = "11"
    Public Shared OverRideCaseNo As String = "" ' to stop the caseno form to search for open mssolve and clarify cases
    Public Shared ReadOnly Version As String = "5.2"
    Public Shared CollectFileList As Boolean = False  ' to intimate when to collect file list
    Public Shared EntersBeforePaste As Integer = 0 ' to find out how many time you pressed enter after before paste
    Public Shared ExtraDataToLog As String = "<Null>"
    Public Shared DonotLoadPreviousNotes As Boolean = False

    '===for copy progrress bars   true value will show the PBs
    Public Shared PBPS As Boolean = False
    Public Shared PBLS As Boolean = False
    Public Shared PBFTP As Boolean = False
    Public Shared PBCF As Boolean = False


    '==========================


    Friend Function GetFileSize(ByVal Bytes As Int64) As String
        Try

            Dim RV As String = "0"

            If Bytes < 1024 Then
                RV = CType(Math.Round(Bytes, 2), String) & " (Bytes)"
            ElseIf Bytes >= 1024 And Bytes < 1048576 Then
                RV = CType(Math.Round(Bytes / 1024, 2), String) & " (KB)"
            ElseIf Bytes >= 1048576 And Bytes < 1073741824 Then
                RV = CType(Math.Round(Bytes / 1048576, 2), String) & " (MB)"
            ElseIf Bytes >= 1073741824 And Bytes < 1099511627776 Then
                RV = CType(Math.Round(Bytes / 1073741824, 2), String) & " (GB)"
            End If

            Return RV

        Catch ex As Exception
            Return "0"
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Function


    Public Function IsCaseNo(ByVal caseno As String) As Boolean
        Try
            If caseno.Length = 15 And Regex.IsMatch(Left(caseno, 3), "^[a-zA-Z]*$") = True And Regex.IsMatch(Right(caseno, 12), "^[0-9]*$") = True Then
                Return True
            ElseIf caseno.Length = 17 Then
                If Regex.IsMatch(Left(caseno, 3), "^[a-zA-Z]*$") = True And caseno.Substring(15, 1) = "-" And IsNumeric(caseno.Substring(16, 1)) And Regex.IsMatch(caseno.Substring(3, 12), "^[0-9]*$") = True Then
                    Return True
                End If
            ElseIf caseno.Length = 15 And Regex.IsMatch(caseno, "^[0-9]*$") = True Then
                Return True
            ElseIf caseno.Length = 18 And Regex.IsMatch(caseno, "^[0-9]*$") = True Then
                Return True
            Else : Return False

            End If
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function IsClarifyCase() As Boolean
        Try
            If CaseNo.Length = 15 And Regex.IsMatch(Left(CaseNo, 3), "^[a-zA-Z]*$") = True And Regex.IsMatch(Right(CaseNo, 12), "^[0-9]*$") = True Then
                Return True
            ElseIf CaseNo.Length = 17 Then
                If Regex.IsMatch(Left(CaseNo, 3), "^[a-zA-Z]*$") = True And CaseNo.Substring(15, 1) = "-" And IsNumeric(CaseNo.Substring(16, 1)) And Regex.IsMatch(CaseNo.Substring(3, 12), "^[0-9]*$") = True Then
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Function



    Public Function IsMSSolveCase() As Boolean
        Try
            If CaseNo.Length = 15 And Regex.IsMatch(CaseNo, "^[0-9]*$") = True Then
                Return True
            ElseIf CaseNo.Length = 18 And Regex.IsMatch(CaseNo, "^[0-9]*$") = True Then
                Return True
            Else : Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Function

    Public Function ReadTextFile(ByVal Path As String) As String
        Try

            Dim objReader As New StreamReader(Path)
            Dim sLine As String
            sLine = objReader.ReadToEnd
            objReader.Close()
            Return sLine.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return ""
        End Try

    End Function


    Friend Function Splitlink(ByVal s As String, ByVal i As Integer) As String
        Try
            Dim output As String = String.Empty
            If i = 1 Then
                output = s.Substring(0, s.IndexOf("<-->"))
            Else
                output = s.Substring(s.IndexOf("<-->") + 4, s.Length - (s.IndexOf("<-->") + 4))
            End If

            Return output
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Function


    Friend Function GetCaseInfo(ByVal i As Integer) As String 'Caseno-1 , c name-2
        Try
            Dim p As Process
            For Each p In Process.GetProcesses(".")
                If p.MainWindowTitle.StartsWith("SR:") Then 'SR: 000000000000000,FName LName 

                    If i = 1 Then
                        Return p.MainWindowTitle.Substring(4, 15)
                        Exit Function
                    ElseIf i = 2 Then
                        Return p.MainWindowTitle.Substring(22, p.MainWindowTitle.Length - 22)
                        Exit Function
                    End If

                    'ElseIf p.MainWindowTitle.StartsWith("Service Request:") Then ' Backward compatible

                    '    If i = 1 Then
                    '        Return p.MainWindowTitle.Substring(17, 15)
                    '    ElseIf i = 2 Then
                    '        Return p.MainWindowTitle.Substring(34, p.MainWindowTitle.Length - 34)
                    '    End If

                ElseIf p.MainWindowTitle.Contains("SR:") Then 'FName LName, SR: 000000000000000

                    Dim sr As Integer = p.MainWindowTitle.IndexOf("SR:")

                    If i = 1 Then
                        Return p.MainWindowTitle.Substring(sr + 4, p.MainWindowTitle.Length - (sr + 4)) ' caseno
                        Exit Function
                    ElseIf i = 2 Then
                        Return p.MainWindowTitle.Substring(0, sr - 2) ' name
                        Exit Function
                    End If

                ElseIf p.MainWindowTitle.Contains("Case Id -") Then 'FName LName, Case Id - 000000000000000 *****

                    Dim sr As Integer = p.MainWindowTitle.IndexOf("Case Id -")

                    If i = 1 Then
                        Return p.MainWindowTitle.Substring(sr + 9, 16).Trim ' caseno
                        Exit Function
                    ElseIf i = 2 Then
                        Return p.MainWindowTitle.Substring(0, sr - 2) ' name
                        Exit Function
                    End If
                ElseIf p.MainWindowTitle.EndsWith("- Dynamics 365") Then

                    Dim sr As Integer = p.MainWindowTitle.LastIndexOf("-")
                    If i = 1 Then
                        Return p.MainWindowTitle.Substring(0, sr - 1).Trim ' caseno
                        Exit Function
                    End If
                End If

            Next

            'For Each p In Process.GetProcesses(".")
            '    If p.MainWindowTitle.StartsWith("ClarifyCRM - ClearSupport - [ Case") Or p.MainWindowTitle.StartsWith("ClarifyCRM - ClearSupport - [ Subcase") Or p.MainWindowTitle.StartsWith("ClarifyCRM - ClearSupport - [[READ] Case") Then
            '        If i = 1 Then
            '            Return p.MainWindowTitle.Substring(p.MainWindowTitle.IndexOf("SR"), p.MainWindowTitle.Length - p.MainWindowTitle.IndexOf("SR") - 1)
            '        End If
            '    End If
            'Next

            Return ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return ""
        End Try

    End Function



    'Friend Function GetFTPInternalDirectory(ByVal Caseno As String) As String
    '    Try
    '        Dim MyWebClient As New WebClient
    '        Dim htmltext As String
    '        MyWebClient.Credentials = CredentialCache.DefaultCredentials
    '        ' Read web page HTML to byte array
    '        Dim PageHTMLBytes() As Byte
    '        PageHTMLBytes = MyWebClient.DownloadData("https://filexfer.partners.extranet.microsoft.com/ViewWorkspace.aspx")
    '        ' Convert result from byte array to string 
    '        Dim oUTF8 As UTF8Encoding = New UTF8Encoding()
    '        htmltext = oUTF8.GetString(PageHTMLBytes)

    '        Dim findcaseno As Integer
    '        findcaseno = htmltext.IndexOf("Case Number " & Caseno)

    '        Dim searchstart As Integer
    '        searchstart = htmltext.IndexOf("<a href=""", findcaseno)

    '        Dim searchend As Integer
    '        searchend = htmltext.IndexOf(""" target=""", findcaseno)

    '        Dim id As String
    '        id = htmltext.Substring(searchstart + 9, searchend - searchstart - 9)
    '        Return id

    '    Catch ex As Exception
    '        If ex.Message.StartsWith("Index was out of range") Then
    '            Return ""
    '        Else
    '            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '        End If

    '    End Try
    'End Function




    Friend Sub SetCaseAttribute(ByVal Section As String, ByVal Value As String, ByVal CaseNo As String)
        Try

            Dim Infofile As String
            'MsgBox(Value)

            If Common.CaseNo.Trim = "" Then
                Exit Sub
            End If

            If My.Computer.FileSystem.FileExists(Common.NotesRoot & "\" & CaseNo & "\Info.txt") = True Then
                Infofile = My.Computer.FileSystem.ReadAllText(Common.NotesRoot & "\" & CaseNo & "\Info.txt")
                My.Computer.FileSystem.DeleteFile(Common.NotesRoot & "\" & CaseNo & "\Info.txt") ' this line is necessary to modify the last access date of the case directory and to enlist it in current case
            Else
                Infofile = " "
            End If

            If Section = "Email" Then
                If Infofile.Contains("<Email>") And Infofile.Contains("<Email/>") Then
                    Infofile = Infofile.Remove(Infofile.IndexOf("<Email>"), Infofile.IndexOf("<Email/>") + 8 - Infofile.IndexOf("<Email>"))
                End If

                Infofile = Infofile + "<Email>" & Value & "<Email/>"

            ElseIf Section = "Problem" Then
                If Infofile.Contains("<Problem>") And Infofile.Contains("<Problem/>") Then
                    Infofile = Infofile.Remove(Infofile.IndexOf("<Problem>"), Infofile.IndexOf("<Problem/>") + 10 - Infofile.IndexOf("<Problem>"))
                End If

                Infofile = Infofile + "<Problem>" & Value & "<Problem/>"
            ElseIf Section = "Environment" Then
                If Infofile.Contains("<Environment>") And Infofile.Contains("<Environment/>") Then
                    Infofile = Infofile.Remove(Infofile.IndexOf("<Environment>"), Infofile.IndexOf("<Environment/>") + 14 - Infofile.IndexOf("<Environment>"))
                End If

                Infofile = Infofile + "<Environment>" & Value & "<Environment/>"

            ElseIf Section = "CustomerName" Then
                If Infofile.Contains("<CustomerName>") And Infofile.Contains("<CustomerName/>") Then
                    Infofile = Infofile.Remove(Infofile.IndexOf("<CustomerName>"), Infofile.IndexOf("<CustomerName/>") + 15 - Infofile.IndexOf("<CustomerName>"))
                End If

                Infofile = Infofile + "<CustomerName>" & Value & "<CustomerName/>"

            End If

            My.Computer.FileSystem.WriteAllText(Common.NotesRoot & "\" & CaseNo & "\Info.txt", Infofile, False)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Friend Function GetCaseAttribute(ByVal section As String, ByVal CaseNo As String) As String
        Try

            Dim Infofile As String
            Dim ReturnText As String = String.Empty

            If CaseNo.Trim = "" Then
                Return ""
                Exit Function
            End If

            If My.Computer.FileSystem.FileExists(Common.NotesRoot & "\" & CaseNo & "\Info.txt") = False Then
                Return ""
                Exit Function
            Else
                Infofile = My.Computer.FileSystem.ReadAllText(Common.NotesRoot & "\" & CaseNo & "\Info.txt")
            End If


            If section = "Email" Then
                ReturnText = Infofile.Substring(Infofile.IndexOf("<Email>") + 7, Infofile.IndexOf("<Email/>") - (Infofile.IndexOf("<Email>") + 7))
            ElseIf section = "Problem" Then
                ReturnText = Infofile.Substring(Infofile.IndexOf("<Problem>") + 9, Infofile.IndexOf("<Problem/>") - (Infofile.IndexOf("<Problem>") + 9))
            ElseIf section = "Environment" Then
                ReturnText = Infofile.Substring(Infofile.IndexOf("<Environment>") + 13, Infofile.IndexOf("<Environment/>") - (Infofile.IndexOf("<Environment>") + 13))
            ElseIf section = "CustomerName" Then
                ReturnText = Infofile.Substring(Infofile.IndexOf("<CustomerName>") + 14, Infofile.IndexOf("<CustomerName/>") - (Infofile.IndexOf("<CustomerName>") + 14))
            End If

            Return ReturnText
        Catch ex As Exception
            If ex.Message.StartsWith("Length cannot be less than zero") Or ex.Message.StartsWith("startIndex cannot be larger than length of string") Then
                Return ""
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try


    End Function

    Friend Function GetBingImageURL() As String
        Try
            Dim MyWebClient As New WebClient
            Dim htmltext As String
            ' Read web page HTML to byte array
            Dim PageHTMLBytes() As Byte
            PageHTMLBytes = MyWebClient.DownloadData("http://www.bing.com/")
            ' Convert result from byte array to string 
            Dim oUTF8 As UTF8Encoding = New UTF8Encoding()
            htmltext = oUTF8.GetString(PageHTMLBytes)

            Dim ImagePathStart As Integer
            ImagePathStart = htmltext.IndexOf("background-image: url(") + 23

            Dim ImagePathEnd As Integer
            ImagePathEnd = htmltext.IndexOf(".jpg", ImagePathStart)

            Dim id As String
            id = "http://www.bing.com/" & htmltext.Substring(ImagePathStart, ImagePathEnd - ImagePathStart + 4)
            id = id.Replace("\", "")
            Return id
        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Function



    Friend Sub SendFeedback()
        Try
            Dim OApp As Outlook.Application = New Outlook.Application()
            Dim MI As Outlook.MailItem = OApp.CreateItem(Outlook.OlItemType.olMailItem)


            MI.To = "Snehach@Microsoft.com"
            MI.Subject = "Easy Notes Feedback - " & Common.Version
            MI.CC = "Snehach@Live.com"
            MI.Display()



        Catch ex As Exception
            If ex.Message <> "Object reference not set to an instance of an object." Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub



    Friend Sub WriteLog()
        Try
            Dim lg As String
            lg = vbCrLf & My.User.Name & "  ,  " & My.Computer.Name & "  ,  " & Now & "  ,  " & Common.Version & " , " & ExtraDataToLog
            File.AppendAllText("\\snehach1\ENLog\ENlog.txt", lg)
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub CheckVersion()
        Try
            If File.Exists("\\snehach1\ENVersion\ENVersion.txt") Then
                Dim V As String = File.ReadAllText("\\snehach1\ENVersion\ENVersion.txt")
                'MsgBox(V.IndexOf("<ENVersion>") + 11)
                'MsgBox(V.IndexOf("<ENVersion/>"))
                Dim VN As Double = V.Substring(11, 3) '<ENVersion>4.6<ENVersion/>
                If VN > CType(Common.Version, Double) Then
                    If MsgBox("A higher version of this product is available. Would you like to Upgrade it.", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Process.Start("http://toolbox/easynotes")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub CheckMessage()
        Try
            If File.Exists("\\snehach1\ENVersion\ENMessage.txt") Then
                Dim V As String = File.ReadAllText("\\snehach1\ENVersion\ENMessage.txt")
                If V.Trim <> "" Then MsgBox(V, MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Friend Function getCustomerFilePath() As String
    '    Dim yyyy, mm, dd As String
    '    Dim FinalString As String = ""
    '    Try
    '        If IsMSSolveCase() = True Then
    '            yyyy = "20" & CaseNo.Substring(1, 2)
    '            mm = CaseNo.Substring(3, 2)
    '            dd = CaseNo.Substring(5, 2)
    '            FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '        End If
    '        Return FinalString
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '        Return FinalString
    '    End Try
    'End Function


    'Friend Function getCustomerFilePath() As String
    '    Dim yyyy, mm, dd As String
    '    Dim FinalString As String = ""
    '    Try
    '        If IsMSSolveCase() = True Then
    '            yyyy = "20" & CaseNo.Substring(1, 2)
    '            mm = CaseNo.Substring(3, 2)
    '            dd = CaseNo.Substring(5, 2)

    '            'For i As Integer = dd - 1 To dd + 1
    '            '    If Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo) = True Then
    '            '        FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & i & "\" & CaseNo
    '            '    End If
    '            'Next

    '            If Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '            End If


    '            'for previous day
    '            If FinalString.Trim = "" And dd > 1 Then
    '                dd = dd - 1
    '                If Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                End If
    '            End If


    '            'for next day
    '            If FinalString.Trim = "" And dd < 31 Then
    '                dd = dd + 1
    '                If Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                End If
    '            End If


    '            'for 2 previous day
    '            If FinalString.Trim = "" And dd > 2 Then
    '                dd = dd - 2
    '                If Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                End If
    '            End If

    '            'for 2 next day
    '            If FinalString.Trim = "" And dd < 30 Then
    '                dd = dd + 2
    '                If Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders10\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders01\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders02\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders03\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders04\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders05\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders06\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders07\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders08\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders09\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                ElseIf Directory.Exists("\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo) = True Then
    '                    FinalString = "\\partners.extranet.microsoft.com\mssolvefiles\SRDataFolders\" & yyyy & "\" & mm & "\" & dd & "\" & CaseNo
    '                End If
    '            End If

    '        End If
    '        Return FinalString
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '        Return FinalString
    '    End Try
    'End Function


    Function SetBytes(ByVal Bytes) As String

        Try
            If Bytes >= 1073741824 Then
                SetBytes = Format(Bytes / 1024 / 1024 / 1024, "#0.00") _
                     & " GB"
            ElseIf Bytes >= 1048576 Then
                SetBytes = Format(Bytes / 1024 / 1024, "#0.00") & " MB"
            ElseIf Bytes >= 1024 Then
                SetBytes = Format(Bytes / 1024, "#0.00") & " KB"
            Else
                SetBytes = Fix(Bytes) & " Bytes"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return "0 Bytes"
        End Try
    End Function



    Friend Function getFileLocations() As String
        Dim Locations As String = ""
        Try
            If Form1.DGLocal.Rows.Count > 0 Then
                Locations = Locations & Form1.lbllocal.Text.Trim & vbCrLf
            End If

            If Form1.DGRemote.Rows.Count > 0 Then
                Locations = Locations & Form1.lblremote.Text.Trim & vbCrLf
            End If

            Return Locations.Trim

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return ""
        End Try
    End Function


End Class
