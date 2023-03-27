Public Class ModifierResponsable

    Dim datread As OleDb.OleDbDataReader
    Private Sub Modifier1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Call connBDD()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cod As Integer
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

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

    Private Sub Enregistrer_btn_Click(sender As Object, e As EventArgs) Handles Enregistrer_btn.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Responsable set Nom_rsp='" & TextBox2.Text & "',Prénom='" & TextBox3.Text & "',Adresse='" & TextBox4.Text & "',Telephone='" & TextBox5.Text & "' where ID_rsp =" & Integer.Parse(TextBox1.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Modification effectuée")
        datread.Close()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Vider_btn_Click(sender As Object, e As EventArgs) Handles Vider_btn.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox1.Select()
    End Sub
End Class