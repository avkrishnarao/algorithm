using System;
using System.Collections.Generic;
namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> aux=new List<int>();
            aux.Add(5);
            aux.Add(4);
            aux.Add(1);
            aux.Add(6);
            aux.Add(8);
            aux.Add(3);
            aux=merge_sort(aux);
            int lenght1=aux.Count;
            for(int i=0;i<lenght1;i++)
            {
                Console.Write(aux[i]);
            }

            
        }
    static List<int> merge_sort(List<int> arr)
    {
        int Left=0,Right=arr.Count()-1;
        Console.WriteLine(Right);
        merge_helper(arr, Left, Right);
        return arr;
    }
     public static void merge_helper(List<int> arr,int Left,int Right)
     {
         if(Left<Right)
         {
             int Mid=(Left + Right)/2;
             merge_helper(arr, Left, Mid);
             merge_helper(arr, Mid+1, Right);
             merge(arr,Left,Mid,Right);
         }
     }
     public static void merge(List<int> arr,int Left,int Mid,int Right)
     {
         int i=Left;
         int j=Mid+1;
         int k=Left;
         List<int> aux=new List<int>();
         while(i<=Mid && j<=Right)
         {
             if(arr[i]<=arr[j])
             {
                 aux.Add(arr[i]);
                 i++;
             }
             else
             {
                   aux.Add(arr[j]);
                 j++;
             }
         }
         if(i>Mid)
         {
             while(j<=Right)
             {
                 aux.Add(arr[j]);
                 j++; 
                 k++;
             }
         }
         else
         {
            while(i<=Left)
             {
                 aux.Add(arr[i]);
                 i++; 
                 k++;
             } 
         }
         for(k=Left;k<=Right;k++)
         {
             arr[k]=aux[k];
         }
     
     }

    }


    
}
