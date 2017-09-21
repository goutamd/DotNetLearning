Imports RefactorMyVB
Module Module1

  Sub Main()


    ' refactor the variable name
    Dim b = New RefactorMyVB.Book
    Dim filePath As String = "C:\demo.txt"

    ' refactor the method name

    b.SaveBook(filePath, True, Date.Now)


    Dim b2 = New RefactorMyVB.Book
    b2.SaveBook("D:\otherfile.txt", False, Date.Now)
  End Sub

End Module
