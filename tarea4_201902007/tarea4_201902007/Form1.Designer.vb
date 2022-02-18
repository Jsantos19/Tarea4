<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.txt_factor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Calcular
        '
        Me.btn_Calcular.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Calcular.Location = New System.Drawing.Point(151, 156)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(160, 46)
        Me.btn_Calcular.TabIndex = 1
        Me.btn_Calcular.Text = "CALCULAR"
        Me.btn_Calcular.UseVisualStyleBackColor = True
        '
        'txt_factor
        '
        Me.txt_factor.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_factor.Location = New System.Drawing.Point(173, 98)
        Me.txt_factor.Name = "txt_factor"
        Me.txt_factor.Size = New System.Drawing.Size(123, 35)
        Me.txt_factor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(112, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cálculo factorial de un número"
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_resultado.Location = New System.Drawing.Point(192, 223)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(104, 30)
        Me.lbl_resultado.TabIndex = 4
        Me.lbl_resultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 304)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_factor)
        Me.Controls.Add(Me.btn_Calcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Calcular As Button
    Friend WithEvents txt_factor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_resultado As Label
End Class
