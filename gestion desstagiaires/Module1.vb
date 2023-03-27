Module Module1


    Public con As New OleDb.OleDbConnection
    Public cmd As New OleDb.OleDbCommand

    Public Sub connBDD()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\gestion_des_stagiaires\gestion_stagiaire2.accdb"
        con.Open()

    End Sub

End Module
