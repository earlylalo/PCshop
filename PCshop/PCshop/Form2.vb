Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click

        If createUsername.Text = "" And createPassword.Text = "" Then

            LabelError.Visible = True
            createUsername.BackColor = Color.Red
            createPassword.BackColor = Color.Red
            createAge.BackColor = Color.Red
            createLastname.BackColor = Color.Red

        ElseIf createUsername.Text = "" Then

            LabelError.Visible = True
            createUsername.BackColor = Color.Red
            createPassword.BackColor = Color.White
            createAge.BackColor = Color.White
            createLastname.BackColor = Color.White

        ElseIf createPassword.Text = "" Then

            LabelError.Visible = True
            createPassword.BackColor = Color.Red
            createUsername.BackColor = Color.White
            createAge.BackColor = Color.White
            createLastname.BackColor = Color.White

        ElseIf createLastname.Text = "" Then

            LabelError.Visible = True
            createPassword.BackColor = Color.White
            createUsername.BackColor = Color.White
            createAge.BackColor = Color.White
            createLastname.BackColor = Color.Red

        ElseIf createAge.Text = "" Then

            LabelError.Visible = True
            createPassword.BackColor = Color.White
            createUsername.BackColor = Color.White
            createAge.BackColor = Color.Red
            createLastname.BackColor = Color.White

        Else

            Call DB_CONNECT()

            Dim SQLcommand As MySqlCommand

            SQLcommand = New MySqlCommand("INSERT INTO users(userName, lastName, password, age) values('" & createUsername.Text & "', '" & createLastname.Text & "', '" & createPassword.Text & "', '" & createAge.Text & "')", conn)
            SQLcommand.ExecuteNonQuery()

            MessageBox.Show("New user created!", "Succesful!")

            conn.Close()


        End If

    End Sub

    Private Sub showPass_CheckedChanged(sender As Object, e As EventArgs) Handles showPass.CheckedChanged
        If showPass.Checked = True Then
            createPassword.UseSystemPasswordChar = False
        Else
            createPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class