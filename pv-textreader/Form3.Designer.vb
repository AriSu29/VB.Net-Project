<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textContent = New System.Windows.Forms.RichTextBox()
        Me.searchWordTextBox = New System.Windows.Forms.TextBox()
        Me.searchWordBtn = New System.Windows.Forms.Button()
        Me.openBtn = New System.Windows.Forms.Button()
        Me.directoryPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(197, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(853, 623)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'textContent
        '
        Me.textContent.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textContent.ForeColor = System.Drawing.Color.Black
        Me.textContent.Location = New System.Drawing.Point(242, 308)
        Me.textContent.Name = "textContent"
        Me.textContent.Size = New System.Drawing.Size(769, 245)
        Me.textContent.TabIndex = 9
        Me.textContent.Text = ""
        '
        'searchWordTextBox
        '
        Me.searchWordTextBox.Font = New System.Drawing.Font("Segoe UI Variable Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchWordTextBox.Location = New System.Drawing.Point(271, 238)
        Me.searchWordTextBox.Name = "searchWordTextBox"
        Me.searchWordTextBox.Size = New System.Drawing.Size(563, 39)
        Me.searchWordTextBox.TabIndex = 8
        '
        'searchWordBtn
        '
        Me.searchWordBtn.BackColor = System.Drawing.Color.MediumTurquoise
        Me.searchWordBtn.Location = New System.Drawing.Point(844, 228)
        Me.searchWordBtn.Name = "searchWordBtn"
        Me.searchWordBtn.Size = New System.Drawing.Size(147, 63)
        Me.searchWordBtn.TabIndex = 7
        Me.searchWordBtn.Text = "Search"
        Me.searchWordBtn.UseVisualStyleBackColor = False
        '
        'openBtn
        '
        Me.openBtn.BackColor = System.Drawing.Color.PaleGreen
        Me.openBtn.Location = New System.Drawing.Point(271, 144)
        Me.openBtn.Name = "openBtn"
        Me.openBtn.Size = New System.Drawing.Size(130, 61)
        Me.openBtn.TabIndex = 6
        Me.openBtn.Text = "OPEN"
        Me.openBtn.UseVisualStyleBackColor = False
        '
        'directoryPath
        '
        Me.directoryPath.Font = New System.Drawing.Font("Segoe UI Variable Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.directoryPath.Location = New System.Drawing.Point(428, 157)
        Me.directoryPath.Name = "directoryPath"
        Me.directoryPath.Size = New System.Drawing.Size(563, 39)
        Me.directoryPath.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(552, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 43)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "FIND WORD"
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.MediumPurple
        Me.backBtn.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.backBtn.Location = New System.Drawing.Point(523, 579)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(203, 67)
        Me.backBtn.TabIndex = 11
        Me.backBtn.Text = "KEMBALI"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1236, 729)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textContent)
        Me.Controls.Add(Me.searchWordTextBox)
        Me.Controls.Add(Me.searchWordBtn)
        Me.Controls.Add(Me.openBtn)
        Me.Controls.Add(Me.directoryPath)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textContent As RichTextBox
    Friend WithEvents searchWordTextBox As TextBox
    Friend WithEvents searchWordBtn As Button
    Friend WithEvents openBtn As Button
    Friend WithEvents directoryPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents backBtn As Button
End Class
