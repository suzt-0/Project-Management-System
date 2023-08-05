<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dash_pm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Dash_pm))
        Panel1 = New Panel()
        Button4 = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Name = "Panel1"
        ' 
        ' Button4
        ' 
        resources.ApplyResources(Button4, "Button4")
        Button4.BackColor = Color.Crimson
        Button4.FlatAppearance.BorderColor = Color.White
        Button4.FlatAppearance.MouseDownBackColor = Color.Black
        Button4.FlatAppearance.MouseOverBackColor = Color.Black
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Name = "Button4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.BackColor = Color.SkyBlue
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Panel3)
        Panel2.Name = "Panel2"
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.Name = "Label4"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Button3
        ' 
        resources.ApplyResources(Button3, "Button3")
        Button3.BackgroundImage = My.Resources.Resources.manager
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderColor = Color.SkyBlue
        Button3.FlatAppearance.CheckedBackColor = SystemColors.MenuHighlight
        Button3.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight
        Button3.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight
        Button3.Name = "Button3"
        Button3.UseMnemonic = False
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        resources.ApplyResources(Button2, "Button2")
        Button2.BackgroundImage = My.Resources.Resources.Personal_info
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.SkyBlue
        Button2.FlatAppearance.CheckedBackColor = SystemColors.MenuHighlight
        Button2.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight
        Button2.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight
        Button2.Name = "Button2"
        Button2.UseMnemonic = False
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.BackgroundImage = My.Resources.Resources.Prj
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.SkyBlue
        Button1.FlatAppearance.CheckedBackColor = SystemColors.MenuHighlight
        Button1.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight
        Button1.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight
        Button1.Name = "Button1"
        Button1.UseMnemonic = False
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        resources.ApplyResources(Panel3, "Panel3")
        Panel3.BackColor = Color.LightCyan
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Label1)
        Panel3.Name = "Panel3"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' Dash_pm
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Dash_pm"
        ShowIcon = False
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
