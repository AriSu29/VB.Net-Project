<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.openBtn = New System.Windows.Forms.Button()
        Me.directoryPath = New System.Windows.Forms.TextBox()
        Me.readFileBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.textContent = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(275, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(717, 588)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(495, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 64)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FILE READER"
        '
        'openBtn
        '
        Me.openBtn.BackColor = System.Drawing.Color.PaleGreen
        Me.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.openBtn.Location = New System.Drawing.Point(309, 156)
        Me.openBtn.Name = "openBtn"
        Me.openBtn.Size = New System.Drawing.Size(150, 51)
        Me.openBtn.TabIndex = 2
        Me.openBtn.Text = "OPEN FILE"
        Me.openBtn.UseVisualStyleBackColor = False
        '
        'directoryPath
        '
        Me.directoryPath.Font = New System.Drawing.Font("Segoe UI Variable Small Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.directoryPath.Location = New System.Drawing.Point(484, 162)
        Me.directoryPath.Name = "directoryPath"
        Me.directoryPath.Size = New System.Drawing.Size(477, 39)
        Me.directoryPath.TabIndex = 3
        '
        'readFileBtn
        '
        Me.readFileBtn.BackColor = System.Drawing.Color.MediumTurquoise
        Me.readFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.readFileBtn.Location = New System.Drawing.Point(309, 245)
        Me.readFileBtn.Name = "readFileBtn"
        Me.readFileBtn.Size = New System.Drawing.Size(150, 51)
        Me.readFileBtn.TabIndex = 4
        Me.readFileBtn.Text = "READ FILE"
        Me.readFileBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Plum
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Small", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(309, 573)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 51)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "KEMBALI"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'textContent
        '
        Me.textContent.BackColor = System.Drawing.Color.White
        Me.textContent.Font = New System.Drawing.Font("Segoe UI Variable Text", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textContent.Location = New System.Drawing.Point(484, 245)
        Me.textContent.Multiline = True
        Me.textContent.Name = "textContent"
        Me.textContent.ReadOnly = True
        Me.textContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textContent.Size = New System.Drawing.Size(477, 379)
        Me.textContent.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1249, 704)
        Me.Controls.Add(Me.textContent)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.readFileBtn)
        Me.Controls.Add(Me.directoryPath)
        Me.Controls.Add(Me.openBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents openBtn As Button
    Friend WithEvents directoryPath As TextBox
    Friend WithEvents readFileBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents textContent As TextBox
End Class
