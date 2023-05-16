<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel2 = New Panel()
        Panel1 = New Panel()
        createAge = New TextBox()
        createLastname = New TextBox()
        LabelError = New Label()
        IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        createBtn = New FontAwesome.Sharp.IconButton()
        showPass = New CheckBox()
        createPassword = New TextBox()
        createUsername = New TextBox()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel1)
        Panel2.Location = New Point(38, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(423, 512)
        Panel2.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(105), CByte(141))
        Panel1.Controls.Add(createAge)
        Panel1.Controls.Add(createLastname)
        Panel1.Controls.Add(LabelError)
        Panel1.Controls.Add(IconPictureBox4)
        Panel1.Controls.Add(IconPictureBox3)
        Panel1.Controls.Add(IconPictureBox2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(createBtn)
        Panel1.Controls.Add(showPass)
        Panel1.Controls.Add(createPassword)
        Panel1.Controls.Add(createUsername)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(36, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(344, 492)
        Panel1.TabIndex = 0
        ' 
        ' createAge
        ' 
        createAge.BorderStyle = BorderStyle.FixedSingle
        createAge.Cursor = Cursors.Hand
        createAge.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        createAge.Location = New Point(63, 222)
        createAge.Name = "createAge"
        createAge.PlaceholderText = "Age"
        createAge.Size = New Size(223, 27)
        createAge.TabIndex = 14
        ' 
        ' createLastname
        ' 
        createLastname.BorderStyle = BorderStyle.FixedSingle
        createLastname.Cursor = Cursors.Hand
        createLastname.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        createLastname.Location = New Point(63, 178)
        createLastname.Name = "createLastname"
        createLastname.PlaceholderText = "Last Name"
        createLastname.Size = New Size(223, 27)
        createLastname.TabIndex = 13
        ' 
        ' LabelError
        ' 
        LabelError.AutoSize = True
        LabelError.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelError.ForeColor = Color.Red
        LabelError.Location = New Point(96, 89)
        LabelError.Name = "LabelError"
        LabelError.Size = New Size(151, 20)
        LabelError.TabIndex = 12
        LabelError.Text = "Error! Fields required!"
        LabelError.Visible = False
        ' 
        ' IconPictureBox4
        ' 
        IconPictureBox4.BackColor = Color.FromArgb(CByte(44), CByte(105), CByte(141))
        IconPictureBox4.Cursor = Cursors.Hand
        IconPictureBox4.ForeColor = Color.Yellow
        IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Twitter
        IconPictureBox4.IconColor = Color.Yellow
        IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox4.IconSize = 28
        IconPictureBox4.Location = New Point(199, 445)
        IconPictureBox4.Name = "IconPictureBox4"
        IconPictureBox4.Size = New Size(32, 28)
        IconPictureBox4.TabIndex = 11
        IconPictureBox4.TabStop = False
        ' 
        ' IconPictureBox3
        ' 
        IconPictureBox3.BackColor = Color.FromArgb(CByte(44), CByte(105), CByte(141))
        IconPictureBox3.Cursor = Cursors.Hand
        IconPictureBox3.ForeColor = Color.Yellow
        IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Instagram
        IconPictureBox3.IconColor = Color.Yellow
        IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox3.IconSize = 28
        IconPictureBox3.Location = New Point(161, 445)
        IconPictureBox3.Name = "IconPictureBox3"
        IconPictureBox3.Size = New Size(32, 28)
        IconPictureBox3.TabIndex = 10
        IconPictureBox3.TabStop = False
        ' 
        ' IconPictureBox2
        ' 
        IconPictureBox2.BackColor = Color.FromArgb(CByte(44), CByte(105), CByte(141))
        IconPictureBox2.Cursor = Cursors.Hand
        IconPictureBox2.ForeColor = Color.Yellow
        IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Facebook
        IconPictureBox2.IconColor = Color.Yellow
        IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox2.IconSize = 28
        IconPictureBox2.Location = New Point(123, 445)
        IconPictureBox2.Name = "IconPictureBox2"
        IconPictureBox2.Size = New Size(32, 28)
        IconPictureBox2.TabIndex = 9
        IconPictureBox2.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Blue
        LinkLabel1.AutoSize = True
        LinkLabel1.Cursor = Cursors.Hand
        LinkLabel1.Font = New Font("SimSun", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.FromArgb(CByte(186), CByte(232), CByte(232))
        LinkLabel1.Location = New Point(84, 408)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(167, 13)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "login to an acccount"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("SimSun", 10.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(160, 394)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 14)
        Label2.TabIndex = 6
        Label2.Text = "or"
        ' 
        ' createBtn
        ' 
        createBtn.Cursor = Cursors.Hand
        createBtn.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        createBtn.IconChar = FontAwesome.Sharp.IconChar.O
        createBtn.IconColor = Color.Empty
        createBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        createBtn.Location = New Point(96, 357)
        createBtn.Name = "createBtn"
        createBtn.Size = New Size(145, 34)
        createBtn.TabIndex = 5
        createBtn.Text = "Create"
        createBtn.UseVisualStyleBackColor = True
        ' 
        ' showPass
        ' 
        showPass.AutoSize = True
        showPass.Cursor = Cursors.Hand
        showPass.ForeColor = SystemColors.ButtonHighlight
        showPass.Location = New Point(178, 301)
        showPass.Name = "showPass"
        showPass.RightToLeft = RightToLeft.Yes
        showPass.Size = New Size(108, 19)
        showPass.TabIndex = 4
        showPass.Text = "Show password"
        showPass.UseVisualStyleBackColor = True
        ' 
        ' createPassword
        ' 
        createPassword.BorderStyle = BorderStyle.FixedSingle
        createPassword.Cursor = Cursors.Hand
        createPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        createPassword.Location = New Point(63, 268)
        createPassword.Name = "createPassword"
        createPassword.PlaceholderText = "Password"
        createPassword.Size = New Size(223, 27)
        createPassword.TabIndex = 3
        createPassword.UseSystemPasswordChar = True
        ' 
        ' createUsername
        ' 
        createUsername.BorderStyle = BorderStyle.FixedSingle
        createUsername.Cursor = Cursors.Hand
        createUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        createUsername.Location = New Point(63, 127)
        createUsername.Name = "createUsername"
        createUsername.PlaceholderText = "Username"
        createUsername.Size = New Size(223, 27)
        createUsername.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(84, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 19)
        Label1.TabIndex = 0
        Label1.Text = "Create Account"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(39), CByte(38), CByte(67))
        ClientSize = New Size(517, 536)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form2"
        Text = "Create account"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelError As Label
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents createBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents showPass As CheckBox
    Friend WithEvents createPassword As TextBox
    Friend WithEvents createUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents createLastname As TextBox
    Friend WithEvents createAge As TextBox
End Class
