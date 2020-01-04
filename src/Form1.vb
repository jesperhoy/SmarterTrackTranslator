Imports System.ComponentModel

Public Class Form1
  Dim x As String
  Dim Data As New List(Of TlItem)
  Dim TranslationFileName As String = Nothing
  Dim CombinedFileName As String = Nothing

  Private Sub grid1_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles grid1.CellValueNeeded
    Select Case e.ColumnIndex
      Case 0 'id
        e.Value = Data(e.RowIndex).ID
      Case 1 'english
        e.Value = Data(e.RowIndex).English
      Case 2 'translated
        e.Value = Data(e.RowIndex).Translated
        'Case 3 ' button
        '  e.Value = "..."
    End Select
  End Sub

  Private Sub grid1_CellValuePushed(sender As Object, e As DataGridViewCellValueEventArgs) Handles grid1.CellValuePushed
    Data(e.RowIndex).Translated = CStr(e.Value)
    UpdateStatusBar()
  End Sub

  Private Sub mnuOpenEnglish_Click(sender As Object, e As EventArgs) Handles mnuOpenEnglish.Click
    OpenFileDialog1.Title = "Open English"
    OpenFileDialog1.FileName = "en.xml"
    If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then Exit Sub

    Dim x = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
    Dim d = New Xml.XmlDocument()
    d.LoadXml(x)
    Dim NewData = New List(Of TlItem)
    For Each n As Xml.XmlNode In d.GetElementsByTagName("root")(0).ChildNodes
      If n.NodeType <> Xml.XmlNodeType.Element Then Continue For 'skip comments and white space
      If n.Name <> "resource" Then Continue For
      NewData.Add(New TlItem With {.ID = n.Attributes("name").Value, .English = n.InnerText})
    Next
    If NewData.Count = 0 Then
      MessageBox.Show("File did not contain any translation entries")
      Exit Sub
    End If
    Data = NewData
    TranslationFileName = Nothing
    grid1.RowCount = Data.Count
    grid1.Refresh()
    UpdateStatusBar()
    mnuOpenTranslation.Enabled = True
  End Sub

  Private Sub UpdateStatusBar()
    lblTotal.Text = "Total: " & Data.Count
    Dim ct = 0
    For Each itm In Data
      If Not String.IsNullOrEmpty(itm.Translated) Then ct += 1
    Next
    lblTranslated.Text = "Translated: " & ct

    mnuSaveTranslation.Enabled = ct > 0
    mnuSaveTranslationAs.Enabled = ct > 0
    mnuSaveCombined.Enabled = ct > 0
    mnuSaveCombinedAs.Enabled = ct > 0
  End Sub

  Class TlItem
    Public ID As String
    Public English As String
    Public Translated As String = ""
  End Class

  Private Sub mnuSaveTranslationAs_Click(sender As Object, e As EventArgs) Handles mnuSaveTranslationAs.Click
    SaveFileDialog1.Title = "Save Translation"
    SaveFileDialog1.FileName = TranslationFileName
    If SaveFileDialog1.ShowDialog <> DialogResult.OK Then Exit Sub
    TranslationFileName = SaveFileDialog1.FileName
    mnuSaveTranslation_Click(sender, e)
  End Sub

  Private Sub mnuSaveTranslation_Click(sender As Object, e As EventArgs) Handles mnuSaveTranslation.Click
    If String.IsNullOrEmpty(TranslationFileName) Then mnuSaveTranslationAs_Click(sender, e) : Exit Sub
    Dim d = New Xml.XmlDocument()
    d.AppendChild(d.CreateXmlDeclaration("1.0", "utf-8", Nothing))
    Dim root = d.CreateElement("root")
    d.AppendChild(root)
    Dim el As Xml.XmlElement
    For Each itm In Data
      If String.IsNullOrEmpty(itm.Translated) Then Continue For
      el = d.CreateElement("resource")
      el.SetAttribute("name", itm.ID)
      el.InnerText = itm.Translated
      root.AppendChild(el)
    Next
    d.Save(TranslationFileName)
  End Sub


  Private Sub mnuOpenTranslation_Click(sender As Object, e As EventArgs) Handles mnuOpenTranslation.Click
    OpenFileDialog1.Title = "Open Translation"
    OpenFileDialog1.FileName = ""
    If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then Exit Sub
    Dim x = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
    Dim d = New Xml.XmlDocument()
    d.LoadXml(x)
    Dim dict = New Dictionary(Of String, TlItem)
    Dim itm As TlItem = Nothing
    Dim NewData As New List(Of TlItem)
    Dim NewItm As TlItem
    For Each itm In Data
      NewItm = New TlItem With {.ID = itm.ID, .English = itm.English}
      NewData.Add(NewItm)
      dict.Add(itm.ID, NewItm)
    Next
    Dim ct = 0
    For Each n As Xml.XmlNode In d.GetElementsByTagName("root")(0).ChildNodes
      If n.NodeType <> Xml.XmlNodeType.Element Then Continue For 'skip comments and white space
      If n.Name <> "resource" Then Continue For
      If Not dict.TryGetValue(n.Attributes("name").Value, itm) Then Continue For
      itm.Translated = n.InnerText
      ct += 1
    Next
    If ct = 0 Then
      MessageBox.Show("File did not contain any matching translation entries")
      Exit Sub
    End If
    TranslationFileName = OpenFileDialog1.FileName
    Data = NewData
    grid1.Refresh()
    UpdateStatusBar()
  End Sub

  Private Sub mnuSaveCombinedAs_Click(sender As Object, e As EventArgs) Handles mnuSaveCombinedAs.Click
    SaveFileDialog1.Title = "Save Combined"
    SaveFileDialog1.FileName = CombinedFileName
    If SaveFileDialog1.ShowDialog <> DialogResult.OK Then Exit Sub
    CombinedFileName = SaveFileDialog1.FileName
    mnuSaveCombined_Click(sender, e)
  End Sub

  Private Sub mnuSaveCombined_Click(sender As Object, e As EventArgs) Handles mnuSaveCombined.Click
    If String.IsNullOrEmpty(CombinedFileName) Then mnuSaveCombinedAs_Click(sender, e) : Exit Sub
    Dim d = New Xml.XmlDocument()
    d.AppendChild(d.CreateXmlDeclaration("1.0", "utf-8", Nothing))
    Dim root = d.CreateElement("root")
    d.AppendChild(root)
    Dim el As Xml.XmlElement
    For Each itm In Data
      el = d.CreateElement("resource")
      el.SetAttribute("name", itm.ID)
      If String.IsNullOrEmpty(itm.Translated) Then
        el.InnerText = itm.English
      Else
        el.InnerText = itm.Translated
      End If
      root.AppendChild(el)
    Next
    d.Save(CombinedFileName)
  End Sub

  Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
    AboutBox1.ShowDialog()
  End Sub

  Private Sub btnFindNext_Click(sender As Object, e As EventArgs) Handles btnFindNext.Click
    DoFind(False)
  End Sub
  Private Sub btnFindPrev_Click(sender As Object, e As EventArgs) Handles btnFindPrev.Click
    DoFind(True)
  End Sub

  Private Sub DoFind(prev As Boolean)
    Dim fv = txtFind.Text.Trim
    If fv = "" Then Exit Sub

    Dim CurRow = grid1.CurrentCell.RowIndex
    Dim CurCol = grid1.CurrentCell.ColumnIndex
    Dim v As String = Nothing

