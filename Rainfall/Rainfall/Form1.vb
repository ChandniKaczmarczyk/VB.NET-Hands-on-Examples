Public Class Form1

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        Dim dscore1 As Byte
        Dim dscore2 As Byte
        Dim dscore3 As Byte
        Dim dscore4 As Byte
        Dim dscore5 As Byte
        Dim dscore6 As Byte
        Dim dscore7 As Byte
        Dim dscore8 As Byte
        Dim dscore9 As Byte
        Dim dscore10 As Byte
        Dim dscore11 As Byte
        Dim dscore12 As Byte
        Dim dtotal As Double
        Dim davg As Double
        Try
            dscore1 = CByte(TextBox1.Text)
            dscore2 = CByte(TextBox2.Text)
            dscore3 = CByte(TextBox3.Text)
            dscore4 = CByte(TextBox4.Text)
            dscore5 = CByte(TextBox5.Text)
            dscore6 = CByte(TextBox6.Text)
            dscore7 = CByte(TextBox7.Text)
            dscore8 = CByte(TextBox8.Text)
            dscore9 = CByte(TextBox9.Text)
            dscore10 = CByte(TextBox10.Text)
            dscore11 = CByte(TextBox11.Text)
            dscore12 = CByte(TextBox12.Text)
            dtotal = dscore1 + dscore2 + dscore3 + dscore4 + dscore5 + dscore6 + dscore7 + dscore8 + dscore9 + dscore10 + dscore11 + dscore12
            davg = dtotal / 12
            lbl1.Text = dtotal.ToString("n2")
            lbl2.Text = davg.ToString("n2")

        Catch ex As Exception
            MessageBox.Show("Data Must be NUMERIC.! Try Again")
        End Try
    End Sub

    Private Sub btncl_Click(sender As Object, e As EventArgs) Handles btncl.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        lbl1.Text = ""
        lbl2.Text = ""
    End Sub

    Private Sub btne_Click(sender As Object, e As EventArgs) Handles btne.Click
        Me.Close()
    End Sub
End Class
