Imports System.Reflection.Metadata
Imports MySqlConnector
Public Class Personal_info


    Private Sub Personal_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            con.Close()
            Name_txt.Text = name
            age_txt.Text = age
            mbl_txt.Text = mobile
            id_txt.Text = id
            Dept_txt.Text = department
            type_txt.Text = Type


        Else

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            Dim i As Integer
            Dim mobile_num As String = globalvariables.mbl
            con.Open()
            sql = "UPDATE `employee` SET `name` = '" & Name_txt.Text & "', `age` = '" & age_txt.Text & "', `mobile` = '" & mbl_txt.Text & "', `department` = '" & Dept_txt.Text & "',`type` = '" & type_txt.Text & "'  WHERE `mobile` = '" & mobile_num & "'"

            Dim mysc As New MySqlCommand(sql, con)


            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Updated successfully!")
                login_form.Show()

                Me.Close()
                Dash_pm.Close()

            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Class