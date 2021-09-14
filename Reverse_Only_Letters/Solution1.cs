/* 
    Solution 1 
    
    Using two pointers, we compare the start and end of the string. If both are valid letters, 
    we swap.
*/


/* 
    Time Complexity: O(N) time, where N is the length of s
    Space Complexity: O(N)
*/

public class Solution {
    public string ReverseOnlyLetters(string s) {
        StringBuilder ans = new StringBuilder();
        int j = s.Length - 1;
        for (int i = 0; i < s.Length; ++i) {
            if (Char.IsLetter(s[i])) {
                while (!Char.IsLetter(s[j]))
                    j--;
                ans.Append(s[j--]);
            } else {
                ans.Append(s[i]);
            }
        }

        return ans.ToString();
    }
}

/*
    LEET CODE RESULTS

    Runtime: 168 ms, faster than 5.26% of C# online submissions for Reverse Only Letters.
    Memory Usage: 23.2 MB, less than 97.89% of C# online submissions for Reverse Only Letters.
*/