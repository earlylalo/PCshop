Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub showPass_CheckedChanged(sender As Object, e As EventArgs) Handles showPass.CheckedChanged
        If showPass.Checked = True Then
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            TextBoxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click


        If TextBoxUsername.Text = "" And TextBoxPassword.Text = "" Then
            LabelError.Visible = True
            TextBoxUsername.BackColor = Color.Red
            TextBoxPassword.BackColor = Color.Red
        ElseIf TextBoxUsername.Text = "" Then
            LabelError.Visible = True
            TextBoxUsername.BackColor = Color.Red
            TextBoxPassword.BackColor = Color.White
        ElseIf TextBoxPassword.Text = "" Then
            LabelError.Visible = True
            TextBoxPassword.BackColor = Color.Red
            TextBoxUsername.BackColor = Color.White

        Else
            Call DB_CONNECT()

            Dim SQLcommand As MySqlCommand
            Dim reader As MySqlDataReader

            'MessageBox.Show("Connection successful")

            SQLcommand = New MySqlCommand("SELECT * FROM users WHERE username = '" & TextBoxUsername.Text & "' AND password = '" & TextBoxPassword.Text & "'", conn)
            reader = SQLcommand.ExecuteReader()

            If reader.HasRows Then
                'Get the information from the database
                Dim frm3 As New Form3()
                If reader.Read() Then
                    frm3.Username = reader("userName").ToString()
                    frm3.Lastname = reader("lastName").ToString()
                    frm3.Age = Convert.ToInt32(reader("age"))
                End If

                

                Me.Hide()
                frm3.Show()


                'MessageBox.Show("Log in successful!", "Success!")
            Else
                    MessageBox.Show("Invalid user", "Error!")
            End If

        End If
        Cursor.Current = Cursors.WaitCursor
        System.Threading.Thread.Sleep(2000)
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()

    End Sub

End Class
