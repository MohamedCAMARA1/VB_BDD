<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Client
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DG_view_Client = New System.Windows.Forms.DataGridView()
        Me.IDCLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDADRESSEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDNATUREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAISONSOCIALEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPECLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EFFECTIFCLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHIFFREDAFFAIRESKEUROSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCONTACTCLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENOMCONTACTCLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FONCTIONCONTACTCLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Active_Final_CommunDataSet = New VB_BDD_FilRouge.Active_Final_CommunDataSet()
        Me.CLIENTTableAdapter = New VB_BDD_FilRouge.Active_Final_CommunDataSetTableAdapters.CLIENTTableAdapter()
        Me.btn_DataGrid = New System.Windows.Forms.Button()
        Me.btn_Cacher_Client = New System.Windows.Forms.Button()
        Me.btn_Retour = New System.Windows.Forms.Button()
        CType(Me.DG_view_Client, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_view_Client
        '
        Me.DG_view_Client.AutoGenerateColumns = False
        Me.DG_view_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_view_Client.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCLIENTDataGridViewTextBoxColumn, Me.IDADRESSEDataGridViewTextBoxColumn, Me.IDNATUREDataGridViewTextBoxColumn, Me.RAISONSOCIALEDataGridViewTextBoxColumn, Me.TYPECLIENTDataGridViewTextBoxColumn, Me.EFFECTIFCLIENTDataGridViewTextBoxColumn, Me.CHIFFREDAFFAIRESKEUROSDataGridViewTextBoxColumn, Me.NOMCONTACTCLIENTDataGridViewTextBoxColumn, Me.PRENOMCONTACTCLIENTDataGridViewTextBoxColumn, Me.FONCTIONCONTACTCLIENTDataGridViewTextBoxColumn})
        Me.DG_view_Client.DataSource = Me.CLIENTBindingSource
        Me.DG_view_Client.Location = New System.Drawing.Point(12, 12)
        Me.DG_view_Client.Name = "DG_view_Client"
        Me.DG_view_Client.Size = New System.Drawing.Size(1106, 242)
        Me.DG_view_Client.TabIndex = 0
        Me.DG_view_Client.Visible = False
        '
        'IDCLIENTDataGridViewTextBoxColumn
        '
        Me.IDCLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENT"
        Me.IDCLIENTDataGridViewTextBoxColumn.HeaderText = "ID_CLIENT"
        Me.IDCLIENTDataGridViewTextBoxColumn.Name = "IDCLIENTDataGridViewTextBoxColumn"
        Me.IDCLIENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDADRESSEDataGridViewTextBoxColumn
        '
        Me.IDADRESSEDataGridViewTextBoxColumn.DataPropertyName = "ID_ADRESSE"
        Me.IDADRESSEDataGridViewTextBoxColumn.HeaderText = "ID_ADRESSE"
        Me.IDADRESSEDataGridViewTextBoxColumn.Name = "IDADRESSEDataGridViewTextBoxColumn"
        '
        'IDNATUREDataGridViewTextBoxColumn
        '
        Me.IDNATUREDataGridViewTextBoxColumn.DataPropertyName = "ID_NATURE"
        Me.IDNATUREDataGridViewTextBoxColumn.HeaderText = "ID_NATURE"
        Me.IDNATUREDataGridViewTextBoxColumn.Name = "IDNATUREDataGridViewTextBoxColumn"
        '
        'RAISONSOCIALEDataGridViewTextBoxColumn
        '
        Me.RAISONSOCIALEDataGridViewTextBoxColumn.DataPropertyName = "RAISON_SOCIALE"
        Me.RAISONSOCIALEDataGridViewTextBoxColumn.HeaderText = "RAISON_SOCIALE"
        Me.RAISONSOCIALEDataGridViewTextBoxColumn.Name = "RAISONSOCIALEDataGridViewTextBoxColumn"
        '
        'TYPECLIENTDataGridViewTextBoxColumn
        '
        Me.TYPECLIENTDataGridViewTextBoxColumn.DataPropertyName = "TYPE_CLIENT"
        Me.TYPECLIENTDataGridViewTextBoxColumn.HeaderText = "TYPE_CLIENT"
        Me.TYPECLIENTDataGridViewTextBoxColumn.Name = "TYPECLIENTDataGridViewTextBoxColumn"
        '
        'EFFECTIFCLIENTDataGridViewTextBoxColumn
        '
        Me.EFFECTIFCLIENTDataGridViewTextBoxColumn.DataPropertyName = "EFFECTIF_CLIENT"
        Me.EFFECTIFCLIENTDataGridViewTextBoxColumn.HeaderText = "EFFECTIF_CLIENT"
        Me.EFFECTIFCLIENTDataGridViewTextBoxColumn.Name = "EFFECTIFCLIENTDataGridViewTextBoxColumn"
        '
        'CHIFFREDAFFAIRESKEUROSDataGridViewTextBoxColumn
        '
        Me.CHIFFREDAFFAIRESKEUROSDataGridViewTextBoxColumn.DataPropertyName = "CHIFFRE_D_AFFAIRES_KEUROS"
        Me.CHIFFREDAFFAIRESKEUROSDataGridViewTextBoxColumn.HeaderText = "CHIFFRE_D_AFFAIRES_KEUROS"
        Me.CHIFFREDAFFAIRESKEUROSDataGridViewTextBoxColumn.Name = "CHIFFREDAFFAIRESKEUROSDataGridViewTextBoxColumn"
        '
        'NOMCONTACTCLIENTDataGridViewTextBoxColumn
        '
        Me.NOMCONTACTCLIENTDataGridViewTextBoxColumn.DataPropertyName = "NOM_CONTACT_CLIENT"
        Me.NOMCONTACTCLIENTDataGridViewTextBoxColumn.HeaderText = "NOM_CONTACT_CLIENT"
        Me.NOMCONTACTCLIENTDataGridViewTextBoxColumn.Name = "NOMCONTACTCLIENTDataGridViewTextBoxColumn"
        '
        'PRENOMCONTACTCLIENTDataGridViewTextBoxColumn
        '
        Me.PRENOMCONTACTCLIENTDataGridViewTextBoxColumn.DataPropertyName = "PRENOM_CONTACT_CLIENT"
        Me.PRENOMCONTACTCLIENTDataGridViewTextBoxColumn.HeaderText = "PRENOM_CONTACT_CLIENT"
        Me.PRENOMCONTACTCLIENTDataGridViewTextBoxColumn.Name = "PRENOMCONTACTCLIENTDataGridViewTextBoxColumn"
        '
        'FONCTIONCONTACTCLIENTDataGridViewTextBoxColumn
        '
        Me.FONCTIONCONTACTCLIENTDataGridViewTextBoxColumn.DataPropertyName = "FONCTION_CONTACT_CLIENT"
        Me.FONCTIONCONTACTCLIENTDataGridViewTextBoxColumn.HeaderText = "FONCTION_CONTACT_CLIENT"
        Me.FONCTIONCONTACTCLIENTDataGridViewTextBoxColumn.Name = "FONCTIONCONTACTCLIENTDataGridViewTextBoxColumn"
        '
        'CLIENTBindingSource
        '
        Me.CLIENTBindingSource.DataMember = "CLIENT"
        Me.CLIENTBindingSource.DataSource = Me.Active_Final_CommunDataSet
        '
        'Active_Final_CommunDataSet
        '
        Me.Active_Final_CommunDataSet.DataSetName = "Active_Final_CommunDataSet"
        Me.Active_Final_CommunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTTableAdapter
        '
        Me.CLIENTTableAdapter.ClearBeforeFill = True
        '
        'btn_DataGrid
        '
        Me.btn_DataGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DataGrid.Location = New System.Drawing.Point(12, 379)
        Me.btn_DataGrid.Name = "btn_DataGrid"
        Me.btn_DataGrid.Size = New System.Drawing.Size(248, 67)
        Me.btn_DataGrid.TabIndex = 1
        Me.btn_DataGrid.Text = "Afficher tous les clients et leurs info"
        Me.btn_DataGrid.UseVisualStyleBackColor = True
        '
        'btn_Cacher_Client
        '
        Me.btn_Cacher_Client.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cacher_Client.Location = New System.Drawing.Point(12, 379)
        Me.btn_Cacher_Client.Name = "btn_Cacher_Client"
        Me.btn_Cacher_Client.Size = New System.Drawing.Size(248, 67)
        Me.btn_Cacher_Client.TabIndex = 2
        Me.btn_Cacher_Client.Text = "Cacher tous les clients et leurs info"
        Me.btn_Cacher_Client.UseVisualStyleBackColor = True
        Me.btn_Cacher_Client.Visible = False
        '
        'btn_Retour
        '
        Me.btn_Retour.BackColor = System.Drawing.Color.Gray
        Me.btn_Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Retour.ForeColor = System.Drawing.Color.Black
        Me.btn_Retour.Location = New System.Drawing.Point(1035, 415)
        Me.btn_Retour.Name = "btn_Retour"
        Me.btn_Retour.Size = New System.Drawing.Size(92, 37)
        Me.btn_Retour.TabIndex = 3
        Me.btn_Retour.Text = "Accueil"
        Me.btn_Retour.UseVisualStyleBackColor = False
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1130, 458)
        Me.Controls.Add(Me.btn_Retour)
        Me.Controls.Add(Me.btn_Cacher_Client)
        Me.Controls.Add(Me.btn_DataGrid)
        Me.Controls.Add(Me.DG_view_Client)
        Me.Name = "Client"
        Me.Text = "Client"
        CType(Me.DG_view_Client, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DG_view_Client As DataGridView
    Friend WithEvents Active_Final_CommunDataSet As Active_Final_CommunDataSet
    Friend WithEvents CLIENTBindingSource As BindingSource
    Friend WithEvents CLIENTTableAdapter As Active_Final_CommunDataSetTableAdapters.CLIENTTableAdapter
    Friend WithEvents IDCLIENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDADRESSEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDNATUREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RAISONSOCIALEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TYPECLIENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EFFECTIFCLIENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CHIFFREDAFFAIRESKEUROSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMCONTACTCLIENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRENOMCONTACTCLIENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FONCTIONCONTACTCLIENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_DataGrid As Button
    Friend WithEvents btn_Cacher_Client As Button
    Friend WithEvents btn_Retour As Button
End Class
