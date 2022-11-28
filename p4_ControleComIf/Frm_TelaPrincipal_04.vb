Public Class Frm_ControleFluxo
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Dim idade As Integer = Val(Txt_Idade.Text)
        Dim estaAcompanhada As Boolean = Rb_Sim.Checked

        If (idade >= 18) Or (idade >= 16 And estaAcompanhada) Then
            Txt_Resultado.Text = "A pessoa pode assistir a peça"
        Else
            Txt_Resultado.Text = "A pessoa não pode assistir a peça."
        End If
    End Sub

End Class
