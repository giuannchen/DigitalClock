using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Aabstract
{
    /// <summary>
    /// 生產武器的抽像類別
    /// </summary>
    internal abstract class Arms
    {
        /// <summary>
        /// 生產武器
        /// </summary>
        /// <returns>武器</returns>
        public abstract string MakeArms();
    }
}