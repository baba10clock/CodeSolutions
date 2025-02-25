public class Solution {
    public int Trap(int[] height) {
        int l = 0, r = height.Length -1, leftMax = height[l], rightMax = height[r];
        int volm = 0;
        while(l < r)
        {
            if(leftMax <= rightMax)
            {
                l++;
                leftMax = Math.Max(height[l], leftMax);
                volm += leftMax - height[l];
                
            }
            else
            {
                r--;
                rightMax = Math.Max(height[r], rightMax);
                volm += rightMax - height[r];
                
            }
        }
        return volm;
    }
}