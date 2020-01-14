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
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEnglish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTranslated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenTranslation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveTranslation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveTranslationAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveCombined = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveCombinedAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindPrev = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuNextEmpty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrevEmpty = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTranslated = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
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
        Me.grid1.Size = New System.Drawing.Size(960, 547)
        Me.grid1.TabIndex = 0
        Me.grid1.VirtualMode = True
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
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
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
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFind, Me.mnuFindNext, Me.mnuFindPrev, Me.ToolStripMenuItem1, Me.mnuNextEmpty, Me.mnuPrevEmpty})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFind.Size = New System.Drawing.Size(257, 26)
        Me.mnuFind.Text = "Find..."
        '
        'mnuFindNext
        '
        Me.mnuFindNext.Enabled = False
        Me.mnuFindNext.Name = "mnuFindNext"
        Me.mnuFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuFindNext.Size = New System.Drawing.Size(257, 26)
        Me.mnuFindNext.Text = "Find Next"
        '
        'mnuFindPrev
        '
        Me.mnuFindPrev.Enabled = False
        Me.mnuFindPrev.Name = "mnuFindPrev"
        Me.mnuFindPrev.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.mnuFindPrev.Size = New System.Drawing.Size(257, 26)
        Me.mnuFindPrev.Text = "Find Previous"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(254, 6)
        '
        'mnuNextEmpty
        '
        Me.mnuNextEmpty.Enabled = False
        Me.mnuNextEmpty.Name = "mnuNextEmpty"
        Me.mnuNextEmpty.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuNextEmpty.Size = New System.Drawing.Size(257, 26)
        Me.mnuNextEmpty.Text = "Next Empty"
        '
        'mnuPrevEmpty
        '
        Me.mnuPrevEmpty.Enabled = False
        Me.mnuPrevEmpty.Name = "mnuPrevEmpty"
        Me.mnuPrevEmpty.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.mnuPrevEmpty.Size = New System.Drawing.Size(257, 26)
        Me.mnuPrevEmpty.Text = "Previous Empty"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.grid1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(966, 579)
        Me.TableLayoutPanel1.TabIndex = 4
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colEnglish As DataGridViewTextBoxColumn
    Friend WithEvents colTranslated As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFind As ToolStripMenuItem
    Friend WithEvents mnuFindNext As ToolStripMenuItem
    Friend WithEvents mnuFindPrev As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuNextEmpty As ToolStripMenuItem
    Friend WithEvents mnuPrevEmpty As ToolStripMenuItem
End Class
