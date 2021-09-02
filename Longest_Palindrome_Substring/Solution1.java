/* 
	Solution 1 
	
	Starting with the maximum size substring, check if it is a palindrome. Work down from there
	checking all substrings of the next largest size.

	Checking a substring if it is a palindrome is simple. Just use two indexes and compare the 
	end of the string to the beginning, moving towards the center. They should all match until you
	hit the center.

*/


/* 
	Time Complexity: O()
	Space Complexity: O()
*/

class Solution {
    public String longestPalindrome(String s) {
        // String length 1 is always a palindrome
        if(s.length() == 1) return s;
        
        // Find the longestPalindrome substring starting with the largest possible
        int subLength = s.length();
        
        while(subLength > 1){
            for(int i = 0; i + subLength <= s.length(); i++ ){
                if(isPalindrome(s.substring(i,i+subLength))){
                    return s.substring(i, i+subLength);
                }
            }
            subLength--;
        }
        
        // None found, longest palindrome is length 1
        return s.substring(0,1);
        
    }
    
    boolean isPalindrome(String substr){
        int left = 0;
        int right = substr.length() - 1;
        
        while(left <= right){
            if(substr.charAt(left).equals(substr.charAt(right)) return false;
            left++;
            right--;
        }
        
        return true;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 2223 ms, faster than 5.00% of Java online submissions for Longest Palindromic Substring.
	Memory Usage: 625.5 MB, less than 5.15% of Java online submissions for Longest Palindromic Substring.
*/