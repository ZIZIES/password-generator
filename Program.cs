using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many characters?");
            string? x = Console.ReadLine();
            if (x == null)
            {
                Console.WriteLine("no input!");
                return;
            }
            int length;
            string uppercase = ("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            string lowercase = ("abcdefghijklmnopqrstuvwxyz");
            string numbers = ("1234567890");
            string special = ("!@#$%^&*()");
            string chars = uppercase + lowercase + numbers + special;
            try
            {
                length = int.Parse(x);
                Console.WriteLine($"{length}, okay");
            }
            catch (FormatException)
            {
                Console.WriteLine("that's not a number!!!");
                return;
            }
            Random rand = new Random();
            string password = ("");
            password += uppercase[rand.Next(uppercase.Length)];
            password += lowercase[rand.Next(lowercase.Length)];
            password += numbers[rand.Next(numbers.Length)];
            password += special[rand.Next(special.Length)];
            for (int i = 4; i < length; i++)
            {
                    password += chars[rand.Next(chars.Length)];    
            }

            //now THIS one i copy and pasted from AI cus all it does is make your password more random
            char[] passwordArray = password.ToCharArray();
            for (int i = passwordArray.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                char temp = passwordArray[i];
                passwordArray[i] = passwordArray[j];
                passwordArray[j] = temp;
            }
            password = new string(passwordArray);
            Console.WriteLine($"{password}");
            
        }
    }
}