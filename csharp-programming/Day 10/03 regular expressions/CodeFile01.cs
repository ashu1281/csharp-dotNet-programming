using System.Text.RegularExpressions;

namespace csharp_programming {
    class Program {
        static void Match(string s, string pattern) {
            Match m = Regex.Match(s, pattern);
            while (m.Success) {
                Console.WriteLine("pattern matched at index {0}, value = {1}", m.Index, m.Value);
                m = m.NextMatch();
            }
            Console.WriteLine();
        }

        static void Main() {
            string sentence = @"The quick brown owned fox jumps over the lazy own dog.";
            string phoneNumber = @"654-0932";
            string phoneNumbers = @"555-1212, 325-3535-800";
            string ipaddresses = "192.168.1.1; 123.456.789.012; 248.240.255.218";

            // 01. Find own
            Match(sentence, "own");

            // 02. Find words beginning and ending with own and own as a whole word
            Match(sentence, @"\bown");
            Match(sentence, @"own\b");
            Match(sentence, @"\bown\b");

            // 03. Find text with "quick" followed by "lazy"
            Match(sentence, @"\bquick\b.*\blazy\b");
            Match(sentence, @"\bown.{0,2}\b");

            // 04. Find seven-digit phone number
            Match(phoneNumbers, @"\b\d\d\d-\d\d\d\d");
            Match(phoneNumbers, @"\b\d{3}-\d{4}");
            Match(phoneNumbers, @"\b\d{3}-\d{4}[, ]");

            // 05. The string should contain only seven-digit phone number
            Match(phoneNumber, @"^\d{3}-\d{4}$");
            Match(phoneNumbers, @"^\d{3}-\d{4}$");

            // 06. Find all words that start with the letter t
            Match(sentence, @"\bt\w*\b");

            // 07. Find five letter words
            Match(sentence, @"\b\w{5}\b");

            // 07. Find repeated strings of digits
            Match(sentence, @"\b\d{3}-\d{4}");

            // 08 A simple IP address finder (Grouping)
            Match(ipaddresses, @"(\d{1,3}\.){3}\d{1,3}");

            // 09 IP finder, a better way
            Match(ipaddresses, @"((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)");
        }
    }
}