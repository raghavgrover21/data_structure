using System;
using System.Collections.Generic;
namespace randomprogzcsharp
{

    class Program
    {
       
        static void Main(string[] args)
        {
           string a="abcdef";
           string b="bcdaeh";
            int count=1;
           Dictionary<char,int> ob1 = new Dictionary<char,int>();
            
            if(a.Length!=b.Length) Console.WriteLine("Not anagram");
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
                        Console.WriteLine("not anagram");
                        break;
                    }

                }
                if(count==1)
                Console.WriteLine("yes it anagram");
            }
           
        }
    }
}

