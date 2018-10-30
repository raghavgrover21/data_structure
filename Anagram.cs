using System;
using System.Collections.Generic;
namespace randomprogzcsharp
{
    //Check if given 2 strings are anagram or not 
    class Program
    {
       
        static void Main(string[] args)
        {
            string a="abcdef";
            string b="bcdaef";
            
            Program obj = new Program();
            
            int res = obj.Anagram(a,b);

            if(res==1) Console.WriteLine("Yes its an anagram");
            else    Console.WriteLine("not an anagram");
            

        }
        int Anagram(string a ,string b)
        {
            Dictionary<char,int> ob1 = new Dictionary<char,int>();
            int count=1;
         
            if(a.Length!=b.Length) return 0;
            
            else
            {
                foreach (char c in a)
                {
                    ob1.Add(c,1);
                }
                foreach(char c in b)
                {
                    if(ob1.ContainsKey(c))
                    {
                         continue;
                    }
                    else 
                    {
                        count=0;
                        
                        break;
                    }

                }
                   
                
             }
          return count; 
        }
    }
}

