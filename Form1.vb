Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Image.FromFile("\\HQPROFILES\HQUP$\2271\Desktop\20170919133247-GettyImages-607980182.jpeg")
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class
