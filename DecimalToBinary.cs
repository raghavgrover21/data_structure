using System;
using System.Collections.Generic;
namespace randomprogzcsharp
{
        //Convert a decimal number to binary
    class Program
    {
       
        static void Main(string[] args)
        {
           Program ob1 = new Program();
          
          string answer= ob1.DecToBinary(100);
          
          char []result=answer.ToCharArray();
          
          Array.Reverse(result);
        
          Console.WriteLine(result);
        }
    
        string DecToBinary(int val)
        {      
            string res=null;
        
            int rem=0;            
            while(val>0)
            {
                rem=val%2;
            
                res=res+rem.ToString();
            
                val=val/2;
            }
        return res;
        }
    }
}

