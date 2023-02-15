Imports System.IO

Public Class Form3
    Private Sub openBtn_Click(sender As Object, e As EventArgs) Handles openBtn.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Title = "Select a File"
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            directoryPath.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub searchWordBtn_Click(sender As Object, e As EventArgs) Handles searchWordBtn.Click
        ' Buka file dan baca isi file
        Dim filePath As String = directoryPath.Text
        Dim fileContent As String = ""
        If File.Exists(filePath) Then
            fileContent = File.ReadAllText(filePath)
        Else
            MessageBox.Show("File tidak ditemukan!")
            Return
        End If

        ' Cari kata kunci dalam file
        Dim searchWord As String = searchWordTextBox.Text
        If Not String.IsNullOrEmpty(searchWord) Then

            ' Periksa apakah kata kunci ditemukan
            If fileContent.Contains(searchWord) Then
                textContent.Text = fileContent
            Else
                textContent.Text = ""
                MessageBox.Show("Kata kunci tidak ditemukan!")

            End If
        End If

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Form1.Show()
        Me.Hide()
        directoryPath.Text = ""
        searchWordTextBox.Text = ""
        textContent.Text = ""

    End Sub
End Class