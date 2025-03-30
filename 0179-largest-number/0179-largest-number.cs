public class Solution {
    public string LargestNumber(int[] nums) {
        var numbers = nums.Select(x => x.ToString()).ToArray();
        Array.Sort(numbers, (a, b) => string.Compare(b + a, a + b));
        if(numbers[0] == "0")   return "0";
        return string.Join("",numbers);
    }
}