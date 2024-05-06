// https://leetcode.com/problems/longest-palindromic-substring/description/

static string LongestPalindrome(string s) {
    string maxPalindrome = "";
    System.Console.WriteLine($"s = {s}");

    if (s.Length <= 1)
        return s;

    for (int i = 0; i < s.Length; i++) {
        System.Console.WriteLine($"i = {i}");

        // odd length palindrome
        string oddPalindrome = Char.ToString(s[i]);
        for (int j = 1; j <= Math.Min(i, s.Length - 1 - i); j++) {
            System.Console.WriteLine($"s[i] = '{s[i]}'\tj = {j}\ts[i-j] = '{s[i-j]}'\ts[i+j] = '{s[i+j]}'");
            if (s[i-j] == s[i+j]) {
                oddPalindrome = Char.ToString(s[i-j]) + oddPalindrome + Char.ToString(s[i+j]);
            }
            else
                break;
        }
        if (oddPalindrome.Length > maxPalindrome.Length) {
            maxPalindrome = oddPalindrome;
        }

        //even length palindrome
        if (i < s.Length - 1 && s[i] == s[i+1]) {
            string evenPalindrome = s.Substring(i,2);
            for (int j = 1; j <= Math.Min(i, s.Length - 1 - (i + 1)); j++) {
                if (s[i-j] == s[i+1+j]) {
                    evenPalindrome = Char.ToString(s[i-j]) + evenPalindrome + Char.ToString(s[i+1+j]);
                }
                else
                    break;
            }
            if (evenPalindrome.Length > maxPalindrome.Length) {
                maxPalindrome = evenPalindrome;
            }
        }
        System.Console.WriteLine($"---- maxPalindrome = '{maxPalindrome}' ----");
    }
    return maxPalindrome;
}

// string input = "babad";
// string input = "cbbd";
string input = "cbbcd";
// string input = "bb";
// string input = "aacabdkacaa";
string answer = LongestPalindrome(input);
System.Console.WriteLine($"The answer is '{answer}'");
