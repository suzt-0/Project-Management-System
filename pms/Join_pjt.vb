Imports MySqlConnector

Public Class Join_pjt
    Private Sub Join_btn_Click(sender As Object, e As EventArgs) Handles Join_btn.Click
        Try
            Dim sql As String
            Dim i As Integer
            Dim name, Type, Mobile, Department As String

            name = globalvariables.name
            Type = globalvariables.typ
            Mobile = globalvariables.mbl
            Department = globalvariables.depart

            con.Open()
            sql = "INSERT INTO `project_members` (`Name`, `Pname`, `Pid`, `Type`, `Mobile`, `Department`) VALUES ('" & name & "', '" & Pname_txt.Text & "', '" & Pid_txt.Text & "', '" & Type & "', '" & Mobile & "', '" & Department & "')"

            Dim mysc As New MySqlCommand(sql, con)


            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Successfully Joined New Project !!!")
                Staff_project_info.Show()
                Me.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Staff_project_info.Show()
        Me.Close()

    End Sub
End Class