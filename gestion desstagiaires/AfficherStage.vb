Public Class AfficherStage
    Dim datread As OleDb.OleDbDataReader
    Private Sub AfficherStage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connBDD()

        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        'Add column header
        ListView1.Columns.Add("N°", 50)
        ListView1.Columns.Add("Nom_stg", 100)
        ListView1.Columns.Add("Description", 100)
        ListView1.Columns.Add("Date_debut", 70)
        ListView1.Columns.Add("Date_fin", 50)
        ListView1.Columns.Add("Duree", 50)

        'Add items in the listview
        Dim arr(6) As String
        Dim itm As ListViewItem

        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Affectation"
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
        Me.Close()

    End Sub


End Class