Public Class Client
    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Active_Final_CommunDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.CLIENTTableAdapter.Fill(Me.Active_Final_CommunDataSet.CLIENT)


    End Sub

    Private Sub btn_DataGrid_Click(sender As Object, e As EventArgs) Handles btn_DataGrid.Click
        DG_view_Client.Show()
        btn_DataGrid.Hide()
        btn_Cacher_Client.Show()
    End Sub

    Private Sub btn_Cacher_Client_Click(sender As Object, e As EventArgs) Handles btn_Cacher_Client.Click
        DG_view_Client.Hide()
        btn_DataGrid.Show()
        btn_Cacher_Client.Hide()
    End Sub

    Private Sub btn_Retour_Click(sender As Object, e As EventArgs) Handles btn_Retour.Click
        Me.Close()
        Accueuil.Show()
    End Sub

    Private Sub DG_view_Client_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_view_Client.CellContentClick

    End Sub
End Class