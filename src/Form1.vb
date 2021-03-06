﻿Imports System.ComponentModel

Public Class Form1
  Dim Data As New List(Of TlItem)
  Dim TranslationFileName As String = Nothing
  Dim CombinedFileName As String = Nothing
  Dim DataChanged As Boolean = False

  Class TlItem
    Public ID As String
    Public English As String
    Public Translated As String = ""
    Public Notes As String = ""
  End Class

  Private Function CellValue(row As Integer, col As Integer) As String
    Dim Itm = Data(row)
    Select Case col
      Case 0 'id
        Return Itm.ID
      Case 1 'english
        Return Itm.English
      Case 2 'translated
        Return Itm.Translated
      Case 3 'notes
        Return Itm.Notes
      Case Else
        Throw New Exception("Invalid column index")
    End Select
  End Function

  Private Sub grid1_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles grid1.CellValueNeeded
    If e.ColumnIndex = 4 Then e.Value = "..." : Exit Sub
    e.Value = CellValue(e.RowIndex, e.ColumnIndex)
  End Sub

  Private Sub grid1_CellValuePushed(sender As Object, e As DataGridViewCellValueEventArgs) Handles grid1.CellValuePushed
    Dim NewValue = If(e.Value Is Nothing, "", CStr(e.Value).Trim)
    If e.ColumnIndex = 2 Then
      If NewValue = Data(e.RowIndex).Translated Then Exit Sub
      Data(e.RowIndex).Translated = NewValue
    Else '3
      If NewValue = Data(e.RowIndex).Notes Then Exit Sub
      Data(e.RowIndex).Notes = NewValue
    End If
    DataChanged = True
    UpdateTitleBar()
    UpdateStatusBar()
  End Sub

  Private Sub mnuOpenEnglish_Click(sender As Object, e As EventArgs) Handles mnuOpenEnglish.Click
    OpenFileDialog1.Title = "Open English"
    OpenFileDialog1.FileName = "en.xml"
    OpenFileDialog1.Filter = "XML files|*.xml"
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
    UpdateTitleBar()
    grid1.RowCount = Data.Count
    grid1.Refresh()
    UpdateStatusBar()
    mnuOpenTranslation.Enabled = True
    mnuFind.Enabled = True
    mnuFindNext.Enabled = True
    mnuFindPrev.Enabled = True
    mnuNextEmpty.Enabled = True
    mnuPrevEmpty.Enabled = True
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

  Private Sub mnuSaveTranslationAs_Click(sender As Object, e As EventArgs) Handles mnuSaveTranslationAs.Click
    SaveFileDialog1.Title = "Save Translation"
    SaveFileDialog1.FileName = TranslationFileName
    SaveFileDialog1.Filter = "Translation files|*.translation.xml"
    If SaveFileDialog1.ShowDialog <> DialogResult.OK Then Exit Sub
    TranslationFileName = SaveFileDialog1.FileName
    If Not TranslationFileName.EndsWith(".translation.xml", StringComparison.InvariantCultureIgnoreCase) Then TranslationFileName &= ".translation.xml"
    mnuSaveTranslation_Click(sender, e)
  End Sub

  Sub UpdateTitleBar()
    Dim x = "SmarterTrack Translator"
    If Not String.IsNullOrEmpty(TranslationFileName) Then
      x = TranslationFileName.Substring(TranslationFileName.LastIndexOf("\") + 1) & " - " & x
      If DataChanged Then x = "*" & x
    End If
    Me.Text = x
  End Sub

  Private Sub mnuSaveTranslation_Click(sender As Object, e As EventArgs) Handles mnuSaveTranslation.Click
    If String.IsNullOrEmpty(TranslationFileName) Then mnuSaveTranslationAs_Click(sender, e) : Exit Sub
    Dim d = New Xml.XmlDocument()
    d.AppendChild(d.CreateXmlDeclaration("1.0", "utf-8", Nothing))
    Dim root = d.CreateElement("root")
    d.AppendChild(root)
    Dim el As Xml.XmlElement
    For Each itm In Data
      If String.IsNullOrEmpty(itm.Translated) AndAlso
       String.IsNullOrEmpty(itm.Notes) Then Continue For
      el = d.CreateElement("resource")
      el.SetAttribute("name", itm.ID)
      If Not String.IsNullOrEmpty(itm.Notes) Then el.SetAttribute("notes", itm.Notes)
      el.InnerText = itm.Translated
      root.AppendChild(el)
    Next
    d.Save(TranslationFileName)
    DataChanged = False
    UpdateTitleBar()
  End Sub

  Private Sub mnuOpenTranslation_Click(sender As Object, e As EventArgs) Handles mnuOpenTranslation.Click
    OpenFileDialog1.Title = "Open Translation"
    OpenFileDialog1.FileName = ""
    OpenFileDialog1.Filter = "Translation files|*.translation.xml"
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
    Dim na As Xml.XmlAttribute
    For Each n As Xml.XmlNode In d.GetElementsByTagName("root")(0).ChildNodes
      If n.NodeType <> Xml.XmlNodeType.Element Then Continue For 'skip comments and white space
      If n.Name <> "resource" Then Continue For
      If Not dict.TryGetValue(n.Attributes("name").Value, itm) Then Continue For
      na = n.Attributes("notes")
      If na IsNot Nothing Then itm.Notes = na.Value
      itm.Translated = n.InnerText
      ct += 1
    Next
    If ct = 0 Then
      MessageBox.Show("File did not contain any matching translation entries")
      Exit Sub
    End If
    TranslationFileName = OpenFileDialog1.FileName
    UpdateTitleBar()
    Data = NewData
    grid1.Refresh()
    UpdateStatusBar()
  End Sub

  Private Sub mnuSaveCombinedAs_Click(sender As Object, e As EventArgs) Handles mnuSaveCombinedAs.Click
    SaveFileDialog1.Title = "Save Combined"
    SaveFileDialog1.Filter = "XML files|*.xml"
    SaveFileDialog1.FileName = CombinedFileName
mark1:
    If SaveFileDialog1.ShowDialog <> DialogResult.OK Then Exit Sub
    If SaveFileDialog1.FileName.EndsWith(".translation.xml", StringComparison.InvariantCultureIgnoreCase) Then
      MessageBox.Show("Cannot save combined with a .translation.xml extension", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      GoTo mark1
    End If
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

  Public Sub DoFind(prev As Boolean)
    If Data Is Nothing OrElse Data.Count = 0 Then Exit Sub
    Dim fv = frmFind.txtFind.Text.Trim
    If fv = "" Then Exit Sub

    Dim c = grid1.CurrentCell
    If c Is Nothing Then MsgBox("Not currentcell") : Exit Sub
    Dim CurRow = c.RowIndex
    Dim CurCol = c.ColumnIndex
    Dim v As String = Nothing

mark1:
    If prev Then
      If CurRow = 0 AndAlso CurCol = 0 Then
        If Not frmFind.chkWrapAround.Checked Then MsgBox("Cannot find """ & fv & """") : Exit Sub
        CurRow = Data.Count - 1 : CurCol = 3
      Else
        CurCol -= 1
        If CurCol < 0 Then CurCol = 3 : CurRow -= 1
      End If
    Else
      If CurRow = Data.Count - 1 AndAlso CurCol >= 3 Then
        If Not frmFind.chkWrapAround.Checked Then MsgBox("Cannot find """ & fv & """") : Exit Sub
        CurRow = 0 : CurCol = 0
      Else
        CurCol += 1
        If CurCol > 3 Then CurCol = 0 : CurRow += 1
      End If
    End If

    Select Case CurCol
      Case 0
        If Not frmFind.chkSearchID.Checked Then GoTo mark1
        v = Data(CurRow).ID
      Case 1
        If Not frmFind.chkSearchEnglish.Checked Then GoTo mark1
        v = Data(CurRow).English
      Case 2
        If Not frmFind.chkSearchTranslated.Checked Then GoTo mark1
        v = Data(CurRow).Translated
      Case 3
        If Not frmFind.chkSearchNotes.Checked Then GoTo mark1
        v = Data(CurRow).Notes
    End Select

    If frmFind.chkMatchExact.Checked Then
      If frmFind.chkMatchCase.Checked Then
        If v <> fv Then GoTo mark1
      Else
        If Not String.Equals(v, fv, StringComparison.CurrentCultureIgnoreCase) Then GoTo mark1
      End If
    Else
      If frmFind.chkMatchCase.Checked Then
        If v.IndexOf(fv) < 0 Then GoTo mark1
      Else
        If v.IndexOf(fv, StringComparison.CurrentCultureIgnoreCase) < 0 Then GoTo mark1
      End If
    End If

    grid1.CurrentCell = grid1.Rows(CurRow).Cells(CurCol)
  End Sub

  Private Sub grid1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid1.CellBeginEdit
    Dim itm = Data(e.RowIndex)
    If Not itm.English.Contains(vbLf) Then Exit Sub
    e.Cancel = True
    grid1_CellClick(sender, New DataGridViewCellEventArgs(4, e.RowIndex))
  End Sub

  Private Sub grid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid1.CellClick
    If e.RowIndex < 0 OrElse e.ColumnIndex <> 4 Then Exit Sub
    Dim f = New frmEdit
    Dim itm = Data(e.RowIndex)
    f.txtID.Text = itm.ID
    f.txtEnglish.Text = itm.English
    f.txtTranslated.Text = itm.Translated
    f.txtNotes.Text = itm.Notes
    If f.ShowDialog(Me) <> DialogResult.OK Then Exit Sub
    Dim New1 = f.txtTranslated.Text.Trim
    Dim New2 = f.txtNotes.Text.Trim
    If New1 = itm.Translated AndAlso New2 = itm.Notes Then Exit Sub
    itm.Translated = New1
    itm.Notes = New2
    grid1.InvalidateRow(e.RowIndex)
    DataChanged = True
    UpdateTitleBar()
    UpdateStatusBar()
  End Sub

  Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If e.CloseReason <> CloseReason.UserClosing OrElse
      Not DataChanged Then Exit Sub
    Dim r = MessageBox.Show("Do you want to save your changes?",
                    Me.Text,
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1)
    If r = DialogResult.No Then Exit Sub
    If r = DialogResult.Cancel Then e.Cancel = True : Exit Sub
    mnuSaveTranslation_Click(Nothing, Nothing)
    If DataChanged Then e.Cancel = True
  End Sub

  Private Sub mnuFind_Click(sender As Object, e As EventArgs) Handles mnuFind.Click
    If Data Is Nothing OrElse Data.Count = 0 Then Exit Sub

    Dim c = grid1.CurrentCell
    If c.ColumnIndex < 4 Then
      Dim v = CellValue(c.RowIndex, c.ColumnIndex)
      If Not String.IsNullOrEmpty(v) Then frmFind.txtFind.Text = v
    End If

    frmFind.Owner = Me
    frmFind.Show()
    frmFind.txtFind.SelectAll()
    frmFind.txtFind.Focus()
  End Sub

  Private Sub mnuFindNext_Click(sender As Object, e As EventArgs) Handles mnuFindNext.Click
    If frmFind.txtFind.Text.Trim = "" Then frmFind.Show() : Exit Sub
    DoFind(False)
    End Sub

  Private Sub mnuFindPrev_Click(sender As Object, e As EventArgs) Handles mnuFindPrev.Click
    If frmFind.txtFind.Text.Trim = "" Then frmFind.Show() : Exit Sub
    DoFind(True)
  End Sub

  Private Sub mnuNextEmpty_Click(sender As Object, e As EventArgs) Handles mnuNextEmpty.Click
    GoEmpty(False)
  End Sub

  Private Sub mnuPrevEmpty_Click(sender As Object, e As EventArgs) Handles mnuPrevEmpty.Click
    GoEmpty(True)
  End Sub

  Public Sub GoEmpty(prev As Boolean)
    If Data Is Nothing OrElse Data.Count = 0 Then Exit Sub
    Dim c = grid1.CurrentCell
    If c Is Nothing Then MsgBox("Not currentcell") : Exit Sub
    Dim CurRow = c.RowIndex
    Dim ct = 0
mark1:
    If prev Then
      If CurRow = 0 Then CurRow = Data.Count - 1 Else CurRow -= 1
    Else
      If CurRow = Data.Count - 1 Then CurRow = 0 Else CurRow += 1
    End If
    ct += 1
    If Not String.IsNullOrEmpty(Data(CurRow).Translated) Then
      If ct >= Data.Count Then MsgBox("There are no empty items") : Exit Sub
      GoTo mark1
    End If
    grid1.CurrentCell = grid1.Rows(CurRow).Cells(2)
  End Sub

End Class
