using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StringNSubsets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Print the string subsets ex: input : xy  Output : ['','x','y','x,y']");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("Enter String for Generating Subset ");
             string sourceString=Console.ReadLine();
            //DigitsDriverPrint(counter);
            string[] subSetStrings=Driver(sourceString);
            for(int i=0;i< subSetStrings.Length;i++)
            {
                Console.WriteLine(subSetStrings[i].ToString());
            }
            Console.Write("------------------------------------------------");

        }
        static string[] Driver(string sourceString)
        {
            List<string> collector = new List<string>();
            Helper(sourceString, new StringBuilder(), 0, collector);
            return collector.ToArray();
        }
        
        public static void Helper(string sourceString, StringBuilder soFar, int index, List<string> collector)
        {
            if (index == sourceString.Length)
            {
                collector.Add(soFar.ToString());
                return;
            }
            else
            {
                Helper(sourceString, soFar, index + 1, collector);
                soFar.Append(sourceString.Substring(index,1));
                Helper(sourceString, soFar, index+ 1,collector);
                soFar.Remove(soFar.Length - 1,1);
            }
        }

        
    }
}
