Public Class Client
    Public Je_Suis_A_La_Maison As Boolean
    Public OUI As Boolean = True
    Public NON As Boolean = False

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Je_Suis_A_La_Maison = NON
        If Fenetre_Principale.Radio_Home.Checked Then
            Je_Suis_A_La_Maison = OUI
        End If

        If Je_Suis_A_La_Maison = OUI Then
            'TODO: cette ligne de code charge les données dans la table 'Active_Final_CommunDataSet2.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            Me.CLIENTTableAdapter1.Fill(Me.Active_Final_CommunDataSet2.CLIENT)
        Else
            'TODO: cette ligne de code charge les données dans la table 'Active_Final_CommunDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            Me.CLIENTTableAdapter.Fill(Me.Active_Final_CommunDataSet.CLIENT)
        End If

    End Sub

    Private Sub btn_DataGrid_Click(sender As Object, e As EventArgs) Handles btn_DataGrid.Click
        If Je_Suis_A_La_Maison = NON Then
            DG_view_Client.Show()
            btn_DataGrid.Hide()
            btn_Cacher_Client.Show()
        Else
            DG_Client_Home.Show()
            btn_DataGrid.Hide()
            btn_Cacher_Client.Show()
        End If

    End Sub

    Private Sub btn_Cacher_Client_Click(sender As Object, e As EventArgs) Handles btn_Cacher_Client.Click
        If Je_Suis_A_La_Maison = NON Then

            DG_view_Client.Hide()
            btn_DataGrid.Show()
            btn_Cacher_Client.Hide()
        Else
            DG_Client_Home.Hide()
            btn_DataGrid.Show()
            btn_Cacher_Client.Hide()
        End If
    End Sub

    Private Sub btn_Retour_Click(sender As Object, e As EventArgs) Handles btn_Retour.Click
        Me.Close()
        Accueuil.Show()
    End Sub

    Private Sub DG_view_Client_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_view_Client.CellContentClick

    End Sub

    Private Sub DG_Client_Home_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Client_Home.CellContentClick

    End Sub
End Class