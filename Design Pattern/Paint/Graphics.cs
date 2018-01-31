using Paint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    /// <summary>
    /// 圖形
    /// </summary>
    public abstract class Graphics
    {
        /// <summary>
        /// 繪圖程式庫
        /// </summary>
        protected IPainter painter = null;

        /// <summary>
        /// 列印程式庫
        /// </summary>
        protected IPrinter printer = null;

        /// <summary>
        /// 輸出文字檔
        /// </summary>
        /// <param name="inputText">輸入</param>
        /// <returns>內容</returns>
        public string PaintText(string inputText)
        {
            return this.painter.PaintText(inputText);
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
            return this.painter.PrintLine(x1, y1, x2, y2);
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
            return this.painter.PrintRround(x, y, radius);
        }

        /// <summary>
        /// 隨機列印
        /// </summary>
        /// <param name="inputText">輸入</param>
        /// <returns>內容</returns>
        public string PrintText(string inputText)
        {
            return this.printer.PrintText(inputText);
        }

        /// <summary>
        /// 隨機列印
        /// </summary>
        /// <returns>內容</returns>
        abstract public string PrintTo();

        /// <summary>
        /// 顯示
        /// </summary>
        /// <returns>內容</returns>
        abstract public string ShowDisplay();
    }
}