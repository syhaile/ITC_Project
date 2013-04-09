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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbxCurriclum = New System.Windows.Forms.ComboBox()
        Me.ClassBox = New System.Windows.Forms.GroupBox()
        Me.lblCompanion = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblPrereq = New System.Windows.Forms.Label()
        Me.lbxCurriculum = New System.Windows.Forms.ListBox()
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
        Me.TabPage2.SuspendLayout()
        Me.ClassBox.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.cmbxCurriclum)
        Me.TabPage2.Controls.Add(Me.ClassBox)
        Me.TabPage2.Controls.Add(Me.lbxCurriculum)
        Me.TabPage2.Controls.Add(Me.lblCurriculumTitle)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(801, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Curriculum View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label8.Location = New System.Drawing.Point(157, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Select Curriculum:"
        '
        'cmbxCurriclum
        '
        Me.cmbxCurriclum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCurriclum.FormattingEnabled = True
        Me.cmbxCurriclum.Location = New System.Drawing.Point(277, 32)
        Me.cmbxCurriclum.Name = "cmbxCurriclum"
        Me.cmbxCurriclum.Size = New System.Drawing.Size(159, 21)
        Me.cmbxCurriclum.TabIndex = 19
        '
        'ClassBox
        '
        Me.ClassBox.Controls.Add(Me.lblCompanion)
        Me.ClassBox.Controls.Add(Me.lblUnit)
        Me.ClassBox.Controls.Add(Me.lblPrereq)
        Me.ClassBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassBox.Location = New System.Drawing.Point(157, 57)
        Me.ClassBox.Name = "ClassBox"
        Me.ClassBox.Size = New System.Drawing.Size(593, 117)
        Me.ClassBox.TabIndex = 18
        Me.ClassBox.TabStop = False
        Me.ClassBox.Text = "ClassBox"
        '
        'lblCompanion
        '
        Me.lblCompanion.AutoSize = True
        Me.lblCompanion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanion.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblCompanion.Location = New System.Drawing.Point(6, 81)
        Me.lblCompanion.Name = "lblCompanion"
        Me.lblCompanion.Size = New System.Drawing.Size(131, 18)
        Me.lblCompanion.TabIndex = 17
        Me.lblCompanion.Text = "Companion Class:"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblUnit.Location = New System.Drawing.Point(6, 34)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(46, 18)
        Me.lblUnit.TabIndex = 15
        Me.lblUnit.Text = "Units:"
        '
        'lblPrereq
        '
        Me.lblPrereq.AutoSize = True
        Me.lblPrereq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrereq.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblPrereq.Location = New System.Drawing.Point(6, 57)
        Me.lblPrereq.Name = "lblPrereq"
        Me.lblPrereq.Size = New System.Drawing.Size(86, 18)
        Me.lblPrereq.TabIndex = 16
        Me.lblPrereq.Text = "Prerequisite"
        '
        'lbxCurriculum
        '
        Me.lbxCurriculum.FormattingEnabled = True
        Me.lbxCurriculum.Location = New System.Drawing.Point(9, 30)
        Me.lbxCurriculum.Name = "lbxCurriculum"
        Me.lbxCurriculum.Size = New System.Drawing.Size(142, 524)
        Me.lbxCurriculum.TabIndex = 13
        '
        'lblCurriculumTitle
        '
        Me.lblCurriculumTitle.AutoSize = True
        Me.lblCurriculumTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurriculumTitle.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblCurriculumTitle.Location = New System.Drawing.Point(301, 3)
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
        Me.TabPage1.Size = New System.Drawing.Size(801, 567)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Metrics View "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblAvgGPA
        '
        Me.lblAvgGPA.AutoSize = True
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
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Unit Metrics"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Average Remaining Units: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(6, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Average Units Taken: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label9.Location = New System.Drawing.Point(6, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Minimum units taken:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
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
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time Metrics"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Average Time in Quarters"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(6, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Maximum Time Taken"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(6, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Minimum Time Taken"
        '
        'lblMetricsTitle
        '
        Me.lblMetricsTitle.AutoSize = True
        Me.lblMetricsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetricsTitle.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblMetricsTitle.Location = New System.Drawing.Point(9, 3)
        Me.lblMetricsTitle.Name = "lblMetricsTitle"
        Me.lblMetricsTitle.Size = New System.Drawing.Size(110, 24)
        Me.lblMetricsTitle.TabIndex = 0
        Me.lblMetricsTitle.Text = "Metrics Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(9, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Graduated Students: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(10, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Drop Outs: "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(-1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(809, 593)
        Me.TabControl1.TabIndex = 10
        '
        'CurriculumMetericView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.Name = "CurriculumMetericView"
        Me.Text = "Form2"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ClassBox.ResumeLayout(False)
        Me.ClassBox.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents lbxCurriculum As System.Windows.Forms.ListBox
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblPrereq As System.Windows.Forms.Label
    Friend WithEvents lblCompanion As System.Windows.Forms.Label
    Friend WithEvents ClassBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxCurriclum As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
