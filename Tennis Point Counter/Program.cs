using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace classproi
{
    class Program
    {
        static void Main(string[] args)
        {
            AsciArt();
            PointCounter();
        }
        static void PrintOutput(int[] P1Point, int[] P2Point, string Adv1, string Adv2)
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, (Console.WindowHeight / 2) - 2);
            Console.Write("p1:" + P1Point[0] + " " + P1Point[1] + " " + P1Point[2] + " " + P1Point[3] + " " + P1Point[4] + " " + P1Point[5] + " " + Adv1 + "\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, (Console.WindowHeight / 2) - 1);
            Console.Write("p2:" + P2Point[0] + " " + P2Point[1] + " " + P2Point[2] + " " + P2Point[3] + " " + P2Point[4] + " " + P2Point[5] + " " + Adv2);
        }
        static void AsciArt()
        {
            SlowType(@"                                                           


                          (*****/
                        *******, **.
                        /*,*****,*#                        
        ((,*,,,**(,     #*,*****,*(     */,# /,**(*        
      , (,// % (/( ((/    #****,**(   ,/(* (,/,% ((/(       
      (/ #//.# ,(..**,/     ,*,     ( #.*.( ,/ ,(/ ((      
     .(* , (* # /,( */..(          ,#, (. ( /,( (*/ ((      
      (/# /// # .(,,*# /(         #( %././ .(.,(. #.(      
      (//,.*, **( # (*/ **       (  *,*.% ((/ (./,***      
       ( # (/( #*/.(  (.*(       (( # ,(..// /*/.%,/       
        *(*., ( , (* % /*( #       (./.,.( (// % */(.
          (,/, ( /*/ #..(#/      .(#( /(.,(. (./(/          
            (#(,,*, //((,/.     *// (/ (((./.((/
               , ((((//   //     /.  .(((((/.               
                     , (/, //   (/ */(.                     
                        .//(*/*(((                         
                          (#%#%((                          
                          *#%###.                          
                         %##%%%###                         
                       /#%%%  .%#%#,                       
                      (##%*     #%##(                      
                      (*(         //*                      
                                                           " ,2);
            Console.Clear();
        }
        static void SlowType(string Statement, int x)
        {
            for (int i = 0; i < Statement.Length; i++)
            {
                Console.Write(Statement[i]);
                Thread.Sleep(x);
            }
        }
        static void PointCounter()      
        {
            int[] a = new int[6] { 0, 0, 0, 0, 0, 00 };
            int[] b = new int[6] { 0, 0, 0, 0, 0, 00 };
            int[] P1Point = new int[6] { 0, 0, 0, 0, 0, 00 };
            int[] P2Point = new int[6] { 0, 0, 0, 0, 0, 00 };
            string Adv1 = "";
            string Adv2 = "";
            int i = 0;
            int P1SetCounter = 0;
            int P2SetCounter = 0;
            SlowType("\n Choose Player One Side: \n\n",5);
            SlowType(" 1) press left arrow to choose left side\t 2) press righte arrow to choose Righte side",5);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.LeftArrow:
                    {
                        a = P1Point;
                        b = P2Point;
                        break;
                    }
                case ConsoleKey.RightArrow:
                    {
                        a = P2Point;
                        b = P1Point;
                        break;
                    }
            }
            Console.Clear();
            PrintOutput(a, b, Adv1, Adv2);
            while (P1SetCounter < 3 && P2SetCounter<3)
            {
                if (i <5)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.LeftArrow:
                            {

                                if (P1Point[i] >= 6 && (P1Point[i] - P2Point[i]) >= 2)
                                {
                                    i += 1;
                                    P1SetCounter += 1;
                                }
                                if (P1Point[5] < 30)
                                {
                                    Console.Clear();
                                    P1Point[5] += 15;
                                    PrintOutput(a, b, Adv1, Adv2);
                                }
                                else if (P1Point[5] == 30)
                                {
                                    Console.Clear();
                                    P1Point[5] += 10;
                                    PrintOutput(a, b, Adv1, Adv2);
                                }
                                else if (P1Point[5] == 40 && P2Point[5] != 40)
                                {
                                    Console.Clear();
                                    P1Point[5] = 0;
                                    P2Point[5] = 0;
                                    P1Point[i] += 1;
                                    PrintOutput(a, b, Adv1, Adv2);
                                }
                                else if (P1Point[5] == 40 && P2Point[5] == 40 && Adv1 != "AD")
                                {
                                    if (Adv2 != "AD")
                                    {
                                        Console.Clear();
                                        Adv1 = "AD";
                                        PrintOutput(a, b, Adv1, Adv2);
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        P2Point[5] = 40;
                                        P1Point[5] = 40;
                                        Adv1 = " ";
                                        Adv2 = " ";
                                        PrintOutput(a, b, Adv1, Adv2);

                                    }
                                }
                                else if (Adv1 == "AD")
                                {
                                    Console.Clear();
                                    P1Point[5] = 0;
                                    P2Point[5] = 0;
                                    P1Point[i] += 1;
                                    Adv1 = " ";
                                    PrintOutput(a, b, Adv1, Adv2);
                                }

                                break;
                            }


                        case ConsoleKey.RightArrow:
                            {
                                if (i < 5)
                                {
                                    if (P2Point[i] >= 6 && (P2Point[i] - P1Point[i]) >= 2)
                                    {
                                        i += 1;
                                        P2SetCounter += 1;
                                    }
                                    if (P2Point[5] < 30)
                                    {
                                        Console.Clear();
                                        P2Point[5] += 15;
                                        PrintOutput(a, b, Adv1, Adv2);
                                    }
                                    else if (P2Point[5] == 30)
                                    {
                                        Console.Clear();
                                        P2Point[5] += 10;
                                        PrintOutput(a, b, Adv1, Adv2);
                                    }
                                    else if (P2Point[5] == 40 && P1Point[5] != 40)
                                    {
                                        Console.Clear();
                                        P2Point[5] = 0;
                                        P1Point[5] = 0;
                                        P2Point[i] += 1;
                                        PrintOutput(a, b, Adv1, Adv2);
                                    }
                                    else if (P2Point[5] == 40 && P1Point[5] == 40 && Adv2 != "AD")
                                    {
                                        if (Adv1 != "AD")
                                        {
                                            Console.Clear();
                                            Adv2 = "AD";
                                            PrintOutput(a, b, Adv1, Adv2);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            P2Point[5] = 40;
                                            P1Point[5] = 40;
                                            Adv1 = " ";
                                            Adv2 = " ";
                                            PrintOutput(a, b, Adv1, Adv2);
                                        }
                                    }
                                    else if (Adv2 == "AD")
                                    {
                                        Console.Clear();
                                        P2Point[5] = 0;
                                        P1Point[5] = 0;
                                        P2Point[i] += 1;
                                        Adv2 = " ";
                                        PrintOutput(a, b, Adv1, Adv2);
                                    }
                                    
                                }
                                else if (i >= 5)
                                {
                                    break;
                                }
                                break;
                            }
                    }
                }

            }
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, (Console.WindowHeight / 2) - 2);
            SlowType("WINNER IS", 30);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, (Console.WindowHeight / 2) - 1);
            if ( (P2SetCounter < 3 && P1Point==a) || (P1SetCounter < 3 && P2Point ==a))
            {
                SlowType("PLAYER ONE", 30);
                Thread.Sleep(200);
                Console.Clear();
                for (int p = 0; p < 50; p++)
                {
                    //Console.Clear();
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 5, (Console.WindowHeight / 2) - 2);
                    Console.WriteLine("PLAYER ONE");
                    int width = Console.WindowWidth ;
                    int hight = Console.WindowHeight ;
                    Random number = new Random();
                    width = number.Next(0, Console.WindowWidth);
                    hight= number.Next(0, Console.WindowHeight);
                    Console.SetCursorPosition(width, hight);
                    Console.WriteLine( "PLAYER ONE" );
                    Console.Beep(number.Next(0, 10000), 200);
                    Thread.Sleep(200);
                }
            }
            else if ((P2SetCounter < 3 && P1Point == b) || (P1SetCounter < 3 && P2Point == b))
            {
                SlowType("PLAYER TWO", 30);
                Thread.Sleep(500);
                Console.Clear();
                for (int p = 0; p < 50; p++)
                {
                    //Console.Clear();
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 5, (Console.WindowHeight / 2) - 2);
                    Console.WriteLine("PLAYER TWO");
                    int width = Console.WindowWidth;
                    int hight = Console.WindowHeight;
                    Random number = new Random();
                    width = number.Next(0, Console.WindowWidth);
                    hight = number.Next(0, Console.WindowHeight);
                    Console.SetCursorPosition(width, hight);
                    Console.WriteLine("PLAYER TWO");
                    Console.Beep(number.Next(0, 10000), 200);
                    Thread.Sleep(200);
                }
            }
        }
    }
}
