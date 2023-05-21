Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "server=localhost;uid=root;
                                port=3306;password=48469894;database=schoolclub"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sql = "SELECT * FROM users WHERE username = '" & usernameTxt.Text & "' AND
        password = '" & passwordTxt.Text & "' "
        connect()

        If dr.Read Then

            MsgBox("Login Successfully!")
            Me.Hide()
            Main.Show()

        Else
            MsgBox("Invalid username or password!")
        End If

        conn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to quit", "ISCP Club Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub usernameTxt_TextChanged(sender As Object, e As EventArgs) Handles usernameTxt.TextChanged

    End Sub
End Class