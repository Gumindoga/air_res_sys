Public Class frmLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String
        Dim password As String

        username = TextBox1.Text
        password = TextBox2.Text

        If username = "admin" And password = "adminpass" Then
            MessageBox.Show("Login Success", "Information")
            frmMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong login details", "Error")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
