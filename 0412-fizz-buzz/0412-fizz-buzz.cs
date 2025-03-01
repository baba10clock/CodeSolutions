public class Solution {
    public IList<string> FizzBuzz(int n) {

        var lst = new List<string>();
        for(int i = 1; i <= n; i++)
        {
            if(i % 15 == 0)    lst.Add("FizzBuzz");
            else if(i % 3 == 0) lst.Add("Fizz");
            else if(i % 5 == 0) lst.Add("Buzz");
            else    lst.Add(i.ToString());
        }
        return lst;
    }
}