using Paint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    /// <summary>
    /// 文字檔
    /// </summary>
    internal class Text : Graphics
    {
        /// <summary>
        /// 變數
        /// </summary>
        private string inputText;

        /// <summary>
        /// 初始
        /// </summary>
        /// <param name="painter">繪圖庫</param>
        /// <param name="printer">列印庫</param>
        /// <param name="inputText">輸入內容</param>
        public Text(IPainter painter, IPrinter printer, string inputText)
        {
            this.painter = painter;
            this.printer = printer;
            this.inputText = inputText;
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
            return this.PaintText(inputText);
        }
    }
}