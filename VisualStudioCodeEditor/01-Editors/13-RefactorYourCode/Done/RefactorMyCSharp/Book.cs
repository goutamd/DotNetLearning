using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RefactorMyCSharp
{
  class Book : IBook
	{
    public string Title { get; set; }
    public decimal Price { get; set; }

    // rename parameter  (overwriteExisting).  It has a typo
    // reorder parameters
    public void SaveBook(string fileLocation, DateTime timeStamp, bool overwriteExisting)
		{
      FileStream fs;
      if (overwriteExisting)
      {
        fs = new FileStream(fileLocation, FileMode.Create);
      }
      else
      {
        fs = new FileStream(fileLocation, FileMode.Open);

      }


    }
  }
}
