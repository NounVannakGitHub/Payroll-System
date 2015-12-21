Public Class TaxForSalary
    Private Shadows Const RENT_MOTOR As String = "Rent Motor"
    Private Shadows Const POSITION As String = "Position"
    Private Shadows Const INCENTIVE As String = "Incentive"
    Private Shadows Const REGIONAL_ALLOWANCE As String = "Regional Allowance"
    Private Shadows Const TRANSPORT_ALLOWANCE As String = "Transport Allowance"
    Private Shadows Const OVERTIME As String = "Over Time"
    Private Shadows Const INCREDIBLE As String = "Incredible"
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

    Function CreateBasicSalary(basicSalary As String, taxSpouse As String, taxChild As String) As Double
        Dim basic As Double = 0
        Try
            basic = CDbl(basicSalary) - (CDbl(taxSpouse) + CDbl(taxChild))
        Catch ex As Exception
            basic = 0
        End Try
        Return basic
    End Function

    Function CreateNetBase(basic As String, award As String, adjust As String, incre As String, decre As String, sal13 As String, sal14 As String, checkBoxIncre As CheckBox) As Double
        Dim netBase As Double = 0
        Try
            If checkBoxIncre.Checked = True Then
                netBase = CDbl(basic) + (CDbl(award) + CDbl(adjust) + CDbl(incre) + CDbl(sal13) + CDbl(sal14))
            ElseIf checkBoxIncre.Checked = False Then
                netBase = (CDbl(basic) + (CDbl(award) + CDbl(adjust) + CDbl(sal13) + CDbl(sal14))) - CDbl(decre)
            Else
                netBase = (CDbl(basic) + (CDbl(award) + CDbl(adjust) + CDbl(sal13) + CDbl(sal14)))
            End If
        Catch ex As Exception
            netBase = 0
        End Try
        Return netBase
    End Function

    Function CreateSalaryBeforeTax(netbase As String, incentive As String, reginal As String, transport As String, overtime As String) As Double
        Dim persent As Double = 0
        Dim afPersent As Double = 0
        Dim newNetBase As Double = 0
        Try
            afPersent = (CDbl(incentive) + CDbl(reginal) + CDbl(transport) + CDbl(overtime))
            persent = afPersent * 0.2
            newNetBase = CDbl(netbase) + (afPersent - persent)
        Catch ex As Exception
            newNetBase = 0
        End Try
        Return newNetBase
    End Function

    Function CreateSubTotal(beforeTax As String, taxPersent As String) As Double
        Dim total As Double = 0
        Try
            If taxPersent.Equals("5%") Then
                total = CDbl(beforeTax) - 40000
            ElseIf taxPersent.Equals("10%") Then
                total = CDbl(beforeTax) - 102500
            ElseIf taxPersent.Equals("15%") Then
                total = CDbl(beforeTax) - 527500
            ElseIf taxPersent.Equals("20%") Then
                total = CDbl(beforeTax) - 1152500
            Else
                total = CDbl(beforeTax)
            End If
        Catch ex As Exception
            total = 0
        End Try
        Return total
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
