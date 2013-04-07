<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentView
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblStudentList = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblCurriculum = New System.Windows.Forms.Label()
        Me.lblExpectedGraduation = New System.Windows.Forms.Label()
        Me.lblAcademicStats = New System.Windows.Forms.Label()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.lblGPAValue = New System.Windows.Forms.Label()
        Me.lblClassesTakenValue = New System.Windows.Forms.Label()
        Me.lblClassesTaken = New System.Windows.Forms.Label()
        Me.lblMinQuartersToGrad = New System.Windows.Forms.Label()
        Me.lblMinQuartersToGradValue = New System.Windows.Forms.Label()
        Me.lblAvgUnitsPerQuarter = New System.Windows.Forms.Label()
        Me.lblAvgUnitsPerQuarterValue = New System.Windows.Forms.Label()
        Me.lblClassStandingValue = New System.Windows.Forms.Label()
        Me.lblClassStanding = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblCourseCurriculum = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Kevin Ampuero", "Brian Berg", "Shigom Haile", "Martin Legaspi", "Miguel Venegas"})
        Me.ListBox1.Location = New System.Drawing.Point(39, 88)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        '
        'lblStudentList
        '
        Me.lblStudentList.AutoSize = True
        Me.lblStudentList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentList.Location = New System.Drawing.Point(39, 69)
        Me.lblStudentList.Name = "lblStudentList"
        Me.lblStudentList.Size = New System.Drawing.Size(104, 13)
        Me.lblStudentList.TabIndex = 1
        Me.lblStudentList.Text = "Select a student:"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(435, 20)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(98, 24)
        Me.lblStudentName.TabIndex = 14
        Me.lblStudentName.Text = "Brian Berg"
        '
        'lblCurriculum
        '
        Me.lblCurriculum.AutoSize = True
        Me.lblCurriculum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurriculum.Location = New System.Drawing.Point(388, 63)
        Me.lblCurriculum.Name = "lblCurriculum"
        Me.lblCurriculum.Size = New System.Drawing.Size(186, 20)
        Me.lblCurriculum.TabIndex = 15
        Me.lblCurriculum.Text = "Winter 2012 Curriculum"
        '
        'lblExpectedGraduation
        '
        Me.lblExpectedGraduation.AutoSize = True
        Me.lblExpectedGraduation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpectedGraduation.Location = New System.Drawing.Point(330, 82)
        Me.lblExpectedGraduation.Name = "lblExpectedGraduation"
        Me.lblExpectedGraduation.Size = New System.Drawing.Size(305, 20)
        Me.lblExpectedGraduation.TabIndex = 16
        Me.lblExpectedGraduation.Text = "Expected Graduation Date: Spring 2015"
        '
        'lblAcademicStats
        '
        Me.lblAcademicStats.AutoSize = True
        Me.lblAcademicStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcademicStats.Location = New System.Drawing.Point(411, 132)
        Me.lblAcademicStats.Name = "lblAcademicStats"
        Me.lblAcademicStats.Size = New System.Drawing.Size(129, 17)
        Me.lblAcademicStats.TabIndex = 17
        Me.lblAcademicStats.Text = "Academic Statistics"
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPA.Location = New System.Drawing.Point(389, 159)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(36, 13)
        Me.lblGPA.TabIndex = 18
        Me.lblGPA.Text = "GPA:"
        Me.lblGPA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGPAValue
        '
        Me.lblGPAValue.AutoSize = True
        Me.lblGPAValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPAValue.Location = New System.Drawing.Point(436, 159)
        Me.lblGPAValue.Name = "lblGPAValue"
        Me.lblGPAValue.Size = New System.Drawing.Size(22, 13)
        Me.lblGPAValue.TabIndex = 19
        Me.lblGPAValue.Text = "4.0"
        Me.lblGPAValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClassesTakenValue
        '
        Me.lblClassesTakenValue.AutoSize = True
        Me.lblClassesTakenValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassesTakenValue.Location = New System.Drawing.Point(436, 186)
        Me.lblClassesTakenValue.Name = "lblClassesTakenValue"
        Me.lblClassesTakenValue.Size = New System.Drawing.Size(19, 13)
        Me.lblClassesTakenValue.TabIndex = 21
        Me.lblClassesTakenValue.Text = "20"
        Me.lblClassesTakenValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClassesTaken
        '
        Me.lblClassesTaken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassesTaken.Location = New System.Drawing.Point(313, 186)
        Me.lblClassesTaken.Name = "lblClassesTaken"
        Me.lblClassesTaken.Size = New System.Drawing.Size(112, 13)
        Me.lblClassesTaken.TabIndex = 22
        Me.lblClassesTaken.Text = "# Classes Taken:"
        Me.lblClassesTaken.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMinQuartersToGrad
        '
        Me.lblMinQuartersToGrad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinQuartersToGrad.Location = New System.Drawing.Point(479, 186)
        Me.lblMinQuartersToGrad.Name = "lblMinQuartersToGrad"
        Me.lblMinQuartersToGrad.Size = New System.Drawing.Size(109, 27)
        Me.lblMinQuartersToGrad.TabIndex = 23
        Me.lblMinQuartersToGrad.Text = "Minimum Quarters Left to Graduate:"
        Me.lblMinQuartersToGrad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMinQuartersToGradValue
        '
        Me.lblMinQuartersToGradValue.AutoSize = True
        Me.lblMinQuartersToGradValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinQuartersToGradValue.Location = New System.Drawing.Point(594, 200)
        Me.lblMinQuartersToGradValue.Name = "lblMinQuartersToGradValue"
        Me.lblMinQuartersToGradValue.Size = New System.Drawing.Size(13, 13)
        Me.lblMinQuartersToGradValue.TabIndex = 24
        Me.lblMinQuartersToGradValue.Text = "8"
        Me.lblMinQuartersToGradValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAvgUnitsPerQuarter
        '
        Me.lblAvgUnitsPerQuarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgUnitsPerQuarter.Location = New System.Drawing.Point(342, 208)
        Me.lblAvgUnitsPerQuarter.Name = "lblAvgUnitsPerQuarter"
        Me.lblAvgUnitsPerQuarter.Size = New System.Drawing.Size(83, 26)
        Me.lblAvgUnitsPerQuarter.TabIndex = 26
        Me.lblAvgUnitsPerQuarter.Text = "Avg. Units Per Quarter:"
        Me.lblAvgUnitsPerQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAvgUnitsPerQuarterValue
        '
        Me.lblAvgUnitsPerQuarterValue.AutoSize = True
        Me.lblAvgUnitsPerQuarterValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgUnitsPerQuarterValue.Location = New System.Drawing.Point(436, 221)
        Me.lblAvgUnitsPerQuarterValue.Name = "lblAvgUnitsPerQuarterValue"
        Me.lblAvgUnitsPerQuarterValue.Size = New System.Drawing.Size(19, 13)
        Me.lblAvgUnitsPerQuarterValue.TabIndex = 27
        Me.lblAvgUnitsPerQuarterValue.Text = "16"
        Me.lblAvgUnitsPerQuarterValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClassStandingValue
        '
        Me.lblClassStandingValue.AutoSize = True
        Me.lblClassStandingValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassStandingValue.Location = New System.Drawing.Point(594, 159)
        Me.lblClassStandingValue.Name = "lblClassStandingValue"
        Me.lblClassStandingValue.Size = New System.Drawing.Size(61, 13)
        Me.lblClassStandingValue.TabIndex = 29
        Me.lblClassStandingValue.Text = "Sophomore"
        Me.lblClassStandingValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClassStanding
        '
        Me.lblClassStanding.AutoSize = True
        Me.lblClassStanding.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassStanding.Location = New System.Drawing.Point(493, 159)
        Me.lblClassStanding.Name = "lblClassStanding"
        Me.lblClassStanding.Size = New System.Drawing.Size(95, 13)
        Me.lblClassStanding.TabIndex = 28
        Me.lblClassStanding.Text = "Class Standing:"
        Me.lblClassStanding.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(245, 44)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(468, 20)
        Me.lblMajor.TabIndex = 30
        Me.lblMajor.Text = "B.S. Business Administration: Computer Information Systems"
        '
        'lblCourseCurriculum
        '
        Me.lblCourseCurriculum.AutoSize = True
        Me.lblCourseCurriculum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseCurriculum.Location = New System.Drawing.Point(411, 302)
        Me.lblCourseCurriculum.Name = "lblCourseCurriculum"
        Me.lblCourseCurriculum.Size = New System.Drawing.Size(136, 17)
        Me.lblCourseCurriculum.TabIndex = 31
        Me.lblCourseCurriculum.Text = "Curriculum Progress"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(305, 341)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 147)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Completed"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"CIS 101", "CIS 234", "CIS 304", "CIS 305", "CIS 307", "CIS 310", "CIS 101", "CIS 234", "CIS 304", "CIS 305", "CIS 307", "CIS 310"})
        Me.ListBox2.Location = New System.Drawing.Point(7, 20)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(99, 121)
        Me.ListBox2.TabIndex = 0
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Items.AddRange(New Object() {"MHR 318", "IBM 201", "TOM 301", "CIS 101", "CIS 234", "CIS 304", "CIS 305", "CIS 307", "CIS 310", "CIS 101", "CIS 234", "CIS 304", "CIS 305", "CIS 307", "CIS 310"})
        Me.ListBox3.Location = New System.Drawing.Point(7, 19)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(100, 121)
        Me.ListBox3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Olive
        Me.GroupBox2.Location = New System.Drawing.Point(423, 341)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(113, 147)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Not Taken"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(542, 341)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(116, 147)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Failed/Dropped"
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Items.AddRange(New Object() {"ACC 207", "CIS 231", "TOM 302", "CIS 101", "CIS 234", "CIS 304", "CIS 305", "CIS 307", "CIS 310", "CIS 101", "CIS 234", "CIS 304", "CIS 305", "CIS 307", "CIS 310"})
        Me.ListBox4.Location = New System.Drawing.Point(7, 19)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(103, 121)
        Me.ListBox4.TabIndex = 0
        '
        'StudentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 596)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCourseCurriculum)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.lblClassStandingValue)
        Me.Controls.Add(Me.lblClassStanding)
        Me.Controls.Add(Me.lblAvgUnitsPerQuarterValue)
        Me.Controls.Add(Me.lblAvgUnitsPerQuarter)
        Me.Controls.Add(Me.lblMinQuartersToGradValue)
        Me.Controls.Add(Me.lblMinQuartersToGrad)
        Me.Controls.Add(Me.lblClassesTaken)
        Me.Controls.Add(Me.lblClassesTakenValue)
        Me.Controls.Add(Me.lblGPAValue)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.lblAcademicStats)
        Me.Controls.Add(Me.lblExpectedGraduation)
        Me.Controls.Add(Me.lblCurriculum)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudentList)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "StudentView"
        Me.Text = "StudentView"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblStudentList As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblCurriculum As System.Windows.Forms.Label
    Friend WithEvents lblExpectedGraduation As System.Windows.Forms.Label
    Friend WithEvents lblAcademicStats As System.Windows.Forms.Label
    Friend WithEvents lblGPA As System.Windows.Forms.Label
    Friend WithEvents lblGPAValue As System.Windows.Forms.Label
    Friend WithEvents lblClassesTakenValue As System.Windows.Forms.Label
    Friend WithEvents lblClassesTaken As System.Windows.Forms.Label
    Friend WithEvents lblMinQuartersToGrad As System.Windows.Forms.Label
    Friend WithEvents lblMinQuartersToGradValue As System.Windows.Forms.Label
    Friend WithEvents lblAvgUnitsPerQuarter As System.Windows.Forms.Label
    Friend WithEvents lblAvgUnitsPerQuarterValue As System.Windows.Forms.Label
    Friend WithEvents lblClassStandingValue As System.Windows.Forms.Label
    Friend WithEvents lblClassStanding As System.Windows.Forms.Label
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents lblCourseCurriculum As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
End Class
