using System.Globalization;

namespace MinhaApi.Services
{
    public class Useful
    {
        public static bool IsNumeric(string x1)
        {
            double result;
            if(double.TryParse(x1, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out result))
                return true;
            return false;
        }
    }
}