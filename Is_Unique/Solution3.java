/* 
	Solution 3 (assuming ASCII character set) 

	If we can't use an additional data structure we can:
		1. Compare every character of the string to every other character of the string.
			This will take O(n^2) time and O(1) space
		2. If we are allowed to modify the input string, we could sort the string in O(n log n) time
			and then linearly check the string for neighboring characters that are identical. We would 
			also have to make sure our sorting algorithm did not take up additonal space.
*/