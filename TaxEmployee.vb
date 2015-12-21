Public Class TaxEmployee
    Private pTaxId As String
    Private pEmployeeId As String
    Private pLastName As String
    Private pFirstName As String
    Private pGender As String
    Private pStatus As String
    Private pDapartment As String
    Private pPosition As String
    Private pSalary As String
    Private pSalaryTaxPersent As String
    Private pSLastName As String
    Private pSFirstName As String
    Private pSGender As String
    Private pSJob As String
    Private pChild As String
    Private pChildQty As String
    Private pTaxSpouse As String
    Private pTaxChild As String
    Private pTaxChildTotal As String

    Sub New(aTaxId As String, aEmployeeId As String, aLastName As String, aFirstName As String, aGender As String, aStatus As String, aDapartment As String, aPosition As String, aSalary As String, aSalaryTaxPersent As String, aSLastName As String, aSFirstName As String, aSGender As String, aSJob As String, aChild As String, aChildQty As String, aTaxSpouse As String, aTaxChild As String, aTaxChildTotal As String)
        pTaxId = aTaxId
        pEmployeeId = aEmployeeId
        pLastName = aLastName
        pFirstName = aFirstName
        pGender = aGender
        pStatus = aStatus
        pDapartment = aDapartment
        pPosition = aPosition
        pSalary = aSalary
        pSalaryTaxPersent = aSalaryTaxPersent
        pSLastName = aSLastName
        pSFirstName = aSFirstName
        pSGender = aSGender
        pSJob = aSJob
        pChild = aChild
        pChildQty = aChildQty
        pTaxSpouse = aTaxSpouse
        pTaxChild = aTaxChild
        pTaxChildTotal = aTaxChildTotal
    End Sub

    Public Overrides Function ToString() As String
        Return "EmpLName=N'" & pLastName & "',EmpFName=N'" & pFirstName & "',EmpGender=N'" & pGender & "',EmpStatus=N'" & pStatus & "',Department=N'" & pDapartment & "',Position='" & pPosition & "',EmpSalary='" & pSalary & "',EmpTaxSalary='" & pSalaryTaxPersent & "',SpouseLName=N'" & pSLastName & "',SpouseFName=N'" & pSFirstName & "',SpouseGender=N'" & pSGender & "',SpouseJob=N'" & pSJob & "',Child=N'" & pChild & "',ChildQty='" & pChildQty & "',ChildTax'" & pTaxChild & "',ChildTaxTotal='" & pTaxChildTotal & "'"
    End Function

    Public Property TaxId() As String
        Get
            Return pTaxId
        End Get
        Set(ByVal value As String)
            pTaxId = value
        End Set
    End Property

    Public Property EmployeeID As String
        Get
            Return pEmployeeId
        End Get
        Set(value As String)
            pEmployeeId = value
        End Set
    End Property

    Public Property EmployeeLastName As String
        Get
            Return pLastName
        End Get
        Set(value As String)
            pLastName = value
        End Set
    End Property

    Public Property EmployeeFirstName As String
        Get
            Return pFirstName
        End Get
        Set(value As String)
            pFirstName = value
        End Set
    End Property

    Public Property EmployeeGender As String
        Get
            Return pGender
        End Get
        Set(value As String)
            pGender = value
        End Set
    End Property

    Public Property EmployeeStatus As String
        Get
            Return pStatus
        End Get
        Set(value As String)
            pStatus = value
        End Set
    End Property

    Public Property Department As String
        Get
            Return pDapartment
        End Get
        Set(value As String)
            pDapartment = value
        End Set
    End Property

    Public Property Position As String
        Get
            Return pPosition
        End Get
        Set(value As String)
            pPosition = value
        End Set
    End Property

    Public Property Salary As String
        Get
            Return pSalary
        End Get
        Set(value As String)
            pSalary = value
        End Set
    End Property

    Public Property Persent As String
        Get
            Return pSalaryTaxPersent
        End Get
        Set(value As String)
            pSalaryTaxPersent = value
        End Set
    End Property

    Public Property SLastName As String
        Get
            Return pSLastName
        End Get
        Set(value As String)
            pSLastName = value
        End Set
    End Property
    Public Property SFirstName As String
        Get
            Return pSFirstName
        End Get
        Set(value As String)
            pSFirstName = value
        End Set
    End Property

    Public Property SGender As String
        Get
            Return pSGender
        End Get
        Set(value As String)
            pSGender = value
        End Set
    End Property

    Public Property SJob As String
        Get
            Return pSJob
        End Get
        Set(value As String)
            pSJob = value
        End Set
    End Property

    Public Property Child As String
        Get
            Return pChild
        End Get
        Set(value As String)
            pChild = value
        End Set
    End Property

    Public Property ChildQty As String
        Get
            Return pChildQty
        End Get
        Set(value As String)
            pChildQty = value
        End Set
    End Property

    Public Property TaxForSpouse As String
        Get
            Return pTaxSpouse
        End Get
        Set(value As String)
            pTaxSpouse = value
        End Set
    End Property

    Public Property TaxForChild As String
        Get
            Return pTaxChild
        End Get
        Set(value As String)
            pTaxChild = value
        End Set
    End Property

    Public Property TaxForChildTotal As String
        Get
            Return pTaxChildTotal
        End Get
        Set(value As String)
            pTaxChildTotal = value
        End Set
    End Property

End Class
