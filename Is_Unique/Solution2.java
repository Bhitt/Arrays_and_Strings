/* 
	Solution 2 (assuming ASCII character set) 

	Similar to solution 1, we can reduce space used by a factor of 8 if we use a
	bit vector.
*/


/* 
	Time Complexity:  O(n), where n is the length of the string
	Space Complexity: O(1)
*/

boolean isUniqueChars(String str){
	int checker = 0;
	for(int i=0; i<str.length(); i++){
		int val = str.charAt(i) - 'a';
		if((checker & (1 << val)) > 0){
			return false;
		}
		checker |= (1 << val);
	}
	return true;
}