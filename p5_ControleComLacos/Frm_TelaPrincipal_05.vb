Public Class Form1
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
        Next


        'While (contador <= periodos)
        '    investimento += investimento * rendimento
        '    contador += 1
        'End While


        MsgBox("O saldo do investimento após " + periodos.ToString + " meses é " + investimento.ToString)
    End Sub
End Class
