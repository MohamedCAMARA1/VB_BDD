Imports System.Data.SqlClient

Public Class Administration
    Public choix_Statut As Integer = 3

    Private Sub Administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Sub radio_Invite_CheckedChanged(sender As Object, e As EventArgs) Handles radio_Admin.CheckedChanged, radio_Client.CheckedChanged, radio_Collaborateur.CheckedChanged

    End Sub

    Private Sub btn_ajouter_utilisateur_Click(sender As Object, e As EventArgs) Handles btn_ajouter_utilisateur.Click

        If radio_Admin.Checked = True Then
            choix_Statut = 1
        End If

        If radio_Collaborateur.Checked = True Then
            choix_Statut = 2
        End If

        If radio_Client.Checked = True Then
            choix_Statut = 3
        End If

        Dim ConnexionBDD As New SqlConnection(str_Connexion)
        Dim Requete_Ajout_Utilisateur As New SqlCommand()

        Requete_Ajout_Utilisateur.CommandType = CommandType.StoredProcedure
        Requete_Ajout_Utilisateur.CommandText = "Ajout_Utilisateur"

        Dim Login_Utilisateur As SqlParameter = Requete_Ajout_Utilisateur.Parameters.Add("@Nom_Utilisateur", SqlDbType.VarChar)
        Dim Mdp_Utilisateur As SqlParameter = Requete_Ajout_Utilisateur.Parameters.Add("@motDePasse", SqlDbType.VarChar)
        Dim profil_Utilisateur As SqlParameter = Requete_Ajout_Utilisateur.Parameters.Add("@Profile_Utilisateur", SqlDbType.Int)

        Login_Utilisateur.Value = txt_Ajout_Nom.Text.ToUpper() + "." + txt_Ajout_Prenom.Text
        Mdp_Utilisateur.Value = txt_Ajout_Mot_De_Passe.Text
        profil_Utilisateur.Value = choix_Statut

        Login_Utilisateur.Direction = ParameterDirection.Input
        Mdp_Utilisateur.Direction = ParameterDirection.Input
        profil_Utilisateur.Direction = ParameterDirection.Input

        Requete_Ajout_Utilisateur.Connection = ConnexionBDD

        Try
            ConnexionBDD.Open()
            Requete_Ajout_Utilisateur.ExecuteNonQuery()
            ConnexionBDD.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'MsgBox("L'utilisateur à été ajouté")
        Me.Close()
        Accueuil.Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub btn_Annule_Click(sender As Object, e As EventArgs) Handles btn_Annule.Click
        Me.Close()
        Accueuil.Show()
    End Sub
End Class