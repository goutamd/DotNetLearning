Public Class CodeStyle

	Private _customerName As String
	Public Property CustomerName() As String
		Get
			Return _customerName
		End Get
		Set(ByVal value As String)
			_customerName = value
		End Set
	End Property

	Public Sub PreferFrameworkTypes(input As System.Int64)
    ' Visual Basic LightBulb defaults to the VB primitive name over .NET types
    ' 
    ' Dim x as Integer , instead of 
    ' Dim x as System.Int32

    Dim x As System.Int32
		Dim y As System.Int16

		Console.WriteLine(x)
		Console.WriteLine(y)
		CustomerName = "Jack"

		While x > 10

		End While


	End Sub

End Class
