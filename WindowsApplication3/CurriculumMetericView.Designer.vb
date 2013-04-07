<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurriculumMetericView
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tvCurriculum = New System.Windows.Forms.TreeView()
        Me.lblCurriculumTitle = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblAvgGPA = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMetricsTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.SuspendLayout
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tvCurriculum)
        Me.TabPage2.Controls.Add(Me.lblCurriculumTitle)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(490, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Curriculum View"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'tvCurriculum
        '
        Me.tvCurriculum.Location = New System.Drawing.Point(13, 30)
        Me.tvCurriculum.Name = "tvCurriculum"
        Me.tvCurriculum.Size = New System.Drawing.Size(469, 528)
        Me.tvCurriculum.TabIndex = 13
        '
        'lblCurriculumTitle
        '
        Me.lblCurriculumTitle.AutoSize = true
        Me.lblCurriculumTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCurriculumTitle.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblCurriculumTitle.Location = New System.Drawing.Point(9, 3)
        Me.lblCurriculumTitle.Name = "lblCurriculumTitle"
        Me.lblCurriculumTitle.Size = New System.Drawing.Size(142, 24)
        Me.lblCurriculumTitle.TabIndex = 12
        Me.lblCurriculumTitle.Text = "Curriculum Title"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblAvgGPA)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.lblMetricsTitle)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(490, 567)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Metrics View "
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'lblAvgGPA
        '
        Me.lblAvgGPA.AutoSize = true
        Me.lblAvgGPA.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblAvgGPA.Location = New System.Drawing.Point(234, 40)
        Me.lblAvgGPA.Name = "lblAvgGPA"
        Me.lblAvgGPA.Size = New System.Drawing.Size(75, 13)
        Me.lblAvgGPA.TabIndex = 12
        Me.lblAvgGPA.Text = "Average GPA:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(237, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 106)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Unit Metrics"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Average Remaining Units: "
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(6, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Average Units Taken: "
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label9.Location = New System.Drawing.Point(6, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Minimum units taken:"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label10.Location = New System.Drawing.Point(6, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Maximum units taken: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 106)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Time Metrics"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Average Time in Quarters"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(6, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Maximum Time Taken"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(6, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Minimum Time Taken"
        '
        'lblMetricsTitle
        '
        Me.lblMetricsTitle.AutoSize = true
        Me.lblMetricsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMetricsTitle.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblMetricsTitle.Location = New System.Drawing.Point(9, 3)
        Me.lblMetricsTitle.Name = "lblMetricsTitle"
        Me.lblMetricsTitle.Size = New System.Drawing.Size(110, 24)
        Me.lblMetricsTitle.TabIndex = 0
        Me.lblMetricsTitle.Text = "Metrics Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(9, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Graduated Students: "
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(10, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Drop Outs: "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(498, 593)
        Me.TabControl1.TabIndex = 10
        '
        'CurriculumMetericView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.Name = "CurriculumMetericView"
        Me.Text = "Form2"
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage2.PerformLayout
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMetricsTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents lblCurriculumTitle As System.Windows.Forms.Label
    Friend WithEvents lblAvgGPA As System.Windows.Forms.Label
    Friend WithEvents tvCurriculum As System.Windows.Forms.TreeView
End Class
