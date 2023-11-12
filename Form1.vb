Imports System.Data.SQLite
Imports System.Drawing.Drawing2D
Imports System.IO
Imports WinFormsApp_Anne.FrmCadstro
Imports Microsoft.Data.Sqlite

Public Class Form1

    Private ReadOnly ConnectionString As String = "Data Source=C:\Projetos\vb\WinFormsApp_Anne\Database.db;"
    Private Property Senhacadastr As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EstilizacaoLogin()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If email.Text <> Nothing And senha.Text <> Nothing Then
                Dim emailTXT As String = email.Text
                Dim senhaTXT As String = Senhacadastr.Replace("*", "")

                SQLitePCL.Batteries.Init()

                Dim con As New SqliteConnection(ConnectionString)

                con.Open()

                Dim query As String = "SELECT * FROM cadastros where senha = " & senhaTXT & " and email =" & "'" & emailTXT & "'"
                Dim command As New SqliteCommand(query, con)

                Dim reader As SqliteDataReader = command.ExecuteReader()

                If reader.HasRows <> False Then

                    Dim objUsuario As New Usuario

                    While reader.Read()
                        objUsuario.Nome = reader("Nome").ToString()
                        objUsuario.senha = reader("senha").ToString()
                        objUsuario.Email = reader("email").ToString()
                        objUsuario.Grupo = reader("grupo").ToString()
                    End While


                    MessageBox.Show("Usuario encontrado com sucesso!")



                    '######################## Carregar aplicação pós login aqui '########################





                    ''###################################################################################

                Else
                    MessageBox.Show("Usuario não encontrado!")

                End If


            Else
                MessageBox.Show("Preencha os dados corretamente!")
            End If




        Catch ex As Exception

        End Try



    End Sub


#Region "Estilização"
    Private Sub EstilizacaoLogin()

        ArredondarBordas(GroupBox1, 10)
        ArredondarBordas(PictureBox1, 10)
        ArredondarBordas(email, 10)
        ArredondarBordas(senha, 10)



        Label1.BackColor = Color.Transparent
        email.Height = 100

    End Sub

    Private Sub ArredondarBordas(controle As Control, raio As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, raio, raio, 180, 90)
        path.AddArc(controle.Width - raio, 0, raio, raio, 270, 90)
        path.AddArc(controle.Width - raio, controle.Height - raio, raio, raio, 0, 90)
        path.AddArc(0, controle.Height - raio, raio, raio, 90, 90)

        controle.Region = New Region(path)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim frm As New ForgPass

        frm.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim frm As New FrmCadastro

        frm.Show()

    End Sub

    Private Sub senha_TextChanged(sender As Object, e As EventArgs) Handles senha.TextChanged

        Dim textBoxSenha As TextBox = DirectCast(sender, TextBox)

        Senhacadastr = Senhacadastr + textBoxSenha.Text

        If textBoxSenha.TextLength > 0 Then
            textBoxSenha.Text = New String("*", textBoxSenha.TextLength)
        End If



    End Sub







#End Region

End Class
