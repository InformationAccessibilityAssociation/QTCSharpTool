using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace QTCSharpTool
{
    /// <summary>
    /// cookie操作累
    /// </summary>
    public static class Cookie
    {

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref System.UInt32 pcchCookieData, int dwFlags, IntPtr lpReserved);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternetSetCookieEx(string lpszURL, string lpszCookieName, string lpszCookieData, int dwFlags, IntPtr dwReserved);

        public static string get(string url)
        {
            uint datasize = 4096;
            StringBuilder cookieData = new StringBuilder((int)datasize);
            if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x2000, IntPtr.Zero))
            {
                if (datasize < 0)
                    return null;
                cookieData = new StringBuilder((int)datasize);
                if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x00002000, IntPtr.Zero))
                    return null;
            }
            return cookieData.ToString();
        }
        public static void set(string url, string cookieName, string cookieValue)
        {

        }


    }
}
