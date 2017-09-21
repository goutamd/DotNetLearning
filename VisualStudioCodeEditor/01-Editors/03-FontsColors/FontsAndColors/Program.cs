using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontsAndColors
{
	class Program
	{
		static void Main(string[] args)
		{
            // a great programming typeface (font)
            // has clean letter shapes, distinguishable punctuation ; : < > . ,
            // and ensures that similar charactors are easy to tell apart
            // The letter l, versus the number 1
            // The letter o, versus the number 0
            // Curly braces { } versus parenthesis ( )

            // most developer prefer monospace fonts
            // find a definitive list of them at
            // https://github.com/chrissimpkins/codeface




            // user defined types can be customized
            var b = new Book();
			// value types can be customized
			var fi = new FileInformation();

			// string can be customized

			fi.FileName = "demo.txt";
			// verbatim strings too.
			var directoryName = @"d:\sample\path\";
		}
	}
}
