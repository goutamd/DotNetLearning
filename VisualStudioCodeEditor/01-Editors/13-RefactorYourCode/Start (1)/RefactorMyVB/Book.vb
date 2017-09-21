Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO

Namespace RefactorMyVB

  Friend Class Book
	Public Property Title() As String
	Public Property Price() As Decimal

	' rename parameter  (overwriteExisting).  It has a typo
	' reorder parameters
	Public Sub SaveBook(ByVal fileLocation As String, ByVal overwriteExising As Boolean, ByVal timeStamp As Date)
	  Dim fs As FileStream
	  If overwriteExising Then
		fs = New FileStream(fileLocation, FileMode.Create)
	  Else
		fs = New FileStream(fileLocation, FileMode.Open)

	  End If


	End Sub
  End Class
End Namespace