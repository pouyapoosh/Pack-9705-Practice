using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedX = 0, selectedY = 0,size =3;
            MultiBox(5, 5, 3, 3, selectedX, selectedY,size);
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (selectedY != 0)
                            {
                                MultiBox(5, 5, 3, 3, selectedX, selectedY--,size);
                            }
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (selectedY < size )
                            {
                                MultiBox(5, 5, 3, 3, selectedX, selectedY++,size);
                            }
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (selectedX!=0)
                            {
                                MultiBox(5, 5, 3, 3, selectedX--, selectedY, size);
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (selectedX < size)
                            {
                                MultiBox(5, 5, 3, 3, selectedX++, selectedY, size);
                            }
                            break;
                        }
                }
            }
        }
        static void MultiBox( int top , int left , int width , int height ,int selectedX ,int selectedY, int size = 3)
        {
            int FirstLeft = left;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i==selectedX && j==selectedY )
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        DrawBox(top, left, width, height);
                    }
                    else
                    {
                        DrawBox(top, left, width, height);
                    }
                    left = left + (width + 1);
                }
                top= top + (height + 1);
                left = FirstLeft;
                
            }

        }
        static void DrawBox(int top, int left ,int width,int height)
        {
            //Console.CursorVisible=;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(left ,top);
            for (int i = 0; i < height ; i++)
            {
                Console.SetCursorPosition(left, top++);
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                } 
            }
        }
    }
}
