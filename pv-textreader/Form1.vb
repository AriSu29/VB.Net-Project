Public Class Form1
    Private Sub TextBoxNama_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxNama.KeyDown
        'Periksa apakah tombol yang ditekan adalah tombol Enter
        If e.KeyCode = Keys.Enter Then
            'Ubah teks LabelWelcome dengan menggabungkan string "WELCOME, " dengan teks TextBoxNama yang diubah menjadi huruf kapital
            LabelWelcome.Text = "WELCOME, " & TextBoxNama.Text.ToUpper()
            'Kosongkan TextBoxNama
            TextBoxNama.Text = ""
            'Sembunyikan labelPressEnter
            labelPressEnter.Visible = False
        End If
    End Sub

    'Method yang dijalankan ketika Timer1 aktif
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Invert visibility dari labelPressEnter
        labelPressEnter.Visible = Not labelPressEnter.Visible
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Aktifkan Timer1
        Timer1.Start()
    End Sub

    'Method yang dijalankan ketika Form1 muncul
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Periksa apakah TextBoxNama memiliki teks
        If TextBoxNama.TextLength > 0 Then
            'Aktifkan Timer1
            Timer1.Enabled = True
        Else
            'Non-aktifkan Timer1 dan sembunyikan labelPressEnter
            Timer1.Enabled = False
            labelPressEnter.Visible = False
        End If
    End Sub

    'Method yang dijalankan ketika teks di TextBoxNama berubah
    Private Sub TextBoxNama_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNama.TextChanged
        'Periksa apakah TextBoxNama memiliki teks
        If TextBoxNama.TextLength > 0 Then
            'Aktifkan Timer1
            Timer1.Enabled = True
        Else
            'Non-aktifkan Timer1 dan sembunyikan labelPressEnter
            Timer1.Enabled = False
            labelPressEnter.Visible = False
        End If
    End Sub

    'Method yang dijalankan ketika tombol Read pada Form1 diklik
    Private Sub readBtn_Click(sender As Object, e As EventArgs) Handles readBtn.Click
        'Tampilkan Form2 dan sembunyikan Form1
        Form2.Show()
        Me.Hide()
    End Sub

    'Method yang dijalankan ketika tombol Search pada Form1 diklik
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        'Tampilkan Form3 dan sembunyikan Form1
        Form3.Show()
        Me.Hide()
    End Sub

End Class
