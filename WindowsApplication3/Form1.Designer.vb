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
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCreateCurriculum
        '
        Me.btnCreateCurriculum.Location = New System.Drawing.Point(79, 12)
        Me.btnCreateCurriculum.Name = "btnCreateCurriculum"
        Me.btnCreateCurriculum.Size = New System.Drawing.Size(139, 23)
        Me.btnCreateCurriculum.TabIndex = 1
        Me.btnCreateCurriculum.Text = "Create test data"
        Me.btnCreateCurriculum.UseVisualStyleBackColor = True
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(108, 195)
        Me.txtArea.Multiline = True
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArea.Size = New System.Drawing.Size(377, 159)
        Me.txtArea.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "For Testing Only Push Once"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 379)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.btnCreateCurriculum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateCurriculum As System.Windows.Forms.Button
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
