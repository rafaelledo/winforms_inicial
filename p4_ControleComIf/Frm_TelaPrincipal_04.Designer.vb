<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ControleFluxo
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
        Me.Lbl_Idade = New System.Windows.Forms.Label()
        Me.Txt_Idade = New System.Windows.Forms.TextBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Gb_Acompanhada = New System.Windows.Forms.GroupBox()
        Me.Rb_Nao = New System.Windows.Forms.RadioButton()
        Me.Rb_Sim = New System.Windows.Forms.RadioButton()
        Me.Gb_Acompanhada.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(12, 155)
        Me.Btn_Principal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(252, 22)
        Me.Btn_Principal.TabIndex = 0
        Me.Btn_Principal.Text = "Checagem da permissão de entrada"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(138, 15)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "Controle de Fluxo com If"
        '
        'Lbl_Idade
        '
        Me.Lbl_Idade.AutoSize = True
        Me.Lbl_Idade.Location = New System.Drawing.Point(12, 57)
        Me.Lbl_Idade.Name = "Lbl_Idade"
        Me.Lbl_Idade.Size = New System.Drawing.Size(36, 15)
        Me.Lbl_Idade.TabIndex = 2
        Me.Lbl_Idade.Text = "Idade"
        '
        'Txt_Idade
        '
        Me.Txt_Idade.Location = New System.Drawing.Point(12, 75)
        Me.Txt_Idade.Name = "Txt_Idade"
        Me.Txt_Idade.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Idade.TabIndex = 3
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(12, 219)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(634, 23)
        Me.Txt_Resultado.TabIndex = 4
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(12, 201)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(59, 15)
        Me.Lbl_Resultado.TabIndex = 5
        Me.Lbl_Resultado.Text = "Resultado"
        '
        'Gb_Acompanhada
        '
        Me.Gb_Acompanhada.Controls.Add(Me.Rb_Nao)
        Me.Gb_Acompanhada.Controls.Add(Me.Rb_Sim)
        Me.Gb_Acompanhada.Location = New System.Drawing.Point(135, 57)
        Me.Gb_Acompanhada.Name = "Gb_Acompanhada"
        Me.Gb_Acompanhada.Size = New System.Drawing.Size(212, 57)
        Me.Gb_Acompanhada.TabIndex = 6
        Me.Gb_Acompanhada.TabStop = False
        Me.Gb_Acompanhada.Text = "Está acompanhada dos pais?"
        '
        'Rb_Nao
        '
        Me.Rb_Nao.AutoSize = True
        Me.Rb_Nao.Location = New System.Drawing.Point(101, 22)
        Me.Rb_Nao.Name = "Rb_Nao"
        Me.Rb_Nao.Size = New System.Drawing.Size(47, 19)
        Me.Rb_Nao.TabIndex = 1
        Me.Rb_Nao.TabStop = True
        Me.Rb_Nao.Text = "Não"
        Me.Rb_Nao.UseVisualStyleBackColor = True
        '
        'Rb_Sim
        '
        Me.Rb_Sim.AutoSize = True
        Me.Rb_Sim.Location = New System.Drawing.Point(35, 22)
        Me.Rb_Sim.Name = "Rb_Sim"
        Me.Rb_Sim.Size = New System.Drawing.Size(45, 19)
        Me.Rb_Sim.TabIndex = 0
        Me.Rb_Sim.TabStop = True
        Me.Rb_Sim.Text = "Sim"
        Me.Rb_Sim.UseVisualStyleBackColor = True
        '
        'Frm_ControleFluxo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.Gb_Acompanhada)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Txt_Idade)
        Me.Controls.Add(Me.Lbl_Idade)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_ControleFluxo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Fluxo com If"
        Me.Gb_Acompanhada.ResumeLayout(False)
        Me.Gb_Acompanhada.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Lbl_Idade As Label
    Friend WithEvents Txt_Idade As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Gb_Acompanhada As GroupBox
    Friend WithEvents Rb_Nao As RadioButton
    Friend WithEvents Rb_Sim As RadioButton
End Class