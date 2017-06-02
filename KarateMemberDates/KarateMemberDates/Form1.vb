Public Class Form1

    Private Sub PaymentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Karate_DatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Karate_DatabaseDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.Karate_DatabaseDataSet.Members)
        'TODO: This line of code loads data into the 'Karate_DatabaseDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.Karate_DatabaseDataSet.Payments)

    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Me.MembersTableAdapter.FillByDate(Me.Karate_DatabaseDataSet.Members, DateTimePicker1.Value)
        Catch ex As Exception
            MessageBox.Show("Please Select Valid Date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
