using System;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Merge Sort Algoritham -----------------");
            int[] SourceArray={2,5,3,6,7,1,4,8};
            for(int i=0;i<SourceArray.Length;i++)
            {
                Console.Write(" "+SourceArray[i]);
            }
          
            MergeHelper(SourceArray,0,SourceArray.Length-1);
            Console.WriteLine();
           Console.WriteLine("---------- Sorted Array -----------------");
           for(int i=0;i<SourceArray.Length;i++)
            {
                Console.Write(" "+ SourceArray[i]);
            }
             Console.WriteLine();

        }
        static void MergeHelper(int[] SourceArray,int Low,int High)
        {
            if(Low<High)
            {
                int Mid=(Low+High)/2;
                MergeHelper(SourceArray,Low,Mid);
                MergeHelper(SourceArray,Mid+1,High);
                Merge(SourceArray,Low,Mid,High);
            }
        }
        static void Merge(int[] SourceArray,int Low,int Mid,int High)
        {
            int i=Low;
            int j=Mid+1;
            int k=Low;
            int[] AuxArray=new int[High+1];
             while(i<=Mid && j<=High)
            {
                if(SourceArray[i]<=SourceArray[j])
                {
                    AuxArray[k]=SourceArray[i];
                    i++;
                }
                else
                {
                   AuxArray[k]=SourceArray[j];
                   j++;  
                }
                k++;
            }
            
            if(i>Mid)
            {
                while(j<=High)
                {
                    AuxArray[k]=SourceArray[j];
                    j++;
                    k++;
                }
            }
            else
            {
                 while(i<=Mid)
                {
                    AuxArray[k]=SourceArray[i];
                    i++;
                    k++;
                }
           
            }
            for(k=Low;k<=High;k++)
            {
                SourceArray[k]=AuxArray[k];
            }
            
        }
         static void MergeTwoAux(int[] SourceArray,int Low,int Mid,int High)
        {
            int FirstArrayLength=Mid-Low+1;
            int SecondArrayLength=High-Mid;
            int[] AuxArray1=new int[FirstArrayLength];
            int[] AuxArray2=new int[FirstArrayLength];
             for (int l = 0; l < FirstArrayLength; ++l)
            AuxArray1[l] = SourceArray[Low + l];
            for (int m= 0; m < SecondArrayLength; ++m)
            AuxArray2[m] = SourceArray[Mid + 1 + m];
            int i=0;
            int j=0;
            int k=Low;
            while(i<FirstArrayLength && j<SecondArrayLength)
            {
                if(AuxArray1[i]<=AuxArray2[j])
                {
                    SourceArray[k]=AuxArray1[i];
                     Console.Write(" O"+SourceArray[k]);
                    i=i+1;
                }
                else
                {
                     SourceArray[k]=AuxArray2[j];
                     Console.Write(" O"+SourceArray[k]);
                   j=j+1;  
                }
                k=k+1;
            }

            while(i<FirstArrayLength)
            {
                    SourceArray[k]=AuxArray1[i];
                    i++;
                    k++;
            }
            while(j<SecondArrayLength)
            {
                      SourceArray[k]=AuxArray2[j];
                    j++;
                    k++;
            }
            
        }

    }
}
