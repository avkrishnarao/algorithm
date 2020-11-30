using System;
using System.Collections;
using System.Text;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Printe the number digits by giving n as input");
             Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("Enter N as Number  ");
             int counter=Convert.ToInt16(Console.ReadLine());
            //DigitsDriverPrint(counter);
            ArrayList al=Driver(counter);
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i].ToString());
            }
            Console.Write("Completed ");

        }

        public static ArrayList Driver(int counter)
        {
            ArrayList al = new ArrayList();
            Helper(counter, new StringBuilder(), al);
            return al;
        }
        public static void Helper(int counter, StringBuilder soFar, ArrayList al)
        {
            if (counter == 0)
            {
                 al.Add(soFar.ToString());
                return;
               
            }
            else
            {
                for (int i = 0; i <= 9; i++)
                {
                    soFar.Append(i);
                    Helper(counter - 1, soFar, al);
                    soFar.Remove(soFar.Length - 1,1);
                }
            }
        }

        public static void DigitsDriverPrint(int counter)
        {
            DigitsHelper(counter,"");
        }

        public static void DigitsHelper(int counter,string soFar)
        {
            if(counter==0)
            {
                Console.WriteLine(soFar);
            }
            else
            {
               for(int i=0;i<=9;i++)
               {
                    DigitsHelper(counter-1, soFar+i.ToString());
               }
            }
        }
    }
}
