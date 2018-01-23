using CosplayBuilder.Aabstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Pokemon
{
    /// <summary>
    /// 魔獸武器
    /// </summary>
    internal class WarArms : Arms
    {
        /// <summary>
        /// 製造武器
        /// </summary>
        /// <returns>回傳武器訊息</returns>
        public override string MakeArms()
        {
            return "魔獸武器";
        }
    }
}