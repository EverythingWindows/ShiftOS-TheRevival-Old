Public Class Uni_KnowledgeInput
    Dim PrevWidthTxt_InputWord As Integer = 470

    Private Sub Uni_KnowledgeInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Category.Items.Remove("Animals")
    End Sub

    Private Sub txt_InputWord_TextChanged(sender As Object, e As KeyEventArgs) Handles txt_InputWord.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                lst_Guessed.Items.Add(txt_InputWord.Text)
                txt_InputWord.Text = Nothing
        End Select
    End Sub
End Class