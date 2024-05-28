<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCerrarAplicacion = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(577, 12)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(169, 79)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Base de Datos"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(398, 200)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(925, 49)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(460, 200)
        Me.DataGridView3.TabIndex = 3
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(-1, 291)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(440, 225)
        Me.DataGridView4.TabIndex = 4
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(925, 291)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.Size = New System.Drawing.Size(460, 197)
        Me.DataGridView5.TabIndex = 5
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(-1, 549)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowHeadersWidth = 51
        Me.DataGridView6.Size = New System.Drawing.Size(1436, 233)
        Me.DataGridView6.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(502, 103)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(408, 415)
        Me.TextBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Seleccionar ""codigo de Marca y Tipo de Vehiculo"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Seleccionar ""idVendedor y Nombre"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(921, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(349, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Seleccionar ""Nombre,Direccion y Telefono"""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(907, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(541, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Seleccionar ""nro_factura,Nombre,Fech_Venta,Comision,impt_total"""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 526)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(435, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Seleccionar ""traccion,modelo,nro_puerta,color,precio"""
        '
        'btnCerrarAplicacion
        '
        Me.btnCerrarAplicacion.Location = New System.Drawing.Point(748, 12)
        Me.btnCerrarAplicacion.Name = "btnCerrarAplicacion"
        Me.btnCerrarAplicacion.Size = New System.Drawing.Size(167, 79)
        Me.btnCerrarAplicacion.TabIndex = 14
        Me.btnCerrarAplicacion.Text = "Cerrar App"
        Me.btnCerrarAplicacion.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(432, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(139, 79)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 838)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCerrarAplicacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView6)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnConectar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCerrarAplicacion As Button
    Friend WithEvents btnLimpiar As Button
End Class
