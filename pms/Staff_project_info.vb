﻿Public Class Staff_project_info

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dashboard_staff.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Join_pjt.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Current_pjt.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Exit_pjt.Show()
        Me.Close()

    End Sub
End Class