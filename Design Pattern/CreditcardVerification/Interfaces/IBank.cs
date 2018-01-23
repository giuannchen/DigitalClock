using System;

namespace CreditcardVerification.Interfaces
{
    /// <summary>
    /// 抽出共同函式
    /// </summary>
    public interface IBank
    {
        /// <summary>
        /// 驗證信用卡號碼
        /// </summary>
        /// <param name="InputNum">卡號</param>
        /// <returns>驗證結果</returns>
        string VerificationNum(string InputNum);
    }
}