/* 
	Solution 1 
	
	Depending on the length of both strings, we can scan both strings at the same time and keep 
	track of any differences. If there is more than one difference, terminate.

	Note: There is another solution that combines the work in oneEditReplace and oneEditInsert to 
	one method. This avoids duplicate code but loses some readability. Each approach is acceptible
	and has tradeoffs that can be discussed during an interview.
*/


/* 
	Time Complexity: O(n), where n is the length of the shorter string
	Space Complexity: O(1)
*/

boolean oneEditAway(String first, String second){
	if(first.length() == second.length()){
		return oneEditReplace(first, second);
	} else if(first.length() + 1 == second.length()){
		return oneEditInsert(first, second);
	} else if(first.length() - 1 == second.length()){
		return oneEditInsert(second, first);
	}
	return false;
}

boolean oneEditReplace(String s1, String s2){
	boolean foundDifference = false;
	for(int i=0; i<s1.length(); i++){
		if(s1.charAt(i) !=  s2.charAt(i)){
			if(foundDifference){
				return false;
			}
			foundDifference = true;
		}
	}
	return true;
}

boolean oneEditInsert(String s1, String s2){
	int index1 = 0;
	int index2 = 0;
	while(index2 < s2.length() && index1 < s1.length()){
		if(s1.charAt(index1) != s2.charAt(index2)){
			if(index1 != index2){
				return false;
			}
			index2++;
		} else {
			index1++;
			index2++;
		}
	}
	return true;
}