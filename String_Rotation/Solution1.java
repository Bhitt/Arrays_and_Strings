/* 
	Solution 1 
	
	is s1 = xy    and   s2 = yx
	then yx should always be a substring of xyxy
*/


/* 
	Time Complexity: If you assume isSubstring runs in O(A+B), then the runtime is O(N)
	Space Complexity: O(A)
*/

boolean isRotation(String s1, String s2){
	int len = s1.length();
	/* check that they are equal length and not empty */
	if(len == s2.length() && len > 0){
		/* concatenate s1 and s1 with a new buffer */
		String s1s1 = s1 + s1;
		return isSubstring(s1s1, s2);
	}
	return false;
}