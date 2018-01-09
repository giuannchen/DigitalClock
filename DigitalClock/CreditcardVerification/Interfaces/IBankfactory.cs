using System;

namespace CreditcardVerification.Interfaces
{
    /// <summary>
    /// 抽出共同工廠
    /// </summary>
    public interface IBankFactory
    {
        /// <summary>
        /// 驗證信用卡
        /// </summary>
        /// <returns>銀行</returns>
        IBank VerificationCard();
    }
}