Public Class Form1


    Private Sub hideSubmenu()
        Panel2.Visible = False
        Panel3.Visible = False
        Panel6.Visible = False




    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()







    End Sub

    Private Sub showSubmenu(Submenu As Panel)
        If Submenu.Visible = False Then
            hideSubmenu()
            Submenu.Visible = True
        Else
            Submenu.Visible = False

        End If






    End Sub













    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel5.Controls.Add(childForm)
        Panel5.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LabelHome.Text = childForm.Text













    End Sub
    Private Sub Form1_Resizer(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else

            FormBorderStyle = FormBorderStyle.Sizable



        End If

    End Sub







    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Width = 279 Then

            Panel1.Width = 56
            PictureBox1.Size = New Size(35, 35)
            PictureBox1.Location = New Point(5, 52)
        Else

            Panel1.Width = 279
            PictureBox1.Size = New Size(79, 72)
            PictureBox1.Location = New Point(90, 38)
        End If
    End Sub







    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If WindowState = FormWindowState.Normal Then

            WindowState = FormWindowState.Maximized
        Else

            WindowState = FormWindowState.Normal



        End If
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Connexion.Show()



    End Sub



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        showSubmenu(Panel2)
    End Sub



    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        showSubmenu(Panel6)
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        showSubmenu(Panel3)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New AjouterStagiaire)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New ModifierStagiaire)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New SupprimerStagiaire)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New RechercheStagiaire)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New AfficherStagiaire)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New Ajouter1Responsable)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New ModifierResponsable)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New SupprimerResponsable)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New RechercheResponsable)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New Afficher2)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New AjouterAffectation)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New ModifierAffectation)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New SupprimerAffectation)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New RechercheAffectation)
        End If


        hideSubmenu()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New AfficherStage)
        End If


        hideSubmenu()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New Projet)
        End If


        hideSubmenu()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            openChildForm(New Attestation)
        End If


        hideSubmenu()
    End Sub
End Class




