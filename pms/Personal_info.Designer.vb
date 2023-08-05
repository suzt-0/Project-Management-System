<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personal_info
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
        Label3 = New Label()
        lebel = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Name_txt = New TextBox()
        age_txt = New TextBox()
        mbl_txt = New TextBox()
        id_txt = New TextBox()
        Dept_txt = New TextBox()
        type_txt = New TextBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(685, 91)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(128, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(445, 60)
        Label3.TabIndex = 0
        Label3.Text = "Personal Information"
        ' 
        ' lebel
        ' 
        lebel.AutoSize = True
        lebel.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lebel.ForeColor = SystemColors.ActiveCaptionText
        lebel.Location = New Point(100, 263)
        lebel.Name = "lebel"
        lebel.Size = New Size(129, 41)
        lebel.TabIndex = 13
        lebel.Text = "Mobile :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(64, 479)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 41)
        Label6.TabIndex = 5
        Label6.Text = "User Type :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(35, 407)
        Label5.Name = "Label5"
        Label5.Size = New Size(200, 41)
        Label5.TabIndex = 4
        Label5.Text = "Department :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(164, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 41)
        Label4.TabIndex = 3
        Label4.Text = "Id :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(138, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 41)
        Label2.TabIndex = 1
        Label2.Text = "Age :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(113, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 41)
        Label1.TabIndex = 0
        Label1.Text = "Name :"
        ' 
        ' Name_txt
        ' 
        Name_txt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Name_txt.Location = New Point(240, 118)
        Name_txt.Name = "Name_txt"
        Name_txt.Size = New Size(259, 47)
        Name_txt.TabIndex = 15
        ' 
        ' age_txt
        ' 
        age_txt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        age_txt.Location = New Point(240, 191)
        age_txt.Name = "age_txt"
        age_txt.Size = New Size(259, 47)
        age_txt.TabIndex = 16
        ' 
        ' mbl_txt
        ' 
        mbl_txt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        mbl_txt.Location = New Point(240, 265)
        mbl_txt.Name = "mbl_txt"
        mbl_txt.Size = New Size(259, 47)
        mbl_txt.TabIndex = 17
        ' 
        ' id_txt
        ' 
        id_txt.Enabled = False
        id_txt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        id_txt.Location = New Point(240, 337)
        id_txt.Name = "id_txt"
        id_txt.Size = New Size(259, 47)
        id_txt.TabIndex = 18
        ' 
        ' Dept_txt
        ' 
        Dept_txt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Dept_txt.Location = New Point(240, 410)
        Dept_txt.Name = "Dept_txt"
        Dept_txt.Size = New Size(259, 47)
        Dept_txt.TabIndex = 19
        ' 
        ' type_txt
        ' 
        type_txt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        type_txt.Location = New Point(240, 483)
        type_txt.Name = "type_txt"
        type_txt.Size = New Size(259, 47)
        type_txt.TabIndex = 20
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.SkyBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(289, 563)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 50)
        Button1.TabIndex = 21
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Personal_info
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(685, 654)
        Controls.Add(Button1)
        Controls.Add(type_txt)
        Controls.Add(Dept_txt)
        Controls.Add(id_txt)
        Controls.Add(mbl_txt)
        Controls.Add(age_txt)
        Controls.Add(Name_txt)
        Controls.Add(lebel)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = SystemColors.ActiveCaptionText
        MaximizeBox = False
        Name = "Personal_info"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Personal Info"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lebel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Name_txt As TextBox
    Friend WithEvents age_txt As TextBox
    Friend WithEvents mbl_txt As TextBox
    Friend WithEvents id_txt As TextBox
    Friend WithEvents Dept_txt As TextBox
    Friend WithEvents type_txt As TextBox
    Friend WithEvents Button1 As Button
End Class
