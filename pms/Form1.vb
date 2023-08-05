Public Class Form1
    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        login_form.Show()
        Me.Hide()
    End Sub

    Private Sub Reg_btn_Click(sender As Object, e As EventArgs) Handles Reg_btn.Click
        Register_form.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        globalvariables.mbl = ""
        globalvariables.pwd = ""
        globalvariables.name = ""
        globalvariables.typ = ""
        globalvariables.depart = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Help.Show()

    End Sub

End Class
