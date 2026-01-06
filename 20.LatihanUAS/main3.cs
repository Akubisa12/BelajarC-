public class Program
{
    public static string AreYouPlayingBanjo(string name)
    {
        char firstChar = name[0];
        if (firstChar == 'R' || firstChar == 'r')
        {
            return name + " plays banjo";
        }
        else
        {
            return name + " does not play banjo";
        }
    }
}