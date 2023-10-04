Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim L As Double
        Dim H As Double
        Dim A As Double


        L = Val(TextBox1.Text)
        H = Val(TextBox2.Text)
        A = TextBox3.Text


        A = H * L



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim L As Double
        Dim H As Double
        Dim P As Double

        L = Val(TextBox1.Text)
        H = Val(TextBox2.Text)

        P = 2 * (L + H)
        P = TextBox4.Text

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
