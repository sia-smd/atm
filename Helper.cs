using System;
using System.Linq;

namespace atm
{
    class helper
    {
        public  string getstring()
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
        public  void space(int a)
        {
            int s = (a.ToString().Length);
            for (var i = 0; i < 10 - s; i++)
            {
                System.Console.Write(" ");
            }
        }

        // check adad vorodi
        public  int ck1(string a)
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
        public  int ck2(string a)
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