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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.cmdGo = New System.Windows.Forms.Button()
        Me.tbSpeed = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbSpeed = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "zu zeigender Text:"
        '
        'txtText
        '
        Me.txtText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtText.Location = New System.Drawing.Point(12, 27)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(808, 560)
        Me.txtText.TabIndex = 1
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(637, 18)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(165, 72)
        Me.cmdGo.TabIndex = 2
        Me.cmdGo.Text = "Text zeigen"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(22, 45)
        Me.tbSpeed.Maximum = 250
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(609, 45)
        Me.tbSpeed.TabIndex = 3
        Me.tbSpeed.Value = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Geschwindigkeit (ms):"
        '
        'mtbSpeed
        '
        Me.mtbSpeed.Location = New System.Drawing.Point(152, 18)
        Me.mtbSpeed.Mask = "0000"
        Me.mtbSpeed.Name = "mtbSpeed"
        Me.mtbSpeed.Size = New System.Drawing.Size(44, 23)
        Me.mtbSpeed.TabIndex = 5
        Me.mtbSpeed.Text = "150"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdGo)
        Me.GroupBox1.Controls.Add(Me.mtbSpeed)
        Me.GroupBox1.Controls.Add(Me.tbSpeed)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 593)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 702)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "RLTexter"
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents cmdGo As Button
    Friend WithEvents tbSpeed As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbSpeed As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
