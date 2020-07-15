Imports System.IO
Imports System.Text

Public Class CleanOldCases
    Dim common As New Common

    Dim Dt As New DataTable


    Private Sub CleanOldCases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ShowAllCases()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CreateDt()
        Try
            Dt.Rows.Clear()
            Dt.Columns.Clear()

            Dim C0 As New DataColumn("Select")
            Dt.Columns.Add(C0)

            Dim C1 As New DataColumn("Case Number")
            Dt.Columns.Add(C1)

            Dim C2 As New DataColumn("Customer Name")
            Dt.Columns.Add(C2)

            Dim C3 As New DataColumn("Last Access")
            Dt.Columns.Add(C3)

            Dim C4 As New DataColumn("Data Size")
            Dt.Columns.Add(C4)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub ShowAllCases()
        Try
            Dim dr As DirectoryInfo
            Dim dri As New DirectoryInfo(common.NotesRoot)
            CreateDt()

            For Each dr In dri.GetDirectories

                Dim datarow As DataRow = Dt.NewRow
                datarow.Item(0) = "False"
                datarow.Item(1) = dr.Name.Trim
                datarow.Item(2) = common.GetCaseAttribute("CustomerName", dr.Name).Trim
                datarow.Item(3) = dr.LastAccessTime
                Dim FS As Long
                Dim MyFiles As FileInfo
                For Each MyFiles In dr.GetFiles
                    FS = FS + MyFiles.Length
                Next
                datarow.Item(4) = common.SetBytes(FS)
                Dt.Rows.Add(datarow)
            Next
            DG.DataSource = Dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellContentClick
        If e.ColumnIndex = 2 Then
            If DG.Rows(e.RowIndex).Cells(2).Value = True Then
                DG.Rows(e.RowIndex).Cells(2).Value = False
            Else
                DG.Rows(e.RowIndex).Cells(2).Value = True
            End If

        ElseIf e.ColumnIndex = 0 Then
            Process.Start("mssv://sr/?" & DG.Rows(e.RowIndex).Cells(3).Value)

        ElseIf e.ColumnIndex = 1 Then
            common.OverRideCaseNo = DG.Rows(e.RowIndex).Cells(3).Value

            Form1.BtnNew_Click(sender, e)
        End If

    End Sub



    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try

            Dim caselist As String = ""
            If common.CaseNo.Trim <> "" Then caselist = common.CaseNo.Trim & " - "
            For Each dr As DataGridViewRow In Form1.DGAlert.Rows
                caselist = caselist & dr.Cells(1).Value.trim.ToString & " - "
            Next

            If MsgBox("Are you sure, you want to delete the local data (case-notes and Data saved locally) related to all the selected cases.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                For Each dr As DataGridViewRow In DG.Rows
                    If dr.Cells(2).Value = True Then
                        If caselist.Contains(dr.Cells(3).Value.trim) = True Then
                            MsgBox("Case number " & dr.Cells(3).Value.trim & " either is currently open in easy notes or has an alert associated with it. So it could not be deleted.", MsgBoxStyle.Information)
                        Else
                            If Directory.Exists(common.NotesRoot & "\" & dr.Cells(3).Value) Then
                                Directory.Delete(common.NotesRoot & "\" & dr.Cells(3).Value, True)

                            End If
                        End If
                    End If
                Next

                MsgBox("All cases deleted successfully.", MsgBoxStyle.Information)
                Me.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


End Class