/* 
	Solution 2 
	
	The sum of numbers 1 through n should equal to (n * (n+1)) / 2 .
	Simply sum all of the entries and return the expected result - the actual result. The missing
	number should be the difference.
*/


/* 
	Time Complexity: O(n)
	Space Complexity: O(1)
*/

public class Solution {
    public int MissingNumber(int[] nums) {
        double sum = 0;
        foreach(int num in nums) sum+=num;
        int len = nums.Length;
        double expected = (len * (len+ 1)) / 2;
        return (int) (expected - sum);
    }
}

/*
	LEET CODE RESULTS

	Runtime: 104 ms, faster than 91.74% of C# online submissions for Missing Number.
	Memory Usage: 30.5 MB, less than 22.19% of C# online submissions for Missing Number.
*/