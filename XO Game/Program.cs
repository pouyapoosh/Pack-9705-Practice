using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BoxDemo
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int X = 0, Y = 0;
            bool flag = true;
            string[,] result = new string[3, 3];
            DrawTable(13, 5, 3, 3,result, selectedX: X, selectedY: Y);
            
            int tableSize = 3;
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Y != 0)
                        {
                            Console.Clear();
                            DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: --Y);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Y != tableSize - 1)
                        {
                            Console.Clear();
                            DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: ++Y);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (X != 0)
                        {
                            Console.Clear();
                            DrawTable(13, 5, 3, 3, result, selectedX: --X, selectedY: Y);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (X != tableSize - 1)
                        {
                            Console.Clear();
                            DrawTable(13, 5, 3, 3, result, selectedX: ++X, selectedY: Y);
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (X==0&Y==0)
                        {
                            Console.Clear();
                            if (flag==true)
                            {
                                result[0, 0] = "x";
                                flag = false;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y,selectedColor: ConsoleColor.White);
                            }
                            else
                            {
                                result[0, 0] = "y";
                                flag = true;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }                           
                        }
                        else if (X == 0 & Y == 1)
                        {
                            Console.Clear();
                            if (flag == true)
                            {
                                result[0, 1] = "x";
                                flag = false;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                            else
                            {
                                result[0, 1] = "y";
                                flag = true;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                        }
                        else if (X == 0 & Y == 2)
                        {
                            Console.Clear();
                            if (flag == true)
                            {
                                result[0, 2] = "x";
                                flag = false;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                            else
                            {
                                result[0, 2] = "y";
                                flag = true;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                        }
                        else if (X == 1 & Y == 0)
                        {
                            Console.Clear();
                            if (flag == true)
                            {
                                result[1, 0] = "x";
                                flag = false;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                            else
                            {
                                result[1, 0] = "y";
                                flag = true;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                        }
                        else if (X == 1 & Y == 1)
                        {
                            Console.Clear();
                            if (flag == true)
                            {
                                result[1, 1] = "x";
                                flag = false;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                            else
                            {
                                result[1, 1] = "y";
                                flag = true;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                        }
                        else if (X == 1 & Y == 2)
                        {
                            Console.Clear();
                            if (flag == true)
                            {
                                result[1, 2] = "x";
                                flag = false;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                            else
                            {
                                result[1, 2] = "y";
                                flag = true;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                        }
                        else if (X == 2 & Y == 0)
                        {
                            Console.Clear();
                            if (flag == true)
                            {
                                result[2, 0] = "x";
                                flag = false;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                            else
                            {
                                result[2, 0] = "y";
                                flag = true;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                        }
                        else if (X == 2 & Y == 1)
                        {
                            Console.Clear();
                            if (flag == true)
                            {
                                result[2, 1] = "x";
                                flag = false;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                            else
                            {
                                result[2, 1] = "y";
                                flag = true;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                        }
                        else if (X == 2 & Y == 2)
                        {
                            Console.Clear();
                            if (flag == true)
                            {
                                result[2, 2] = "x";
                                flag = false;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                            else
                            {
                                result[2, 2] = "y";
                                flag = true;
                                DrawTable(13, 5, 3, 3, result, selectedX: X, selectedY: Y, selectedColor: ConsoleColor.White);
                            }
                        }
                        break;
                }

            }
        }
            
        static void DrawBox(int width,
            int height,
            int left,
            int top,ConsoleColor charcolor,ConsoleColor color = ConsoleColor.Cyan, char a = ' ')
        {
            Console.BackgroundColor = color;
            Console.CursorVisible = false;
            for (int j = 0 ; j < height; j++)//Row
            {
                Console.SetCursorPosition(left, top++);
                for (int i = 0; i < width; i++)
                {
                    Console.WriteLine(a);
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void DrawTable(int cellWidth,
            int cellHeight,
            int left,
            int top,
            string[,] Result,
            int size = 3,
            ConsoleColor color = ConsoleColor.Cyan,
            int selectedX = 0,
            int selectedY = 0,
            ConsoleColor selectedColor = ConsoleColor.DarkGreen)
        {
            var initialLeft = left;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Result[i, j] == "x")
                    {                        
                        char a = 'x';
                        DrawBox(cellWidth, cellHeight, left, top, Console.ForegroundColor = ConsoleColor.Red, selectedColor, a);
                    }
                    else if (Result[i, j] == "y")
                    {
                        char a = 'y';
                        DrawBox(cellWidth, cellHeight, left, top, Console.ForegroundColor = ConsoleColor.Red, selectedColor, a);
                    }
                    else
                    {
                        char a = ' ';
                        DrawBox(cellWidth, cellHeight, left, top,color,color, a);
                    }
                    if (i == selectedY && j == selectedX)
                        DrawBox(cellWidth, cellHeight, left, top, selectedColor, selectedColor);
                    else
                        DrawBox(cellWidth, cellHeight, left, top, color,color);
                    left = left + (cellWidth + 1);
                }
                top = top + (cellHeight + 1);
                left = initialLeft;
            }
        }
    }
}