<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Collaborateur
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
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.cb_Affichage_Collaborateurs = New System.Windows.Forms.ComboBox()
        Me.lbl_Nom_Collaborateur = New System.Windows.Forms.Label()
        Me.lbl_Prenom_Collaborateur = New System.Windows.Forms.Label()
        Me.lbl_Adresse = New System.Windows.Forms.Label()
        Me.lbl_Contrat_Collaborateur = New System.Windows.Forms.Label()
        Me.lbl_Fin_Contat = New System.Windows.Forms.Label()
        Me.lbl_Telephone = New System.Windows.Forms.Label()
        Me.txt_Prenom = New System.Windows.Forms.TextBox()
        Me.txt_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Adresse1 = New System.Windows.Forms.TextBox()
        Me.txt_Telephone = New System.Windows.Forms.TextBox()
        Me.txt_Debut_Contrat = New System.Windows.Forms.TextBox()
        Me.txt_Fin_Contrat = New System.Windows.Forms.TextBox()
        Me.txt_Adresse_Complement = New System.Windows.Forms.TextBox()
        Me.txt_Code_Postal = New System.Windows.Forms.TextBox()
        Me.lbl_Code_Postal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_retour
        '
        Me.btn_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_retour.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.Location = New System.Drawing.Point(698, 406)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(90, 32)
        Me.btn_retour.TabIndex = 1
        Me.btn_retour.Text = "Accueil"
        Me.btn_retour.UseVisualStyleBackColor = False
        '
        'cb_Affichage_Collaborateurs
        '
        Me.cb_Affichage_Collaborateurs.FormattingEnabled = True
        Me.cb_Affichage_Collaborateurs.Location = New System.Drawing.Point(121, 23)
        Me.cb_Affichage_Collaborateurs.Name = "cb_Affichage_Collaborateurs"
        Me.cb_Affichage_Collaborateurs.Size = New System.Drawing.Size(474, 21)
        Me.cb_Affichage_Collaborateurs.TabIndex = 2
        '
        'lbl_Nom_Collaborateur
        '
        Me.lbl_Nom_Collaborateur.AutoSize = True
        Me.lbl_Nom_Collaborateur.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nom_Collaborateur.Location = New System.Drawing.Point(349, 103)
        Me.lbl_Nom_Collaborateur.Name = "lbl_Nom_Collaborateur"
        Me.lbl_Nom_Collaborateur.Size = New System.Drawing.Size(46, 18)
        Me.lbl_Nom_Collaborateur.TabIndex = 3
        Me.lbl_Nom_Collaborateur.Text = "NOM"
        '
        'lbl_Prenom_Collaborateur
        '
        Me.lbl_Prenom_Collaborateur.AutoSize = True
        Me.lbl_Prenom_Collaborateur.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prenom_Collaborateur.Location = New System.Drawing.Point(12, 103)
        Me.lbl_Prenom_Collaborateur.Name = "lbl_Prenom_Collaborateur"
        Me.lbl_Prenom_Collaborateur.Size = New System.Drawing.Size(81, 18)
        Me.lbl_Prenom_Collaborateur.TabIndex = 3
        Me.lbl_Prenom_Collaborateur.Text = "PRENOM"
        '
        'lbl_Adresse
        '
        Me.lbl_Adresse.AutoSize = True
        Me.lbl_Adresse.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Adresse.Location = New System.Drawing.Point(12, 180)
        Me.lbl_Adresse.Name = "lbl_Adresse"
        Me.lbl_Adresse.Size = New System.Drawing.Size(87, 18)
        Me.lbl_Adresse.TabIndex = 3
        Me.lbl_Adresse.Text = "ADRESSE"
        '
        'lbl_Contrat_Collaborateur
        '
        Me.lbl_Contrat_Collaborateur.AutoSize = True
        Me.lbl_Contrat_Collaborateur.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contrat_Collaborateur.Location = New System.Drawing.Point(6, 347)
        Me.lbl_Contrat_Collaborateur.Name = "lbl_Contrat_Collaborateur"
        Me.lbl_Contrat_Collaborateur.Size = New System.Drawing.Size(153, 18)
        Me.lbl_Contrat_Collaborateur.TabIndex = 3
        Me.lbl_Contrat_Collaborateur.Text = "DEBUT CONTRAT"
        '
        'lbl_Fin_Contat
        '
        Me.lbl_Fin_Contat.AutoSize = True
        Me.lbl_Fin_Contat.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fin_Contat.Location = New System.Drawing.Point(349, 347)
        Me.lbl_Fin_Contat.Name = "lbl_Fin_Contat"
        Me.lbl_Fin_Contat.Size = New System.Drawing.Size(124, 18)
        Me.lbl_Fin_Contat.TabIndex = 3
        Me.lbl_Fin_Contat.Text = "FIN CONTRAT"
        '
        'lbl_Telephone
        '
        Me.lbl_Telephone.AutoSize = True
        Me.lbl_Telephone.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Telephone.Location = New System.Drawing.Point(349, 277)
        Me.lbl_Telephone.Name = "lbl_Telephone"
        Me.lbl_Telephone.Size = New System.Drawing.Size(115, 18)
        Me.lbl_Telephone.TabIndex = 3
        Me.lbl_Telephone.Text = "TELEPHONE"
        '
        'txt_Prenom
        '
        Me.txt_Prenom.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Prenom.Location = New System.Drawing.Point(15, 124)
        Me.txt_Prenom.Name = "txt_Prenom"
        Me.txt_Prenom.Size = New System.Drawing.Size(192, 20)
        Me.txt_Prenom.TabIndex = 4
        '
        'txt_Nom
        '
        Me.txt_Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Nom.Location = New System.Drawing.Point(352, 124)
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.Size = New System.Drawing.Size(192, 20)
        Me.txt_Nom.TabIndex = 4
        '
        'txt_Adresse1
        '
        Me.txt_Adresse1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Adresse1.Location = New System.Drawing.Point(15, 201)
        Me.txt_Adresse1.Name = "txt_Adresse1"
        Me.txt_Adresse1.Size = New System.Drawing.Size(634, 20)
        Me.txt_Adresse1.TabIndex = 4
        '
        'txt_Telephone
        '
        Me.txt_Telephone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Telephone.Location = New System.Drawing.Point(352, 298)
        Me.txt_Telephone.Name = "txt_Telephone"
        Me.txt_Telephone.Size = New System.Drawing.Size(192, 20)
        Me.txt_Telephone.TabIndex = 4
        '
        'txt_Debut_Contrat
        '
        Me.txt_Debut_Contrat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Debut_Contrat.Location = New System.Drawing.Point(9, 368)
        Me.txt_Debut_Contrat.Name = "txt_Debut_Contrat"
        Me.txt_Debut_Contrat.Size = New System.Drawing.Size(192, 20)
        Me.txt_Debut_Contrat.TabIndex = 4
        '
        'txt_Fin_Contrat
        '
        Me.txt_Fin_Contrat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Fin_Contrat.Location = New System.Drawing.Point(352, 368)
        Me.txt_Fin_Contrat.Name = "txt_Fin_Contrat"
        Me.txt_Fin_Contrat.Size = New System.Drawing.Size(192, 20)
        Me.txt_Fin_Contrat.TabIndex = 4
        '
        'txt_Adresse_Complement
        '
        Me.txt_Adresse_Complement.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Adresse_Complement.Location = New System.Drawing.Point(15, 227)
        Me.txt_Adresse_Complement.Name = "txt_Adresse_Complement"
        Me.txt_Adresse_Complement.Size = New System.Drawing.Size(634, 20)
        Me.txt_Adresse_Complement.TabIndex = 4
        '
        'txt_Code_Postal
        '
        Me.txt_Code_Postal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Code_Postal.Location = New System.Drawing.Point(15, 298)
        Me.txt_Code_Postal.Name = "txt_Code_Postal"
        Me.txt_Code_Postal.Size = New System.Drawing.Size(192, 20)
        Me.txt_Code_Postal.TabIndex = 4
        '
        'lbl_Code_Postal
        '
        Me.lbl_Code_Postal.AutoSize = True
        Me.lbl_Code_Postal.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Code_Postal.Location = New System.Drawing.Point(12, 277)
        Me.lbl_Code_Postal.Name = "lbl_Code_Postal"
        Me.lbl_Code_Postal.Size = New System.Drawing.Size(126, 18)
        Me.lbl_Code_Postal.TabIndex = 3
        Me.lbl_Code_Postal.Text = "CODE POSTAL"
        '
        'Collaborateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_Fin_Contrat)
        Me.Controls.Add(Me.txt_Debut_Contrat)
        Me.Controls.Add(Me.txt_Code_Postal)
        Me.Controls.Add(Me.txt_Telephone)
        Me.Controls.Add(Me.txt_Adresse_Complement)
        Me.Controls.Add(Me.txt_Adresse1)
        Me.Controls.Add(Me.txt_Nom)
        Me.Controls.Add(Me.txt_Prenom)
        Me.Controls.Add(Me.lbl_Code_Postal)
        Me.Controls.Add(Me.lbl_Telephone)
        Me.Controls.Add(Me.lbl_Fin_Contat)
        Me.Controls.Add(Me.lbl_Contrat_Collaborateur)
        Me.Controls.Add(Me.lbl_Adresse)
        Me.Controls.Add(Me.lbl_Prenom_Collaborateur)
        Me.Controls.Add(Me.lbl_Nom_Collaborateur)
        Me.Controls.Add(Me.cb_Affichage_Collaborateurs)
        Me.Controls.Add(Me.btn_retour)
        Me.Name = "Collaborateur"
        Me.Text = "Collaborateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_retour As Button
    Friend WithEvents cb_Affichage_Collaborateurs As ComboBox
    Friend WithEvents lbl_Nom_Collaborateur As Label
    Friend WithEvents lbl_Prenom_Collaborateur As Label
    Friend WithEvents lbl_Adresse As Label
    Friend WithEvents lbl_Contrat_Collaborateur As Label
    Friend WithEvents lbl_Fin_Contat As Label
    Friend WithEvents lbl_Telephone As Label
    Friend WithEvents txt_Prenom As TextBox
    Friend WithEvents txt_Nom As TextBox
    Friend WithEvents txt_Adresse1 As TextBox
    Friend WithEvents txt_Telephone As TextBox
    Friend WithEvents txt_Debut_Contrat As TextBox
    Friend WithEvents txt_Fin_Contrat As TextBox
    Friend WithEvents txt_Adresse_Complement As TextBox
    Friend WithEvents txt_Code_Postal As TextBox
    Friend WithEvents lbl_Code_Postal As Label
End Class
