Imports System.Net.Mime.MediaTypeNames

Public Class Frm_TelaPrincipal_02
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_NumerosInteiros.Click
        Dim idade As Integer = 12
        MsgBox("O valor da idade é " + idade.ToString, MsgBoxStyle.Critical)

        idade = 12 * 5
        MsgBox("O valor da idade multiplicado por 5 é " + idade.ToString, MsgBoxStyle.Critical)

        idade = (12 * 5) + 10
        MsgBox("O valor da idade multiplicado por 5 e acrescido de 10 é " + idade.ToString, MsgBoxStyle.Critical)
    End Sub

    Private Sub Btn_PontoFlutuante_Click(sender As Object, e As EventArgs) Handles Btn_PontoFlutuante.Click
        Dim valor As Double = 9.5

        MsgBox("O valor da variável valor é " + valor.ToString, MsgBoxStyle.Critical)

        valor = 5 / 2

        MsgBox("O valor de 5 / 2 é " + valor.ToString, MsgBoxStyle.Critical)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        valor = numerador / denominador

        MsgBox("O valor de 5 / 2 é " + valor.ToString, MsgBoxStyle.Critical)
    End Sub

    Private Sub Btn_ConversaoNumeros_Click(sender As Object, e As EventArgs) Handles Btn_ConversaoNumeros.Click
        Dim salario As Double
        salario = 1300.45

        Dim salarioInteiro As Integer = salario

        MsgBox("O valor do salário é " + salario.ToString + " e do salario inteiro " + salarioInteiro.ToString,
               MsgBoxStyle.Critical)

        Dim salarioGrande As Long
        salarioGrande = 1000000000000000000

        MsgBox("O valor do salário longo é " + salarioGrande.ToString, MsgBoxStyle.Critical)

        Dim salarioPequeno As Short
        salarioPequeno = 10000

        MsgBox("O valor do salário pequeno é " + salarioPequeno.ToString, MsgBoxStyle.Critical)

        Dim salarioMinusculo As SByte
        salarioMinusculo = 10
        MsgBox("O valor do salário minúsculo é " + salarioMinusculo.ToString, MsgBoxStyle.Critical)

        Dim valorDouble As Double
        valorDouble = 9.2312342352341
        MsgBox("O valor da variável double é " + valorDouble.ToString, MsgBoxStyle.Critical)

        Dim valorDecimal As Double
        valorDecimal = 9.2312342352341
        MsgBox("O valor da variável decimal é " + valorDecimal.ToString, MsgBoxStyle.Critical)
    End Sub

    Private Sub Btn_Resultado_Click(sender As Object, e As EventArgs) Handles Btn_Resultado.Click
        Dim numerador As Decimal = Txt_Numerador.Text
        Dim denominador As Decimal = Txt_Denominador.Text

        Dim resultadoDecimal As Decimal = numerador / denominador

        MsgBox("O resultado decimal da a divisão entre " + numerador.ToString + " e " +
               denominador.ToString + " é " + resultadoDecimal.ToString, MsgBoxStyle.Critical)

        Dim resultadoDouble As Double = numerador / denominador

        MsgBox("O resultado double da a divisão entre " + numerador.ToString + " e " +
               denominador.ToString + " é " + resultadoDouble.ToString, MsgBoxStyle.Critical)

        Txt_ResultadoDecimal.Text = resultadoDecimal.ToString
        Txt_ResultadoDouble.Text = resultadoDouble.ToString
    End Sub
End Class
