Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2

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

    Private Sub readFileBtn_Click(sender As Object, e As EventArgs) Handles readFileBtn.Click
        ' Baca file yang dipilih
        Dim filePath As String = directoryPath.Text
        If Not File.Exists(filePath) Then
            MessageBox.Show("File tidak ditemukan!")
            Return
        End If

        ' Baca karakter demi karakter dari file dan tambahkan ke textbox
        Dim fileContent As String = ""
        Using reader As New StreamReader(filePath)
            Dim ch As Integer = reader.Read()
            While ch <> -1
                fileContent += ChrW(ch)
                ch = reader.Read()
            End While
        End Using
        textContent.Text = fileContent
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If directoryPath.TextLength > 0 Then
            directoryPath.Text = ""
            textContent.Text = ""
        End If
        Form1.Show()
        Me.Hide()

    End Sub

End Class