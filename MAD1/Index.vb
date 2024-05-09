Imports System.IO

Public Class Index
    Private Sub IndexForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MagicItemsDataGrid.DataSource = MagicItemDatabase.Items
        CreatureDataGridView.DataSource = CreatureDatabase.Creatures

        MagicItemsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        CreatureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        'Creature info column
        Dim infoButtonColumn As New DataGridViewButtonColumn()
        infoButtonColumn.Name = "Info"
        infoButtonColumn.HeaderText = "Info"
        infoButtonColumn.Text = "Info"
        infoButtonColumn.UseColumnTextForButtonValue = True

        CreatureDataGridView.Columns.Add(infoButtonColumn)
    End Sub

    Private Sub MagicSearchBox_TextChanged(sender As Object, e As EventArgs) Handles MagicSearchBox.TextChanged
        Dim searchText As String = MagicSearchBox.Text

        If String.IsNullOrEmpty(searchText) Then
            MagicItemsDataGrid.DataSource = MagicItemDatabase.Items
        Else
            MagicItemsDataGrid.DataSource = MagicItemDatabase.Items.Where(Function(item) item.Name.Contains(searchText)).ToList()
        End If
    End Sub

    Private Sub CreatureSearchBox_TextChanged(sender As Object, e As EventArgs) Handles CreatureSearchBox.TextChanged
        Dim searchText As String = CreatureSearchBox.Text

        If String.IsNullOrEmpty(searchText) Then
            CreatureDataGridView.DataSource = CreatureDatabase.Creatures
        Else
            CreatureDataGridView.DataSource = CreatureDatabase.Creatures.Where(Function(creature) creature.Name.Contains(searchText)).ToList()
        End If
    End Sub

    'handle info button
    Private Sub CreatureDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CreatureDataGridView.CellContentClick
        If CreatureDataGridView.Columns(e.ColumnIndex).Name = "Info" Then
            'get creature
            Dim selectedCreature As Creature = CType(CreatureDataGridView.Rows(e.RowIndex).DataBoundItem, Creature)

            'New dialog
            Dim dialog As New Form()
            dialog.Text = selectedCreature.Name
            dialog.FormBorderStyle = FormBorderStyle.FixedToolWindow
            Dim pictureBox As New PictureBox()

            'release
            'Dim filePath As String = Path.Combine(Application.StartupPath, "creatures", selectedCreature.Name & ".png")

            'debug
            Dim startupDirectory As New DirectoryInfo(Application.StartupPath)
            Dim projectDirectory As String = startupDirectory.Parent.Parent.Parent.FullName
            Dim filePath As String = Path.Combine(projectDirectory, "creatures", selectedCreature.Name & ".png")

            If File.Exists(filePath) Then
                pictureBox.Image = Image.FromFile(filePath)
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize
                dialog.Controls.Add(pictureBox)
                dialog.ClientSize = pictureBox.Size
            Else
                dialog.Controls.Add(New Label() With {.Text = "Image not found: " & filePath, .Location = New Point(10, 10)})
            End If
            dialog.ShowDialog()
        End If
    End Sub
End Class