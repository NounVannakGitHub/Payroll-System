Public Class frmMenu
    Private Sub BonusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles toolBonus.Click
        With frmBonusInfo
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub BenefitDeductionTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BenefitDeductionTypeToolStripMenuItem.Click
        'With frmBenefitAndDeductionType
        '    .MdiParent = Me
        '    .Dock = DockStyle.Fill
        '    .Show()
        '    .Activate()
        'End With
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        With frmEmployeeInformation
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub toolAttendance_Click(sender As Object, e As EventArgs) Handles toolAttendance.Click
        With frmAttendance
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With

    End Sub
End Class