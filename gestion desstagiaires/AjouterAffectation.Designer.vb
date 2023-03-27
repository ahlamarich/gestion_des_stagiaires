<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterAffectation
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Enregistrer_btn = New System.Windows.Forms.Button()
        Me.Annuler_btn = New System.Windows.Forms.Button()
        Me.Vider_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(175, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 337)
        Me.Panel1.TabIndex = 24
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(183, 98)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox2.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Plum
        Me.Label3.Location = New System.Drawing.Point(52, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Titre De Projet"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(227, 216)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(227, 173)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(183, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 20)
        Me.TextBox2.TabIndex = 30
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(183, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(211, 269)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 20)
        Me.TextBox3.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Plum
        Me.Label7.Location = New System.Drawing.Point(52, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Durée du Stage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Plum
        Me.Label6.Location = New System.Drawing.Point(53, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Date Fin Stage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Plum
        Me.Label5.Location = New System.Drawing.Point(52, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Date Début Stage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Plum
        Me.Label4.Location = New System.Drawing.Point(52, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Plum
        Me.Label2.Location = New System.Drawing.Point(53, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Stagiaire"
        '
        'Enregistrer_btn
        '
        Me.Enregistrer_btn.BackColor = System.Drawing.Color.Plum
        Me.Enregistrer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enregistrer_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enregistrer_btn.ForeColor = System.Drawing.Color.White
        Me.Enregistrer_btn.Location = New System.Drawing.Point(299, 463)
        Me.Enregistrer_btn.Name = "Enregistrer_btn"
        Me.Enregistrer_btn.Size = New System.Drawing.Size(201, 33)
        Me.Enregistrer_btn.TabIndex = 23
        Me.Enregistrer_btn.Text = "Enregistrer"
        Me.Enregistrer_btn.UseVisualStyleBackColor = False
        '
        'Annuler_btn
        '
        Me.Annuler_btn.BackColor = System.Drawing.Color.Plum
        Me.Annuler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Annuler_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Annuler_btn.ForeColor = System.Drawing.Color.White
        Me.Annuler_btn.Location = New System.Drawing.Point(539, 463)
        Me.Annuler_btn.Name = "Annuler_btn"
        Me.Annuler_btn.Size = New System.Drawing.Size(83, 33)
        Me.Annuler_btn.TabIndex = 22
        Me.Annuler_btn.Text = "Annuler"
        Me.Annuler_btn.UseVisualStyleBackColor = False
        '
        'Vider_btn
        '
        Me.Vider_btn.BackColor = System.Drawing.Color.Plum
        Me.Vider_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Vider_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vider_btn.ForeColor = System.Drawing.Color.White
        Me.Vider_btn.Location = New System.Drawing.Point(175, 468)
        Me.Vider_btn.Name = "Vider_btn"
        Me.Vider_btn.Size = New System.Drawing.Size(75, 28)
        Me.Vider_btn.TabIndex = 21
        Me.Vider_btn.Text = "Vider"
        Me.Vider_btn.UseVisualStyleBackColor = False
        '
        'AjouterAffectation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 574)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Enregistrer_btn)
        Me.Controls.Add(Me.Annuler_btn)
        Me.Controls.Add(Me.Vider_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AjouterAffectation"
        Me.Text = "Ajouter3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Enregistrer_btn As Button
    Friend WithEvents Annuler_btn As Button
    Friend WithEvents Vider_btn As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
End Class
