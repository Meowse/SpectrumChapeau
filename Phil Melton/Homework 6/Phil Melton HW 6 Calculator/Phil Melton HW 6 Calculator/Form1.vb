﻿Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Button1Click(sender As Object, e As EventArgs) Handles clear.Click

        Display.Clear()
    End Sub


    Private Sub Button5Click(sender As Object, e As EventArgs) Handles Button5.Click

        Display.Text = Display.Text + Button5.Text
    End Sub

    Private Sub Button6Click(sender As Object, e As EventArgs) Handles Button6.Click

        Display.Text = Display.Text + Button6.Text
    End Sub

    Private Sub Button7Click(sender As Object, e As EventArgs) Handles Button7.Click

        Display.Text = Display.Text + Button7.Text
    End Sub


    Private Sub Button8Click(sender As Object, e As EventArgs) Handles add.Click


        Display.Clear()

    End Sub

    Private Sub Button9Click(sender As Object, e As EventArgs) Handles Button9.Click

        Display.Text = Display.Text + Button9.Text
    End Sub

    Private Sub Button10Click(sender As Object, e As EventArgs) Handles Button10.Click

        Display.Text = Display.Text + Button10.Text
    End Sub

    Private Sub Button11Click(sender As Object, e As EventArgs) Handles Button11.Click

        Display.Text = Display.Text + Button11.Text
    End Sub

    Private Sub Button12Click(sender As Object, e As EventArgs) Handles subtract.Click

        Display.Text = subtract.Text
    End Sub

    Private Sub Button13Click(sender As Object, e As EventArgs) Handles Button13.Click

        Display.Text = Display.Text + Button13.Text
    End Sub

    Private Sub Button14Click(sender As Object, e As EventArgs) Handles Button14.Click

        Display.Text = Display.Text + Button14.Text
    End Sub

    Private Sub Button15Click(sender As Object, e As EventArgs) Handles Button15.Click

        Display.Text = Display.Text + Button15.Text
    End Sub

    Private Sub Button16Click(sender As Object, e As EventArgs) Handles multiply.Click

        Display.Text = multiply.Text
    End Sub

    Private Sub Button17Click(sender As Object, e As EventArgs) Handles Button17.Click

        Display.Text = Button17.Text
    End Sub

    Private Sub Button18Click(sender As Object, e As EventArgs) Handles dot.Click

        Display.Text = dot.Text
    End Sub

    Private Sub Button19Click(sender As Object, e As EventArgs) Handles Button19.Click

        Display.Text = Button19.Text
    End Sub

    Private Sub Button20Click(sender As Object, e As EventArgs) Handles divide.Click

        Display.Text = divide.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Display.TextChanged
    End Sub
End Class
