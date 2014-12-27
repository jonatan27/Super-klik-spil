Public Class Shop

    'Prisen på en power klik
    Dim powerklikPris As Integer = 100

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.clicks - powerklikPris >= 0 Then
            Form1.clicks -= powerklikPris
            Form1.powerclicks += 1
        End If
    End Sub

    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class