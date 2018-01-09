using CreditcardVerification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditcardVerification
{
    /// <summary>
    /// NCCC銀行工廠
    /// </summary>
    public class NcccBankFactory : IBankFactory
    {
        /// <summary>
        /// 產生驗證銀行
        /// </summary>
        /// <returns> NCCC銀行</returns>
        public IBank VerificationCard()
        {
            return new NcccBank();
        }
    }
}