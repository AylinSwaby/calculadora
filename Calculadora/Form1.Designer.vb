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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Baby sweet", 20.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 73)
        Label1.TabIndex = 0
        Label1.Text = "Operaciones Aritméticas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(75, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 21)
        Label2.TabIndex = 1
        Label2.Text = "Ingrese el Valor 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(75, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 21)
        Label3.TabIndex = 2
        Label3.Text = "Ingrese el Valor 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(106, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 23)
        Label4.TabIndex = 3
        Label4.Text = "Resultado"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(86, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 17)
        Label5.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(220, 94)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 25)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(220, 155)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 25)
        TextBox2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(106, 289)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 48)
        Button1.TabIndex = 8
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(220, 289)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 48)
        Button2.TabIndex = 9
        Button2.Text = "-"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(106, 373)
        Button3.Name = "Button3"
        Button3.Size = New Size(96, 48)
        Button3.TabIndex = 10
        Button3.Text = "*"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(220, 373)
        Button4.Name = "Button4"
        Button4.Size = New Size(96, 48)
        Button4.TabIndex = 11
        Button4.Text = "/"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(106, 442)
        Button5.Name = "Button5"
        Button5.Size = New Size(96, 48)
        Button5.TabIndex = 12
        Button5.Text = "Raíz"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(220, 442)
        Button6.Name = "Button6"
        Button6.Size = New Size(96, 48)
        Button6.TabIndex = 13
        Button6.Text = "^"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(208, 219)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 25)
        TextBox3.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(405, 533)
        Controls.Add(TextBox3)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox3 As TextBox
End Class
