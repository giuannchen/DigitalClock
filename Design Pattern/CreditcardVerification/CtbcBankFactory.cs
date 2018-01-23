using CreditcardVerification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditcardVerification
{
    /// <summary>
    /// 中國信託銀行工廠
    /// </summary>
    public class CtbcBankFactory : IBankFactory
    {
        /// <summary>
        /// 產生驗證銀行
        /// </summary>
        /// <returns> 中國信託銀行</returns>
        public IBank VerificationCard()
        {
            return new CtbcBank();
        }
    }
}