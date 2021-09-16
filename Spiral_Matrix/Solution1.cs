/* 
	Solution 1 
	
	Traverse in a spiral pattern you dingus. Also keep track of cases with only one row or column.
*/


/* 
	Time Complexity: O(m x n) time, since we touch each element once
	Space Complexity: O(m x n)
*/

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        if(matrix.Length == 1){
            return matrix[0];
        }
        if(matrix[0].Length == 1){
            return singleCol(matrix);
        }
        
        // Current direction
        bool direction = true;
        int stepsHorizontal = matrix[0].Length;
        int stepsVertical = matrix.Length - 1;
        int currentR = 0;
        int currentC = -1;
        
        // Resulting list
        List<int> spiral = new List<int>();
        
        // Traverse matrix in a spiral pattern
        while(stepsHorizontal > 0){
            // Move Horizontally
            for(int i = 0; i < stepsHorizontal; i++){
                if(direction) currentC++;
                else currentC--;
                spiral.Add(matrix[currentR][currentC]);
            }
            stepsHorizontal--;
            
            if(stepsVertical > 0){
               // Move Vertically
                for(int i = 0; i < stepsVertical; i++){
                    if(direction) currentR++;
                    else currentR--;
                    spiral.Add(matrix[currentR][currentC]);
                }
                stepsVertical--;
            } else {
                stepsHorizontal = 0;
            }
            
            // Swap direction
            direction = !direction;
        }
        
        // Exit stage right
        return spiral;
    }
    
    IList<int> singleCol(int[][] matrix){
        List<int> spiral = new List<int>();
        for(int i = 0; i < matrix.Length; i++){
            spiral.Add(matrix[i][0]);
        }
        return spiral;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 240 ms, faster than 55.16% of C# online submissions for Spiral Matrix.
	Memory Usage: 30.3 MB, less than 61.61% of C# online submissions for Spiral Matrix.
*/