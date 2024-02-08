using System;

namespace atm
{
    interface atm
    {
        int menu();
        string GetPassword();
        void add();
        bool select();
        void CtoC();
        void update();
        void credit();
        void cash();
        void add_history(string id, int price, string type);
        void history();

    }
}