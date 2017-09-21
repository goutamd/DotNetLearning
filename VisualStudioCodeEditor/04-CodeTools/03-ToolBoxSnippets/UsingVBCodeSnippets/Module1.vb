

Module Module1

	Sub Main()
    Dim results = From fruit In New String() {"apple", "orange", "pear", "banana"} _
                Select fruit.ToUpper(), fruit.Length

    Dim count = results.Count
    
	End Sub

End Module
