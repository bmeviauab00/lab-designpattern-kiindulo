namespace DesignPatternApp.Helpers;

static class RandomHelper
{
    static Random rand = new Random();

    /// <summary>
    /// Visszaad egy random számot, ami alakzatok létrehozásánál használható paraméterezésre.
    /// </summary>
    static int getRandomValue()
    {
        return rand.Next(20, 250);
    }

    public static Rectangle GetRandomRect()
    {
        return new Rectangle(getRandomValue(), getRandomValue(), getRandomValue(), getRandomValue());
    }
}
