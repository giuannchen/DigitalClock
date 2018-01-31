using Paint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    /// <summary>
    /// 繪圖程式庫V2
    /// </summary>
    internal class PainterV2 : IPainter
    {
        /// <summary>
        /// 文字檔
        /// </summary>
        /// <param name="inputText">輸入</param>
        /// <returns>內容</returns>
        public string PaintText(string inputText)
        {
            return Win32API.PrintText(inputText);
        }

        /// <summary>
        /// 畫線
        /// </summary>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        /// <returns>內容</returns>
        public string PrintLine(double x1, double y1, double x2, double y2)
        {
            return Win32API.PrintLine(x1, y1, x2, y2);
        }

        /// <summary>
        /// 畫圓
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <param name="radius">radius</param>
        /// <returns>內容</returns>
        public string PrintRround(double x, double y, double radius)
        {
            return Win32API.PrintRround(x, y, radius);
        }
    }
}