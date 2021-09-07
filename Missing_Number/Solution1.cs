/* 
	Solution 1 
	
	My Strange Solution:
	Loop through the array, swapping the current number to its correct index (if the new number at
	the current index is not in the correct position, then swap... repeat)
	Loop through the array again and find the index that does not contain it's number.
*/


/* 
	Time Complexity: O(?)
	Space Complexity: O(1)
*/

public class Solution {
    public int MissingNumber(int[] nums) {
        // Swap helper
        int temp = 0;
        
        // Loop through swapping the number at nums[i] with its correct index
        for (int i = 0; i < nums.Length; i++){
            if(nums[i] < nums.Length){
                while(nums[i] != i && nums[i] < nums.Length){
                    // swap
                    temp = nums[nums[i]];
                    nums[nums[i]] = nums[i];
                    nums[i] = temp; 
                }
            }
        }
        
        // Find missing number
        for (int i = 0; i < nums.Length; i++){
            if(nums[i] != i) return i;
        }
        
        return nums.Length;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 108 ms, faster than 80.70% of C# online submissions for Missing Number.
	Memory Usage: 29.8 MB, less than 97.01% of C# online submissions for Missing Number.
*/