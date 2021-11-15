using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //A PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1) || (i == 3) || (j == 1) || (j == 5))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //A PATTERN
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1 && j > 1 && j < 5) || (j == 1 && i > 1) || (j == 5 && i > 1) || (i == 4))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //B PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if( (i==1) || (i==3) || (i==5) || (j==1) || (j==5))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //B PATTERN
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((j==1) || (j==5 && i!=1 && i!=4 && i!=7) || ((i==1) || (i==4) || (i==7)  && j!=5))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //C PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if  ((j==1) || (i==1) || (i==5))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // C PATTERN
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i==1 && j>1) || (i==7 && j>1) || (j==1 && i>1 && i<7))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // D PATTER
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((j==1) || (i==1  && j<5) || (i==7 && j<5) || (j==5 && i!=1 && i!=7))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //E PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1) || (i == 3) || (i == 5) || (j==1))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // F PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1) || (i == 3) || (j == 1))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //G PATTERN
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 6; j++)
            //    {
            //        if ((j == 1) || (i == 1 && j<=5) || (i==7 && j<=5) || (i==4 && j>=4) || (j==5 && i>=4))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // H PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 3) || (j == 1) || (j == 5))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // I PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1) || (i == 5) || (j == 3))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // J PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1) || (j == 3) || (i == 5 && j==2))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // K PATTERN
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((j == 1) || (i+j == 6) || (i-j==2))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // L PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((j== 1) || ( i== 5) )
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // M PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((j == 1) || (j == 5) || (i == 2 && j == 2) ||(i==2 && j== 4) || (i==3 && j==3))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // N PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((j == 1) || (j == 5) || (i-j == 0 ))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //O PATTERN
            //for (int i = 1; i <= 6; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1 && j>=2 && j<=4) || (i==6 && j>=2 && j<=4) || (j==1 && i>=2 && i<=5) || (j==5 && i>=2 && i<=5))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // P PATTERN
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1 && j>= 2 && j<=4) || (j == 1 && i >= 2) || (i==4 && j<=4) || (j==5 && i==2) ||(j==5 && i==3))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // Q PATTERN
            //for (int i = 1; i <= 8; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1 && j>=2 && j<=4) || (j == 1 && i >= 2 && i<=6) || (j==5 && i>=2 && i<=6) ||(i==7 && j>=2 && j<=4) || (i==6 && j<=2) || (i==8 && j==4))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // R PATTERN
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((j == 1) || (i == 1 && j<=4) || (i == 4 && j <=4 ) || (j==5 && i>=5) || (j==5 && i==2) || (j==5 && i==3))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //// S PATTERN
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i == 1 && j>=2 && j<=4) || (i == 4 && j >= 2 && j <= 4) || (i == 7 && j >= 2 && j <= 4) || (j==1 && i>=2 && i<=3) || (j==5 && i>=5 && i<=6))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // T PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i== 1) || (j == 3) )
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // U PATTERN
            //for (int i = 1; i <= 6; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((j == 1 && i<=5) || (j == 5 && i<=5) || (i==6 &&  j>=2 && j<=4))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // V PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        if ((i-j==0) || (i+j==10))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //W PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((j == 1) || (j == 5) || (i==4 && j!=3) || (j==3 && i==3))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // X PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i-j==0) || (i+j==6))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // Y PATTERN
            //for (int i = 1; i <= 6; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i==1 && j==1) || (i==1 && j==5) || (i==2 && j==2) || (i==2 && j==4) || (j==3 && i>=3))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // Z PATTERN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i==1) || (i==5) || (i==2 && j==4) || (i==4 && j==2) || (i==3 && j==3))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}






        }
    }
}
