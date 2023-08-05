Imports MySqlConnector

Public Class Prj_create

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        Dim Project_Deadline As DateTime = DateTimePicker1.Value
        Dim name As String = globalvariables.name
        Dim formattedDeadline As String = Project_Deadline.ToString("yyyy-MM-dd")
        Try
            Dim sql As String
            Dim i As Integer
            Dim Pm As String
            Pm = globalvariables.name
            con.Open()
            sql = "INSERT INTO `project` (`Pname`, `Project_Deadline`, `Pid`, `password`, `Project Manager`, `Creation time`, `Time-Left`) VALUES ('" & Pname.Text & "',  ' " & formattedDeadline & " ', NULL, '" & password_txt.Text & "', '" & name & "', current_timestamp(), TIMESTAMPDIFF(DAY, NOW(),'" & formattedDeadline & "'));"

            Dim mysc As New MySqlCommand(sql, con)


            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Project has been created successfully!")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        View_prj.Show()
        Me.Close()

    End Sub
End Class