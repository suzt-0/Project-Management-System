Public Class Dashboard_staff

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Per_btn_Click(sender As Object, e As EventArgs) Handles Per_btn.Click
        Personal_info.Show()
    End Sub

    Private Sub Prj_btn_Click(sender As Object, e As EventArgs) Handles Prj_btn.Click
        Staff_project_info.Show()
        Me.Close()

    End Sub
End Class