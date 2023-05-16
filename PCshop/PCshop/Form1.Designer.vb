<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        LabelError = New Label()
        IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        showPass = New CheckBox()
        TextBoxPassword = New TextBox()
        TextBoxUsername = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(105), CByte(141))
        Panel1.Controls.Add(LabelError)
        Panel1.Controls.Add(IconPictureBox4)
        Panel1.Controls.Add(IconPictureBox3)
        Panel1.Controls.Add(IconPictureBox2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(IconButton1)
        Panel1.Controls.Add(showPass)
        Panel1.Controls.Add(TextBoxPassword)
        Panel1.Controls.Add(TextBoxUsername)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(147, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(336, 426)
        Panel1.TabIndex = 0
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
        IconPictureBox4.Location = New Point(198, 368)
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
        IconPictureBox3.Location = New Point(160, 368)
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
        IconPictureBox2.Location = New Point(122, 368)
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
        LinkLabel1.Location = New Point(96, 304)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(151, 13)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "create new account"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("SimSun", 10.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(160, 290)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 14)
        Label2.TabIndex = 6
        Label2.Text = "or"
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.White
        IconButton1.Cursor = Cursors.Hand
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.O
        IconButton1.IconColor = Color.Empty
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(96, 253)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(145, 34)
        IconButton1.TabIndex = 5
        IconButton1.Text = "Login"
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' showPass
        ' 
        showPass.AutoSize = True
        showPass.Cursor = Cursors.Hand
        showPass.ForeColor = SystemColors.ButtonHighlight
        showPass.Location = New Point(178, 216)
        showPass.Name = "showPass"
        showPass.RightToLeft = RightToLeft.Yes
        showPass.Size = New Size(108, 19)
        showPass.TabIndex = 4
        showPass.Text = "Show password"
        showPass.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.BorderStyle = BorderStyle.FixedSingle
        TextBoxPassword.Cursor = Cursors.IBeam
        TextBoxPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPassword.Location = New Point(63, 183)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PlaceholderText = "Password"
        TextBoxPassword.Size = New Size(223, 27)
        TextBoxPassword.TabIndex = 3
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.BorderStyle = BorderStyle.FixedSingle
        TextBoxUsername.Cursor = Cursors.IBeam
        TextBoxUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxUsername.Location = New Point(63, 127)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.PlaceholderText = "Username"
        TextBoxUsername.Size = New Size(223, 27)
        TextBoxUsername.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(118, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 19)
        Label1.TabIndex = 0
        Label1.Text = "User Login"
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.Controls.Add(Panel1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(635, 490)
        Panel2.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(39), CByte(38), CByte(67))
        ClientSize = New Size(635, 490)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Log In"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents showPass As CheckBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelError As Label
End Class
