using System;
using System.Collections.Generic;

namespace Homework1
{
    public class User
    {
        public string FirstName { get; }
        public string LastName { get; }
        private string _location;
        public long Id { get;}
      
        
        public User(long id,string firstName, string lastName, string location)
        {
            Id =id;
            FirstName = firstName;
            LastName = lastName;
            _location = location;
        }

        public void GetMessage(Message message)
        {
           Console.WriteLine($"{FirstName} {LastName} - {message.Title} {message.Text} ");
           
        }

    }
}