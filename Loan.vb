Public Class Loan
    Private _loanId As String
    Private _loanAmount As Double
    Private _loanPay As Double
    Private _loanRate As Double
    Private _loanStartDate As String
    Private _loanEndDate As String
    Private _loanType As String
    Private _employee As Employee
    Public Property LoanId As String
        Get
            Return _loanId
        End Get
        Set(value As String)
            _loanId = value
        End Set
    End Property

    Public Property LoanAmount As Double
        Get
            Return _loanAmount
        End Get
        Set(value As Double)
            _loanAmount = value
        End Set
    End Property

    Public Property LoanPay As Double
        Get
            Return _loanPay
        End Get
        Set(value As Double)
            _loanPay = value
        End Set
    End Property

    Public Property LoanStartDate As String
        Get
            Return _loanStartDate
        End Get
        Set(value As String)
            _loanStartDate = value
        End Set
    End Property

    Public Property LoanEndDate As String
        Get
            Return _loanEndDate
        End Get
        Set(value As String)
            _loanEndDate = value
        End Set
    End Property

    Public Property LoanType As String
        Get
            Return _loanType
        End Get
        Set(value As String)
            _loanType = value
        End Set
    End Property
    Public Property Employee As Employee
        Get
            Return _employee
        End Get
        Set(value As Employee)
            _employee = value
        End Set
    End Property
    Public Property LoanRate As Double
        Get
            Return _loanRate
        End Get
        Set(value As Double)
            _loanRate = value
        End Set
    End Property
End Class
