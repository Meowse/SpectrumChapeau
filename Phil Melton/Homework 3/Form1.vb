Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Click, Button1.Click, Button1.TextChanged

        MessageBox.Show(String.Format("Hello, {0}!", TextBox1.Text))

    End Sub


    Private Sub Button1Click(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
