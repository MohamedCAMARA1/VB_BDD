Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Collaborateur

    Public nom_A_Rechercher As String
    Public prenom_A_Rechercher As String
    Public Nomination As String
    Public Mon_Adresse As String
    Public index_Selection As Integer


    Private Sub Collaborateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tableau des Profils accès avec variable "res" qui renvoi le numero du profil correspondant {"", "ADMIN", "COLLABORATEUR", "CLIENT"}
        If (Fenetre_Principale.res = 2) Then
            btn_Modifier.Visible = False
            btn_Valider.Visible = False
        End If



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



        '======================================================================================
        '============================= Pour La liste Collaborateur=============================
        '======================================================================================

        ''--------------------------------------------------------------------
        ''                               Noms Requêtes
        ''--------------------------------------------------------------------
        'Dim Requete_Liste_Collaborateur As SqlCommand = ConnexionBDD.CreateCommand()

        ''--------------------------------------------------------------------
        ''                           Types des Requetes
        ''--------------------------------------------------------------------
        'Requete_Liste_Collaborateur.CommandType = CommandType.StoredProcedure

        ''--------------------------------------------------------------------
        ''              Liaison avec la BDD (procedure, Fonction ... etc
        ''--------------------------------------------------------------------
        'Requete_Liste_Collaborateur.CommandText = "Ps_Liste_Collaborateur"

        ''--------------------------------------------------------------------
        ''             Liaison Variables sql et variables VB 
        ''--------------------------------------------------------------------
        '' exemple
        ''Dim nom_Collaborateur As SqlParameter = Requete_Adresse.Parameters.Add("@nom_Personne", SqlDbType.VarChar)

        ''--------------------------------------------------------------------
        ''             Liaison Variables sql et variables VB 
        ''--------------------------------------------------------------------
        '' exemple
        ''nom_Collaborateur.Value = cb_Affichage_Collaborateurs.SelectedItem

        ''--------------------------------------------------------------------
        ''            Direction des variables (Input, Output, return
        ''--------------------------------------------------------------------
        ''rien ici

        ''--------------------------------------------------------------------
        ''                        Connexion
        ''--------------------------------------------------------------------
        'Requete_Liste_Collaborateur.Connection = ConnexionBDD

        'Try

        '    ConnexionBDD.Open()


        '    'On spéciifie que c'est une exécution en mode lecture 
        '    Dim myReader As SqlDataReader = Requete_Liste_Collaborateur.ExecuteReader()
        '    Dim compteur As Integer

        '    compteur = 0

        '    Do While myReader.Read()
        '        cb_Affichage_Collaborateurs.Items.Add(myReader.GetString(compteur))
        '    Loop


        '    myReader.Close()
        '    ConnexionBDD.Close()


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


        'Avec Le Dataset


        Try
            ConnexionBDD.Open()

            Dim Requete_Liste_Collaborateur As String = "Ps_Liste_Collaborateur"
            Dim MaCommande_Liste_Collaborateur As New SqlCommand(Requete_Liste_Collaborateur, ConnexionBDD)
            Dim Adaptateur_Liste_Collaborateur As New SqlDataAdapter(MaCommande_Liste_Collaborateur)
            Dim MonDataSet As New DataSet

            Try

                Adaptateur_Liste_Collaborateur.Fill(MonDataSet, "COLLABORATEUR")

                Dim myReader As SqlDataReader = MaCommande_Liste_Collaborateur.ExecuteReader()

                Do While myReader.Read()
                    cb_Affichage_Collaborateurs.Items.Add(myReader.GetString(0) + myReader.GetString(1))
                Loop


            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            ConnexionBDD.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try



    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Close()
        Accueuil.Show()
    End Sub

    Private Sub cb_Affichage_Collaborateurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Affichage_Collaborateurs.SelectedIndexChanged
        
        Dim ConnexionBDD As New SqlConnection(str_Connexion)

        Try
            ConnexionBDD.Open()

            Dim Requete_Liste_Collaborateur As String = "Ps_Liste_Collaborateur"
            Dim MaCommande_Collaborateur As New SqlCommand(Requete_Liste_Collaborateur, ConnexionBDD)
            Dim Adaptateur_Collaborateur As New SqlDataAdapter(MaCommande_Collaborateur)
            Dim MonDataSet_Collaborateur As New DataSet

            Try
                Adaptateur_Collaborateur.Fill(MonDataSet_Collaborateur, "COLLABORATEUR")
                index_Selection = cb_Affichage_Collaborateurs.SelectedIndex()
                'Console.WriteLine("============================================================")
                'Console.WriteLine(MonDataSet.Tables("COLLABORATEUR").Rows(index_Selection).Item("NOM_COLLABORATEUR"))
                'Console.WriteLine(MonDataSet_Collaborateur.Tables("COLLABORATEUR").Rows(index_Selection).Item("TELEPHONE_COLLABORATEUR"))
                txt_Nom.Text = MonDataSet_Collaborateur.Tables("COLLABORATEUR").Rows(index_Selection).Item("NOM_COLLABORATEUR")
                txt_Prenom.Text = MonDataSet_Collaborateur.Tables("COLLABORATEUR").Rows(index_Selection).Item("PRENOM_COLLABORATEUR")
                txt_Telephone.Text = MonDataSet_Collaborateur.Tables("COLLABORATEUR").Rows(index_Selection).Item("TELEPHONE_COLLABORATEUR")

                nom_A_Rechercher = txt_Nom.Text
                prenom_A_Rechercher = txt_Prenom.Text
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            ConnexionBDD.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        ''on met le nom complet dans nomination il faudra donc séparer le nom et le prénom
        'Nomination = cb_Affichage_Collaborateurs.SelectedItem

        ''séparation nom et prenom
        ''on cré d'abord un tableau qui va prendre nom col0 et pren col 1 en splitant avec l'espace vide
        'Dim tab() As String
        'TAB = Split(Nomination, " ")

        ''on peut faire aussi tab = split(cb_Affichage_Collaborateurs.SelectedItem, " ") 


        ''on met les valeurs du tableau dans les variables qu'il faut
        'nom_A_Rechercher = tab(0)
        'prenom_A_Rechercher = tab(1)

        ''                                               '/!\'
        ''REMPLISSAGE DESZONES DE TEXTE DANS LA PAGE -> il faudra les rendre innaccessible puis mettre un bouton pour permettre
        ''la modification des données => ce qui implique update de la base de données en même temps
        'txt_Nom.Text = nom_A_Rechercher
        'txt_Prenom.Text = prenom_A_Rechercher

        ''======================================================================================
        ''=================================== Pour L'Adresse ===================================
        ''======================================================================================

        ''--------------------------------------------------------------------
        ''             'Nom connexion : un type de connexion pour tout
        ''--------------------------------------------------------------------
        'Dim ConnexionBDD As New SqlConnection(str_Connexion)

        ''--------------------------------------------------------------------
        ''                               Noms commande de Requête
        ''--------------------------------------------------------------------
        Dim Requete_Adresse1 As SqlCommand = ConnexionBDD.CreateCommand()

        ''--------------------------------------------------------------------
        ''                           Types des Requetes
        ''--------------------------------------------------------------------

        Requete_Adresse1.CommandType = CommandType.StoredProcedure

        ''--------------------------------------------------------------------
        ''              Liaison avec la BDD (procedure, Fonction ... etc
        ''--------------------------------------------------------------------

        Requete_Adresse1.CommandText = "Ps_Mon_Adresse"

        ''--------------------------------------------------------------------
        ''             'Utilisateion du dataset
        ''--------------------------------------------------------------------
        Dim MonAdaptateur As New SqlDataAdapter(Requete_Adresse1)

        'Dim MonDataSet As New DataSet

        ''--------------------------------------------------------------------
        ''             Liaison Variables sql et variables VB 
        ''--------------------------------------------------------------------

        Dim nom_Collaborateur As SqlParameter = Requete_Adresse1.Parameters.Add("@nom_Personne", SqlDbType.VarChar)
        Dim prenom_Collaborateur As SqlParameter = Requete_Adresse1.Parameters.Add("@prenom_personne", SqlDbType.VarChar)



        ''--------------------------------------------------------------------
        ''             Liaison Variables sql et variables VB 
        ''--------------------------------------------------------------------
        nom_Collaborateur.Value = nom_A_Rechercher
        prenom_Collaborateur.Value = prenom_A_Rechercher



        ''--------------------------------------------------------------------
        ''            Direction des variables (Input, Output, return
        ''--------------------------------------------------------------------

        nom_Collaborateur.Direction = ParameterDirection.Input
        prenom_Collaborateur.Direction = ParameterDirection.Input



        ''--------------------------------------------------------------------
        ''                        Connexion Pour les Adresses
        ''--------------------------------------------------------------------
        'Requete_Adresse1.Connection = ConnexionBDD

        Try
            ConnexionBDD.Open()
            Dim Requete_Adresse_Collaborateur As String = "Ps_Mon_Adresse"
            Dim MaCommande As New SqlCommand(Requete_Adresse_Collaborateur, ConnexionBDD)
            Dim Adaptateur As New SqlDataAdapter
            Adaptateur = MonAdaptateur
            Dim MonDataSet_Adresse As New DataSet

            'Dim MonDataSet_Collaborateur As New DataSet
            Try

                Adaptateur.Fill(MonDataSet_Adresse, "COLLABORATEUR,ADRESSE")
                'Tableau stocké
                '-------------------------------------------------------------
                'RUE_ADRESSE1--COMPLEMENT_ADRESSE2--CP_ADRESSE--VILLE_ADRESSE-
                '-------------------------------------------------------------
                'Application du Dataset
                '------------------------------------
                'index_Selection = cb_Affichage_Collaborateurs.SelectedIndex()

                'Console.WriteLine("=======================================")
                'Console.WriteLine(MonDataSet_Adresse.Tables("COLLABORATEUR,ADRESSE").Rows(0).Item("DATE_DEBUT_SALAIRE"))

                'FAIRE GAFFE AUX ESPACES!!!! du genre "COLLABORATEUR, ADRESSE psk pas pareil que "COLLABORATEUR,ADRESSE
                Dim Adresse_Complement As String
                Dim Adresse1 As String

                Adresse1 = MonDataSet_Adresse.Tables("COLLABORATEUR,ADRESSE").Rows(0).Item("RUE_ADRESSE1")
                If IsDBNull(MonDataSet_Adresse.Tables("COLLABORATEUR,ADRESSE").Rows(0).Item("COMPLEMENT_ADRESSE2")) Then
                    Adresse_Complement = "pas de complement d'adresse"
                Else
                    Adresse_Complement = MonDataSet_Adresse.Tables("COLLABORATEUR,ADRESSE").Rows(0).Item("COMPLEMENT_ADRESSE2")
                End If

                txt_Code_Postal.Text = MonDataSet_Adresse.Tables("COLLABORATEUR,ADRESSE").Rows(0).Item("CP_ADRESSE")

                'Mise en MAJUSCULE
                txt_Adresse1.Text = Adresse1.ToUpper
                txt_Adresse_Complement.Text = Adresse_Complement.ToUpper



            Catch ex As Exception
                Console.WriteLine("exception Adresse ==> 1er TRY " + ex.Message)
            End Try
            ConnexionBDD.Close()

        Catch ex As Exception
            MsgBox("exception Adresse ==> 2er TRY " + ex.Message)
        End Try




        '===================================Les salaire=====================================


        Dim Requete_Adresse2 As SqlCommand = ConnexionBDD.CreateCommand()
        Requete_Adresse2.CommandType = CommandType.StoredProcedure
        Requete_Adresse2.CommandText = "Ps_Mon_Salaire"
        Dim MonAdaptateur2 As New SqlDataAdapter(Requete_Adresse2)
        Dim nom_Collaborateur2 As SqlParameter = Requete_Adresse2.Parameters.Add("@nom_Personne", SqlDbType.VarChar)
        Dim prenom_Collaborateur2 As SqlParameter = Requete_Adresse2.Parameters.Add("@prenom_personne", SqlDbType.VarChar)
        nom_Collaborateur2.Value = nom_A_Rechercher
        prenom_Collaborateur2.Value = prenom_A_Rechercher
        nom_Collaborateur2.Direction = ParameterDirection.Input
        prenom_Collaborateur2.Direction = ParameterDirection.Input
        Try
            ConnexionBDD.Open()
            Dim Requete_Salaire_Collaborateur As String = "Ps_Mon_Salaire"
            Dim Macommande_salaire As New SqlCommand(Requete_Salaire_Collaborateur, ConnexionBDD)
            Dim Adaptateur_Salaire As New SqlDataAdapter
            Adaptateur_Salaire = MonAdaptateur2
            Dim MonDataSet_Salaire As New DataSet


            Try
                Adaptateur_Salaire.Fill(MonDataSet_Salaire, "COLLABORATEUR,SALAIRE")
                'Tableau stocké
                '--------------------------------------------------------------------------------------------------------------------
                'MONTANT_SALAIRE--DATE_DEBUT_SALAIRE--DATE_FIN_SALAIRE- 
                '--------------------------------------------------------------------------------------------------------------------
                'Application du Dataset
                '------------------------------------


                Console.WriteLine("=======================================")
                Console.WriteLine(MonDataSet_Salaire.Tables("COLLABORATEUR,SALAIRE").Rows(0).Item("DATE_FIN_SALAIRE"))

                'Les Salaires et les durées de contrats
                txt_Salaire.Text = MonDataSet_Salaire.Tables("COLLABORATEUR,SALAIRE").Rows(0).Item("MONTANT_SALAIRE")
                txt_Debut_Contrat.Text = MonDataSet_Salaire.Tables("COLLABORATEUR,SALAIRE").Rows(0).Item("DATE_DEBUT_SALAIRE")
                Dim Fin_Contrat As String


                If IsDBNull(MonDataSet_Salaire.Tables("COLLABORATEUR,SALAIRE").Rows(0).Item("DATE_FIN_SALAIRE")) Then
                    Fin_Contrat = "CDI"
                Else
                    Fin_Contrat = MonDataSet_Salaire.Tables("COLLABORATEUR,SALAIRE").Rows(0).Item("DATE_FIN_SALAIRE")
                End If

                txt_Fin_Contrat.Text = Fin_Contrat

                'Console.WriteLine("****************************************")
                'Console.WriteLine(txt_Fin_Contrat.Text)
                'Mise en MAJUSCULE



            Catch ex As Exception
                Console.WriteLine("exception Salaire ==> 1er TRY " + nom_A_Rechercher.ToString + ex.Message)
            End Try
            ConnexionBDD.Close()

        Catch ex As Exception
            MsgBox("exception Salaire ==> dans 2er TRY " + ex.Message)
        End Try





        ' Dim ConnexionBDD As New SqlConnection(str_Connexion)

        'Try
        '    ConnexionBDD.Open()

        '    Dim Requete_Liste_Projet As String = "[dbo].[Ps_Mon_Adresse]"
        '    Dim MaCommande As New SqlCommand(Requete_Liste_Projet, ConnexionBDD)
        '    Dim Adaptateur As New SqlDataAdapter(MaCommande)
        '    Dim MonDataSet_Adresse As New DataSet
        '    'Dim MonDataSet_Collaborateur As New DataSet

        '    Try

        '        Adaptateur.Fill(MonDataSet_Adresse, "COLLABORATEUR, ADRESSE")

        '        '------------------------------------------------------------------------------------------------------
        '        'NOM_COLLABORATEUR--PRENOM_COLLABORATEUR--RUE_ADRESSE1--COMPLEMENT_ADRESSE2--CP_ADRESSE--VILLE_ADRESSE-
        '        '------------------------------------------------------------------------------------------------------
        '        'Application du Dataset
        '        '------------------------------------
        '        index_Selection = cb_Affichage_Collaborateurs.SelectedIndex()
        '        Console.WriteLine("=======================================")
        '        Console.WriteLine(MonDataSet_Adresse.Tables("COLLABORATEUR, ADRESSE").Rows(index_Selection).Item("NOM_COLLABORATEUR"))
        '        'lbl_Affichage_Abreviation.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("LIBELLE_COURT")
        '        'lbl_Affichage_date_Previsionnelle_Debut.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("DATE_PREVISIONNELLE_DEBUT")
        '        'lbl_Affichage_date_Previsionnelle_Fin.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("DATE_PREVISIONNELLE_FIN")
        '        'lbl_Affichage_date_Reelle_Debut.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("DATE_REELLE_DEBUT")
        '        'lbl_Affichage_date_Reelle_Fin.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("DATE_REELLE_FIN")
        '        'lbl_Affichage_Nbr_Max_Equipe.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("TAILLE_MAXI_EQUIPE")
        '    Catch ex As Exception
        '        Console.WriteLine(ex.Message)
        '    End Try

        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try
        ''fin




    End Sub



    Private Sub cb_Collaborateur_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_Prenom_TextChanged(sender As Object, e As EventArgs) Handles txt_Prenom.TextChanged

    End Sub

    Private Sub txt_Nom_TextChanged(sender As Object, e As EventArgs) Handles txt_Nom.TextChanged

    End Sub

    Private Sub txt_Code_Postal_TextChanged(sender As Object, e As EventArgs) Handles txt_Code_Postal.TextChanged

    End Sub

    Private Sub btn_Modifier_Click(sender As Object, e As EventArgs) Handles btn_Modifier.Click
        txt_Adresse1.ReadOnly = False
        txt_Adresse_Complement.ReadOnly = False
        txt_Code_Postal.ReadOnly = False
        txt_Fin_Contrat.ReadOnly = False
        txt_Nom.ReadOnly = False
        txt_Telephone.ReadOnly = False
        txt_Salaire.ReadOnly = False
        btn_Valider.Show()
        btn_Modifier.Hide()


    End Sub

    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click
        'verifier si les champs ont changé avant de mettre à jour 



        txt_Adresse1.ReadOnly = True
        txt_Adresse_Complement.ReadOnly = True
        txt_Code_Postal.ReadOnly = True
        txt_Fin_Contrat.ReadOnly = True
        txt_Nom.ReadOnly = True
        txt_Telephone.ReadOnly = True
        txt_Salaire.ReadOnly = True
        btn_Modifier.Show()
        btn_Valider.Hide()
    End Sub

    Private Sub txt_Nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Nom.KeyPress
        'empecher d ecrire autre chose que des lettres 
        If (Char.IsSymbol(e.KeyChar)) Then
            e.Handled = True
        End If
        If (Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
        End If

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Prenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Prenom.KeyPress
        'empecher d ecrire autre chose que des lettres 
        If (Char.IsSymbol(e.KeyChar)) Then
            e.Handled = True
        End If
        If (Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
        End If

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Code_Postal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Code_Postal.KeyPress
        'empecher d  kkk ecrire autre chose que des lettres 
        If (Char.IsSymbol(e.KeyChar)) Then
            e.Handled = True
        End If
        If (Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
        End If

        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class