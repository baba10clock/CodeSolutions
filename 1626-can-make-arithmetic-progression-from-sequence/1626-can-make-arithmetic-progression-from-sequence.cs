public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        arr = arr.OrderBy(x => x).ToArray();
        int i = 0, j = 1, diff = arr[j] - arr[i];
        while(j < arr.Length)
        {
            if(arr[j] - arr[i] != diff){
                return false;
            }
            i++;
            j++;
        }
        return true;
    }
}