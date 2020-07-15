Imports System.Net
Imports System.IO

Public NotInheritable Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)

        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright



        Dim ObjWebClient As New WebClient
        Dim ObjImage As New MemoryStream
        Dim Cmn As New Common
        ObjImage = New MemoryStream(ObjWebClient.DownloadData(Cmn.GetBingImageURL))
        Me.BackgroundImage = Image.FromStream(ObjImage)

        

    End Sub

    Public Sub DrawStringRectangleF(ByVal e As PaintEventArgs)
        Try
            Dim drawString As String = "Easy Notes " & Common.Version
            Dim drawFont As New Font("Snap ITC", 20)
            Dim drawBrush As New SolidBrush(Color.White)

            Dim x As Decimal = 10
            Dim y As Decimal = 10
            Dim width As Decimal = 400
            Dim height As Decimal = 50

            Dim drawRect As New RectangleF(x, y, width, height)
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub About_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        DrawStringRectangleF(e)

        
    End Sub



    
End Class
