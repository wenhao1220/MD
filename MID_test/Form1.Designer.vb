<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.困難度DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.D20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.D10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.D5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.困難度DToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1260, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '困難度DToolStripMenuItem
        '
        Me.困難度DToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D20, Me.D10, Me.D5})
        Me.困難度DToolStripMenuItem.Name = "困難度DToolStripMenuItem"
        Me.困難度DToolStripMenuItem.Size = New System.Drawing.Size(139, 38)
        Me.困難度DToolStripMenuItem.Text = "困難度(&D)"
        '
        'D20
        '
        Me.D20.Name = "D20"
        Me.D20.Size = New System.Drawing.Size(359, 44)
        Me.D20.Text = "高20x20(&H)"
        '
        'D10
        '
        Me.D10.Checked = True
        Me.D10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.D10.Name = "D10"
        Me.D10.Size = New System.Drawing.Size(359, 44)
        Me.D10.Text = "中10x10(&M)"
        '
        'D5
        '
        Me.D5.Name = "D5"
        Me.D5.Size = New System.Drawing.Size(359, 44)
        Me.D5.Text = "低5x5(&L)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 893)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 困難度DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents D20 As ToolStripMenuItem
    Friend WithEvents D10 As ToolStripMenuItem
    Friend WithEvents D5 As ToolStripMenuItem
End Class
