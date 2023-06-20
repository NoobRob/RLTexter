<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmText
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblText = New System.Windows.Forms.Label()
        Me.tbSpeed = New System.Windows.Forms.TrackBar()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblText, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbSpeed, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdPause, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblstatus, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdStart, 2, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.95487!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.90974!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.740168!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.39523!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(842, 397)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblText
        '
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblText.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblText.Location = New System.Drawing.Point(129, 79)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(583, 158)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Auf Start klicken, um zu beginnen"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbSpeed
        '
        Me.tbSpeed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSpeed.Location = New System.Drawing.Point(129, 250)
        Me.tbSpeed.Maximum = 250
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(583, 144)
        Me.tbSpeed.TabIndex = 4
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(3, 250)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(111, 35)
        Me.cmdPause.TabIndex = 2
        Me.cmdPause.Text = "II"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(3, 0)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(39, 15)
        Me.lblstatus.TabIndex = 3
        Me.lblstatus.Text = "Status"
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(718, 250)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(101, 35)
        Me.cmdStart.TabIndex = 1
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'frmText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 421)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RLTexter"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblText As Label
    Friend WithEvents cmdPause As Button
    Friend WithEvents cmdStart As Button
    Friend WithEvents lblstatus As Label
    Friend WithEvents tbSpeed As TrackBar
End Class
