using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExcep
{
    public class Account
    {
        public void Login(string userName, string password)
        {
            try
            {
                if (userName != "Dunyafm " || password != "001122dunya")
                {

                }
                else
                {
                    Console.WriteLine("Login was success");
                }

            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }






        }






    }
}
