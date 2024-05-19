<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_comensales = New System.Windows.Forms.ComboBox()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ingrediente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tiempo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(528, 149)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Tipo"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"Acompañamiento", "Cena", "Cumpleaños", "Desayuno", "Entrante", "Merienda", "Plato principal", "Postre"})
        Me.cmb_tipo.Location = New System.Drawing.Point(531, 177)
        Me.cmb_tipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(112, 21)
        Me.cmb_tipo.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(337, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Comensales"
        '
        'cmb_comensales
        '
        Me.cmb_comensales.FormattingEnabled = True
        Me.cmb_comensales.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "20", "24", "25", "30", "32", "35", "40", "45", "48", "50", "60", "80", "100"})
        Me.cmb_comensales.Location = New System.Drawing.Point(337, 177)
        Me.cmb_comensales.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_comensales.Name = "cmb_comensales"
        Me.cmb_comensales.Size = New System.Drawing.Size(92, 21)
        Me.cmb_comensales.TabIndex = 22
        '
        'cmb_categoria
        '
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Items.AddRange(New Object() {"Cocteles y bebidas", "Consejos de cocina", "Recetas de Aperitivos y tapas", "Recetas de Arroces y cereales", "Recetas de Aves y caza", "Recetas de Carne", "Recetas de Ensaladas", "Recetas de Guisos y Potajes", "Recetas de Huevos y lacteos", "Recetas de Legumbres", "Recetas de Mariscos", "Recetas de Pan y bollerina", "Recetas de Pasta", "Recetas de Pescado", "Recetas de Postres", "Recetas de Salsas", "Recetas de Sopas y cremas", "Recetas de Verduras"})
        Me.cmb_categoria.Location = New System.Drawing.Point(11, 178)
        Me.cmb_categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(158, 21)
        Me.cmb_categoria.TabIndex = 21
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(654, 167)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(82, 21)
        Me.btn_buscar.TabIndex = 20
        Me.btn_buscar.Text = "Filtrar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(186, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ingrediente"
        '
        'txt_ingrediente
        '
        Me.txt_ingrediente.Location = New System.Drawing.Point(189, 178)
        Me.txt_ingrediente.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ingrediente.Name = "txt_ingrediente"
        Me.txt_ingrediente.Size = New System.Drawing.Size(132, 20)
        Me.txt_ingrediente.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 91)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Recetas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 224)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(750, 187)
        Me.DataGridView1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Categoria"
        '
        'cmb_tiempo
        '
        Me.cmb_tiempo.FormattingEnabled = True
        Me.cmb_tiempo.Items.AddRange(New Object() {"10m", "15m", "1h 30m", "24h", "2h 30m", "30m ", "3h", "45m", "4h", "6h", "8h"})
        Me.cmb_tiempo.Location = New System.Drawing.Point(445, 177)
        Me.cmb_tiempo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tiempo.Name = "cmb_tiempo"
        Me.cmb_tiempo.Size = New System.Drawing.Size(62, 21)
        Me.cmb_tiempo.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(442, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Tiempo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(410, 446)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 35)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Imprimir alguna Receta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoPrueba.My.Resources.Resources.receta
        Me.PictureBox1.Location = New System.Drawing.Point(348, -16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(255, 446)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 35)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "¡Califica la receta!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(11, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Regresar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(777, 493)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_tiempo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_comensales)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ingrediente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_comensales As ComboBox
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ingrediente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_tiempo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
