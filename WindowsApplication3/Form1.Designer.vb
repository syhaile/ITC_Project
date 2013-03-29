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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnCourses = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateCurriculum
        '
        Me.btnCreateCurriculum.Location = New System.Drawing.Point(335, 82)
        Me.btnCreateCurriculum.Name = "btnCreateCurriculum"
        Me.btnCreateCurriculum.Size = New System.Drawing.Size(139, 23)
        Me.btnCreateCurriculum.TabIndex = 1
        Me.btnCreateCurriculum.Text = "Create Curriculum"
        Me.btnCreateCurriculum.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(195, 203)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(299, 95)
        Me.ListBox1.TabIndex = 2
        '
        'btnCourses
        '
        Me.btnCourses.Location = New System.Drawing.Point(335, 126)
        Me.btnCourses.Name = "btnCourses"
        Me.btnCourses.Size = New System.Drawing.Size(109, 23)
        Me.btnCourses.TabIndex = 3
        Me.btnCourses.Text = "Display Courses"
        Me.btnCourses.UseVisualStyleBackColor = True
        '
        'btnStudents
        '
        Me.btnStudents.Location = New System.Drawing.Point(335, 156)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(109, 23)
        Me.btnStudents.TabIndex = 4
        Me.btnStudents.Text = "Display Students"
        Me.btnStudents.UseVisualStyleBackColor = True
        '
        'btnTeacher
        '
        Me.btnTeacher.Location = New System.Drawing.Point(217, 126)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(101, 23)
        Me.btnTeacher.TabIndex = 5
        Me.btnTeacher.Text = "Display Teachers"
        Me.btnTeacher.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 379)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.btnStudents)
        Me.Controls.Add(Me.btnCourses)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnCreateCurriculum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateCurriculum As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnCourses As System.Windows.Forms.Button
    Friend WithEvents btnStudents As System.Windows.Forms.Button
    Friend WithEvents btnTeacher As System.Windows.Forms.Button

End Class
