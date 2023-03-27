Public Class RechercheStagiaire
    Dim datread As OleDb.OleDbDataReader


    Private Sub RechercheStagiaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call connBDD()

        For i = 10 To 30
            ComboBox1.Items.Add(i)
        Next



        '-------------------remplissage du combox responsable ------------------
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Responsable"
        datread = cmd.ExecuteReader

        ComboBox3.Items.Clear()

        Do While datread.Read
            ComboBox3.Items.Add(datread.GetString(1))

        Loop
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cod As Integer
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cod = TextBox1.Text
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Stagiaire where ID_stg=" & cod
            datread = cmd.ExecuteReader
            If Not datread.HasRows Then
                MessageBox.Show("Aucun enregistrement")
            Else
                MessageBox.Show("Enregistrement Existe à la BD")
                datread.Read()
                TextBox1.Text = datread.GetValue(0)
                TextBox2.Text = datread.GetValue(1)
                TextBox3.Text = datread.GetValue(2)
                ComboBox3.Text = datread.GetValue(3)
                ComboBox1.Text = datread.GetValue(4)
                ComboBox2.Text = datread.GetValue(5)
                TextBox4.Text = datread.GetValue(6)
                TextBox5.Text = datread.GetValue(7)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Annuler_btn_Click(sender As Object, e As EventArgs) Handles Annuler_btn.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Text = ""
        End If
    End Sub
End Class