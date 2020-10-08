namespace Homework1
{
    public class Generator
    {
        private long _userId = 0;

        public long GenerateId()
        {
            return ++_userId;
        }
    }
}