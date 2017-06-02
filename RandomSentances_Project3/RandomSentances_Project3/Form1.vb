Public Class Form1
    Dim strArticles() As String = {"the", "a", "an", "another", "some", "one"}
    Dim strNouns() As String = {"computer", "bird", "girl", "person", "boy", "men", "animal", "processor", "knowledge", "women"}
    Dim strPrepositions() As String = {"before", "after", "on", "by", "through", "around", "behind", "near", "over", "below", "above", "toward"}
    Dim strAdjectives() As String = {"small", "good", "bad", "important", "useful", "helpful", "interesting", "right", "new", "public", "young"}
    Dim strVerbs() As String = {"put", "used", "processed", "help", "contain", "check", "offer", "grow", "bring", "study"}


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnNextSentence_Click(sender As Object, e As EventArgs) Handles btnNextSentence.Click
        Dim arrayindx As Integer
        Dim rNumber As New Random

        Dim NewGeneratedSentence As String = " "

        arrayindx = rNumber.Next(0, strArticles.Length)
        NewGeneratedSentence &= StrConv(strArticles(arrayindx), VbStrConv.ProperCase) & " "

        arrayindx = rNumber.Next(0, strAdjectives.Length)
        NewGeneratedSentence &= strAdjectives(arrayindx) & " "

        arrayindx = rNumber.Next(0, strNouns.Length)
        NewGeneratedSentence &= strNouns(arrayindx) & " "

        arrayindx = rNumber.Next(0, strVerbs.Length)
        NewGeneratedSentence &= strVerbs(arrayindx) & " "

        arrayindx = rNumber.Next(0, strPrepositions.Length)
        NewGeneratedSentence &= strPrepositions(arrayindx) & " "

        arrayindx = rNumber.Next(0, strArticles.Length)
        NewGeneratedSentence &= strArticles(arrayindx) & " "

        arrayindx = rNumber.Next(0, strAdjectives.Length)
        NewGeneratedSentence &= strAdjectives(arrayindx) & " "

        arrayindx = rNumber.Next(0, strNouns.Length)
        NewGeneratedSentence &= strNouns(arrayindx) & "."

        ListBox1.Items.Add(NewGeneratedSentence)
    End Sub
End Class
