/* 
	Solution 1 
	
	Moving layer by layer (think outside to inside), you can implement this by swapping indexes.
*/


/* 
	Time Complexity: O(N^2), the algorithm must touch all N^2 elements
	Space Complexity: O(1), we only ever save one extra int instead of all N elements in an array
*/

boolean rotate(int[][] matrix){
	if(matrix.length == 0 || matrix.length != matrix[0].length) return false;
	int n = matrix.length;
	for(int layer=0; layer<n/2; layer++){
		int first = layer;
		int last = n - 1 - layer;
		for(int i = first; i<last; i++){
			int offset = i - first;
			
			int top = matrix[first][i]; // save top
			
			//left -> top
			matrix[first][i] = matrix[last-offset][first];

			//bottom -> left
			matrix[last-offset][first] = matrix[last][last-offset];

			//right -> bottom
			matrix[last][last-offset] = matrix[i][last];

			//top -> right
			matrix[i][last] = top;
		}
	}
	return true;
}