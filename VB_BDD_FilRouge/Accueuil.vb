Public Class Accueuil




    Private Sub Accueuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tableau de profil
        Dim MonStatut() As String = {"", "ADMIN", "COLLABORATEUR", "CLIENT"}

        'application du resultat de la valeur renvoyer par <<Verification>> sur le tableau à partir de la bdd: c'est soit 1,2 ou 3
        lbl_statut.Text = MonStatut(Fenetre_Principale.res)

        lbl_Affichage_Nom.Text = Fenetre_Principale.txt_Login.Text.ToUpper

        'si c'est un admin on rend l'appui du bouton ajouter vrai
        If (Fenetre_Principale.res = 1) Then
            btn_Ajout.Visible = True
        End If


    End Sub

    Private Sub btn_Deconnexion_Click(sender As Object, e As EventArgs) Handles btn_Deconnexion.Click
        Me.Close()
        Fenetre_Principale.Show()
    End Sub

    Private Sub lbl_BienVenu_Click(sender As Object, e As EventArgs) Handles lbl_BienVenu.Click

    End Sub

    Private Sub btn_Ajout_Click(sender As Object, e As EventArgs) Handles btn_Ajout.Click
        Me.Close()
        Administration.Show()
    End Sub

    Private Sub btn_Client_Click(sender As Object, e As EventArgs) Handles btn_Client.Click
        Me.Close()
        Client.Show()
    End Sub

    Private Sub btn_Collaborateur_Click(sender As Object, e As EventArgs) Handles btn_Collaborateur.Click
        Me.Close()
        Collaborateur.Show()
    End Sub

    Private Sub btn_Projet_Click(sender As Object, e As EventArgs) Handles btn_Projet.Click
        Me.Close()
        Projets.Show()
    End Sub
End Class