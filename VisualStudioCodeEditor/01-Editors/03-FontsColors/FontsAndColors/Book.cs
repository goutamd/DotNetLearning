using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FontsAndColors
{
  public class Book
  {
    // classes contain data and code
    public string Title { get; set; }
    public decimal Price { get; set; }

    public void SampleMethod()
    {
      // comments 
      
      // matching braces
      if (true)
      {
        for (int i = 0; i < 3; i++)
        {
          switch (i)
          {
            default:
              break;
          }
        }
      }
    }

  }

  public struct FileInformation
  {
    // structs are primarily for data stores
    public string FileName { get; set; }
  }
}
