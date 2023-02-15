<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.readBtn = New System.Windows.Forms.Button()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.labelPressEnter = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'readBtn
        '
        Me.readBtn.BackColor = System.Drawing.Color.PaleGreen
        Me.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.readBtn.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.readBtn.ForeColor = System.Drawing.Color.Black
        Me.readBtn.Location = New System.Drawing.Point(843, 143)
        Me.readBtn.Name = "readBtn"
        Me.readBtn.Size = New System.Drawing.Size(235, 82)
        Me.readBtn.TabIndex = 0
        Me.readBtn.Text = "BACA FILE"
        Me.readBtn.UseVisualStyleBackColor = False
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.BackColor = System.Drawing.Color.Transparent
        Me.LabelWelcome.Font = New System.Drawing.Font("Segoe UI Variable Display", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelWelcome.Location = New System.Drawing.Point(199, 34)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(334, 74)
        Me.LabelWelcome.TabIndex = 2
        Me.LabelWelcome.Text = "WELCOME, "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(216, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ENTER YOUR NAME : "
        '
        'TextBoxNama
        '
        Me.TextBoxNama.BackColor = System.Drawing.Color.MediumTurquoise
        Me.TextBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNama.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxNama.ForeColor = System.Drawing.Color.Indigo
        Me.TextBoxNama.Location = New System.Drawing.Point(495, 265)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(293, 38)
        Me.TextBoxNama.TabIndex = 4
        '
        'labelPressEnter
        '
        Me.labelPressEnter.AutoSize = True
        Me.labelPressEnter.BackColor = System.Drawing.Color.Transparent
        Me.labelPressEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelPressEnter.Location = New System.Drawing.Point(595, 223)
        Me.labelPressEnter.Name = "labelPressEnter"
        Me.labelPressEnter.Size = New System.Drawing.Size(123, 25)
        Me.labelPressEnter.TabIndex = 5
        Me.labelPressEnter.Text = "PRESS ENTER!"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.MediumTurquoise
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBtn.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.searchBtn.ForeColor = System.Drawing.Color.Black
        Me.searchBtn.Location = New System.Drawing.Point(843, 358)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(235, 82)
        Me.searchBtn.TabIndex = 6
        Me.searchBtn.Text = "CARI KATA"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1223, 672)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.labelPressEnter)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Controls.Add(Me.readBtn)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents readBtn As Button
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents labelPressEnter As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents searchBtn As Button
End Class
