<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Principale
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
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.lbl_Mot_de_passe = New System.Windows.Forms.Label()
        Me.txt_Login = New System.Windows.Forms.TextBox()
        Me.txt_Mot_De_Passe = New System.Windows.Forms.TextBox()
        Me.btn_Valider = New System.Windows.Forms.Button()
        Me.Radio_Home = New System.Windows.Forms.RadioButton()
        Me.Radio_AFPA = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.BackColor = System.Drawing.Color.Gray
        Me.lbl_Login.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Login.ForeColor = System.Drawing.Color.Black
        Me.lbl_Login.Location = New System.Drawing.Point(72, 66)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(119, 34)
        Me.lbl_Login.TabIndex = 0
        Me.lbl_Login.Text = "LOGIN"
        '
        'lbl_Mot_de_passe
        '
        Me.lbl_Mot_de_passe.AutoSize = True
        Me.lbl_Mot_de_passe.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mot_de_passe.ForeColor = System.Drawing.Color.Black
        Me.lbl_Mot_de_passe.Location = New System.Drawing.Point(72, 185)
        Me.lbl_Mot_de_passe.Name = "lbl_Mot_de_passe"
        Me.lbl_Mot_de_passe.Size = New System.Drawing.Size(196, 34)
        Me.lbl_Mot_de_passe.TabIndex = 0
        Me.lbl_Mot_de_passe.Text = "Mot de Passe"
        '
        'txt_Login
        '
        Me.txt_Login.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Login.Location = New System.Drawing.Point(334, 66)
        Me.txt_Login.Name = "txt_Login"
        Me.txt_Login.Size = New System.Drawing.Size(279, 42)
        Me.txt_Login.TabIndex = 1
        Me.txt_Login.Text = "CAMARA.Mohamed"
        '
        'txt_Mot_De_Passe
        '
        Me.txt_Mot_De_Passe.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mot_De_Passe.Location = New System.Drawing.Point(334, 177)
        Me.txt_Mot_De_Passe.Name = "txt_Mot_De_Passe"
        Me.txt_Mot_De_Passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Mot_De_Passe.Size = New System.Drawing.Size(279, 42)
        Me.txt_Mot_De_Passe.TabIndex = 1
        Me.txt_Mot_De_Passe.Text = "momo "
        '
        'btn_Valider
        '
        Me.btn_Valider.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_Valider.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Valider.ForeColor = System.Drawing.Color.Black
        Me.btn_Valider.Location = New System.Drawing.Point(348, 341)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(219, 45)
        Me.btn_Valider.TabIndex = 2
        Me.btn_Valider.Text = "Connexion"
        Me.btn_Valider.UseVisualStyleBackColor = False
        '
        'Radio_Home
        '
        Me.Radio_Home.AutoSize = True
        Me.Radio_Home.Checked = True
        Me.Radio_Home.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Home.ForeColor = System.Drawing.Color.Black
        Me.Radio_Home.Location = New System.Drawing.Point(11, 416)
        Me.Radio_Home.Name = "Radio_Home"
        Me.Radio_Home.Size = New System.Drawing.Size(78, 22)
        Me.Radio_Home.TabIndex = 3
        Me.Radio_Home.TabStop = True
        Me.Radio_Home.Text = "HOME"
        Me.Radio_Home.UseVisualStyleBackColor = True
        '
        'Radio_AFPA
        '
        Me.Radio_AFPA.AutoSize = True
        Me.Radio_AFPA.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_AFPA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Radio_AFPA.Location = New System.Drawing.Point(153, 416)
        Me.Radio_AFPA.Name = "Radio_AFPA"
        Me.Radio_AFPA.Size = New System.Drawing.Size(72, 22)
        Me.Radio_AFPA.TabIndex = 3
        Me.Radio_AFPA.Text = "AFPA"
        Me.Radio_AFPA.UseVisualStyleBackColor = True
        '
        'Fenetre_Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Radio_AFPA)
        Me.Controls.Add(Me.Radio_Home)
        Me.Controls.Add(Me.btn_Valider)
        Me.Controls.Add(Me.txt_Mot_De_Passe)
        Me.Controls.Add(Me.txt_Login)
        Me.Controls.Add(Me.lbl_Mot_de_passe)
        Me.Controls.Add(Me.lbl_Login)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "Fenetre_Principale"
        Me.Text = "Fenêtre Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Login As Label
    Friend WithEvents lbl_Mot_de_passe As Label
    Friend WithEvents txt_Login As TextBox
    Friend WithEvents txt_Mot_De_Passe As TextBox
    Friend WithEvents btn_Valider As Button
    Friend WithEvents Radio_Home As RadioButton
    Friend WithEvents Radio_AFPA As RadioButton
End Class
