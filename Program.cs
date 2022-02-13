using System;

namespace UserPasswordCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username daxil edin");
            string userid = Console.ReadLine();
            User user1 = new User(userid);
            Console.WriteLine("Parolunuzu daxil edin");

            string userpsw = Console.ReadLine();

            user1.Password = userpsw;

            Console.WriteLine($"Istifadeci Yaradildi. Username:{user1.Name} Password:{user1.Password}");
            
        }
    }
}
