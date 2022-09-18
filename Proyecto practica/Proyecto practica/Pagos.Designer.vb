<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos
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
        Me.TextBoxIDP = New System.Windows.Forms.TextBox()
        Me.TextBoxMonto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerProximo = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBoxIDC = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxIDP
        '
        Me.TextBoxIDP.Location = New System.Drawing.Point(167, 166)
        Me.TextBoxIDP.Name = "TextBoxIDP"
        Me.TextBoxIDP.Size = New System.Drawing.Size(196, 20)
        Me.TextBoxIDP.TabIndex = 60
        '
        'TextBoxMonto
        '
        Me.TextBoxMonto.Location = New System.Drawing.Point(167, 268)
        Me.TextBoxMonto.Name = "TextBoxMonto"
        Me.TextBoxMonto.Size = New System.Drawing.Size(196, 20)
        Me.TextBoxMonto.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 21)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Fecha del pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Próximo pago"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Monto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "ID Pago"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 21)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 21)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "ID Cliente"
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"Efectivo", "Transferencia bancaria", "POS", "Cheque"})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(167, 303)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(196, 21)
        Me.ComboBoxTipo.TabIndex = 63
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(167, 197)
        Me.DateTimePickerFecha.MinDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePickerFecha.TabIndex = 64
        '
        'DateTimePickerProximo
        '
        Me.DateTimePickerProximo.Location = New System.Drawing.Point(167, 231)
        Me.DateTimePickerProximo.MinDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerProximo.Name = "DateTimePickerProximo"
        Me.DateTimePickerProximo.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePickerProximo.TabIndex = 65
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Proyecto_practica.My.Resources.Resources.pago3
        Me.PictureBox4.Location = New System.Drawing.Point(82, 32)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(194, 105)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 66
        Me.PictureBox4.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(465, 165)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 193)
        Me.DataGridView1.TabIndex = 67
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.BackColor = System.Drawing.Color.Peru
        Me.ButtonAgregar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.Location = New System.Drawing.Point(21, 389)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(121, 40)
        Me.ButtonAgregar.TabIndex = 69
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Peru
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(167, 389)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 40)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBoxIDC
        '
        Me.ComboBoxIDC.FormattingEnabled = True
        Me.ComboBoxIDC.Items.AddRange(New Object() {"Efectivo", "Transferencia bancaria", "POS", "Cheque"})
        Me.ComboBoxIDC.Location = New System.Drawing.Point(167, 340)
        Me.ComboBoxIDC.Name = "ComboBoxIDC"
        Me.ComboBoxIDC.Size = New System.Drawing.Size(196, 21)
        Me.ComboBoxIDC.TabIndex = 73
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Peru
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(891, 389)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 40)
        Me.Button3.TabIndex = 74
        Me.Button3.Text = "Regresar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Peru
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(312, 389)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 40)
        Me.Button4.TabIndex = 75
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(1069, 466)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBoxIDC)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.DateTimePickerProximo)
        Me.Controls.Add(Me.DateTimePickerFecha)
        Me.Controls.Add(Me.ComboBoxTipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxIDP)
        Me.Controls.Add(Me.TextBoxMonto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Pagos"
        Me.Text = "Pagos"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxIDP As TextBox
    Friend WithEvents TextBoxMonto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents DateTimePickerFecha As DateTimePicker
    Friend WithEvents DateTimePickerProximo As DateTimePicker
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBoxIDC As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
