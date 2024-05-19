<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_tipo1 = New System.Windows.Forms.ComboBox()
        Me.cmb_tiempo1 = New System.Windows.Forms.ComboBox()
        Me.cmb_comensales1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxReceta = New System.Windows.Forms.TextBox()
        Me.cmb_categoria1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(111, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(95, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Ingredientes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Tiempo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Num Comensales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Nombre Receta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Categoría"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "IdReceta"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(186, 305)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(251, 20)
        Me.TextBox3.TabIndex = 46
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Buscar Receta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_tipo1
        '
        Me.cmb_tipo1.FormattingEnabled = True
        Me.cmb_tipo1.Items.AddRange(New Object() {"Desayuno", "Cena", "Entrante", "Merienda", "Acompañamiento", "Postre", "Cumpleaños", "Plato Principal"})
        Me.cmb_tipo1.Location = New System.Drawing.Point(186, 264)
        Me.cmb_tipo1.Name = "cmb_tipo1"
        Me.cmb_tipo1.Size = New System.Drawing.Size(131, 21)
        Me.cmb_tipo1.TabIndex = 44
        '
        'cmb_tiempo1
        '
        Me.cmb_tiempo1.FormattingEnabled = True
        Me.cmb_tiempo1.Items.AddRange(New Object() {"10m", "6h", "45m", "2h 30m", "24h", "1h", "1h 30m", "8h", "15m", "3h", "4h", "30m"})
        Me.cmb_tiempo1.Location = New System.Drawing.Point(186, 226)
        Me.cmb_tiempo1.Name = "cmb_tiempo1"
        Me.cmb_tiempo1.Size = New System.Drawing.Size(110, 21)
        Me.cmb_tiempo1.TabIndex = 43
        '
        'cmb_comensales1
        '
        Me.cmb_comensales1.FormattingEnabled = True
        Me.cmb_comensales1.Items.AddRange(New Object() {"15", "9", "3", "32", "12", "35", "6", "7", "1", "50", "24", "30", "18", "10", "4", "25", "13", "5", "16", "45", "2", "48", "17", "60", "40", "11", "20", "80", "14", "8", "100"})
        Me.cmb_comensales1.Location = New System.Drawing.Point(186, 183)
        Me.cmb_comensales1.Name = "cmb_comensales1"
        Me.cmb_comensales1.Size = New System.Drawing.Size(85, 21)
        Me.cmb_comensales1.TabIndex = 42
        '
        'TextBoxReceta
        '
        Me.TextBoxReceta.Location = New System.Drawing.Point(186, 143)
        Me.TextBoxReceta.Name = "TextBoxReceta"
        Me.TextBoxReceta.Size = New System.Drawing.Size(208, 20)
        Me.TextBoxReceta.TabIndex = 41
        '
        'cmb_categoria1
        '
        Me.cmb_categoria1.FormattingEnabled = True
        Me.cmb_categoria1.Items.AddRange(New Object() {"Cocteles y bebidas", "Recetas de Huevos y lácteos", "Recetas de Mariscos", "Consejos de cocina", "Recetas de Legumbres", "Recetas de Carne", "Recetas de Ensaladas", "Recetas de Pan y bolleria", "Recetas de Pasta", "Recetas de Postres", "Recetas de Salsas", "Recetas de Aves y caza", "Recetas de Aperitivos y tapas", "Recetas de Sopas y cremas", "Recetas de Pescado", "Recetas d Guisos y Potajes", "Recetas de Arroces y cereales", "Recetas de Verduras"})
        Me.cmb_categoria1.Location = New System.Drawing.Point(186, 102)
        Me.cmb_categoria1.Name = "cmb_categoria1"
        Me.cmb_categoria1.Size = New System.Drawing.Size(187, 21)
        Me.cmb_categoria1.TabIndex = 40
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(186, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 39
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoPrueba.My.Resources.Resources.actualizar
        Me.PictureBox2.Location = New System.Drawing.Point(254, 357)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoPrueba.My.Resources.Resources.anadiendo
        Me.PictureBox1.Location = New System.Drawing.Point(163, 357)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_tipo1)
        Me.Controls.Add(Me.cmb_tiempo1)
        Me.Controls.Add(Me.cmb_comensales1)
        Me.Controls.Add(Me.TextBoxReceta)
        Me.Controls.Add(Me.cmb_categoria1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmb_tipo1 As ComboBox
    Friend WithEvents cmb_tiempo1 As ComboBox
    Friend WithEvents cmb_comensales1 As ComboBox
    Friend WithEvents TextBoxReceta As TextBox
    Friend WithEvents cmb_categoria1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
End Class
