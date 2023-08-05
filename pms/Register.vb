Imports MySqlConnector

Public Class Register_form
    Private Sub Reg_btn_Click(sender As Object, e As EventArgs) Handles Reg_btn.Click
        Try
            Dim sql As String
            Dim i As Integer

            con.Open()
            sql = "INSERT INTO `employee` (`name`, `age`, `mobile`, `id`, `department`, `type`, `password`) VALUES ('" & name_txt.Text & "', '" & age_txt.Text & "', '" & mobile_txt.Text & "', NULL, '" & Department_txt.Text & "', '" & Type_txt.Text & "', '" & pwd_txt.Text & "')"

            Dim mysc As New MySqlCommand(sql, con)


            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
                login_form.Show()

                Me.Close()

            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class