mark1:

    If prev Then
      If CurRow = 0 AndAlso CurCol = 0 Then MsgBox("Cannot find """ & fv & """") : Exit Sub
      CurCol -= 1
      If CurCol < 0 Then CurCol = 2 : CurRow -= 1
    Else
      If CurRow = Data.Count - 1 AndAlso CurCol >= 2 Then MsgBox("Cannot find """ & fv & """") : Exit Sub
      CurCol += 1
      If CurCol > 2 Then CurCol = 0 : CurRow += 1
    End If

    Select Case CurCol
      Case 0
        If Not chkSearchID.Checked Then GoTo mark1
        v = Data(CurRow).ID
      Case 1
        If Not chkSearchEnglish.Checked Then GoTo mark1
        v = Data(CurRow).English
      Case 2
        If Not chkSearchTranslated.Checked Then GoTo mark1
        v = Data(CurRow).Translated
    End Select

    If chkMatchExact.Checked Then
      If chkMatchCase.Checked Then
        If v <> fv Then GoTo mark1
      Else
        If Not String.Equals(v, fv, StringComparison.CurrentCultureIgnoreCase) Then GoTo mark1
      End If
    Else
      If chkMatchCase.Checked Then
        If v.IndexOf(fv) < 0 Then GoTo mark1
      Else
        If v.IndexOf(fv, StringComparison.CurrentCultureIgnoreCase) < 0 Then GoTo mark1
      End If
    End If

    grid1.CurrentCell = grid1.Rows(CurRow).Cells(CurCol)
  End Sub

  Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
    If e.KeyCode <> Keys.F3 Then Exit Sub
    If e.Modifiers = Keys.None Then DoFind(False) : Exit Sub
    If e.Modifiers = Keys.Shift Then DoFind(True) : Exit Sub
  End Sub

  Private Sub grid1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid1.CellBeginEdit
    Dim itm = Data(e.RowIndex)
    If Not itm.English.Contains(vbLf) Then Exit Sub
    e.Cancel = True
    MsgBox("Multi-line edit is not yet implemented", MsgBoxStyle.Exclamation, "Multi-line edit")
  End Sub

  'Private Sub grid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid1.CellClick
  '  If e.ColumnIndex <> 3 OrElse e.RowIndex < 0 Then Exit Sub
  '  MsgBox("edit")
  'End Sub

End Class
