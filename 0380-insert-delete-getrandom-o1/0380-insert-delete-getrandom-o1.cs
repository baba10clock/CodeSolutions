public class RandomizedSet {
    private HashSet<int> set;
    public RandomizedSet() {
        set = new HashSet<int>();
    }
    
    public bool Insert(int val) {
        if(!set.Contains(val))
        {
            set.Add(val);
            return true;
        }
        return false;
    }
    
    public bool Remove(int val) {
        if(set.Contains(val))
        {
            set.Remove(val);
            return true;
        }
        return false;
    }
    
    public int GetRandom() {
        var rand = new Random();
        var lst = new List<int>(set);
        return lst[rand.Next(lst.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */