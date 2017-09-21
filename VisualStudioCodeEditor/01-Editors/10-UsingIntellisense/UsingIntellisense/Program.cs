using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;



namespace UsingIntellisense
{
	class Program
	{
		static void Main(string[] args)
		{

      // Show ListMembers
			// AKA Auto Complete
      // Ctrl-J



      // Finish auto-complete with
      // Mouse, Tab, Spacebar, Parenthesis, Semicolon



      // Fix issues with code with Ctrl-Spacebar
      // AKA CompleteWord
     
			var c = new Customer
			{
				FirstName = "Joe",
				LastName = "Smith"
			};


      // Use Parameter Info to show information
      // Ctrl-Shift-Spacebar

      
			Console.WriteLine(c.FullName);
			c.Save();


      // Use Ctrl-Period to expand Smart Tags
      // Quick Action (Light Bulb) rplaces most smart tags in VS 2015

		}

   
	}
}
