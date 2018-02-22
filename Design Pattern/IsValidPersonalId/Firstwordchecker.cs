using IsValidPersonalId.Aabstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsValidPersonalId
{
    /// <summary>
    /// 第一個字母檢查
    /// </summary>
    class FirstWordChecker : AbstractChecker
    {
        /// <summary>
        /// 覆寫檢查
        /// </summary>
        /// <param name="personalId">身份證字號</param>
        /// <returns>檢查結果</returns>
        public override bool Check(string personalId)
        {
            //將身分證字號英文改為大寫
            personalId = personalId.ToUpper(); 
            List<string> FirstEng =
            new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "J",
                               "K", "L", "M", "N", "P", "Q", "R", "S", "T",
                               "U", "V", "X", "Y", "W", "Z", "I", "O" };
            bool CheckFirstEnd = false;
            for (int x = 0; x < FirstEng.Count; x++)
            {
                if (personalId.Substring(0, 1) == FirstEng[x])
                {
                    CheckFirstEnd = true;
                    break;
                }
            }
            return CheckFirstEnd;
        }
    }
}
