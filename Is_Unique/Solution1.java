/* 
	Solution 1 (assuming ASCII character set) 

	Create an array of boolean values, where the flag at index i indicates whether
	character i in the alphabet is in the string. The second time you see this character you can return false.
*/


/* 
	Time Complexity: O(n), where n is the length of the string
	Space Complexity: O(1), since the size here is fixed to 128 in all cases
*/


boolean isUniqueChars(String str){
	
	/* first check if the string has more characters than the set */
	if(str.length() > 128) return false;

	/* create the boolean array */
	boolean[] char_set = new boolean[128];

	/* loop through each character in the input string */
	for(int i=0; i< str.length(); i++){
		int val = str.charAt(i);
		/* check if you already found this character */
		if(char_set[val]){
			return false;
		}
		/* otherwise, set the flag to true */
		char_set[val] = true;
	}

	/* all characters checked with no problems */
	return true;
}