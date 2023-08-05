Imports MySqlConnector

Public Class Delete
    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        View_prj.Show()
        Me.Close()

    End Sub
    Public Sub mem()
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "DELETE FROM project_members WHERE `project_members`.`Pid` ='" & Pid_txt.Text & "'"

            Dim mysc As New MySqlCommand(sql, con)


            i = mysc.ExecuteNonQuery()

            If i > 0 Then
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            Dim i As Integer
            mem()

            con.Open()
            sql = "DELETE FROM project WHERE `Pid` ='" & Pid_txt.Text & "'"

            Dim mysc As New MySqlCommand(sql, con)


            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Deleted successfully!")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Class