using System;
using System.Collections.Generic;

namespace MergeSortList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Merge Sort Algoritham With Sort -----------------");
            var SourceArray=new List<int>(){7,5,3,6,7,1,4,8};
            
            for(int i=0;i<SourceArray.Count;i++)
            {
                Console.Write(" "+SourceArray[i]);
            }
          
            MergeHelper(SourceArray);
            Console.WriteLine();
           Console.WriteLine("---------- Sorted Array -----------------");
           for(int i=0;i<SourceArray.Count;i++)
            {
                Console.Write(" "+ SourceArray[i]);
            }
             Console.WriteLine();

        }
        static List<int> MergeHelper(List<int> SourceArray)
        {
            int LengthOfArray=SourceArray.Count;
            if(LengthOfArray<=1)
            {
                return SourceArray;
            }
            else
            {
                int Middle=LengthOfArray/2;
                var LeftList=new List<int>();
                var RightList=new List<int>();
                for(int i=0;i<=Middle;i++)
                LeftList.Add(SourceArray[i]);
                for(int j=Middle+1;j<LengthOfArray;j++)
                RightList.Add(SourceArray[j]);
                
                MergeHelper(LeftList);
                MergeHelper(RightList);
               return Merge(LeftList,RightList);
            }
            
        }
        static List<int> Merge(List<int> left,List<int> right)
        {
          List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
       

    }
}
