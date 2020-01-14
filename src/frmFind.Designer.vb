<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Me.chkMatchExact = New System.Windows.Forms.CheckBox()
        Me.chkSearchID = New System.Windows.Forms.CheckBox()
        Me.chkSearchTranslated = New System.Windows.Forms.CheckBox()
        Me.chkSearchEnglish = New System.Windows.Forms.CheckBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMatchCase = New System.Windows.Forms.CheckBox()
        Me.chkSearchNotes = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkWrapAround = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkMatchExact
        '
        Me.chkMatchExact.AutoSize = True
        Me.chkMatchExact.Location = New System.Drawing.Point(133, 56)
        Me.chkMatchExact.Margin = New System.Windows.Forms.Padding(18, 3, 3, 3)
        Me.chkMatchExact.Name = "chkMatchExact"
        Me.chkMatchExact.Size = New System.Drawing.Size(133, 21)
        Me.chkMatchExact.TabIndex = 3
        Me.chkMatchExact.Text = "Match whole cell"
        Me.chkMatchExact.UseVisualStyleBackColor = True
        '
        'chkSearchID
        '
        Me.chkSearchID.AutoSize = True
        Me.chkSearchID.Checked = True
        Me.chkSearchID.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchID.Location = New System.Drawing.Point(18, 31)
        Me.chkSearchID.Name = "chkSearchID"
        Me.chkSearchID.Size = New System.Drawing.Size(43, 21)
        Me.chkSearchID.TabIndex = 0
        Me.chkSearchID.Text = "ID"
        Me.chkSearchID.UseVisualStyleBackColor = True
        '
        'chkSearchTranslated
        '
        Me.chkSearchTranslated.AutoSize = True
        Me.chkSearchTranslated.Checked = True
        Me.chkSearchTranslated.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchTranslated.Location = New System.Drawing.Point(179, 31)
        Me.chkSearchTranslated.Margin = New System.Windows.Forms.Padding(18, 3, 3, 3)
        Me.chkSearchTranslated.Name = "chkSearchTranslated"
        Me.chkSearchTranslated.Size = New System.Drawing.Size(98, 21)
        Me.chkSearchTranslated.TabIndex = 2
        Me.chkSearchTranslated.Text = "Translated"
        Me.chkSearchTranslated.UseVisualStyleBackColor = True
        '
        'chkSearchEnglish
        '
        Me.chkSearchEnglish.AutoSize = True
        Me.chkSearchEnglish.Checked = True
        Me.chkSearchEnglish.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchEnglish.Location = New System.Drawing.Point(82, 31)
        Me.chkSearchEnglish.Margin = New System.Windows.Forms.Padding(18, 3, 3, 3)
        Me.chkSearchEnglish.Name = "chkSearchEnglish"
        Me.chkSearchEnglish.Size = New System.Drawing.Size(76, 21)
        Me.chkSearchEnglish.TabIndex = 1
        Me.chkSearchEnglish.Text = "English"
        Me.chkSearchEnglish.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFind.Location = New System.Drawing.Point(90, 17)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(313, 22)
        Me.txtFind.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find what:"
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.Location = New System.Drawing.Point(15, 56)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(102, 21)
        Me.chkMatchCase.TabIndex = 2
        Me.chkMatchCase.Text = "Match case"
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'chkSearchNotes
        '
        Me.chkSearchNotes.AutoSize = True
        Me.chkSearchNotes.Checked = True
        Me.chkSearchNotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchNotes.Location = New System.Drawing.Point(298, 31)
        Me.chkSearchNotes.Margin = New System.Windows.Forms.Padding(18, 3, 3, 3)
        Me.chkSearchNotes.Name = "chkSearchNotes"
        Me.chkSearchNotes.Size = New System.Drawing.Size(67, 21)
        Me.chkSearchNotes.TabIndex = 3
        Me.chkSearchNotes.Text = "Notes"
        Me.chkSearchNotes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkSearchID)
        Me.GroupBox1.Controls.Add(Me.chkSearchEnglish)
        Me.GroupBox1.Controls.Add(Me.chkSearchTranslated)
        Me.GroupBox1.Controls.Add(Me.chkSearchNotes)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 68)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search in columns"
        '
        'btnFind
        '
        Me.btnFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFind.Location = New System.Drawing.Point(422, 12)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(100, 30)
        Me.btnFind.TabIndex = 6
        Me.btnFind.Text = "Find Next"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(422, 50)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 30)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkWrapAround
        '
        Me.chkWrapAround.AutoSize = True
        Me.chkWrapAround.Checked = True
        Me.chkWrapAround.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWrapAround.Location = New System.Drawing.Point(287, 56)
        Me.chkWrapAround.Margin = New System.Windows.Forms.Padding(18, 3, 3, 3)
        Me.chkWrapAround.Name = "chkWrapAround"
        Me.chkWrapAround.Size = New System.Drawing.Size(113, 21)
        Me.chkWrapAround.TabIndex = 4
        Me.chkWrapAround.Text = "Wrap around"
        Me.chkWrapAround.UseVisualStyleBackColor = True
        '
        'frmFind
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(532, 175)
        Me.Controls.Add(Me.chkWrapAround)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkMatchExact)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkMatchCase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFind"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkMatchExact As CheckBox
    Friend WithEvents chkSearchID As CheckBox
    Friend WithEvents chkSearchTranslated As CheckBox
    Friend WithEvents chkSearchEnglish As CheckBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkMatchCase As CheckBox
    Friend WithEvents chkSearchNotes As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFind As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkWrapAround As CheckBox
End Class
