Public Class Frm_LacosRepeticao
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Dim investimento As Decimal = Val(Txt_Principal.Text)
        Dim rendimento As Decimal = Val(Txt_Rendimento.Text) / 100
        Dim periodos As Integer = Val(Txt_Periodos.Text)
        Dim contador As Integer = 1

        For i As Integer = 1 To periodos
            investimento += investimento * rendimento
            'Exit For < palvra reservada para sair do loop
            'Continue For < palavra reservada para pular a execução
        Next


        'While (contador <= periodos)
        '    investimento += investimento * rendimento
        '    contador += 1
        'End While


        MsgBox("O saldo do investimento após " + periodos.ToString + " meses é " + investimento.ToString)
    End Sub
End Class
