Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim [OF] As New OpenFileDialog
        If [OF].ShowDialog = DialogResult.OK Then



            PictureBox1.Image = Image.FromFile([OF].FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
End Class
