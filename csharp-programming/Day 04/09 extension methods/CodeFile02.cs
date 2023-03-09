namespace csharp_programming {
    public static class StringExtensions {
        public static bool IsPalindrome(this string str) {
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
            result = s.IsPalindrome();

            string t = "hello";
            result = t.IsPalindrome();

            result = "radar".IsPalindrome();

            result = StringExtensions.IsPalindrome("racecar");
        }
    }
}
