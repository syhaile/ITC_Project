Public Class CurriculumView
    Dim MyLabels()

    Private Sub CurriculumView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub

    Private Sub CurriculumView_Load( sender As Object,  e As EventArgs) Handles MyBase.Load
            
    End Sub

    Private Sub lblTopLeft_MouseHover(sender As Object, e As EventArgs) 
        lblTopLeft.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub lblTopCenter_MouseClick(sender As Object, e As EventArgs) Handles lblTopCenter.MouseClick
        lblTopCenter.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub lblTopRight_MouseHover(sender As Object, e As EventArgs) 
        lblTopRight.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub lblBottomLeft_MouseHover(sender As Object, e As EventArgs) 
        lblBottomLeft.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub lblBottomCenter_MouseHover(sender As Object, e As EventArgs) 
        lblBottomCenter.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub lblBottomRight_MouseHover(sender As Object, e As EventArgs) 
        lblBottomRight.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub lblNext_MouseHover( sender As Object,  e As EventArgs)
        lblNext.BackColor = SystemColors.ControlDarkDark
    End Sub
    Private Sub lblBack_MouseHover(sender As Object, e As EventArgs)
        lblBack.BackColor = SystemColors.ControlDarkDark
    End Sub
End Class