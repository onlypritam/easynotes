Imports System.Net
Imports System.IO
Imports System.Drawing.Drawing2D

Public NotInheritable Class SplashScreen

    Dim i As Integer
    Dim b As Bitmap


    Private Sub SplashScreen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            'MsgBox("1> " & ex.Message)
        End Try

    End Sub

    Private Sub SplashScreen_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            b.Dispose()
        Catch ex As Exception
            'MsgBox("2> " & ex.Message)
        End Try

    End Sub


    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            My.Computer.FileSystem.CopyFile("Img.tmp", "Img1.tmp", True)
            b = Image.FromFile("img1.tmp")
            Me.BackgroundImage = b 'New Bitmap("Img1.tmp")
        Catch ex As Exception

            Try
                Dim ObjWebClient As New WebClient
                Dim ObjImage As New MemoryStream
                Dim Cmn As New Common
                ObjImage = New MemoryStream(ObjWebClient.DownloadData(Cmn.GetBingImageURL))
                Me.BackgroundImage = Image.FromStream(ObjImage)
            Catch ex1 As Exception
                'MsgBox(ex1.Message, MsgBoxStyle.Exclamation)
            End Try
            ' MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    'Public Sub DrawStringRectangleF(ByVal e As PaintEventArgs)
    '    Try
    '        Dim drawString As String = "Easy Notes v4.6"
    '        Dim drawFont As New Font("Snap ITC", 18)
    '        Dim drawBrush As New SolidBrush(Color.White)

    '        Dim x As Decimal = 10 'Me.Width - 290
    '        Dim y As Decimal = 10
    '        Dim width As Decimal = 400
    '        Dim height As Decimal = 50

    '        Dim drawRect As New RectangleF(x, y, width, height)
    '        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try


    'End Sub

    Private Sub SplashScreen_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' DrawStringRectangleF(e)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            i = i + 1
            If i > 10 Then

                If Me.Opacity > 0.1 Then
                    Me.Opacity = Me.Opacity - 0.1
                Else
                    Me.Dispose()
                End If


            End If

            
        Catch ex As Exception
            If ex.Message.StartsWith("Object reference not set to an instance of an object") = False Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try

    End Sub

    Private Sub SplashScreen_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        
        Try
            Dim t As New Threading.Thread(AddressOf SaveBingLogowithCaption)
            t.Start()


        Catch ex As Exception
            'If ex.Message.StartsWith("The process cannot access the file") = False Then
            '    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            'End If

        End Try
    End Sub


    Private Sub SaveBingLogowithCaption()
        Dim fs As FileStream
        'Dim Bimage As Bitmap
        Dim GraphicImage As Graphics
        Try
            Dim ObjWebClient As New WebClient
            Dim ObjImage As New MemoryStream
            Dim Cmn As New Common
            ObjImage = New MemoryStream(ObjWebClient.DownloadData(Cmn.GetBingImageURL))
            'Me.BackgroundImage = Image.FromStream(ObjImage)
            '
            Dim data As Byte() = ObjImage.ToArray()
            fs = New FileStream("Img2.tmp", FileMode.Create)
            fs.Write(data, 0, data.Length)
            fs.Close()
            fs.Dispose()
            '
            Dim Bimage As Bitmap = Image.FromFile("Img2.tmp", True)
            GraphicImage = Graphics.FromImage(Bimage)
            GraphicImage.SmoothingMode = SmoothingMode.AntiAlias
            Dim drawBrush As New SolidBrush(Color.White)
            GraphicImage.DrawString("Easy Notes v" & Common.Version, New Font("Snap ITC", 44, FontStyle.Regular), drawBrush, New Point(10, 10))
            Bimage.Save("img.tmp")

        Catch ex As Exception
            'If ex.Message.StartsWith("The process cannot access the file") = False Then
            '    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            'End If

        End Try
    End Sub


End Class
