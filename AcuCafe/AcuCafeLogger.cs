using System.Diagnostics;
using System.Text;

namespace AcuCafe
{
    internal class AcuCafeLogger
    {
       

        public static void WriteLine(string message)
        {
        //    StringBuilder.Append(message);
            Debug.WriteLine(message);
        }
    }
}