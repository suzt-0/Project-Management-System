<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_prj
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
        Close_btn = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        Del_btn = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Update_btn = New Button()
        Pjt_info_btn = New Button()
        Create_btn = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Close_btn)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1369, 85)
        Panel1.TabIndex = 0
        ' 
        ' Close_btn
        ' 
        Close_btn.BackColor = Color.Crimson
        Close_btn.FlatAppearance.BorderColor = Color.LightCyan
        Close_btn.FlatAppearance.MouseDownBackColor = Color.Black
        Close_btn.FlatAppearance.MouseOverBackColor = Color.Black
        Close_btn.FlatStyle = FlatStyle.Flat
        Close_btn.ForeColor = SystemColors.ButtonHighlight
        Close_btn.Location = New Point(33, 29)
        Close_btn.Name = "Close_btn"
        Close_btn.Size = New Size(85, 31)
        Close_btn.TabIndex = 1
        Close_btn.Text = "Back"
        Close_btn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(446, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 62)
        Label1.TabIndex = 0
        Label1.Text = "Project"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SkyBlue
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Del_btn)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Update_btn)
        Panel2.Controls.Add(Pjt_info_btn)
        Panel2.Controls.Add(Create_btn)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 85)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1369, 518)
        Panel2.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(1167, 382)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 38)
        Label5.TabIndex = 7
        Label5.Text = "Delete"
        ' 
        ' Del_btn
        ' 
        Del_btn.BackgroundImage = My.Resources.Resources.trash
        Del_btn.BackgroundImageLayout = ImageLayout.Stretch
        Del_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Del_btn.FlatAppearance.CheckedBackColor = Color.SteelBlue
        Del_btn.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        Del_btn.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        Del_btn.FlatStyle = FlatStyle.Flat
        Del_btn.Location = New Point(1079, 114)
        Del_btn.Name = "Del_btn"
        Del_btn.Size = New Size(256, 239)
        Del_btn.TabIndex = 6
        Del_btn.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(812, 382)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 38)
        Label4.TabIndex = 5
        Label4.Text = "Update"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(471, 382)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 38)
        Label3.TabIndex = 4
        Label3.Text = "View"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(114, 382)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 38)
        Label2.TabIndex = 3
        Label2.Text = "+Create"
        ' 
        ' Update_btn
        ' 
        Update_btn.BackgroundImage = My.Resources.Resources.updated
        Update_btn.BackgroundImageLayout = ImageLayout.Stretch
        Update_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Update_btn.FlatAppearance.CheckedBackColor = Color.SteelBlue
        Update_btn.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        Update_btn.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        Update_btn.FlatStyle = FlatStyle.Flat
        Update_btn.Location = New Point(743, 140)
        Update_btn.Name = "Update_btn"
        Update_btn.Size = New Size(256, 239)
        Update_btn.TabIndex = 2
        Update_btn.UseVisualStyleBackColor = True
        ' 
        ' Pjt_info_btn
        ' 
        Pjt_info_btn.BackgroundImage = My.Resources.Resources.file
        Pjt_info_btn.BackgroundImageLayout = ImageLayout.Stretch
        Pjt_info_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Pjt_info_btn.FlatAppearance.CheckedBackColor = Color.SteelBlue
        Pjt_info_btn.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        Pjt_info_btn.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        Pjt_info_btn.FlatStyle = FlatStyle.Flat
        Pjt_info_btn.Location = New Point(409, 114)
        Pjt_info_btn.Name = "Pjt_info_btn"
        Pjt_info_btn.Size = New Size(256, 239)
        Pjt_info_btn.TabIndex = 1
        Pjt_info_btn.UseVisualStyleBackColor = True
        ' 
        ' Create_btn
        ' 
        Create_btn.BackgroundImage = My.Resources.Resources.Create
        Create_btn.BackgroundImageLayout = ImageLayout.Stretch
        Create_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Create_btn.FlatAppearance.CheckedBackColor = Color.SteelBlue
        Create_btn.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        Create_btn.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        Create_btn.FlatStyle = FlatStyle.Flat
        Create_btn.Location = New Point(74, 114)
        Create_btn.Name = "Create_btn"
        Create_btn.Size = New Size(256, 239)
        Create_btn.TabIndex = 0
        Create_btn.UseVisualStyleBackColor = True
        ' 
        ' View_prj
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1369, 603)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "View_prj"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Project"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Pjt_info_btn As Button
    Friend WithEvents Create_btn As Button
    Friend WithEvents Update_btn As Button
    Friend WithEvents Close_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Del_btn As Button
End Class
