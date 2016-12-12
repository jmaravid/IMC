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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaltura = New System.Windows.Forms.TextBox()
        Me.txtcalcula = New System.Windows.Forms.TextBox()
        Me.txtpeso = New System.Windows.Forms.TextBox()
        Me.btncalcula = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblmensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ingrese talla en m"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingrese peso en Kg"
        '
        'txtaltura
        '
        Me.txtaltura.Location = New System.Drawing.Point(20, 106)
        Me.txtaltura.Name = "txtaltura"
        Me.txtaltura.Size = New System.Drawing.Size(111, 20)
        Me.txtaltura.TabIndex = 1
        '
        'txtcalcula
        '
        Me.txtcalcula.Location = New System.Drawing.Point(151, 152)
        Me.txtcalcula.Name = "txtcalcula"
        Me.txtcalcula.Size = New System.Drawing.Size(111, 20)
        Me.txtcalcula.TabIndex = 5
        '
        'txtpeso
        '
        Me.txtpeso.Location = New System.Drawing.Point(20, 53)
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.Size = New System.Drawing.Size(111, 20)
        Me.txtpeso.TabIndex = 0
        '
        'btncalcula
        '
        Me.btncalcula.Location = New System.Drawing.Point(21, 150)
        Me.btncalcula.Name = "btncalcula"
        Me.btncalcula.Size = New System.Drawing.Size(94, 23)
        Me.btncalcula.TabIndex = 2
        Me.btncalcula.Text = "Calcular IMC"
        Me.btncalcula.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(108, 251)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Riesgo Según IMC"
        '
        'lblmensaje
        '
        Me.lblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmensaje.Location = New System.Drawing.Point(23, 223)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(239, 23)
        Me.lblmensaje.TabIndex = 10
        Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 286)
        Me.Controls.Add(Me.lblmensaje)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtaltura)
        Me.Controls.Add(Me.txtcalcula)
        Me.Controls.Add(Me.txtpeso)
        Me.Controls.Add(Me.btncalcula)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcula IMC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtaltura As TextBox
    Friend WithEvents txtcalcula As TextBox
    Friend WithEvents txtpeso As TextBox
    Friend WithEvents btncalcula As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblmensaje As Label
End Class
