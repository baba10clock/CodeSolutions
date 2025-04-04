public class ParkingSystem {
    private int bigCount, mediumCount, smallCount;

    public ParkingSystem(int big, int medium, int small) {
        bigCount = big;
        mediumCount = medium;
        smallCount = small; 
    }
    
    public bool AddCar(int carType) {
        switch(carType)
        {
            case 1:
                if(bigCount > 0)
                {
                    bigCount--;
                    return true;
                }
                break;
            case 2:
                if(mediumCount > 0)
                {
                    mediumCount--;
                    return true;
                }
                break;
            case 3:
                if(smallCount > 0)
                {
                    smallCount--;
                    return true;
                }
                break;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */