Public Class AjouterAffectation
    Dim datread As OleDb.OleDbDataReader
    Private Sub Enregistrer_btn_Click(sender As Object, e As EventArgs) Handles Enregistrer_btn.Click
        'Test'
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Remplir tous les champs")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Selectionner l'age !!")
        ElseIf DateTimePicker1.Value = Now Then

            MsgBox("Entrer la Date de Début!!")
        ElseIf DateTimePicker2.Value = Now Then

            MsgBox("Entrer la Date de Fin!!")


        End If
        'Enregistrer'
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Affectation (Nom_stg,Titre,Description,Date_debut,Date_fin,Duree) values('" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Value & "','" & DateTimePicker2.Value & "','" & TextBox3.Text & "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("opération d'ajout effectuée")
        Enregistrer_btn.Enabled = False
        Vider_btn.Enabled = True
    End Sub

    Private Sub Vider_btn_Click(sender As Object, e As EventArgs) Handles Vider_btn.Click

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Text = ""
        DateTimePicker1.Value = Now
        DateTimePicker1.Value = Now
        TextBox3.Text = ""
        TextBox2.Select()
    End Sub

    Private Sub Ajouter3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connBDD()
        '-------------------remplissage du combox stagiaire ------------------
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Projet"
        datread = cmd.ExecuteReader

        ComboBox2.Items.Clear()

        Do While datread.Read
            ComboBox2.Items.Add(datread.GetString(1))

        Loop
        datread.Close()


        DateTimePicker1.MinDate = Now
        DateTimePicker2.MinDate = Now


        '-------------------remplissage du combox stagiaire ------------------
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Stagiaire"
        datread = cmd.ExecuteReader

        ComboBox1.Items.Clear()

        Do While datread.Read
            ComboBox1.Items.Add(datread.GetString(1))

        Loop





    End Sub

    Private Sub Annuler_btn_Click(sender As Object, e As EventArgs) Handles Annuler_btn.Click
        Me.Close()
    End Sub



    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

        Dim date_D, date_F As Date

        date_D = CDate(DateTimePicker1.Value)
        date_F = CDate(DateTimePicker2.Value)
        Dim diff As Long = 0
        diff = DateDiff(DateInterval.Day, date_D, date_F)


        TextBox3.Text = diff.ToString + "jours"

    End Sub


End Class