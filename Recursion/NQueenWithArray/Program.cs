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
            List<List<int>> completedBoard=Driver(boardSize);
            string[][] outputString = new string[completedBoard.Count][];
            int boardIndex = 0, rowIndex;
            foreach (List<int> board in completedBoard)
            {
                rowIndex = 0;
                outputString[boardIndex] = new string[boardSize];
                foreach (int columnIndex in board)
                {
                    string strEachRow = string.Empty;
                    for (int i=0;i<boardSize;i++)
                    {
                        if (i==columnIndex)
                            strEachRow= strEachRow+"q";
                        else
                            strEachRow = strEachRow + "-";
                    }
                    outputString[boardIndex][rowIndex] = strEachRow;
                    Console.WriteLine(strEachRow);
                    rowIndex++;
                }
                Console.WriteLine("-----------------");
                boardIndex++;
            }

            Console.Write("Completed ");

        }
        public static List<List<int>> Driver(int boardSize)
        {
            List<List<int>> boards = new List<List<int>>();
            List<int> board = new List<int>();
            Helper(boardSize, boards, board,0);
            return boards;
        }
        public static void Helper(int boardSize,List<List<int>> boards, List<int> board,int row)
        {
            if (row == boardSize)
            {
                List<int> copyBoard = new List<int>(board);
                boards.Add(copyBoard);
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
        public static bool IsSafeToPlaceQueenAt(List<int> board,int row,int column)
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
