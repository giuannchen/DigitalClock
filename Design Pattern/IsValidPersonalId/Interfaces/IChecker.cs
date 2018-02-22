using System;

namespace IsValidPersonalId.Interfaces
{
    /// <summary>
    /// 檢查程式庫
    /// </summary>
    public interface IChecker
    {
        /// <summary>
        /// 抽出共用的檢查
        /// </summary>
        /// <param name="personalId">身份證字號</param>
        /// <returns>檢查結果</returns>
        bool Check(string personalId);

        /// <summary>
        /// 替換檢查器
        /// </summary>
        /// <param name="checker">想要換的檢查器</param>
        /// <returns>已變更的檢查器</returns>
        IChecker SetNextCheck(IChecker checker);


    }
}