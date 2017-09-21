using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorMyCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
			// refactor the variable name
      var book = new Book();
      string filePath = "C:\\demo.txt";

      // refactor the method name

      book.SaveBook(filePath, DateTime.Now, true);

      var b2 = new Book();
      b2.SaveBook(@"D:\otherfile.txt", DateTime.Now, false);

    }


  }
}
