using HackerRank.DataStructures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges
{
    public class Contacts
    {
        public void Solve(string[] args)
        {
            StreamReader file = new StreamReader("C:\\Users\\scosta\\Documents\\Visual Studio 2013\\Projects\\HackerRank\\HackerRank\\TestCases\\Contacts\\TestCase1.txt");
            StringBuilder result = new StringBuilder();

            ContactsBook contactsBook = new ContactsBook();
            int n = Convert.ToInt32(file.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] op = file.ReadLine().Split(' ');
                if (op[0] == "add")
                {
                    contactsBook.Add(op[1].ToCharArray());
                }
                else if (op[0] == "find")
                {
                    result.AppendLine(contactsBook.Find(op[1].ToCharArray()).ToString());
                }
            }

            Console.Write(result.ToString());

            Console.ReadLine();
            file.Close();
        }
    }
}
