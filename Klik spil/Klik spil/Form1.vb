Public Class Form1

    'Hvor mange klik man har
    Dim klik As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        klik += 1
        Label1.Text = klik
    End Sub
End Class
