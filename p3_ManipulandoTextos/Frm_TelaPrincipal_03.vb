Public Class Frm_TelaPrincipal_03
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Dim PrimeiraLetra As Char = "a"
        MsgBox("O caractere da variável PrimeiraLetra é " + PrimeiraLetra)

        Dim SegundaLetra As Char = Chr(65)
        MsgBox("O número 65 é " + SegundaLetra)

        Dim NumeroChar As Integer = 65
        Dim TerceiraLetra As Char = Chr(NumeroChar)
        NumeroChar += 1
        Dim QuartaLetra As Char = Chr(NumeroChar)

        MsgBox("O caractere de número 65 é " + TerceiraLetra + " e o 66 é " + QuartaLetra)
    End Sub

    Private Sub Btn_Char_Click(sender As Object, e As EventArgs) Handles Btn_Char.Click
        Dim ValorChar As Integer = Val(Txt_Numero_Char.Text)
        Dim QuintaLetra As Char = Chr(ValorChar)

        MsgBox("O caractere para o número " + ValorChar.ToString + " é o " + QuintaLetra.ToString)
    End Sub

    Private Sub Lbl_Curso_Click(sender As Object, e As EventArgs) Handles Lbl_Curso.Click

    End Sub

    Private Sub Txt_Numero_Char_TextChanged(sender As Object, e As EventArgs) Handles Txt_Numero_Char.TextChanged

    End Sub

    Private Sub Btn_Adicionar_Click(sender As Object, e As EventArgs) Handles Btn_Adicionar.Click
        Dim CursoDigitado As String = Txt_Curso.Text + vbCrLf
        Txt_Lista.Text += CursoDigitado
    End Sub
End Class
