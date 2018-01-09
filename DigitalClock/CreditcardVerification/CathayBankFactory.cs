using CreditcardVerification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditcardVerification
{
    /// <summary>
    /// 國泰世華銀行工廠
    /// </summary>
    public class CathayBankFactory : IBankFactory
    {
        /// <summary>
        /// 產生驗證銀行
        /// </summary>
        /// <returns> 國泰世華銀行</returns>
        public IBank VerificationCard()
        {
            return new CathayBank();
        }
    }
}