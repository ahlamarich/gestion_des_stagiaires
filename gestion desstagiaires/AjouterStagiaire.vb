Public Class AjouterStagiaire
    Dim datread As OleDb.OleDbDataReader

    Private Sub Ajouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connBDD()

        For i = 10 To 30
            ComboBox1_cmb.Items.Add(i)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Annuler_btn.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Vider_btn.Click

        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox3.Text = ""
        ComboBox1_cmb.Text = ""
        ComboBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox2.Select()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Enregistrer_btn.Click
        'Test'
        If TextBox2.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Remplir tous les champs")
        ElseIf ComboBox3.Text = "" Then
            MsgBox("Selectionner ID de responsable !!")
        ElseIf ComboBox1_cmb.Text = "" Then
            MsgBox("Selectionner l'age !!")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Selectionner sexe!!")


        End If
        'Enregistrer'
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Stagiaire(Nom_stg,prenom,Age,sexe,Adresse,Telephone,Nom_rsp) values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1_cmb.Text & "','" & ComboBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox3.Text & "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("opération d'ajout effectuée")
        Enregistrer_btn.Enabled = False
        Vider_btn.Enabled = True


    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs)

    End Sub
End Class