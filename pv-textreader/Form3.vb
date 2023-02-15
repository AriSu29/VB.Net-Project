Imports System.IO

Public Class Form3
    Private Sub openBtn_Click(sender As Object, e As EventArgs) Handles openBtn.Click
        ' Membuat objek dialog untuk membuka file
        Dim openFileDialog1 As New OpenFileDialog()

        ' Mengatur judul dialog dan filter file
        openFileDialog1.Title = "Select a File"
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        ' Menampilkan dialog dan mengambil path file yang dipilih
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            directoryPath.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub searchWordBtn_Click(sender As Object, e As EventArgs) Handles searchWordBtn.Click
        ' Mengambil path file dari input user
        Dim filePath As String = directoryPath.Text

        ' Mengecek apakah file ditemukan
        If Not File.Exists(filePath) Then
            MessageBox.Show("File tidak ditemukan!")
            Return
        End If

        ' Membaca isi file
        Dim fileContent As String = File.ReadAllText(filePath)

        ' Mengambil kata kunci dari input user
        Dim searchWord As String = searchWordTextBox.Text

        ' Mengecek apakah kata kunci diisi
        If String.IsNullOrEmpty(searchWord) Then
            MessageBox.Show("Silakan isi kata kunci!")
            Return
        End If

        ' Mencari kata kunci dalam isi file
        If fileContent.Contains(searchWord) Then
            ' Menampilkan isi file pada teksbox
            textContent.Text = fileContent
        Else
            ' Menampilkan pesan jika kata kunci tidak ditemukan
            textContent.Text = ""
            MessageBox.Show("Kata kunci tidak ditemukan!")
        End If

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        ' Menampilkan form sebelumnya dan menyembunyikan form ini
        Form1.Show()
        Me.Hide()

        ' Mengosongkan input dan teksbox
        directoryPath.Text = ""
        searchWordTextBox.Text = ""
        textContent.Text = ""

    End Sub
End Class