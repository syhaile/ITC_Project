<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataGenerator))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Classes = New System.Windows.Forms.TabPage()
        Me.lboxClassesCourses = New System.Windows.Forms.ListBox()
        Me.btnClassesAddClass = New System.Windows.Forms.Button()
        Me.txtClassesPrerequisites = New System.Windows.Forms.TextBox()
        Me.cboxClassesPrerequisites = New System.Windows.Forms.CheckBox()
        Me.txtClassesCompanion = New System.Windows.Forms.TextBox()
        Me.cboxClassesCompanion = New System.Windows.Forms.CheckBox()
        Me.nudClassesUnits = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassesFileSRC = New System.Windows.Forms.TextBox()
        Me.btnClassesBrowse = New System.Windows.Forms.Button()
        Me.Curriculum = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Students = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lboxCurriculumCourses = New System.Windows.Forms.ListBox()
        Me.lboxCurriculumCurrent = New System.Windows.Forms.ListBox()
        Me.btnDrop = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Classes.SuspendLayout()
        CType(Me.nudClassesUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Curriculum.SuspendLayout()
        Me.Students.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Classes)
        Me.TabControl1.Controls.Add(Me.Curriculum)
        Me.TabControl1.Controls.Add(Me.Students)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(455, 332)
        Me.TabControl1.TabIndex = 0
        '
        'Classes
        '
        Me.Classes.Controls.Add(Me.lboxClassesCourses)
        Me.Classes.Controls.Add(Me.btnClassesAddClass)
        Me.Classes.Controls.Add(Me.txtClassesPrerequisites)
        Me.Classes.Controls.Add(Me.cboxClassesPrerequisites)
        Me.Classes.Controls.Add(Me.txtClassesCompanion)
        Me.Classes.Controls.Add(Me.cboxClassesCompanion)
        Me.Classes.Controls.Add(Me.nudClassesUnits)
        Me.Classes.Controls.Add(Me.Label8)
        Me.Classes.Controls.Add(Me.txtCourseName)
        Me.Classes.Controls.Add(Me.Label4)
        Me.Classes.Controls.Add(Me.Label1)
        Me.Classes.Controls.Add(Me.txtClassesFileSRC)
        Me.Classes.Controls.Add(Me.btnClassesBrowse)
        Me.Classes.Location = New System.Drawing.Point(4, 22)
        Me.Classes.Name = "Classes"
        Me.Classes.Padding = New System.Windows.Forms.Padding(3)
        Me.Classes.Size = New System.Drawing.Size(447, 306)
        Me.Classes.TabIndex = 0
        Me.Classes.Text = "Classes"
        Me.Classes.UseVisualStyleBackColor = True
        '
        'lboxClassesCourses
        '
        Me.lboxClassesCourses.FormattingEnabled = True
        Me.lboxClassesCourses.Location = New System.Drawing.Point(223, 63)
        Me.lboxClassesCourses.Name = "lboxClassesCourses"
        Me.lboxClassesCourses.Size = New System.Drawing.Size(198, 173)
        Me.lboxClassesCourses.TabIndex = 18
        '
        'btnClassesAddClass
        '
        Me.btnClassesAddClass.Location = New System.Drawing.Point(108, 258)
        Me.btnClassesAddClass.Name = "btnClassesAddClass"
        Me.btnClassesAddClass.Size = New System.Drawing.Size(75, 23)
        Me.btnClassesAddClass.TabIndex = 17
        Me.btnClassesAddClass.Text = "Add Class"
        Me.btnClassesAddClass.UseVisualStyleBackColor = True
        Me.btnClassesAddClass.Visible = False
        '
        'txtClassesPrerequisites
        '
        Me.txtClassesPrerequisites.Enabled = False
        Me.txtClassesPrerequisites.Location = New System.Drawing.Point(106, 217)
        Me.txtClassesPrerequisites.Name = "txtClassesPrerequisites"
        Me.txtClassesPrerequisites.Size = New System.Drawing.Size(100, 20)
        Me.txtClassesPrerequisites.TabIndex = 16
        '
        'cboxClassesPrerequisites
        '
        Me.cboxClassesPrerequisites.AutoSize = True
        Me.cboxClassesPrerequisites.Enabled = False
        Me.cboxClassesPrerequisites.Location = New System.Drawing.Point(83, 194)
        Me.cboxClassesPrerequisites.Name = "cboxClassesPrerequisites"
        Me.cboxClassesPrerequisites.Size = New System.Drawing.Size(86, 17)
        Me.cboxClassesPrerequisites.TabIndex = 15
        Me.cboxClassesPrerequisites.Text = "Prerequisites"
        Me.cboxClassesPrerequisites.UseVisualStyleBackColor = True
        '
        'txtClassesCompanion
        '
        Me.txtClassesCompanion.Enabled = False
        Me.txtClassesCompanion.Location = New System.Drawing.Point(106, 157)
        Me.txtClassesCompanion.Name = "txtClassesCompanion"
        Me.txtClassesCompanion.Size = New System.Drawing.Size(100, 20)
        Me.txtClassesCompanion.TabIndex = 14
        '
        'cboxClassesCompanion
        '
        Me.cboxClassesCompanion.AutoSize = True
        Me.cboxClassesCompanion.Enabled = False
        Me.cboxClassesCompanion.Location = New System.Drawing.Point(83, 134)
        Me.cboxClassesCompanion.Name = "cboxClassesCompanion"
        Me.cboxClassesCompanion.Size = New System.Drawing.Size(107, 17)
        Me.cboxClassesCompanion.TabIndex = 13
        Me.cboxClassesCompanion.Text = "Companion Class"
        Me.cboxClassesCompanion.UseVisualStyleBackColor = True
        '
        'nudClassesUnits
        '
        Me.nudClassesUnits.Enabled = False
        Me.nudClassesUnits.Location = New System.Drawing.Point(108, 97)
        Me.nudClassesUnits.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudClassesUnits.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudClassesUnits.Name = "nudClassesUnits"
        Me.nudClassesUnits.Size = New System.Drawing.Size(98, 20)
        Me.nudClassesUnits.TabIndex = 12
        Me.nudClassesUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudClassesUnits.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Units"
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(106, 62)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Course Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Import a File"
        '
        'txtClassesFileSRC
        '
        Me.txtClassesFileSRC.Enabled = False
        Me.txtClassesFileSRC.Location = New System.Drawing.Point(106, 12)
        Me.txtClassesFileSRC.Name = "txtClassesFileSRC"
        Me.txtClassesFileSRC.Size = New System.Drawing.Size(254, 20)
        Me.txtClassesFileSRC.TabIndex = 1
        '
        'btnClassesBrowse
        '
        Me.btnClassesBrowse.Location = New System.Drawing.Point(366, 10)
        Me.btnClassesBrowse.Name = "btnClassesBrowse"
        Me.btnClassesBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnClassesBrowse.TabIndex = 0
        Me.btnClassesBrowse.Text = "Browse"
        Me.btnClassesBrowse.UseVisualStyleBackColor = True
        '
        'Curriculum
        '
        Me.Curriculum.Controls.Add(Me.btnAdd)
        Me.Curriculum.Controls.Add(Me.btnDrop)
        Me.Curriculum.Controls.Add(Me.lboxCurriculumCurrent)
        Me.Curriculum.Controls.Add(Me.lboxCurriculumCourses)
        Me.Curriculum.Controls.Add(Me.Button1)
        Me.Curriculum.Controls.Add(Me.TextBox1)
        Me.Curriculum.Controls.Add(Me.Label3)
        Me.Curriculum.Location = New System.Drawing.Point(4, 22)
        Me.Curriculum.Name = "Curriculum"
        Me.Curriculum.Padding = New System.Windows.Forms.Padding(3)
        Me.Curriculum.Size = New System.Drawing.Size(447, 306)
        Me.Curriculum.TabIndex = 1
        Me.Curriculum.Text = "Curriculum"
        Me.Curriculum.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Import a File"
        '
        'Students
        '
        Me.Students.Controls.Add(Me.Label2)
        Me.Students.Controls.Add(Me.Button2)
        Me.Students.Controls.Add(Me.TextBox2)
        Me.Students.Location = New System.Drawing.Point(4, 22)
        Me.Students.Name = "Students"
        Me.Students.Size = New System.Drawing.Size(447, 306)
        Me.Students.TabIndex = 2
        Me.Students.Text = "Students"
        Me.Students.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Import a File"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(366, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(106, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(254, 20)
        Me.TextBox2.TabIndex = 2
        '
        'lboxCurriculumCourses
        '
        Me.lboxCurriculumCourses.FormattingEnabled = True
        Me.lboxCurriculumCourses.Location = New System.Drawing.Point(19, 58)
        Me.lboxCurriculumCourses.Name = "lboxCurriculumCourses"
        Me.lboxCurriculumCourses.Size = New System.Drawing.Size(158, 199)
        Me.lboxCurriculumCourses.TabIndex = 6
        '
        'lboxCurriculumCurrent
        '
        Me.lboxCurriculumCurrent.FormattingEnabled = True
        Me.lboxCurriculumCurrent.Location = New System.Drawing.Point(266, 58)
        Me.lboxCurriculumCurrent.Name = "lboxCurriculumCurrent"
        Me.lboxCurriculumCurrent.Size = New System.Drawing.Size(158, 199)
        Me.lboxCurriculumCurrent.TabIndex = 7
        '
        'btnDrop
        '
        Me.btnDrop.Image = CType(resources.GetObject("btnDrop.Image"), System.Drawing.Image)
        Me.btnDrop.Location = New System.Drawing.Point(185, 104)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(75, 50)
        Me.btnDrop.TabIndex = 8
        Me.btnDrop.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(185, 160)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 50)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 418)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "DataGenerator"
        Me.Text = "DataGenerator"
        Me.TabControl1.ResumeLayout(False)
        Me.Classes.ResumeLayout(False)
        Me.Classes.PerformLayout()
        CType(Me.nudClassesUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Curriculum.ResumeLayout(False)
        Me.Curriculum.PerformLayout()
        Me.Students.ResumeLayout(False)
        Me.Students.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Classes As System.Windows.Forms.TabPage
    Friend WithEvents txtCourseName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClassesFileSRC As System.Windows.Forms.TextBox
    Friend WithEvents btnClassesBrowse As System.Windows.Forms.Button
    Friend WithEvents Curriculum As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Students As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtClassesPrerequisites As System.Windows.Forms.TextBox
    Friend WithEvents cboxClassesPrerequisites As System.Windows.Forms.CheckBox
    Friend WithEvents txtClassesCompanion As System.Windows.Forms.TextBox
    Friend WithEvents cboxClassesCompanion As System.Windows.Forms.CheckBox
    Friend WithEvents nudClassesUnits As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClassesAddClass As System.Windows.Forms.Button
    Friend WithEvents lboxClassesCourses As System.Windows.Forms.ListBox
    Friend WithEvents lboxCurriculumCourses As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDrop As System.Windows.Forms.Button
    Friend WithEvents lboxCurriculumCurrent As System.Windows.Forms.ListBox
End Class
