public class Solution {
    public int PivotIndex(int[] nums) {
        int size = nums.Length;
        int [] arr = new int [size];
        int temp = 0;
        for(int i = 0; i < size ; i++)
        {   temp += nums[i];
            arr[i] = temp;
        }
        if(arr[0] - arr[size - 1] == 0)
        {
            return 0;
        }
        for(int i = 0; i < size ; i++)
        {
            if( i != 0 && arr[size - 1] - arr[i] == arr[i - 1])
            {
                return i;
            }
        }
        return -1;
    }
}