using System;
using System.Text;

namespace QTCSharpTool
{
    /// <summary>
    /// string扩展方法
    /// </summary>
    public static class QTCSharpToolmethodex
    {
        /// <summary>
        /// GB2312转换成UTF8
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string gb2312_utf8(this string text)
        {
            //声明字符集   
            System.Text.Encoding utf8, gb2312;
            //gb2312   
            gb2312 = System.Text.Encoding.GetEncoding("gb2312");
            //utf8   
            utf8 = System.Text.Encoding.GetEncoding("utf-8");
            byte[] gb;
            gb = gb2312.GetBytes(text);
            gb = System.Text.Encoding.Convert(gb2312, utf8, gb);
            //返回转换后的字符   
            return utf8.GetString(gb);
        }

        /// <summary>
        /// UTF8转换成GB2312
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string utf8_gb2312(this string text)
        {
            //声明字符集   
            System.Text.Encoding utf8, gb2312;
            //utf8   
            utf8 = System.Text.Encoding.GetEncoding("utf-8");
            //gb2312   
            gb2312 = System.Text.Encoding.GetEncoding("gb2312");
            byte[] utf;
            utf = utf8.GetBytes(text);
            utf = System.Text.Encoding.Convert(utf8, gb2312, utf);
            //返回转换后的字符   
            return gb2312.GetString(utf);
        }

        /// <summary>
        /// 字符串的编码转换
        /// </summary>
        /// <param name="text"></param>
        /// <param name="oenc">原编码</param>
        /// <param name="nenc">目标编码</param>
        /// <returns></returns>
        public static string EncodingConvert(this string text, System.Text.Encoding oenc, System.Text.Encoding nenc)
        {
            byte[] bytes;
            bytes = oenc.GetBytes(text);
            bytes = System.Text.Encoding.Convert(oenc, nenc, bytes);
            //返回转换后的字符   
            return nenc.GetString(bytes);
        }

        /// <summary>
        /// URL编码（默认GB2312）
        /// </summary>
        /// <param name="text">需要转换的字符串</param>
        /// <returns></returns>
        public static string UrlEncode(this string text)
        {
            return text.UrlEncode(System.Text.Encoding.GetEncoding("gb2312"));
        }

        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="text"></param>
        /// <param name="withencoding"></param>
        /// <returns></returns>
        public static string UrlEncode(this string text, System.Text.Encoding withencoding)
        {
            StringBuilder sb = new StringBuilder();
            byte[] bytes = withencoding.GetBytes(text); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(bytes[i], 16));
            }
            return (sb.ToString());
        }


        public static string md5(this string text)
        {
            return text.md5(System.Text.Encoding.GetEncoding("gb2312"));
        }

        public static string md5(this string text, System.Text.Encoding withencoding)
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] emailBytes = withencoding.GetBytes(text.ToLower());
            byte[] hashedEmailBytes = md5.ComputeHash(emailBytes);
            StringBuilder sb = new StringBuilder();
            foreach (var b in hashedEmailBytes)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

    }
}
