<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatureStatBlock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreatureStatBlock))
        StatSep1 = New PictureBox()
        StatArmorClassLabel = New Label()
        StatSpeedLabel = New Label()
        StatHPLabel = New Label()
        StatACVar = New Label()
        StatHPVar = New Label()
        StatSpeedVar = New Label()
        StatSep2 = New PictureBox()
        StatSTRLabel = New Label()
        StatDEXLabel = New Label()
        StatCONLabel = New Label()
        StatINTLabel = New Label()
        StatWISLabel = New Label()
        StatCHALabel = New Label()
        StatSTRVar = New Label()
        StatDEXVar = New Label()
        StatCONVar = New Label()
        StatINTVar = New Label()
        StatWISVar = New Label()
        StatCHAVar = New Label()
        StatSensesLabel = New Label()
        StatLangLabel = New Label()
        StatCRLabel = New Label()
        StatSep3 = New PictureBox()
        StatSensesVar = New Label()
        StatLangVar = New Label()
        StatCRVar = New Label()
        StatAbilLabel = New Label()
        StatPanel = New Panel()
        StatNameLabel = New TextBox()
        StatAbilVar = New TextBox()
        StatSubNameLabel = New Label()
        CType(StatSep1, ComponentModel.ISupportInitialize).BeginInit()
        CType(StatSep2, ComponentModel.ISupportInitialize).BeginInit()
        CType(StatSep3, ComponentModel.ISupportInitialize).BeginInit()
        StatPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatSep1
        ' 
        StatSep1.Image = My.Resources.Resources.line1
        StatSep1.Location = New Point(-2, 61)
        StatSep1.Name = "StatSep1"
        StatSep1.Size = New Size(681, 5)
        StatSep1.TabIndex = 1
        StatSep1.TabStop = False
        ' 
        ' StatArmorClassLabel
        ' 
        StatArmorClassLabel.AutoSize = True
        StatArmorClassLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatArmorClassLabel.Location = New Point(396, 8)
        StatArmorClassLabel.Name = "StatArmorClassLabel"
        StatArmorClassLabel.Size = New Size(105, 23)
        StatArmorClassLabel.TabIndex = 3
        StatArmorClassLabel.Text = "Armor Class"
        ' 
        ' StatSpeedLabel
        ' 
        StatSpeedLabel.AutoSize = True
        StatSpeedLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatSpeedLabel.Location = New Point(396, 31)
        StatSpeedLabel.Name = "StatSpeedLabel"
        StatSpeedLabel.Size = New Size(56, 23)
        StatSpeedLabel.TabIndex = 4
        StatSpeedLabel.Text = "Speed"
        ' 
        ' StatHPLabel
        ' 
        StatHPLabel.AutoSize = True
        StatHPLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatHPLabel.Location = New Point(532, 9)
        StatHPLabel.Name = "StatHPLabel"
        StatHPLabel.Size = New Size(86, 23)
        StatHPLabel.TabIndex = 5
        StatHPLabel.Text = "Hit Points"
        ' 
        ' StatACVar
        ' 
        StatACVar.AutoSize = True
        StatACVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatACVar.Location = New Point(497, 10)
        StatACVar.Name = "StatACVar"
        StatACVar.Size = New Size(29, 21)
        StatACVar.TabIndex = 6
        StatACVar.Text = "{0}"
        ' 
        ' StatHPVar
        ' 
        StatHPVar.AutoSize = True
        StatHPVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatHPVar.Location = New Point(614, 10)
        StatHPVar.Name = "StatHPVar"
        StatHPVar.Size = New Size(29, 21)
        StatHPVar.TabIndex = 7
        StatHPVar.Text = "{0}"
        ' 
        ' StatSpeedVar
        ' 
        StatSpeedVar.AutoSize = True
        StatSpeedVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatSpeedVar.Location = New Point(447, 33)
        StatSpeedVar.Name = "StatSpeedVar"
        StatSpeedVar.Size = New Size(29, 21)
        StatSpeedVar.TabIndex = 8
        StatSpeedVar.Text = "{0}"
        ' 
        ' StatSep2
        ' 
        StatSep2.Image = My.Resources.Resources.line1
        StatSep2.Location = New Point(-1, 144)
        StatSep2.Name = "StatSep2"
        StatSep2.Size = New Size(681, 5)
        StatSep2.TabIndex = 9
        StatSep2.TabStop = False
        ' 
        ' StatSTRLabel
        ' 
        StatSTRLabel.AutoSize = True
        StatSTRLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatSTRLabel.Location = New Point(48, 83)
        StatSTRLabel.Name = "StatSTRLabel"
        StatSTRLabel.Size = New Size(59, 23)
        StatSTRLabel.TabIndex = 10
        StatSTRLabel.Text = "STR    "
        ' 
        ' StatDEXLabel
        ' 
        StatDEXLabel.AutoSize = True
        StatDEXLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatDEXLabel.Location = New Point(152, 83)
        StatDEXLabel.Name = "StatDEXLabel"
        StatDEXLabel.Size = New Size(62, 23)
        StatDEXLabel.TabIndex = 11
        StatDEXLabel.Text = "DEX    "
        ' 
        ' StatCONLabel
        ' 
        StatCONLabel.AutoSize = True
        StatCONLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatCONLabel.Location = New Point(249, 83)
        StatCONLabel.Name = "StatCONLabel"
        StatCONLabel.Size = New Size(66, 23)
        StatCONLabel.TabIndex = 12
        StatCONLabel.Text = "CON    "
        ' 
        ' StatINTLabel
        ' 
        StatINTLabel.AutoSize = True
        StatINTLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatINTLabel.Location = New Point(359, 83)
        StatINTLabel.Name = "StatINTLabel"
        StatINTLabel.Size = New Size(57, 23)
        StatINTLabel.TabIndex = 13
        StatINTLabel.Text = "INT    "
        ' 
        ' StatWISLabel
        ' 
        StatWISLabel.AutoSize = True
        StatWISLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatWISLabel.Location = New Point(455, 83)
        StatWISLabel.Name = "StatWISLabel"
        StatWISLabel.Size = New Size(60, 23)
        StatWISLabel.TabIndex = 14
        StatWISLabel.Text = "WIS    "
        ' 
        ' StatCHALabel
        ' 
        StatCHALabel.AutoSize = True
        StatCHALabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatCHALabel.Location = New Point(563, 83)
        StatCHALabel.Name = "StatCHALabel"
        StatCHALabel.Size = New Size(64, 23)
        StatCHALabel.TabIndex = 15
        StatCHALabel.Text = "CHA    "
        ' 
        ' StatSTRVar
        ' 
        StatSTRVar.AutoSize = True
        StatSTRVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatSTRVar.Location = New Point(57, 106)
        StatSTRVar.Name = "StatSTRVar"
        StatSTRVar.Size = New Size(29, 21)
        StatSTRVar.TabIndex = 16
        StatSTRVar.Text = "{0}"
        ' 
        ' StatDEXVar
        ' 
        StatDEXVar.AutoSize = True
        StatDEXVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatDEXVar.Location = New Point(162, 106)
        StatDEXVar.Name = "StatDEXVar"
        StatDEXVar.Size = New Size(29, 21)
        StatDEXVar.TabIndex = 17
        StatDEXVar.Text = "{0}"
        ' 
        ' StatCONVar
        ' 
        StatCONVar.AutoSize = True
        StatCONVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatCONVar.Location = New Point(260, 106)
        StatCONVar.Name = "StatCONVar"
        StatCONVar.Size = New Size(29, 21)
        StatCONVar.TabIndex = 18
        StatCONVar.Text = "{0}"
        ' 
        ' StatINTVar
        ' 
        StatINTVar.AutoSize = True
        StatINTVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatINTVar.Location = New Point(364, 106)
        StatINTVar.Name = "StatINTVar"
        StatINTVar.Size = New Size(29, 21)
        StatINTVar.TabIndex = 19
        StatINTVar.Text = "{0}"
        ' 
        ' StatWISVar
        ' 
        StatWISVar.AutoSize = True
        StatWISVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatWISVar.Location = New Point(465, 106)
        StatWISVar.Name = "StatWISVar"
        StatWISVar.Size = New Size(29, 21)
        StatWISVar.TabIndex = 20
        StatWISVar.Text = "{0}"
        ' 
        ' StatCHAVar
        ' 
        StatCHAVar.AutoSize = True
        StatCHAVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatCHAVar.Location = New Point(573, 106)
        StatCHAVar.Name = "StatCHAVar"
        StatCHAVar.Size = New Size(29, 21)
        StatCHAVar.TabIndex = 21
        StatCHAVar.Text = "{0}"
        ' 
        ' StatSensesLabel
        ' 
        StatSensesLabel.AutoSize = True
        StatSensesLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatSensesLabel.Location = New Point(15, 151)
        StatSensesLabel.Name = "StatSensesLabel"
        StatSensesLabel.Size = New Size(61, 23)
        StatSensesLabel.TabIndex = 22
        StatSensesLabel.Text = "Senses"
        ' 
        ' StatLangLabel
        ' 
        StatLangLabel.AutoSize = True
        StatLangLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatLangLabel.Location = New Point(15, 173)
        StatLangLabel.Name = "StatLangLabel"
        StatLangLabel.Size = New Size(90, 23)
        StatLangLabel.TabIndex = 23
        StatLangLabel.Text = "Languages"
        ' 
        ' StatCRLabel
        ' 
        StatCRLabel.AutoSize = True
        StatCRLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatCRLabel.Location = New Point(532, 150)
        StatCRLabel.Name = "StatCRLabel"
        StatCRLabel.Size = New Size(84, 23)
        StatCRLabel.TabIndex = 24
        StatCRLabel.Text = "Challenge"
        ' 
        ' StatSep3
        ' 
        StatSep3.Image = My.Resources.Resources.line1
        StatSep3.Location = New Point(-1, 201)
        StatSep3.Name = "StatSep3"
        StatSep3.Size = New Size(681, 5)
        StatSep3.TabIndex = 25
        StatSep3.TabStop = False
        ' 
        ' StatSensesVar
        ' 
        StatSensesVar.AutoSize = True
        StatSensesVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatSensesVar.Location = New Point(82, 152)
        StatSensesVar.Name = "StatSensesVar"
        StatSensesVar.Size = New Size(29, 21)
        StatSensesVar.TabIndex = 26
        StatSensesVar.Text = "{0}"
        ' 
        ' StatLangVar
        ' 
        StatLangVar.AutoSize = True
        StatLangVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatLangVar.Location = New Point(113, 174)
        StatLangVar.Name = "StatLangVar"
        StatLangVar.Size = New Size(29, 21)
        StatLangVar.TabIndex = 27
        StatLangVar.Text = "{0}"
        ' 
        ' StatCRVar
        ' 
        StatCRVar.AutoSize = True
        StatCRVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatCRVar.Location = New Point(532, 174)
        StatCRVar.Name = "StatCRVar"
        StatCRVar.Size = New Size(29, 21)
        StatCRVar.TabIndex = 28
        StatCRVar.Text = "{0}"
        ' 
        ' StatAbilLabel
        ' 
        StatAbilLabel.AutoSize = True
        StatAbilLabel.Font = New Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StatAbilLabel.Location = New Point(17, 209)
        StatAbilLabel.Name = "StatAbilLabel"
        StatAbilLabel.Size = New Size(71, 23)
        StatAbilLabel.TabIndex = 29
        StatAbilLabel.Text = "Abilities"
        ' 
        ' StatPanel
        ' 
        StatPanel.BorderStyle = BorderStyle.Fixed3D
        StatPanel.Controls.Add(StatNameLabel)
        StatPanel.Controls.Add(StatAbilVar)
        StatPanel.Controls.Add(StatSubNameLabel)
        StatPanel.Controls.Add(StatAbilLabel)
        StatPanel.Controls.Add(StatSep1)
        StatPanel.Controls.Add(StatSep3)
        StatPanel.Controls.Add(StatCRVar)
        StatPanel.Controls.Add(StatSpeedLabel)
        StatPanel.Controls.Add(StatLangVar)
        StatPanel.Controls.Add(StatSensesVar)
        StatPanel.Controls.Add(StatArmorClassLabel)
        StatPanel.Controls.Add(StatHPLabel)
        StatPanel.Controls.Add(StatCRLabel)
        StatPanel.Controls.Add(StatACVar)
        StatPanel.Controls.Add(StatLangLabel)
        StatPanel.Controls.Add(StatHPVar)
        StatPanel.Controls.Add(StatSensesLabel)
        StatPanel.Controls.Add(StatSpeedVar)
        StatPanel.Controls.Add(StatSep2)
        StatPanel.Controls.Add(StatSTRVar)
        StatPanel.Controls.Add(StatDEXVar)
        StatPanel.Controls.Add(StatCONVar)
        StatPanel.Controls.Add(StatINTVar)
        StatPanel.Controls.Add(StatWISVar)
        StatPanel.Controls.Add(StatCHAVar)
        StatPanel.Controls.Add(StatSTRLabel)
        StatPanel.Controls.Add(StatDEXLabel)
        StatPanel.Controls.Add(StatCONLabel)
        StatPanel.Controls.Add(StatINTLabel)
        StatPanel.Controls.Add(StatWISLabel)
        StatPanel.Controls.Add(StatCHALabel)
        StatPanel.Location = New Point(1, -1)
        StatPanel.Name = "StatPanel"
        StatPanel.Size = New Size(682, 288)
        StatPanel.TabIndex = 31
        ' 
        ' StatNameLabel
        ' 
        StatNameLabel.BackColor = SystemColors.Info
        StatNameLabel.BorderStyle = BorderStyle.None
        StatNameLabel.Font = New Font("Calisto MT", 18F, FontStyle.Bold, GraphicsUnit.Point)
        StatNameLabel.Location = New Point(15, 5)
        StatNameLabel.Name = "StatNameLabel"
        StatNameLabel.ReadOnly = True
        StatNameLabel.Size = New Size(375, 29)
        StatNameLabel.TabIndex = 31
        StatNameLabel.Text = "{Creature}"
        ' 
        ' StatAbilVar
        ' 
        StatAbilVar.BackColor = SystemColors.Info
        StatAbilVar.BorderStyle = BorderStyle.None
        StatAbilVar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        StatAbilVar.Location = New Point(9, 235)
        StatAbilVar.Multiline = True
        StatAbilVar.Name = "StatAbilVar"
        StatAbilVar.ReadOnly = True
        StatAbilVar.Size = New Size(660, 46)
        StatAbilVar.TabIndex = 30
        StatAbilVar.Text = "{0}"
        ' 
        ' StatSubNameLabel
        ' 
        StatSubNameLabel.AutoSize = True
        StatSubNameLabel.Font = New Font("Leelawadee UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point)
        StatSubNameLabel.Location = New Point(9, 36)
        StatSubNameLabel.Name = "StatSubNameLabel"
        StatSubNameLabel.Size = New Size(169, 15)
        StatSubNameLabel.TabIndex = 5
        StatSubNameLabel.Text = "{Size Type, Alignment | Source}"
        ' 
        ' CreatureStatBlock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(684, 289)
        Controls.Add(StatPanel)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "CreatureStatBlock"
        Text = "CreatureStatBlock"
        CType(StatSep1, ComponentModel.ISupportInitialize).EndInit()
        CType(StatSep2, ComponentModel.ISupportInitialize).EndInit()
        CType(StatSep3, ComponentModel.ISupportInitialize).EndInit()
        StatPanel.ResumeLayout(False)
        StatPanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents StatSep1 As PictureBox
    Friend WithEvents StatArmorClassLabel As Label
    Friend WithEvents StatSpeedLabel As Label
    Friend WithEvents StatHPLabel As Label
    Friend WithEvents StatACVar As Label
    Friend WithEvents StatHPVar As Label
    Friend WithEvents StatSpeedVar As Label
    Friend WithEvents StatSep2 As PictureBox
    Friend WithEvents StatSTRLabel As Label
    Friend WithEvents StatDEXLabel As Label
    Friend WithEvents StatCONLabel As Label
    Friend WithEvents StatINTLabel As Label
    Friend WithEvents StatWISLabel As Label
    Friend WithEvents StatCHALabel As Label
    Friend WithEvents StatSTRVar As Label
    Friend WithEvents StatDEXVar As Label
    Friend WithEvents StatCONVar As Label
    Friend WithEvents StatINTVar As Label
    Friend WithEvents StatWISVar As Label
    Friend WithEvents StatCHAVar As Label
    Friend WithEvents StatSensesLabel As Label
    Friend WithEvents StatLangLabel As Label
    Friend WithEvents StatCRLabel As Label
    Friend WithEvents StatSep3 As PictureBox
    Friend WithEvents StatSensesVar As Label
    Friend WithEvents StatLangVar As Label
    Friend WithEvents StatCRVar As Label
    Friend WithEvents StatAbilLabel As Label
    Friend WithEvents StatPanel As Panel
    Friend WithEvents StatSubNameLabel As Label
    Friend WithEvents StatAbilVar As TextBox
    Friend WithEvents StatNameLabel As TextBox
End Class
