using System.Text;

namespace StringArrayClass.tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reverse String
            //string str = "Salam Necesen";
            //ReverseString(str);
            //static void ReverseString(string str)
            //{
            //    string[] names = str.Split(' ');
            //    StringBuilder NewName = new StringBuilder();
            //    foreach (var word in names)
            //    {

            //        for (int i = word.Length - 1; i >= 0; i--)
            //        {
            //            NewName.Append(word[i]);
            //        }
            //        NewName.Append(' ');
            //    }
            //    Console.WriteLine(NewName.ToString().TrimEnd());
            //}
            #endregion

            #region Task 2

            string usernamee= Console.ReadLine();
            string passw= Console.ReadLine();
            Account acc = new Account();
            acc.Login(usernamee, passw);
            #endregion
        }
    }
}
