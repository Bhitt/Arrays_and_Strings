/* 
	Solution 2 
	
	Unlike solution 1, we can check in advance if the new string will be shorter. This is optimal 
	for cases where we don't have a large number of repeating characters. It will also avoid
	creating a string that won't ever be used. The downside is that there is a second loop through
	the characters and also adds nearly duplicated code.
*/


/* 
	Time Complexity: 
	Space Complexity: 
*/

String compress(String str){
	/* check the final length and return the input if it would be longer */
	int finalLength = countCompression(str);
	if( finalLength >= str.length()) return str;

	StringBuilder compressed = new StringBuilder(finalLength);
	int countConsecutive = 0;
	for(int i=0; i<str.length i++){
		countConsecutive++;

		/* if the next character is different than the current, append this char to result */
		if(i+1 >= str.length() || str.charAt(i) != str.charAt(i+1)){
			compressed.append(str.charAt(i));
			compressed.append(countConsecutive);
			countConsecutive = 0;
		}
	}
	return compressed.toString();
}


int countCompression(String str){
	int compressedLength = 0;
	int countConsecutive = 0;
	for(int i=0; i<str.length(); i++){
		countConsecutive++;

		/* if the next character is different than the current, append this char to result */
		if(i+1 >= str.length() || str.charAt(i) != str.charAt(i+1)){
			compressedLength += 1 + String.valueOf(countConsecutive).length();
			countConsecutive = 0;
		}
	}
	return compressedLength;
}

