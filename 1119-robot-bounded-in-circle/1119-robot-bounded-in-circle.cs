public class Solution {
    public bool IsRobotBounded(string instructions) {
        int x = 0, y = 0, dirX = 0, dirY = 1;

        foreach(var i in instructions)
        {
            if(i == 'G')
            {
                (x, y) = ( x+dirX, y+dirY);
            }
            else if(i == 'L')
            {
                (dirX, dirY)=(-dirY, dirX);
            }
            else
            {
                (dirX, dirY)=( dirY, -dirX);
            }
        }
        return (x,y) == (0,0) || (dirX, dirY) != (0,1);
    }
}