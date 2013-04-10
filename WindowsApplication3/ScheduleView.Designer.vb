<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleView
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
        Me.lboxQuarters = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlQuarter = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNumClasses = New System.Windows.Forms.Label()
        Me.lblNumFirstYear = New System.Windows.Forms.Label()
        Me.lblNumSecondYear = New System.Windows.Forms.Label()
        Me.lblNumFifthYear = New System.Windows.Forms.Label()
        Me.lblNumFourthYear = New System.Windows.Forms.Label()
        Me.lblNumThirdYear = New System.Windows.Forms.Label()
        Me.pnlClassMetrics = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lboxClasses = New System.Windows.Forms.ListBox()
        Me.pnlClass = New System.Windows.Forms.Panel()
        Me.pnlQuarter.SuspendLayout()
        Me.pnlClassMetrics.SuspendLayout()
        Me.pnlClass.SuspendLayout()
        Me.SuspendLayout()
        '
        'lboxQuarters
        '
        Me.lboxQuarters.FormattingEnabled = True
        Me.lboxQuarters.Items.AddRange(New Object() {"Spring 2004", "Fall 2004", "Winter 2004"})
        Me.lboxQuarters.Location = New System.Drawing.Point(28, 62)
        Me.lboxQuarters.Name = "lboxQuarters"
        Me.lboxQuarters.Size = New System.Drawing.Size(120, 95)
        Me.lboxQuarters.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quarters"
        '
        'pnlQuarter
        '
        Me.pnlQuarter.Controls.Add(Me.lblNumFifthYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumFourthYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumThirdYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumSecondYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumFirstYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumClasses)
        Me.pnlQuarter.Controls.Add(Me.Label5)
        Me.pnlQuarter.Controls.Add(Me.Label2)
        Me.pnlQuarter.Controls.Add(Me.Label3)
        Me.pnlQuarter.Controls.Add(Me.Label1)
        Me.pnlQuarter.Controls.Add(Me.label7)
        Me.pnlQuarter.Controls.Add(Me.label6)
        Me.pnlQuarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlQuarter.Location = New System.Drawing.Point(201, 25)
        Me.pnlQuarter.Name = "pnlQuarter"
        Me.pnlQuarter.Size = New System.Drawing.Size(532, 190)
        Me.pnlQuarter.TabIndex = 19
        Me.pnlQuarter.TabStop = False
        Me.pnlQuarter.Text = "Quarter Metrics"
        Me.pnlQuarter.Visible = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.label7.Location = New System.Drawing.Point(44, 34)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(189, 18)
        Me.label7.TabIndex = 15
        Me.label7.Text = "Number of Classes Offered"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.label6.Location = New System.Drawing.Point(27, 57)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(207, 18)
        Me.label6.TabIndex = 16
        Me.label6.Text = "Number of First Year Students"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Number of Second Year Students"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(14, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Number of Fourth Year Students"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(24, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Number of Third Year Students"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(29, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Number of Fifth Year Students"
        '
        'lblNumClasses
        '
        Me.lblNumClasses.AutoSize = True
        Me.lblNumClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumClasses.Location = New System.Drawing.Point(258, 37)
        Me.lblNumClasses.Name = "lblNumClasses"
        Me.lblNumClasses.Size = New System.Drawing.Size(94, 15)
        Me.lblNumClasses.TabIndex = 22
        Me.lblNumClasses.Text = "Course Name"
        '
        'lblNumFirstYear
        '
        Me.lblNumFirstYear.AutoSize = True
        Me.lblNumFirstYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFirstYear.Location = New System.Drawing.Point(258, 60)
        Me.lblNumFirstYear.Name = "lblNumFirstYear"
        Me.lblNumFirstYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumFirstYear.TabIndex = 23
        Me.lblNumFirstYear.Text = "Course Name"
        '
        'lblNumSecondYear
        '
        Me.lblNumSecondYear.AutoSize = True
        Me.lblNumSecondYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumSecondYear.Location = New System.Drawing.Point(258, 83)
        Me.lblNumSecondYear.Name = "lblNumSecondYear"
        Me.lblNumSecondYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumSecondYear.TabIndex = 24
        Me.lblNumSecondYear.Text = "Course Name"
        '
        'lblNumFifthYear
        '
        Me.lblNumFifthYear.AutoSize = True
        Me.lblNumFifthYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFifthYear.Location = New System.Drawing.Point(258, 149)
        Me.lblNumFifthYear.Name = "lblNumFifthYear"
        Me.lblNumFifthYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumFifthYear.TabIndex = 27
        Me.lblNumFifthYear.Text = "Course Name"
        '
        'lblNumFourthYear
        '
        Me.lblNumFourthYear.AutoSize = True
        Me.lblNumFourthYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFourthYear.Location = New System.Drawing.Point(258, 126)
        Me.lblNumFourthYear.Name = "lblNumFourthYear"
        Me.lblNumFourthYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumFourthYear.TabIndex = 26
        Me.lblNumFourthYear.Text = "Course Name"
        '
        'lblNumThirdYear
        '
        Me.lblNumThirdYear.AutoSize = True
        Me.lblNumThirdYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumThirdYear.Location = New System.Drawing.Point(258, 103)
        Me.lblNumThirdYear.Name = "lblNumThirdYear"
        Me.lblNumThirdYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumThirdYear.TabIndex = 25
        Me.lblNumThirdYear.Text = "Course Name"
        '
        'pnlClassMetrics
        '
        Me.pnlClassMetrics.Controls.Add(Me.Label8)
        Me.pnlClassMetrics.Controls.Add(Me.Label9)
        Me.pnlClassMetrics.Controls.Add(Me.Label10)
        Me.pnlClassMetrics.Controls.Add(Me.Label11)
        Me.pnlClassMetrics.Controls.Add(Me.Label12)
        Me.pnlClassMetrics.Controls.Add(Me.Label13)
        Me.pnlClassMetrics.Controls.Add(Me.Label14)
        Me.pnlClassMetrics.Controls.Add(Me.Label15)
        Me.pnlClassMetrics.Controls.Add(Me.Label16)
        Me.pnlClassMetrics.Controls.Add(Me.Label17)
        Me.pnlClassMetrics.Controls.Add(Me.Label18)
        Me.pnlClassMetrics.Controls.Add(Me.Label19)
        Me.pnlClassMetrics.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlClassMetrics.Location = New System.Drawing.Point(183, 13)
        Me.pnlClassMetrics.Name = "pnlClassMetrics"
        Me.pnlClassMetrics.Size = New System.Drawing.Size(532, 190)
        Me.pnlClassMetrics.TabIndex = 30
        Me.pnlClassMetrics.TabStop = False
        Me.pnlClassMetrics.Text = "Class Metrics"
        Me.pnlClassMetrics.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(258, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Course Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(258, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Course Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(258, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Course Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(258, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Course Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(258, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 15)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Course Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(258, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Course Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label14.Location = New System.Drawing.Point(29, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(206, 18)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Number of Fifth Year Students"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label15.Location = New System.Drawing.Point(14, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(221, 18)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Number of Fourth Year Students"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label16.Location = New System.Drawing.Point(24, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(211, 18)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Number of Third Year Students"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label17.Location = New System.Drawing.Point(6, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(229, 18)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Number of Second Year Students"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label18.Location = New System.Drawing.Point(44, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(189, 18)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Number of Classes Offered"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label19.Location = New System.Drawing.Point(27, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(207, 18)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Number of First Year Students"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(27, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 15)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Classes"
        '
        'lboxClasses
        '
        Me.lboxClasses.FormattingEnabled = True
        Me.lboxClasses.Items.AddRange(New Object() {"CIS-304", "CIS-234", "CIS-244", "CIS-124"})
        Me.lboxClasses.Location = New System.Drawing.Point(10, 50)
        Me.lboxClasses.Name = "lboxClasses"
        Me.lboxClasses.Size = New System.Drawing.Size(120, 95)
        Me.lboxClasses.TabIndex = 28
        '
        'pnlClass
        '
        Me.pnlClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlClass.Controls.Add(Me.pnlClassMetrics)
        Me.pnlClass.Controls.Add(Me.lboxClasses)
        Me.pnlClass.Controls.Add(Me.Label20)
        Me.pnlClass.Location = New System.Drawing.Point(16, 234)
        Me.pnlClass.Name = "pnlClass"
        Me.pnlClass.Size = New System.Drawing.Size(738, 221)
        Me.pnlClass.TabIndex = 31
        Me.pnlClass.Visible = False
        '
        'ScheduleView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 528)
        Me.Controls.Add(Me.pnlClass)
        Me.Controls.Add(Me.pnlQuarter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lboxQuarters)
        Me.Name = "ScheduleView"
        Me.Text = "ScheduleView"
        Me.pnlQuarter.ResumeLayout(False)
        Me.pnlQuarter.PerformLayout()
        Me.pnlClassMetrics.ResumeLayout(False)
        Me.pnlClassMetrics.PerformLayout()
        Me.pnlClass.ResumeLayout(False)
        Me.pnlClass.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lboxQuarters As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlQuarter As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents lblNumClasses As System.Windows.Forms.Label
    Friend WithEvents lblNumFifthYear As System.Windows.Forms.Label
    Friend WithEvents lblNumFourthYear As System.Windows.Forms.Label
    Friend WithEvents lblNumThirdYear As System.Windows.Forms.Label
    Friend WithEvents lblNumSecondYear As System.Windows.Forms.Label
    Friend WithEvents lblNumFirstYear As System.Windows.Forms.Label
    Friend WithEvents pnlClassMetrics As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lboxClasses As System.Windows.Forms.ListBox
    Friend WithEvents pnlClass As System.Windows.Forms.Panel
End Class
