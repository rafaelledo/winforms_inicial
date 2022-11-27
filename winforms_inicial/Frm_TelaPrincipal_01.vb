Public Class Frm_TelaPrincipal_01
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        MsgBox("Olá Mundo!", MsgBoxStyle.Critical, "Erro")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lbl_NomeProjeto.Click

    End Sub
End Class
