<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueuil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Client = New System.Windows.Forms.Button()
        Me.btn_Collaborateur = New System.Windows.Forms.Button()
        Me.btn_Projet = New System.Windows.Forms.Button()
        Me.lbl_BienVenu = New System.Windows.Forms.Label()
        Me.lbl_Affichage_Nom = New System.Windows.Forms.Label()
        Me.btn_Deconnexion = New System.Windows.Forms.Button()
        Me.btn_Ajout = New System.Windows.Forms.Button()
        Me.lbl_statut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Client
        '
        Me.btn_Client.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Client.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Client.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Client.Location = New System.Drawing.Point(25, 98)
        Me.btn_Client.Name = "btn_Client"
        Me.btn_Client.Size = New System.Drawing.Size(338, 105)
        Me.btn_Client.TabIndex = 0
        Me.btn_Client.Text = "CLIENT"
        Me.btn_Client.UseVisualStyleBackColor = False
        '
        'btn_Collaborateur
        '
        Me.btn_Collaborateur.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_Collaborateur.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Collaborateur.Location = New System.Drawing.Point(444, 98)
        Me.btn_Collaborateur.Name = "btn_Collaborateur"
        Me.btn_Collaborateur.Size = New System.Drawing.Size(316, 105)
        Me.btn_Collaborateur.TabIndex = 0
        Me.btn_Collaborateur.Text = "COLLABORATEUR"
        Me.btn_Collaborateur.UseVisualStyleBackColor = False
        '
        'btn_Projet
        '
        Me.btn_Projet.BackColor = System.Drawing.Color.OliveDrab
        Me.btn_Projet.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Projet.Location = New System.Drawing.Point(444, 238)
        Me.btn_Projet.Name = "btn_Projet"
        Me.btn_Projet.Size = New System.Drawing.Size(311, 105)
        Me.btn_Projet.TabIndex = 0
        Me.btn_Projet.Text = "PROJET"
        Me.btn_Projet.UseVisualStyleBackColor = False
        '
        'lbl_BienVenu
        '
        Me.lbl_BienVenu.AutoSize = True
        Me.lbl_BienVenu.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BienVenu.Location = New System.Drawing.Point(180, 21)
        Me.lbl_BienVenu.Name = "lbl_BienVenu"
        Me.lbl_BienVenu.Size = New System.Drawing.Size(179, 34)
        Me.lbl_BienVenu.TabIndex = 1
        Me.lbl_BienVenu.Text = "Bienvenue :"
        '
        'lbl_Affichage_Nom
        '
        Me.lbl_Affichage_Nom.AutoSize = True
        Me.lbl_Affichage_Nom.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Affichage_Nom.Location = New System.Drawing.Point(369, 21)
        Me.lbl_Affichage_Nom.Name = "lbl_Affichage_Nom"
        Me.lbl_Affichage_Nom.Size = New System.Drawing.Size(0, 34)
        Me.lbl_Affichage_Nom.TabIndex = 1
        '
        'btn_Deconnexion
        '
        Me.btn_Deconnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Deconnexion.Font = New System.Drawing.Font("Juice ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Deconnexion.Location = New System.Drawing.Point(634, 396)
        Me.btn_Deconnexion.Name = "btn_Deconnexion"
        Me.btn_Deconnexion.Size = New System.Drawing.Size(153, 43)
        Me.btn_Deconnexion.TabIndex = 2
        Me.btn_Deconnexion.Text = "Déconnexion"
        Me.btn_Deconnexion.UseVisualStyleBackColor = False
        '
        'btn_Ajout
        '
        Me.btn_Ajout.BackColor = System.Drawing.Color.Gray
        Me.btn_Ajout.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ajout.Location = New System.Drawing.Point(25, 238)
        Me.btn_Ajout.Name = "btn_Ajout"
        Me.btn_Ajout.Size = New System.Drawing.Size(338, 105)
        Me.btn_Ajout.TabIndex = 0
        Me.btn_Ajout.Text = "Administration"
        Me.btn_Ajout.UseVisualStyleBackColor = False
        Me.btn_Ajout.Visible = False
        '
        'lbl_statut
        '
        Me.lbl_statut.AutoSize = True
        Me.lbl_statut.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statut.Location = New System.Drawing.Point(34, 404)
        Me.lbl_statut.Name = "lbl_statut"
        Me.lbl_statut.Size = New System.Drawing.Size(0, 34)
        Me.lbl_statut.TabIndex = 3
        '
        'Accueuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 456)
        Me.Controls.Add(Me.lbl_statut)
        Me.Controls.Add(Me.btn_Deconnexion)
        Me.Controls.Add(Me.lbl_Affichage_Nom)
        Me.Controls.Add(Me.lbl_BienVenu)
        Me.Controls.Add(Me.btn_Ajout)
        Me.Controls.Add(Me.btn_Projet)
        Me.Controls.Add(Me.btn_Collaborateur)
        Me.Controls.Add(Me.btn_Client)
        Me.Name = "Accueuil"
        Me.Text = "Accueuil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Client As Button
    Friend WithEvents btn_Collaborateur As Button
    Friend WithEvents btn_Projet As Button
    Friend WithEvents lbl_BienVenu As Label
    Friend WithEvents lbl_Affichage_Nom As Label
    Friend WithEvents btn_Deconnexion As Button
    Friend WithEvents btn_Ajout As Button
    Friend WithEvents lbl_statut As Label
End Class
