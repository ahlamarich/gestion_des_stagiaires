Public Class SupprimerResponsable
    Dim datread As OleDb.OleDbDataReader
    Private Sub Supprimer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connBDD()
        Me.Height = 152


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cod As Integer
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Me.Height = 640
            cod = TextBox1.Text
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Responsable where ID_rsp=" & cod
            datread = cmd.ExecuteReader
            If Not datread.HasRows Then
                MessageBox.Show("Aucun enregistrement")
            Else
                MessageBox.Show("Enregistrement Existe à la BD")
                datread.Read()
                TextBox1.Text = datread.GetValue(0)
                TextBox2.Text = datread.GetValue(1)
                TextBox3.Text = datread.GetValue(2)
                TextBox4.Text = datread.GetValue(3)
                TextBox5.Text = datread.GetValue(4)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Text = ""
        End If
        Me.Height = 152
    End Sub

    Private Sub Annuler_btn_Click(sender As Object, e As EventArgs) Handles Annuler_btn.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Vous Voulez vraiment supprimer !!!") = MsgBoxResult.Ok Then
            datread.Close()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from Responsable where ID_rsp=" & Integer.Parse(TextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Opération de suppression effectuée")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox1.Focus()
            datread.Close()
        End If
    End Sub
End Class