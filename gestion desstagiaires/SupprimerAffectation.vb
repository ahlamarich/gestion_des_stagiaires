Public Class SupprimerAffectation
    Dim datread As OleDb.OleDbDataReader
    Private Sub Supprimer3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Call connBDD()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Annuler_btn_Click(sender As Object, e As EventArgs) Handles Annuler_btn.Click
        If MsgBox("Vous Voulez vraiment supprimer !!!") = MsgBoxResult.Ok Then
            datread.Close()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from Affectation where N°=" & Integer.Parse(TextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Opération de suppression effectuée")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            DateTimePicker1.Value = Now
            DateTimePicker1.Value = Now
            TextBox1.Focus()
            datread.Close()
        End If
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
            cmd.CommandText = "select * from  Affectation where N°=" & cod
            datread = cmd.ExecuteReader
            If Not datread.HasRows Then
                MessageBox.Show("Aucun enregistrement")
            Else
                MessageBox.Show("Enregistrement Existe à la BD")
                datread.Read()
                TextBox1.Text = datread.GetValue(0)
                ComboBox1.Text = datread.GetValue(1)
                ComboBox2.Text = datread.GetValue(2)
                TextBox2.Text = datread.GetValue(3)
                DateTimePicker1.Value = datread.GetValue(4)
                DateTimePicker2.Value = datread.GetValue(5)
                TextBox3.Text = datread.GetValue(6)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class