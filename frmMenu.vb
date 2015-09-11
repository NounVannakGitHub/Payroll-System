Public Class frmMenu
    Private Sub BonusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonusToolStripMenuItem.Click
        'With frmBonus
        '    .MdiParent = Me
        '    .Dock = DockStyle.Fill
        '    .Show()
        '    .Activate()
        'End With
    End Sub

    Private Sub BenefitDeductionTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BenefitDeductionTypeToolStripMenuItem.Click
        With frmBenefitAndDeductionType
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        With frmEmployeeInformation
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub
End Class