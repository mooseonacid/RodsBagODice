Imports System.Drawing.Design
Imports System.Security.Cryptography
Imports System.Text

Public Class Start
    Private Function GetRandomNumber(minValue As Integer, maxValue As Integer) As Integer
        Using rng As RandomNumberGenerator = RandomNumberGenerator.Create()
            Dim data As Byte() = New Byte(3) {}
            rng.GetBytes(data)
            Dim value As Integer = BitConverter.ToInt32(data, 0)
            Return Math.Abs(value Mod (maxValue - minValue + 1)) + minValue
        End Using
    End Function

    'Standard dice
    Private Sub D4Button_Click(sender As Object, e As EventArgs) Handles D4Button.Click
        Dim numRolls As Integer = D4Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d4 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d4Roll As Integer = GetRandomNumber(1, 4)
            total += d4Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d4Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D6Button_Click(sender As Object, e As EventArgs) Handles D6Button.Click
        Dim numRolls As Integer = D6Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d6 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d6Roll As Integer = GetRandomNumber(1, 6)
            total += d6Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d6Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D8Button_Click(sender As Object, e As EventArgs) Handles D8Button.Click
        Dim numRolls As Integer = D8Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d8 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d8Roll As Integer = GetRandomNumber(1, 8)
            total += d8Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d8Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D10Button_Click(sender As Object, e As EventArgs) Handles D10Button.Click
        Dim numRolls As Integer = D10Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d10 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d10Roll As Integer = GetRandomNumber(1, 10)
            total += d10Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d10Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D12Button_Click(sender As Object, e As EventArgs) Handles D12Button.Click
        Dim numRolls As Integer = D12Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d12 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d12Roll As Integer = GetRandomNumber(1, 12)
            total += d12Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d12Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D100Button_Click(sender As Object, e As EventArgs) Handles D100Button.Click
        Dim numRolls As Integer = D100Count.Value
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d100 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d100Roll As Integer = GetRandomNumber(1, 100)
            historybox.AppendText("Roll " & i.ToString() & ":      " & d100Roll.ToString() & Environment.NewLine)
        Next
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D20Button_Click(sender As Object, e As EventArgs) Handles D20Button.Click
        Dim numRolls As Integer = D20Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d20 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d20Roll As Integer = GetRandomNumber(1, 20)
            total += d20Roll
            historybox.AppendText("Roll " & i.ToString() & ":      ")
            If d20Roll = 1 Then
                historybox.SelectionStart = historybox.TextLength
                historybox.SelectionLength = 0
                historybox.SelectionColor = Color.Red
                historybox.AppendText(d20Roll.ToString() & " - Critical Failure!" & Environment.NewLine)
            ElseIf d20Roll = 20 Then
                historybox.SelectionStart = historybox.TextLength
                historybox.SelectionLength = 0
                historybox.SelectionColor = Color.Green
                historybox.AppendText(d20Roll.ToString() & " - Critical Success!" & Environment.NewLine)
            Else
                historybox.AppendText(d20Roll.ToString() & Environment.NewLine)
            End If
            historybox.SelectionColor = historybox.ForeColor
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    'Menu bar stuff
    Private Sub ResetCountersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetCountersToolStripMenuItem.Click
        D3Count.Value = 1
        D4Count.Value = 1
        D5Count.Value = 1
        D6Count.Value = 1
        D7Count.Value = 1
        D8Count.Value = 1
        D10Count.Value = 1
        D12Count.Value = 1
        D14Count.Value = 1
        D16Count.Value = 1
        D20Count.Value = 1
        D24Count.Value = 1
        D30Count.Value = 1
        D100Count.Value = 1
    End Sub

    Private Sub ClearHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearHistoryToolStripMenuItem.Click
        historybox.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutForm As New About()
        aboutForm.ShowDialog()
    End Sub

    Private Sub IndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexToolStripMenuItem.Click
        Dim indexForm As New Index()
        indexForm.ShowDialog()
    End Sub

    'DCC Dice
    Private Sub D3Button_Click(sender As Object, e As EventArgs) Handles D3Button.Click
        Dim numRolls As Integer = D3Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d3 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d3Roll As Integer = GetRandomNumber(1, 3)
            total += d3Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d3Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D5Button_Click(sender As Object, e As EventArgs) Handles D5Button.Click
        Dim numRolls As Integer = D5Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d5 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d5Roll As Integer = GetRandomNumber(1, 5)
            total += d5Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d5Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D7Button_Click(sender As Object, e As EventArgs) Handles D7Button.Click
        Dim numRolls As Integer = D7Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d7 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d7Roll As Integer = GetRandomNumber(1, 7)
            total += d7Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d7Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D14Button_Click(sender As Object, e As EventArgs) Handles D14Button.Click
        Dim numRolls As Integer = D14Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d14 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d14Roll As Integer = GetRandomNumber(1, 14)
            total += d14Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d14Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D16Button_Click(sender As Object, e As EventArgs) Handles D16Button.Click
        Dim numRolls As Integer = D16Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d16 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d16Roll As Integer = GetRandomNumber(1, 16)
            total += d16Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d16Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D24Button_Click(sender As Object, e As EventArgs) Handles D24Button.Click
        Dim numRolls As Integer = D24Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d24 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d24Roll As Integer = GetRandomNumber(1, 24)
            total += d24Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d24Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    Private Sub D30Button_Click(sender As Object, e As EventArgs) Handles D30Button.Click
        Dim numRolls As Integer = D30Count.Value
        Dim total As Integer = 0
        historybox.AppendText("===== ROLL " & numRolls.ToString() & "d30 =====" & Environment.NewLine)
        For i As Integer = 1 To numRolls
            Dim d30Roll As Integer = GetRandomNumber(1, 30)
            total += d30Roll
            historybox.AppendText("Roll " & i.ToString() & ":      " & d30Roll.ToString() & Environment.NewLine)
        Next
        If numRolls > 1 Then
            historybox.AppendText("_________________________" & Environment.NewLine)
            historybox.AppendText("Total:      " & total.ToString() & Environment.NewLine)
        End If
        historybox.AppendText(Environment.NewLine)
        historybox.ScrollToCaret()
    End Sub

    'Loot stuff
    Private Sub MagicGenerate_Click(sender As Object, e As EventArgs) Handles MagicGenerate.Click
        Dim challengeRating As Integer = MagicCRSelect.SelectedIndex + 1

        'Gen treasure
        Dim treasure As List(Of (Item As Item, Currency As Currency, JunkItem As List(Of Item))) = GenerateTreasure(challengeRating)

        'Display
        historybox.AppendText("===== TREASURE =====" & Environment.NewLine)
        For i As Integer = 0 To treasure.Count - 1
            Dim magicItemResult As String = ""
            Dim currencyResult As String = ""
            Dim junkItemResult As New List(Of String)

            If treasure(i).Item IsNot Nothing Then
                Dim item = treasure(i).Item
                magicItemResult = (item.Name)
            End If
            If treasure(i).Currency IsNot Nothing Then
                Dim currency = treasure(i).Currency
                currencyResult = (currency.Amount & " " & currency.Type)
            End If
            For Each junkItem In treasure(i).JunkItem
                If junkItem IsNot Nothing Then
                    junkItemResult.Add(junkItem.Name)
                End If
            Next
            historybox.AppendText((i + 1).ToString() & ". ")

            If treasure(i).Item IsNot Nothing Then
                Dim color As Color
                Select Case treasure(i).Item.Rarity
                    Case "Common"
                        color = Color.Black
                    Case "Uncommon"
                        color = Color.Green
                    Case "Rare"
                        color = Color.Blue
                    Case "Very Rare"
                        color = Color.Purple
                    Case "Legendary"
                        color = Color.Orange
                End Select
                historybox.SelectionStart = historybox.TextLength
                historybox.SelectionLength = 0
                historybox.SelectionColor = color
                historybox.AppendText(magicItemResult)
                historybox.SelectionColor = historybox.ForeColor
                historybox.AppendText(", ")
            End If
            historybox.AppendText(currencyResult & ", " & String.Join(", ", junkItemResult) & Environment.NewLine)
            If i < treasure.Count - 1 Then
                historybox.AppendText(Environment.NewLine)
            End If
        Next
        historybox.ScrollToCaret()
    End Sub

    Private Function GenerateTreasure(challengeRating As Integer) As List(Of (Item As Item, Currency As Currency, JunkItem As List(Of Item)))
        Dim rand As New Random()

        Dim treasure As New List(Of (Item As Item, Currency As Currency, JunkItem As List(Of Item)))
        For i As Integer = 1 To 10
            Dim item As Item = Nothing
            Dim currency As Currency = Nothing
            Dim junkItem As New List(Of Item)

            'items
            If IndividualIncludeItemsCheck.Checked Then
                '10% chance for magic item
                If rand.NextDouble() < 0.1 Then
                    item = GetRandomItem(challengeRating)
                End If

                'junk item
                Dim junkIndex As Integer = rand.Next(JunkItemDatabase.Items.Count)
                junkItem.Add(JunkItemDatabase.Items(junkIndex))
                If rand.NextDouble() < 0.5 Then
                    junkIndex = rand.Next(JunkItemDatabase.Items.Count)
                    junkItem.Add(JunkItemDatabase.Items(junkIndex))
                End If
            End If

            'Generate shmoney
            Dim minGp As Integer = challengeRating * 10
            Dim maxGp As Integer = Math.Max(minGp, 10 + Math.Sqrt(challengeRating) * 50)
            Dim gp As Integer = rand.Next(minGp, maxGp)

            Dim minSp As Integer = challengeRating * 100
            Dim maxSp As Integer = Math.Max(minSp, 100 + Math.Sqrt(challengeRating) * 500)
            Dim sp As Integer = rand.Next(minSp, maxSp)

            Dim minCp As Integer = challengeRating * 1000
            Dim maxCp As Integer = Math.Max(minCp, 1000 + Math.Sqrt(challengeRating) * 5000)
            Dim cp As Integer = rand.Next(minCp, maxCp)

            'Convert shmoney
            'sp += cp \ 100
            'cp = cp Mod 100
            'gp += sp \ 100
            'sp = sp Mod 100

            If Not GPOnlyCheck.Checked Then
                Dim currencyType As Integer = rand.Next(3)
                If currencyType = 0 Then
                    currency = New Currency With {.Type = "GP", .Amount = gp}
                ElseIf currencyType = 1 Then
                    currency = New Currency With {.Type = "SP", .Amount = sp}
                Else
                    currency = New Currency With {.Type = "CP", .Amount = cp}
                End If
            Else
                currency = New Currency With {.Type = "GP", .Amount = gp}
            End If
            treasure.Add((item, currency, junkItem))
        Next

        Return treasure
    End Function

    'Rarity weight test
    Private Function GetRandomItem(challengeRating As Integer) As Item
        Dim rand As New Random()

        Dim items As New List(Of (Item As Item, Rarity As Integer))
        For Each item In MagicItemDatabase.Items
            Dim rarity As Integer
            Select Case item.Rarity
                Case "Common"
                    rarity = 1
                Case "Uncommon"
                    rarity = 2
                Case "Rare"
                    rarity = 3
                Case "Very Rare"
                    rarity = 4
                Case "Legendary"
                    rarity = 5
                Case Else
                    rarity = 1
            End Select
            'CR ceiling for item rarity
            If (rarity <= Math.Ceiling(challengeRating / 4.0)) Then
                items.Add((item, rarity))
            End If
        Next

        'calc weight
        Dim totalWeight As Integer = items.Sum(Function(x) x.Rarity * challengeRating)

        'random value between 0 and total weight
        Dim randomValue As Integer = rand.Next(totalWeight)

        'Find item based on random value
        For Each item In items
            If randomValue < item.Rarity * challengeRating Then
                Return item.Item
            End If
            randomValue -= item.Rarity * challengeRating
        Next

        'If nothing is found (should not happen)
        Return Nothing
    End Function
End Class

Public Class Item
    Public Property Name As String
    Public Property Type As String
    Public Property Rarity As String
    Public Property Attunement As String
    Public Property Notes As String
    Public Property Source As String

    Public Sub New(name As String, type As String, rarity As String, attunement As String, notes As String, source As String)
        Me.Name = name
        Me.Type = type
        Me.Rarity = rarity
        Me.Attunement = attunement
        Me.Notes = notes
        Me.Source = source
    End Sub
End Class

Public Class Currency
    Public Property Type As String
    Public Property Amount As Integer
End Class

