
Imports MySql.Data.MySqlClient

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles LoadDataBtn.Click
        LoadDataForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        LoginForm.Show()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        With cmd
            'Call Connect_to_DB()
            'Dim mycmd As New MySqlCommand
            'Try
            '    strSQL = "Insert into students('"
            '    & .student_id.Text & "', '"
            '    & .fname.Text & "')"
            '    & .lname.Text & "')"
            '    & .contact_number.Text & "')"
            '    & .age.Text & "')"
            '    mycmd.CommandText = strSQL
            '    mycmd.Connection = myconn
            '    mycmd.ExecuteNonQuery()
            '    MsgBox("Record Successfully Added!")
            '    Call Clear_Boxes()
            'Catch ex As MySqlException
            '    MsgBox(ex.Number & " " & ex.Message)
            'End Try
            'Disconnect_to_DB()
        End With
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        With Me
            'Call Connect_to_DB()
            'Dim mycmd As New MySqlCommand
            'Try
            ' strSQL = "Update students set student_id = '" _
            '     & .fname.Text & "' where dnumber = '" _
            '     & .lname.Text & "'"

            'mycmd.CommandText = strSQL
            'mycmd.Connection = myconn
            'mycmd.ExecuteNonQuery()
            'MsgBox("Record Successfully Updated")
            '   Call Clear_Boxes()
            '   Catch ex As MySqlException
            '   MsgBox(ex.Number & " " & ex.Message)
            'End Try
            'Disconnect_to_DB()
        End With
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        With Me
            'Call Connect_to_DB()
            'Dim mycmd As New MySqlCommand
            'Try
                'Dim answer As MsgBoxResult
                'answer = MsgBox("Are you sure you want to delete this record", MsgBoxStyle.YesNo)
                'If answer = MsgBoxResult.Yes Then
                    'strSQL = "Delete from students" _
                                '& " where dnumber = '" _
                                '& .student_ID.Text & "'"
                    'MsgBox(strSQL)
                    'mycmd.CommandText = strSQL
                    'mycmd.Connection = myconn
                    'mycmd.ExecuteNonQuery()
                    'MsgBox("Record Successfully Deleted")
                    'Call Clear_Boxes()
                'End If

            'Catch ex As MySqlException
                'MsgBox(ex.Number & " " & ex.Message)
            'End Try
            'Disconnect_to_DB()
        End With
    End Sub

    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click

    End Sub
End Class