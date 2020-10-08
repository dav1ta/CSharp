using System;
using System.Data.Common;
using System.Collections.Generic;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            Generator gen = new Generator();
            User user1 = new User(gen.GenerateId(),"DaviD","Chanturia","Tbilisi");
            User user2 = new User(gen.GenerateId(),"Nika","Nikauri","Tbilisi");
            User user3 = new User(gen.GenerateId(),"sandro","sandriani","Tbilisi");
            users.Add(user2);
            users.Add(user1);
            users.Add(user3);
            
            
            foreach (var user in users)
            {
                Console.WriteLine($"{users.IndexOf(user)} {user.FirstName} {user.LastName}" );
                 
            }

            Console.WriteLine("Choose One:");
            string inputId = Console.ReadLine();
            Console.WriteLine("Write Message:"); 
            string messageText= Console.ReadLine();
            Message message = new Message("message", messageText);
            Post post = new Post();
          
            post.SendMessage(users[int.Parse(inputId)],message);


        }
        
    }
}
