

Imports System.Data.OleDb
Public Class Connexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBox2.PasswordChar = Chr(149)


    End Sub
    Private Sub Form1_Resizer(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Width
        Me.Width = x
        Me.Height = y - 40
        Me.Top = 0
        Me.Left = 0


        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2




    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Call connBDD()
        Dim logincmd As OleDbCommand = New OleDbCommand("select username,passwd from Login where [username]='" & textBox1.Text & "'and [passwd]='" & textBox2.Text & "'", con)
        Dim loginrd As OleDbDataReader = logincmd.ExecuteReader
        If (loginrd.Read() = True) Then
            Me.Hide()

            username = textBox1.Text
            FormWelcome.Show()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Close Application ", vbYesNo, vbQuestion) = vbYes Then
            Application.Exit()  
        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If textBox2.PasswordChar = "*" Then
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
            textBox2.PasswordChar = ""
        Else
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye
            textBox2.PasswordChar = "*"
        End If
    End Sub
End Class
