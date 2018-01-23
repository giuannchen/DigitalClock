using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Aabstract
{
    /// <summary>
    /// 生產靴子的抽像類別
    /// </summary>
    internal abstract class Boots
    {
        /// <summary>
        /// 生產靴子
        /// </summary>
        /// <returns>靴子</returns>
        public abstract string MakeBoots();
    }
}