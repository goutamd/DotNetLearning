using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploringCSharpEditor
{
  struct Samples
  {
    int SampleField;
    public int SampleProperty { get; set; }
  }


  // need to ask Matt what naming convention to use for this class
  class SampleClass
  {
    void OpenFile()
    {
      // We need to write the error handler
      // This code relies on Edward's fragile timing hack.  PLEASE FIX
    }
    void SaveFile()
    {
      // this code does not save correctly to shared drives
    }
  }

  
}
