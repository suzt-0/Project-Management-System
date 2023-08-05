<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(login_form))
        Label1 = New Label()
        Panel2 = New Panel()
        Button2 = New Button()
        password_txtbox = New TextBox()
        Moblie_txtbox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        login_btn = New Button()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(164, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 54)
        Label1.TabIndex = 0
        Label1.Text = "Log in"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SkyBlue
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(password_txtbox)
        Panel2.Controls.Add(Moblie_txtbox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(login_btn)
        Panel2.Location = New Point(1, -3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(428, 508)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Crimson
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.SkyBlue
        Button2.FlatAppearance.MouseDownBackColor = Color.Black
        Button2.FlatAppearance.MouseOverBackColor = Color.Black
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(11, 15)
        Button2.Name = "Button2"
        Button2.Size = New Size(68, 29)
        Button2.TabIndex = 2
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' password_txtbox
        ' 
        password_txtbox.Cursor = Cursors.IBeam
        password_txtbox.Location = New Point(112, 245)
        password_txtbox.Name = "password_txtbox"
        password_txtbox.Size = New Size(252, 27)
        password_txtbox.TabIndex = 5
        ' 
        ' Moblie_txtbox
        ' 
        Moblie_txtbox.Cursor = Cursors.IBeam
        Moblie_txtbox.Location = New Point(112, 212)
        Moblie_txtbox.Name = "Moblie_txtbox"
        Moblie_txtbox.Size = New Size(252, 27)
        Moblie_txtbox.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(31, 250)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 3
        Label3.Text = "Password :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(51, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 2
        Label2.Text = "Mobile:"
        ' 
        ' login_btn
        ' 
        login_btn.BackColor = SystemColors.ButtonHighlight
        login_btn.Cursor = Cursors.Hand
        login_btn.FlatAppearance.BorderColor = Color.SkyBlue
        login_btn.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        login_btn.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue
        login_btn.FlatStyle = FlatStyle.Flat
        login_btn.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point)
        login_btn.ForeColor = Color.Black
        login_btn.Location = New Point(164, 340)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(129, 47)
        login_btn.TabIndex = 1
        login_btn.Text = "Log in"
        login_btn.UseVisualStyleBackColor = False
        ' 
        ' login_form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(418, 499)
        ControlBox = False
        Controls.Add(Panel2)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "login_form"
        RightToLeft = RightToLeft.No
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log in"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents login_btn As Button
    Friend WithEvents password_txtbox As TextBox
    Friend WithEvents Moblie_txtbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