Public Module MagicItemDatabase
    Public ReadOnly Items As New List(Of Item) From {
        New Item("Armor of Gleaming", "Armor", "Common", "", "Medium or Heavy | This armor never gets dirty.", "xge 136"), 'MAGIC ITEMS START
        New Item("Cast-Off Armor", "Armor", "Common", "", "Light, Medium or Heavy | Cast-off armor was armor that was magically enchanted to become exceedingly quick for its wearer to doff. Cast-off armor could be completely removed within only a few seconds, regardless of type.", "xge 136"),
        New Item("Shield of Expression", "Armor", "Common", "", "Shield | The front of this shield is shaped in the likeness of a face. While bearing the shield, you can use a bonus action to alter the face's expression.", "xge 139"),
        New Item("Smoldering Armor", "Armor", "Common", "", "Wisps of harmless, odorless smoke rise from this armor while it is worn.", "xge 139"),
        New Item("Adamantine Armor", "Armor", "Uncommon", "", "Medium or Heavy, but not hide. | This suit of armor is reinforced with adamantine, one of the hardest substances in existence. While you're wearing it, any critical hit against you becomes a normal hit.", "dmg 150"),
        New Item("Mariner's Armor", "Armor", "Uncommon", "", "Light, Medium or Heavy | While wearing this armor, you have a swimming speed equal to your walking speed. In addition, whenever you start your turn underwater with 0 hit points, the armor causes you to rise 60 feet toward the surface. The armor is decorated with fish and shell motifs.", "dmg 181"),
        New Item("Mithral Armor", "Armor", "Uncommon", "", "Medium or Heavy, but not hide | Mithral is a light, flexible metal. A mithral chain shirt or breastplate can be worn under normal clothes. If the armor normally imposes disadvantage on Dexterity (Stealth) checks or has a Strength requirement, the mithral version of the armor doesn't.", "dmg 182"),
        New Item("Sentinel Shield", "Armor", "Uncommon", "", "Shield | While holding this shield, you have advantage on initiative rolls and Wisdom (Perception) checks. The shield is emblazoned with the symbol of an eye.", "dmg 199"),
        New Item("Shield, +1", "Armor", "Uncommon", "", "Shield | While holding this shield, you have a bonus to AC determined by the shield's rarity. This bonus is in addition to the shield's normal bonus to AC.", "dmg 200"),
        New Item("Arrow-catching Shield", "Armor", "Rare", "Requires Attunement", "Shield | You gain a +2 bonus to AC against ranged attacks while you wield this shield. This bonus is in addition to the shield's normal bonus to AC. In addition, whenever an attacker makes a ranged attack against a target within 5 feet of you, you can use your reaction to become the target of the attack instead.", "dmg 152"),
        New Item("Elven Chain", "Armor", "Rare", "", "Chain shirt", "dmg 168"),
        New Item("Glamoured Studded Leather", "Armor", "Rare", "", "Studded leather | While wearing this armor, you gain a +1 bonus to AC. You can also use a bonus action to speak the armor's command word and cause the armor to assume the appearance of a normal set of clothing or some other kind of armor. You decide what it looks like, including color, style, and accessories, but the armor retains its normal bulk and weight. The illusory appearance lasts until you use this property again or remove the armor.", "dmg 172"),
        New Item("Shield of Missile Attraction", "Armor", "Rare", "Requires Attunement", "Shield | While holding this shield, you have resistance to damage from ranged weapon attacks. - This shield is cursed. Attuning to it curses you until you are targeted by the remove curse spell or similar magic. Removing the shield fails to end the curse on you. Whenever a ranged weapon attack is made against a target within 10 feet of you, the curse causes you to become the target instead.", "dmg 200"),
        New Item("Shield, +2", "Armor", "Rare", "", "Shield | While holding this shield, you have a bonus to AC determined by the shield's rarity. This bonus is in addition to the shield's normal bonus to AC.", "dmg 200"),
        New Item("Animated Shield", "Armor", "Very Rare", "Requires Attunement", "Shield | While holding this shield, you can speak its command word as a bonus action to cause it to animate. The shield leaps into the air and hovers in your space to protect you as if you were wielding it, leaving your hands free. The shield remains animated for 1 minute, until you use a bonus action to end this effect, or until you are incapacitated or die, at which point the shield falls to the ground or into your hand if you have one free.", "dmg 151"),
        New Item("Armor, +2", "Armor", "Very Rare", "", "You have a bonus to AC while wearing this armor. The bonus is determined by its rarity.", "dmg 152"),
        New Item("Demon Armor", "Armor", "Very Rare", "Requires Attunement", "Plate | While wearing this armor, you gain a +1 bonus to AC, and you can understand and speak Abyssal. In addition, the armor's clawed gauntlets turn unarmed strikes with your hands into magic weapons that deal slashing damage, with a +1 bonus to attack rolls and damage rolls and a damage die of 1d8. - Once you don this cursed armor, you can't doff it unless you are targeted by the remove curse spell or similar magic. While wearing the armor, you have disadvantage on attack rolls against demons and on saving throws against their spells and special abilities.", "dmg 165"),
        New Item("Dwarven Plate", "Armor", "Very Rare", "", "Plate | While wearing this armor, you gain a +2 bonus to AC. In addition, if an effect moves you against your will along the ground, you can use your reaction to reduce the distance you are moved by up to 10 feet.", "dmg 167"),
        New Item("Shield, +3", "Armor", "Very Rare", "", "Shield | While holding this shield, you have a bonus to AC determined by the shield's rarity. This bonus is in addition to the shield's normal bonus to AC.", "dmg 200"),
        New Item("Spellguard Shield", "Armor", "Very Rare", "Requires Attunement", "Shield | While holding this shield, you have advantage on saving throws against spells and other magical effects, and spell attacks have disadvantage against you.", "dmg 201"),
        New Item("Armor of Invulnerability", "Armor", "Legendary", "Requires Attunement", "Plate | You have resistance to nonmagical damage while you wear this armor. Additionally, you can use an action to make yourself immune to nonmagical damage for 10 minutes or until you are no longer wearing the armor. Once this special action is used, it can't be used again until the next dawn.", "dmg 152"),
        New Item("Armor, +3", "Armor", "Legendary", "", "You have a bonus to AC while wearing this armor. The bonus is determined by its rarity.", "dmg 152"),
        New Item("Efreeti Chain", "Armor", "Legendary", "Requires Attunement", "Chain mail | While wearing this armor, you gain a +3 bonus to AC, you are immune to fire damage, and you can understand and speak Primordial. In addition, you can stand on and walk across molten rock as if it were solid ground.", "dmg 167"),
        New Item("Plate Armor of Etherealness", "Armor", "Legendary", "Requires Attunement", "Plate | While you're wearing this armor, you can speak its command word as an action to gain the effect of the etherealness spell, which last for 10 minutes or until you remove the armor or use an action to speak the command word again. This property of the armor can't be used again until the next dawn.", "dmg 185"),
        New Item("Potion of Climbing", "Potion", "Common", "", "When you drink this potion, you gain a climbing speed equal to your walking speed for 1 hour. During this time, you have advantage on Strength (Athletics) checks you make to climb. The potion is separated into brown, silver, and gray layers resembling bands of stone. Shaking the bottle fails to mix the colors.", "dmg 187"),
        New Item("Potion of Healing", "Potion", "Common", "", "You regain 2d4 + 2 hit points when you drink this potion. Whatever its potency, the potion's red liquid glimmers when agitated.", "dmg 187"),
        New Item("Potion of Greater Healing", "Potion", "Uncommon", "", "You regain 4d4 + 4 hit points when you drink this potion. Whatever its potency, the potion's red liquid glimmers when agitated.", "dmg 187"),
        New Item("Potion of Superior Healing", "Potion", "Rare", "", "You regain 8d4 + 8 hit points when you drink this potion. Whatever its potency, the potion's red liquid glimmers when agitated.", "dmg 187"),
        New Item("Potion of Supreme Healing", "Potion", "Very Rare", "", "You regain 10d4 + 20 hit points when you drink this potion. Whatever its potency, the potion's red liquid glimmers when agitated.", "dmg 187"),
        New Item("Oil of Slipperiness", "Potion", "Uncommon", "", "This sticky black unguent is thick and heavy in the container, but it flows quickly when poured. The oil can cover a Medium or smaller creature, along with the equipment it's wearing and carrying (one additional vial is required for each size category above Medium). Applying the oil takes 10 minutes. The affected creature then gains the effect of a freedom of movement spell for 8 hours. Alternatively, the oil can be poured on the ground as an action, where it covers a 10-foot square, duplicating the effect of the grease spell in that area for 8 hours.", "dmg 184"),
        New Item("Philter of Love", "Potion", "Uncommon", "", "The next time you see a creature within 10 minutes after drinking this philter, you become charmed by that creature for 1 hour. If the creature is of a species and gender you are normally attracted to, you regard it as your true love while you are charmed. This potion's rose-hued, effervescent liquid contains one easy-to-miss bubble shaped like a heart.", "dmg 184"),
        New Item("Potion of Animal Friendship", "Potion", "Uncommon", "", "When you drink this potion, you can cast the animal friendship spell (save DC 13) for 1 hour at will. Agitating this muddy liquid brings little bits into view: a fish scale, a hummingbird tongue, a cat claw, or a squirrel hair.", "dmg 187"),
        New Item("Potion of Fire Breath", "Potion", "Uncommon", "", "After drinking this potion, you can use a bonus action to exhale fire at a target within 30 feet of you. The target must make a DC 13 Dexterity saving throw, taking 4d6 fire damage on a failed save, or half as much damage on a successful one. The effect ends after you exhale the fire three times or when 1 hour has passed. This potion's orange liquid flickers, and smoke fills the top of the container and wafts out whenever it is opened.", "dmg 187"),
        New Item("Potion of Growth", "Potion", "Uncommon", "", "When you drink this potion, you gain the 'enlarge' effect of the enlarge/reduce spell for 1d4 hours (no concentration required). The red in the potion's liquid continuously expands from a tiny bead to color the clear liquid around it and then contracts. Shaking the bottle fails to interrupt this process.", "dmg 187"),
        New Item("Potion of Poision", "Potion", "Uncommon", "", "This concoction looks, smells, and tastes like a Potion of Healing or other beneficial potion. However, it is actually poison masked by illusion magic. An identify spell reveals its true nature. If you drink it, you take 3d6 poison damage, and you must succeed on a DC 13 Constitution saving throw or be poisoned. At the start of each of your turns while you are poisoned in this way, you take 3d6 poison damage. At the end of each of your turns, you can repeat the saving throw. On a successful save, the poison damage you take on your subsequent turns decreases by 1d6. The poison ends when the damage decreases to 0.", "dmg 188"),
        New Item("Potion of Water Breathing", "Potion", "Uncommon", "", "You can breathe underwater for 1 hour after drinking this potion. Its cloudy green fluid smells of the sea and has a jellyfish-like bubble floating in it.", "dmg 188"),
        New Item("Elixir of Health", "Potion", "Rare", "", "When you drink this potion, it cures any disease afflicting you, and it removes the blinded, deafened, paralyzed, and poisoned conditions. The clear golden liquid has tiny bubbles of light in it.", "dmg 168"),
        New Item("Oil of Etherealness", "Potion", "Rare", "", "Beads of this cloudy gray oil form on the outside of its container and quickly evaporate. The oil can cover a Medium or smaller creature, along with the equipment it's wearing and carrying (one additional vial is required for each size category above Medium). Applying the oil takes 10 minutes. The affected creature then gains the effect of the etherealness spell for 1 hour.", "dmg 183"),
        New Item("Potion of Clairvoyance", "Potion", "Rare", "", "When you drink this potion, you gain the effect of the clairvoyance spell. An eyeball bobs in this yellowish liquid but vanishes when the potion is opened.", "dmg 187"),
        New Item("Potion of Diminution", "Potion", "Rare", "", "When you drink this potion, you gain the 'reduce' effect of the enlarge/reduce spell for 1d4 hours (no concentration required). The red in the potion's liquid continuously contracts to a tiny bead and then expands to color the clear liquid around it. Shaking the bottle fails to interrupt this process.", "dmg 187"),
        New Item("Potion of Gaseous Form", "Potion", "Rare", "", "When you drink this potion, you gain the effect of the gaseous form spell for 1 hour (no concentration required) or until you end the effect as a bonus action. This potion's container seems to hold fog that moves and pours like water.", "dmg 187"),
        New Item("Potion of Heroism", "Potion", "Rare", "", "For 1 hour after drinking it, you gain 10 temporary hit points that last for 1 hour. For the same duration, you are under the effect of the Bless spell (no concentration required). This blue potion bubbles and steams as if boiling.", "dmg 188"),
        New Item("Potion of Invulnerability", "Potion", "Rare", "", "For 1 minute after you drink this potion, you have resistance to all damage. The potion's syrupy liquid looks like liquified iron.", "dmg 188"),
        New Item("Potion of Mind Reading", "Potion", "Rare", "", "When you drink this potion, you gain the effect of the detect thoughts spell (save DC 13). The potion's dense, purple liquid has an ovoid cloud of pink floating in it.", "dmg 188"),
        New Item("Oil of Sharpness", "Potion", "Very Rare", "", "This clear, gelatinous oil sparkles with tiny, ultrathin silver shards. The oil can coat one slashing or piercing weapon or up to 5 pieces of slashing or piercing ammunition. Applying the oil takes 1 minute. For 1 hour, the coated item is magical and has a +3 bonus to attack and damage rolls.", "dmg 184"),
        New Item("Potion of Flying", "Potion", "Very Rare", "", "When you drink this potion, you gain a flying speed equal to your walking speed for 1 hour and can hover. If you're in the air when the potion wears off, you fall unless you have some other means of staying aloft. This potion's clear liquid floats at the top of its container and has cloudy white impurities drifting in it.", "dmg 187"),
        New Item("Potion of Invisibility", "Potion", "Very Rare", "", "This potion's container looks empty but feels as though it holds liquid. When you drink it, you become invisible for 1 hour. Anything you wear or carry is invisible with you. The effect ends early if you attack or cast a spell.", "dmg 188"),
        New Item("Potion of Longevity", "Potion", "Very Rare", "", "When you drink this potion, your physical age is reduced by 1d6 + 6 years, to a minimum of 13 years. Each time you subsequently drink a potion of longevity, there is a 10 percent cumulative chance that you instead age by 1d6 + 6 years. Suspended in this amber liquid are a scorpion's tail, an adder's fang, a dead spider, and a tiny heart that, against all reason, is still beating. The ingredients vanish when the potion is opened.", "dmg 188"),
        New Item("Potion of Speed", "Potion", "Very Rare", "", "When you drink this potion, you gain the effect of the haste spell for 1 minute (no concentration required). The potion's yellow fluid is streaked with black and swirls on its own.", "dmg 188"),
        New Item("Potion of Vitality", "Potion", "Very Rare", "", "When you drink this potion, it removes any exhaustion you are suffering and cures any disease or poison affecting you. For the next 24 hours, you regain the maximum number of hit points for any Hit Die you spend. The potion's crimson liquid regularly pulses with dull light, calling to mind a heartbeat.", "dmg 188"),
        New Item("Ring of Jumping", "Ring", "Uncommon", "Requires Attunement", "While wearing this ring, you can cast the jump spell from it as a bonus action at will, but can target only yourself when you do so.", "dmg 191"),
        New Item("Ring of Mind Shielding", "Ring", "Uncommon", "Requires Attunement", "While wearing this ring, you are immune to magic that allows other creatures to read your thoughts, determine whether you are lying, know your alignment, or know your creature type. Creatures can telepathically communicate with you only if you allow it. You can use an action to cause the ring to become invisible until you use another action to make it visible, until you remove the ring, or until you die. If you die while wearing the ring, your soul enters it, unless it already houses a soul. You can remain in the ring or depart for the afterlife. As long as your soul is in the ring, you can telepathically communicate with any creature wearing it. A wearer can't prevent this telepathic communication.", "dmg 191"),
        New Item("Ring of Swimming", "Ring", "Uncommon", "", "You have a swimming speed of 40 feet while wearing this ring.", "dmg 193"),
        New Item("Ring of Warmth", "Ring", "Uncommon", "Requires Attunement", "While wearing this ring, you have resistance to cold damage. In addition, you and everything you wear and carry are unharmed by temperatures as low as -50 degrees Fahrenheit.", "dmg 193"),
        New Item("Ring of Water Walking", "Ring", "Uncommon", "", "While wearing this ring, you can stand on and move across any liquid surface as if it were solid ground.", "dmg 193"),
        New Item("Ring of Evasion", "Ring", "Rare", "Requires Attunement", "This ring has 3 charges, and it regains 1d3 expended charges daily at dawn. When you fail a Dexterity saving throw while wearing it, you can use your reaction to expend 1 of its charges to succeed on that saving throw instead.", "dmg 191"),
        New Item("Ring of Feather Falling", "Ring", "Rare", "Requires Attunement", "When you fall while wearing this ring, you descend 60 feet per round and take no damage from falling.", "dmg 191"),
        New Item("Ring of Free Action", "Ring", "Rare", "Requires Attunement", "While you wear this ring, difficult terrain doesn't cost you extra movement. In addition, magic can neither reduce your speed nor cause you to be paralyzed or restrained.", "dmg 191"),
        New Item("Ring of Protection", "Ring", "Rare", "Requires Attunement", "You gain a +1 bonus to AC and saving throws while wearing this ring.", "dmg 191"),
        New Item("Ring of Spell Storing", "Ring", "Rare", "Requires Attunement", "This ring stores spells cast into it, holding them until the attuned wearer uses them. The ring can store up to 5 levels worth of spells at a time. When found, it contains 1d6 - 1 levels of stored spells chosen by the GM. Any creature can cast a spell of 1st through 5th level into the ring by touching the ring as the spell is cast. The spell has no effect, other than to be stored in the ring. If the ring can't hold the spell, the spell is expended without effect. The level of the slot used to cast the spell determines how much space it uses. While wearing this ring, you can cast any spell stored in it. The spell uses the slot level, spell save DC, spell attack bonus, and spellcasting ability of the original caster, but is otherwise treated as if you cast the spell. The spell cast from the ring is no longer stored in it, freeing up space.", "dmg 192"),
        New Item("Ring of X-ray Vision", "Ring", "Rare", "Requires Attunement", "While wearing this ring, you can use an action to speak its command word. When you do so, you can see into and through solid matter for 1 minute. This vision has a radius of 30 feet. To you, solid objects within that radius appear transparent and don't prevent light from passing through them. The vision can penetrate 1 foot of stone, 1 inch of common metal, or up to 3 feet of wood or dirt. Thicker substances block the vision, as does a thin sheet of lead. Whenever you use the ring again before taking a long rest, you must succeed on a DC 15 Constitution saving throw or gain one level of exhaustion.", "dmg 193"),
        New Item("Ring of the Ram", "Ring", "Rare", "Requires Attunement", "This ring has 3 charges, and it regains 1d3 expended charges daily at dawn. While wearing the ring, you can use an action to expend 1 to 3 of its charges to attack one creature you can see within 60 feet of you. The ring produces a spectral ram's head and makes its attack roll with a +7 bonus. On a hit, for each charge you spend, the target takes 2d10 force damage and is pushed 5 feet away from you. Alternatively, you can expend 1 to 3 of the ring's charges as an action to try to break an object you can see within 60 feet of you that isn't being worn or carried. The ring makes a Strength check with a +5 bonus for each charge you spend.", "dmg 193"),
        New Item("Ring of Regeneration", "Ring", "Very Rare", "Requires Attunement", "While wearing this ring, you regain 1d6 hit points every 10 minutes, provided that you have at least 1 hit point. If you lose a body part, the ring causes the missing part to regrow and return to full functionality after 1d6 + 1 days if you have at least 1 hit point the whole time.", "dmg 191"),
        New Item("Ring of Telekinesis", "Ring", "Very Rare", "Requires Attunement", "While wearing this ring, you can cast the telekinesis spell at will, but you can target only objects that aren't being worn or carried.", "dmg 193"),
        New Item("Ring of Djinni Summoning", "Ring", "Legendary", "Requires Attunement", "While wearing this ring, you can speak its command word as an action to summon a particular djinni from the Elemental Plane of Air. The djinni appears in an unoccupied space you choose within 120 feet of you. It remains as long as you concentrate (as if concentrating on a spell), to a maximum of 1 hour, or until it drops to 0 hit points. It then returns to its home plane. While summoned, the djinni is friendly to you and your companions. It obeys any commands you give it, no matter what language you use. If you fail to command it, the djinni defends itself against attackers but takes no other actions. After the djinni departs, it can't be summoned again for 24 hours, and the ring becomes nonmagical if the djinni dies.", "dmg 190"),
        New Item("Ring of Invisibility", "Ring", "Legendary", "Requires Attunement", "While wearing this ring, you can turn invisible as an action. Anything you are wearing or carrying is invisible with you. You remain invisible until the ring is removed, until you attack or cast a spell, or until you use a bonus action to become visible again.", "dmg 191"),
        New Item("Ring of Spell Turning", "Ring", "Legendary", "Requires Attunement", "While wearing this ring, you have advantage on saving throws against any spell that targets only you (not in an area of effect). In addition, if you roll a 20 for the save and the spell is 7th level or lower, the spell has no effect on you and instead targets the caster, using the slot level, spell save DC, attack bonus, and spellcasting ability of the caster.", "dmg 193"),
        New Item("Ring of Three Wishes", "Ring", "Legendary", "", "While wearing this ring, you can use an action to expend 1 of its 3 charges to cast the wish spell from it. The ring becomes nonmagical when you use the last charge.", "dmg 193"),
        New Item("Immovable Rod", "Rod", "Uncommon", "", "This flat iron rod has a button on one end. You can use an action to press the button, which causes the rod to become magically fixed in place. Until you or another creature uses an action to push the button again, the rod doesn't move, even if it is defying gravity. The rod can hold up to 8,000 pounds of weight. More weight causes the rod to deactivate and fall. A creature can use an action to make a DC 30 Strength check, moving the fixed rod up to 10 feet on a success.", "dmg 175"),
        New Item("Rod of the Pact Keeper, +1", "Rod", "Uncommon", "Requires Attunement | Warlock Only", "While holding this rod, you gain a bonus to spell attack rolls and to the saving throw DCs of your warlock spells. This bonus is determined by the rod's rarity. In addition, you can regain one warlock spell slot as an action while holding the rod. You can't use this property again until you finish a long rest.", "dmg 197"),
        New Item("Rod of Rulership", "Rod", "Rare", "Requires Attunement", "You can use an action to present the rod and command obedience from each creature of your choice that you can see within 120 feet of you. Each target must succeed on a DC 15 Wisdom saving throw or be charmed by you for 8 hours. While charmed in this way, the creature regards you as its trusted leader. If harmed by you or your companions, or commanded to do something contrary to its nature, a target ceases to be charmed in this way. The rod can't be used again until the next dawn.", "dmg 197"),
        New Item("Rod of Security", "Rod", "Very Rare", "", "While holding this rod, you can use an action to activate it. The rod then instantly transports you and up to 199 other willing creatures you can see to a paradise that exists in an extraplanar space. You choose the form that the paradise takes. It could be a tranquil garden, lovely glade, cheery tavern, immense palace, tropical island, fantastic carnival, or whatever else you can imagine. Regardless of its nature, the paradise contains enough water and food to sustain its visitors. Everything else that can be interacted with inside the extraplanar space can exist only there. For example, a flower picked from a garden in the paradise disappears if it is taken outside the extraplanar space. For each hour spent in the paradise, a visitor regains hit points as if it had spent 1 Hit Die. Also, creatures don't age while in the paradise, although time passes normally. Visitors can remain in the paradise for up to 200 days divided by the number of creatures present (round down). When the time runs out or you use an action to end it, all visitors reappear in the location they occupied when you activated the rod, or an unoccupied space nearest that location. The rod can't be used again until ten days have passed.", "dmg 197"),
        New Item("Rod of Resurrection", "Rod", "Legendary", "Requires Attunement | Cleric, Druid or Paladin", "This rod has 5 charges. While you hold it, you can use an action to cast one of the following spells from it: Heal (expends 1 charge) or Resurrection (expends 5 charges. The rod regains 1 expended charge daily at dawn. If the rod is reduced to 0 charges, roll a d20. On a 1, the rod disappears in a burst of radiance.", "dmg 197"),
        New Item("Scroll of Protection", "Scroll", "Rare", "", "Using an action to read the scroll encloses you in a invisible barrier that extends from you to form a 5-foot-radius, 10-foot-high cylinder. For 5 minutes, this barrier prevents creatures of the specified type from entering or affecting anything within the cylinder. The cylinder moves with you and remains centered on you. However, if you move in such a way that a creature of the specified type would be inside the cylinder, the effect ends. A creature can attempt to overcome the barrier by using an action to make a DC 15 Charisma check. On a success, the creature ceases to be affected by the barrier.", "dmg 199"),
        New Item("Staff of Adornment", "Staff", "Common", "", "If you place an object weighing no more than 1 pound (such as a shard of crystal, an egg, or a stone) above the tip of the staff while holding it, the object floats an inch from the staff's tip and remains there until it is removed or until the staff is no longer in your possession. The staff can have up to three such objects floating over its tip at any given time. While holding the staff, you can make one or more of the objects slowly spin or turn in place.", "xge 139"),
        New Item("Staff of Birdcalls", "Staff", "Common", "", "This wooden staff is decorated with bird carvings. It has 10 charges. While holding it, you can use an action to expend 1 charge from the staff and cause it to create one of the following sounds out to a range of 60 feet: a finch's chirp, a raven's caw, a duck's quack, a chicken's cluck, a goose's honk, a loon's call, a turkey's gobble, a seagull's cry, an owl's hoot, or an eagle's shriek. The staff regains 1d6 + 4 expended charges daily at dawn. If you expend the last charge, roll a d20. On a 1, the staff explodes in a harmless cloud of bird feathers and is lost forever.", "xge 139"),
        New Item("Staff of Flowers", "Staff", "Common", "", "This wooden staff has 10 charges. While holding it, you can use an action to expend 1 charge from the staff and cause a flower to sprout from a patch of earth or soil within 5 feet of you, or from the staff itself. Unless you choose a specific kind of flower, the staff creates a mild-scented daisy. The flower is harmless and nonmagical, and it grows or withers as a normal flower would. The staff regains 1d6 + 4 expended charges daily at dawn. If you expend the last charge, roll a d20. On a 1, the staff turns into flower petals and is lost forever.", "xge 139"),
        New Item("Staff of the Adder", "Staff", "Uncommon", "Requires Attunement | Cleric, Druid or Warlock", "You can use a bonus action to speak this staff's command word and make the head of the staff become that of an animate poisonous snake for 1 minute. By using another bonus action to speak the command word again, you return the staff to its normal inanimate form. You can make a melee attack using the snake head, which has a reach of 5 feet. Your proficiency bonus applies to the attack roll. On a hit, the target takes 1d6 piercing damage and must succeed on a DC 15 Constitution saving throw or take 3d6 poison damage. The snake head can be attacked while it is animate. It has an Armor Class of 15 and 20 hit points. If the head drops to 0 hit points, the staff is destroyed. As long as it's not destroyed, the staff regains all lost hit points when it reverts to its inanimate form.", "dmg 203"),
        New Item("Staff of the Python", "Staff", "Uncommon", "Requires Attunement | Cleric, Druid or Warlock", "You can use an action to speak this staff's command word and throw the staff on the ground within 10 feet of you. The staff becomes a giant constrictor snake under your control and acts on its own initiative count. By using a bonus action to speak the command word again, you return the staff to its normal form in a space formerly occupied by the snake. On your turn, you can mentally command the snake if it is within 60 feet of you and you aren't incapacitated. You decide what action the snake takes and where it moves during its next turn, or you can issue it a general command, such as to attack your enemies or guard a location. If the snake is reduced to 0 hit points, it dies and reverts to its staff form. The staff then shatters and is destroyed. If the snake reverts to staff form before losing all its hit points, it regains all of them.", "dmg 204"),
        New Item("Staff of Charming", "Staff", "Rare", "Requires Attunement | Bard, Cleric, Druid, Sorcerer, Warlock or Wizard", "While holding this staff, you can use an action to expend 1 of its 10 charges to cast charm person, command, or comprehend languages from it using your spell save DC. The staff can also be used as a magic quarterstaff. If you are holding the staff and fail a saving throw against an enchantment spell that targets only you, you can turn your failed save into a successful one. You can't use this property of the staff again until the next dawn. If you succeed on a save against an enchantment spell that targets only you, with or without the staff's intervention, you can use your reaction to expend 1 charge from the staff and turn the spell back on its caster as if you had cast the spell. The staff regains 1d8 + 2 expended charges daily at dawn. If you expend the last charge, roll a d20. On a 1, the staff becomes a nonmagical quarterstaff.", "dmg 201"),
        New Item("Staff of Healing", "Staff", "Rare", "Requires Attunement | Bard, Cleric or Druid", "This staff has 10 charges. While holding it, you can use an action to expend 1 or more of its charges to cast one of the following spells from it, using your spell save DC and spellcasting ability modifier: cure wounds (1 charge per spell level, up to 4th), lesser restoration (2 charges), or mass cure wounds (5 charges). The staff regains 1d6 + 4 expended charges daily at dawn. If you expend the last charge, roll a d20. On a 1, the staff vanishes in a flash of light, lost forever.", "dmg 202"),
        New Item("Staff of Swarming Insects", "Staff", "Rare", "Requires Attunement | Bard, Cleric, Druid, Sorcerer, Warlock or Wizard", "This staff has 10 charges and regains 1d6 + 4 expended charges daily at dawn. If you expend the last charge, roll a d20. On a 1, a swarm of insects consumes and destroys the staff, then disperses. Spells. While holding the staff, you can use an action to expend some of its charges to cast one of the following spells from it, using your spell save DC: giant insect (4 charges) or insect plague (5 charges). Insect Cloud. While holding the staff, you can use an action and expend 1 charge to cause a swarm of harmless flying insects to spread out in a 30-foot radius from you. The insects remain for 10 minutes, making the area heavily obscured for creatures other than you. The swarm moves with you, remaining centered on you. A wind of at least 10 miles per hour disperses the swarm and ends the effect.", "dmg 203"),
        New Item("Staff of Withering", "Staff", "Rare", "Requires Attunement | Cleric, Druid or Warlock", "This staff has 3 charges and regains 1d3 expended charges daily at dawn. The staff can be wielded as a magic quarterstaff. On a hit, it deals damage as a normal quarterstaff, and you can expend 1 charge to deal an extra 2d10 necrotic damage to the target. In addition, the target must succeed on a DC 15 Constitution saving throw or have disadvantage for 1 hour on any ability check or saving throw that uses Strength or Constitution.", "dmg 205"),
        New Item("Staff of Fire", "Staff", "Very Rare", "Requries Attunement | Druid, Sorcerer, Warlock or Wizard", "You have resistance to fire damage while you hold this staff. The staff has 10 charges. While holding it, you can use an action to expend 1 or more of its charges to cast one of the following spells from it, using your spell save DC: burning hands (1 charge), fireball (3 charges), or wall of fire (4 charges). The staff regains 1d6 + 4 expended charges daily at dawn. If you expend the last charge, roll a d20. On a 1, the staff blackens, crumbles into cinders, and is destroyed.", "dmg 201"),
        New Item("Staff of Frost", "Staff", "Very Rare", "Requries Attunement | Druid, Sorcerer, Warlock or Wizard", "You have resistance to cold damage while you hold this staff. The staff has 10 charges. While holding it, you can use an action to expend 1 or more of its charges to cast one of the following spells from it, using your spell save DC: cone of cold (5 charges), fog cloud (1 charge), ice storm (4 charges), or wall of ice (4 charges). The staff regains 1d6 + 4 expended charges daily at dawn. If you expend the last charge, roll a d20. On a 1, the staff turns to water and is destroyed.", "dmg 202"),
        New Item("Staff of Striking", "Staff", "Very Rare", "Requires Attunement", "This staff can be wielded as a magic quarterstaff that grants a +3 bonus to attack and damage rolls made with it. The staff has 10 charges. When you hit with a melee attack using it, you can expend up to 3 of its charges. For each charge you expend, the target takes an extra 1d6 force damage. The staff regains 1d6 + 4 expended charges daily at dawn. If you expend the last charge, roll a d20. On a 1, the staff becomes a nonmagical quarterstaff.", "dmg 203"),
        New Item("Wand of Conducting", "Wand", "Common", "", "This wand has 3 charges. While holding it, you can use an action to expend 1 of its charges and create orchestral music by waving it around. The music can be heard out to a range of 60 feet and ends when you stop waving the wand. The wand regains all expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, a sad tuba sound plays as the wand crumbles to dust and is destroyed.", "xge 140"),
        New Item("Wand of Pyrotechnics", "Wand", "Common", "", "This wand has 7 charges. While holding it, you can use an action to expend 1 of its charges and create a harmless burst of multicolored light at a point you can see up to 60 feet away. The burst of light is accompanied by a crackling noise that can be heard up to 300 feet away. The light is as bright as a torch flame but lasts only a second. The wand regains 1d6 + 1 expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand erupts in a harmless pyrotechnic display and is destroyed.", "xge 140"),
        New Item("Wand of Scowls", "Wand", "Common", "", "This wand has 3 charges. While holding it, you can use an action to expend 1 of its charges and target a humanoid you can see within 30 feet of you. The target must succeed on a DC 10 Charisma saving throw or be forced to scowl for 1 minute. The wand regains all expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand transforms into a Wand of Smiles.", "xge 140"),
        New Item("Wand of Smiles", "Wand", "Common", "", "This wand has 3 charges. While holding it, you can use an action to expend 1 of its charges and target a humanoid you can see within 30 feet of you. The target must succeed on a DC 10 Charisma saving throw or be forced to smile for 1 minute. The wand regains all expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand transforms into a Wand of Scowls.", "xge 140"),
        New Item("Wand of Magic Detection", "Wand", "Uncommon", "", "This wand has 3 charges. While holding it, you can expend 1 charge as an action to cast the detect magic spell from it. The wand regains 1d3 expended charges daily at dawn.", "dmg 211"),
        New Item("Wand of Magic Missiles", "Wand", "Uncommon", "", "This wand has 7 charges. While holding it, you can use an action to expend 1 or more of its charges to cast the magic missile spell from it. For 1 charge, you cast the 1st-level version of the spell. You can increase the spell slot level by one for each additional charge you expend. The wand regains 1d6 + 1 expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand crumbles into ashes and is destroyed.", "dmg 211"),
        New Item("Wand of Secrets", "Wand", "Uncommon", "", "The wand has 3 charges. While holding it, you can use an action to expend 1 of its charges, and if a secret door or trap is within 30 feet of you, the wand pulses and points at the one nearest to you. The wand regains 1d3 expended charges daily at dawn.", "dmg 211"),
        New Item("Wand of Web", "Wand", "Uncommon", "Requires Attunement | Spellcaster", "This wand has 7 charges. While holding it, you can use an action to expend 1 of its charges to cast the web spell (save DC 15) from it. The wand regains 1d6 + 1 expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand crumbles into ashes and is destroyed.", "dmg 211"),
        New Item("Wand of the War Mage, +1", "Wand", "Uncommon", "Requires Attunement | Spellcaster", "While holding this wand, you gain a bonus to spell attack rolls determined by the wand's rarity. In addition, you ignore half cover when making a spell attack.", "dmg 212"),
        New Item("Wand of Enemy Detection", "Wand", "Rare", "Requires Attunement", "This wand has 7 charges. While holding it, you can use an action and expend 1 charge to speak its command word. For the next minute, you know the direction of the nearest creature hostile to you within 60 feet, but not its distance from you. The wand can sense the presence of hostile creatures that are ethereal, invisible, disguised, or hidden, as well as those in plain sight. The effect ends if you stop holding the wand. The wand regains 1d6 + 1 expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand crumbles into ashes and is destroyed.", "dmg 210"),
        New Item("Wand of Fireballs", "Wand", "Rare", "Requires Attunement | Spellcaster", "This wand has 7 charges. While holding it, you can use an action to expend 1 or more of its charges to cast the fireball spell (save DC 15) from it. For 1 charge, you cast the 3rd-level version of the spell. You can increase the spell slot level by one for each additional charge you expend. The wand regains 1d6 + 1 expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand crumbles into ashes and is destroyed.", "dmg 210"),
        New Item("Wand of Lightning Bolts", "Wand", "Rare", "Requires Attunement | Spellcaster", "This wand has 7 charges. While holding it, you can use an action to expend 1 or more of its charges to cast the lightning bolt spell (save DC 15) from it. For 1 charge, you cast the 3rd-level version of the spell. You can increase the spell slot level by one for each additional charge you expend. The wand regains 1d6 + 1 expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand crumbles into ashes and is destroyed.", "dmg 211"),
        New Item("Wand of Paralysis", "Wand", "Rare", "Requires Attunement | Spellcaster", "This wand has 7 charges. While holding it, you can use an action to expend 1 of its charges to cause a thin blue ray to streak from the tip toward a creature you can see within 60 feet of you. The target must succeed on a DC 15 Constitution saving throw or be paralyzed for 1 minute. At the end of each of the target's turns, it can repeat the saving throw, ending the effect on itself on a success. The wand regains 1d6 + 1 expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand crumbles into ashes and is destroyed.", "dmg 211"),
        New Item("Wand of the War Mage, +2", "Wand", "Rare", "Requires Attunement | Spellcaster", "While holding this wand, you gain a bonus to spell attack rolls determined by the wand's rarity. In addition, you ignore half cover when making a spell attack.", "dmg 212"),
        New Item("Wand of Polymorph", "Wand", "Very Rare", "Requires Attunement | Spellcaster", "This wand has 7 charges. While holding it, you can use an action to expend 1 of its charges to cast the polymorph spell (save DC 15) from it. The wand regains 1d6 + 1 expended charges daily at dawn. If you expend the wand's last charge, roll a d20. On a 1, the wand crumbles into ashes and is destroyed.", "dmg 211"),
        New Item("Wand of the War Mage, +3", "Wand", "Very Rare", "Requires Attunement | Spellcaster", "While holding this wand, you gain a bonus to spell attack rolls determined by the wand's rarity. In addition, you ignore half cover when making a spell attack.", "dmg 212"),
        New Item("Moon-Touched Sword", "Weapon", "Common", "", "Any Sword | In darkness, the unsheathed blade of this sword sheds moonlight, creating bright light in a 15-foot radius and dim light for an additional 15 feet.", "xge 138"),
        New Item("Unbreakable Arrow", "Weapon", "Common", "", "Arrow | This arrow can't be broken, except when it is within an Antimagic Field.", "xge 139"),
        New Item("Walloping Ammunition", "Weapon", "Common", "", "Any Ammunition | This ammunition packs a wallop. A creature hit by the ammunition must succeed on a DC 10 Strength saving throw or be knocked prone.", "xge 139"),
        New Item("Ammunition, +1", "Weapon", "Uncommon", "", "Any Ammunition | You have a bonus to attack and damage rolls made with this piece of magic ammunition. The bonus is determined by the rarity of the ammunition. Once it hits a target, the ammunition is no longer magical.", "dmg 150"),
        New Item("Javelin of Lightning", "Weapon", "Uncommon", "", "Javelin | This javelin is a magic weapon. When you hurl it and speak its command word, it transforms into a bolt of lightning, forming a line 5 feet wide that extends out from you to a target within 120 feet. Each creature in the line excluding you and the target must make a DC 13 Dexterity saving throw, taking 4d6 lightning damage on a failed save, and half as much damage on a successful one. The lightning bolt turns back into a javelin when it reaches the target. Make a ranged weapon attack against the target. On a hit, the target takes damage from the javelin plus 4d6 lightning damage. The javelin's property can't be used again until the next dawn. In the meantime, the javelin can still be used as a magic weapon.", "dmg 178"),
        New Item("Moon Sickle, +1", "Weapon", "Uncommon", "Requires Attunement | Sickle, Druid or Ranger", "This silver-bladed sickle glimmers softly with moonlight. While holding this magic weapon, you gain a bonus to attack and damage rolls made with it, and you gain a bonus to spell attack rolls and the saving throw DCs of your druid and ranger spells. The bonus is determined by the weapon's rarity. In addition, you can use the sickle as a spellcasting focus for your druid and ranger spells. When you cast a spell that restores hit points, you can roll a d4 and add the number rolled to the amount of hit points restored, provided you are holding the sickle.", "tce 133"),
        New Item("Sword of Vengeance", "Weapon", "Uncommon", "Requires Attunement", "Any Sword | You gain a +1 bonus to attack and damage rolls made with this magic weapon. This sword is cursed and possessed by a vengeful spirit. Becoming attuned to it extends the curse to you. As long as you remain cursed, you are unwilling to part with the sword, keeping it on your person at all times. While attuned to this weapon, you have disadvantage on attack rolls made with weapons other than this one. In addition, while the sword is on your person, you must succeed on a DC 15 Wisdom saving throw whenever you take damage in combat. On a failed save, you must attack the creature that damaged you until you drop to 0 hit points or it does, or until you can't reach the creature to make a melee attack against it. You can break the curse in the usual ways. Alternatively, casting Banishment on the sword forces the vengeful spirit to leave it. The sword then becomes a +1 weapon with no other properties.", "dmg 206"),
        New Item("Trident of Fish Command", "Weapon", "Uncommon", "Requires Attunement", "Trident | This trident is a magic weapon. It has 3 charges. While you carry it, you can use an action and expend 1 charge to cast dominate beast (save DC 15) from it on a beast that has an innate swimming speed. The trident regains 1d3 expended charges daily at dawn.", "dmg 209"),
        New Item("Weapon, +1", "Weapon", "Uncommon", "", "You have a bonus to attack and damage rolls made with this magic weapon. The bonus is determined by the weapon's rarity.", "dmg 213"),
        New Item("Ammunition, +2", "Weapon", "Rare", "", "Any Ammunition | You have a bonus to attack and damage rolls made with this piece of magic ammunition. The bonus is determined by the rarity of the ammunition. Once it hits a target, the ammunition is no longer magical.", "dmg 150"),
        New Item("Dagger of Venom", "Weapon", "Rare", "", "Dagger | You gain a +1 bonus to attack and damage rolls made with this magic weapon. You can use an action to cause thick, black poison to coat the blade. The poison remains for 1 minute or until an attack using this weapon hits a creature. That creature must succeed on a DC 15 Constitution saving throw or take 2d10 poison damage and become poisoned for 1 minute. The dagger can't be used this way again until the next dawn.", "dmg 161"),
        New Item("Dragon Slayer", "Weapon", "Rare", "", "Any Sword | You gain a +1 bonus to attack and damage rolls made with this magic weapon. When you hit a dragon with this weapon, the dragon takes an extra 3d6 damage of the weapon's type. For the purpose of this weapon, 'dragon' refers to any creature with the dragon type, including dragon turtles and wyverns.", "dmg 166"),
        New Item("Flame Tongue", "Weapon", "Rare", "Requires Attunement", "Any Sword | You can use a bonus action to speak this magic sword's command word, causing flames to erupt from the blade. These flames shed bright light in a 40-foot radius and dim light for an additional 40 feet. While the sword is ablaze, it deals an extra 2d6 fire damage to any target it hits. The flames last until you use a bonus action to speak the command word again or until you drop or sheathe the sword.", "dmg 170"),
        New Item("Giant Slayer", "Weapon", "Rare", "", "Any Axe or Sword | You gain a +1 bonus to attack and damage rolls made with this magic weapon. When you hit a giant with it, the giant takes an extra 2d6 damage of the weapon's type and must succeed on a DC 15 Strength saving throw or fall prone. For the purpose of this weapon, 'giant' refers to any creature with the giant type, including ettins and trolls.", "dmg 172"),
        New Item("Mace of Disruption", "Weapon", "Rare", "Requires Attunement", "Any Mace | When you hit a fiend or an undead with this magic weapon, that creature takes an extra 2d6 radiant damage. If the target has 25 hit points or fewer after taking this damage, it must succeed on a DC 15 Wisdom saving throw or be destroyed. On a successful save, the creature becomes frightened of you until the end of your next turn. While you hold this weapon, it sheds bright light in a 20-foot radius and dim light for an additional 20 feet.", "dmg 179"),
        New Item("Mace of Smiting", "Weapon", "Rare", "", "Any Mace | You gain a +1 bonus to attack and damage rolls made with this magic weapon. The bonus increases to +3 when you use the mace to attack a construct. When you roll a 20 on an attack roll made with this weapon, the target takes an extra 2d6 bludgeoning damage, or 4d6 bludgeoning damage if it's a construct. If a construct has 25 hit points or fewer after taking this damage, it is destroyed.", "dmg 179"),
        New Item("Mace of Terror", "Weapon", "Rare", "Requires Attunement", "Any Mace | This magic weapon has 3 charges. While holding it, you can use an action and expend 1 charge to release a wave of terror. Each creature of your choice in a 30-foot radius extending from you must succeed on a DC 15 Wisdom saving throw or become frightened of you for 1 minute. While it is frightened in this way, a creature must spend its turns trying to move as far away from you as it can, and it can't willingly move to a space within 30 feet of you. It also can't take reactions. For its action, it can use only the Dash action or try to escape from an effect that prevents it from moving. If it has nowhere it can move, the creature can use the Dodge action. At the end of each of its turns, a creature can repeat the saving throw, ending the effect on itself on a success. The mace regains 1d3 expended charges daily at dawn.", "dmg 180"),
        New Item("Moon Sickle, +2", "Weapon", "Rare", "Requires Attunement | Sickle, Druid or Ranger", "This silver-bladed sickle glimmers softly with moonlight. While holding this magic weapon, you gain a bonus to attack and damage rolls made with it, and you gain a bonus to spell attack rolls and the saving throw DCs of your druid and ranger spells. The bonus is determined by the weapon's rarity. In addition, you can use the sickle as a spellcasting focus for your druid and ranger spells. When you cast a spell that restores hit points, you can roll a d4 and add the number rolled to the amount of hit points restored, provided you are holding the sickle.", "tce 133"),
        New Item("Sun Blade", "Weapon", "Rare", "Requires Attunement", "Longsword | This item appears to be a longsword hilt. While grasping the hilt, you can use a bonus action to cause a blade of pure radiance to spring into existence, or make the blade disappear. While the blade exists, this magic longsword has the finesse property. If you are proficient with shortswords or longswords, you are proficient with the sun blade. You gain a +2 bonus to attack and damage rolls made with this weapon, which deals radiant damage instead of slashing damage. When you hit an undead with it, that target takes an extra 1d8 radiant damage. The sword's luminous blade emits bright light in a 15-foot radius and dim light for an additional 15 feet. The light is sunlight. While the blade persists, you can use an action to expand or reduce its radius of bright and dim light by 5 feet each, to a maximum of 30 feet each or a minimum of 10 feet each.", "dmg 205"),
        New Item("Sword of Life Stealing", "Weapon", "Rare", "Requires Attunement", "Any Sword | When you attack a creature with this magic weapon and roll a 20 on the attack roll, that target takes an extra 3d6 necrotic damage, provided that the target isn't a construct or an undead. You gain temporary hit points equal to the extra damage dealt.", "dmg 206"),
        New Item("Sword of Wounding", "Weapon", "Rare", "Requires Attunement", "Any Sword | Hit points lost to this weapon's damage can be regained only through a short or long rest, rather than by regeneration, magic, or any other means. Once per turn, when you hit a creature with an attack using this magic weapon, you can wound the target. At the start of each of the wounded creature's turns, it takes 1d4 necrotic damage for each time you've wounded it, and it can then make a DC 15 Constitution saving throw, ending the effect of all such wounds on itself on a success. Alternatively, the wounded creature, or a creature within 5 feet of it, can use an action to make a DC 15 Wisdom (Medicine) check, ending the effect of such wounds on it on a success.", "dmg 207"),
        New Item("Vicious Weapon", "Weapon", "Rare", "", "When you roll a 20 on your attack roll with this magic weapon, your critical hit deals an extra 2d6 damage of the weapon's type.", "dmg 209"),
        New Item("Weapon, +2", "Weapon", "Rare", "", "You have a bonus to attack and damage rolls made with this magic weapon. The bonus is determined by the weapon's rarity.", "dmg 213"),
        New Item("Ammunition, +3", "Weapon", "Very Rare", "", "Any Ammunition | You have a bonus to attack and damage rolls made with this piece of magic ammunition. The bonus is determined by the rarity of the ammunition. Once it hits a target, the ammunition is no longer magical.", "dmg 150"),
        New Item("Arrow of Slaying", "Weapon", "Very Rare", "", "Arrow | An arrow of slaying is a magic weapon meant to slay a particular kind of creature. Some are more focused than others; for example, there are both arrows of dragon slaying and arrows of blue dragon slaying. If a creature belonging to the type, race, or group associated with an arrow of slaying takes damage from the arrow, the creature must make a DC 17 Constitution saving throw, taking an extra 6d10 piercing damage on a failed save, or half as much extra damage on a successful one. Once an arrow of slaying deals its extra damage to a creature, it becomes a nonmagical arrow. Other types of magic ammunition of this kind exist, such as bolts of slaying meant for a crossbow, though arrows are most common.", "dmg 152"),
        New Item("Dancing Sword", "Weapon", "Very Rare", "Requires Attunement", "Any Sword | You can use a bonus action to toss this magic sword into the air and speak the command word. When you do so, the sword begins to hover, flies up to 30 feet, and attacks one creature of your choice within 5 feet of it. The sword uses your attack roll and ability score modifier to damage rolls. While the sword hovers, you can use a bonus action to cause it to fly up to 30 feet to another spot within 30 feet of you. As part of the same bonus action, you can cause the sword to attack one creature within 5 feet of it. After the hovering sword attacks for the fourth time, it flies up to 30 feet and tries to return to your hand. If you have no hand free, it falls to the ground at your feet. If the sword has no unobstructed path to you, it moves as close to you as it can and then falls to the ground. It also ceases to hover if you grasp it or move more than 30 feet away from it.", "dmg 161"),
        New Item("Dwarven Thrower", "Weapon", "Very Rare", "Requires Attunement | Dwarf", "Warhammer | You gain a +3 bonus to attack and damage rolls made with this magic weapon. It has the thrown property with a normal range of 20 feet and a long range of 60 feet. When you hit with a ranged attack using this weapon, it deals an extra 1d8 damage or, if the target is a giant, 2d8 damage. Immediately after the attack, the weapon flies back to your hand.", "dmg 167"),
        New Item("Frost Brand", "Weapon", "Very Rare", "Requires Attunement", "Any Sword | When you hit with an attack using this magic sword, the target takes an extra 1d6 cold damage. In addition, while you hold the sword, you have resistance to fire damage. In freezing temperatures, the blade sheds bright light in a 10-foot radius and dim light for an additional 10 feet. When you draw this weapon, you can extinguish all nonmagical flames within 30 feet of you. This property can be used no more than once per hour.", "dmg 171"),
        New Item("Moon Sickle, +3", "Weapon", "Very Rare", "Requires Attunement | Sickle, Druid or Ranger", "This silver-bladed sickle glimmers softly with moonlight. While holding this magic weapon, you gain a bonus to attack and damage rolls made with it, and you gain a bonus to spell attack rolls and the saving throw DCs of your druid and ranger spells. The bonus is determined by the weapon's rarity. In addition, you can use the sickle as a spellcasting focus for your druid and ranger spells. When you cast a spell that restores hit points, you can roll a d4 and add the number rolled to the amount of hit points restored, provided you are holding the sickle.", "tce 133"),
        New Item("Nine Lives Stealer", "Weapon", "Very Rare", "Requires Attunement", "Any Sword | You gain a +2 bonus to attack and damage rolls made with this magic weapon. The sword has 1d8 + 1 charges. If you score a critical hit against a creature that has fewer than 100 hit points, it must succeed on a DC 15 Constitution saving throw or be slain instantly as the sword tears its life force from its body (a construct or an undead is immune). The sword loses 1 charge if the creature is slain. When the sword has no charges remaining, it loses this property.", "dmg 183"),
        New Item("Oathbow", "Weapon", "Very Rare", "Requires Attunement", "Longbow | When you nock an arrow on this bow, it whispers in Elvish, 'Swift defeat To my enemies.' When you use this weapon to make a ranged attack, you can, as a command phrase, say, 'Swift death to you who have wronged me.' The target of your attack becomes your sworn enemy until it dies or until dawn seven days later. You can have only one such sworn enemy at a time. When your sworn enemy dies, you can choose a new one after the next dawn. When you make a ranged attack roll with this weapon against your sworn enemy, you have advantage on the roll. In addition, your target gains no benefit from cover, other than total cover, and you suffer no disadvantage due to long range. If the attack hits, your sworn enemy takes an extra 3d6 piercing damage. While your sworn enemy lives, you have disadvantage on attack rolls with all other weapons.", "dmg 183"),
        New Item("Scimitar of Speed", "Weapon", "Very Rare", "Requires Attunement", "Scimitar | You gain a +2 bonus to attack and damage rolls made with this magic weapon. In addition, you can make one attack with it as a bonus action on each of your turns.", "dmg 199"),
        New Item("Sword of Sharpness", "Weapon", "Very Rare", "Requires Attunement", "Any Sword that deals slashing damage | When you attack an object with this magic sword and hit, maximize your weapon damage dice against the target. When you attack a creature with this weapon and roll a 20 on the attack roll, that target takes an extra 4d6 slashing damage. Then roll another d20. If you roll a 20, you lop off one of the target's limbs, with the effect of such loss determined by the GM. If the creature has no limb to sever, you lop off a portion of its body instead. In addition, you can speak the sword's command word to cause the blade to shed bright light in a 10- foot radius and dim light for an additional 10 feet. Speaking the command word again or sheathing the sword puts out the light.", "dmg 206"),
        New Item("Weapon, +3", "Weapon", "Very Rare", "", "You have a bonus to attack and damage rolls made with this magic weapon. The bonus is determined by the weapon's rarity.", "dmg 213"),
        New Item("Defender", "Weapon", "Legendary", "Requires Attunement", "Any Sword | You gain a +3 bonus to attack and damage rolls made with this magic weapon. The first time you attack with the sword on each of your turns, you can transfer some or all of the sword's bonus to your Armor Class, instead of using the bonus on any attacks that turn. For example, you could reduce the bonus to your attack and damage rolls to +1 and gain a +2 bonus to AC. The adjusted bonuses remain in effect until the start of your next turn, although you must hold the sword to gain a bonus to AC from it.", "dmg 164"),
        New Item("Holy Avenger", "Weapon", "Legendary", "Requires Attunement | Paladin", "Any Sword | You gain a +3 bonus to attack and damage rolls made with this magic weapon. When you hit a fiend or an undead with it, that creature takes an extra 2d10 radiant damage. While you hold the drawn sword, it creates an aura in a 10-foot radius around you. You and all creatures friendly to you in the aura have advantage on saving throws against spells and other magical effects. If you have 17 or more levels in the paladin class, the radius of the aura increases to 30 feet.", "dmg 174"),
        New Item("Vorpal Sword", "Weapon", "Legendary", "Requires Attunement", "Any Sword that deals slashing damage | You gain a +3 bonus to attack and damage rolls made with this magic weapon. In addition, the weapon ignores resistance to slashing damage. When you attack a creature that has at least one head with this weapon and roll a 20 on the attack roll, you cut off one of the creature's heads. The creature dies if it can't survive without the lost head. A creature is immune to this effect if it is immune to slashing damage, doesn't have or need a head, has legendary actions, or the GM decides that the creature is too big for its head to be cut off with this weapon. Such a creature instead takes an extra 6d8 slashing damage from the hit.", "dmg 209"),
        New Item("Luck Blade", "Weapon", "Legendary", "Requires Attunement", "Any Sword | You gain a +1 bonus to attack and damage rolls made with this magic weapon. While the sword is on your person, you also gain a +1 bonus to saving throws. Luck. If the sword is on your person, you can call on its luck (no action required) to reroll one attack roll, ability check, or saving throw you dislike. You must use the second roll. This property can't be used again until the next dawn. Wish. The sword has 1d4-1 charges. While holding it, you can use an action to expend 1 charge and cast the wish spell from it. This property can't be used again until the next dawn. The sword loses this property if it has no charges.", "dmg 179"),
        New Item("Bead of Nourishment", "Wondrous Item", "Common", "", "This spongy, flavorless, gelatinous bead dissolves on your tongue and provides as much nourishment as 1 day of rations.", "xge 136"),
        New Item("Bead of Refreshment", "Wondrous Item", "Common", "", "This spongy, flavorless, gelatinous bead dissolves in liquid, transforming up to a pint of the liquid into fresh, cold drinking water. The bead has no effect on magical liquids or harmful substances such as poison.", "xge 136"),
        New Item("Boots of False Tracks", "Wondrous Item", "Common", "", "Only humanoids can wear these boots. While wearing the boots, you can choose to have them leave tracks like those of another kind of humanoid of your size.", "xge 136"),
        New Item("Candle of the Deep", "Wondrous Item", "Common", "", "The flame of this candle is not extinguished when immersed in water. It gives off light and heat like a normal candle.", "xge 136"),
        New Item("Charlatan's Die", "Wondrous ITem", "Common", "Requires Attunement", "Whenever you roll this six-sided die, you can control which number it rolls.", "xge 136"),
        New Item("Cloak of Billowing", "Wondrous Item", "Common", "", "While wearing this cloak, you can use a bonus action to make it billow dramatically.", "xge 136"),
        New Item("Cloak of Many Fashions", "Wondrous Item", "Common", "", "While wearing this cloak, you can use a bonus action to change the style, color, and apparent quality of the garment. The cloak's weight doesn't change. Regardless of its appearance, the cloak can't be anything but a cloak. Although it can duplicate the appearance of other magic cloaks, it doesn't gain their magical properties.", "xge 136"),
        New Item("Clockwork Amulet", "Wondrous Item", "Common", "", "This copper amulet contains tiny interlocking gears and is powered by magic from Mechanus, a plane of clockwork predictability. A creature that puts an ear to the amulet can hear faint ticking and whirring noises coming from within. When you make an attack roll while wearing the amulet, you can forgo rolling the d20 to get a 10 on the die. Once used, this property can't be used again until the next dawn.", "xge 137"),
        New Item("Clothes of Mending", "Wondrous Item", "Common", "", "This elegant outfit of traveler's clothes magically mends itself to counteract daily wear and tear. Pieces of the outfit that are destroyed can't be repaired in this way.", "xge 137"),
        New Item("Dread Helm", "Wondrous Item", "Common", "", "This fearsome steel helm makes your eyes glow red while you wear it.", "xge 137"),
        New Item("Ear Horn of Hearing", "Wondrous Item", "Common", "", "While held up to your ear, this horn suppresses the effects of the deafened condition on you, allowing you to hear normally.", "xge 137"),
        New Item("Enduring Spellbook", "Wondrous Item", "Common", "", "This spellbook, along with anything written on its pages, can't be damaged by fire or immersion in water. In addition, the spellbook doesn't deteriorate with age.", "xge 137"),
        New Item("Ersatz Eye", "Wondrous Item", "Common", "Requires Attunement", "This artificial eye replaces a real one that was lost or removed. While the ersatz eye is embedded in your eye socket, it can’t be removed by anyone other than you, and you can see through the tiny orb as though it were a normal eye.", "xge 137"),
        New Item("Hat of Vermin", "Wondrous Item", "Common", "", "This hat has 3 charges. While holding the hat, you can use an action to expend 1 of its charges and speak a command word that summons your choice of a bat, a frog, or a rat (see the Player's Handbook or the Monster Manual for statistics). The summoned creature magically appears in the hat and tries to get away from you as quickly as possible. The creature is neither friendly nor hostile, and it isn't under your control. It behaves as an ordinary creature of its kind and disappears after 1 hour or when it drops to 0 hit points. The hat regains all expended charges daily at dawn.", "xge 137"),
        New Item("Heward's Handy Spice Pouch", "Wondrous Item", "Common", "", "This belt pouch appears empty and has 10 charges. While holding the pouch, you can use an action to expend 1 of its charges, speak the name of any nonmagical food seasoning (such as salt, pepper, saffron, or cilantro), and remove a pinch of the desired seasoning from the pouch. A pinch is enough to season a single meal. The pouch regains 1d6 + 4 expended charges daily at dawn.", "xge 137"),
        New Item("Horn of Silent Alarm", "Wondrous Item", "Common", "", "This horn has 4 charges. When you use an action to blow it, one creature of your choice can hear the horn's blare, provided the creature is within 600 feet of the horn and not deafened. No other creature hears sound coming from the horn. The horn regains 1d4 expended charges daily at dawn.", "xge 137"),
        New Item("Instrument of Illusions", "Wondrous Item", "Common", "Requires Attunement", "While you are playing this musical instrument, you can create harmless, illusory visual effects within a 5-foot-radius sphere centered on the instrument. If you are a bard, the radius increases to 15 feet. Sample visual effects include luminous musical notes, a spectral dancer, butterflies, and gently falling snow. The magical effects have neither substance nor sound, and they are obviously illusory. The effects end when you stop playing.", "xge 137"),
        New Item("Lock of Trickery", "Wondrous Item", "Common", "", "This lock appears to be an ordinary lock (of the type described in chapter 5 of the Player's Handbook) and comes with a single key. The tumblers in this lock magically adjust to thwart burglars. Dexterity checks made to pick the lock have disadvantage.", "xge 138"),
        New Item("Mystery Key", "Wondrous Item", "Common", "", "A question mark is worked into the head of this key. The key has a 5 percent chance of unlocking any lock into which it's inserted. Once it unlocks something, the key disappears.", "xge 138"),
        New Item("Orb of Direction", "Wondrous Item", "Common", "", "While holding this orb, you can use an action to determine which way is north. This property functions only on the Material Plane.", "xge 138"),
        New Item("Orb of Time", "Wondrous Item", "Common", "", "While holding this orb, you can use an action to determine whether it is morning, afternoon, evening, or nighttime outside. This property functions only on the Material Plane.", "xge 138"),
        New Item("Perfume of Bewitching", "Wondrous Item", "Common", "", "This tiny vial contains magic perfume, enough for one use. You can use an action to apply the perfume to yourself, and its effect lasts 1 hour. For the duration, you have advantage on all Charisma checks directed at humanoids of challenge rating 1 or lower. Those subjected to the perfume's effect are not aware that they've been influenced by magic.", "xge 138"),
        New Item("Pipe of Smoke Monsters", "Wondrous Item", "Common", "", "While smoking this pipe, you can use an action to exhale a puff of smoke that takes the form of a single creature, such as a dragon, a flumph, or a froghemoth. The form must be small enough to fit in a 1-foot cube and loses its shape after a few seconds, becoming an ordinary puff of smoke.", "xge 138"),
        New Item("Pole of Angling", "Wondrous Item", "Common", "", "While holding this 10-foot pole, you can speak a command word and transform it into a fishing pole with a hook, a line, and a reel. Speaking the command word again changes the fishing pole back into a normal 10-foot pole.", "xge 138"),
        New Item("Pole of Collapsing", "Wondrous Item", "Common", "", "While holding this 10-foot pole, you can use an action to speak a command word and cause it to collapse into a 1-foot-long rod, for ease of storage. The pole's weight doesn't change. You can use an action to speak a different command word and cause the rod to revert to a pole; however, the rod will elongate only as far as the surrounding space allows.", "xge 138"),
        New Item("Pot of Awakening", "Wondrous Item", "Common", "", "If you plant an ordinary shrub in this 10-pound clay pot and let it grow for 30 days, the shrub magically transforms into an awakened shrub (see the Monster Manual for statistics) at the end of that time. When the shrub awakens, its roots break the pot, destroying it. The awakened shrub is friendly toward you. Absent commands from you, it does nothing.", "xge 138"),
        New Item("Rope of Mending", "Wondrous Item", "Common", "", "You can cut this 50-foot coil of hempen rope into any number of smaller pieces, and then use an action to speak a command word and cause the pieces to knit back together. The pieces must be in contact with each other and not otherwise in use. A rope of mending is forever shortened if a section of it is lost or destroyed.", "xge 138"),
        New Item("Ruby of the War Mage", "Wondrous Item", "Common", "Requires Attunement | Spellcaster", "Etched with eldritch runes, this 1-inch-diameter ruby allows you to use a simple or martial weapon as a spellcasting focus for your spells. For this property to work, you must attach the ruby to the weapon by pressing the ruby against it for at least 10 minutes. Thereafter, the ruby can't be removed unless you detach it as an action or the weapon is destroyed. Not even an Antimagic Field causes it to fall off. The ruby does fall off the weapon if your attunement to the ruby ends.", "xge 138"),
        New Item("Talking Doll", "Wondrous Item", "Common", "Requires Attunement", "While this stuffed doll is within 5 feet of you, you can spend a short rest telling it to say up to six phrases, none of which can be more than six words long, and set a condition under which the doll speaks each phrase. You can also replace old phrases with new ones. Whatever the condition, it must occur within 5 feet of the doll to make it speak. For example, whenever someone picks up the doll, it might say, 'I want a piece Of candy.' The doll's phrases are lost when your attunement to the doll ends.", "xge 139"),
        New Item("Bag of Holding", "Wondrous Item", "Uncommon", "", "This bag has an interior space considerably larger than its outside dimensions, roughly 2 feet in diameter at the mouth and 4 feet deep. The bag can hold up to 500 pounds, not exceeding a volume of 64 cubic feet. The bag weighs 15 pounds, regardless of its contents. Retrieving an item from the bag requires an action. If the bag is overloaded, pierced, or torn, it ruptures and is destroyed, and its contents are scattered in the Astral Plane. If the bag is turned inside out, its contents spill forth, unharmed, but the bag must be put right before it can be used again. Breathing creatures inside the bag can survive up to a number of minutes equal to 10 divided by the number of creatures (minimum 1 minute), after which time they begin to suffocate. Placing a bag of holding inside an extradimensional space created by a handy haversack, portable hole, or similar item instantly destroys both items and opens a gate to the Astral Plane. The gate originates where the one item was placed inside the other. Any creature within 10 feet of the gate is sucked through it to a random location on the Astral Plane. The gate then closes. The gate is one-way only and can't be reopened.", "dmg 153"),
        New Item("Boots of Elvenkind", "Wondrous Item", "Uncommon", "", "While you wear these boots, your steps make no sound, regardless of the surface you are moving across. You also have advantage on Dexterity (Stealth) checks that rely on moving silently.", "dmg 155"),
        New Item("Boots of Striding and Springing", "Wondrous Item", "Uncommon", "Requires Attunement", "While you wear these boots, your walking speed becomes 30 feet, unless your walking speed is higher, and your speed isn't reduced if you are encumbered or wearing heavy armor. In addition, you can jump three times the normal distance, though you can't jump farther than your remaining movement would allow.", "dmg 156"),
        New Item("Bracers of Archery", "Wondrous Item", "Uncommon", "Requires Attunement", "While wearing these bracers, you have proficiency with the longbow and shortbow, and you gain a +2 bonus to damage rolls on ranged attacks made with such weapons.", "dmg 156"),
        New Item("Brooch of Shielding", "Wondrous Item", "Uncommon", "Requires Attunement", "While wearing this brooch, you have resistance to force damage, and you have immunity to damage from the magic missile spell.", "dmg 156"),
        New Item("Broom of Flying", "Wondrous Item", "Uncommon", "", "This wooden broom, which weighs 3 pounds, functions like a mundane broom until you stand astride it and speak its command word. It then hovers beneath you and can be ridden in the air. It has a flying speed of 50 feet. It can carry up to 400 pounds, but its flying speed becomes 30 feet while carrying over 200 pounds. The broom stops hovering when you land. You can send the broom to travel alone to a destination within 1 mile of you if you speak the command word, name the location, and are familiar with that place. The broom comes back to you when you speak another command word, provided that the broom is still within 1 mile of you.", "dmg 156"),
        New Item("Cap of Water Breathing", "Wondrous Item", "Uncommon", "", "While wearing this cap underwater, you can speak its command word as an action to create a bubble of air around your head. It allows you to breathe normally underwater. This bubble stays with you until you speak the command word again, the cap is removed, or you are no longer underwater.", "dmg 157"),
        New Item("Circlet of Blasting", "Wondrous Item", "Uncommon", "", "While wearing this circlet, you can use an action to cast the scorching ray spell with it. When you make the spell's attacks, you do so with an attack bonus of +5. The circlet can't be used this way again until the next dawn.", "dmg 158"),
        New Item("Cloak of Elvenkind", "Wondrous Item", "Uncommon", "Requires Attunement", "While you wear this cloak with its hood up, Wisdom (Perception) checks made to see you have disadvantage, and you have advantage on Dexterity (Stealth) checks made to hide, as the cloak's color shifts to camouflage you. Pulling the hood up or down requires an action.", "dmg 158"),
        New Item("Cloak of Protection", "Wondrous Item", "Uncommon", "Requires Attunement", "You gain a +1 bonus to AC and saving throws while you wear this cloak.", "dmg 159"),
        New Item("Cloak of the Manta Ray", "Wondrous Item", "Uncommon", "", "While wearing this cloak with its hood up, you can breathe underwater, and you have a swimming speed of 60 feet. Pulling the hood up or down requires an action.", "dmg 159"),
        New Item("Dust of Disappearance", "Wondrous Item", "Uncommon", "", "Found in a small packet, this powder resembles very fine sand. There is enough of it for one use. When you use an action to throw the dust into the air, you and each creature and object within 10 feet of you become invisible for 2d4 minutes. The duration is the same for all subjects, and the dust is consumed when its magic takes effect. If a creature affected by the dust attacks or casts a spell, the invisibility ends for that creature.", "dmg 166"),
        New Item("Eversmoking Bottle", "Wondrous Item", "Uncommon", "", "Smoke leaks from the lead-stoppered mouth of this brass bottle, which weighs 1 pound. When you use an action to remove the stopper, a cloud of thick smoke pours out in a 60-foot radius from the bottle. The cloud's area is heavily obscured. Each minute the bottle remains open and within the cloud, the radius increases by 10 feet until it reaches its maximum radius of 120 feet. The cloud persists as long as the bottle is open. Closing the bottle requires you to speak its command word as an action. Once the bottle is closed, the cloud disperses after 10 minutes. A moderate wind (11 to 20 miles per hour) can also disperse the smoke after 1 minute, and a strong wind (21 or more miles per hour) can do so after 1 round.", "dmg 168"),
        New Item("Eyes of Charming", "Wondrous Item", "Uncommon", "Requires Attunement", "These crystal lenses fit over the eyes. They have 3 charges. While wearing them, you can expend 1 charge as an action to cast the charm person spell (save DC 13) on a humanoid within 30 feet of you, provided that you and the target can see each other. The lenses regain all expended charges daily at dawn.", "dmg 168"),
        New Item("Eyes of Minute Seeing", "Wondrous Item", "Uncommon", "", "These crystal lenses fit over the eyes. While wearing them, you can see much better than normal out to a range of 1 foot. You have advantage on Intelligence (Investigation) checks that rely on sight while searching an area or studying an object within that range.", "dmg 168"),
        New Item("Gauntlets of Ogre Power", "Wondrous Item", "Uncommon", "Requires Attunement", "Your Strength score is 19 while you wear these gauntlets. They have no effect on you if your Strength is already 19 or higher.", "dmg 171"),
        New Item("Gloves of Missile Snaring", "Wondrous Item", "Uncommon", "Requires Attunement", "These gloves seem to almost meld into your hands when you don them. When a ranged weapon attack hits you while you're wearing them, you can use your reaction to reduce the damage by 1d10 + your Dexterity modifier, provided that you have a free hand. If you reduce the damage to 0, you can catch the missile if it is small enough for you to hold in that hand.", "dmg 172"),
        New Item("Goggles of Night", "Wondrous Item", "Uncommon", "", "While wearing these dark lenses, you have darkvision out to a range of 60 feet. If you already have darkvision, wearing the goggles increases its range by 60 feet.", "dmg 172"),
        New Item("Hat of Disguise", "Wondrous Item", "Uncommon", "Requires Attunement", "While wearing this hat, you can use an action to cast the disguise self spell from it at will. The spell ends if the hat is removed.", "dmg 173"),
        New Item("Headband of Intellect", "Wondrous Item", "Uncommon", "Requires Attunement", "Your Intelligence score is 19 while you wear this headband. It has no effect on you if your Intelligence is already 19 or higher.", "dmg 173"),
        New Item("Helm of Comprehending Languages", "Wondrous Item", "Uncommon", "", "While wearing this helm, you can use an action to cast the comprehend languages spell from it at will.", "dmg 173"),
        New Item("Helm of Telepathy", "Wondrous Item", "Uncommon", "Requires Attunement", "While wearing this helm, you can use an action to cast the detect thoughts spell (save DC 13) from it. As long as you maintain concentration on the spell, you can use a bonus action to send a telepathic message to a creature you are focused on. It can reply -- using a bonus action to do so -- while your focus on it continues. While focusing on a creature with detect thoughts, you can use an action to cast the suggestion spell (save DC 13) from the helm on that creature. Once used, the suggestion property can't be used again until the next dawn.", "dmg 174"),
        New Item("Keoghtom's Ointment", "Wondrous Item", "Uncommon", "", "This glass jar, 3 inches in diameter, contains 1d4 + 1 doses of a thick mixture that smells faintly of aloe. The jar and its contents weigh 1/2 pound. As an action, one dose of the ointment can be swallowed or applied to the skin. The creature that receives it regains 2d8 + 2 hit points, ceases to be poisoned, and is cured of any disease.", "dmg 179"),
        New Item("Lantern of Revealing", "Wondrous Item", "Uncommon", "", "While lit, this hooded lantern burns for 6 hours on 1 pint of oil, shedding bright light in a 30-foot radius and dim light for an additional 30 feet. Invisible creatures and objects are visible as long as they are in the lantern's bright light. You can use an action to lower the hood, reducing the light to dim light in a 5-foot radius.", "dmg 179"),
        New Item("Necklace of Adaptation", "Wondrous Item", "Uncommon", "Requires Attunement", "While wearing this necklace, you can breathe normally in any environment, and you have advantage on saving throws made against harmful gases and vapors (such as cloudkill and stinking cloud effects, inhaled poisons, and the breath weapons of some dragons).", "dmg 182"),
        New Item("Winged Boots", "Wondrous Item", "Uncommon", "Requires Attunement", "While you wear these boots, you have a flying speed equal to your walking speed. You can use the boots to fly for up to 4 hours, all at once or in several shorter flights, each one using a minimum of 1 minute from the duration. If you are flying when the duration expires, you descend at a rate of 30 feet per round until you land. The boots regain 2 hours of flying capability for every 12 hours they aren't in use.", "dmg 214"),
        New Item("Amulet of Health", "Wondrous Item", "Rare", "Requires Attunement", "Your Constitution score is 19 while you wear this amulet. It has no effect on you if your Constitution is already 19 or higher.", "dmg 150"),
        New Item("Boots of Levitation", "Wondrous Item", "Rare", "Requires Attunement", "While you wear these boots, you can use an action to cast the levitate spell on yourself at will.", "dmg 155"),
        New Item("Boots of Speed", "Wondrous Item", "Rare", "Requires Attunement", "While you wear these boots, you can use a bonus action and click the boots' heels together. If you do, the boots double your walking speed, and any creature that makes an opportunity attack against you has disadvantage on the attack roll. If you click your heels together again, you end the effect. When the boots' property has been used for a total of 10 minutes, the magic ceases to function until you finish a long rest.", "dmg 155"),
        New Item("Bracers of Defense", "Wondrous Item", "Rare", "Requires Attunement", "While wearing these bracers, you gain a +2 bonus to AC if you are wearing no armor and using no shield.", "dmg 156"),
        New Item("Cape of the Mountebank", "Wondrous Item", "Rare", "", "This cape smells faintly of brimstone. While wearing it, you can use it to cast the dimension door spell as an action. This property of the cape can't be used again until the next dawn. When you disappear, you leave behind a cloud of smoke, and you appear in a similar cloud of smoke at your destination. The smoke lightly obscures the space you left and the space you appear in, and it dissipates at the end of your next turn. A light or stronger wind disperses the smoke.", "dmg 157"),
        New Item("Chime of Opening", "Wondrous Item", "Rare", "", "This hollow metal tube measures about 1 foot long and weighs 1 pound. You can strike it as an action, pointing it at an object within 120 feet of you that can be opened, such as a door, lid, or lock. The chime issues a clear tone, and one lock or latch on the object opens unless the sound can't reach the object. If no locks or latches remain, the object itself opens. The chime can be used ten times. After the tenth time, it cracks and becomes useless.", "dmg 158"),
        New Item("Cloak of Displacement", "Wondrous Item", "Rare", "Requires Attunement", "While you wear this cloak, it projects an illusion that makes you appear to be standing in a place near your actual location, causing any creature to have disadvantage on attack rolls against you. If you take damage, the property ceases to function until the start of your next turn. This property is suppressed while you are incapacitated, restrained, or otherwise unable to move.", "dmg 158"),
        New Item("Dimensional Shackles", "Wondrous Item", "Rare", "", "You can use an action to place these shackles on an incapacitated creature. The shackles adjust to fit a creature of Small to Large size. In addition to serving as mundane manacles, the shackles prevent a creature bound by them from using any method of extradimensional movement, including teleportation or travel to a different plane of existence. They don't prevent the creature from passing through an interdimensional portal. You and any creature you designate when you use the shackles can use an action to remove them. Once every 30 days, the bound creature can make a DC 30 Strength (Athletics) check. On a success, the creature breaks free and destroys the shackles.", "dmg 156"),
        New Item("Folding Boat", "Wondrous Item", "Rare", "", "This object appears as a wooden box that measures 12 inches long, 6 inches wide, and 6 inches deep. It weighs 4 pounds and floats. It can be opened to store items inside. This item also has three command words, each requiring you to use an action to speak it. One command word causes the box to unfold into a boat 10 feet long, 4 feet wide, and 2 feet deep. The boat has one pair of oars, an anchor, a mast, and a lateen sail. The boat can hold up to four Medium creatures comfortably. The second command word causes the box to unfold into a ship 24 feet long, 8 feet wide, and 6 feet deep. The ship has a deck, rowing seats, five sets of oars, a steering oar, an anchor, a deck cabin, and a mast with a square sail. The ship can hold fifteen Medium creatures comfortably. When the box becomes a vessel, its weight becomes that of a normal vessel its size, and anything that was stored in the box remains in the boat. The third command word causes the folding boat to fold back into a box, provided that no creatures are aboard. Any objects in the vessel that can't fit inside the box remain outside the box as it folds. Any objects in the vessel that can fit inside the box do so.", "dmg 170"),
        New Item("Gem of Seeing", "Wondrous Item", "Rare", "Requires Attunement", "This gem has 3 charges. As an action, you can speak the gem's command word and expend 1 charge. For the next 10 minutes, you have truesight out to 120 feet when you peer through the gem. The gem regains 1d3 expended charges daily at dawn.", "dmg 172"),
        New Item("Helm of Teleportation", "Wondrous Item", "Rare", "Requires Attunement", "This helm has 3 charges. While wearing it, you can use an action and expend 1 charge to cast the teleport spell from it. The helm regains 1d3 expended charges daily at dawn.", "dmg 174"),
        New Item("Horseshoes of Speed", "Wondrous Item", "Rare", "", "These iron horseshoes come in a set of four. While all four shoes are affixed to the hooves of a horse or similar creature, they increase the creature's walking speed by 30 feet.", "dmg 175"),
        New Item("Mantle of Spell Resistance", "Wondrous Item", "Rare", "Requires Attunement", "You have advantage on saving throws against spells while you wear this cloak.", "dmg 180"),
        New Item("Necklace of Fireballs", "Wondrous Item", "Rare", "", "This necklace has 1d6 + 3 beads hanging from it. You can use an action to detach a bead and throw it up to 60 feet away. When it reaches the end of its trajectory, the bead detonates as a 3rd-level fireball spell (save DC 15). You can hurl multiple beads, or even the whole necklace, as one action. When you do so, increase the level of the fireball by 1 for each bead beyond the first.", "dmg 182"),
        New Item("Wings of Flying", "Wondrous Item", "Rare", "Requires Attunement", "While wearing this cloak, you can use an action to speak its command word. This turns the cloak into a pair of bat wings or bird wings on your back for 1 hour or until you repeat the command word as an action. The wings give you a flying speed of 60 feet. When they disappear, you can't use them again for 1d12 hours.", "dmg 214"),
        New Item("Amulet of the Planes", "Wondrous Item", "Very Rare", "Requires Attunement", "While wearing this amulet, you can use an action to name a location that you are familiar with on another plane of existence. Then make a DC 15 Intelligence check. On a successful check, you cast the Plane Shift spell. On a failure, you and each creature and object within 15 feet of you travel to a random destination. Roll a d100. On a 1-60, you travel to a random location on the plane you named. On a 61-100, you travel to a randomly determined plane of existence.", "dmg 150"),
        New Item("Bag of Devouring", "Wondrous Item", "Very Rare", "", "This bag superficially resembles a bag of holding but is a feeding orifice for a gigantic extradimensional creature. Turning the bag inside out closes the orifice. The extradimensional creature attached to the bag can sense whatever is placed inside the bag. Animal or vegetable matter placed wholly in the bag is devoured and lost forever. When part of a living creature is placed in the bag, as happens when someone reaches inside it, there is a 50 percent chance that the creature is pulled inside the bag. A creature inside the bag can use its action to try to escape with a successful DC 15 Strength check. Another creature can use its action to reach into the bag to pull a creature out, doing so with a successful DC 20 Strength check (provided it isn't pulled inside the bag first). Any creature that starts its turn inside the bag is devoured, its body destroyed. Inanimate objects can be stored in the bag, which can hold a cubic foot of such material. However, once each day, the bag swallows any objects inside it and spits them out into another plane of existence. The GM determines the time and plane. If the bag is pierced or torn, it is destroyed, and anything contained within it is transported to a random location on the Astral Plane.", "dmg 153"),
        New Item("Crystal Ball", "Wondrous Item", "Very Rare", "Requires Attunement", "The typical crystal ball, a very rare item, is about 6 inches in diameter. While touching it, you can cast the scrying spell (save DC 17) with it.", "dmg 159"),
        New Item("Manual of Bodily Health", "Wondrous Item", "Very Rare", "", "This book contains health and diet tips, and its words are charged with magic. If you spend 48 hours over a period of 6 days or fewer studying the book's contents and practicing its guidelines, your Constitution score increases by 2, as does your maximum for that score. The manual then loses its magic, but regains it in a century.", "dmg 180"),
        New Item("Tome of Clear Thought", "Wondrous Item", "Very Rare", "", "This book contains memory and logic exercises, and its words are charged with magic. If you spend 48 hours over a period of 6 days or fewer studying the book's contents and practicing its guidelines, your Intelligence score increases by 2, as does your maximum for that score. The manual then loses its magic, but regains it in a century.", "dmg 208"),
        New Item("Tome of Understanding", "Wondrous Item", "Very Rare", "", "This book contains intuition and insight exercises, and its words are charged with magic. If you spend 48 hours over a period of 6 days or fewer studying the book's contents and practicing its guidelines, your Wisdom score increases by 2, as does your maximum for that score. The manual then loses its magic, but regains it in a century.", "dmg 209"),
        New Item("Cloak of Invisibility", "Wondrous Item", "Legendary", "Requires Attunement", "While wearing this cloak, you can pull its hood over your head to cause yourself to become invisible. While you are invisible, anything you are carrying or wearing is invisible with you. You become visible when you cease wearing the hood. Pulling the hood up or down requires an action. Deduct the time you are invisible, in increments of 1 minute, from the cloak's maximum duration of 2 hours. After 2 hours of use, the cloak ceases to function. For every uninterrupted period of 12 hours, the cloak goes unused, it regains 1 hour of duration.", "dmg 158"),
        New Item("Cubic Gate", "Wondrous Item", "Legendary", "", "This cube is 3 inches across and radiates palpable magical energy. The six sides of the cube are each keyed to a different plane of existence, one of which is the Material Plane. The other sides are linked to planes determined by the GM. You can use an action to press one side of the cube to cast the Gate spell with it, opening a portal to the plane keyed to that side. Alternatively, if you use an action to press one side twice, you can cast the plane shift spell (save DC 17) with the cube and transport the targets to the plane keyed to that side. The cube has 3 charges. Each use of the cube expends 1 charge. The cube regains 1d3 expended charges daily at dawn.", "dmg 160"),
        New Item("Sovereign Glue", "Wondrous Item", "Legendary", "", "This viscous, milky-white substance can form a permanent adhesive bond between any two objects. It must be stored in a jar or flask that has been coated inside with oil of slipperiness. When found, a container contains 1d6 + 1 ounces. One ounce of the glue can cover a 1-foot square surface. The glue takes 1 minute to set. Once it has done so, the bond it creates can be broken only by the application of universal solvent or oil of etherealness, or with a wish spell.", "dmg 200"),
        New Item("Talisman of Pure Good", "Wondrous Item", "Legendary", "Requires Attunement | Good Alignment", "This talisman is a mighty symbol of goodness. A creature that is neither good nor evil in alignment takes 6d6 radiant damage upon touching the talisman. An evil creature takes 8d6 radiant damage upon touching the talisman. Either sort of creature takes the damage again each time it ends its turn holding or carrying the talisman. If you are a good cleric or paladin, you can use the talisman as a holy symbol, and you gain a +2 bonus to spell attack rolls while you wear or hold it. The talisman has 7 charges. If you are wearing or holding it, you can use an action to expend 1 charge from it and choose one creature you can see on the ground within 120 feet of you. If the target is of evil alignment, a flaming fissure opens under it. The target must succeed on a DC 20 Dexterity saving throw or fall into the fissure and be destroyed, leaving no remains. The fissure then closes, leaving no trace of its existence. When you expend the last charge, the talisman disperses into motes of golden light and is destroyed.", "dmg 207"),
        New Item("Universal Solvent", "Wondrous Item", "Legendary", "", "This tube holds milky liquid with a strong alcohol smell. You can use an action to pour the contents of the tube onto a surface within reach. The liquid instantly dissolves up to 1 square foot of adhesive it touches, including sovereign glue.", "dmg 209"),
        New Item("Well of Many Worlds", "Wondrous Item", "Legendary", "", "This fine black cloth, soft as silk, is folded up to the dimensions of a handkerchief. It unfolds into a circular sheet 6 feet in diameter. You can use an action to unfold and place the well of many worlds on a solid surface, whereupon it creates a two-way portal to another world or plane of existence. Each time the item opens a portal, the GM decides where it leads. You can use an action to close an open portal by taking hold of the edges of the cloth and folding it up. Once the well of many worlds has opened a portal, it can't do so again for 1d8 hours.", "dmg 213")
    }
