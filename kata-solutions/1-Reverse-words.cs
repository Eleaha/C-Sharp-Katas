namespace ReverseWords
{
    public class Text
    {
        public static string Reverse(string words)
        {
            if (words.Length == 0)
            {
                return words;
            }
            string[] wordArr = words.Split(' ');
            if (wordArr.Length < 2)
            {
                return words;
            }
            Array.Reverse( wordArr );
            return String.Join(" ", wordArr);
        }
    }
}