using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayClass.tasks
{
    internal class Account:Constants
    {
        public void Login(string UserName , string Password)
        {
            if (UserName == username && Password == password)
            {
                Console.WriteLine(SuccessMessage);
            }
            else
            {
                Console.WriteLine(UnseccessMessage);
            }
        }

    }
}
