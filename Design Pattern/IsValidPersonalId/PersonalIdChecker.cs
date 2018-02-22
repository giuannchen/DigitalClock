using IsValidPersonalId.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsValidPersonalId
{
    /// <summary>
    /// 身分證檢查
    /// </summary>
    class PersonalIdChecker
    {
        public IChecker IChecker
        {
            get => default(IChecker);
            set
            {
            }
        }

        /// <summary>
        /// 檢查身分證字號是否正確
        /// </summary>
        /// <param name="personalId">身份證字號</param>
        /// <returns>檢查結果</returns>
        public bool CheckPersonalId(string personalId)
        {
            bool CheckId = false;
            IChecker Checker = new FirstWordChecker();
            CheckId = Checker.Check(personalId);
            Checker=Checker.SetNextCheck(new LengthChecker());
            CheckId = CheckId && Checker.Check(personalId);
            Checker=Checker.SetNextCheck(new NumberSumChecker());
            CheckId = CheckId && Checker.Check(personalId);
            return CheckId;

        }
    }
}
