/* 
	Solution 1 
	
	Start from the end of the array adding 1 and continue to move backward if a carry is needed.
	If you reach the beginning and still have a carry, create a new array of original array size + 1
	and set the first value to 1.
*/


/* 
	Time Complexity: O(n), where n is the size of the array.
	Space Complexity: O(n), if all items in the original array are 9. O(1) otherwise.
*/

public class Solution {
    public int[] PlusOne(int[] digits) {
        // carry value
        bool carry = true;
        int index = digits.Length - 1;
        // Loop from end to front, adding 1 and carrying if needed
        while(carry && index >= 0){
            if(digits[index] + 1 > 9){
                digits[index] = 0;
                index--;
            } else {
                carry = false;
                digits[index] = digits[index] +  1;
            }
        }
        
        // If carry is still true, you will need a larger array
        if(carry){
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            return newDigits;
        }
        
        return digits;
    
    }
}

/*
	LEET CODE RESULTS

	Runtime: 228 ms, faster than 92.24% of C# online submissions for Plus One.
	Memory Usage: 30.6 MB, less than 84.70% of C# online submissions for Plus One.
*/