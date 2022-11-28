Public Class Frm_TelaPrincipal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New p1_PrimeiroProjeto.Frm_TelaPrincipal_01
        f.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New p2_CriandoVariaveis.Frm_TelaPrincipal_02
        f.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New p3_ManipulandoTextos.Frm_TelaPrincipal_03
        f.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New p4_ControleComIf.Frm_ControleFluxo
        f.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f As New p5_ControleComLacos.Frm_LacosRepeticao
        f.ShowDialog()
    End Sub
End Class
