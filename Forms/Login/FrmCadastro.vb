Imports Microsoft.Data.Sqlite

Public Class FrmCadastro

    Private ReadOnly ConnectionString As String = "Data Source=C:\Projetos\vb\WinFormsApp_Anne\Database.db;"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            If NomeCadastro.Text <> Nothing And SenhaCadastro.Text <> Nothing And RptSenhaCadastro.Text <> Nothing And EmailCadastro.Text <> Nothing Then


                If SenhaCadastro.Text = RptSenhaCadastro.Text Then


                    SQLitePCL.Batteries.Init()

                    Dim con As New SqliteConnection(ConnectionString)

                    con.Open()


                    Dim strquery As String = "INSERT INTO cadastros (Email, Nome,senha,Grupo) VALUES (" & "'" & EmailCadastro.Text & "', " & "'" & NomeCadastro.Text & "', " & "'" & SenhaCadastro.Text & "'" & ", CURRENT_TIMESTAMP);"

                    Dim Execute As New SqliteCommand(strquery, con)

                    Execute.ExecuteNonQuery()
                    MessageBox.Show("Usuario cadastrado com sucesso!")

                    Me.Close()

                Else
                    MessageBox.Show("Senhas não se coincidem")


                End If


            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar usuario!")


        End Try




    End Sub
End Class