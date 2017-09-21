using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo {
  class Financial {
    public static decimal CalculateMonthlyPayment(int numberOfMonths, decimal loanRate, decimal loanAmount) 
    {
      // simplified formula
      decimal perMonth = 0;
      decimal perMonthWithLoanRate = 0;

      if (loanAmount > 10000)
      {
        loanRate +=.5M;
      }
      
      perMonth = loanAmount / numberOfMonths;
      perMonthWithLoanRate = perMonth * loanRate;
      return perMonthWithLoanRate;

              {

              }
    }     
  }
}
