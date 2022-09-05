<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonRegresar = New System.Windows.Forms.Button()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxEdad = New System.Windows.Forms.TextBox()
        Me.TextBoxPeso = New System.Windows.Forms.TextBox()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBoxIDC = New System.Windows.Forms.TextBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "ID Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Edad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 21)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Peso"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(113, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 21)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Sexo"
        '
        'ButtonRegresar
        '
        Me.ButtonRegresar.BackColor = System.Drawing.Color.Peru
        Me.ButtonRegresar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegresar.Location = New System.Drawing.Point(969, 414)
        Me.ButtonRegresar.Name = "ButtonRegresar"
        Me.ButtonRegresar.Size = New System.Drawing.Size(121, 40)
        Me.ButtonRegresar.TabIndex = 36
        Me.ButtonRegresar.Text = "Regresar"
        Me.ButtonRegresar.UseVisualStyleBackColor = False
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(233, 169)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxNombre.TabIndex = 38
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(233, 203)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxTelefono.TabIndex = 39
        '
        'TextBoxEdad
        '
        Me.TextBoxEdad.Location = New System.Drawing.Point(233, 238)
        Me.TextBoxEdad.Name = "TextBoxEdad"
        Me.TextBoxEdad.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxEdad.TabIndex = 40
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Location = New System.Drawing.Point(233, 271)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxPeso.TabIndex = 41
        '
        'ComboBoxSexo
        '
        Me.ComboBoxSexo.FormattingEnabled = True
        Me.ComboBoxSexo.Items.AddRange(New Object() {"Masculino ", "Femenino"})
        Me.ComboBoxSexo.Location = New System.Drawing.Point(233, 307)
        Me.ComboBoxSexo.Name = "ComboBoxSexo"
        Me.ComboBoxSexo.Size = New System.Drawing.Size(162, 21)
        Me.ComboBoxSexo.TabIndex = 43
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(554, 136)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(536, 249)
        Me.DataGridView2.TabIndex = 46
        '
        'TextBoxIDC
        '
        Me.TextBoxIDC.Location = New System.Drawing.Point(233, 136)
        Me.TextBoxIDC.Name = "TextBoxIDC"
        Me.TextBoxIDC.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxIDC.TabIndex = 52
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.BackColor = System.Drawing.Color.Peru
        Me.ButtonAgregar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.Location = New System.Drawing.Point(80, 370)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(121, 40)
        Me.ButtonAgregar.TabIndex = 56
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto_practica.My.Resources.Resources.clientes1
        Me.PictureBox2.Location = New System.Drawing.Point(171, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.Peru
        Me.ButtonModificar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificar.Location = New System.Drawing.Point(216, 370)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(121, 40)
        Me.ButtonModificar.TabIndex = 58
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.Peru
        Me.ButtonEliminar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.Location = New System.Drawing.Point(361, 370)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(121, 40)
        Me.ButtonEliminar.TabIndex = 59
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(1176, 494)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.TextBoxIDC)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ComboBoxSexo)
        Me.Controls.Add(Me.TextBoxPeso)
        Me.Controls.Add(Me.TextBoxEdad)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.ButtonRegresar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonRegresar As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxEdad As TextBox
    Friend WithEvents TextBoxPeso As TextBox
    Friend WithEvents ComboBoxSexo As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBoxIDC As TextBox
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
End Class
