Imports System.Data.SqlClient

Public Class Fenetre_Principale
    Public Changement_Login As Boolean
    Public Changement_Mdp As Boolean
    Public res As Integer

    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click

        If Radio_AFPA.Checked() Then
            str_Connexion = str_Connexion_AFPA
        End If
        If Radio_Home.Checked Then
            str_Connexion = str_Connexion_Home
        End If

        Dim ConnexionBDD As New SqlConnection(str_Connexion)
        Dim Requete_ConnexionUtilisateur As New SqlCommand()

        Requete_ConnexionUtilisateur.CommandType = CommandType.StoredProcedure
        'Requete_ConnexionUtilisateur.CommandText = "Ajout_Utilisateur"
        Requete_ConnexionUtilisateur.CommandText = "Ps_Verification"
        Dim Login_Utilisateur As SqlParameter = Requete_ConnexionUtilisateur.Parameters.Add("@Mon_login", SqlDbType.VarChar)
        Dim Mdp_Utilisateur As SqlParameter = Requete_ConnexionUtilisateur.Parameters.Add("@Mon_motDePasse", SqlDbType.VarChar)

        Login_Utilisateur.Value = txt_Login.Text
        Mdp_Utilisateur.Value = txt_Mot_De_Passe.Text

        Login_Utilisateur.Direction = ParameterDirection.Input
        Mdp_Utilisateur.Direction = ParameterDirection.Input

        Dim return_value As SqlParameter = Requete_ConnexionUtilisateur.Parameters.Add("@retour", SqlDbType.Int)
        return_value.Direction = ParameterDirection.ReturnValue 'permet de dire que c'est la valeur retourner qui est mis dedans

        Requete_ConnexionUtilisateur.Connection = ConnexionBDD



        '----------------------------------------------------------------------------------------------------
        'Lorsque c'est une requête utilisé comme en sql on utilise celui là'
        'Requete_ConnexionUtilisateur.CommandType = CommandType.Text
        'Requete_ConnexionUtilisateur.CommandText = "INSERT INTO NATURE VALUES ('" + txt_LOG.Text + "')"
        'Requete_ConnexionUtilisateur.Connection = ConnexionBDD
        '-----------------------------------------------------------------------------------------------------------



        Try
            ConnexionBDD.Open()
            Requete_ConnexionUtilisateur.ExecuteNonQuery()
            res = return_value.Value
            ConnexionBDD.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If (res = 0) Then
            MsgBox("Le login est incorrect")

        Else
            If (res = -1) Then
                MsgBox("Le Mot de passe est incorrect")
            Else
                'MsgBox("vous êtes : " + txt_Login.Text + " et votre mot de passe : " + txt_Mot_De_Passe.Text)
                Me.Hide()
                Accueuil.Show()
            End If
        End If

    End Sub


    Private Sub txt_Login_TextChanged(sender As Object, e As EventArgs) Handles txt_Login.TextChanged

    End Sub

    Private Sub txt_Mot_De_Passe_TextChanged(sender As Object, e As EventArgs) Handles txt_Mot_De_Passe.TextChanged
        btn_Valider.Enabled = True
    End Sub

    Private Sub Fenetre_Principale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
