﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_project_info
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
        Button4 = New Button()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1059, 88)
        Panel1.TabIndex = 0
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Crimson
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderColor = Color.LightCyan
        Button4.FlatAppearance.MouseDownBackColor = Color.Black
        Button4.FlatAppearance.MouseOverBackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(916, 28)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 41)
        Button4.TabIndex = 1
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(380, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 41)
        Label1.TabIndex = 0
        Label1.Text = "Project Information"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.Create
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.SkyBlue
        Button1.FlatAppearance.CheckedBackColor = Color.RoyalBlue
        Button1.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Button1.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(66, 185)
        Button1.Name = "Button1"
        Button1.Size = New Size(211, 174)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.file
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.SkyBlue
        Button2.FlatAppearance.CheckedBackColor = Color.RoyalBlue
        Button2.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Button2.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(410, 185)
        Button2.Name = "Button2"
        Button2.Size = New Size(211, 174)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.logout
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderColor = Color.SkyBlue
        Button3.FlatAppearance.CheckedBackColor = Color.RoyalBlue
        Button3.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Button3.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(778, 185)
        Button3.Name = "Button3"
        Button3.Size = New Size(211, 174)
        Button3.TabIndex = 3
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(34, 386)
        Label2.Name = "Label2"
        Label2.Size = New Size(243, 41)
        Label2.TabIndex = 4
        Label2.Text = "Join new project"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(364, 386)
        Label3.Name = "Label3"
        Label3.Size = New Size(313, 41)
        Label3.TabIndex = 5
        Label3.Text = "View Current Projects"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(755, 386)
        Label4.Name = "Label4"
        Label4.Size = New Size(213, 41)
        Label4.TabIndex = 6
        Label4.Text = "Leave Projects"
        ' 
        ' Staff_project_info
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(1059, 522)
        ControlBox = False
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Staff_project_info"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Project"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
End Class
