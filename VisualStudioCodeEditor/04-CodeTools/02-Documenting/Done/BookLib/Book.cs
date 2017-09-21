using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TourBookingLib

{
	
 public class Book
  {

    public int ID { get; set; }
	 /// <summary>
	 /// The title of the book
	 /// </summary>
    public string Title { get; set; }
		/// <summary>
		/// The price of the book
		/// </summary>
    public decimal Price { get; set; }
		/// <summary>
		/// Update the Book Price
		/// </summary>
		/// <param name="bookId">The ID of the book</param>
		/// <param name="newPrice">The new price of the book</param>
    public void UpdatePrice(int bookId, decimal newPrice)
    {
      // code to update book
    }
		/// <summary>
		/// Update the Book Price
		/// </summary>
		/// <param name="bookId">The ID of the book</param>
		/// <param name="percentIncrease">The percent increase  of the book</param>
		public void UpdatePrice(int bookId, double percentIncrease)
    {
      // code to update the book.
    }
  }
}
