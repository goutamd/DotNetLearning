using TourBookingLib;

namespace UsingCsCodeSnippets
{
	class Program
	{
		static void Main(string[] args) {

			var t = new Tour();
			t.MultiDay = true;
			var price = t.GetTourPrice(tourId: 42, ticketType: TicketType.Kid);

			var b = new Book();
			b.Price = 55.95M;
			b.UpdatePrice(34, 120M);

		}
	}

	
}
