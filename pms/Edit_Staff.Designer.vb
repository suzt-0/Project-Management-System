<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Staff
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
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        name_txt = New TextBox()
        age_txt = New TextBox()
        dept_txt = New TextBox()
        password_txt = New TextBox()
        Button1 = New Button()
        Label9 = New Label()
        id_txt = New TextBox()
        mobile_txt = New TextBox()
        Label10 = New Label()
        Del_btn = New Button()
        Del_id_txt = New TextBox()
        Label11 = New Label()
        Del_mobile_txt = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Del_password_txt = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1166, 95)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Crimson
        Button2.FlatAppearance.BorderColor = Color.LightCyan
        Button2.FlatAppearance.MouseDownBackColor = Color.Black
        Button2.FlatAppearance.MouseOverBackColor = Color.Black
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(36, 32)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 36)
        Button2.TabIndex = 1
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(392, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(457, 60)
        Label1.TabIndex = 0
        Label1.Text = "Edit Staff Information"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(257, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 38)
        Label2.TabIndex = 1
        Label2.Text = "Staff info"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 148)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(708, 276)
        DataGridView1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(821, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 31)
        Label3.TabIndex = 3
        Label3.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(842, 261)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 31)
        Label4.TabIndex = 4
        Label4.Text = "Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(757, 306)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 31)
        Label5.TabIndex = 5
        Label5.Text = "Department"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(810, 351)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 31)
        Label6.TabIndex = 6
        Label6.Text = "Mobile"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(785, 396)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 31)
        Label7.TabIndex = 7
        Label7.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(881, 98)
        Label8.Name = "Label8"
        Label8.Size = New Size(237, 38)
        Label8.TabIndex = 8
        Label8.Text = "Update Staff Info"
        ' 
        ' name_txt
        ' 
        name_txt.Cursor = Cursors.IBeam
        name_txt.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        name_txt.Location = New Point(929, 216)
        name_txt.Name = "name_txt"
        name_txt.Size = New Size(189, 31)
        name_txt.TabIndex = 9
        ' 
        ' age_txt
        ' 
        age_txt.Cursor = Cursors.IBeam
        age_txt.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        age_txt.Location = New Point(929, 261)
        age_txt.Name = "age_txt"
        age_txt.Size = New Size(189, 31)
        age_txt.TabIndex = 10
        ' 
        ' dept_txt
        ' 
        dept_txt.Cursor = Cursors.IBeam
        dept_txt.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        dept_txt.Location = New Point(929, 306)
        dept_txt.Name = "dept_txt"
        dept_txt.Size = New Size(189, 31)
        dept_txt.TabIndex = 11
        ' 
        ' password_txt
        ' 
        password_txt.Cursor = Cursors.IBeam
        password_txt.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        password_txt.Location = New Point(929, 396)
        password_txt.Name = "password_txt"
        password_txt.Size = New Size(189, 31)
        password_txt.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(984, 435)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 14
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(831, 148)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 28)
        Label9.TabIndex = 15
        Label9.Text = "Enter id:"
        ' 
        ' id_txt
        ' 
        id_txt.Cursor = Cursors.IBeam
        id_txt.Location = New Point(930, 148)
        id_txt.Name = "id_txt"
        id_txt.Size = New Size(67, 27)
        id_txt.TabIndex = 16
        ' 
        ' mobile_txt
        ' 
        mobile_txt.Cursor = Cursors.IBeam
        mobile_txt.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        mobile_txt.Location = New Point(930, 352)
        mobile_txt.Name = "mobile_txt"
        mobile_txt.Size = New Size(188, 31)
        mobile_txt.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(12, 432)
        Label10.Name = "Label10"
        Label10.Size = New Size(191, 28)
        Label10.TabIndex = 18
        Label10.Text = "Delete Staff records"
        ' 
        ' Del_btn
        ' 
        Del_btn.Cursor = Cursors.Hand
        Del_btn.Location = New Point(123, 599)
        Del_btn.Name = "Del_btn"
        Del_btn.Size = New Size(94, 29)
        Del_btn.TabIndex = 19
        Del_btn.Text = "Delete"
        Del_btn.UseVisualStyleBackColor = True
        ' 
        ' Del_id_txt
        ' 
        Del_id_txt.Cursor = Cursors.IBeam
        Del_id_txt.Location = New Point(123, 483)
        Del_id_txt.Name = "Del_id_txt"
        Del_id_txt.Size = New Size(134, 27)
        Del_id_txt.TabIndex = 20
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(52, 479)
        Label11.Name = "Label11"
        Label11.Size = New Size(30, 28)
        Label11.TabIndex = 21
        Label11.Text = "Id"
        ' 
        ' Del_mobile_txt
        ' 
        Del_mobile_txt.Cursor = Cursors.IBeam
        Del_mobile_txt.Location = New Point(123, 519)
        Del_mobile_txt.Name = "Del_mobile_txt"
        Del_mobile_txt.Size = New Size(134, 27)
        Del_mobile_txt.TabIndex = 22
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(26, 519)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 28)
        Label12.TabIndex = 23
        Label12.Text = "Mobile"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(12, 558)
        Label13.Name = "Label13"
        Label13.Size = New Size(97, 28)
        Label13.TabIndex = 24
        Label13.Text = "Password"
        ' 
        ' Del_password_txt
        ' 
        Del_password_txt.Cursor = Cursors.IBeam
        Del_password_txt.Location = New Point(123, 558)
        Del_password_txt.Name = "Del_password_txt"
        Del_password_txt.Size = New Size(134, 27)
        Del_password_txt.TabIndex = 25
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SteelBlue
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderColor = Color.SteelBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(1028, 148)
        Button3.Name = "Button3"
        Button3.Size = New Size(67, 28)
        Button3.TabIndex = 26
        Button3.Text = "Enter"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.SteelBlue
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderColor = Color.SteelBlue
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(501, 435)
        Button4.Name = "Button4"
        Button4.Size = New Size(143, 36)
        Button4.TabIndex = 27
        Button4.Text = "Refresh table"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Edit_Staff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(1166, 640)
        ControlBox = False
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Del_password_txt)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Del_mobile_txt)
        Controls.Add(Label11)
        Controls.Add(Del_id_txt)
        Controls.Add(Del_btn)
        Controls.Add(Label10)
        Controls.Add(mobile_txt)
        Controls.Add(id_txt)
        Controls.Add(Label9)
        Controls.Add(Button1)
        Controls.Add(password_txt)
        Controls.Add(dept_txt)
        Controls.Add(age_txt)
        Controls.Add(name_txt)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Cursor = Cursors.Arrow
        Name = "Edit_Staff"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Staff Information"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents name_txt As TextBox
    Friend WithEvents age_txt As TextBox
    Friend WithEvents dept_txt As TextBox
    Friend WithEvents password_txt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents id_txt As TextBox
    Friend WithEvents mobile_txt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Del_btn As Button
    Friend WithEvents Del_id_txt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Del_mobile_txt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Del_password_txt As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
