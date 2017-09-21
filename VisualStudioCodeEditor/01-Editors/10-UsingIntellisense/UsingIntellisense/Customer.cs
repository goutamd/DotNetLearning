using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingIntellisense
{
  class Customer
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FullName { get; set; }

    internal void Save()
    {
      throw new NotImplementedException();
    }
  }
}
