using Paint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    /// <summary>
    /// 長方形
    /// </summary>
    internal class Rectangle : Graphics
    {
        /// <summary>
        /// 變數
        /// </summary>
        private double x1, x2, y1, y2;

        /// <summary>
        /// 初始畫
        /// </summary>
        /// <param name="painter">畫圖庫</param>
        /// <param name="printer">列印庫</param>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        public Rectangle(IPainter painter, IPrinter printer, double x1, double y1, double x2, double y2)
        {
            this.painter = painter;
            this.printer = printer;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        /// <summary>
        /// 列印
        /// </summary>
        /// <returns>內容</returns>
        public override string PrintTo()
        {
            return "列印" + this.printer.GetRandomNum().ToString() + "次 " + this.printer.PrintText(ShowDisplay());
        }

        /// <summary>
        /// 螢幕輸出
        /// </summary>
        /// <returns>內容</returns>
        public override string ShowDisplay()
        {
            return this.PrintLine(this.x1, this.y1, this.x2, this.y1) + "  " +
            this.PrintLine(this.x2, this.y1, this.x2, this.y2) + "  " +
            this.PrintLine(this.x2, this.y2, this.x1, this.y2) + "  " +
            this.PrintLine(this.x1, this.y2, this.x1, this.y1);
        }
    }
}