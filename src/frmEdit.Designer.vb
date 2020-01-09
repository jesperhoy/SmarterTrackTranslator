<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.txtTranslated = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkWrap = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK_Button.Location = New System.Drawing.Point(478, 280)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 7
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(575, 280)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 8
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtID
        '
        Me.txtID.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtID.Location = New System.Drawing.Point(89, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(560, 22)
        Me.txtID.TabIndex = 1
        Me.txtID.TabStop = False
        '
        'txtEnglish
        '
        Me.txtEnglish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEnglish.Location = New System.Drawing.Point(89, 31)
        Me.txtEnglish.Multiline = True
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.ReadOnly = True
        Me.txtEnglish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEnglish.Size = New System.Drawing.Size(560, 110)
        Me.txtEnglish.TabIndex = 3
        Me.txtEnglish.TabStop = False
        '
        'txtTranslated
        '
        Me.txtTranslated.AcceptsReturn = True
        Me.txtTranslated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTranslated.Location = New System.Drawing.Point(89, 147)
        Me.txtTranslated.Multiline = True
        Me.txtTranslated.Name = "txtTranslated"
        Me.txtTranslated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTranslated.Size = New System.Drawing.Size(560, 111)
        Me.txtTranslated.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "English:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Translated:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTranslated, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtID, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEnglish, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(652, 261)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'chkWrap
        '
        Me.chkWrap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkWrap.AutoSize = True
        Me.chkWrap.Checked = True
        Me.chkWrap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWrap.Location = New System.Drawing.Point(12, 288)
        Me.chkWrap.Name = "chkWrap"
        Me.chkWrap.Size = New System.Drawing.Size(64, 21)
        Me.chkWrap.TabIndex = 6
        Me.chkWrap.Text = "Wrap"
        Me.chkWrap.UseVisualStyleBackColor = True
        '
        'frmEdit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(676, 321)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.chkWrap)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit translation item"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents txtTranslated As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents chkWrap As CheckBox
End Class
