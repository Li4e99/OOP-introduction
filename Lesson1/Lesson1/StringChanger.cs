namespace Lesson1
{
    public class StringChanger
    {
        public string Reverse(string userChoice)
        {
            char[] reverse = userChoice.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
    }
}
