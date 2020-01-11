<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
    Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenTranslation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveTranslation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveTranslationAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveCombined = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveCombinedAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTranslated = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkMatchExact = New System.Windows.Forms.CheckBox()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnFindPrev = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSearchID = New System.Windows.Forms.CheckBox()
        Me.chkSearchTranslated = New System.Windows.Forms.CheckBox()
        Me.chkSearchEnglish = New System.Windows.Forms.CheckBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMatchCase = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEnglish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTranslated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.chkSearchNotes = New System.Windows.Forms.CheckBox()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.AllowUserToResizeRows = False
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colEnglish, Me.colTranslated, Me.Column2, Me.Column1})
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid1.Location = New System.Drawing.Point(3, 3)
        Me.grid1.Name = "grid1"
        Me.grid1.RowHeadersVisible = False
        Me.grid1.RowHeadersWidth = 35
        Me.grid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid1.RowTemplate.Height = 24
        Me.grid1.Size = New System.Drawing.Size(960, 462)
        Me.grid1.TabIndex = 0
        Me.grid1.VirtualMode = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(966, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenEnglish, Me.mnuOpenTranslation, Me.mnuSaveTranslation, Me.mnuSaveTranslationAs, Me.mnuSaveCombined, Me.mnuSaveCombinedAs})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuOpenEnglish
        '
        Me.mnuOpenEnglish.Name = "mnuOpenEnglish"
        Me.mnuOpenEnglish.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuOpenEnglish.Size = New System.Drawing.Size(314, 26)
        Me.mnuOpenEnglish.Text = "Open English..."
        '
        'mnuOpenTranslation
        '
        Me.mnuOpenTranslation.Enabled = False
        Me.mnuOpenTranslation.Name = "mnuOpenTranslation"
        Me.mnuOpenTranslation.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpenTranslation.Size = New System.Drawing.Size(314, 26)
        Me.mnuOpenTranslation.Text = "Open translation..."
        '
        'mnuSaveTranslation
        '
        Me.mnuSaveTranslation.Enabled = False
        Me.mnuSaveTranslation.Name = "mnuSaveTranslation"
        Me.mnuSaveTranslation.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSaveTranslation.Size = New System.Drawing.Size(314, 26)
        Me.mnuSaveTranslation.Text = "Save translation..."
        '
        'mnuSaveTranslationAs
        '
        Me.mnuSaveTranslationAs.Enabled = False
        Me.mnuSaveTranslationAs.Name = "mnuSaveTranslationAs"
        Me.mnuSaveTranslationAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSaveTranslationAs.Size = New System.Drawing.Size(314, 26)
        Me.mnuSaveTranslationAs.Text = "Save translation as..."
        '
        'mnuSaveCombined
        '
        Me.mnuSaveCombined.Enabled = False
        Me.mnuSaveCombined.Name = "mnuSaveCombined"
        Me.mnuSaveCombined.Size = New System.Drawing.Size(314, 26)
        Me.mnuSaveCombined.Text = "Save combined..."
        '
        'mnuSaveCombinedAs
        '
        Me.mnuSaveCombinedAs.Enabled = False
        Me.mnuSaveCombinedAs.Name = "mnuSaveCombinedAs"
        Me.mnuSaveCombinedAs.Size = New System.Drawing.Size(314, 26)
        Me.mnuSaveCombinedAs.Text = "Save combined as..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(301, 26)
        Me.mnuAbout.Text = "About SmarterTrack Translator..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotal, Me.lblTranslated})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 553)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(966, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 20)
        Me.lblTotal.Text = "Total: 0"
        '
        'lblTranslated
        '
        Me.lblTranslated.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblTranslated.Name = "lblTranslated"
        Me.lblTranslated.Size = New System.Drawing.Size(92, 20)
        Me.lblTranslated.Text = "Translated: 0"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "XML files|*.xml"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xml"
        Me.SaveFileDialog1.Filter = "XML files|*.xml"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.chkMatchExact)
        Me.Panel1.Controls.Add(Me.btnFindNext)
        Me.Panel1.Controls.Add(Me.btnFindPrev)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.chkSearchID)
        Me.Panel1.Controls.Add(Me.chkSearchTranslated)
        Me.Panel1.Controls.Add(Me.chkSearchEnglish)
        Me.Panel1.Controls.Add(Me.txtFind)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chkMatchCase)
        Me.Panel1.Controls.Add(Me.chkSearchNotes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 471)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 79)
        Me.Panel1.TabIndex = 3
        '
        'chkMatchExact
        '
        Me.chkMatchExact.AutoSize = True
        Me.chkMatchExact.Location = New System.Drawing.Point(128, 44)
        Me.chkMatchExact.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.chkMatchExact.Name = "chkMatchExact"
        Me.chkMatchExact.Size = New System.Drawing.Size(106, 21)
        Me.chkMatchExact.TabIndex = 7
        Me.chkMatchExact.Text = "Exact match"
        Me.chkMatchExact.UseVisualStyleBackColor = True
        '
        'btnFindNext
        '
        Me.btnFindNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindNext.Location = New System.Drawing.Point(803, 42)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(150, 30)
        Me.btnFindNext.TabIndex = 14
        Me.btnFindNext.Text = "Next (F3)"
        Me.btnFindNext.UseVisualStyleBackColor = True
        '
        'btnFindPrev
        '
        Me.btnFindPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindPrev.Location = New System.Drawing.Point(803, 6)
        Me.btnFindPrev.Name = "btnFindPrev"
        Me.btnFindPrev.Size = New System.Drawing.Size(150, 30)
        Me.btnFindPrev.TabIndex = 13
        Me.btnFindPrev.Text = "Previous (Shift+F3)"
        Me.btnFindPrev.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search in:"
        '
        'chkSearchID
        '
        Me.chkSearchID.AutoSize = True
        Me.chkSearchID.Checked = True
        Me.chkSearchID.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchID.Location = New System.Drawing.Point(328, 44)
        Me.chkSearchID.Name = "chkSearchID"
        Me.chkSearchID.Size = New System.Drawing.Size(43, 21)
        Me.chkSearchID.TabIndex = 9
        Me.chkSearchID.Text = "ID"
        Me.chkSearchID.UseVisualStyleBackColor = True
        '
        'chkSearchTranslated
        '
        Me.chkSearchTranslated.AutoSize = True
        Me.chkSearchTranslated.Checked = True
        Me.chkSearchTranslated.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchTranslated.Location = New System.Drawing.Point(479, 44)
        Me.chkSearchTranslated.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.chkSearchTranslated.Name = "chkSearchTranslated"
        Me.chkSearchTranslated.Size = New System.Drawing.Size(98, 21)
        Me.chkSearchTranslated.TabIndex = 11
        Me.chkSearchTranslated.Text = "Translated"
        Me.chkSearchTranslated.UseVisualStyleBackColor = True
        '
        'chkSearchEnglish
        '
        Me.chkSearchEnglish.AutoSize = True
        Me.chkSearchEnglish.Checked = True
        Me.chkSearchEnglish.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchEnglish.Location = New System.Drawing.Point(387, 44)
        Me.chkSearchEnglish.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.chkSearchEnglish.Name = "chkSearchEnglish"
        Me.chkSearchEnglish.Size = New System.Drawing.Size(76, 21)
        Me.chkSearchEnglish.TabIndex = 10
        Me.chkSearchEnglish.Text = "English"
        Me.chkSearchEnglish.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFind.Location = New System.Drawing.Point(50, 10)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(704, 22)
        Me.txtFind.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Find:"
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.Location = New System.Drawing.Point(10, 44)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(102, 21)
        Me.chkMatchCase.TabIndex = 6
        Me.chkMatchCase.Text = "Match case"
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.grid1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(966, 579)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.MinimumWidth = 6
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 150
        '
        'colEnglish
        '
        Me.colEnglish.HeaderText = "English"
        Me.colEnglish.MinimumWidth = 6
        Me.colEnglish.Name = "colEnglish"
        Me.colEnglish.ReadOnly = True
        Me.colEnglish.Width = 250
        '
        'colTranslated
        '
        Me.colTranslated.HeaderText = "Translated"
        Me.colTranslated.MinimumWidth = 6
        Me.colTranslated.Name = "colTranslated"
        Me.colTranslated.Width = 250
        '
        'Column2
        '
        Me.Column2.HeaderText = "Notes (private)"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 250
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 25
        '
        'chkSearchNotes
        '
        Me.chkSearchNotes.AutoSize = True
        Me.chkSearchNotes.Checked = True
        Me.chkSearchNotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchNotes.Location = New System.Drawing.Point(593, 44)
        Me.chkSearchNotes.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.chkSearchNotes.Name = "chkSearchNotes"
        Me.chkSearchNotes.Size = New System.Drawing.Size(67, 21)
        Me.chkSearchNotes.TabIndex = 12
        Me.chkSearchNotes.Text = "Notes"
        Me.chkSearchNotes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 607)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(850, 300)
        Me.Name = "Form1"
        Me.Text = "SmarterTrack Translator"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid1 As DataGridView
  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents mnuOpenEnglish As ToolStripMenuItem
  Friend WithEvents mnuOpenTranslation As ToolStripMenuItem
  Friend WithEvents mnuSaveTranslation As ToolStripMenuItem
  Friend WithEvents mnuSaveCombined As ToolStripMenuItem
  Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents mnuAbout As ToolStripMenuItem
  Friend WithEvents mnuSaveTranslationAs As ToolStripMenuItem
  Friend WithEvents mnuSaveCombinedAs As ToolStripMenuItem
  Friend WithEvents StatusStrip1 As StatusStrip
  Friend WithEvents lblTranslated As ToolStripStatusLabel
  Friend WithEvents lblTotal As ToolStripStatusLabel
  Friend WithEvents OpenFileDialog1 As OpenFileDialog
  Friend WithEvents SaveFileDialog1 As SaveFileDialog
  Friend WithEvents Panel1 As Panel
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents txtFind As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents chkMatchCase As CheckBox
  Friend WithEvents Label2 As Label
  Friend WithEvents chkSearchID As CheckBox
  Friend WithEvents chkSearchTranslated As CheckBox
  Friend WithEvents chkSearchEnglish As CheckBox
  Friend WithEvents btnFindNext As Button
  Friend WithEvents btnFindPrev As Button
  Friend WithEvents chkMatchExact As CheckBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colEnglish As DataGridViewTextBoxColumn
    Friend WithEvents colTranslated As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents chkSearchNotes As CheckBox
End Class
