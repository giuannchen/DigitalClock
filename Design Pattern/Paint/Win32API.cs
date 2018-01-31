using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    /// <summary>
    /// Win32API
    /// </summary>
    internal class Win32API
    {
        /// <summary>
        /// 畫線
        /// </summary>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        /// <returns>內容</returns>
        public static string PrintLine(double x1, double y1, double x2, double y2)
        {
            return "Win32API PrintLine: x1=" + x1.ToString() + " y1=" + y1.ToString() + " x2=" + x2.ToString() + " y2=" + y2.ToString();
        }

        /// <summary>
        /// 畫圓
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <param name="radius">radius</param>
        /// <returns>內容</returns>
        public static string PrintRround(double x, double y, double radius)
        {
            return "Win32API PrintRround: x1=" + x.ToString() + " y=" + y.ToString() + " radius=" + radius.ToString();
        }

        /// <summary>
        /// 文字檔
        /// </summary>
        /// <param name="inputText">輸入</param>
        /// <returns>內容</returns>
        public static string PrintText(string inputText)
        {
            return "Win32API PrintText=" + inputText;
        }
    }
}