<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administration
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
        Me.txt_Ajout_Prenom = New System.Windows.Forms.TextBox()
        Me.txt_Ajout_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Ajout_Mot_De_Passe = New System.Windows.Forms.TextBox()
        Me.lbl_Prenom_Ajout = New System.Windows.Forms.Label()
        Me.lbl_Nom_Ajout = New System.Windows.Forms.Label()
        Me.lbl_Mot_de_Passe_Ajout = New System.Windows.Forms.Label()
        Me.lbl_Titre_Admin = New System.Windows.Forms.Label()
        Me.lbl_Choix_Statut = New System.Windows.Forms.Label()
        Me.btn_ajouter_utilisateur = New System.Windows.Forms.Button()
        Me.radio_Admin = New System.Windows.Forms.RadioButton()
        Me.radio_Collaborateur = New System.Windows.Forms.RadioButton()
        Me.radio_Client = New System.Windows.Forms.RadioButton()
        Me.btn_Annule = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_Ajout_Prenom
        '
        Me.txt_Ajout_Prenom.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ajout_Prenom.Location = New System.Drawing.Point(28, 89)
        Me.txt_Ajout_Prenom.Name = "txt_Ajout_Prenom"
        Me.txt_Ajout_Prenom.Size = New System.Drawing.Size(246, 28)
        Me.txt_Ajout_Prenom.TabIndex = 0
        '
        'txt_Ajout_Nom
        '
        Me.txt_Ajout_Nom.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ajout_Nom.Location = New System.Drawing.Point(385, 89)
        Me.txt_Ajout_Nom.Name = "txt_Ajout_Nom"
        Me.txt_Ajout_Nom.Size = New System.Drawing.Size(246, 28)
        Me.txt_Ajout_Nom.TabIndex = 0
        '
        'txt_Ajout_Mot_De_Passe
        '
        Me.txt_Ajout_Mot_De_Passe.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ajout_Mot_De_Passe.Location = New System.Drawing.Point(28, 200)
        Me.txt_Ajout_Mot_De_Passe.Name = "txt_Ajout_Mot_De_Passe"
        Me.txt_Ajout_Mot_De_Passe.Size = New System.Drawing.Size(246, 28)
        Me.txt_Ajout_Mot_De_Passe.TabIndex = 0
        '
        'lbl_Prenom_Ajout
        '
        Me.lbl_Prenom_Ajout.AutoSize = True
        Me.lbl_Prenom_Ajout.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prenom_Ajout.Location = New System.Drawing.Point(25, 62)
        Me.lbl_Prenom_Ajout.Name = "lbl_Prenom_Ajout"
        Me.lbl_Prenom_Ajout.Size = New System.Drawing.Size(76, 21)
        Me.lbl_Prenom_Ajout.TabIndex = 2
        Me.lbl_Prenom_Ajout.Text = "Prénom"
        '
        'lbl_Nom_Ajout
        '
        Me.lbl_Nom_Ajout.AutoSize = True
        Me.lbl_Nom_Ajout.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nom_Ajout.Location = New System.Drawing.Point(381, 62)
        Me.lbl_Nom_Ajout.Name = "lbl_Nom_Ajout"
        Me.lbl_Nom_Ajout.Size = New System.Drawing.Size(49, 21)
        Me.lbl_Nom_Ajout.TabIndex = 2
        Me.lbl_Nom_Ajout.Text = "Nom"
        '
        'lbl_Mot_de_Passe_Ajout
        '
        Me.lbl_Mot_de_Passe_Ajout.AutoSize = True
        Me.lbl_Mot_de_Passe_Ajout.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mot_de_Passe_Ajout.Location = New System.Drawing.Point(25, 176)
        Me.lbl_Mot_de_Passe_Ajout.Name = "lbl_Mot_de_Passe_Ajout"
        Me.lbl_Mot_de_Passe_Ajout.Size = New System.Drawing.Size(120, 21)
        Me.lbl_Mot_de_Passe_Ajout.TabIndex = 2
        Me.lbl_Mot_de_Passe_Ajout.Text = "Mot de passe"
        '
        'lbl_Titre_Admin
        '
        Me.lbl_Titre_Admin.AutoSize = True
        Me.lbl_Titre_Admin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre_Admin.Location = New System.Drawing.Point(171, 9)
        Me.lbl_Titre_Admin.Name = "lbl_Titre_Admin"
        Me.lbl_Titre_Admin.Size = New System.Drawing.Size(407, 21)
        Me.lbl_Titre_Admin.TabIndex = 2
        Me.lbl_Titre_Admin.Text = "Vous êtes sur le point d'ajouter un utilisateur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_Choix_Statut
        '
        Me.lbl_Choix_Statut.AutoSize = True
        Me.lbl_Choix_Statut.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Choix_Statut.Location = New System.Drawing.Point(24, 250)
        Me.lbl_Choix_Statut.Name = "lbl_Choix_Statut"
        Me.lbl_Choix_Statut.Size = New System.Drawing.Size(84, 29)
        Me.lbl_Choix_Statut.TabIndex = 2
        Me.lbl_Choix_Statut.Text = "Statut"
        '
        'btn_ajouter_utilisateur
        '
        Me.btn_ajouter_utilisateur.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_ajouter_utilisateur.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter_utilisateur.Location = New System.Drawing.Point(307, 390)
        Me.btn_ajouter_utilisateur.Name = "btn_ajouter_utilisateur"
        Me.btn_ajouter_utilisateur.Size = New System.Drawing.Size(213, 44)
        Me.btn_ajouter_utilisateur.TabIndex = 3
        Me.btn_ajouter_utilisateur.Text = "VALIDER"
        Me.btn_ajouter_utilisateur.UseVisualStyleBackColor = False
        '
        'radio_Admin
        '
        Me.radio_Admin.AutoSize = True
        Me.radio_Admin.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_Admin.Location = New System.Drawing.Point(29, 300)
        Me.radio_Admin.Name = "radio_Admin"
        Me.radio_Admin.Size = New System.Drawing.Size(117, 29)
        Me.radio_Admin.TabIndex = 1
        Me.radio_Admin.TabStop = True
        Me.radio_Admin.Text = "ADMIN"
        Me.radio_Admin.UseVisualStyleBackColor = True
        '
        'radio_Collaborateur
        '
        Me.radio_Collaborateur.AutoSize = True
        Me.radio_Collaborateur.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_Collaborateur.Location = New System.Drawing.Point(179, 300)
        Me.radio_Collaborateur.Name = "radio_Collaborateur"
        Me.radio_Collaborateur.Size = New System.Drawing.Size(252, 29)
        Me.radio_Collaborateur.TabIndex = 1
        Me.radio_Collaborateur.TabStop = True
        Me.radio_Collaborateur.Text = "COLLABORATEUR"
        Me.radio_Collaborateur.UseVisualStyleBackColor = True
        '
        'radio_Client
        '
        Me.radio_Client.AutoSize = True
        Me.radio_Client.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_Client.Location = New System.Drawing.Point(455, 300)
        Me.radio_Client.Name = "radio_Client"
        Me.radio_Client.Size = New System.Drawing.Size(124, 29)
        Me.radio_Client.TabIndex = 1
        Me.radio_Client.TabStop = True
        Me.radio_Client.Text = "CLIENT"
        Me.radio_Client.UseVisualStyleBackColor = True
        '
        'btn_Annule
        '
        Me.btn_Annule.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Annule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Annule.Location = New System.Drawing.Point(702, 399)
        Me.btn_Annule.Name = "btn_Annule"
        Me.btn_Annule.Size = New System.Drawing.Size(93, 35)
        Me.btn_Annule.TabIndex = 4
        Me.btn_Annule.Text = "Annuler"
        Me.btn_Annule.UseVisualStyleBackColor = False
        '
        'Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Annule)
        Me.Controls.Add(Me.radio_Client)
        Me.Controls.Add(Me.radio_Collaborateur)
        Me.Controls.Add(Me.btn_ajouter_utilisateur)
        Me.Controls.Add(Me.radio_Admin)
        Me.Controls.Add(Me.lbl_Choix_Statut)
        Me.Controls.Add(Me.lbl_Mot_de_Passe_Ajout)
        Me.Controls.Add(Me.lbl_Nom_Ajout)
        Me.Controls.Add(Me.lbl_Titre_Admin)
        Me.Controls.Add(Me.lbl_Prenom_Ajout)
        Me.Controls.Add(Me.txt_Ajout_Mot_De_Passe)
        Me.Controls.Add(Me.txt_Ajout_Nom)
        Me.Controls.Add(Me.txt_Ajout_Prenom)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Administration"
        Me.Text = "Administration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Ajout_Prenom As TextBox
    Friend WithEvents txt_Ajout_Nom As TextBox
    Friend WithEvents txt_Ajout_Mot_De_Passe As TextBox
    Friend WithEvents lbl_Prenom_Ajout As Label
    Friend WithEvents lbl_Nom_Ajout As Label
    Friend WithEvents lbl_Mot_de_Passe_Ajout As Label
    Friend WithEvents lbl_Titre_Admin As Label
    Friend WithEvents lbl_Choix_Statut As Label
    Friend WithEvents btn_ajouter_utilisateur As Button
    Friend WithEvents radio_Admin As RadioButton
    Friend WithEvents radio_Collaborateur As RadioButton
    Friend WithEvents radio_Client As RadioButton
    Friend WithEvents btn_Annule As Button
End Class
