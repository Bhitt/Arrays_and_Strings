/* 
	Solution 1 

	We use a hashtable to count how many times each character appears. There should be at most one
	character whose count is odd.

	Note: CTCI has another solution using an integer to act as a bit which improves on the space
	usage but not the time complexity.
*/


/* 
	Time Complexity: O(N)
	Space Complexity: O(1)
*/

boolean isPermutationOfPalindrome(String phrase){
	int[] table = buildCharFrequencyTable(phrase);
	return checkMaxOneOdd(table);
}

/* Check that no more than one character has an odd count */
boolean checkMaxOneOdd(int[] table){
	boolean foundOdd = false;
	for(int count : table){
		if(count % 2 == 1){
			if(foundOdd){
				return false;
			}
			foundOdd = true;
		}
	}
	return true;
}

/* Map each character to a number. a -> 0, b -> 1, etc.
 * This is case insensitive. Non-letter characters map to -1. */
int getCharNumber(Character c){
	int a = Character.getNumericValue('a');
	int z = Character.getNumericValue('z');
	int val = Character.getNumericValue(c);
	if(a <= val && val <= z){
		return val - a;
	}
	return -1;
}

/* Count how many times each character appears */
int[] buildCharFrequencyTable(String phrase){
	int[] table = new int[Character.getNumericValue('z') - Character.getNumericValue('a') + 1];
	for(char c : phrase.toCharArray()) {
		if(x != -1){
			table[x]++;
		}
	}
	return table;
}