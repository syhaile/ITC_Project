<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCreateCurriculum = New System.Windows.Forms.Button()
        Me.btnCourses = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCurriculum = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'btnCreateCurriculum
        '
        Me.btnCreateCurriculum.Location = New System.Drawing.Point(246, 12)
        Me.btnCreateCurriculum.Name = "btnCreateCurriculum"
        Me.btnCreateCurriculum.Size = New System.Drawing.Size(139, 23)
        Me.btnCreateCurriculum.TabIndex = 1
        Me.btnCreateCurriculum.Text = "Create test data"
        Me.btnCreateCurriculum.UseVisualStyleBackColor = true
        '
        'btnCourses
        '
        Me.btnCourses.Location = New System.Drawing.Point(210, 99)
        Me.btnCourses.Name = "btnCourses"
        Me.btnCourses.Size = New System.Drawing.Size(101, 23)
        Me.btnCourses.TabIndex = 3
        Me.btnCourses.Text = "Display Courses"
        Me.btnCourses.UseVisualStyleBackColor = true
        '
        'btnStudents
        '
        Me.btnStudents.Location = New System.Drawing.Point(210, 128)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(101, 23)
        Me.btnStudents.TabIndex = 4
        Me.btnStudents.Text = "Display Students"
        Me.btnStudents.UseVisualStyleBackColor = true
        '
        'btnTeacher
        '
        Me.btnTeacher.Location = New System.Drawing.Point(210, 41)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(101, 23)
        Me.btnTeacher.TabIndex = 5
        Me.btnTeacher.Text = "Display Teachers"
        Me.btnTeacher.UseVisualStyleBackColor = true
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(210, 70)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(101, 23)
        Me.btnRoom.TabIndex = 6
        Me.btnRoom.Text = "Display Room"
        Me.btnRoom.UseVisualStyleBackColor = true
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(108, 195)
        Me.txtArea.Multiline = true
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArea.Size = New System.Drawing.Size(377, 159)
        Me.txtArea.TabIndex = 7
        '
        'btnSchedule
        '
        Me.btnSchedule.Location = New System.Drawing.Point(210, 157)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(101, 23)
        Me.btnSchedule.TabIndex = 8
        Me.btnSchedule.Text = "Display Schedule"
        Me.btnSchedule.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(391, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "For Testing Only Push Once"
        '
        'btnCurriculum
        '
        Me.btnCurriculum.Location = New System.Drawing.Point(317, 99)
        Me.btnCurriculum.Name = "btnCurriculum"
        Me.btnCurriculum.Size = New System.Drawing.Size(101, 23)
        Me.btnCurriculum.TabIndex = 10
        Me.btnCurriculum.Text = "Display Curriculm"
        Me.btnCurriculum.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 379)
        Me.Controls.Add(Me.btnCurriculum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.btnStudents)
        Me.Controls.Add(Me.btnCourses)
        Me.Controls.Add(Me.btnCreateCurriculum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnCreateCurriculum As System.Windows.Forms.Button
    Friend WithEvents btnCourses As System.Windows.Forms.Button
    Friend WithEvents btnStudents As System.Windows.Forms.Button
    Friend WithEvents btnTeacher As System.Windows.Forms.Button
    Friend WithEvents btnRoom As System.Windows.Forms.Button
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents btnSchedule As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCurriculum As System.Windows.Forms.Button

End Class
