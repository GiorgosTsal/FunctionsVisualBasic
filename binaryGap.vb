
Private Function solution(N As Integer) As Integer
    
    Dim converted As String = Convert.ToString(N,2)
    
    Dim size As Integer = converted.Length
    
    'Console.WriteLine(converted & "  "&size)
    Dim maxLength As Integer = 0
    
        if(size>0) Then 
            
            Dim gaps As integer = 0 
                For i As integer = 1 To size-1
                   
                    if(converted.chars(i)= "0" and converted.chars(i-1)="1") Then
                        gaps=1
                    elseif(converted.chars(i)="0" and converted.chars(i-1)="0") Then
                        gaps+=1
                    elseif(converted.chars(i)="1" and converted.chars(i-1)="0") Then
                        maxLength = Math.Max(maxLength,gaps)
                    End If    
    '                Console.WriteLine(maxLength & "  "&gaps)
                    
                Next
    
        End if
      '   Console.WriteLine("To max binary gap einai: " &maxLength )
         return maxLength
End Function