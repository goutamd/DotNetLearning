using PublisherLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
	class ExampleA {

		internal void Refactor1() {
			// Simplify object initialization with an initializer
			Book b = new Book()
			{
				Title = "HLSL Pixel Shaders for WPF and Silverlight Developers",
				PublicationDate = DateTime.Now,
				CatalogNumber = 44534,
				Price = 45.00M,
				BookCoverType = CoverType.HardCover
			};
		}

		internal void Refactor2() {
			// move 'out' variable declarations inline
			string dateString = "2018/11/17";

			if (DateTime.TryParse(dateString, out DateTime outDate))
			{
				Console.WriteLine(outDate);
			}
			else
			{
				Console.WriteLine("Value is not a valid date.");
			}
		}

		internal void Refactor3(Book bestSellingBook, decimal newPrice) {
			//Convert String.Format to string interpolation

			string result = $"Change the price on the book '{bestSellingBook.Title}' to {newPrice:C}";

		}
		
		internal void Refactor4(Book bestSellingBook, decimal newPrice) {
			// Simplify null checks and throw expressions using null-coalescing operator

			
			if (bestSellingBook == null)
			{
				throw new ArgumentNullException(nameof(bestSellingBook));
			}
			else
			{

			}


			string bookTitle = bestSellingBook.Title;

			bookTitle = bestSellingBook.Title ?? throw new ArgumentNullException(nameof(bestSellingBook));
		}

		// Sync filename and type name.
		// Move type to matching file
	}
}
