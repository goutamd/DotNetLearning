using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TourBookingLib

{
	
 public class Book
  {

    public int ID { get; set; }
	
    public string Title { get; set; }
		
    public decimal Price { get; set; }

    public void UpdatePrice(int bookId, decimal newPrice)
    {
      // code to update book
    }
    
		public void UpdatePrice(int bookId, double percentIncrease)
    {
      // code to update the book.
    }
  }
}
