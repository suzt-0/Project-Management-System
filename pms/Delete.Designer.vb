<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
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
        Label1 = New Label()
        back_btn = New Button()
        Pid_txt = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(back_btn)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(564, 103)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(96, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(306, 60)
        Label1.TabIndex = 0
        Label1.Text = "Delete Project"
        ' 
        ' back_btn
        ' 
        back_btn.BackColor = Color.Crimson
        back_btn.Cursor = Cursors.Hand
        back_btn.FlatAppearance.BorderColor = Color.SkyBlue
        back_btn.FlatAppearance.MouseDownBackColor = Color.Black
        back_btn.FlatAppearance.MouseOverBackColor = Color.Black
        back_btn.FlatStyle = FlatStyle.Flat
        back_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        back_btn.ForeColor = SystemColors.ButtonHighlight
        back_btn.Location = New Point(462, 37)
        back_btn.Name = "back_btn"
        back_btn.Size = New Size(90, 40)
        back_btn.TabIndex = 1
        back_btn.Text = "Back"
        back_btn.UseVisualStyleBackColor = False
        ' 
        ' Pid_txt
        ' 
        Pid_txt.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Pid_txt.Location = New Point(237, 211)
        Pid_txt.Name = "Pid_txt"
        Pid_txt.Size = New Size(274, 47)
        Pid_txt.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(58, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 41)
        Label2.TabIndex = 4
        Label2.Text = "Project_id"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.SkyBlue
        Button1.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight
        Button1.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(294, 321)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 56)
        Button1.TabIndex = 6
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Delete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(564, 404)
        ControlBox = False
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Pid_txt)
        Controls.Add(Panel1)
        Name = "Delete"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Delete"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents back_btn As Button
    Friend WithEvents Pid_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
