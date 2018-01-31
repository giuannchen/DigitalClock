using System;

namespace Paint.Interfaces
{
    /// <summary>
    /// 繪圖程式庫
    /// </summary>
    public interface IPainter
    {
        /// <summary>
        /// 文字檔
        /// </summary>
        /// <param name="inputText">輸入內容</param>
        /// <returns>書出內容</returns>
        string PaintText(string inputText);

        /// <summary>
        /// 畫線
        /// </summary>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        /// <returns>內容</returns>
        string PrintLine(double x1, double y1, double x2, double y2);

        /// <summary>
        /// 畫圓
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <param name="radius">radius</param>
        /// <returns>內容</returns>
        string PrintRround(double x, double y, double radius);
    }
}