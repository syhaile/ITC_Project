<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurriculumView
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
        Dim Label1 As System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloTharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HalloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Label1.AutoSize = true
        Label1.Location = New System.Drawing.Point(36, 38)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(39, 13)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(39, 54)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(168, 415)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = false
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(805, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloTharToolStripMenuItem, Me.HalloToolStripMenuItem})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripComboBox1.Text = "File"
        '
        'HelloTharToolStripMenuItem
        '
        Me.HelloTharToolStripMenuItem.Name = "HelloTharToolStripMenuItem"
        Me.HelloTharToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelloTharToolStripMenuItem.Text = "Hello thar"
        '
        'HalloToolStripMenuItem
        '
        Me.HalloToolStripMenuItem.Name = "HalloToolStripMenuItem"
        Me.HalloToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HalloToolStripMenuItem.Text = "hallo"
        '
        'CurriculumView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 481)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CurriculumView"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelloTharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HalloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
