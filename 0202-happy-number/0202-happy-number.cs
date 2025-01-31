public class Solution {
    public bool IsHappy(int n) {
        
        var set = new HashSet<int>();


        while(!set.Contains(n))
        {
            set.Add(n);
            var output = 0;
            var digit = 0;
            while(n > 0)
            {
                digit = n % 10;
                output += (int)(Math.Pow(digit, 2));
                n = n / 10;
            }
            if( output == 1) return true;
            n = output;
        }

        return false;


    }
}