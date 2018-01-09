using CreditcardVerification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditcardVerification
{
    /// <summary>
    /// Nccc銀行
    /// </summary>
    public class NcccBank : IBank
    {
        /// <summary>
        /// 驗證信用卡卡號實作
        /// </summary>
        /// <param name="InputNum">卡號</param>
        /// <returns>驗證結果</returns>
        public string VerificationNum(string InputNum)
        {
            return "Nccc驗證卡號" + InputNum + "完畢";
        }
    }
}