Imports System.Windows
Imports MySqlConnector

Public Class login_form

    Public Sub Check()

        Dim command As New MySqlCommand("SELECT * FROM `employee` WHERE  `mobile` = '" & Moblie_txtbox.Text & "' AND `password` = '" & password_txtbox.Text & "'", con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Dim userType As String = table.Rows(0)("type").ToString
            con.Close()
            If userType = "Staff" Then
                Dashboard_staff.Show()
                Dim name As String = table.Rows(0)("name").ToString
                Dim dept As String = table.Rows(0)("department").ToString
                globalvariables.name = name
                globalvariables.depart = dept
                globalvariables.typ = userType
                Me.Hide()
            Else userType = "Project Manager"
                Dash_pm.Show()
                Dim name As String = table.Rows(0)("name").ToString
                Dim dept As String = table.Rows(0)("department").ToString
                globalvariables.name = name
                globalvariables.depart = dept
                globalvariables.typ = userType
                Me.Hide()
            End If
        Else
            MsgBox("Rows did not come")
        End If



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If (Moblie_txtbox.Text = "" Or password_txtbox.Text = "") Then
            MsgBox("Enter something to login")
        Else
            Dim command As New MySqlCommand("SELECT `mobile`, `password` FROM `employee` WHERE `mobile` = '" & Moblie_txtbox.Text & "' AND `password` = '" & password_txtbox.Text & "'", con)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count = 0 Then
                MessageBox.Show("Invalid Username Or Password")
                Moblie_txtbox.Text = ""
                password_txtbox.Text = ""
            Else

                globalvariables.mbl = Moblie_txtbox.Text
                globalvariables.pwd = password_txtbox.Text
                con.Close()
                MessageBox.Show("Login Sucessfull!!!")

                Check()
                Moblie_txtbox.Text = ""
                password_txtbox.Text = ""

            End If

        End If


    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Moblie_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Moblie_txtbox.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub
End Class