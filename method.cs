using System;
using System.Linq;

namespace atm
{
    class ATM
    {

        // menu atm

        public static int menu()
        {
            Console.Clear();
            System.Console.WriteLine("*--------------ATM menu--------------*");
            System.Console.WriteLine("*                                    *");
            System.Console.WriteLine("*1-acount balance   change password-2*");
            System.Console.WriteLine("*                                    *");
            System.Console.WriteLine("*3-card to card       withdrow cash-4*");
            System.Console.WriteLine("*                                    *");
            System.Console.WriteLine("*5-last ten round                    *");
            System.Console.WriteLine("*                                    *");
            System.Console.WriteLine("*6-try another card            exit-7*");
            System.Console.WriteLine("*------------------------------------*");
            System.Console.Write("Select the desired option :");
            int add = ck2("enter correct option number");
            return add;
        }

        public static string GetPassword()
        {
            string password = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password += key.KeyChar;
            }
            return password;
        }

        public static string getstring()
        {
            string str;
            bool c ;
            do
            {
                str = Console.ReadLine();
                if (str.Length == 0)
                {
                    c = false;
                    System.Console.WriteLine("please enter some character");
                }
                else
                {
                    c = true;
                }
            } while (c == false);
            return str;
        }

        // sazande space baraye 10 gardesh akhar
        public static void space(int a)
        {
            int s = (a.ToString().Length);
            for (var i = 0; i < 10 - s; i++)
            {
                System.Console.Write(" ");
            }
        }

        // check adad vorodi
        public static int ck1(string a)
        {
            int num = 0;
            bool c;
            do
            {
                c = true;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    System.Console.WriteLine(a);
                }
                if (num <= 0)
                {
                    System.Console.WriteLine("enter bigger than 0");
                    a = "enter correct number";
                    c = false;
                }

            } while (c == false);

            return num;
        }
        public static int ck2(string a)
        {
            int num = 0;
            bool c;
            do
            {
                c = true;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    System.Console.WriteLine(a);

                }
                if (num < 1 || num > 7)
                {
                    System.Console.WriteLine("not in list option");
                    a = "enter correct option number";
                    c = false;
                }

            } while (c == false);

            return num;

        }
    }
}