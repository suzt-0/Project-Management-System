Imports MySqlConnector

Public Class Edit_Staff

    Public Sub data_refresh()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from employee where 1"
            Dim data As New MySqlDataAdapter(sql, con)
            data.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Edit_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_refresh()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            Dim i As Integer
            Dim mobile_num As String = globalvariables.mbl
            con.Open()
            sql = "UPDATE `employee` SET `name` = '" & name_txt.Text & "', `age` = '" & age_txt.Text & "', `mobile` = '" & mobile_txt.Text & "', `department` = '" & dept_txt.Text & "'  WHERE `id` = '" & id_txt.Text & "'"

            Dim mysc As New MySqlCommand(sql, con)


            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Updated successfully!")
                DataGridView1.Refresh()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Del_btn_Click(sender As Object, e As EventArgs) Handles Del_btn.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "DELETE FROM employee WHERE `employee`.`id` ='" & Del_id_txt.Text & "' AND `employee`.`mobile` ='" & Del_mobile_txt.Text & "' AND `employee`.`password` ='" & Del_password_txt.Text & "'"

            Dim mysc As New MySqlCommand(sql, con)


            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Deleted successfully!")
                DataGridView1.Refresh()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Staff_info_pm.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim command As New MySqlCommand("SELECT * FROM `employee` WHERE  `mobile` = '" & mbl & "' AND `password` = '" & pwd & "'", con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count > 0 Then

            Dim name As String = table.Rows(0)("name").ToString
            Dim age As String = table.Rows(0)("age").ToString
            Dim mobile As String = table.Rows(0)("mobile").ToString
            Dim id As String = table.Rows(0)("id").ToString
            Dim department As String = table.Rows(0)("department").ToString
            Dim Type As String = table.Rows(0)("type").ToString
            Dim password As String = table.Rows(0)("password").ToString
            con.Close()
            name_txt.Text = name
            age_txt.Text = age
            mobile_txt.Text = mobile
            id_txt.Text = id
            dept_txt.Text = department
            password_txt.Text = password



        Else

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        data_refresh()

    End Sub
End Class

