class Lasagna
{
    const int COOK_TIME = 40;
    const int MINUTES_PER_LAYER = 2;
    public int ExpectedMinutesInOven(){
        return COOK_TIME;
    }

    public int RemainingMinutesInOven(int minutesElapsed){
        return COOK_TIME - minutesElapsed;
    }

    public int PreparationTimeInMinutes(int numberOfLayers){ 
        return numberOfLayers * MINUTES_PER_LAYER;
    }

    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesElapsed){
        return PreparationTimeInMinutes(numberOfLayers) + minutesElapsed;
    }
}
