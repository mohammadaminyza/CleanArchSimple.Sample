namespace CleanArch.Common.Extensions;

public static class Linq
{

    public static string ToShamsi(this DateTime dateTime)
    {
        //Todo Persian Calnder

        return dateTime.ToString();
    }
}