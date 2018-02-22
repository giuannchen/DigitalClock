using IsValidPersonalId.Aabstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsValidPersonalId
{
    /// <summary>
    /// 長度檢查
    /// </summary>
    class LengthChecker : AbstractChecker
    {
        /// <summary>
        /// 覆寫檢查
        /// </summary>
        /// <param name="personalId">身份證字號</param>
        /// <returns>檢查結果</returns>
        public override bool Check(string personalId)
        {           
            bool CheckLength = false;            
            if (personalId.Length == 10)            
              CheckLength = true;

            return CheckLength;
        }
    }
}
