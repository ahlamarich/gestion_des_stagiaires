Public Class ModifierAffectation
    Dim datread As OleDb.OleDbDataReader
    Private Sub Modifier3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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





    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Text = ""
        End If
    End Sub



    Private Sub Enregistrer_btn_Click_1(sender As Object, e As EventArgs) Handles Enregistrer_btn.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Affectation set Nom_stg='" & ComboBox1.Text & "',Titre='" & ComboBox2.Text & "',Description='" & TextBox2.Text & "',Date_debut='" & DateTimePicker1.Value & "',Date_fin='" & DateTimePicker1.Value & "' ,Duree='" & TextBox3.Text & "' where N° =" & Integer.Parse(TextBox1.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Modification effectuée")
        datread.Close()
    End Sub

    Private Sub Vider_btn_Click(sender As Object, e As EventArgs) Handles Vider_btn.Click
        TextBox1.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Text = ""
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
        TextBox3.Text = ""
        TextBox1.Select()
    End Sub

    Private Sub Annuler_btn_Click(sender As Object, e As EventArgs) Handles Annuler_btn.Click
        Me.Close()
    End Sub
End Class