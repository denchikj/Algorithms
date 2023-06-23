namespace Algorithms.ReversingString.Implementations
{
    public class ReversingString
    {
        public static string ReverseString(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
                result += str[i];

            return result;
        }
    }
}