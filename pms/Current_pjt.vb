Imports MySqlConnector

Public Class Current_pjt
    Private Sub Current_pjt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from project_members where `mobile`='" & mbl & "'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Staff_project_info.Show()
        Me.Close()

    End Sub
End Class