namespace Palindrome
{
    public class PalindromeKata
    {
        public static bool IsPalindrome(string str)
        {
            string lowerStr = str.ToLower();
            char[] charArr = lowerStr.ToCharArray();
            Array.Reverse(charArr);
            string reversedStr = new string(charArr);
            return reversedStr == lowerStr ? true : false;
        }
    }
}
