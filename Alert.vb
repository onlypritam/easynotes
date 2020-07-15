Public Class Alert

    Dim Common As New Common

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If Common.IsCaseNo(TxtCaseno.Text.Trim) = False Then
                MsgBox("Please enter a valid case no.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If CboAction.Text.Trim = "" Then
                MsgBox("Please enter a Action.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If CboAction.Text.Trim = "" Then
                MsgBox("Please enter a Priority.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If Form1.DSAlert.Tables.Count <= 0 Then
                '============Creating the dataset====================
                Dim Dt As New DataTable("Alert")
                Dim c1 As New DataColumn("Caseno")
                Dim c2 As New DataColumn("Priority")
                Dim c3 As New DataColumn("Action")
                Dt.Columns.Add(c1)
                Dt.Columns.Add(c2)
                Dt.Columns.Add(c3)
                '---------------------------------------
                Form1.DSAlert.Tables.Add(Dt)

            End If

            Dim Rw As DataRow = Form1.DSAlert.Tables(0).NewRow
            'MsgBox(Common.DSAlert.Columns.Count)
            Rw.Item(0) = TxtCaseno.Text.Trim
            Rw.Item(1) = CboPriority.Text.Trim
            Rw.Item(2) = CboAction.Text.Trim
            Form1.DSAlert.Tables(0).Rows.Add(Rw)
            Form1.DSAlert.Tables(0).WriteXml("Alerts.Config")

            Form1.DGAlert.DataSource = Form1.DSAlert.Tables(0)


            '------Writing log ------------------
            Common.ExtraDataToLog = "Reminder created for Case no - " & TxtCaseno.Text.Trim & " for priority - " & CboPriority.Text.Trim & " with action - " & CboAction.Text.Trim
            Dim WL As New Threading.Thread(AddressOf Common.WriteLog)
            WL.Start()
            '------------------------------------

            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Alert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CboPriority.SelectedIndex = 0


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TxtCaseno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCaseno.TextChanged
        Try
            Dim Rno As Integer = 0
            If Form1.DSAlert.Tables.Count > 0 Then
                Rno = Form1.DSAlert.Tables(0).Select("Caseno='" & TxtCaseno.Text.Trim & "'").Length
            End If

            If Rno > 0 Then
                Me.Height = 180
                LblCNO.Text = "Note : This case already has " & Rno & " reminder(s)."
            Else
                Me.Height = 160
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class