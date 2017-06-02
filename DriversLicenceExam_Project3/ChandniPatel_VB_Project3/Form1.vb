Public Class Form1

    Dim LicenceAnswer() As String = {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"}
    Dim count As Integer = 0

    Private Sub BtnScore_Click(sender As Object, e As EventArgs) Handles BtnScore.Click
        Dim i As Integer = 0
        Dim AnswerArray(19) As String
        Dim validinput As Boolean = True

        AnswerArray(0) = TxtAns0.Text
        AnswerArray(1) = TxtAns1.Text
        AnswerArray(2) = TxtAns2.Text
        AnswerArray(3) = TxtAns3.Text
        AnswerArray(4) = TxtAns4.Text
        AnswerArray(5) = TxtAns5.Text
        AnswerArray(6) = TxtAns6.Text
        AnswerArray(7) = TxtAns7.Text
        AnswerArray(8) = TxtAns8.Text
        AnswerArray(9) = TxtAns9.Text
        AnswerArray(10) = TxtAns10.Text
        AnswerArray(11) = TxtAns11.Text
        AnswerArray(12) = TxtAns12.Text
        AnswerArray(13) = TxtAns13.Text
        AnswerArray(14) = TxtAns14.Text
        AnswerArray(15) = TxtAns15.Text
        AnswerArray(16) = TxtAns16.Text
        AnswerArray(17) = TxtAns17.Text
        AnswerArray(18) = TxtAns18.Text
        AnswerArray(19) = TxtAns19.Text

        Try
            For i = 0 To 19
                If AnswerArray(i).ToUpper() = "A" Or AnswerArray(i).ToUpper() = "B" Or AnswerArray(i).ToUpper() = "C" Or AnswerArray(i).ToUpper() = "D" Then
                    If LicenceAnswer(i) = AnswerArray(i).ToUpper() Then
                        count += 1
                        Form2.lstboxResult.Items.Add(i + 1 & " Correct")
                    Else
                        Form2.lstboxResult.Items.Add(i + 1 & " Incorrect. " & "Correct Answer is: " & LicenceAnswer(i))
                    End If
                Else
                    validinput = False
                End If
            Next
            If validinput = False Then

                MessageBox.Show("Only A, B, C, D are valid inputs.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Else
                correct = count
                incorrect = 20 - correct
                Me.Hide()
                Form2.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TxtAns0.Text = ""
        TxtAns1.Text = ""
        TxtAns2.Text = ""
        TxtAns3.Text = ""
        TxtAns4.Text = ""
        TxtAns5.Text = ""
        TxtAns6.Text = ""
        TxtAns7.Text = ""
        TxtAns8.Text = ""
        TxtAns9.Text = ""
        TxtAns10.Text = ""
        TxtAns11.Text = ""
        TxtAns12.Text = ""
        TxtAns13.Text = ""
        TxtAns14.Text = ""
        TxtAns15.Text = ""
        TxtAns16.Text = ""
        TxtAns17.Text = ""
        TxtAns18.Text = ""
        TxtAns19.Text = ""
        correct = 0
        incorrect = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
