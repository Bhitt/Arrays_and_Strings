/* 
	Solution 1 
	
	1) Copy the string to a character array
	2) Iterate backwards through the shifts array and put the new shift value equal to the shift at
	that value plus the total shifts so far (values from right of i). Mod that number by 26.
	3) Iterate through string s and shift each character by the correct value
	4) Return the string.
*/


/* 
	Time Complexity: O(n) 
	Space Complexity: O(n)
*/

public class Solution {
    public string ShiftingLetters(string s, int[] shifts) {
        // Move string to char array
        char[] copy = s.ToCharArray();
        int temp = 0;
        int shift = 0;
        
        // Iterate backwards through shift ( shift[i] = total shifts so far + shift[i]) and mod26
        for(int i = shifts.Length -1 ; i >= 0; i--){
            shift = (shift + shifts[i]) % 26;
            shifts[i] = shift;
        }
        
        // Iterate through and shift characters
        for( int i = 0; i < shifts.Length; i++){
            temp = shifts[i] + Convert.ToInt32(copy[i]);
            if(temp > 122) temp -= 26;
            copy[i] = Convert.ToChar(temp);
        }
        
        s = new string(copy);
        
        return s;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 236 ms, faster than 77.78% of C# online submissions for Shifting Letters.
	Memory Usage: 46.7 MB, less than 58.33% of C# online submissions for Shifting Letters.
*/