public class NumArray {
    private List<int> lst;
    public NumArray(int[] nums) {
        lst = new List<int>(nums);
    }
    
    public int SumRange(int left, int right) {
        return lst[left..(right + 1)].Sum();
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */