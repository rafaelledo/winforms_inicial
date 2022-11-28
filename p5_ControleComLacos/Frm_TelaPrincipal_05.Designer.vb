<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_LacosRepeticao
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
        Me.Btn_Principal = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Lbl_Rendimento = New System.Windows.Forms.Label()
        Me.Txt_Principal = New System.Windows.Forms.TextBox()
        Me.Txt_Rendimento = New System.Windows.Forms.TextBox()
        Me.Txt_Periodos = New System.Windows.Forms.TextBox()
        Me.Lbl_Periodos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(244, 282)
        Me.Btn_Principal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(193, 22)
        Me.Btn_Principal.TabIndex = 0
        Me.Btn_Principal.Text = "Calcular Valor"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(108, 15)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "Laços de Repetição"
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(117, 164)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(84, 15)
        Me.Lbl_Principal.TabIndex = 2
        Me.Lbl_Principal.Text = "Valor Investido"
        '
        'Lbl_Rendimento
        '
        Me.Lbl_Rendimento.AutoSize = True
        Me.Lbl_Rendimento.Location = New System.Drawing.Point(307, 164)
        Me.Lbl_Rendimento.Name = "Lbl_Rendimento"
        Me.Lbl_Rendimento.Size = New System.Drawing.Size(47, 15)
        Me.Lbl_Rendimento.TabIndex = 3
        Me.Lbl_Rendimento.Text = "Juros %"
        '
        'Txt_Principal
        '
        Me.Txt_Principal.Location = New System.Drawing.Point(106, 198)
        Me.Txt_Principal.Name = "Txt_Principal"
        Me.Txt_Principal.Size = New System.Drawing.Size(108, 23)
        Me.Txt_Principal.TabIndex = 4
        '
        'Txt_Rendimento
        '
        Me.Txt_Rendimento.Location = New System.Drawing.Point(271, 198)
        Me.Txt_Rendimento.Name = "Txt_Rendimento"
        Me.Txt_Rendimento.Size = New System.Drawing.Size(121, 23)
        Me.Txt_Rendimento.TabIndex = 5
        '
        'Txt_Periodos
        '
        Me.Txt_Periodos.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace
        Me.Txt_Periodos.Location = New System.Drawing.Point(441, 198)
        Me.Txt_Periodos.Name = "Txt_Periodos"
        Me.Txt_Periodos.Size = New System.Drawing.Size(121, 23)
        Me.Txt_Periodos.TabIndex = 7
        '
        'Lbl_Periodos
        '
        Me.Lbl_Periodos.AutoSize = True
        Me.Lbl_Periodos.Location = New System.Drawing.Point(471, 164)
        Me.Lbl_Periodos.Name = "Lbl_Periodos"
        Me.Lbl_Periodos.Size = New System.Drawing.Size(53, 15)
        Me.Lbl_Periodos.TabIndex = 6
        Me.Lbl_Periodos.Text = "Períodos"
        '
        'Frm_LacosRepeticao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.Txt_Periodos)
        Me.Controls.Add(Me.Lbl_Periodos)
        Me.Controls.Add(Me.Txt_Rendimento)
        Me.Controls.Add(Me.Txt_Principal)
        Me.Controls.Add(Me.Lbl_Rendimento)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_LacosRepeticao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laços de Repetição"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Lbl_Rendimento As Label
    Friend WithEvents Txt_Principal As TextBox
    Friend WithEvents Txt_Rendimento As TextBox
    Friend WithEvents Txt_Periodos As TextBox
    Friend WithEvents Lbl_Periodos As Label
End Class
