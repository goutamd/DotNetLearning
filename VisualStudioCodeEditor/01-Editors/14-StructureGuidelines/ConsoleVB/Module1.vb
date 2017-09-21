Module Module1

  Sub Main()

  End Sub

  Public Function CalculateMonthlyPayment(numberOfMonths As Integer,
                                          loanRate As Decimal,
                                          loanAmount As Decimal) As Decimal

    ' simplified formula
    Dim perMonth As Decimal = 0
    Dim perMonthWithLoanRate As Decimal = 0

    If loanAmount > 10000 Then
      loanRate = loanRate - 0.5
    End If
    perMonth = loanAmount / numberOfMonths
    perMonthWithLoanRate = perMonth * loanRate
    Return perMonthWithLoanRate

  End Function

End Module
