<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exit_pjt
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
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Pid_txt = New TextBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(518, 83)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(24, 34)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(158, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 41)
        Label1.TabIndex = 0
        Label1.Text = "Exit Project"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(111, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 32)
        Label2.TabIndex = 1
        Label2.Text = "Pid"
        ' 
        ' Pid_txt
        ' 
        Pid_txt.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Pid_txt.Location = New Point(192, 127)
        Pid_txt.Name = "Pid_txt"
        Pid_txt.Size = New Size(133, 39)
        Pid_txt.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(158, 201)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 57)
        Button1.TabIndex = 4
        Button1.Text = "Exit Project"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Exit_pjt
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(518, 307)
        ControlBox = False
        Controls.Add(Button1)
        Controls.Add(Pid_txt)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Exit_pjt"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Exit Project"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Pid_txt As TextBox
    Friend WithEvents Button1 As Button
End Class
