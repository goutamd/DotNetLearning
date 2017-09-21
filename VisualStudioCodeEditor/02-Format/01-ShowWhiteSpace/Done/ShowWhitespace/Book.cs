using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormattingYourCode
{
    class Book
    {

      public string Title { get; set; }
            public decimal Price { get; set; }
            public void SampleMethod()
        {

        }

        public void SmartIndenting()
        {
      // change the smart indent to 
      // None or Smart
      // write code here to demonstrate
      if (true)
      {
            



      }


        }
        public void WorkingWithTabs()
        {
      // you control whether to use spaces or tabs

      // use tabs to align declarations
      int     attendeeHeadcount = 6500;
      decimal ticketCost =        45.00M;
      decimal grossSales =        attendeeHeadcount * ticketCost;
        }

        public void TabifyDemo()
        {
            // nobody likes mixed spaces and tabs
            // Tabify, Untabify provide 
            // a way to use a consistant set of tabs or spaces
        }


    }
}
