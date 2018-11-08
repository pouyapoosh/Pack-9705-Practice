using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XOgame3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playflag = true;
            XoGame XOobject = new XoGame();
            while (playflag==true)
            {
                XOobject.trace();
                Console.WriteLine("do you want to play again?");
                Console.WriteLine("1)yes");
                Console.WriteLine("2)no");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        {
                            playflag = true;
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            playflag = false;
                            Console.Clear();
                            Console.WriteLine("it was a good match");
                            break;
                        }
                }
            }
        }
    }
}
class XoGame {
    public string[,] Result = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
    int X = 0, Y = 0;
    public void trace()
    {
        //DrawTable(13, 5, 5, 5);
        Result[0,0] =" "; Result[0, 1] = " "; Result[0, 2] = " ";
        Result[1, 0] = " "; Result[1, 1] = " "; Result[1, 2] = " ";
        Result[2, 0] = " "; Result[2, 1] = " "; Result[2, 2] = " ";
        int tableSize = 3;
        bool flag = true;
        int playcounter = 0;
        bool playflag = true;
        Console.Clear();
        Console.WriteLine("please enter player ONE name (X) :");
        string playerone = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("please enter player TWO name (O) :");
        string playertwo = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"{playerone} TURNS");
        DrawTable(13, 5, 3, 3, selectedX: X, selectedY: Y);
        while (playflag==true)
        {
            string playerturns = (flag == true) ? playerone : playertwo;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if (Y != 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"{playerturns} TURNS");
                        DrawTable(13, 5, 3, 3, selectedX: X, selectedY: --Y);
                        Console.WriteLine(playcounter);
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Y != tableSize - 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"{playerturns} TURNS");
                        DrawTable(13, 5, 3, 3, selectedX: X, selectedY: ++Y);
                        Console.WriteLine(playcounter);
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (X != 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"{playerturns} TURNS");
                        DrawTable(13, 5, 3, 3, selectedX: --X, selectedY: Y);
                        Console.WriteLine(playcounter);

                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (X != tableSize - 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"{playerturns} TURNS");
                        DrawTable(13, 5, 3, 3, selectedX: ++X, selectedY: Y);
                        Console.WriteLine(playcounter);


                    }
                    break;
                case ConsoleKey.Enter:
                    if (flag == true && Result[X,Y]==" ")
                    {
                        flag = false;
                        Result[X, Y] = "x";
                        playcounter++;
                        DrawTable(13, 5, 3, 3, selectedX: X, selectedY: Y);
                    }
                    else if (flag != true && Result[X, Y] == " ")
                    {
                        flag = true;
                        Result[X, Y] = "y";
                        playcounter++;
                        DrawTable(13, 5, 3, 3, selectedX: X, selectedY: Y);
                    }
                    break;
            }
            if (playcounter >= 5)
            {
                if (Result[0, 0] == "x" && Result[1, 0] == "x" && Result[2, 0] == "x" || Result[1, 0] == "y" && Result[0, 0] == "y" && Result[2, 0] == "y")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"winner is {playerturns}");
                    playflag = false;
                }
                else if (Result[0, 1] == "x" && Result[1, 1] == "x" && Result[2, 1] == "x" || Result[1, 1] == "y" && Result[0, 1] == "y" && Result[2, 1] == "y")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"winner is {playerturns}");
                    playflag = false;
                }
                else if (Result[0, 2] == "x" && Result[1, 2] == "x" && Result[2, 2] == "x" || Result[1, 2] == "y" && Result[0, 2] == "y" && Result[2, 2] == "y")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"winner is {playerturns}");
                    playflag = false;
                }
                else if (Result[0, 0] == "x" && Result[0, 1] == "x" && Result[0, 2] == "x" || Result[0, 1] == "y" && Result[0, 0] == "y" && Result[0, 2] == "y")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"winner is {playerturns}");
                    playflag = false;
                }
                else if (Result[1, 0] == "x" && Result[1, 1] == "x" && Result[1, 2] == "x" || Result[1, 1] == "y" && Result[1, 0] == "y" && Result[1, 2] == "y")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"winner is {playerturns}");
                    playflag = false;
                }
                else if (Result[2, 0] == "x" && Result[2, 1] == "x" && Result[2, 2] == "x" || Result[2, 1] == "y" && Result[2, 0] == "y" && Result[2, 2] == "y")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"winner is {playerturns}");
                    playflag = false;
                }
                else if (Result[0, 0] == "x" && Result[1, 1] == "x" && Result[2, 2] == "x" || Result[1, 1] == "y" && Result[0, 0] == "y" && Result[2, 2] == "y")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"winner is {playerturns}");
                    playflag = false;
                }
                else if (Result[0, 2] == "x" && Result[1, 1] == "x" && Result[2, 0] == "x" || Result[1, 1] == "y" && Result[0, 2] == "y" && Result[2, 0] == "y")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"winner is {playerturns}");
                    playflag = false;
                }
                else if(playcounter== 9)
                {
                    Console.Clear();
                    Console.WriteLine("the game is a draw");
                    playflag = false;
                }
            }

        
            
        }
    }
    internal void DrawBox(int width,
           int height,
           int left,
           int top,string selectedchar=" ", ConsoleColor color = ConsoleColor.Cyan)
    {
        Console.BackgroundColor = color;
        Console.CursorVisible = false;
        for (int j = 0; j < height; j++)//Row
        {
            Console.SetCursorPosition(left, top++);
            for (int i = 0; i < width; i++)
            {
                        Console.Write(selectedchar);  
            }
        }
        Console.BackgroundColor = ConsoleColor.Black;
    }
    internal void DrawTable(int cellWidth,
        int cellHeight,
        int left,
        int top,
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
                if (Result[j,i]=="x")
                {
                    if (i == selectedY && j == selectedX)
                        DrawBox(cellWidth, cellHeight, left, top,"x",selectedColor);
                    else
                        DrawBox(cellWidth, cellHeight, left, top,"x",color);
                }
                else if (Result[j,i]=="y")
                {
                    if (i == selectedY && j == selectedX)
                        DrawBox(cellWidth, cellHeight, left, top, "o", selectedColor);
                    else
                        DrawBox(cellWidth, cellHeight, left, top, "o", color);
                }
                else
                {
                    if (i == selectedY && j == selectedX)
                        DrawBox(cellWidth, cellHeight, left, top, " ", selectedColor);
                    else
                        DrawBox(cellWidth, cellHeight, left, top, " ", color);
                }
                left = left + (cellWidth + 1);
            }
            top = top + (cellHeight + 1);
            left = initialLeft;
        }
    }
}
