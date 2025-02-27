public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        var map = new Dictionary<int, int>();
        map[0] = 0;
         foreach(var i in wall)
        {
            int total = 0;
            foreach(var j in i.SkipLast(1))
            {
                total += j;
                map[total] = map.GetValueOrDefault(total) + 1;
            }
        }
        return wall.Count - map.Values.Max();
    }
}