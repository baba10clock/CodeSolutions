public class Solution {
    public int[][] KClosest(int[][] points, int k) {
       return points.OrderBy(i => i[0]*i[0] + i[1]*i[1]).Take(k).ToArray();
    }
}