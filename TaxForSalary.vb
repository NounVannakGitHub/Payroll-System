Public Class TaxForSalary
    Private Shadows Const RENT_MOTOR As String = "Rent Motor"
    Private Shadows Const POSITION As String = "Position"
    Private Shadows Const INCENTIVE As String = "Incentive"
    Private Shadows Const REGIONAL_ALLOWANCE As String = "Regional Allowance"
    Private Shadows Const TRANSPORT_ALLOWANCE As String = "Transport Allowance"
    Private Shadows Const OVERTIME As String = "Over Time"
    Private Shadows Const INCREDIBLE As String = "Incredible"
    Function CreateNetBase(ByVal baseSalary As Double, ByVal bonus As Double) As Double
        Dim netBase As Double = 0.0
        If (baseSalary <= SalaryTax.EIGHTY) Then
            netBase = baseSalary + bonus
        End If

        Return netBase
    End Function
    Function CreateBonus(ByVal bonusType As String, ByVal bonusValue As Double) As Double
        Dim taxBonus As Double = 0.0
        If bonusType.Equals(TaxForSalary.RENT_MOTOR) Then
            taxBonus = bonusValue - (bonusValue * SalaryTax.RENT_MOTOR)
        ElseIf bonusType.Equals(TaxForSalary.POSITION) Then
            taxBonus = bonusValue - (bonusValue * SalaryTax.POSITION)
        ElseIf bonusType.Equals(TaxForSalary.REGIONAL_ALLOWANCE) Then
            taxBonus = bonusValue - (bonusValue * SalaryTax.REGIONAL_ALLOWANCE)
        ElseIf bonusType.Equals(TaxForSalary.TRANSPORT_ALLOWANCE) Then
            taxBonus = bonusValue - (bonusValue * SalaryTax.TRANSPORT_ALLOWANCE)
        ElseIf bonusType.Equals(TaxForSalary.INCENTIVE) Then
            taxBonus = bonusValue - (bonusValue * SalaryTax.INCENTIVE)
        ElseIf taxBonus.Equals(TaxForSalary.OVERTIME) Then
            taxBonus = bonusValue - (bonusValue * SalaryTax.OVERTIME)
        End If
        Return taxBonus
    End Function
    Function FindIncre(ByVal increValue As Double, ByVal increType As String) As Double
        Dim incre As Double = 0.0
        If increType.Equals(TaxForSalary.INCREDIBLE) Then
            incre = increValue - (increValue * SalaryTax.INCREDIBLE)
        Else
            incre = increValue
        End If
        Return incre
    End Function
End Class
