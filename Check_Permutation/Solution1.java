/* 
	Solution 1 

	Sort the strings. Compare after sorting. Not efficient but simple to
	implement and understand.
*/


String sort(String s){
	char[] content = s.toCharArray();
	java.util.Array.sort(content);
	return new String(content);
}

boolean permutation(String s, String t){
	/* first check that the strings are the same length */
	if(s.length() != t.length()){
		return false;
	}

	/* compare the sorted strings */
	return sort(s).equals(sort(t));
}