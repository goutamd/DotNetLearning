using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TourBookingLib
{
	/// <summary>
	/// Represents a tour in the TourBooking system
	/// </summary>
	/// <example>
	/// var t = new Tour();
	/// </example>
	public class Tour
	{
		/// <summary>
		/// The default constructor
		/// </summary>
		public Tour()
		{

		}

		/// <summary>
		/// A constructor that takes the TourName
		/// </summary>
		/// <param name="tourName">
		/// <remarks> The initial name of the tour</remarks>
		/// <example>
		/// var t = new Tour("Gold Coast");
		/// </example>
		/// </param>
		public Tour(string tourName)
		{
			this.TourName = tourName;
		}

		/// <summary>
		/// Indicates the unique Tour ID
		/// </summary>
		public int TourId { get; set; }

		/// <summary>
		/// The TourName
		/// </summary>
		public string TourName { get; set; }
		/// <summary>
		/// Indicates whether the tour has a senior discount available.
		/// </summary>
		public bool SeniorDiscountAvailable { get; set; }
		/// <summary>
		///  Indicates whether the tour is appropriate for kids.
		/// </summary>
		public bool KidFriendly { get; set; }
		/// <summary>
		/// Indicates whether the tour lasts for more than one day
		/// </summary>
		public bool MultiDay { get; set; }
		/// <summary>
		/// Indicates how many people are permitted on the tour.
		/// </summary>
		public int MaxPeoplePerTour { get; set; }
		/// <summary>
		/// URL for tour Image
		/// </summary>
		public string TourImage { get; set; }

		/// <summary>
		/// Get the Tour price
		/// </summary>
		/// <param name="tourId">Specify the unique Tour ID</param>
		/// <param name="ticketType" >Provide the Ticket type.</param>
		/// <returns>Current price for a tour, based on ticket type.  Amount in USD.</returns>
		public Decimal GetTourPrice(int tourId, TicketType ticketType)
		{
	
			return 10M;
		}
	}
	/// <summary>
	/// Enum of the Ticket Type
	/// </summary>
	public enum TicketType
	{
		/// <summary>
		/// Normal customer
		/// </summary>
		Normal,
		/// <summary>
		/// Kid customer
		/// </summary>
		Kid,
		/// <summary>
		/// Senior customer (over 55)
		/// </summary>
		Senior
	}
}

