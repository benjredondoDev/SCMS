Public Class Form1

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class