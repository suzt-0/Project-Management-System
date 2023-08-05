<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_pjt
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
        Panel1 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Pname_txt = New TextBox()
        Password_txt = New TextBox()
        Id_txt = New TextBox()
        Button2 = New Button()
        Enter_btn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(738, 89)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(611, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 35)
        Button1.TabIndex = 1
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(286, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 41)
        Label1.TabIndex = 0
        Label1.Text = "Update"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(64, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 41)
        Label2.TabIndex = 1
        Label2.Text = "Project Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(121, 260)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 41)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(128, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(308, 41)
        Label5.TabIndex = 4
        Label5.Text = "Enter Project Id(Pid) :"
        ' 
        ' Pname_txt
        ' 
        Pname_txt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Pname_txt.Location = New Point(300, 188)
        Pname_txt.Name = "Pname_txt"
        Pname_txt.Size = New Size(276, 47)
        Pname_txt.TabIndex = 5
        ' 
        ' Password_txt
        ' 
        Password_txt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Password_txt.Location = New Point(300, 254)
        Password_txt.Name = "Password_txt"
        Password_txt.Size = New Size(276, 47)
        Password_txt.TabIndex = 6
        ' 
        ' Id_txt
        ' 
        Id_txt.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Id_txt.Location = New Point(442, 114)
        Id_txt.Name = "Id_txt"
        Id_txt.Size = New Size(110, 31)
        Id_txt.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.FlatAppearance.BorderColor = Color.SkyBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(242, 349)
        Button2.Name = "Button2"
        Button2.Size = New Size(194, 51)
        Button2.TabIndex = 9
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Enter_btn
        ' 
        Enter_btn.BackColor = Color.SteelBlue
        Enter_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Enter_btn.FlatStyle = FlatStyle.Flat
        Enter_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Enter_btn.Location = New Point(580, 109)
        Enter_btn.Name = "Enter_btn"
        Enter_btn.Size = New Size(105, 38)
        Enter_btn.TabIndex = 10
        Enter_btn.Text = "Enter"
        Enter_btn.UseVisualStyleBackColor = False
        ' 
        ' update_pjt
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(738, 498)
        ControlBox = False
        Controls.Add(Enter_btn)
        Controls.Add(Button2)
        Controls.Add(Id_txt)
        Controls.Add(Password_txt)
        Controls.Add(Pname_txt)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "update_pjt"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Update"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Pname_txt As TextBox
    Friend WithEvents Password_txt As TextBox
    Friend WithEvents Id_txt As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Enter_btn As Button
End Class
