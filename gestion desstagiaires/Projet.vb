Public Class Projet
    Dim datread As OleDb.OleDbDataReader
    Private Sub Ajouter4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connBDD()
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        'Add column header
        ListView1.Columns.Add("N°", 50)
        ListView1.Columns.Add("Titre", 100)
        ListView1.Columns.Add("Description", 100)


        'Add items in the listview
        Dim arr(3) As String
        Dim itm As ListViewItem

        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Projet"
        datread = cmd.ExecuteReader
        If Not datread.HasRows Then
            MessageBox.Show("aucun enregistrement")
        Else
            Do While datread.Read
                For i = 0 To datread.FieldCount - 1
                    arr(i) = datread.GetValue(i)
                Next
                itm = New ListViewItem(arr)
                ListView1.Items.Add(itm)
            Loop
        End If




    End Sub


    Private Sub Vider_btn_Click(sender As Object, e As EventArgs) Handles Vider_btn.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Select()
    End Sub



    Private Sub Annuler_btn_Click(sender As Object, e As EventArgs) Handles Annuler_btn.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ajouter_btn.Click
        'Test'
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Remplir tous les champs")



        End If
        'Enregistrer'
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Projet (N°,Titre,Description) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("opération d'ajout effectuée")
        Ajouter_btn.Enabled = False
        Vider_btn.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Try
            Dim cod As Integer
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cod = InputBox("Entrez le code du salarié a cherché :")
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from  Projet where N°=" & cod
            datread = cmd.ExecuteReader
            If Not datread.HasRows Then
                MessageBox.Show("Aucun enregistrement")
            Else
                MessageBox.Show("Enregistrement Existe à la BD")
                datread.Read()
                TextBox1.Text = datread.GetValue(0)
                TextBox2.Text = datread.GetValue(1)
                TextBox3.Text = datread.GetValue(2)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Projet set Titre='" & TextBox2.Text & "', Description='" & TextBox3.Text & "' where N° =" & Integer.Parse(TextBox1.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Modification effectuée")
        datread.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Vous Voulez vraiment supprimer !!!") = MsgBoxResult.Ok Then
            datread.Close()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from Projet where N°=" & Integer.Parse(TextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Opération de suppression effectuée")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox1.Focus()
            datread.Close()
        End If
    End Sub
End Class