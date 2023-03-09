namespace csharp_programming {
    public static class StringExtensions {
        public static bool IsPalindrome(string str) {
            int left = 0;
            int right = str.Length - 1;

            while (left < right) {
                if (str[left] != str[right]) {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }

    class Program {
        static void Main() {
            bool result = false;
            
            string s = "level";
            result = StringExtensions.IsPalindrome(s);

            string t = "hello";
            result = StringExtensions.IsPalindrome(t);
        }
    }
}
