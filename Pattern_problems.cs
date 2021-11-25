public class patternprograms
{
    private static string s;

    public static void Main(string[] args)
    {
        Console.Clear();

        //bowpattern();
        //pattern1();
        //pattern2();
        //pattern3();
        //pattern4();
        //pattern5();
        //pattern6();
        //pattern7();
        //pattern8();
        //pattern9();
         pattern10();

        Console.ReadLine();
    }

    private static void bowpattern()
    {

        int lines = 10;
        int space = (lines * 2) - 2;
        for (int i = 1; i <= (lines / 2); i++)
        {
            bool flagl = false;
            for (int l = 1; l <= i; l++)
            {
                if (!flagl)
                {
                    Console.Write("*");
                    flagl = true;
                }
                else
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
            }

            for (int l = 1; l <= space; l++)
            {
                Console.Write(" ");
            }
            space = space - 4;
            bool flagr = false;
            for (int l = 1; l <= i; l++)
            {
                if (!flagr)
                {
                    Console.Write("*");
                    flagr = true;
                }
                else
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
            }
            Console.WriteLine("");
        }
        space = space + 4;
        for (int i = (lines / 2); i >= 1; i--)
        {
            bool flagl = false;
            for (int l = 1; l <= i; l++)
            {
                if (!flagl)
                {
                    Console.Write("*");
                    flagl = true;
                }
                else
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
            }
            for (int l = 1; l <= space; l++)
            {
                Console.Write(" ");
            }
            space = space + 4;
            bool flagr = false;
            for (int l = 1; l <= i; l++)
            {
                if (!flagr)
                {
                    Console.Write("*");
                    flagr = true;
                }
                else
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
            }
            Console.WriteLine("");
        }

    }
    private static void pattern1()
    {
        int i, j, lines = 5;
        for (i = 1; i <= lines; i++)
        {
            for (j = lines; j >= 1; j--)
            {
                if (j != i)
                    Console.Write(j);
                else
                    Console.Write("*");
            }
            Console.WriteLine("\n");
        }

    }
    private static void pattern2()
    {
        int lines = 4;
        int i, j;
        for (i = 1; i <= lines; i++)
        {
            for (j = 1; j <= lines; j++)
            {
                if (i == j)
                    Console.Write("*");
                else
                    Console.Write("0");
            }
            j--;
            Console.Write("*");
            while (j >= 1)
            {
                if (i == j)
                    Console.Write("*");
                else
                    Console.Write("0");
                j--;
            }
            Console.WriteLine("");
        }
    }
    private static void pattern3()
    {
        int line = 10;
        int i = 1;
        int j;
        for (i = 1; i <= line; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(i * j + " ");
            }
            Console.WriteLine("");
        }
    }
    private static void pattern4()
    {
        int lines = 8;
        int i, j;
        for (i = 1; i < lines; i++)
        {
            for (j = 1; j <= lines / 2; j++)
            {
                if (i == j)
                {
                    Console.Write(j);
                }
                else if (i > 4 && j == lines - i)
                {
                    Console.Write(j);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            j = j - 2;
            while (j > 0)
            {
                if (i == j)
                {
                    Console.Write(j);
                }
                else if (i > 4 && j == lines - i)
                {
                    Console.Write(j);
                }
                else
                {
                    Console.Write(" ");
                }
                j--;
            }
            Console.WriteLine();
        }
    }
    private static void pattern5()
    {
        {
            int[,] matrix = new int[5, 5];
            int i, j, k;
            int direction = 1;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            for (i = 1, j = 0, k = 0; i <= 16; i++)
            {
                matrix[j, k] = i;
                switch (direction)
                {
                    case 1:
                        if (k + 1 < 5)
                        {
                            if (matrix[j, k + 1] == 0)
                            {
                                k++;
                                continue;
                            }
                            else
                            {

                                j++;
                                direction = 2;
                                continue;
                            }
                        }
                        else
                        {
                            j++;
                            direction = 2;
                            continue;
                        }
                    case 2:
                        if (j + 1 < 5)
                        {

                            if (matrix[j + 1, k] == 0)
                            {
                                j++;
                                continue;
                            }
                            else
                            {
                                direction = 3;
                                k--;
                                continue;
                            }
                        }
                        else
                        {
                            direction = 3;
                            k--;
                            continue;
                        }
                    case 3:
                        if (k - 1 >= 0)
                        {
                            if (matrix[j, k - 1] == 0)
                            {

                                k--;
                                continue;
                            }
                            else
                            {
                                direction = 4;
                                j--;
                                continue;
                            }
                        }
                        else
                        {
                            direction = 4;
                            j--;
                            continue;
                        }
                    case 4:
                        if (j - 1 >= 0)
                        {
                            if (matrix[j - 1, k] == 0)
                            {

                                j--;
                                continue;
                            }
                            else
                            {
                                k++;
                                direction = 1;
                                continue;
                            }
                        }
                        else
                        {
                            k++;
                            direction = 1;
                            continue;
                        }
                }
            }
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Console.Write(" \t");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
    private static void pattern6()
    {
        int n = 6;
        for (int row = 1; row <= 6; ++row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    private static void pattern7()
    {
        for (int i = 5; i >= 1; --i)
        {
            for (int j = 1; j <= i; ++j)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    private static void pattern8()
    {
        int i, j, rows, k = 1;
        Console.Write("");
        rows = 5;
        for (i = 1; i <= rows; i++)
        {
            for (j = 1; j <= i; j++)
                Console.Write("{0}", k++);
            Console.Write("\n");
        }
    }
    private static void pattern9()
    {
        int a, b, c, count = 1;
        a = 5;
        count = a - 1;
        for (c = 1; c <= a; c++)
        {
            for (b = 1; b <= count; b++)
                Console.Write("");
            count--;
            for (b = 1; b <= 2 * c - 1; b++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
    private static void pattern10()
    {
        int r, a, b;
        r = 5;
        for (a = 0; a <= 10; a++)
        {
            for (b = 0; b <= 10; b++)
            {
                if (a == 0 || a == 10 ||b == 0 ||b == 10)
                    Console.Write("1");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
