using CreditcardVerification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditcardVerification
{
    /// <summary>
    /// 國泰世華銀行
    /// </summary>
    public class CathayBank : IBank
    {
        /// <summary>
        /// 驗證信用卡卡號實作
        /// </summary>
        /// <param name="InputNum">卡號</param>
        /// <returns>驗證結果</returns>
        public string VerificationNum(string InputNum)
        {
            return "國泰世華驗證卡號" + InputNum + "完畢";
        }
    }
}