End Module

Public Module JunkItemDatabase
    Public ReadOnly Items As New List(Of Item) From {
        New Item("a tiny figurine of a god of ice", "Junk", "Common", "", "", ""),
        New Item("a document of identification", "Junk", "Common", "", "", ""),
        New Item("dried berries", "Junk", "Common", "", "", ""),
        New Item("some garlic", "Junk", "Common", "", "", ""),
        New Item("a brass ring", "Junk", "Common", "", "", ""),
        New Item("written directions to the Gauntlet of Aphotic Souls", "Junk", "Common", "", "", ""),
        New Item("a smoking pipe", "Junk", "Common", "", "", ""),
        New Item("a wedge of cheese", "Junk", "Common", "", "", ""),
        New Item("a pair of cloth gloves", "Junk", "Common", "", "", ""),
        New Item("a shopping list", "Junk", "Common", "", "", ""),
        New Item("fragments of a shattered sword", "Junk", "Common", "", "", ""),
        New Item("a pair of candle clocks", "Junk", "Common", "", "", ""),
        New Item("a pendant of stained glass", "Junk", "Common", "", "", ""),
        New Item("some hardtack", "Junk", "Common", "", "", ""),
        New Item("nine unusual coins", "Junk", "Common", "", "", ""),
        New Item("a blood-stained cloth", "Junk", "Common", "", "", ""),
        New Item("a holy amulet", "Junk", "Common", "", "", ""),
        New Item("a ring of iron keys", "Junk", "Common", "", "", ""),
        New Item("a deck of tarot cards", "Junk", "Common", "", "", ""),
        New Item("a pouch of medicinal herbs", "Junk", "Common", "", "", ""),
        New Item("a list of people", "Junk", "Common", "", "", ""),
        New Item("a block of soap", "Junk", "Common", "", "", ""),
        New Item("the deed to a ruined tower", "Junk", "Common", "", "", ""),
        New Item("a vial of scented oil", "Junk", "Common", "", "", ""),
        New Item("several ribbons", "Junk", "Common", "", "", ""),
        New Item("a platinum coin wrapped in a crude map", "Junk", "Common", "", "", ""),
        New Item("some lacy undergarments", "Junk", "Common", "", "", ""),
        New Item("a set of fine brushes", "Junk", "Common", "", "", ""),
        New Item("a letter of correspondence", "Junk", "Common", "", "", ""),
        New Item("a steel key", "Junk", "Common", "", "", ""),
        New Item("a brass bell", "Junk", "Common", "", "", ""),
        New Item("a whetstone", "Junk", "Common", "", "", ""),
        New Item("a magnifying glass", "Junk", "Common", "", "", ""),
        New Item("a shopping list", "Junk", "Common", "", "", ""),
        New Item("a preserved basilisk eye", "Junk", "Common", "", "", ""),
        New Item("an invitation", "Junk", "Common", "", "", ""),
        New Item("a glass sphere", "Junk", "Common", "", "", ""),
        New Item("an onion", "Junk", "Common", "", "", ""),
        New Item("a pouch of pipeweed", "Junk", "Common", "", "", ""),
        New Item("a small pouch of chalk", "Junk", "Common", "", "", ""),
        New Item("a flask of ale", "Junk", "Common", "", "", ""),
        New Item("eleven unusual coins", "Junk", "Common", "", "", ""),
        New Item("some stale bread", "Junk", "Common", "", "", ""),
        New Item("some scraps of bad poetry", "Junk", "Common", "", "", ""),
        New Item("a flask of water", "Junk", "Common", "", "", ""),
        New Item("a spool of thread", "Junk", "Common", "", "", ""),
        New Item("a pouch of seeds", "Junk", "Common", "", "", ""),
        New Item("a pouch of glass marbles", "Junk", "Common", "", "", ""),
        New Item("a small hammer and chisel", "Junk", "Common", "", "", ""),
        New Item("a carved bone whistle", "Junk", "Common", "", "", ""),
        New Item("a broken key", "Junk", "Common", "", "", ""),
        New Item("some sand", "Junk", "Common", "", "", ""),
        New Item("a rabbit's foot", "Junk", "Common", "", "", ""),
        New Item("a bundle of seven twigs", "Junk", "Common", "", "", ""),
        New Item("an empty flask", "Junk", "Common", "", "", ""),
        New Item("several mushrooms", "Junk", "Common", "", "", ""),
        New Item("an apple", "Junk", "Common", "", "", ""),
        New Item("a pouch of salt", "Junk", "Common", "", "", ""),
        New Item("a map of a nearby castle", "Junk", "Uncommon", "", "", ""),
        New Item("a drafting compass", "Junk", "Uncommon", "", "", ""),
        New Item("a vial of lightning", "Junk", "Uncommon", "", "", ""),
        New Item("a vial of quicksilver", "Junk", "Uncommon", "", "", ""),
        New Item("a pouch of viridian powder", "Junk", "Uncommon", "", "", ""),
        New Item("a vial of perfume", "Junk", "Uncommon", "", "", ""),
        New Item("a contract for services", "Junk", "Uncommon", "", "", ""),
        New Item("a page torn from a spellbook", "Junk", "Uncommon", "", "", ""),
        New Item("a map of the local area", "Junk", "Uncommon", "", "", ""),
        New Item("a sling and 10 bullets", "Junk", "Uncommon", "", "", ""),
        New Item("the deed to a small property", "Junk", "Uncommon", "", "", ""),
        New Item("a two-headed copper coin", "Junk", "Uncommon", "", "", ""),
        New Item("a pouch of multi-colored chalk", "Junk", "Uncommon", "", "", ""),
        New Item("a mysterious clockwork device", "Junk", "Uncommon", "", "", ""),
        New Item("spectacles", "Junk", "Uncommon", "", "", ""),
        New Item("a set of runestones wrapped in cloth", "Junk", "Uncommon", "", "", ""),
        New Item("an ominous warning", "Junk", "Uncommon", "", "", ""),
        New Item("a set of merchant's weights", "Junk", "Uncommon", "", "", ""),
        New Item("a pouch of topaz powder", "Junk", "Uncommon", "", "", ""),
        New Item("a lock of golden hair", "Junk", "Uncommon", "", "", ""),
        New Item("a small iron ingot", "Junk", "Uncommon", "", "", ""),
        New Item("a pewter key", "Junk", "Uncommon", "", "", ""),
        New Item("a steel key", "Junk", "Uncommon", "", "", ""),
        New Item("a bottle of honey", "Junk", "Uncommon", "", "", ""),
        New Item("a dragon's tooth", "Junk", "Uncommon", "", "", ""),
        New Item("a pair of dice engraved with runes", "Junk", "Uncommon", "", "", ""),
        New Item("a vial of ashes", "Junk", "Uncommon", "", "", ""),
        New Item("an iridescent scale", "Junk", "Uncommon", "", "", ""),
        New Item("a vial of ink", "Junk", "Uncommon", "", "", ""),
        New Item("a signet ring", "Junk", "Uncommon", "", "", ""),
        New Item("a mysterious clockwork device", "Junk", "Uncommon", "", "", ""),
        New Item("a lock", "Junk", "Uncommon", "", "", ""),
        New Item("a blob of wax", "Junk", "Uncommon", "", "", ""),
        New Item("an empty vial", "Junk", "Uncommon", "", "", ""),
        New Item("a trilobite fossil", "Junk", "Uncommon", "", "", ""),
        New Item("a necklace of animal teeth", "Junk", "Uncommon", "", "", ""),
        New Item("a small ingot of electrum", "Junk", "Uncommon", "", "", ""),
        New Item("a tattered map of the Tomb of Demonic Chaos", "Junk", "Uncommon", "", "", ""),
        New Item("a lead amulet", "Junk", "Uncommon", "", "", ""),
        New Item("a tiny figurine of a rat", "Junk", "Uncommon", "", "", ""),
        New Item("a patch of chainmail", "Junk", "Uncommon", "", "", ""),
        New Item("a pouch of candies", "Junk", "Uncommon", "", "", ""),
        New Item("a patch of rabbit fur", "Junk", "Uncommon", "", "", ""),
        New Item("a journal of heresies", "Junk", "Uncommon", "", "", ""),
        New Item("a crystal of sulphur", "Junk", "Uncommon", "", "", ""),
        New Item("a lock of gray hair", "Junk", "Uncommon", "", "", ""),
        New Item("a pouch of bronze powder", "Junk", "Uncommon", "", "", ""),
        New Item("a handkerchief", "Junk", "Uncommon", "", "", ""),
        New Item("a pouch of pixie dust", "Junk", "Rare", "", "", ""),
        New Item("a small meteorite", "Junk", "Rare", "", "", ""),
        New Item("a goblin key (can lock any door)", "Junk", "Rare", "", "", ""),
        New Item("an ivory game piece", "Junk", "Rare", "", "", ""),
        New Item("written directions to the Vaults of Sabaalu", "Junk", "Rare", "", "", ""),
        New Item("a tiny figurine of a male gnome", "Junk", "Rare", "", "", ""),
        New Item("a tiny figurine of an octopus", "Junk", "Rare", "", "", ""),
        New Item("a small lodestone", "Junk", "Rare", "", "", ""),
        New Item("a cloth game board and wooden tokens", "Junk", "Rare", "", "", ""),
        New Item("a vial of blood", "Junk", "Rare", "", "", ""),
        New Item("a lock of emerald hair", "Junk", "Rare", "", "", ""),
        New Item("a tiny figurine of a god of darkness", "Junk", "Rare", "", "", ""),
        New Item("a copper key", "Junk", "Rare", "", "", ""),
        New Item("a flask of wine", "Junk", "Rare", "", "", ""),
        New Item("an Explosive Rune", "Junk", "Rare", "", "", ""),
        New Item("a gold key", "Junk", "Rare", "", "", "")
    }
End Module