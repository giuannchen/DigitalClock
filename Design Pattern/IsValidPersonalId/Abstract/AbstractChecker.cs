using IsValidPersonalId.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsValidPersonalId.Aabstract
{
    /// <summary>
    /// 抽象型別
    /// </summary>
    internal abstract class AbstractChecker : IChecker
    {
        /// <summary>
        /// 檢查器
        /// </summary>
        protected IChecker nextChecker;

        /// <summary>
        /// 抽象檢查
        /// </summary>
        /// <param name="personalId">身份證字號</param>
        /// <returns>檢查結果</returns>
        public abstract bool Check(string personalId);

        /// <summary>
        /// 替換檢查器
        /// </summary>
        /// <param name="checker">想要換的檢查器</param>
        /// <returns>已變更的檢查器</returns>
        public IChecker SetNextCheck(IChecker checker)
        {
            return this.nextChecker = checker;
        }

    }
}