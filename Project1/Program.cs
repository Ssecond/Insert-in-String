using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcPyyyabc453465abcOabcIabc";
            string ptr = "abc";

            string ptr1 = "ggg";
            string g = string.Empty;
            string h = string.Empty;
            string h1 = string.Empty;
            int x = 0;

            for (int y = 0; y < s.Length; y++)
            {      
                
                
                for (int z = y; z < ptr.Length + y;  z++)
                {
                    h += s[z].ToString();
                    h1 = h;

                    if (ptr == h)
                    {
                        h = ptr1;
                        g += h;
                    }

                    
                }

                if (ptr != h1)
                {
                    g += h1[0].ToString();
                }
                else
                {
                    y += ptr.Length - 1;
                }

                if (s.Length == g.Length)
                {
                    break;
                }
               
                
                h = string.Empty;
                h1 = string.Empty;
            }

            Console.WriteLine(g);
         
            Console.ReadLine();
        }
    }
}
