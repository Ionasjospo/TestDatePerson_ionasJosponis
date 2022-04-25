using System;

namespace TestDateFormat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, DateFormat.ChangeFormat(testDate));

            string testDate2 = "09/10/2002";
            Console.WriteLine("{0} se convierte a: {1} ", testDate2, DateFormat.ChangeToOtherFormat(testDate2));


        }
    }
}