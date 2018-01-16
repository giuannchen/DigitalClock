using CosplayBuilder.Aabstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Pokemon
{
    /// <summary>
    /// 魔獸頭盔
    /// </summary>
    internal class WarArmor : Armor
    {
        /// <summary>
        /// 製造頭盔
        /// </summary>
        /// <returns>回傳頭盔訊息</returns>
        public override string MakeArmor()
        {
            return "魔獸頭盔";
        }
    }
}