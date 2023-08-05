<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prj_create
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
        create = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Pname = New TextBox()
        password_txt = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' create
        ' 
        create.BackColor = Color.RoyalBlue
        create.Cursor = Cursors.Hand
        create.FlatAppearance.BorderColor = Color.RoyalBlue
        create.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        create.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        create.FlatStyle = FlatStyle.Popup
        create.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        create.ForeColor = SystemColors.ButtonHighlight
        create.Location = New Point(197, 316)
        create.Name = "create"
        create.Size = New Size(139, 47)
        create.TabIndex = 0
        create.Text = "Create"
        create.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(197, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 41)
        Label1.TabIndex = 1
        Label1.Text = "Create New Project"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(30, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 31)
        Label2.TabIndex = 2
        Label2.Text = "Project Name :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(0, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 31)
        Label3.TabIndex = 3
        Label3.Text = "Project Deadline :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(73, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 31)
        Label5.TabIndex = 5
        Label5.Text = "Password :"
        ' 
        ' Pname
        ' 
        Pname.Location = New Point(242, 106)
        Pname.Name = "Pname"
        Pname.Size = New Size(250, 27)
        Pname.TabIndex = 6
        ' 
        ' password_txt
        ' 
        password_txt.Location = New Point(242, 240)
        password_txt.Name = "password_txt"
        password_txt.Size = New Size(250, 27)
        password_txt.TabIndex = 8
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(242, 173)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.FlatAppearance.BorderColor = Color.SkyBlue
        Button1.FlatAppearance.MouseDownBackColor = Color.Black
        Button1.FlatAppearance.MouseOverBackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(20, 17)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 38)
        Button1.TabIndex = 10
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Prj_create
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(537, 389)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(password_txt)
        Controls.Add(Pname)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(create)
        MaximizeBox = False
        Name = "Prj_create"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create new project"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents create As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Pname As TextBox
    Friend WithEvents password_txt As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
