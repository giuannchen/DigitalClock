using CosplayBuilder.Aabstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Pokemon
{
    /// <summary>
    /// 魔獸帽子
    /// </summary>
    internal class WarHat : Hat
    {
        /// <summary>
        /// 製造帽子
        /// </summary>
        /// <returns>回傳帽子訊息</returns>
        public override string MakeHat()
        {
            return "魔獸帽子";
        }
    }
}