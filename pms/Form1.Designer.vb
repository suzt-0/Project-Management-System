<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Panel1 = New Panel()
        Button4 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Reg_btn = New Button()
        Login_btn = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(336, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(488, 46)
        Label1.TabIndex = 0
        Label1.Text = "Project Management System"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-12, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1197, 82)
        Panel1.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.AllowDrop = True
        Button4.BackColor = Color.Crimson
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderColor = Color.Crimson
        Button4.FlatAppearance.MouseDownBackColor = Color.Black
        Button4.FlatAppearance.MouseOverBackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(1087, 15)
        Button4.Name = "Button4"
        Button4.Size = New Size(95, 43)
        Button4.TabIndex = 3
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Crimson
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.DodgerBlue
        Button2.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText
        Button2.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(24, 17)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 41)
        Button2.TabIndex = 2
        Button2.Text = "Help ?"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SkyBlue
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Reg_btn)
        Panel2.Controls.Add(Login_btn)
        Panel2.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Panel2.Location = New Point(-9, 73)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1194, 682)
        Panel2.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(804, 482)
        Label4.Name = "Label4"
        Label4.Size = New Size(159, 50)
        Label4.TabIndex = 6
        Label4.Text = "Register"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(258, 482)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 50)
        Label3.TabIndex = 5
        Label3.Text = "Login"
        ' 
        ' Reg_btn
        ' 
        Reg_btn.BackgroundImage = My.Resources.Resources.document
        Reg_btn.BackgroundImageLayout = ImageLayout.Stretch
        Reg_btn.Cursor = Cursors.Hand
        Reg_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Reg_btn.FlatAppearance.CheckedBackColor = Color.RoyalBlue
        Reg_btn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Reg_btn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Reg_btn.FlatStyle = FlatStyle.Flat
        Reg_btn.Location = New Point(684, 95)
        Reg_btn.Name = "Reg_btn"
        Reg_btn.Size = New Size(397, 361)
        Reg_btn.TabIndex = 2
        Reg_btn.UseVisualStyleBackColor = True
        ' 
        ' Login_btn
        ' 
        Login_btn.BackgroundImage = My.Resources.Resources.login
        Login_btn.BackgroundImageLayout = ImageLayout.Stretch
        Login_btn.Cursor = Cursors.Hand
        Login_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Login_btn.FlatAppearance.CheckedBackColor = Color.RoyalBlue
        Login_btn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Login_btn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Login_btn.FlatStyle = FlatStyle.Flat
        Login_btn.ForeColor = Color.Black
        Login_btn.Location = New Point(145, 95)
        Login_btn.Name = "Login_btn"
        Login_btn.Size = New Size(349, 361)
        Login_btn.TabIndex = 1
        Login_btn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1182, 753)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Project Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Login_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Reg_btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
End Class
