using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingClassWindows.BookSeller
{
  class Employee : Person
  {
    public string SSN { get; set; }
    public DateTime HireDate { get; set; }
    public bool IsActive { get; set; }
  }
}
