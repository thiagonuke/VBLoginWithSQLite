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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        email = New TextBox()
        senha = New TextBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' email
        ' 
        email.Location = New Point(37, 65)
        email.Name = "email"
        email.Size = New Size(425, 23)
        email.TabIndex = 0
        ' 
        ' senha
        ' 
        senha.Location = New Point(37, 144)
        senha.Name = "senha"
        senha.Size = New Size(425, 23)
        senha.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(350, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(259, 254)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(211, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 32)
        Label1.TabIndex = 6
        Label1.Text = "Usuario"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(senha)
        GroupBox1.Controls.Add(email)
        GroupBox1.Location = New Point(240, 268)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(514, 258)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(149, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(211, 36)
        Button1.TabIndex = 9
        Button1.Text = "Entrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 15)
        Label3.TabIndex = 8
        Label3.Text = "Esqueceu sua senha?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(211, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 32)
        Label2.TabIndex = 7
        Label2.Text = "Senha"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(378, 540)
        Label4.Name = "Label4"
        Label4.Size = New Size(231, 15)
        Label4.TabIndex = 8
        Label4.Text = "Ainda não possui uma conta? Cadastra-se!"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(-4, 540)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(934, 564)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents senha As TextBox
    Friend WithEvents divLogin As GroupBox
    Friend WithEvents email As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
