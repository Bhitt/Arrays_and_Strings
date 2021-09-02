/* 
	Solution 1 
	
	Use two pointers to keep track of where to swap unique elements.
*/


/* 
	Time Complexity: O(n)
	Space Complexity: O(1)
*/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Empty Array
        if (nums.Length == 0) return 0;
        
        // Last valid index for swap
        int uniqueP = 0;
        
        // Loop through numbers swapping at the last valid index
        for (int i = 1; i < nums.Length; i++) {
            if(nums[i] != nums[uniqueP]){
                uniqueP++;
                swap(nums, uniqueP, i);
            }
        }
        
        return uniqueP + 1;
    }
    
    void swap (int[] arr, int a, int b) {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 348 ms, faster than 19.04% of C# online submissions for Remove Duplicates from Sorted 
		Array.
	Memory Usage: 33.5 MB, less than 98.68% of C# online submissions for Remove Duplicates from 
		Sorted Array
*/