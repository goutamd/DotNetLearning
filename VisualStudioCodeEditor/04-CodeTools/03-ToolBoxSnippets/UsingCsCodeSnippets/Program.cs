using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCsCodeSnippets {
  class Program {
    static void Main(string[] args) {

      // our standard list of variables
      var book = new Book();
      book.Author = "Walt Ritscher";
      book.Title = "HLSL and Pixel Shaders";
      var library = new Library();

      library.Books.Add(book);


    }
  }


}
