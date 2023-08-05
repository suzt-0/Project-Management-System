<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Join_pjt
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
        Pname_txt = New TextBox()
        Pid_txt = New TextBox()
        Join_btn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(538, 75)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.FlatAppearance.BorderColor = Color.LightCyan
        Button1.FlatAppearance.MouseDownBackColor = Color.Black
        Button1.FlatAppearance.MouseOverBackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(12, 18)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(158, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 41)
        Label1.TabIndex = 0
        Label1.Text = "Join New Project"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(53, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 31)
        Label2.TabIndex = 1
        Label2.Text = "Project Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(158, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 31)
        Label3.TabIndex = 2
        Label3.Text = "Pid"
        ' 
        ' Pname_txt
        ' 
        Pname_txt.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Pname_txt.Location = New Point(225, 109)
        Pname_txt.Name = "Pname_txt"
        Pname_txt.Size = New Size(224, 38)
        Pname_txt.TabIndex = 3
        ' 
        ' Pid_txt
        ' 
        Pid_txt.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Pid_txt.Location = New Point(225, 159)
        Pid_txt.Name = "Pid_txt"
        Pid_txt.Size = New Size(224, 38)
        Pid_txt.TabIndex = 4
        ' 
        ' Join_btn
        ' 
        Join_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Join_btn.Location = New Point(283, 224)
        Join_btn.Name = "Join_btn"
        Join_btn.Size = New Size(94, 38)
        Join_btn.TabIndex = 5
        Join_btn.Text = "Join"
        Join_btn.UseVisualStyleBackColor = True
        ' 
        ' Join_pjt
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(538, 325)
        ControlBox = False
        Controls.Add(Join_btn)
        Controls.Add(Pid_txt)
        Controls.Add(Pname_txt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Join_pjt"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Join New Project"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Pname_txt As TextBox
    Friend WithEvents Pid_txt As TextBox
    Friend WithEvents Join_btn As Button
    Friend WithEvents Button1 As Button
End Class
