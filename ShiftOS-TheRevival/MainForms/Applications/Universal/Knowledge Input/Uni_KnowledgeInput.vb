Public Class Uni_KnowledgeInput
    Dim PrevWidthTxt_InputWord As Integer

    Private Sub Uni_KnowledgeInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrevWidthTxt_InputWord = txt_InputWord.Width
    End Sub

    Private Sub Uni_KnowledgeInput_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Dim Txt_InputTextWidthRatio As Double = (txt_InputWord.Width / PrevWidthTxt_InputWord)
        'txt_InputWord.Width = txt_InputWord.Width * Txt_InputTextWidthRatio
        'PrevWidthTxt_InputWord = txt_InputWord.Width
    End Sub
End Class