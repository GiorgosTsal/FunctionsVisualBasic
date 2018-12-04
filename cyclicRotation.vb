
Private Function solution(A As Integer(), K As Integer) As Integer()
  
  Dim size As Integer = A.Length
  Dim myArray(size), i, thesi As integer
  Dim arrayToReturn(size-1) As Integer 
  Dim noRepeat = K MOD size
  'Console.WriteLine("to size einai  " & size)
 ' console.WriteLine("To norepeat einai " &noRepeat)
  if(size>0 AND noRepeat>0) Then 

        for i = 0 To size-1
    
        Dim thesi As Integer = i + noRepeat
      '  Console.WriteLine("Prin mpei i thesi einai  " & thesi)
            if(thesi>size-1) Then 
                thesi = thesi -size
            '    Console.WriteLine("mpenei otan h thesi einai  " & thesi)
            End if
           ' Console.WriteLine("Grafei ston pinaka otan h thesi einai  " & thesi)
           myArray(thesi)=A(i)    
        
        Next
     'Console.WriteLine("To teleutaio stoixeio tou pinaka myArray einai " &myArray(size))
        
    'Antimeto piza to eksis provlima. Egrafe se kathe pinaka +1 stoixeio opou evaze to 0. Den mporesa na vro giati to ekane kai to ekana me mpakaliko tropo afairontas to teleutaio stoixeio
    
    Array.Copy(myArray, arrayToReturn, arrayToReturn.Length)
    for i = 0 To arrayToReturn.Length-1
       ' Console.WriteLine("Ta stoixeia tou neou pinaka einai  " &arrayToReturn(i))
    next
    
    
  else
    arrayToReturn = A
  
  End if 
  return arrayToReturn
  
End Function