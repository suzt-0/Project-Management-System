<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_staff
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
        Button1 = New Button()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Prj_btn = New Button()
        Per_btn = New Button()
        Panel3 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.FlatAppearance.MouseDownBackColor = Color.Black
        Button1.FlatAppearance.MouseOverBackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(956, 59)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 41)
        Button1.TabIndex = 0
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SkyBlue
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Prj_btn)
        Panel2.Controls.Add(Per_btn)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(100, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1082, 753)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(117, 581)
        Label3.Name = "Label3"
        Label3.Size = New Size(321, 46)
        Label3.TabIndex = 4
        Label3.Text = "Project Information"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(644, 581)
        Label2.Name = "Label2"
        Label2.Size = New Size(285, 46)
        Label2.TabIndex = 3
        Label2.Text = "Staff Information"
        ' 
        ' Prj_btn
        ' 
        Prj_btn.BackgroundImage = My.Resources.Resources.Prj
        Prj_btn.BackgroundImageLayout = ImageLayout.Stretch
        Prj_btn.Cursor = Cursors.Hand
        Prj_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Prj_btn.FlatAppearance.CheckedBackColor = Color.RoyalBlue
        Prj_btn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Prj_btn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Prj_btn.FlatStyle = FlatStyle.Flat
        Prj_btn.Location = New Point(117, 219)
        Prj_btn.Name = "Prj_btn"
        Prj_btn.Size = New Size(323, 316)
        Prj_btn.TabIndex = 2
        Prj_btn.UseVisualStyleBackColor = True
        ' 
        ' Per_btn
        ' 
        Per_btn.BackgroundImage = My.Resources.Resources.Personal_info
        Per_btn.BackgroundImageLayout = ImageLayout.Stretch
        Per_btn.Cursor = Cursors.Hand
        Per_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Per_btn.FlatAppearance.CheckedBackColor = Color.RoyalBlue
        Per_btn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Per_btn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Per_btn.FlatStyle = FlatStyle.Flat
        Per_btn.Location = New Point(613, 219)
        Per_btn.Name = "Per_btn"
        Per_btn.Size = New Size(323, 316)
        Per_btn.TabIndex = 1
        Per_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightCyan
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1082, 125)
        Panel3.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(250, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(598, 60)
        Label1.TabIndex = 0
        Label1.Text = "Project Management System"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(100, 753)
        Panel1.TabIndex = 0
        ' 
        ' Dashboard_staff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1182, 753)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Dashboard_staff"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Staff"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Prj_btn As Button
    Friend WithEvents Per_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
