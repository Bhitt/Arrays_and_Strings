/* 
	Solution 2 

	Check character counts. Create an array that acts like a hashtable, mapping characters
	to frequency. Increment through the first string, then decrement through the second string.
	If they are permutations, the array will be all zeros. Terminate early if a value goes
	negative.
*/


/* 
	Time Complexity: O(n)
	Space Complexity: O(1)
*/

boolean permutation(String s, String t){
	if(s.length()  != t.length()) return false; //Permutations must be the same length

	int[] letters = new int[128]; //Assuming ASCII
	for(int i=0; i<s.length(); i++){
		letters[s.charAt(i)]++;
	} 

	for(int i=0; i<t.length(); i++){
		letters[t.charAt(i)]--;
		if(letters[t.charAt(i)] < 0){
			return false;
		}
	}

	return true;
}