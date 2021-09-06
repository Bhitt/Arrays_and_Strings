/* 
	Solution 2 (LEETCODE SOLUTION)
	
	Simply use Trim() to get rid of leading/trailing whitespaces, then Split(" ") to separate all
	sequences divided by whitespace, then return the final string in the split array's length.
*/


/* 
	Time Complexity: O() 
	Space Complexity: O()
*/

public class Solution {
    public int LengthOfLastWord(string s) {
        string[] splitString = s.Trim(' ').Split(" ");
        return splitString[splitString.Length - 1].Length;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 109 ms, faster than 15.54% of C# online submissions for Length of Last Word.
	Memory Usage: 22.8 MB, less than 48.52% of C# online submissions for Length of Last Word.
*/