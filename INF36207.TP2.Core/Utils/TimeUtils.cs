using INF36207.TP2.Exceptions;

namespace INF36207.TP2.Utils;

/*
 * Tout le crédit de l'idée pour convertir un nombre de secondes
 * en temps écoulé doit être porté au compte de l'utilisateur
 * vikas_jk, 4 janvier 2021.
 * Repéré à https://qawithexperts.com/questions/484/how-to-convert-seconds-into-hhmmss-in-c
 */

public static class TimeUtils
{
    public static string GetTimeElapsed(int seconds)
    {
        if (seconds < 0)
            throw new IllegalTimespanException("Une durée ne peut pas être négative.");
        
        TimeSpan time = TimeSpan.FromSeconds(seconds);
        return time.ToString(@"hh\:mm\:ss");
    }
}