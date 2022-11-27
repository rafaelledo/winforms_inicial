<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal_03
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
        Me.Btn_Char = New System.Windows.Forms.Button()
        Me.Txt_Numero_Char = New System.Windows.Forms.TextBox()
        Me.Lbl_Curso = New System.Windows.Forms.Label()
        Me.Txt_Curso = New System.Windows.Forms.TextBox()
        Me.Btn_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_Lista = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(12, 40)
        Me.Btn_Principal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(236, 40)
        Me.Btn_Principal.TabIndex = 0
        Me.Btn_Principal.Text = "Clique para ver os resultados"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(114, 15)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "Manipulando Textos"
        '
        'Btn_Char
        '
        Me.Btn_Char.Location = New System.Drawing.Point(520, 83)
        Me.Btn_Char.Name = "Btn_Char"
        Me.Btn_Char.Size = New System.Drawing.Size(168, 38)
        Me.Btn_Char.TabIndex = 2
        Me.Btn_Char.Text = "Clique Para Obter o Char"
        Me.Btn_Char.UseVisualStyleBackColor = True
        '
        'Txt_Numero_Char
        '
        Me.Txt_Numero_Char.Location = New System.Drawing.Point(520, 24)
        Me.Txt_Numero_Char.Name = "Txt_Numero_Char"
        Me.Txt_Numero_Char.Size = New System.Drawing.Size(168, 23)
        Me.Txt_Numero_Char.TabIndex = 3
        '
        'Lbl_Curso
        '
        Me.Lbl_Curso.AutoSize = True
        Me.Lbl_Curso.Location = New System.Drawing.Point(12, 97)
        Me.Lbl_Curso.Name = "Lbl_Curso"
        Me.Lbl_Curso.Size = New System.Drawing.Size(152, 15)
        Me.Lbl_Curso.TabIndex = 4
        Me.Lbl_Curso.Text = "Digite o seu curso preferido"
        '
        'Txt_Curso
        '
        Me.Txt_Curso.Location = New System.Drawing.Point(15, 123)
        Me.Txt_Curso.Name = "Txt_Curso"
        Me.Txt_Curso.Size = New System.Drawing.Size(253, 23)
        Me.Txt_Curso.TabIndex = 5
        '
        'Btn_Adicionar
        '
        Me.Btn_Adicionar.Location = New System.Drawing.Point(279, 123)
        Me.Btn_Adicionar.Name = "Btn_Adicionar"
        Me.Btn_Adicionar.Size = New System.Drawing.Size(143, 23)
        Me.Btn_Adicionar.TabIndex = 6
        Me.Btn_Adicionar.Text = "Adicione a sua lista"
        Me.Btn_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_Lista
        '
        Me.Txt_Lista.Location = New System.Drawing.Point(17, 159)
        Me.Txt_Lista.Multiline = True
        Me.Txt_Lista.Name = "Txt_Lista"
        Me.Txt_Lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Lista.Size = New System.Drawing.Size(379, 167)
        Me.Txt_Lista.TabIndex = 7
        '
        'Frm_TelaPrincipal_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.Txt_Lista)
        Me.Controls.Add(Me.Btn_Adicionar)
        Me.Controls.Add(Me.Txt_Curso)
        Me.Controls.Add(Me.Lbl_Curso)
        Me.Controls.Add(Me.Txt_Numero_Char)
        Me.Controls.Add(Me.Btn_Char)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_TelaPrincipal_03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manipulando Textos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btn_Char As Button
    Friend WithEvents Txt_Numero_Char As TextBox
    Friend WithEvents Lbl_Curso As Label
    Friend WithEvents Txt_Curso As TextBox
    Friend WithEvents Btn_Adicionar As Button
    Friend WithEvents Txt_Lista As TextBox
End Class