<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        SplitContainer1 = New SplitContainer()
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblAge = New Label()
        lblLastname = New Label()
        lblUsername = New Label()
        SplitContainer4 = New SplitContainer()
        lblFilePath = New TextBox()
        Button4 = New Button()
        Backup = New Button()
        Button1 = New Button()
        SplitContainer2 = New SplitContainer()
        prodError = New Label()
        prodPrice = New TextBox()
        prodDescription = New TextBox()
        Panel5 = New Panel()
        Label1 = New Label()
        prodName = New TextBox()
        Panel4 = New Panel()
        SplitContainer3 = New SplitContainer()
        Button2 = New Button()
        Panel3 = New Panel()
        lblYourRecord = New Label()
        dbData = New DataGridView()
        Panel2 = New Panel()
        PrintBTN = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer4, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer4.Panel1.SuspendLayout()
        SplitContainer4.Panel2.SuspendLayout()
        SplitContainer4.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(SplitContainer3, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer3.Panel2.SuspendLayout()
        SplitContainer3.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dbData, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(55), CByte(131), CByte(174))
        Panel1.Controls.Add(SplitContainer1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(878, 99)
        Panel1.TabIndex = 0
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(lblAge)
        SplitContainer1.Panel1.Controls.Add(lblLastname)
        SplitContainer1.Panel1.Controls.Add(lblUsername)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer4)
        SplitContainer1.Size = New Size(878, 99)
        SplitContainer1.SplitterDistance = 305
        SplitContainer1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(49, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 17)
        Label4.TabIndex = 10
        Label4.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(15, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 17)
        Label2.TabIndex = 9
        Label2.Text = "Lastname:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 17)
        Label3.TabIndex = 8
        Label3.Text = "Username:"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblAge.ForeColor = Color.White
        lblAge.Location = New Point(88, 61)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(42, 23)
        lblAge.TabIndex = 7
        lblAge.Text = "Age"
        ' 
        ' lblLastname
        ' 
        lblLastname.AutoSize = True
        lblLastname.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblLastname.ForeColor = Color.White
        lblLastname.Location = New Point(90, 34)
        lblLastname.Name = "lblLastname"
        lblLastname.Size = New Size(96, 23)
        lblLastname.TabIndex = 6
        lblLastname.Text = "LastName"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(90, 9)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(97, 23)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' SplitContainer4
        ' 
        SplitContainer4.Dock = DockStyle.Fill
        SplitContainer4.Location = New Point(0, 0)
        SplitContainer4.Name = "SplitContainer4"
        ' 
        ' SplitContainer4.Panel1
        ' 
        SplitContainer4.Panel1.Controls.Add(lblFilePath)
        SplitContainer4.Panel1.Controls.Add(Button4)
        ' 
        ' SplitContainer4.Panel2
        ' 
        SplitContainer4.Panel2.Controls.Add(Backup)
        SplitContainer4.Size = New Size(569, 99)
        SplitContainer4.SplitterDistance = 389
        SplitContainer4.TabIndex = 0
        ' 
        ' lblFilePath
        ' 
        lblFilePath.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblFilePath.BorderStyle = BorderStyle.FixedSingle
        lblFilePath.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblFilePath.ForeColor = Color.Black
        lblFilePath.Location = New Point(100, 27)
        lblFilePath.Name = "lblFilePath"
        lblFilePath.Size = New Size(239, 25)
        lblFilePath.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(39), CByte(38), CByte(67))
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.Gray
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.White
        Button4.Location = New Point(13, 21)
        Button4.Name = "Button4"
        Button4.Size = New Size(81, 40)
        Button4.TabIndex = 0
        Button4.Text = "Open a File"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Backup
        ' 
        Backup.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Backup.BackColor = Color.FromArgb(CByte(39), CByte(38), CByte(67))
        Backup.Cursor = Cursors.Hand
        Backup.FlatAppearance.BorderSize = 0
        Backup.FlatAppearance.MouseOverBackColor = Color.Black
        Backup.FlatStyle = FlatStyle.Flat
        Backup.ForeColor = Color.White
        Backup.Location = New Point(27, 23)
        Backup.Name = "Backup"
        Backup.Size = New Size(126, 55)
        Backup.TabIndex = 2
        Backup.Text = "Save as Backup File"
        Backup.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(39), CByte(38), CByte(67))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(3, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(142, 32)
        Button1.TabIndex = 0
        Button1.Text = "Show product record"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 99)
        SplitContainer2.Name = "SplitContainer2"
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(prodError)
        SplitContainer2.Panel1.Controls.Add(prodPrice)
        SplitContainer2.Panel1.Controls.Add(prodDescription)
        SplitContainer2.Panel1.Controls.Add(Panel5)
        SplitContainer2.Panel1.Controls.Add(prodName)
        SplitContainer2.Panel1.Controls.Add(Panel4)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(Panel3)
        SplitContainer2.Panel2.Controls.Add(Panel2)
        SplitContainer2.Size = New Size(878, 407)
        SplitContainer2.SplitterDistance = 318
        SplitContainer2.TabIndex = 1
        ' 
        ' prodError
        ' 
        prodError.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        prodError.AutoSize = True
        prodError.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        prodError.ForeColor = Color.Red
        prodError.Location = New Point(3, 58)
        prodError.Name = "prodError"
        prodError.Size = New Size(144, 25)
        prodError.TabIndex = 5
        prodError.Text = "Fields required!"
        prodError.Visible = False
        ' 
        ' prodPrice
        ' 
        prodPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        prodPrice.BorderStyle = BorderStyle.FixedSingle
        prodPrice.Cursor = Cursors.IBeam
        prodPrice.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        prodPrice.Location = New Point(36, 143)
        prodPrice.Name = "prodPrice"
        prodPrice.PlaceholderText = "Product price"
        prodPrice.Size = New Size(239, 27)
        prodPrice.TabIndex = 7
        ' 
        ' prodDescription
        ' 
        prodDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        prodDescription.BorderStyle = BorderStyle.FixedSingle
        prodDescription.Cursor = Cursors.IBeam
        prodDescription.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        prodDescription.Location = New Point(36, 196)
        prodDescription.Multiline = True
        prodDescription.Name = "prodDescription"
        prodDescription.PlaceholderText = "Description"
        prodDescription.Size = New Size(239, 130)
        prodDescription.TabIndex = 6
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label1)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(318, 41)
        Panel5.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(36, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 19)
        Label1.TabIndex = 4
        Label1.Text = "Add a record"
        ' 
        ' prodName
        ' 
        prodName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        prodName.BorderStyle = BorderStyle.FixedSingle
        prodName.Cursor = Cursors.IBeam
        prodName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        prodName.Location = New Point(36, 93)
        prodName.Name = "prodName"
        prodName.PlaceholderText = "Product name"
        prodName.Size = New Size(239, 27)
        prodName.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(SplitContainer3)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 362)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(318, 45)
        Panel4.TabIndex = 0
        ' 
        ' SplitContainer3
        ' 
        SplitContainer3.Dock = DockStyle.Fill
        SplitContainer3.Location = New Point(0, 0)
        SplitContainer3.Name = "SplitContainer3"
        ' 
        ' SplitContainer3.Panel2
        ' 
        SplitContainer3.Panel2.Controls.Add(Button2)
        SplitContainer3.Size = New Size(318, 45)
        SplitContainer3.SplitterDistance = 37
        SplitContainer3.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(39), CByte(38), CByte(67))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(32, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(151, 45)
        Button2.TabIndex = 1
        Button2.Text = "Insert Record"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblYourRecord)
        Panel3.Controls.Add(dbData)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 62)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(556, 345)
        Panel3.TabIndex = 1
        ' 
        ' lblYourRecord
        ' 
        lblYourRecord.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblYourRecord.AutoSize = True
        lblYourRecord.Font = New Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblYourRecord.ForeColor = Color.Black
        lblYourRecord.Location = New Point(107, 12)
        lblYourRecord.Name = "lblYourRecord"
        lblYourRecord.Size = New Size(152, 19)
        lblYourRecord.TabIndex = 5
        lblYourRecord.Text = "lblYourRecord"
        lblYourRecord.Visible = False
        ' 
        ' dbData
        ' 
        dbData.AllowUserToAddRows = False
        dbData.AllowUserToDeleteRows = False
        dbData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dbData.BackgroundColor = Color.FromArgb(CByte(227), CByte(246), CByte(245))
        dbData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dbData.Cursor = Cursors.No
        dbData.GridColor = Color.FromArgb(CByte(186), CByte(232), CByte(232))
        dbData.Location = New Point(0, 34)
        dbData.Name = "dbData"
        dbData.RowTemplate.Height = 25
        dbData.Size = New Size(556, 311)
        dbData.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PrintBTN)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(556, 62)
        Panel2.TabIndex = 0
        ' 
        ' PrintBTN
        ' 
        PrintBTN.BackColor = Color.Lime
        PrintBTN.Cursor = Cursors.Hand
        PrintBTN.Dock = DockStyle.Right
        PrintBTN.FlatAppearance.BorderSize = 0
        PrintBTN.FlatAppearance.MouseOverBackColor = Color.Cyan
        PrintBTN.FlatStyle = FlatStyle.Flat
        PrintBTN.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        PrintBTN.ForeColor = Color.Black
        PrintBTN.Location = New Point(430, 0)
        PrintBTN.Name = "PrintBTN"
        PrintBTN.Size = New Size(126, 62)
        PrintBTN.TabIndex = 3
        PrintBTN.Text = "P R I N T"
        PrintBTN.UseVisualStyleBackColor = False
        PrintBTN.Visible = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(39), CByte(38), CByte(67))
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(170, 9)
        Button3.Name = "Button3"
        Button3.Size = New Size(142, 32)
        Button3.TabIndex = 1
        Button3.Text = "Show user record"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(186), CByte(232), CByte(232))
        ClientSize = New Size(878, 506)
        Controls.Add(SplitContainer2)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Products"
        Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer4.Panel1.ResumeLayout(False)
        SplitContainer4.Panel1.PerformLayout()
        SplitContainer4.Panel2.ResumeLayout(False)
        CType(SplitContainer4, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer4.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        SplitContainer3.Panel2.ResumeLayout(False)
        CType(SplitContainer3, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer3.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dbData, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dbData As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents prodName As TextBox
    Friend WithEvents prodPrice As TextBox
    Friend WithEvents prodDescription As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents prodError As Label
    Friend WithEvents lblYourRecord As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents lblFilePath As TextBox
    Friend WithEvents Backup As Button
    Friend WithEvents PrintBTN As Button
End Class
