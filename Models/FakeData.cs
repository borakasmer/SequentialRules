using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet.Models
{
    public static class FakeData
    {
        public static string Token = "234234223423";
        public static string RefreshToken = "98349785389732";
        public static DateTime TokenExpireDate = new DateTime(2022, 9, 23, 4, 50, 0);
        public static string IMEI = "111222333444555";
        public static int UserID = 1;


        public static void UpdateData()
        {
            TokenExpireDate = DateTime.UtcNow.AddHours(5);
            RefreshToken = "4124124124124142";
            Token = "214124124124124";
        }
    }
}
