Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Collaborateur

    Public nom_A_Rechercher As String
    Public prenom_A_Rechercher As String
    Public Nomination As String
    Public Mon_Adresse As String


    Private Sub Collaborateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Active_Final_CommunDataSet.COLLABORATEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'On peut directemejnt acceder aux données de cette façon
        ''Me.COLLABORATEURTableAdapter.Fill(Me.Active_Final_CommunDataSet.COLLABORATEUR)
        ''Dim ConnexionLecture As New OleDbConnection(str_Connexion)
        '' Dim Requete_Commande_Lecture As OleDbCommand = ConnexionLecture.CreateCommand()
        ''Requete_Commande_Lecture.CommandType = CommandType.StoredProcedure
        ''Requete_Commande_Lecture.CommandText = "Ps_Liste_Collaborateur"

        'Dim Login_Utilisateur As SqlParameter = Requete_Liste_Collaborateur.Parameters.Add("@Nom_Utilisateur", SqlDbType.VarChar)
        'Dim Mdp_Utilisateur As SqlParameter = Requete_Liste_Collaborateur.Parameters.Add("@motDePasse", SqlDbType.VarChar)
        'Dim profil_Utilisateur As SqlParameter = Requete_Liste_Collaborateur.Parameters.Add("@Profile_Utilisateur", SqlDbType.Int)
        'Login_Utilisateur.Value = txt_Ajout_Nom.Text + "." + txt_Ajout_Prenom.Text
        'Mdp_Utilisateur.Value = txt_Ajout_Mot_De_Passe.Text
        'profil_Utilisateur.Value = choix_Statut

        'nom_Collaborateur.Value = nom_A_Rechercher
        'Login_Utilisateur.Direction = ParameterDirection.Input
        'Mdp_Utilisateur.Direction = ParameterDirection.Input
        'profil_Utilisateur.Direction = ParameterDirection.Input
        ''Requete_Commande_Lecture.Connection = ConnexionLecture



        '--------------------------------------------------------------------
        '             'Nom connexion : un type de connexion pour tout
        '--------------------------------------------------------------------
        Dim ConnexionBDD As New SqlConnection(str_Connexion)

        '--------------------------------------------------------------------
        '                               Noms Requêtes
        '--------------------------------------------------------------------

        Dim Requete_Liste_Collaborateur As SqlCommand = ConnexionBDD.CreateCommand()


        '--------------------------------------------------------------------
        '                           Types des Requetes
        '--------------------------------------------------------------------

        Requete_Liste_Collaborateur.CommandType = CommandType.StoredProcedure



        '--------------------------------------------------------------------
        '              Liaison avec la BDD (procedure, Fonction ... etc
        '--------------------------------------------------------------------

        Requete_Liste_Collaborateur.CommandText = "Ps_Liste_Collaborateur"




        '--------------------------------------------------------------------
        '             Liaison Variables sql et variables VB 
        '--------------------------------------------------------------------
        ' exemple
        'Dim nom_Collaborateur As SqlParameter = Requete_Adresse.Parameters.Add("@nom_Personne", SqlDbType.VarChar)


        '--------------------------------------------------------------------
        '             Liaison Variables sql et variables VB 
        '--------------------------------------------------------------------
        ' exemple
        ''nom_Collaborateur.Value = cb_Affichage_Collaborateurs.SelectedItem



        '--------------------------------------------------------------------
        '            Direction des variables (Input, Output, return
        '--------------------------------------------------------------------



        '--------------------------------------------------------------------
        '                        Connexion
        '--------------------------------------------------------------------
        Requete_Liste_Collaborateur.Connection = ConnexionBDD

        Try

            ConnexionBDD.Open()
            ''ConnexionLecture.Open()

            'On spéciifie que c'est une exécution en mode lecture 
            Dim myReader As SqlDataReader = Requete_Liste_Collaborateur.ExecuteReader()
            Dim compteur As Integer

            compteur = 0

            Do While myReader.Read()
                cb_Affichage_Collaborateurs.Items.Add(myReader.GetString(compteur))


            Loop


            myReader.Close()

            ConnexionBDD.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Close()
        Accueuil.Show()
    End Sub

    Private Sub cb_Affichage_Collaborateurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Affichage_Collaborateurs.SelectedIndexChanged
        'on met le nom complet dans nomination il faut donc séparer le nom et le prénom
        Nomination = cb_Affichage_Collaborateurs.SelectedItem

        'séparation nom et prenom
        'on cré d'abord un tableau qui va prendre nom col0 et pren col 1 en splitant avec l'espace vide
        Dim tab() As String
        tab = Split(Nomination, " ")

        'on peut faire aussi tab = split(cb_Affichage_Collaborateurs.SelectedItem, " ") 


        'on met les valeurs où il faut
        nom_A_Rechercher = tab(0)
        prenom_A_Rechercher = tab(1)

        '                                               '/!\'
        'REMPLISSAGE DESZONES DE TEXTE DANS LA PAGE -> il faudra les rendre innaccessible puis mettre un bouton pour permettre
        'la modification des données => ce qui implique update de la base de données en même temps
        txt_Nom.Text = nom_A_Rechercher
        txt_Prenom.Text = prenom_A_Rechercher
        '-----------------------------Pour L'Adresse---------------------------------
        '--------------------------------------------------------------------
        '             'Nom connexion : un type de connexion pour tout
        '--------------------------------------------------------------------
        Dim ConnexionBDD As New SqlConnection(str_Connexion)

        '--------------------------------------------------------------------
        '                               Noms commande de Requête
        '--------------------------------------------------------------------

        Dim Requete_Adresse As SqlCommand = ConnexionBDD.CreateCommand()

        '--------------------------------------------------------------------
        '                           Types des Requetes
        '--------------------------------------------------------------------

        Requete_Adresse.CommandType = CommandType.StoredProcedure


        '--------------------------------------------------------------------
        '              Liaison avec la BDD (procedure, Fonction ... etc
        '--------------------------------------------------------------------

        Requete_Adresse.CommandText = "Ps_Mon_Adresse"

        '--------------------------------------------------------------------
        '             'Utilisateion du dataset
        '--------------------------------------------------------------------
        Dim MonAdaptateur As New SqlDataAdapter(Requete_Adresse)
        Dim MonDataSet As New DataSet

        '--------------------------------------------------------------------
        '             Liaison Variables sql et variables VB 
        '--------------------------------------------------------------------

        Dim nom_Collaborateur As SqlParameter = Requete_Adresse.Parameters.Add("@nom_Personne", SqlDbType.VarChar)
        Dim prenom_Collaborateur As SqlParameter = Requete_Adresse.Parameters.Add("@prenom_personne", SqlDbType.VarChar)
        Dim adresse_collaborateur As SqlParameter = Requete_Adresse.Parameters.Add("@adresse", SqlDbType.VarChar)
        'Dim MonTabAdresse() As String 
        '--------------------------------------------------------------------
        '             Liaison Variables sql et variables VB 
        '--------------------------------------------------------------------
        nom_Collaborateur.Value = nom_A_Rechercher
        prenom_Collaborateur.Value = prenom_A_Rechercher


        '--------------------------------------------------------------------
        '            Direction des variables (Input, Output, return
        '--------------------------------------------------------------------

        nom_Collaborateur.Direction = ParameterDirection.Input
        prenom_Collaborateur.Direction = ParameterDirection.Input


        'MonTabAdresse = Split(adresse_collaborateur.ToString(), "")

        '--------------------------------------------------------------------
        '                        Connexion Pour les Adresses
        '--------------------------------------------------------------------
        Requete_Adresse.Connection = ConnexionBDD
        Try

            ConnexionBDD.Open()
            Try
                'txt_Adresse1.Text = MonAdaptateur.Fill(MonDataSet, "RUE_ADRESSE1")
                txt_Adresse1.Text = MonDataSet.Tables("COLLABORATEUR").Rows(1).Item("RUE_ADRESSE1").ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            //je suis nul


            'Requete_Adresse.Execute  'NonQuery()
            ConnexionBDD.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'txt_Adresse1.Text = adresse_collaborateur.ToString()
    End Sub



    Private Sub cb_Collaborateur_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_Prenom_TextChanged(sender As Object, e As EventArgs) Handles txt_Prenom.TextChanged

    End Sub

    Private Sub txt_Nom_TextChanged(sender As Object, e As EventArgs) Handles txt_Nom.TextChanged

    End Sub

    Private Sub txt_Code_Postal_TextChanged(sender As Object, e As EventArgs) Handles txt_Code_Postal.TextChanged

    End Sub
End Class