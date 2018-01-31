using Paint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    /// <summary>
    /// 列印程式庫
    /// </summary>
    internal class Print : IPrinter
    {
        /// <summary>
        /// 取亂數
        /// </summary>
        /// <returns>回傳一到十</returns>
        public int GetRandomNum()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }

        /// <summary>
        /// 列印
        /// </summary>
        /// <param name="inputText">需要列印文字</param>
        /// <returns>列印的文字</returns>
        public string PrintText(string inputText)
        {
            return inputText;
        }
    }
}