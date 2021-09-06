/* 
	Solution 1 
	
	Start from the end of the string. Find the first index that is not a whitespace. Following that,
	keep track of the next whitespace index.
	Subtrack the first index with the next whitespace index and return the length.

	If you reach the beginning of the string, instead return first index + 1.
*/


/* 
	Time Complexity: O(n) 
	Space Complexity: O(1)
*/

public class Solution {
    public int LengthOfLastWord(string s) {
        // Keep track of last word final character index
        int index = -1;
        
        for (int i = s.Length - 1; i >= 0; i--){
            if(index <= 0 && s[i] != ' ') index = i;
            if(index > 0 && s[i] == ' ') return index - i;
        }
        
        return index + 1;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 146 ms, faster than 5.12% of C# online submissions for Length of Last Word.
	Memory Usage: 22.6 MB, less than 77.81% of C# online submissions for Length of Last Word.
*/