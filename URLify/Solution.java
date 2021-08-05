/* 
	Solution 1  

	We will use a two-scan approach. In the first scan, we count the number of spaces. By tripling
	this number, we can compute how many extra characters we will have in the final string. In the
	second pass, which is done in reverse order, we actually edit the string. When we see a space,
	we replace it with %20. If there is no space, we copy the original character.

	Note: We use character arrays since Java arrays are immutable. If we used strings directly, the
	function would have to return a new copy of the string, but it would allow us to implement this
	in just one pass.
*/


/* 
	Time Complexity: O(n)
	Space Complexity: O(1)
*/

void replaceSpaces(char[] str, int trueLength){
	int spaceCount = 0, index, i=0;
	for(i=0; i<trueLength; i++){
		if(str[i] == ' '){
			spaceCount++;
		}
	}

	index = trueLength + spaceCount *2;
	if(trueLength < str.length) str[trueLength] = '\0'; //End Array
	for(i=trueLength-1; i>=0; i--){
		if(str[i] == ' '){
			str[index-1] = '0';
			str[index-2] = '2';
			str[index-3] = '%';
			index = index-3;
		} else {
			str[index-1] = str[i];
			index--;
		}
	}
}