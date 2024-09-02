namespace ReverseWords
{
    public class ReverseWordsKata
    {
        public static string Reverse(string str)
        {
            if (str.Length == 0)
            {
                return str;
            }
            string[] wordArr = str.Split(' ');
            if (wordArr.Length < 2)
            {
                return str;
            }
            Array.Reverse(wordArr);
            return String.Join(" ", wordArr);
        }
    }
}