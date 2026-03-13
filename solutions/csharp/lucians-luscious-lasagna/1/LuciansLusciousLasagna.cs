namespace Exercism;

class Lasagna
{
    public static int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int elapsedMinutes) => ExpectedMinutesInOven() - elapsedMinutes;

    public int PreparationTimeInMinutes(int layers) => layers * 2;

    public int ElapsedTimeInMinutes(int layers, int minutesInOven) => minutesInOven + PreparationTimeInMinutes(layers);
}