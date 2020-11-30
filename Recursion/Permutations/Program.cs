using System;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Print S Strings in n Numbers of Ways ex : {t1D2}  Result {t1D2}{t1d2}{T1D2}{T1d2}");
             Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("Enter the string to Print ");
            string sourceString=Console.ReadLine();
            Driver(sourceString);
             /*
             Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Printe the number digits by giving n as input");
             Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("Enter N as Number  ");
             int counter=Convert.ToInt16(Console.ReadLine());
            DigitsDriver(counter);*/

        }
        public static void Driver(string sourceString)
        {
            Helper(sourceString,"",0);
        }
        public static void Helper(string sourceString,string recursionString,int subProblemCount)
        {
            if(sourceString.Length==subProblemCount)
            {
                Console.WriteLine(recursionString);
            }
            else
            {
                char chartAt=char.Parse(sourceString.Substring(subProblemCount,1));
                if(Char.IsDigit(chartAt))
                {
                    Helper(sourceString, recursionString+chartAt,subProblemCount+1);
                }
                else
                {
                    Helper(sourceString, recursionString+Char.ToLower(chartAt),subProblemCount+1);
                    Helper(sourceString, recursionString+Char.ToUpper(chartAt),subProblemCount+1);
                }
            }

        }

         public static void DigitsDriver(int counter)
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
