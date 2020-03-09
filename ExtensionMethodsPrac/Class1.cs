using System;


namespace ExtensionMethodsPrac
{
    public static class DatetimeExtension

    {
        public static int ToInt(this int addint)
        {
            return addint * addint;
        }
        public static string Toformat(this DateTime datetime)
        {

            return "My format " + datetime.ToString("d");
        }

        public static string Toformat(this DateTime dateTime, bool reverse)
        {
            string result = string.Empty;
            return result = reverse ? "My format " + dateTime.ToString("yyyy-MM-dd") : "My format " + dateTime.ToString("dd-MM-yyyy");
        }

        public static string Toformat(this string mystring)
        {
            return "My format " + mystring.ToUpper();
        }
    }
}
