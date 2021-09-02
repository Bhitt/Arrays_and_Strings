/* 
	Solution 1 (GEEKS FOR GEEKS SOLUTION)
	
	Create a set to stroe last positions of occurrence

	Keep track of windows between repeating characters
*/


/* 
	Time Complexity: O() 
	Space Complexity: O()
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // Creating a set to store the last positions of occurrence
        Dictionary<char, int> seen = new Dictionary<char, int>(); 
        int maximum_length = 0;

        // starting the initial point of window to index 0
        int start = 0;

        for(int end = 0; end < s.Length; end++)
        {
          // Checking if we have already seen the element or not
          if(seen.ContainsKey(s[end]))
          {
            // If we have seen the number, move the start pointer
            // to position after the last occurrence
            start = Math.Max(start, seen[s[end]] + 1);
          }

          // Updating the last seen value of the character
          seen[s[end]] = end;
          maximum_length = Math.Max(maximum_length, end-start + 1);
        }
        return maximum_length;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 92 ms, faster than 56.91% of C# online submissions for Longest Substring Without 
		Repeating Characters.
	Memory Usage: 26.3 MB, less than 72.67% of C# online submissions for Longest Substring Without 
		Repeating Characters.
*/