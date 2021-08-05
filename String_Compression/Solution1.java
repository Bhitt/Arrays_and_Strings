/* 
	Solution 1 

	One solution is to iterate through the string, copying characters to a new string and counting 
	the repeats. At each iteration, check if the current character is the same as the next character.
	If not, add its compressed version to the result. This is inefficient without StringBuilder
	because the concatenating operates in O(n^2) time. You must use StringBuilder!
*/


/* 
	Time Complexity: 
	Space Complexity: 
*/

String compress(String str){
	StringBuilder compressed = new StringBuilder();
	int countConsecutive = 0;
	for(int i=0; i<str.length; i++){

		/* if the next character is different than current, append this char to result. */
		if(i+1 >=  str.length || str.charAt(i) != str.charAt(i+1)){
			compressed.append(str.charAt(i));
			compressed.append(countConsecutive);
			countConsecutive = 0;
		}
	}
	return compressed.length() < str.length() ? compressed.toString() : str;
}
