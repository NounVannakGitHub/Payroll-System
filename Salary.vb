Public Class Salary
    Private pEmployeeID As String
    Private pLastName As String
    Private pFirstName As String
    Private pBasicSalary As String
    Private pTaxChild As String
    Private pTaxSpouse As String
    Private pBasicSalary2 As String
    Private pAnnualAward As String
    Private pAdjust As String
    Private pIncre As String
    Private pDecre As String
    Private pThird As String
    Private pFour As String
    Private pNetBase As String
    Private pIncentive As String
    Private pReginal As String
    Private pTransport As String
    Private pOverTime As String
    Private pSalaryBeforeTax As String
    Private pTax As String
    Private pSubTotal As String
    Private pDateFrom As String
    Private pDateTo As String

    Sub New(id As String, salary As String, dateTo As String)
        pEmployeeID = id
        pTaxSpouse = salary
        pDateTo = dateTo
    End Sub

    Sub New(id As String, ln As String, fn As String, bs1 As String, tc As String, ts As String, bs2 As String, aa As String, ad As String, inc As String, decr As String, thrid As String, four As String, nb As String, ince As String, re As String, tran As String, ot As String, sbt As String, tax As String, st As String, df As String, dt As String)
        pEmployeeID = id
        pLastName = ln
        pFirstName = fn
        pBasicSalary = bs1
        pTaxChild = tc
        pTaxSpouse = ts
        pBasicSalary2 = bs2
        pAnnualAward = aa
        pAdjust = ad
        pIncre = inc
        pDecre = decr
        pNetBase = nb
        pIncentive = ince
        pReginal = re
        pTransport = tran
        pOverTime = ot
        pSalaryBeforeTax = sbt
        pTax = tax
        pSubTotal = st
        pDateFrom = df
        pDateTo = dt
        pThird = thrid
        pFour = four
    End Sub

    Public Property ThirdteenSalary As String
        Get
            Return pThird
        End Get
        Set(value As String)
            pThird = value
        End Set
    End Property

    Public Property FourteenSalary As String
        Get
            Return pFour
        End Get
        Set(value As String)
            pFour = value
        End Set
    End Property

    Public Property EmployeeID As String
        Get
            Return pEmployeeID
        End Get
        Set(value As String)
            pEmployeeID = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return pLastName
        End Get
        Set(value As String)
            pLastName = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return pFirstName
        End Get
        Set(value As String)
            pFirstName = value
        End Set
    End Property

    Public Property BasicSalary1 As String
        Get
            Return pBasicSalary
        End Get
        Set(value As String)
            pBasicSalary = value
        End Set
    End Property
    Public Property TaxSpouse As String
        Get
            Return pTaxSpouse
        End Get
        Set(value As String)
            pTaxSpouse = value
        End Set
    End Property

    Public Property Tax As String
        Get
            Return pTax
        End Get
        Set(value As String)
            pTax = value
        End Set
    End Property

    Public Property TaxChild As String
        Get
            Return pTaxChild
        End Get
        Set(value As String)
            pTaxChild = value
        End Set
    End Property

    Public Property BasicSalary2 As String
        Get
            Return pBasicSalary2
        End Get
        Set(value As String)
            pBasicSalary2 = value
        End Set
    End Property

    Public Property AnnualAward As String
        Get
            Return pAnnualAward
        End Get
        Set(value As String)
            pAnnualAward = value
        End Set
    End Property
    Public Property Adjust As String
        Get
            Return pAdjust
        End Get
        Set(value As String)
            pAdjust = value
        End Set
    End Property
    Public Property Incre As String
        Get
            Return pIncre
        End Get
        Set(value As String)
            pIncre = value
        End Set
    End Property

    Public Property Decre As String
        Get
            Return pDecre
        End Get
        Set(value As String)
            pDecre = value
        End Set
    End Property
    Public Property NetBase As String
        Get
            Return pNetBase
        End Get
        Set(value As String)
            pNetBase = value
        End Set
    End Property
    Public Property Incentive As String
        Get
            Return pIncentive
        End Get
        Set(value As String)
            pIncentive = value
        End Set
    End Property

    Public Property Reginal As String
        Get
            Return pReginal
        End Get
        Set(value As String)
            pReginal = value
        End Set
    End Property
    Public Property Transport As String
        Get
            Return pTransport
        End Get
        Set(value As String)
            pTransport = value
        End Set
    End Property

    Public Property OverTime As String
        Get
            Return pOverTime
        End Get
        Set(value As String)
            pOverTime = value
        End Set
    End Property
    Public Property SalaryBeforeTax As String
        Get
            Return pSalaryBeforeTax
        End Get
        Set(value As String)
            pSalaryBeforeTax = value
        End Set
    End Property
    Public Property SubTotal As String
        Get
            Return pSubTotal
        End Get
        Set(value As String)
            pSubTotal = value
        End Set
    End Property
    Public Property DateFrom As String
        Get
            Return pDateFrom
        End Get
        Set(value As String)
            pDateFrom = value
        End Set
    End Property
    Public Property DateTo As String
        Get
            Return pDateTo
        End Get
        Set(value As String)
            pDateTo = value
        End Set
    End Property
End Class
