using Paint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    /// <summary>
    /// 圓形
    /// </summary>
    internal class Round : Graphics
    {
        /// <summary>
        /// 變數
        /// </summary>
        private double radius;

        private double x;
        private double y;

        /// <summary>
        /// 初始畫
        /// </summary>
        /// <param name="painter">繪圖</param>
        /// <param name="printer">列印</param>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <param name="radius">radius</param>
        public Round(IPainter painter, IPrinter printer, double x, double y, double radius)
        {
            this.painter = painter;
            this.printer = printer;
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        /// <summary>
        /// 列印
        /// </summary>
        /// <returns></returns>
        public override string PrintTo()
        {
            return "列印" + this.printer.GetRandomNum().ToString() + "次 " + this.printer.PrintText(ShowDisplay());
        }

        /// <summary>
        /// 螢幕輸出
        /// </summary>
        /// <returns></returns>
        public override string ShowDisplay()
        {
            return this.PrintRround(x, y, radius);
        }
    }
}