using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedCeaserCipher
{
    class Program
    {
        //string message = "";
        //int key = 0;
        public string encryptMessage(String message, int key)
        {

            string result = "";
            foreach (char i in message)
            {
                char c = Convert.ToChar(i + key);
                //Console.Write(c);
                result = result + c;
            }
            return result;
        }

        public string decryptMessage(String message, int key)
        {

            string result = "";
            foreach (char i in message)
            {
                char c = Convert.ToChar(i - key);
                //Console.Write(c);
                result = result + c;
            }
            return result;
        }


        public static void Main(string[] args)
        {
            char b = 'a';
            //Console.WriteLine((int)b);
            /*Console.WriteLine("Hello World!");
            int a = 10;
            while (a != 0) {
                Console.WriteLine($"loop: {a}");
                a -= 1;
            }*/


            Console.Write("Do you want to perform encryption or decryption ?");
            string IsEncrypt = Console.ReadLine();

            //Console.ReadLine();

            Program obj = new Program();

            if (IsEncrypt == "encrypt")
            {
                Console.WriteLine("Enter your Message :");
                String message = Console.ReadLine();

                Console.WriteLine("Enter the Key :");
                int key = Convert.ToInt32(Console.ReadLine());

                key = ((key % 11) % 7);

                string a = obj.encryptMessage(message, key);
                Console.WriteLine(a);
            }
            else if (IsEncrypt == "decrypt")
            {
                Console.WriteLine("Enter your Message :");
                String message = Console.ReadLine();

                Console.WriteLine("Enter the Key :");
                int key = Convert.ToInt32(Console.ReadLine());

                string a = obj.decryptMessage(message, key);
                Console.WriteLine(a);
            }
            else {
                Console.WriteLine("Select a valid option.");
            }
            Console.ReadLine();
        }

    }

}
