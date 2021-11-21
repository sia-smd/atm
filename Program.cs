using System;


namespace atm
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = 0;
            process pro = new process();

            // vared kardane card
            pro.add();

            //  vorod be hesabe karbari

            bool check;

            do
            {
                do
                {
                    check = pro.select();

                } while (check == false);

                // baz shodane menu

                do
                {

                    add = ATM.menu();

                    switch (add)
                    {
                        case 1:
                            pro.credit();

                            break;
                        case 2:
                            pro.update();

                            break;
                        case 3:
                            pro.CtoC();

                            break;
                        case 4:
                            pro.cash();

                            break;
                        case 5:
                            pro.history();

                            break;
                    }

                } while (add == 1 || add == 2 || add == 3 || add == 4 || add == 5);
            } while (add == 6);
            Console.Clear();
            System.Console.WriteLine("        *------tank you------*");
        }
    }


}

