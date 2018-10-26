<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Projets
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
        Me.cb_Affichage_Projets = New System.Windows.Forms.ComboBox()
        Me.btn_Projet_Retour_Accueil = New System.Windows.Forms.Button()
        Me.lbl_Titre_Abreviation = New System.Windows.Forms.Label()
        Me.lbl_Affichage_Abreviation = New System.Windows.Forms.Label()
        Me.lbl_Titre_Date_Previsionnelle_Debut = New System.Windows.Forms.Label()
        Me.lbl_Affichage_date_Previsionnelle_Debut = New System.Windows.Forms.Label()
        Me.lbl_Titre_Date_Previsionnelle_Fin = New System.Windows.Forms.Label()
        Me.lbl_Affichage_date_Previsionnelle_Fin = New System.Windows.Forms.Label()
        Me.lbl_Titre_Date_Reelle_Debut = New System.Windows.Forms.Label()
        Me.lbl_Affichage_date_Reelle_Debut = New System.Windows.Forms.Label()
        Me.lbl_Titre_Date_Reelle_Fin = New System.Windows.Forms.Label()
        Me.lbl_Affichage_date_Reelle_Fin = New System.Windows.Forms.Label()
        Me.lbl_Titre_Nombre_Equipe_Max = New System.Windows.Forms.Label()
        Me.lbl_Affichage_Nbr_Max_Equipe = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cb_Affichage_Projets
        '
        Me.cb_Affichage_Projets.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Affichage_Projets.FormattingEnabled = True
        Me.cb_Affichage_Projets.Location = New System.Drawing.Point(142, 12)
        Me.cb_Affichage_Projets.Name = "cb_Affichage_Projets"
        Me.cb_Affichage_Projets.Size = New System.Drawing.Size(551, 26)
        Me.cb_Affichage_Projets.TabIndex = 0
        '
        'btn_Projet_Retour_Accueil
        '
        Me.btn_Projet_Retour_Accueil.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Projet_Retour_Accueil.Location = New System.Drawing.Point(807, 425)
        Me.btn_Projet_Retour_Accueil.Name = "btn_Projet_Retour_Accueil"
        Me.btn_Projet_Retour_Accueil.Size = New System.Drawing.Size(114, 48)
        Me.btn_Projet_Retour_Accueil.TabIndex = 1
        Me.btn_Projet_Retour_Accueil.Text = "Accueil"
        Me.btn_Projet_Retour_Accueil.UseVisualStyleBackColor = True
        '
        'lbl_Titre_Abreviation
        '
        Me.lbl_Titre_Abreviation.AutoSize = True
        Me.lbl_Titre_Abreviation.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre_Abreviation.Location = New System.Drawing.Point(12, 103)
        Me.lbl_Titre_Abreviation.Name = "lbl_Titre_Abreviation"
        Me.lbl_Titre_Abreviation.Size = New System.Drawing.Size(123, 21)
        Me.lbl_Titre_Abreviation.TabIndex = 2
        Me.lbl_Titre_Abreviation.Text = "Abréviation :"
        '
        'lbl_Affichage_Abreviation
        '
        Me.lbl_Affichage_Abreviation.AutoSize = True
        Me.lbl_Affichage_Abreviation.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Affichage_Abreviation.Location = New System.Drawing.Point(138, 103)
        Me.lbl_Affichage_Abreviation.Name = "lbl_Affichage_Abreviation"
        Me.lbl_Affichage_Abreviation.Size = New System.Drawing.Size(0, 21)
        Me.lbl_Affichage_Abreviation.TabIndex = 2
        '
        'lbl_Titre_Date_Previsionnelle_Debut
        '
        Me.lbl_Titre_Date_Previsionnelle_Debut.AutoSize = True
        Me.lbl_Titre_Date_Previsionnelle_Debut.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre_Date_Previsionnelle_Debut.Location = New System.Drawing.Point(12, 149)
        Me.lbl_Titre_Date_Previsionnelle_Debut.Name = "lbl_Titre_Date_Previsionnelle_Debut"
        Me.lbl_Titre_Date_Previsionnelle_Debut.Size = New System.Drawing.Size(243, 21)
        Me.lbl_Titre_Date_Previsionnelle_Debut.TabIndex = 2
        Me.lbl_Titre_Date_Previsionnelle_Debut.Text = "Date previsionnelle début :"
        '
        'lbl_Affichage_date_Previsionnelle_Debut
        '
        Me.lbl_Affichage_date_Previsionnelle_Debut.AutoSize = True
        Me.lbl_Affichage_date_Previsionnelle_Debut.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Affichage_date_Previsionnelle_Debut.Location = New System.Drawing.Point(261, 149)
        Me.lbl_Affichage_date_Previsionnelle_Debut.Name = "lbl_Affichage_date_Previsionnelle_Debut"
        Me.lbl_Affichage_date_Previsionnelle_Debut.Size = New System.Drawing.Size(0, 21)
        Me.lbl_Affichage_date_Previsionnelle_Debut.TabIndex = 2
        '
        'lbl_Titre_Date_Previsionnelle_Fin
        '
        Me.lbl_Titre_Date_Previsionnelle_Fin.AutoSize = True
        Me.lbl_Titre_Date_Previsionnelle_Fin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre_Date_Previsionnelle_Fin.Location = New System.Drawing.Point(12, 180)
        Me.lbl_Titre_Date_Previsionnelle_Fin.Name = "lbl_Titre_Date_Previsionnelle_Fin"
        Me.lbl_Titre_Date_Previsionnelle_Fin.Size = New System.Drawing.Size(222, 21)
        Me.lbl_Titre_Date_Previsionnelle_Fin.TabIndex = 2
        Me.lbl_Titre_Date_Previsionnelle_Fin.Text = "Date prévisionnelle fin :"
        '
        'lbl_Affichage_date_Previsionnelle_Fin
        '
        Me.lbl_Affichage_date_Previsionnelle_Fin.AutoSize = True
        Me.lbl_Affichage_date_Previsionnelle_Fin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Affichage_date_Previsionnelle_Fin.Location = New System.Drawing.Point(240, 180)
        Me.lbl_Affichage_date_Previsionnelle_Fin.Name = "lbl_Affichage_date_Previsionnelle_Fin"
        Me.lbl_Affichage_date_Previsionnelle_Fin.Size = New System.Drawing.Size(0, 21)
        Me.lbl_Affichage_date_Previsionnelle_Fin.TabIndex = 2
        '
        'lbl_Titre_Date_Reelle_Debut
        '
        Me.lbl_Titre_Date_Reelle_Debut.AutoSize = True
        Me.lbl_Titre_Date_Reelle_Debut.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre_Date_Reelle_Debut.Location = New System.Drawing.Point(523, 149)
        Me.lbl_Titre_Date_Reelle_Debut.Name = "lbl_Titre_Date_Reelle_Debut"
        Me.lbl_Titre_Date_Reelle_Debut.Size = New System.Drawing.Size(170, 21)
        Me.lbl_Titre_Date_Reelle_Debut.TabIndex = 2
        Me.lbl_Titre_Date_Reelle_Debut.Text = "Date réelle début :"
        '
        'lbl_Affichage_date_Reelle_Debut
        '
        Me.lbl_Affichage_date_Reelle_Debut.AutoSize = True
        Me.lbl_Affichage_date_Reelle_Debut.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Affichage_date_Reelle_Debut.Location = New System.Drawing.Point(699, 149)
        Me.lbl_Affichage_date_Reelle_Debut.Name = "lbl_Affichage_date_Reelle_Debut"
        Me.lbl_Affichage_date_Reelle_Debut.Size = New System.Drawing.Size(0, 21)
        Me.lbl_Affichage_date_Reelle_Debut.TabIndex = 2
        '
        'lbl_Titre_Date_Reelle_Fin
        '
        Me.lbl_Titre_Date_Reelle_Fin.AutoSize = True
        Me.lbl_Titre_Date_Reelle_Fin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre_Date_Reelle_Fin.Location = New System.Drawing.Point(523, 180)
        Me.lbl_Titre_Date_Reelle_Fin.Name = "lbl_Titre_Date_Reelle_Fin"
        Me.lbl_Titre_Date_Reelle_Fin.Size = New System.Drawing.Size(149, 21)
        Me.lbl_Titre_Date_Reelle_Fin.TabIndex = 2
        Me.lbl_Titre_Date_Reelle_Fin.Text = "Date réelle fin :"
        '
        'lbl_Affichage_date_Reelle_Fin
        '
        Me.lbl_Affichage_date_Reelle_Fin.AutoSize = True
        Me.lbl_Affichage_date_Reelle_Fin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Affichage_date_Reelle_Fin.Location = New System.Drawing.Point(678, 180)
        Me.lbl_Affichage_date_Reelle_Fin.Name = "lbl_Affichage_date_Reelle_Fin"
        Me.lbl_Affichage_date_Reelle_Fin.Size = New System.Drawing.Size(0, 21)
        Me.lbl_Affichage_date_Reelle_Fin.TabIndex = 2
        '
        'lbl_Titre_Nombre_Equipe_Max
        '
        Me.lbl_Titre_Nombre_Equipe_Max.AutoSize = True
        Me.lbl_Titre_Nombre_Equipe_Max.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre_Nombre_Equipe_Max.Location = New System.Drawing.Point(12, 241)
        Me.lbl_Titre_Nombre_Equipe_Max.Name = "lbl_Titre_Nombre_Equipe_Max"
        Me.lbl_Titre_Nombre_Equipe_Max.Size = New System.Drawing.Size(274, 21)
        Me.lbl_Titre_Nombre_Equipe_Max.TabIndex = 2
        Me.lbl_Titre_Nombre_Equipe_Max.Text = "Nombre de personne maximal :"
        '
        'lbl_Affichage_Nbr_Max_Equipe
        '
        Me.lbl_Affichage_Nbr_Max_Equipe.AutoSize = True
        Me.lbl_Affichage_Nbr_Max_Equipe.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Affichage_Nbr_Max_Equipe.Location = New System.Drawing.Point(292, 241)
        Me.lbl_Affichage_Nbr_Max_Equipe.Name = "lbl_Affichage_Nbr_Max_Equipe"
        Me.lbl_Affichage_Nbr_Max_Equipe.Size = New System.Drawing.Size(0, 21)
        Me.lbl_Affichage_Nbr_Max_Equipe.TabIndex = 2
        '
        'Projets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(933, 485)
        Me.Controls.Add(Me.lbl_Affichage_Abreviation)
        Me.Controls.Add(Me.lbl_Affichage_date_Reelle_Fin)
        Me.Controls.Add(Me.lbl_Titre_Date_Reelle_Fin)
        Me.Controls.Add(Me.lbl_Affichage_date_Previsionnelle_Fin)
        Me.Controls.Add(Me.lbl_Affichage_Nbr_Max_Equipe)
        Me.Controls.Add(Me.lbl_Affichage_date_Reelle_Debut)
        Me.Controls.Add(Me.lbl_Titre_Date_Previsionnelle_Fin)
        Me.Controls.Add(Me.lbl_Titre_Nombre_Equipe_Max)
        Me.Controls.Add(Me.lbl_Titre_Date_Reelle_Debut)
        Me.Controls.Add(Me.lbl_Affichage_date_Previsionnelle_Debut)
        Me.Controls.Add(Me.lbl_Titre_Date_Previsionnelle_Debut)
        Me.Controls.Add(Me.lbl_Titre_Abreviation)
        Me.Controls.Add(Me.btn_Projet_Retour_Accueil)
        Me.Controls.Add(Me.cb_Affichage_Projets)
        Me.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Projets"
        Me.Text = "Projets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_Affichage_Projets As ComboBox
    Friend WithEvents btn_Projet_Retour_Accueil As Button
    Friend WithEvents lbl_Titre_Abreviation As Label
    Friend WithEvents lbl_Affichage_Abreviation As Label
    Friend WithEvents lbl_Titre_Date_Previsionnelle_Debut As Label
    Friend WithEvents lbl_Affichage_date_Previsionnelle_Debut As Label
    Friend WithEvents lbl_Titre_Date_Previsionnelle_Fin As Label
    Friend WithEvents lbl_Affichage_date_Previsionnelle_Fin As Label
    Friend WithEvents lbl_Titre_Date_Reelle_Debut As Label
    Friend WithEvents lbl_Affichage_date_Reelle_Debut As Label
    Friend WithEvents lbl_Titre_Date_Reelle_Fin As Label
    Friend WithEvents lbl_Affichage_date_Reelle_Fin As Label
    Friend WithEvents lbl_Titre_Nombre_Equipe_Max As Label
    Friend WithEvents lbl_Affichage_Nbr_Max_Equipe As Label
End Class
