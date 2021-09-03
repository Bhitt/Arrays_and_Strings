/* 
	Solution 1 
	
	Start with a binary search to look for the value. If the value does not exist, return the 
	left/low value at the end of the binary search. It should be at an index where the new value 
	would be inserted.
*/


/* 
	Time Complexity: O(log n) 
	Space Complexity: O(1)
*/

public class Solution {
    public int SearchInsert (int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int mid;
        
        while (left <= right) {
            mid = (left + right) / 2;
            if (nums[mid] < target) {
                left = mid + 1;
            } else if (nums[mid] > target) {
                right = mid - 1;
            } else {
                return mid;
            }
        }
        return left;  // Normally we would return an error value such as -1
    }
}

/*
	LEET CODE RESULTS

	Runtime: 109 ms, faster than 21.47% of C# online submissions for Search Insert Position.
	Memory Usage: 25.2 MB, less than 73.60% of C# online submissions for Search Insert Position.
*/