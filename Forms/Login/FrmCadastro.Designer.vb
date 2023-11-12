<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmCadastro))
        EmailCadastro = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SenhaCadastro = New TextBox()
        Label3 = New Label()
        RptSenhaCadastro = New TextBox()
        Label4 = New Label()
        NomeCadastro = New TextBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EmailCadastro
        ' 
        EmailCadastro.Location = New Point(44, 174)
        EmailCadastro.Name = "EmailCadastro"
        EmailCadastro.Size = New Size(282, 23)
        EmailCadastro.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(44, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 32)
        Label1.TabIndex = 7
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(44, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 32)
        Label2.TabIndex = 8
        Label2.Text = "Senha"
        ' 
        ' SenhaCadastro
        ' 
        SenhaCadastro.Location = New Point(44, 250)
        SenhaCadastro.Name = "SenhaCadastro"
        SenhaCadastro.Size = New Size(282, 23)
        SenhaCadastro.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(44, 276)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 32)
        Label3.TabIndex = 10
        Label3.Text = "Repita a senha"
        ' 
        ' RptSenhaCadastro
        ' 
        RptSenhaCadastro.Location = New Point(44, 333)
        RptSenhaCadastro.Name = "RptSenhaCadastro"
        RptSenhaCadastro.Size = New Size(282, 23)
        RptSenhaCadastro.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(44, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 32)
        Label4.TabIndex = 12
        Label4.Text = "Nome"
        ' 
        ' NomeCadastro
        ' 
        NomeCadastro.Location = New Point(44, 91)
        NomeCadastro.Name = "NomeCadastro"
        NomeCadastro.Size = New Size(282, 23)
        NomeCadastro.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(256, 392)
        Button1.Name = "Button1"
        Button1.Size = New Size(282, 36)
        Button1.TabIndex = 14
        Button1.Text = "Cadastrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(471, 91)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(254, 256)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' FrmCadastro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(NomeCadastro)
        Controls.Add(Label4)
        Controls.Add(RptSenhaCadastro)
        Controls.Add(Label3)
        Controls.Add(SenhaCadastro)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(EmailCadastro)
        Name = "FrmCadastro"
        Text = "FrmCadastro"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EmailCadastro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SenhaCadastro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RptSenhaCadastro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NomeCadastro As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
