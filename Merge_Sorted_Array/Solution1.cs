/* 
	Solution 1 
	
	Use the sizes m and n to relate as indexing for the end of nums1, the index of the end element 
	in m that hasn't yet been merges, and the index of the end element in n that hasn't yet been
	merged.

	End of nums1 : m + n - 1
	End element of nums1: m
	End element of nums2: n

	While m and n are greater than 0
		Place the greater element of nums1 and nums2 at the end of nums1.
		Decrement the index of either m or n (which also decrements the index for the end of nums1).

	While some elements remain in nums2
		Place the element from nums2 into nums1;
*/


/* 
	Time Complexity: O(m + n)
	Space Complexity: O(1)
*/

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        while(m > 0 && n > 0){
            if(nums1[m-1] > nums2[n-1]){
                nums1[m+n-1] = nums1[m-1];
                m--;
            }else{
                nums1[m+n-1] = nums2[n-1];
                n--;
            }
        }
 
        while(n > 0){
            nums1[m+n-1] = nums2[n-1];
            n--;
        }
    }
}

/*
	LEET CODE RESULTS

	Runtime: 232 ms, faster than 87.85% of C# online submissions for Merge Sorted Array.
	Memory Usage: 31.3 MB, less than 10.53% of C# online submissions for Merge Sorted Array.
*/