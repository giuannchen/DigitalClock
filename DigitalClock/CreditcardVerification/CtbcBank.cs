using CreditcardVerification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditcardVerification
{
    /// <summary>
    /// 中國信託銀行
    /// </summary>
    public class CtbcBank : IBank
    {
        /// <summary>
        /// 驗證信用卡卡號實作
        /// </summary>
        /// <param name="InputNum">卡號</param>
        /// <returns>驗證結果</returns>
        public string VerificationNum(string InputNum)
        {
            return "中國信託驗證卡號" + InputNum + "完畢";
        }
    }
}