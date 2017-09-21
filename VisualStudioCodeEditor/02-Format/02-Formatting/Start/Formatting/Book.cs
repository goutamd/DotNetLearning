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


		public void UseFormatDocument()
		{
			// force formatting 
			int total=     0;
			int attendeeCount= 4;
													int result;
			for (int i = 0; i < 20; i++)
			{
				total += i;
			}
			result       = attendeeCount *     total;
		}
		public void DefaultCSharpRules()
		{
								

		}
	}
}
