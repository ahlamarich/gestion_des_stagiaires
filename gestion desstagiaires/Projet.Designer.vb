<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Projet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Projet))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Annuler_btn = New System.Windows.Forms.Button()
        Me.Vider_btn = New System.Windows.Forms.Button()
        Me.Ajouter_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(74, 140)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 221)
        Me.Panel1.TabIndex = 29
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(169, 115)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 30
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(169, 177)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 20)
        Me.TextBox3.TabIndex = 28
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(169, 56)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Plum
        Me.Label7.Location = New System.Drawing.Point(2, 115)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Titre Du Projet"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Plum
        Me.Label4.Location = New System.Drawing.Point(11, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Plum
        Me.Label1.Location = New System.Drawing.Point(11, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "N°"
        '
        'Annuler_btn
        '
        Me.Annuler_btn.BackColor = System.Drawing.Color.Plum
        Me.Annuler_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Annuler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Annuler_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Annuler_btn.ForeColor = System.Drawing.Color.White
        Me.Annuler_btn.Location = New System.Drawing.Point(732, 464)
        Me.Annuler_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Annuler_btn.Name = "Annuler_btn"
        Me.Annuler_btn.Size = New System.Drawing.Size(110, 32)
        Me.Annuler_btn.TabIndex = 27
        Me.Annuler_btn.Text = "Annuler"
        Me.Annuler_btn.UseVisualStyleBackColor = False
        '
        'Vider_btn
        '
        Me.Vider_btn.BackColor = System.Drawing.Color.Plum
        Me.Vider_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Vider_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Vider_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vider_btn.ForeColor = System.Drawing.Color.White
        Me.Vider_btn.Location = New System.Drawing.Point(74, 475)
        Me.Vider_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Vider_btn.Name = "Vider_btn"
        Me.Vider_btn.Size = New System.Drawing.Size(110, 32)
        Me.Vider_btn.TabIndex = 26
        Me.Vider_btn.Text = "Vider"
        Me.Vider_btn.UseVisualStyleBackColor = False
        '
        'Ajouter_btn
        '
        Me.Ajouter_btn.BackgroundImage = CType(resources.GetObject("Ajouter_btn.BackgroundImage"), System.Drawing.Image)
        Me.Ajouter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Ajouter_btn.Location = New System.Drawing.Point(223, 59)
        Me.Ajouter_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Ajouter_btn.Name = "Ajouter_btn"
        Me.Ajouter_btn.Size = New System.Drawing.Size(62, 55)
        Me.Ajouter_btn.TabIndex = 30
        Me.Ajouter_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(320, 59)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 55)
        Me.Button2.TabIndex = 31
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(404, 59)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 55)
        Me.Button3.TabIndex = 32
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(494, 59)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 55)
        Me.Button4.TabIndex = 33
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(480, 140)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(363, 263)
        Me.ListView1.TabIndex = 34
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Plum
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(353, 475)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 32)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Imprimer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Projet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 576)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Ajouter_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Annuler_btn)
        Me.Controls.Add(Me.Vider_btn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Projet"
        Me.Text = "Ajouter4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Annuler_btn As Button
    Friend WithEvents Vider_btn As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ajouter_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
End Class
