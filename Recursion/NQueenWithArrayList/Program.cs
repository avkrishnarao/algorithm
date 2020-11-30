using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Print N Queens ");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter N as Queens to Print  ");
            int boardSize=Convert.ToInt16(Console.ReadLine());
            List<ArrayList> completedBoard=Driver(boardSize);
            foreach(ArrayList board in completedBoard)
            {
                foreach(int columnIndex in board)
                {
                    for (int i=0;i<boardSize;i++)
                    {
                        if(i==columnIndex)
                        Console.Write($"Q ");
                        else
                            Console.Write($"X ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------");
            }
            Console.Write("Completed ");

        }
        public static List<ArrayList> Driver(int boardSize)
        {
            List<ArrayList> boards = new List<ArrayList>();
            ArrayList board = new ArrayList();
            Helper(boardSize, boards, board,0);
            return boards;
        }
        public static void Helper(int boardSize,List<ArrayList> boards, ArrayList board,int row)
        {
            if (row == boardSize)
            {
                boards.Add((ArrayList)board.Clone());
                return;
            }
            else
            {
                for (int col = 0; col<boardSize; col++)
                {
                    if(IsSafeToPlaceQueenAt(board,row,col))
                    {
                        board.Add(col);
                        Helper(boardSize, boards, board, row + 1);
                        board.RemoveAt(board.Count - 1);
                    }
                }
            }
        }
        public static bool IsSafeToPlaceQueenAt(ArrayList board,int row,int column)
        {
            foreach(int QueenColumn in board)
            {
                if (QueenColumn == column)
                    return false;
            }
            for(int QueenRow=0;QueenRow<board.Count;QueenRow++)
            {
                int XValue = Math.Abs(QueenRow - row);
                int Yvalue = Math.Abs(Convert.ToInt32(board[QueenRow].ToString()) - column);
                if (XValue == Yvalue)
                    return false;
            }
            return true;
        }
        
    }
}
