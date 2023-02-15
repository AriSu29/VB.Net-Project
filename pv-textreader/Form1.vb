Public Class Form1
    Private Sub TextBoxNama_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            LabelWelcome.Text = "WELCOME, " & TextBoxNama.Text.ToUpper()
            TextBoxNama.Text = ""
            labelPressEnter.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelPressEnter.Visible = Not labelPressEnter.Visible
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If TextBoxNama.TextLength > 0 Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
            labelPressEnter.Visible = False
        End If
    End Sub

    Private Sub TextBoxNama_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNama.TextChanged
        If TextBoxNama.TextLength > 0 Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
            labelPressEnter.Visible = False
        End If
    End Sub

    Private Sub readBtn_Click(sender As Object, e As EventArgs) Handles readBtn.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
