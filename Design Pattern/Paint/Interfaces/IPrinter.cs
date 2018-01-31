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
    public interface IPrinter
    {
        /// <summary>
        /// 取1-10亂數
        /// </summary>
        /// <returns>回傳值</returns>
        int GetRandomNum();

        /// <summary>
        /// 列印內容
        /// </summary>
        /// <param name="inputText">輸入</param>
        /// <returns>印出內容</returns>
        string PrintText(string inputText);
    }
}