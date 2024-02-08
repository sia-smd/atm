using System;


namespace atm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
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

                    input = pro.menu();

                    switch (input)
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

                } while (input == 1 || input == 2 || input == 3 || input == 4 || input == 5);
            } while (input == 6);
            Console.Clear();
            System.Console.WriteLine("        *------tank you------*");
        }
    }


}

