using System;

namespace Homework1
{
    public class Post
    {
        
        public void SendMessage(User user, Message message)
        {
            user.GetMessage(message);
        }

        
    }
}