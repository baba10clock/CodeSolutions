public class Solution {
    public double Average(int[] salary) {
        int mini = int.MaxValue, maxx = int.MinValue;double total = 0;
        foreach(var i in salary)
        {
            if(mini > i)    mini = i;
            if(maxx < i)    maxx = i;
            total += i;
        }
        return (total - mini - maxx)/(salary.Length - 2);
    }
}