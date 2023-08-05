Public Class Staff_info_pm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        View_staff.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Edit_Staff.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dash_pm.Show()
        Me.Close()

    End Sub

    Private Sub Staff_info_pm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class