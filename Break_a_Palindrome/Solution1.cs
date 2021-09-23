/* 
	Solution 1 
	
	Find the first non 'a' character and swap to 'a'.
	If all 'a' characters, swap final 'a' to a 'b'.
*/


/* 
	Time Complexity: O(n) , where n is the length of the string
	Space Complexity: O(n) space for copying the string to the char array
*/


public class Solution {
    public string BreakPalindrome(string palindrome) {
        // Single character case
        if(palindrome.Length == 1) return "";
        
        // Move the string to a char array
        char[] chars = palindrome.ToCharArray();
        
        // Move through and find vialble candidate to swap to 'a'
        // If none found, increment the final char by 1
        for(int i = 0; i < chars.Length; i++){
            if(chars[i] != 'a' && i != chars.Length/2){
                chars[i] = 'a'; // Swap to 'a' and return string
                return new string(chars);
            }
            if(i == chars.Length - 1){
                chars[i] = 'b'; // Swap to 'b' and return string
                return new string(chars);
            }
        }
        
        // Return error
        return "ERROR";
    }
}


/*
	LEET CODE RESULTS

	Runtime: 76 ms, faster than 100.00% of C# online submissions for Break a Palindrome.
	Memory Usage: 22.9 MB, less than 94.23% of C# online submissions for Break a Palindrome.
*/