Imports System.Numerics
Imports MySqlConnector

Public Class update_pjt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        View_prj.Show()
        Me.Close()
    End Sub



    Private Sub Enter_btn_Click(sender As Object, e As EventArgs) Handles Enter_btn.Click
        Dim command As New MySqlCommand("SELECT `Pname`,`password` FROM `project` WHERE  `Pid` = '" & Id_txt.Text & "'", con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count > 0 Then

            Dim Pname As String = table.Rows(0)("Pname").ToString
            Dim password As String = table.Rows(0)("password").ToString


            con.Close()
            Pname_txt.Text = Pname
            Password_txt.Text = password



        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim sql As String
            Dim i As Integer

            con.Open()
            sql = "UPDATE `project` SET `Pname` = '" & Pname_txt.Text & "', `password` = '" & Password_txt.Text & "'  WHERE `Pid` = '" & Id_txt.Text & "'"

            Dim mysc As New MySqlCommand(sql, con)


            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Updated successfully!")
                Pname_txt.Text = ""
                Password_txt.Text = ""
                Id_txt.Text = ""
                View_prj.Show()
                Me.Close()

            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class