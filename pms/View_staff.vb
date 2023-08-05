Imports MySqlConnector

Public Class View_staff
    Private Sub View_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from employee where `type`='staff'"
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
        Staff_info_pm.Show()
        Me.Close()

    End Sub
End Class