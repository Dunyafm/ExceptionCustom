using System;

namespace CustomExcep
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "Dunyafm";
            string password = "001122dunya";

            if (password != "0")

            throw new FormatException("Password simvollari sayi 6 kicikdir");

            Account account = new Account();
            account.Login(userName, password);




















        }
    }
}
