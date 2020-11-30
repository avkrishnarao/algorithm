using System;

namespace FindTargetNumberWithOperatorMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TargetNumber Match with Operators (*,+,join)");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Ex: Input: Arrary {222}, Target Number 24");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Enter the string you want to input ");
            string sourceString= Console.ReadLine();
            Console.WriteLine("Enter the target number to mach the pattern");
            int targetNumber = Convert.ToInt32(Console.ReadLine());
            Driver(sourceString, targetNumber);
            Console.WriteLine($"---------------Completed--------------");
        }
        static void Driver(string sourceString,int targetNumber)
        {
            Helper(sourceString, targetNumber,"", 0,0);
        }
        static void Helper(string sourceString, int targetNumber,string soFarCaliculatedValue,int index,int soFarValue)
        {
            if (soFarValue == targetNumber)
            {
                Console.WriteLine($"Found one :{soFarCaliculatedValue} ");
                return;
            }
            else
            if (sourceString.Length==index)
            {
                //Console.WriteLine($"{soFarCaliculatedValue} ");
                return;
            }
            else
            {
                    int indexValue = Convert.ToInt32(sourceString.Substring(index, 1));
                if(index==0)
                {
                    Helper(sourceString, targetNumber, soFarCaliculatedValue + indexValue, index + 1,
                                        soFarValue + indexValue);
                }
                else
                {
                   Helper(sourceString, targetNumber, soFarCaliculatedValue + indexValue, index + 1,Convert.ToInt32(soFarValue.ToString() + indexValue.ToString()));
                    Helper(sourceString, targetNumber, soFarCaliculatedValue + "+"+ indexValue, index + 1, 
                        soFarValue + indexValue);
                    Helper(sourceString, targetNumber, soFarCaliculatedValue +"*"+ indexValue, index + 1, index == 0 ? 1 : soFarValue * indexValue);
                }
                


                //Helper(sourceString, targetNumber, soFarCaliculatedValue + indexValue, index == 0 ? indexValue : Convert.ToInt32(soFarValue.ToString() + indexValue.ToString()), index + 1);
                //    Helper(sourceString, targetNumber, soFarCaliculatedValue + "+" + indexValue, soFarValue + indexValue, index + 1);
                //    Helper(sourceString, targetNumber, soFarCaliculatedValue + "*" + indexValue, index == 0 ? 1 : soFarValue * indexValue, index + 1);
            }
        }

    }
}
