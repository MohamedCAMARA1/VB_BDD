Imports System.Data.SqlClient

Public Class Projets
    'Pour recuperer l'index de ce qui est selectionner dans la combobox
    'cet index devienda la ligne à selectionner pour le Dataset
    Public index_selection As Integer

    Private Sub Projets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim ConnexionBDD As New SqlConnection(str_Connexion)
        ''======================================================================================
        ''============================= Pour La liste Projetr=============================
        ''======================================================================================

        ''--------------------------------------------------------------------
        ''                               Noms Requêtes
        ''--------------------------------------------------------------------
        'Dim Requete_Liste_Projet As SqlCommand = ConnexionBDD.CreateCommand()

        ''--------------------------------------------------------------------
        ''                           Types des Requetes
        ''--------------------------------------------------------------------
        'Requete_Liste_Projet.CommandType = CommandType.StoredProcedure

        ''--------------------------------------------------------------------
        ''              Liaison avec la BDD (procedure, Fonction ... etc
        ''--------------------------------------------------------------------
        'Requete_Liste_Projet.CommandText = "Ps_Liste_Collaborateur"

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
        'rien ici

        '--------------------------------------------------------------------
        '                        Connexion
        ''--------------------------------------------------------------------
        'Requete_Liste_Projet.Connection = ConnexionBDD

        'Try

        '    ConnexionBDD.Open()


        '    'On spéciifie que c'est une exécution en mode lecture 
        '    Dim myReader As SqlDataReader = Requete_Liste_Projet.ExecuteReader()
        '    Dim compteur As Integer

        '    compteur = 0

        '    Do While myReader.Read()
        '        cb_Affichage_Projets.Items.Add(myReader.GetString(compteur))
        '    Loop


        '    myReader.Close()
        '    ConnexionBDD.Close()


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


        'deb
        Dim ConnexionBDD As New SqlConnection(str_Connexion)

        Try
            ConnexionBDD.Open()

            Dim Requete_Liste_Projet As String = "[dbo].[Ps_Liste_Projet]"
            Dim MaCommande As New SqlCommand(Requete_Liste_Projet, ConnexionBDD)
            Dim Adaptateur As New SqlDataAdapter(MaCommande)
            Dim MonDataSet As New DataSet

            Try

                Adaptateur.Fill(MonDataSet, "PROJET")

                Dim myReader As SqlDataReader = MaCommande.ExecuteReader()
                ' Dim compteur As Integer
                'compteur = 1

                Do While myReader.Read()
                    '1 pour qu'on ait le libellé lon : 2ecolonne
                    cb_Affichage_Projets.Items.Add(myReader.GetString(1))
                Loop

                'Tableau qui est mit dans le Dataset
                'LIBELLE_COURT,LIBELLE_LONG, DATE_PREVISIONNELLE_DEBUT, DATE_REELLE_DEBUT,
                'DATE_PREVISIONNELLE_FIN, DATE_REELLE_FIN, TAILLE_MAXI_EQUIPE


            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            ConnexionBDD.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        'fin


    End Sub

    Private Sub btn_Projet_Retour_Accueil_Click(sender As Object, e As EventArgs) Handles btn_Projet_Retour_Accueil.Click
        Me.Close()
        Accueuil.Show()

    End Sub

    Private Sub cb_Affichage_Projets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Affichage_Projets.SelectedIndexChanged


        Dim ConnexionBDD As New SqlConnection(str_Connexion)

        Try
            ConnexionBDD.Open()

            Dim Requete_Liste_Projet As String = "[dbo].[Ps_Liste_Projet]"
            Dim MaCommande As New SqlCommand(Requete_Liste_Projet, ConnexionBDD)
            Dim Adaptateur As New SqlDataAdapter(MaCommande)
            Dim MonDataSet As New DataSet

            Try

                Adaptateur.Fill(MonDataSet, "PROJET")
                ' Dim myReader As SqlDataReader = MaCommande.ExecuteReader()
                '------------------------------------------------------------------------------------------------------------------------------------------
                'LIBELLE_COURT--LIBELLE_LONG--DATE_PREVISIONNELLE_DEBUT--DATE_REELLE_DEBUT--DATE_PREVISIONNELLE_FIN--DATE_REELLE_FIN--TAILLE_MAXI_EQUIPE -
                '------------------------------------------------------------------------------------------------------------------------------------------
                'Application du Dataset
                '------------------------------------
                index_selection = cb_Affichage_Projets.SelectedIndex()
                lbl_Affichage_Abreviation.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("LIBELLE_COURT")
                lbl_Affichage_date_Previsionnelle_Debut.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("DATE_PREVISIONNELLE_DEBUT")
                lbl_Affichage_date_Previsionnelle_Fin.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("DATE_PREVISIONNELLE_FIN")
                lbl_Affichage_date_Reelle_Debut.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("DATE_REELLE_DEBUT")
                lbl_Affichage_date_Reelle_Fin.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("DATE_REELLE_FIN")
                lbl_Affichage_Nbr_Max_Equipe.Text = MonDataSet.Tables("PROJET").Rows(index_selection).Item("TAILLE_MAXI_EQUIPE")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            ConnexionBDD.Close()
        Catch ex As Exception
            Console.WriteLine("error projet" + ex.Message)
        End Try
        'fin





    End Sub

    Private Sub cb_Affichage_Projets_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_Affichage_Projets.SelectedValueChanged

    End Sub

    Private Sub cb_Affichage_Projets_Validated(sender As Object, e As EventArgs) Handles cb_Affichage_Projets.Validated

    End Sub
End Class