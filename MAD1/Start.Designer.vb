<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Menu = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        ResetCountersToolStripMenuItem = New ToolStripMenuItem()
        ClearHistoryToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        Tabs = New TabControl()
        TabPage1 = New TabPage()
        D20Count = New NumericUpDown()
        D20Button = New Button()
        D100Count = New NumericUpDown()
        D12Count = New NumericUpDown()
        D10Count = New NumericUpDown()
        D100Button = New Button()
        D12Button = New Button()
        D10Button = New Button()
        D8Count = New NumericUpDown()
        D6Count = New NumericUpDown()
        D8Button = New Button()
        D6Button = New Button()
        D4Count = New NumericUpDown()
        D4Button = New Button()
        TabPage2 = New TabPage()
        D30Count = New NumericUpDown()
        D24Count = New NumericUpDown()
        D16Count = New NumericUpDown()
        D14Count = New NumericUpDown()
        D7Count = New NumericUpDown()
        D5Count = New NumericUpDown()
        D30Button = New Button()
        D24Button = New Button()
        D16Button = New Button()
        D14Button = New Button()
        D7Button = New Button()
        D5Button = New Button()
        D3Count = New NumericUpDown()
        D3Button = New Button()
        TabPage3 = New TabPage()
        ItemGroup = New GroupBox()
        IndividualIncludeItemsCheck = New CheckBox()
        GPOnlyCheck = New CheckBox()
        MagicGenerate = New Button()
        MagicCRLabel = New Label()
        MagicCRSelect = New ComboBox()
        TabPage5 = New TabPage()
        NPCEncounterGroup = New GroupBox()
        EncounterEnvLabel = New Label()
        EncounterEnvControl = New ComboBox()
        EncounterGenButton = New Button()
        EncounterDiffControl = New ComboBox()
        EncounterDiffLabel = New Label()
        EncounterLevelControl = New ComboBox()
        EncounterPCLevelLabel = New Label()
        EncounterPCNumControl = New ComboBox()
        EncounterPCNumLabel = New Label()
        NPCNameGenGroup = New GroupBox()
        NameFemRadio = New RadioButton()
        NameMascRadio = New RadioButton()
        NameSurCheck = New CheckBox()
        NameRaceComboBox = New ComboBox()
        NameRaceLabel = New Label()
        NameGenerateButton = New Button()
        TabPage4 = New TabPage()
        Panel = New Panel()
        Panel1 = New Panel()
        NotesFontSize = New NumericUpDown()
        NotesFont = New ComboBox()
        NotesUnderline = New Button()
        NotesItalic = New Button()
        NoteBold = New Button()
        Panel2 = New Panel()
        historybox = New RichTextBox()
        notesbox = New RichTextBox()
        NotesLoadButton = New Button()
        NotesSaveButton = New Button()
        Menu.SuspendLayout()
        Tabs.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(D20Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D100Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D12Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D10Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D8Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D6Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D4Count, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(D30Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D24Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D16Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D14Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D7Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D5Count, ComponentModel.ISupportInitialize).BeginInit()
        CType(D3Count, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        ItemGroup.SuspendLayout()
        TabPage5.SuspendLayout()
        NPCEncounterGroup.SuspendLayout()
        NPCNameGenGroup.SuspendLayout()
        Panel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(NotesFontSize, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Menu
        ' 
        Menu.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, HelpToolStripMenuItem})
        Menu.Location = New Point(0, 0)
        Menu.Name = "Menu"
        Menu.Size = New Size(455, 24)
        Menu.TabIndex = 0
        Menu.Text = "Menu"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(93, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ResetCountersToolStripMenuItem, ClearHistoryToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' ResetCountersToolStripMenuItem
        ' 
        ResetCountersToolStripMenuItem.Name = "ResetCountersToolStripMenuItem"
        ResetCountersToolStripMenuItem.Size = New Size(153, 22)
        ResetCountersToolStripMenuItem.Text = "Reset Counters"
        ' 
        ' ClearHistoryToolStripMenuItem
        ' 
        ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem"
        ClearHistoryToolStripMenuItem.Size = New Size(153, 22)
        ClearHistoryToolStripMenuItem.Text = "Clear History"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IndexToolStripMenuItem, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(107, 22)
        IndexToolStripMenuItem.Text = "Index"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Tabs
        ' 
        Tabs.Controls.Add(TabPage1)
        Tabs.Controls.Add(TabPage2)
        Tabs.Controls.Add(TabPage3)
        Tabs.Controls.Add(TabPage5)
        Tabs.Controls.Add(TabPage4)
        Tabs.Location = New Point(3, 3)
        Tabs.Name = "Tabs"
        Tabs.SelectedIndex = 0
        Tabs.Size = New Size(421, 276)
        Tabs.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(D20Count)
        TabPage1.Controls.Add(D20Button)
        TabPage1.Controls.Add(D100Count)
        TabPage1.Controls.Add(D12Count)
        TabPage1.Controls.Add(D10Count)
        TabPage1.Controls.Add(D100Button)
        TabPage1.Controls.Add(D12Button)
        TabPage1.Controls.Add(D10Button)
        TabPage1.Controls.Add(D8Count)
        TabPage1.Controls.Add(D6Count)
        TabPage1.Controls.Add(D8Button)
        TabPage1.Controls.Add(D6Button)
        TabPage1.Controls.Add(D4Count)
        TabPage1.Controls.Add(D4Button)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(413, 248)
        TabPage1.TabIndex = 0
        TabPage1.Text = "5E D20"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' D20Count
        ' 
        D20Count.Location = New Point(6, 190)
        D20Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D20Count.Name = "D20Count"
        D20Count.Size = New Size(47, 23)
        D20Count.TabIndex = 13
        D20Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D20Button
        ' 
        D20Button.Location = New Point(59, 174)
        D20Button.Name = "D20Button"
        D20Button.Size = New Size(348, 50)
        D20Button.TabIndex = 12
        D20Button.Text = "D20"
        D20Button.UseVisualStyleBackColor = True
        ' 
        ' D100Count
        ' 
        D100Count.Location = New Point(229, 134)
        D100Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D100Count.Name = "D100Count"
        D100Count.Size = New Size(47, 23)
        D100Count.TabIndex = 11
        D100Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D12Count
        ' 
        D12Count.Location = New Point(229, 78)
        D12Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D12Count.Name = "D12Count"
        D12Count.Size = New Size(47, 23)
        D12Count.TabIndex = 10
        D12Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D10Count
        ' 
        D10Count.Location = New Point(229, 22)
        D10Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D10Count.Name = "D10Count"
        D10Count.Size = New Size(47, 23)
        D10Count.TabIndex = 9
        D10Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D100Button
        ' 
        D100Button.Location = New Point(282, 118)
        D100Button.Name = "D100Button"
        D100Button.Size = New Size(125, 50)
        D100Button.TabIndex = 8
        D100Button.Text = "D100"
        D100Button.UseVisualStyleBackColor = True
        ' 
        ' D12Button
        ' 
        D12Button.Location = New Point(282, 62)
        D12Button.Name = "D12Button"
        D12Button.Size = New Size(125, 50)
        D12Button.TabIndex = 7
        D12Button.Text = "D12"
        D12Button.UseVisualStyleBackColor = True
        ' 
        ' D10Button
        ' 
        D10Button.Location = New Point(282, 6)
        D10Button.Name = "D10Button"
        D10Button.Size = New Size(125, 50)
        D10Button.TabIndex = 6
        D10Button.Text = "D10"
        D10Button.UseVisualStyleBackColor = True
        ' 
        ' D8Count
        ' 
        D8Count.Location = New Point(6, 134)
        D8Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D8Count.Name = "D8Count"
        D8Count.Size = New Size(47, 23)
        D8Count.TabIndex = 5
        D8Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D6Count
        ' 
        D6Count.Location = New Point(6, 78)
        D6Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D6Count.Name = "D6Count"
        D6Count.Size = New Size(47, 23)
        D6Count.TabIndex = 4
        D6Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D8Button
        ' 
        D8Button.Location = New Point(59, 118)
        D8Button.Name = "D8Button"
        D8Button.Size = New Size(125, 50)
        D8Button.TabIndex = 3
        D8Button.Text = "D8"
        D8Button.UseVisualStyleBackColor = True
        ' 
        ' D6Button
        ' 
        D6Button.Location = New Point(59, 62)
        D6Button.Name = "D6Button"
        D6Button.Size = New Size(125, 50)
        D6Button.TabIndex = 2
        D6Button.Text = "D6"
        D6Button.UseVisualStyleBackColor = True
        ' 
        ' D4Count
        ' 
        D4Count.Location = New Point(6, 21)
        D4Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D4Count.Name = "D4Count"
        D4Count.Size = New Size(47, 23)
        D4Count.TabIndex = 1
        D4Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D4Button
        ' 
        D4Button.Location = New Point(59, 6)
        D4Button.Name = "D4Button"
        D4Button.Size = New Size(125, 50)
        D4Button.TabIndex = 0
        D4Button.Text = "D4"
        D4Button.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(D30Count)
        TabPage2.Controls.Add(D24Count)
        TabPage2.Controls.Add(D16Count)
        TabPage2.Controls.Add(D14Count)
        TabPage2.Controls.Add(D7Count)
        TabPage2.Controls.Add(D5Count)
        TabPage2.Controls.Add(D30Button)
        TabPage2.Controls.Add(D24Button)
        TabPage2.Controls.Add(D16Button)
        TabPage2.Controls.Add(D14Button)
        TabPage2.Controls.Add(D7Button)
        TabPage2.Controls.Add(D5Button)
        TabPage2.Controls.Add(D3Count)
        TabPage2.Controls.Add(D3Button)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(413, 248)
        TabPage2.TabIndex = 1
        TabPage2.Text = "DCC D30"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' D30Count
        ' 
        D30Count.Location = New Point(6, 190)
        D30Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D30Count.Name = "D30Count"
        D30Count.Size = New Size(47, 23)
        D30Count.TabIndex = 14
        D30Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D24Count
        ' 
        D24Count.Location = New Point(229, 134)
        D24Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D24Count.Name = "D24Count"
        D24Count.Size = New Size(47, 23)
        D24Count.TabIndex = 13
        D24Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D16Count
        ' 
        D16Count.Location = New Point(229, 78)
        D16Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D16Count.Name = "D16Count"
        D16Count.Size = New Size(47, 23)
        D16Count.TabIndex = 12
        D16Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D14Count
        ' 
        D14Count.Location = New Point(229, 22)
        D14Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D14Count.Name = "D14Count"
        D14Count.Size = New Size(47, 23)
        D14Count.TabIndex = 11
        D14Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D7Count
        ' 
        D7Count.Location = New Point(6, 134)
        D7Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D7Count.Name = "D7Count"
        D7Count.Size = New Size(47, 23)
        D7Count.TabIndex = 10
        D7Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D5Count
        ' 
        D5Count.Location = New Point(6, 78)
        D5Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D5Count.Name = "D5Count"
        D5Count.Size = New Size(47, 23)
        D5Count.TabIndex = 9
        D5Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D30Button
        ' 
        D30Button.Location = New Point(59, 174)
        D30Button.Name = "D30Button"
        D30Button.Size = New Size(348, 50)
        D30Button.TabIndex = 8
        D30Button.Text = "D30"
        D30Button.UseVisualStyleBackColor = True
        ' 
        ' D24Button
        ' 
        D24Button.Location = New Point(282, 118)
        D24Button.Name = "D24Button"
        D24Button.Size = New Size(125, 50)
        D24Button.TabIndex = 7
        D24Button.Text = "D24"
        D24Button.UseVisualStyleBackColor = True
        ' 
        ' D16Button
        ' 
        D16Button.Location = New Point(282, 62)
        D16Button.Name = "D16Button"
        D16Button.Size = New Size(125, 50)
        D16Button.TabIndex = 6
        D16Button.Text = "D16"
        D16Button.UseVisualStyleBackColor = True
        ' 
        ' D14Button
        ' 
        D14Button.Location = New Point(282, 6)
        D14Button.Name = "D14Button"
        D14Button.Size = New Size(125, 50)
        D14Button.TabIndex = 5
        D14Button.Text = "D14"
        D14Button.UseVisualStyleBackColor = True
        ' 
        ' D7Button
        ' 
        D7Button.Location = New Point(59, 118)
        D7Button.Name = "D7Button"
        D7Button.Size = New Size(125, 50)
        D7Button.TabIndex = 4
        D7Button.Text = "D7"
        D7Button.UseVisualStyleBackColor = True
        ' 
        ' D5Button
        ' 
        D5Button.Location = New Point(59, 62)
        D5Button.Name = "D5Button"
        D5Button.Size = New Size(125, 50)
        D5Button.TabIndex = 3
        D5Button.Text = "D5"
        D5Button.UseVisualStyleBackColor = True
        ' 
        ' D3Count
        ' 
        D3Count.Location = New Point(6, 22)
        D3Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        D3Count.Name = "D3Count"
        D3Count.Size = New Size(47, 23)
        D3Count.TabIndex = 2
        D3Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' D3Button
        ' 
        D3Button.Location = New Point(59, 6)
        D3Button.Name = "D3Button"
        D3Button.Size = New Size(125, 50)
        D3Button.TabIndex = 1
        D3Button.Text = "D3"
        D3Button.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(ItemGroup)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(413, 248)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Treasure"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' ItemGroup
        ' 
        ItemGroup.Controls.Add(IndividualIncludeItemsCheck)
        ItemGroup.Controls.Add(GPOnlyCheck)
        ItemGroup.Controls.Add(MagicGenerate)
        ItemGroup.Controls.Add(MagicCRLabel)
        ItemGroup.Controls.Add(MagicCRSelect)
        ItemGroup.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ItemGroup.Location = New Point(3, 3)
        ItemGroup.Name = "ItemGroup"
        ItemGroup.Size = New Size(179, 124)
        ItemGroup.TabIndex = 0
        ItemGroup.TabStop = False
        ItemGroup.Text = "Individual Treasure"
        ' 
        ' IndividualIncludeItemsCheck
        ' 
        IndividualIncludeItemsCheck.AutoSize = True
        IndividualIncludeItemsCheck.Checked = True
        IndividualIncludeItemsCheck.CheckState = CheckState.Checked
        IndividualIncludeItemsCheck.Location = New Point(6, 37)
        IndividualIncludeItemsCheck.Name = "IndividualIncludeItemsCheck"
        IndividualIncludeItemsCheck.Size = New Size(97, 19)
        IndividualIncludeItemsCheck.TabIndex = 4
        IndividualIncludeItemsCheck.Text = "Include Items"
        IndividualIncludeItemsCheck.UseVisualStyleBackColor = True
        ' 
        ' GPOnlyCheck
        ' 
        GPOnlyCheck.AutoSize = True
        GPOnlyCheck.Location = New Point(6, 62)
        GPOnlyCheck.Name = "GPOnlyCheck"
        GPOnlyCheck.Size = New Size(69, 19)
        GPOnlyCheck.TabIndex = 3
        GPOnlyCheck.Text = "GP Only"
        GPOnlyCheck.UseVisualStyleBackColor = True
        ' 
        ' MagicGenerate
        ' 
        MagicGenerate.Location = New Point(87, 88)
        MagicGenerate.Name = "MagicGenerate"
        MagicGenerate.Size = New Size(86, 30)
        MagicGenerate.TabIndex = 2
        MagicGenerate.Text = "Generate"
        MagicGenerate.UseVisualStyleBackColor = True
        ' 
        ' MagicCRLabel
        ' 
        MagicCRLabel.AutoSize = True
        MagicCRLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MagicCRLabel.Location = New Point(6, 19)
        MagicCRLabel.Name = "MagicCRLabel"
        MagicCRLabel.Size = New Size(103, 15)
        MagicCRLabel.TabIndex = 1
        MagicCRLabel.Text = "Challenge Rating:"
        ' 
        ' MagicCRSelect
        ' 
        MagicCRSelect.FormattingEnabled = True
        MagicCRSelect.Items.AddRange(New Object() {"CR 0", "CR 1", "CR 2", "CR 3", "CR 4", "CR 5", "CR 6", "CR 7", "CR 8", "CR 9", "CR 10", "CR 11", "CR 12", "CR 13", "CR 15", "CR 16", "CR 17", "CR 18", "CR 19", "CR 20+"})
        MagicCRSelect.Location = New Point(115, 16)
        MagicCRSelect.Name = "MagicCRSelect"
        MagicCRSelect.Size = New Size(58, 23)
        MagicCRSelect.TabIndex = 0
        MagicCRSelect.Text = "CR 0"
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(NPCEncounterGroup)
        TabPage5.Controls.Add(NPCNameGenGroup)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(413, 248)
        TabPage5.TabIndex = 4
        TabPage5.Text = "NPC"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' NPCEncounterGroup
        ' 
        NPCEncounterGroup.Controls.Add(EncounterEnvLabel)
        NPCEncounterGroup.Controls.Add(EncounterEnvControl)
        NPCEncounterGroup.Controls.Add(EncounterGenButton)
        NPCEncounterGroup.Controls.Add(EncounterDiffControl)
        NPCEncounterGroup.Controls.Add(EncounterDiffLabel)
        NPCEncounterGroup.Controls.Add(EncounterLevelControl)
        NPCEncounterGroup.Controls.Add(EncounterPCLevelLabel)
        NPCEncounterGroup.Controls.Add(EncounterPCNumControl)
        NPCEncounterGroup.Controls.Add(EncounterPCNumLabel)
        NPCEncounterGroup.Location = New Point(3, 127)
        NPCEncounterGroup.Name = "NPCEncounterGroup"
        NPCEncounterGroup.Size = New Size(407, 118)
        NPCEncounterGroup.TabIndex = 2
        NPCEncounterGroup.TabStop = False
        NPCEncounterGroup.Text = "Encounter Generator"
        ' 
        ' EncounterEnvLabel
        ' 
        EncounterEnvLabel.AutoSize = True
        EncounterEnvLabel.Location = New Point(191, 48)
        EncounterEnvLabel.Name = "EncounterEnvLabel"
        EncounterEnvLabel.Size = New Size(81, 15)
        EncounterEnvLabel.TabIndex = 13
        EncounterEnvLabel.Text = "Environment: "
        ' 
        ' EncounterEnvControl
        ' 
        EncounterEnvControl.DropDownStyle = ComboBoxStyle.DropDownList
        EncounterEnvControl.FormattingEnabled = True
        EncounterEnvControl.Items.AddRange(New Object() {"Any", "Arctic", "Coastal", "Desert", "Forest", "Grassland", "Hill", "Jungle", "Mountain", "Swamp", "Underdark", "Underwater", "Urban", "fff"})
        EncounterEnvControl.Location = New Point(278, 45)
        EncounterEnvControl.Name = "EncounterEnvControl"
        EncounterEnvControl.Size = New Size(121, 23)
        EncounterEnvControl.TabIndex = 12
        ' 
        ' EncounterGenButton
        ' 
        EncounterGenButton.Location = New Point(314, 82)
        EncounterGenButton.Name = "EncounterGenButton"
        EncounterGenButton.Size = New Size(85, 30)
        EncounterGenButton.TabIndex = 11
        EncounterGenButton.Text = "Generate"
        EncounterGenButton.UseVisualStyleBackColor = True
        ' 
        ' EncounterDiffControl
        ' 
        EncounterDiffControl.DropDownStyle = ComboBoxStyle.DropDownList
        EncounterDiffControl.FormattingEnabled = True
        EncounterDiffControl.Items.AddRange(New Object() {"Any", "Easy", "Medium", "Hard", "Deadly"})
        EncounterDiffControl.Location = New Point(100, 45)
        EncounterDiffControl.Name = "EncounterDiffControl"
        EncounterDiffControl.Size = New Size(85, 23)
        EncounterDiffControl.TabIndex = 5
        ' 
        ' EncounterDiffLabel
        ' 
        EncounterDiffLabel.AutoSize = True
        EncounterDiffLabel.Location = New Point(33, 48)
        EncounterDiffLabel.Name = "EncounterDiffLabel"
        EncounterDiffLabel.Size = New Size(61, 15)
        EncounterDiffLabel.TabIndex = 4
        EncounterDiffLabel.Text = "Difficulty: "
        ' 
        ' EncounterLevelControl
        ' 
        EncounterLevelControl.DropDownStyle = ComboBoxStyle.DropDownList
        EncounterLevelControl.FormattingEnabled = True
        EncounterLevelControl.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        EncounterLevelControl.Location = New Point(225, 16)
        EncounterLevelControl.Name = "EncounterLevelControl"
        EncounterLevelControl.Size = New Size(39, 23)
        EncounterLevelControl.TabIndex = 3
        ' 
        ' EncounterPCLevelLabel
        ' 
        EncounterPCLevelLabel.AutoSize = True
        EncounterPCLevelLabel.Location = New Point(179, 19)
        EncounterPCLevelLabel.Name = "EncounterPCLevelLabel"
        EncounterPCLevelLabel.Size = New Size(40, 15)
        EncounterPCLevelLabel.TabIndex = 2
        EncounterPCLevelLabel.Text = "Level: "
        ' 
        ' EncounterPCNumControl
        ' 
        EncounterPCNumControl.DropDownStyle = ComboBoxStyle.DropDownList
        EncounterPCNumControl.FormattingEnabled = True
        EncounterPCNumControl.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"})
        EncounterPCNumControl.Location = New Point(100, 16)
        EncounterPCNumControl.Name = "EncounterPCNumControl"
        EncounterPCNumControl.Size = New Size(73, 23)
        EncounterPCNumControl.TabIndex = 1
        ' 
        ' EncounterPCNumLabel
        ' 
        EncounterPCNumLabel.AutoSize = True
        EncounterPCNumLabel.Location = New Point(6, 19)
        EncounterPCNumLabel.Name = "EncounterPCNumLabel"
        EncounterPCNumLabel.Size = New Size(91, 15)
        EncounterPCNumLabel.TabIndex = 0
        EncounterPCNumLabel.Text = "Number of PCs:"
        ' 
        ' NPCNameGenGroup
        ' 
        NPCNameGenGroup.Controls.Add(NameFemRadio)
        NPCNameGenGroup.Controls.Add(NameMascRadio)
        NPCNameGenGroup.Controls.Add(NameSurCheck)
        NPCNameGenGroup.Controls.Add(NameRaceComboBox)
        NPCNameGenGroup.Controls.Add(NameRaceLabel)
        NPCNameGenGroup.Controls.Add(NameGenerateButton)
        NPCNameGenGroup.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        NPCNameGenGroup.Location = New Point(3, 3)
        NPCNameGenGroup.Name = "NPCNameGenGroup"
        NPCNameGenGroup.Size = New Size(179, 118)
        NPCNameGenGroup.TabIndex = 1
        NPCNameGenGroup.TabStop = False
        NPCNameGenGroup.Text = "Name Generator"
        ' 
        ' NameFemRadio
        ' 
        NameFemRadio.AutoSize = True
        NameFemRadio.Location = New Point(91, 47)
        NameFemRadio.Name = "NameFemRadio"
        NameFemRadio.Size = New Size(74, 19)
        NameFemRadio.TabIndex = 10
        NameFemRadio.Text = "Feminine"
        NameFemRadio.UseVisualStyleBackColor = True
        ' 
        ' NameMascRadio
        ' 
        NameMascRadio.AutoSize = True
        NameMascRadio.Checked = True
        NameMascRadio.Location = New Point(6, 47)
        NameMascRadio.Name = "NameMascRadio"
        NameMascRadio.Size = New Size(79, 19)
        NameMascRadio.TabIndex = 9
        NameMascRadio.TabStop = True
        NameMascRadio.Text = "Masculine"
        NameMascRadio.UseVisualStyleBackColor = True
        ' 
        ' NameSurCheck
        ' 
        NameSurCheck.AutoSize = True
        NameSurCheck.Location = New Point(6, 73)
        NameSurCheck.Name = "NameSurCheck"
        NameSurCheck.Size = New Size(73, 19)
        NameSurCheck.TabIndex = 8
        NameSurCheck.Text = "Surname"
        NameSurCheck.UseVisualStyleBackColor = True
        ' 
        ' NameRaceComboBox
        ' 
        NameRaceComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        NameRaceComboBox.FormattingEnabled = True
        NameRaceComboBox.Items.AddRange(New Object() {"Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf", "Halfling", "Half-Orc", "Human", "Tiefling"})
        NameRaceComboBox.Location = New Point(49, 16)
        NameRaceComboBox.Name = "NameRaceComboBox"
        NameRaceComboBox.Size = New Size(121, 23)
        NameRaceComboBox.TabIndex = 5
        ' 
        ' NameRaceLabel
        ' 
        NameRaceLabel.AutoSize = True
        NameRaceLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        NameRaceLabel.Location = New Point(6, 19)
        NameRaceLabel.Name = "NameRaceLabel"
        NameRaceLabel.Size = New Size(37, 15)
        NameRaceLabel.TabIndex = 4
        NameRaceLabel.Text = "Race:"
        ' 
        ' NameGenerateButton
        ' 
        NameGenerateButton.Location = New Point(87, 82)
        NameGenerateButton.Name = "NameGenerateButton"
        NameGenerateButton.Size = New Size(86, 30)
        NameGenerateButton.TabIndex = 3
        NameGenerateButton.Text = "Generate"
        NameGenerateButton.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(413, 248)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Notes"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Panel
        ' 
        Panel.BorderStyle = BorderStyle.Fixed3D
        Panel.Controls.Add(Tabs)
        Panel.Controls.Add(Panel1)
        Panel.Location = New Point(12, 27)
        Panel.Name = "Panel"
        Panel.Size = New Size(431, 761)
        Panel.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(NotesFontSize)
        Panel1.Controls.Add(NotesFont)
        Panel1.Controls.Add(NotesUnderline)
        Panel1.Controls.Add(NotesItalic)
        Panel1.Controls.Add(NoteBold)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(NotesLoadButton)
        Panel1.Controls.Add(NotesSaveButton)
        Panel1.Location = New Point(-2, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(431, 724)
        Panel1.TabIndex = 3
        ' 
        ' NotesFontSize
        ' 
        NotesFontSize.Location = New Point(368, 9)
        NotesFontSize.Maximum = New Decimal(New Integer() {72, 0, 0, 0})
        NotesFontSize.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        NotesFontSize.Name = "NotesFontSize"
        NotesFontSize.Size = New Size(43, 23)
        NotesFontSize.TabIndex = 11
        NotesFontSize.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' NotesFont
        ' 
        NotesFont.FormattingEnabled = True
        NotesFont.Location = New Point(251, 9)
        NotesFont.Name = "NotesFont"
        NotesFont.Size = New Size(111, 23)
        NotesFont.TabIndex = 10
        ' 
        ' NotesUnderline
        ' 
        NotesUnderline.Font = New Font("Times New Roman", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        NotesUnderline.Location = New Point(215, 7)
        NotesUnderline.Name = "NotesUnderline"
        NotesUnderline.Size = New Size(30, 25)
        NotesUnderline.TabIndex = 9
        NotesUnderline.Text = "U"
        NotesUnderline.UseVisualStyleBackColor = True
        ' 
        ' NotesItalic
        ' 
        NotesItalic.Font = New Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point)
        NotesItalic.Location = New Point(179, 7)
        NotesItalic.Name = "NotesItalic"
        NotesItalic.Size = New Size(30, 25)
        NotesItalic.TabIndex = 8
        NotesItalic.Text = "I"
        NotesItalic.UseVisualStyleBackColor = True
        ' 
        ' NoteBold
        ' 
        NoteBold.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        NoteBold.Location = New Point(143, 7)
        NoteBold.Name = "NoteBold"
        NoteBold.Size = New Size(30, 25)
        NoteBold.TabIndex = 7
        NoteBold.Text = "B"
        NoteBold.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(historybox)
        Panel2.Controls.Add(notesbox)
        Panel2.Location = New Point(3, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(425, 685)
        Panel2.TabIndex = 6
        ' 
        ' historybox
        ' 
        historybox.Font = New Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point)
        historybox.Location = New Point(2, 210)
        historybox.Name = "historybox"
        historybox.ReadOnly = True
        historybox.Size = New Size(421, 475)
        historybox.TabIndex = 2
        historybox.Text = ""
        ' 
        ' notesbox
        ' 
        notesbox.Enabled = False
        notesbox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        notesbox.Location = New Point(2, 3)
        notesbox.Name = "notesbox"
        notesbox.Size = New Size(421, 680)
        notesbox.TabIndex = 3
        notesbox.Text = ""
        notesbox.Visible = False
        ' 
        ' NotesLoadButton
        ' 
        NotesLoadButton.Location = New Point(76, 3)
        NotesLoadButton.Name = "NotesLoadButton"
        NotesLoadButton.Size = New Size(61, 29)
        NotesLoadButton.TabIndex = 5
        NotesLoadButton.Text = "Load"
        NotesLoadButton.UseVisualStyleBackColor = True
        ' 
        ' NotesSaveButton
        ' 
        NotesSaveButton.Location = New Point(9, 3)
        NotesSaveButton.Name = "NotesSaveButton"
        NotesSaveButton.Size = New Size(61, 29)
        NotesSaveButton.TabIndex = 4
        NotesSaveButton.Text = "Save"
        NotesSaveButton.UseVisualStyleBackColor = True
        ' 
        ' Start
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 800)
        Controls.Add(Panel)
        Controls.Add(Menu)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = Menu
        MaximizeBox = False
        Name = "Start"
        Text = "Rod's Bag O' Dice | V2-Alpha 2"
        Menu.ResumeLayout(False)
        Menu.PerformLayout()
        Tabs.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(D20Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D100Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D12Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D10Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D8Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D6Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D4Count, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(D30Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D24Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D16Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D14Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D7Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D5Count, ComponentModel.ISupportInitialize).EndInit()
        CType(D3Count, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        ItemGroup.ResumeLayout(False)
        ItemGroup.PerformLayout()
        TabPage5.ResumeLayout(False)
        NPCEncounterGroup.ResumeLayout(False)
        NPCEncounterGroup.PerformLayout()
        NPCNameGenGroup.ResumeLayout(False)
        NPCNameGenGroup.PerformLayout()
        Panel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(NotesFontSize, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel As Panel
    Friend WithEvents D4Count As NumericUpDown
    Friend WithEvents D4Button As Button
    Friend WithEvents D20Count As NumericUpDown
    Friend WithEvents D20Button As Button
    Friend WithEvents D100Count As NumericUpDown
    Friend WithEvents D12Count As NumericUpDown
    Friend WithEvents D10Count As NumericUpDown
    Friend WithEvents D100Button As Button
    Friend WithEvents D12Button As Button
    Friend WithEvents D10Button As Button
    Friend WithEvents D8Count As NumericUpDown
    Friend WithEvents D6Count As NumericUpDown
    Friend WithEvents D8Button As Button
    Friend WithEvents D6Button As Button
    Friend WithEvents historybox As RichTextBox
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents D30Count As NumericUpDown
    Friend WithEvents D24Count As NumericUpDown
    Friend WithEvents D16Count As NumericUpDown
    Friend WithEvents D14Count As NumericUpDown
    Friend WithEvents D7Count As NumericUpDown
    Friend WithEvents D5Count As NumericUpDown
    Friend WithEvents D30Button As Button
    Friend WithEvents D24Button As Button
    Friend WithEvents D16Button As Button
    Friend WithEvents D14Button As Button
    Friend WithEvents D7Button As Button
    Friend WithEvents D5Button As Button
    Friend WithEvents D3Count As NumericUpDown
    Friend WithEvents D3Button As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ResetCountersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemGroup As GroupBox
    Friend WithEvents MagicCRLabel As Label
    Friend WithEvents MagicCRSelect As ComboBox
    Friend WithEvents MagicGenerate As Button
    Friend WithEvents GPOnlyCheck As CheckBox
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualIncludeItemsCheck As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NotesSaveButton As Button
    Friend WithEvents NotesLoadButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents notesbox As RichTextBox
    Friend WithEvents NotesItalic As Button
    Friend WithEvents NoteBold As Button
    Friend WithEvents NotesUnderline As Button
    Friend WithEvents NotesFont As ComboBox
    Friend WithEvents NotesFontSize As NumericUpDown
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents NPCNameGenGroup As GroupBox
    Friend WithEvents NameGenerateButton As Button
    Friend WithEvents NameSurCheck As CheckBox
    Friend WithEvents NameRaceComboBox As ComboBox
    Friend WithEvents NameRaceLabel As Label
    Friend WithEvents NameFemRadio As RadioButton
    Friend WithEvents NameMascRadio As RadioButton
    Friend WithEvents NPCEncounterGroup As GroupBox
    Friend WithEvents EncounterPCNumControl As ComboBox
    Friend WithEvents EncounterPCNumLabel As Label
    Friend WithEvents EncounterDiffControl As ComboBox
    Friend WithEvents EncounterDiffLabel As Label
    Friend WithEvents EncounterLevelControl As ComboBox
    Friend WithEvents EncounterPCLevelLabel As Label
    Friend WithEvents EncounterGenButton As Button
    Friend WithEvents EncounterEnvLabel As Label
    Friend WithEvents EncounterEnvControl As ComboBox

End Class
