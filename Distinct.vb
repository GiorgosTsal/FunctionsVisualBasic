' you can write to stdout for debugging purposes, e.g.
' Console.WriteLine("this is a debug message")

Private Function solution(A As Integer()) As Integer
    
    Dim arrayLength, i, numOfDistinctNumbers As Integer 
    arrayLength= A.length
    numOfDistinctNumbers=1
  ' Console.WriteLine("The arrays lenght is: " & arrayLength)
    If(arrayLength = 0) Then
        numOfDistinctNumbers=0
        Else
         Array.Sort(A) 'taksinomo ton pinaka gia na eksasfalisti monadikotita   
      
      
        For i=1 To arrayLength-1 
            
             
            
            if A(i)<>A(i-1) then 
                numOfDistinctNumbers +=1
             
            End If
         
        Next
    End If
    
 ' Console.WriteLine("The distinct lenght is: " & numOfDistinctNumbers)    
            
return numOfDistinctNumbers
    
End Function