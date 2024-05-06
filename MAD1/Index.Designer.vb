<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Index
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        IndexPanel = New Panel()
        TabControl1 = New TabControl()
        IndexTabPage1 = New TabPage()
        MagicItemsDataGrid = New DataGridView()
        MagicItemDatabaseBindingSource = New BindingSource(components)
        MagicSearchLabel = New Label()
        MagicSearchBox = New TextBox()
        IndexPanel.SuspendLayout()
        TabControl1.SuspendLayout()
        IndexTabPage1.SuspendLayout()
        CType(MagicItemsDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(MagicItemDatabaseBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IndexPanel
        ' 
        IndexPanel.BorderStyle = BorderStyle.Fixed3D
        IndexPanel.Controls.Add(TabControl1)
        IndexPanel.Location = New Point(2, 2)
        IndexPanel.Name = "IndexPanel"
        IndexPanel.Size = New Size(880, 608)
        IndexPanel.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(IndexTabPage1)
        TabControl1.Location = New Point(3, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(870, 598)
        TabControl1.TabIndex = 0
        ' 
        ' IndexTabPage1
        ' 
        IndexTabPage1.Controls.Add(MagicSearchBox)
        IndexTabPage1.Controls.Add(MagicSearchLabel)
        IndexTabPage1.Controls.Add(MagicItemsDataGrid)
        IndexTabPage1.Location = New Point(4, 24)
        IndexTabPage1.Name = "IndexTabPage1"
        IndexTabPage1.Padding = New Padding(3)
        IndexTabPage1.Size = New Size(862, 570)
        IndexTabPage1.TabIndex = 0
        IndexTabPage1.Text = "Magic Items"
        IndexTabPage1.UseVisualStyleBackColor = True
        ' 
        ' MagicItemsDataGrid
        ' 
        MagicItemsDataGrid.AllowUserToAddRows = False
        MagicItemsDataGrid.AllowUserToDeleteRows = False
        MagicItemsDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        MagicItemsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MagicItemsDataGrid.Location = New Point(6, 38)
        MagicItemsDataGrid.Name = "MagicItemsDataGrid"
        MagicItemsDataGrid.ReadOnly = True
        MagicItemsDataGrid.RowTemplate.Height = 25
        MagicItemsDataGrid.Size = New Size(850, 526)
        MagicItemsDataGrid.TabIndex = 0
        ' 
        ' MagicItemDatabaseBindingSource
        ' 
        MagicItemDatabaseBindingSource.DataSource = GetType(MagicItemDatabase)
        ' 
        ' MagicSearchLabel
        ' 
        MagicSearchLabel.AutoSize = True
        MagicSearchLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        MagicSearchLabel.Location = New Point(6, 15)
        MagicSearchLabel.Name = "MagicSearchLabel"
        MagicSearchLabel.Size = New Size(54, 17)
        MagicSearchLabel.TabIndex = 1
        MagicSearchLabel.Text = "Search: "
        ' 
        ' MagicSearchBox
        ' 
        MagicSearchBox.Location = New Point(57, 9)
        MagicSearchBox.Name = "MagicSearchBox"
        MagicSearchBox.Size = New Size(298, 23)
        MagicSearchBox.TabIndex = 2
        ' 
        ' Index
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 611)
        Controls.Add(IndexPanel)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Index"
        Text = "Index"
        IndexPanel.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        IndexTabPage1.ResumeLayout(False)
        IndexTabPage1.PerformLayout()
        CType(MagicItemsDataGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(MagicItemDatabaseBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents IndexPanel As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents IndexTabPage1 As TabPage
    Friend WithEvents MagicItemDatabaseBindingSource As BindingSource
    Friend WithEvents MagicItemsDataGrid As DataGridView
    Friend WithEvents MagicSearchLabel As Label
    Friend WithEvents MagicSearchBox As TextBox
End Class
