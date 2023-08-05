<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_info_pm
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
        Button3 = New Button()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(914, 97)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Crimson
        Button3.FlatAppearance.BorderColor = Color.LightCyan
        Button3.FlatAppearance.MouseDownBackColor = Color.Black
        Button3.FlatAppearance.MouseOverBackColor = Color.Black
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(764, 23)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 54)
        Button3.TabIndex = 1
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(265, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(333, 54)
        Label3.TabIndex = 0
        Label3.Text = "Staff Information"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.file
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.SkyBlue
        Button1.FlatAppearance.CheckedBackColor = Color.RoyalBlue
        Button1.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Button1.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(129, 116)
        Button1.Name = "Button1"
        Button1.Size = New Size(251, 243)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.edit
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.SkyBlue
        Button2.FlatAppearance.CheckedBackColor = Color.RoyalBlue
        Button2.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Button2.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(506, 105)
        Button2.Name = "Button2"
        Button2.Size = New Size(270, 265)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(158, 384)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 41)
        Label1.TabIndex = 3
        Label1.Text = "View Info"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(558, 384)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 41)
        Label2.TabIndex = 4
        Label2.Text = "Edit Info"
        ' 
        ' Staff_info_pm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(914, 492)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Staff_info_pm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Staff Information"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
End Class
