namespace TestDateFormat;

public class DateFormat
{
    public static String ChangeFormat(String year)
    {
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }
    }

    public static String ChangeToOtherFormat(String year)
    {
        {
            return year.Substring(0, 2) + "·" + year.Substring(3, 2)+ "·" + year.Substring(6);
        }
    }      
}
