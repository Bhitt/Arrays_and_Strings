/* 
    Solution 1 
    
    Use two pointers to copy valid elements towards the front. The slow pointer keeps track of the
    front elements and increments when a valid element is copied to the front. The fast pointer
    moves foward checking if elements are valid.
*/


/* 
    Time Complexity: O(n)
    Space Complexity: O(1)
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // check for empty nums
        if(nums.Length == 0) return 0;
        
        // two pointer approach, i = slow, j = fast
        int i = 0;
        // loop through, swapping valid items to the front
        for (int j = 0; j < nums.Length; j++) {
            if(nums[j] != val){
                // found a valid, swap it to the front
                nums[i] = nums[j];
                i++;
            }
        }
        
        return i;
    }
}

/*
    LEET CODE RESULTS
    
    Runtime: 290 ms, faster than 16.76% of C# online submissions for Remove Element.
    Memory Usage: 30.7 MB, less than 89.76% of C# online submissions for Remove Element.
*/