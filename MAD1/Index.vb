Public Class Index
    Private Sub IndexForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MagicItemsDataGrid.DataSource = MagicItemDatabase.Items

        MagicItemsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub MagicSearchBox_TextChanged(sender As Object, e As EventArgs) Handles MagicSearchBox.TextChanged
        Dim searchText As String = MagicSearchBox.Text

        If String.IsNullOrEmpty(searchText) Then
            MagicItemsDataGrid.DataSource = MagicItemDatabase.Items
        Else
            MagicItemsDataGrid.DataSource = MagicItemDatabase.Items.Where(Function(item) item.Name.Contains(searchText)).ToList()
        End If
    End Sub
End Class