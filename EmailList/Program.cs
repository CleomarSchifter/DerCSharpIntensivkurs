using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emailList = new string[5];
            emailList[0] = "lukas@gmail.com";
            emailList[1] = "thomas@gmail.com";
            emailList[2] = "michael@gmail.com";
            emailList[3] = "daniel@gmail.com";
            emailList[4] = "emil@gmail.com";

            foreach (string email in emailList)
            {
                Console.WriteLine(email);
            }

            Console.ReadLine();
        }
    }
}
