Public Class View_prj
    Private Sub Create_btn_Click(sender As Object, e As EventArgs) Handles Create_btn.Click
        Prj_create.Show()
        Me.Close()

    End Sub

    Private Sub Pjt_info_btn_Click(sender As Object, e As EventArgs) Handles Pjt_info_btn.Click
        project_info_pm.Show()
        Me.Close()

    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        update_pjt.Show()
        Me.Close()

    End Sub

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Dash_pm.Show()
        Me.Close()

    End Sub



    Private Sub Del_btn_Click(sender As Object, e As EventArgs) Handles Del_btn.Click
        Delete.Show()
        Me.Close()

    End Sub


End Class