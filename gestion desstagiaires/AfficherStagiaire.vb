Public Class AfficherStagiaire
    Dim datread As OleDb.OleDbDataReader
    Private Sub Afficher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connBDD()

        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        'Add column header
        ListView1.Columns.Add("ID_stg", 50)
        ListView1.Columns.Add("Nom", 100)
        ListView1.Columns.Add("Prénom", 100)
        ListView1.Columns.Add("Age", 70)
        ListView1.Columns.Add("sexe", 50)
        ListView1.Columns.Add("Adresse", 70)
        ListView1.Columns.Add("Telephone", 100)

        'Add items in the listview
        Dim arr(7) As String
        Dim itm As ListViewItem

        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Stagiaire"
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImprimerStagiaire.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class