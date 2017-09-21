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
      var b = new Book();
      string filePath = "C:\\demo.txt";

      // refactor the method name

      b.SaveBook(filePath, true, DateTime.Now);

      var b2 = new Book();
      b2.SaveBook(@"D:\otherfile.txt", false, DateTime.Now);

    }


  }
}
