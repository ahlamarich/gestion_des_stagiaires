Public Class Ajouter1Responsable
    Private Sub Ajouter1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connBDD()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Annuler_btn.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Vider_btn.Click

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox2.Select()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Enregistrer_btn.Click
        'Test'
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Remplir tous les champs")

        End If
        'Enregistrer'
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Responsable (Nom_rsp,prénom,Adresse,Telephone) values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("opération d'ajout effectuée")
        Enregistrer_btn.Enabled = False
        Vider_btn.Enabled = True


    End Sub


End Class