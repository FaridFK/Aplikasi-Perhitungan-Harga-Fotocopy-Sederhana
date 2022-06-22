Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListPelanggan.Items.Add("Bukan Pelanggan")
        ListPelanggan.Items.Add("Pelanggan")
    End Sub

    Private Sub BoxCopy_TextChanged(sender As Object, e As EventArgs) Handles BoxCopy.TextChanged
        Dim jmlCopy As Integer = Val(BoxCopy.Text)
        Dim index As Integer = Val(ListPelanggan.SelectedIndex)

        If jmlCopy >= 100 And index <> 0 Then
            LabelLembar.Text = 65

        ElseIf jmlCopy < 100 And index <> 0 Then
            LabelLembar.Text = 70

        ElseIf jmlCopy >= 100 And index = 0 Then
            LabelLembar.Text = 80

        Else
            LabelLembar.Text = 100
        End If
    End Sub

    Private Sub BtnTotal_Click(sender As Object, e As EventArgs) Handles BtnTotal.Click
        Dim jmlCopy As Integer = Val(BoxCopy.Text)
        Dim harga As Integer = Val(LabelLembar.Text)

        LabelTotal.Text = jmlCopy * harga
    End Sub
End Class
