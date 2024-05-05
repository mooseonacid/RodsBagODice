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
        ClearHistoryToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
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
        Panel = New Panel()
        historybox = New RichTextBox()
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
        Panel.SuspendLayout()
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
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClearHistoryToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' ClearHistoryToolStripMenuItem
        ' 
        ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem"
        ClearHistoryToolStripMenuItem.Size = New Size(142, 22)
        ClearHistoryToolStripMenuItem.Text = "Clear History"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
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
        Tabs.Location = New Point(3, 3)
        Tabs.Name = "Tabs"
        Tabs.SelectedIndex = 0
        Tabs.Size = New Size(421, 274)
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
        TabPage1.Size = New Size(413, 246)
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
        TabPage2.Size = New Size(413, 246)
        TabPage2.TabIndex = 1
        TabPage2.Text = "DCC"
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
        ' Panel
        ' 
        Panel.BorderStyle = BorderStyle.Fixed3D
        Panel.Controls.Add(historybox)
        Panel.Controls.Add(Tabs)
        Panel.Location = New Point(12, 27)
        Panel.Name = "Panel"
        Panel.Size = New Size(431, 722)
        Panel.TabIndex = 2
        ' 
        ' historybox
        ' 
        historybox.Font = New Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point)
        historybox.Location = New Point(3, 283)
        historybox.Name = "historybox"
        historybox.ReadOnly = True
        historybox.Size = New Size(421, 432)
        historybox.TabIndex = 2
        historybox.Text = ""
        ' 
        ' Start
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 761)
        Controls.Add(Panel)
        Controls.Add(Menu)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = Menu
        MaximizeBox = False
        Name = "Start"
        Text = "Rod's Bag O' Dice | V2-Alpha 1"
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
        Panel.ResumeLayout(False)
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

End Class
