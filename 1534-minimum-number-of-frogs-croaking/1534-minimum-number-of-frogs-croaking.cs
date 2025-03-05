public class Solution {
    public int MinNumberOfFrogs(string croakOfFrogs) {
        int c = 0, r = 0, o = 0, a = 0, k = 0, frog = 0, maxFrogs = 0;
        foreach(var voice in croakOfFrogs)
        {
            switch(voice)
            {
                case 'c':
                    c++;
                    frog++;
                    maxFrogs = Math.Max(maxFrogs, frog);
                    break;
                case 'r':
                    if(c == 0)  return -1;
                    c--;
                    r++;
                    break;
                case 'o':
                    if(r == 0) return -1;
                    r--;
                    o++;
                    break;
                case 'a':
                    if(o == 0)  return -1;
                    o--;
                    a++;
                    break;
                case 'k':
                    if(a == 0) return -1;
                    a--;
                    k++;
                    frog--;
                    break;
            }
        }
        if(c == 0 && r == 0 && o == 0 && a == 0)
            return maxFrogs;
        return -1;
    }
}