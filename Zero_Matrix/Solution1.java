/* 
	Solution 1 
	
	We use two arrays to keep track of all the rows with zeros and all the columns with zeros. We
	then nullify the rows and columns based on the values in these arrays.

	Note: There is a solution that reduces space usage to O(1) by using the first row as a replacement
	for the row array and the first column as a replacement for the column array.
*/


/* 
	Time Complexity: O(MN)
	Space Complexity: O(MN)
*/

void setZeros(int[][] matrix){
	boolean[] row = new boolean[matrix.length];
	boolean[] column = new boolean[matrix[0].length];

	//Store the row and column index with value 0
	for(int i=0; i<matrix.length; i++){
		for(int j=0; j<matrix[0].length; j++){
			if(matrix[i][j] == 0){
				row[i] = true;
				column[j] = true;
			}
		}
	}

	//Nullify rows
	for(int i=0; i<row.length; i++){
		if(row[i]) nullifyRow(matrix, i);
	}

	//Nullify columns
	for(int j=0; j<column.length; j++){
		if(column[j]) nullifyColumn(matrix, j);
	}
}


void nullifyRow(int[][] matrix, int row){
	for(int j=0; j<matrix[0].length; j++){
		matrix[row][j] = 0;
	}
}

void nullifyColumn(int[][] matrix, int column){
	for(int i=0; i<matrix.length; i++){
		matrix[i][column] = 0;
	}
}