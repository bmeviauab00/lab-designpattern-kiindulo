namespace DesignPatternApp.Helpers;

public static class RandomHelper
{
    private static Random rand = new Random();

    /// <summary>
    /// Visszaad egy random számot, ami alakzatok létrehozásánál használható paraméterezésre.
    /// </summary>
    private static int GetRandomValue()
    {
        return rand.Next(20, 250);
    }

    /// <summary>
    /// Visszaad egy random pozícióban lévő random méretű téglalapot
    /// </summary>
    /// <returns></returns>
    public static Rectangle GetRandomRect()
    {
        return new Rectangle(GetRandomValue(), GetRandomValue(), GetRandomValue(), GetRandomValue());
    }
}
