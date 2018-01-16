using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Aabstract
{
    /// <summary>
    /// 生產盔甲的抽像類別
    /// </summary>
    internal abstract class Armor
    {
        /// <summary>
        /// 生產盔甲
        /// </summary>
        /// <returns>盔甲</returns>
        public abstract string MakeArmor();
    }
}