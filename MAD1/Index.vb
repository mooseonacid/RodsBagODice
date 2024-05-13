﻿Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Index
    Private fullStats As List(Of CreatureFullStats)

    Private Sub IndexForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MagicItemsDataGrid.DataSource = MagicItemDatabase.Items
        CreatureDataGridView.DataSource = CreatureDatabase.Creatures

        MagicItemsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        CreatureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        'loads csv for creature stat blocks

        'release
        'Dim filePath As String = Path.Combine(Application.StartupPath, "Resources\creatureFullStat.csv")

        'debug
        Dim startupDirectory As New DirectoryInfo(Application.StartupPath)
        Dim projectDirectory As String = startupDirectory.Parent.Parent.Parent.FullName
        Dim filePath As String = Path.Combine(projectDirectory, "Resources\creatureFullStat.csv")

        fullStats = LoadFullStats(filePath)

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
            'find full stats
            Dim selectedFullStats As CreatureFullStats = fullStats.Find(Function(fs) fs.Name = selectedCreature.Name)
            Dim statBlock = GenerateStatBlock(selectedCreature, selectedFullStats)
            MessageBox.Show(statBlock)
        End If
    End Sub

    Public Shared Function LoadFullStats(filePath As String) As List(Of CreatureFullStats)
        Dim fullStats = New List(Of CreatureFullStats)

        'parses csv file containing creature info for stat blocks
        Using parser As New TextFieldParser(filePath)
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters(",")
            'parse time
            While Not parser.EndOfData
                Dim fields = parser.ReadFields()

                Dim ac As Integer
                Integer.TryParse(fields(1), ac)

                Dim hp As Integer
                Integer.TryParse(fields(2), hp)

                Dim speed As String = fields(3)

                Dim str As Integer
                Integer.TryParse(fields(4), str)

                Dim dex As Integer
                Integer.TryParse(fields(5), dex)

                Dim con As Integer
                Integer.TryParse(fields(6), con)

                Dim int As Integer
                Integer.TryParse(fields(7), int)

                Dim wis As Integer
                Integer.TryParse(fields(8), wis)

                Dim cha As Integer
                Integer.TryParse(fields(9), cha)

                Dim saves As String = fields(10)
                Dim skills As String = fields(11)
                Dim senses As String = fields(12)
                Dim languages As String = fields(13)
                Dim additional As String = fields(14)

                Dim stats = New CreatureFullStats(fields(0), ac, hp, speed, str, dex, con, int, wis, cha, saves, skills, senses, languages, additional)
                'Dim stats = New CreatureFullStats(fields(0), Integer.Parse(fields(5)), Integer.Parse(fields(6)), fields(7), Integer.Parse(fields(8)), Integer.Parse(fields(9)), Integer.Parse(fields(10)), Integer.Parse(fields(11)), Integer.Parse(fields(12)), Integer.Parse(fields(13)), fields(14), fields(15), fields(17), fields(18), fields(20))
                fullStats.Add(stats)
            End While
        End Using
        'result of parse
        Return fullStats
    End Function

    'create actual formatted stat block
    Private Shared Function GenerateStatBlock(creature As Creature, fullStats As CreatureFullStats) As String
        Return $"Name: {creature.Name}" & Environment.NewLine &
            $"{creature.Size} {creature.Type}, {creature.Alignment}" & Environment.NewLine &
            $"Armor Class: {fullStats.AC}" & Environment.NewLine &
            $"Hit Points: {fullStats.HP}" & Environment.NewLine &
            $"Speed: {fullStats.Speed}" & Environment.NewLine &
            $"STR: {fullStats.STR} | DEX: {fullStats.DEX} | CON: {fullStats.CON} | INT: {fullStats.INT} | WIS: {fullStats.WIS} | CHA: {fullStats.CHA}" & Environment.NewLine &
            $"Skills: {fullStats.Skills}" & Environment.NewLine &
            $"Senses: {fullStats.Senses}" & Environment.NewLine &
            $"Languages: {fullStats.Languages}" & Environment.NewLine &
            $"Challenge: {creature.Challenge} ({creature.XP})" & Environment.NewLine &
            $"Additional: {fullStats.Additional}"
    End Function
End Class