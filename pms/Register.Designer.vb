<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Register_form))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        name_txt = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        address_txt = New TextBox()
        Department_txt = New TextBox()
        Label7 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Label9 = New Label()
        Label8 = New Label()
        pwd_txt = New TextBox()
        mobile_txt = New TextBox()
        Type_txt = New TextBox()
        Label6 = New Label()
        age_txt = New TextBox()
        Reg_btn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(152, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 54)
        Label1.TabIndex = 0
        Label1.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(50, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 23)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(65, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 23)
        Label3.TabIndex = 3
        Label3.Text = "Age"
        ' 
        ' name_txt
        ' 
        name_txt.BackColor = Color.LightGray
        name_txt.BorderStyle = BorderStyle.FixedSingle
        name_txt.Cursor = Cursors.Hand
        name_txt.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        name_txt.Location = New Point(121, 126)
        name_txt.Name = "name_txt"
        name_txt.PlaceholderText = "Eg: Sujit Bhattarai"
        name_txt.Size = New Size(239, 25)
        name_txt.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(36, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 23)
        Label4.TabIndex = 6
        Label4.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(42, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 23)
        Label5.TabIndex = 10
        Label5.Text = "mobile"
        ' 
        ' address_txt
        ' 
        address_txt.BackColor = Color.LightGray
        address_txt.BorderStyle = BorderStyle.FixedSingle
        address_txt.Cursor = Cursors.Hand
        address_txt.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        address_txt.Location = New Point(121, 198)
        address_txt.Name = "address_txt"
        address_txt.PlaceholderText = "Eg: Bhaktapur"
        address_txt.Size = New Size(239, 25)
        address_txt.TabIndex = 11
        ' 
        ' Department_txt
        ' 
        Department_txt.BackColor = Color.LightGray
        Department_txt.BorderStyle = BorderStyle.FixedSingle
        Department_txt.Cursor = Cursors.Hand
        Department_txt.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Department_txt.Location = New Point(121, 270)
        Department_txt.Name = "Department_txt"
        Department_txt.PlaceholderText = "Eg: Design, management,..."
        Department_txt.Size = New Size(239, 25)
        Department_txt.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(9, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 23)
        Label7.TabIndex = 15
        Label7.Text = "Department"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(pwd_txt)
        Panel1.Controls.Add(mobile_txt)
        Panel1.Controls.Add(Type_txt)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(age_txt)
        Panel1.Controls.Add(Reg_btn)
        Panel1.Controls.Add(Department_txt)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(name_txt)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(address_txt)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(-4, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(443, 615)
        Panel1.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.FlatAppearance.BorderColor = Color.Crimson
        Button1.FlatAppearance.MouseDownBackColor = Color.Black
        Button1.FlatAppearance.MouseOverBackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(9, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 33)
        Button1.TabIndex = 28
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.GrayText
        Label9.Location = New Point(28, 438)
        Label9.Name = "Label9"
        Label9.Size = New Size(385, 140)
        Label9.TabIndex = 27
        Label9.Text = resources.GetString("Label9.Text")
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label8.Location = New Point(28, 350)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 23)
        Label8.TabIndex = 26
        Label8.Text = "Password"
        ' 
        ' pwd_txt
        ' 
        pwd_txt.BackColor = Color.LightGray
        pwd_txt.BorderStyle = BorderStyle.FixedSingle
        pwd_txt.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        pwd_txt.Location = New Point(121, 342)
        pwd_txt.Name = "pwd_txt"
        pwd_txt.PlaceholderText = "Eg : 12345"
        pwd_txt.Size = New Size(239, 25)
        pwd_txt.TabIndex = 25
        ' 
        ' mobile_txt
        ' 
        mobile_txt.BackColor = Color.LightGray
        mobile_txt.BorderStyle = BorderStyle.FixedSingle
        mobile_txt.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        mobile_txt.Location = New Point(121, 234)
        mobile_txt.Name = "mobile_txt"
        mobile_txt.PlaceholderText = "Eg: 98*********"
        mobile_txt.Size = New Size(239, 25)
        mobile_txt.TabIndex = 24
        ' 
        ' Type_txt
        ' 
        Type_txt.BackColor = Color.LightGray
        Type_txt.BorderStyle = BorderStyle.FixedSingle
        Type_txt.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Type_txt.Location = New Point(121, 306)
        Type_txt.Name = "Type_txt"
        Type_txt.PlaceholderText = " Staff or Project Manager"
        Type_txt.Size = New Size(239, 25)
        Type_txt.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(58, 314)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 23)
        Label6.TabIndex = 22
        Label6.Text = "Type"
        ' 
        ' age_txt
        ' 
        age_txt.BackColor = Color.LightGray
        age_txt.BorderStyle = BorderStyle.FixedSingle
        age_txt.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        age_txt.Location = New Point(121, 162)
        age_txt.Name = "age_txt"
        age_txt.PlaceholderText = "Eg: 30"
        age_txt.Size = New Size(239, 25)
        age_txt.TabIndex = 21
        ' 
        ' Reg_btn
        ' 
        Reg_btn.BackColor = Color.Transparent
        Reg_btn.BackgroundImageLayout = ImageLayout.None
        Reg_btn.Cursor = Cursors.Hand
        Reg_btn.FlatAppearance.BorderColor = Color.SkyBlue
        Reg_btn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        Reg_btn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        Reg_btn.FlatStyle = FlatStyle.Flat
        Reg_btn.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Reg_btn.ForeColor = SystemColors.ActiveCaptionText
        Reg_btn.Location = New Point(152, 373)
        Reg_btn.Name = "Reg_btn"
        Reg_btn.Size = New Size(129, 47)
        Reg_btn.TabIndex = 18
        Reg_btn.Text = "Register"
        Reg_btn.UseVisualStyleBackColor = False
        ' 
        ' Register_form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(432, 612)
        ControlBox = False
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Register_form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents name_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents address_txt As TextBox
    Friend WithEvents Department_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Reg_btn As Button
    Friend WithEvents age_txt As TextBox
    Friend WithEvents mobile_txt As TextBox
    Friend WithEvents Type_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pwd_txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
End Class
