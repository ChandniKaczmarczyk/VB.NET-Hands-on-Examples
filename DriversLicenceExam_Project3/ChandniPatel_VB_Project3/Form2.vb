Public Class Form2

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If correct >= 15 Then
            Label1.Text = "You are passed. " & "Your Score is :" & correct
        Else
            Label1.Text = "You are failed. " & "Your Score is :" & correct
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class