Imports System.Windows.Forms
Public Class Form1
    Inherits Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Minha Aplicação"

        ' Criação e configuração do botão
        Dim button As New Button()
        button.Text = "Clique-me"
        button.Location = New Point(50, 50)

        ' Adiciona o botão ao formulário
        Me.Controls.Add(button)
    End Sub
End Class
