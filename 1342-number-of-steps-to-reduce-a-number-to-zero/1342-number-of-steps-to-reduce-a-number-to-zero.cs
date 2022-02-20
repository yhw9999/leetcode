public class Solution {
    public int NumberOfSteps(int num) {
        
        var count = 0;
        
        while(num != 0){
            count++;
            if(num % 2 == 1){
                num -= 1;
            }
            else{
                num /= 2;
            }            
        }
        
        return count;
    }
}