using System;

namespace OrderDiscount.Interfaces
{
    /// <summary>
    /// 抽出共同函式
    /// </summary>
    public interface IIDiscount
    {
        /// <summary>
        /// 打折
        /// </summary>
        /// <param name="originalAmt">原來的價格</param>
        /// <returns>打完折後的價格</returns>

        double DoDiscount(double originalAmt);
    }
}